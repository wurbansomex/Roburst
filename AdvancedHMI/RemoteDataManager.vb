Imports Somex.Roburst.Integration.Common
Imports Somex.Roburst.Integration.Sockets
Imports log4net

''' <summary>
''' Manages the current mode of operation.
''' </summary>
''' <remarks></remarks>
Public Class RemoteDataManager


    Public Enum MachineStates
        Rdy
        Busy
        Fault
        Stopped
    End Enum


    Private _currentMode As ModesOfOperation
    Private _machineState As MachineStates
    Private _connectionManager1Channel As CommunicationsManager
    Private _connectionManager2Channel As CommunicationsManager
    Private _messageBuilder As IMessageBuilder
    Private _agrMessageBuilder1Channel As AgrMessageBuilder
    Private _agrMessageBuilder2Channel As AgrMessageBuilder
    Private _alarmManager As AlarmManager
    Private _plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom
    Private _comType As TypeOfCommunication
    Shared _log As ILog = LogManager.GetLogger(GetType(RemoteDataManager))
    Private WithEvents _timerCavityTimeout As System.Timers.Timer

    Private _mouldNumberSaved As Integer
    Private _maxPressureSaved As Decimal
    Private _burstSaved As Boolean
    Private _isResultValidSaved As Boolean

#Region "Properties"

    Public Property CurrentMode As ModesOfOperation

        Get
            Return _currentMode
        End Get

        Set(value As ModesOfOperation)
            _currentMode = value
        End Set

    End Property

    Public Property CurrentMachineState As MachineStates
        Get
            Return _machineState
        End Get
        Set(value As MachineStates)
            _machineState = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Constructor for claass. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom, alarmManager As AlarmManager)

        Try
            Me._plcDriver = plcDriver
            Me._alarmManager = alarmManager

            ' read the port number from the PLC
            Dim portNumberData As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionPort", plcDriver)
            Dim ipAddressData As String = PlcDriverUtilities.ReadPLCValue(Of String)("RemoteConnectionIP", plcDriver)
            Dim receiveDataTimeoutData As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionTimeout", plcDriver)
            _comType = PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionType", plcDriver)

            Dim portNumberPolling As Integer = portNumberData + 1
            Dim ipAddressPolling As String = ipAddressData
            Dim receiveDataTimeoutPolling As Integer = receiveDataTimeoutData

            _currentMode = ModesOfOperation.local
            _connectionManager1Channel = New CommunicationsManager(ipAddressData, portNumberData, receiveDataTimeoutData, _comType)
            _connectionManager2Channel = New CommunicationsManager(ipAddressPolling, portNumberPolling, receiveDataTimeoutPolling, _comType)
            _messageBuilder = New iAFISMessageXmlBuilder()
            _agrMessageBuilder1Channel = New AgrMessageBuilder()
            _agrMessageBuilder2Channel = New AgrMessageBuilder()
            _machineState = MachineStates.Rdy
            _timerCavityTimeout = New System.Timers.Timer()
            _timerCavityTimeout.Interval = receiveDataTimeoutData

            AddHandler _connectionManager1Channel.MessageReceived, AddressOf SocketMessageRecieved1Channel
            AddHandler _connectionManager1Channel.MessageProcessingError, AddressOf MessageProcessingErrorHandler

            AddHandler _connectionManager2Channel.MessageReceived, AddressOf SocketMessageRecieved2Channel
            AddHandler _connectionManager2Channel.MessageProcessingError, AddressOf MessageProcessingErrorHandler

            AddHandler _timerCavityTimeout.Elapsed, AddressOf OntimerCavityTimeout

        Catch ex As Exception
            _log.Error(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ErrorCreatingRemoteDataManager) & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
        End Try

    End Sub


    ''' <summary>
    ''' If invalid data arrives from remote clients then
    ''' we need to handle it. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MessageProcessingErrorHandler()

        Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)

    End Sub

    ''' <summary>
    ''' The remote client can request the status of the machine and also for the machine
    ''' to change mode. This sub handles incoming messages. 
    ''' </summary>
    ''' <param name="message"></param>
    ''' <remarks></remarks>
    Private Sub SocketMessageRecieved1Channel(message As IMessage)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Select Case message.MessageType

            Case MessageType.StatusRequest
                Me.SendStatusResponse()

            Case MessageType.ModeChangeRequest
                Me.HandleModeChangeRequest(CType(message, ModeChangeRequestMessage))

            Case MessageType.SampleSetResponse
                Me.ProcessMouldSetResponseMessage(CType(message, MouldSetResponseMessage))

            Case MessageType.SampleSetWithProfileDetailResponse
                Me.ProcessMouldSetResponseMessage(CType(message, MouldSetResponseMessage))
                ''
                '' AGR Messages
                ''
            Case MessageType.NAckMessage
                _log.Debug("NAK Channel 1")
                Me.ProcessNAckMessage(CType(message, AgrNAckMessage))

            Case MessageType.ChannelStatusRequest
                Me.ProcessChannelStatus(CType(message, AgrChannelStatusRequest))

            Case Else
                _log.Debug("Unsupported message channel 1")
        End Select

    End Sub

    Private Sub SocketMessageRecieved2Channel(message As IMessage)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Select Case message.MessageType

            Case MessageType.StatusRequest
                Me.SendStatusResponse(True)

            Case MessageType.ModeChangeRequest
                Me.HandleModeChangeRequest(CType(message, ModeChangeRequestMessage), True)
                ''
                '' AGR messages
                ''
            Case MessageType.NAckMessage
                _log.Debug("NAK Channel 2")
                Me.ProcessNAckMessage(CType(message, AgrNAckMessage))

            Case MessageType.ChannelStatusRequest
                Me.ProcessChannelStatus(CType(message, AgrChannelStatusRequest), True)

            Case Else
                _log.Debug("Unsupported message channel 2")

        End Select



    End Sub


    ''' <summary>
    ''' Starts listening for data
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub StartCommunications()

        Dim actionData As Action = Sub()

                                       If (Not _connectionManager1Channel Is Nothing) Then _connectionManager1Channel.Start()

                                   End Sub

        actionData.BeginInvoke(Nothing, Nothing)


        Dim actionPolling As Action = Sub()

                                          If (Not _connectionManager2Channel Is Nothing) Then _connectionManager2Channel.Start()

                                      End Sub

        actionPolling.BeginInvoke(Nothing, Nothing)

    End Sub

    Public Sub StopCommunications()
        _connectionManager1Channel.Stop()
        _connectionManager2Channel.Stop()
    End Sub


    Private Sub HandleModeChangeRequest(message As ModeChangeRequestMessage, Optional Channel2 As Boolean = False)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        ' check what the mode change requet is 
        Dim newMode As ModesOfOperation = message.Mode

        ' write the new mode to the PLC
        If (newMode = ModesOfOperation.auto Or newMode = ModesOfOperation.semi) Then
            PlcDriverUtilities.PulsePlcTag("hmi_remote", True, Me._plcDriver)
        Else
            PlcDriverUtilities.PulsePlcTag("hmi_local", True, Me._plcDriver)
        End If

        ' update the mode
        Me.CurrentMode = newMode

        ' send status back, even if we didn't change the mode
        Me.SendStatusResponse(Channel2)

    End Sub

    Public Sub SendStatusResponse(Optional Channel2 As Boolean = False)

        If (Not IsRemoteCommunicationsEnabled()) Then Return


        Try
            Dim status As String = String.Empty
            Dim state As String = "fault"
            If (Me.CurrentMachineState = MachineStates.Rdy) Then
                status = "000"
                state = "rdy"
            ElseIf Me.CurrentMachineState = MachineStates.Busy Then
                status = "001"
                state = "busy"
            ElseIf (Me.CurrentMachineState = MachineStates.Fault) Then
                status = "002"
                state = "fault"
            ElseIf (Me.CurrentMachineState = MachineStates.Stopped) Then
                status = "003"
                state = "busy"
            End If

            Dim statusReponseMessage As New StatusResponseMessage()
            statusReponseMessage.Mode = Me.CurrentMode.ToString().ToLower()
            statusReponseMessage.Status = state
            statusReponseMessage.Reason = status
            Dim xml As String = _messageBuilder.BuildXmlFor(statusReponseMessage)
            xml += Environment.NewLine 'eol terminating characters CR-LF

            If (Not Channel2) Then
                _connectionManager1Channel.SendData(xml, False) ' send and don't wait for response
            Else
                _connectionManager2Channel.SendData(xml, False) ' send and don't wait for response
            End If

        Catch ex As Exception
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.DataTransmitFailed)
        End Try

    End Sub


    ''' <summary>
    ''' Request a single mould number from the line controller and send recipe acknowledgement in responsse. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RequestMouldSample()

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        If _comType = TypeOfCommunication.SerialOverTCP Then
            RequestMouldSampleAgr()
        Else
            RequestMouldSampleiAFIS()
        End If

    End Sub

    Public Sub RequestSet()
        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try

            Dim setRequest As New MouldSetRequestMessage()
            Dim xml As String = _messageBuilder.BuildXmlFor(setRequest)
            xml += Environment.NewLine 'eol terminating characters CR-LF
            Dim responseData As String = _connectionManager1Channel.SendData(xml, False) ' send and wait for response
            _log.Debug("<sampreq/> Request Mould Number command sent")
        Catch
            _log.Error("Error requesting set")
        End Try

    End Sub

    Private Sub RequestMouldSampleiAFIS()

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Dim wasRequestSuccessful As Boolean

        Try

            Dim mouldRequest As New MouldNumberRequestMessage()
            Dim xml As String = _messageBuilder.BuildXmlFor(mouldRequest)
            xml += Environment.NewLine 'eol terminating characters CR-LF
            Dim responseData As String = _connectionManager1Channel.SendData(xml, True) ' send and wait for response
            _log.Debug("<sampreq/> Request Mould Number command sent")


            'build message from response acknowledgement
            Dim mouldNumberResponse As MouldNumberResponseMessage = CType(iAFISXmlMessageParser.CreateMessage(responseData), MouldNumberResponseMessage)

            '
            ' check the profile number, if it's 0 then  what's returned is a this is a MouldNumberWithProfileDetailResponseMessage message
            If (mouldNumberResponse.ProfileNumber = "0") Then

                _log.Info("Profile number is 0, loading profile parameters")
                ' 
                Dim mouldNumberWithProfile As MouldNumberWithProfileDetailResponseMessage = TryCast(mouldNumberResponse, MouldNumberWithProfileDetailResponseMessage)
                If (Not mouldNumberWithProfile Is Nothing) Then
                    ProfileManager.LoadProfileInPLC(mouldNumberWithProfile.ProfileDetails, Me._plcDriver)
                Else
                    ' force an alarm high by throwing exception
                    Throw New ApplicationException("Could not convert response from iAFIS to MouldNumberWithProfileDetailResponseMessage")
                End If
            Else
                ' set the profile number  and load it by pulsing load tag. 
                If (mouldNumberResponse.ProfileNumber <> "-1") Then
                    ' get back a matching profile and load it
                    Dim matchingProfile As ProfileDetails = ProfileManager.GetProfileForNumber(mouldNumberResponse.ProfileNumber)
                    If (Not matchingProfile Is Nothing) Then
                        ProfileManager.LoadProfileInPLC(matchingProfile, Me._plcDriver)

                    Else
                        Throw New ApplicationException("No matching profile found in xml file for profile number " & mouldNumberResponse.ProfileNumber)
                    End If
                End If

            End If


            ' set the mould number quantity to 1 in the PLC and pulse the entry tag
            PlcDriverUtilities.WritePlcValue("ContCountEnter", 1, Me._plcDriver)
            PlcDriverUtilities.WritePlcValue("MEnter0", mouldNumberResponse.MouldNumber, Me._plcDriver)
            PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)


            wasRequestSuccessful = True ' don't care if the ack. fails as we've transferred the mould number and won't be rolling back

            ' acknowleddge reciept of the mould and profile numbers
            Me.AcknowledgeSampleReceived(mouldNumberResponse.MouldNumber, mouldNumberResponse.ProfileNumber)

        Catch parseEx As MessageParseException
            _log.Error("Error requesting mould sample, message parse error: " & parseEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error("Error requesting mould sample, communications timeout: " & timeout.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch remoteClientEx As NoRemoteClientConnectedException
            _log.Error("Error requesting mould sample, no remote client: " & remoteClientEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch ex As Exception
            _log.Error("Error requesting mould sample, exception: " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Finally

            ' if the mould number was not set then send the default mould number
            ' to the PLC. 
            If (Not wasRequestSuccessful) Then

                Dim defaultMouldNumber As String = PlcDriverUtilities.ReadPLCValue(Of String)("RemoteConnectionDefaultMouldNumber", Me._plcDriver)
                'Dim defaultMouldNumber As String = "127"
                PlcDriverUtilities.WritePlcValue("ContCountEnter", 1, Me._plcDriver)
                PlcDriverUtilities.WritePlcValue("MEnter0", defaultMouldNumber, Me._plcDriver)
                PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)
            End If

        End Try

    End Sub



    ''' <summary>
    ''' Handles mould set message from iAFIS
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ProcessMouldSetResponseMessage(mouldSetResponse As MouldSetResponseMessage)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try

            ' we need to check the number of available slots versus the number returned in the set
            Dim freeSlot As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me._plcDriver)
            If (mouldSetResponse.SetQuantity > freeSlot) Then

                ' throw new alarm so we 
                _log.Error(String.Format("Quantity in set {0} exceeds free slot quantity {1}", mouldSetResponse.SetQuantity, freeSlot))
                _alarmManager.ActivateAlarmBit(HMISourceAlarms.NotEnoughFreeSlots)
                Return

            End If

            ' check what the profile number is, profile 0 reserved for messages with profile parameters included
            If (mouldSetResponse.Profile = "0") Then

                _log.Info("Profile number is 0, loading profile parameters")

                ' convert to MouldSetResponse to MouldSetWithProfileDetailsResponseMessage
                Dim mouldSetWithProfile As MouldSetWithProfileDetailsResponseMessage = TryCast(mouldSetResponse, MouldSetWithProfileDetailsResponseMessage)
                If (Not mouldSetWithProfile Is Nothing) Then
                    ProfileManager.LoadProfileInPLC(mouldSetWithProfile.ProfileDetails, Me._plcDriver)
                Else
                    ' force an alarm high by throwing exception
                    Throw New ApplicationException("Could not convert response from iAFIS to MouldSetWithProfileDetailsResponseMessage message")
                End If

            Else
                ' rev 1.0.0.0.18 update profile number for positive numbers only. 
                If (mouldSetResponse.Profile <> "-1") Then

                    ' get back a matching profile and load it
                    Dim matchingProfile As ProfileDetails = ProfileManager.GetProfileForNumber(mouldSetResponse.Profile)
                    If (Not matchingProfile Is Nothing) Then
                        ProfileManager.LoadProfileInPLC(matchingProfile, Me._plcDriver)

                    Else
                        Throw New ApplicationException("No matching profile found in xml file for profile number " & mouldSetResponse.Profile)
                    End If

                End If

            End If

            ' set the mould number quantity in the PLC and pulse the entry tag
            PlcDriverUtilities.WritePlcValue("ContCountEnter", mouldSetResponse.SetQuantity, Me._plcDriver)
            ' populate an MEnterX tag for each mould in the list
            Dim mouldTagNumber As Integer = 0
            For Each mouldNumber As String In mouldSetResponse.MouldNumbers
                PlcDriverUtilities.WritePlcValue("MEnter" & mouldTagNumber, mouldNumber, Me._plcDriver)
                mouldTagNumber += 1
            Next

            ' acknowledge the entry operation
            PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)

            ' acknowleddge reciept of the mould and profile numbers
            Me.AcknowledgeSetReceived(mouldSetResponse.MouldNumbers, mouldSetResponse.Profile, mouldSetResponse.SetNumber)


        Catch parseEx As MessageParseException
            _log.Error("Error requesting mould set, message parse error: " & parseEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error("Error requesting mould set, communications timeout: " & timeout.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch remoteClientEx As NoRemoteClientConnectedException
            _log.Error("Error requesting mould set, no remote client: " & remoteClientEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch ex As Exception
            _log.Error("Error requesting mould set, exception: " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        End Try


    End Sub




    ''' <summary>
    ''' Sends ack mesasge back to remote client with the mould number and profile number
    ''' </summary>
    ''' <param name="mouldNumber"></param>
    ''' <param name="profileNumber"></param>
    ''' <remarks></remarks>
    Public Sub AcknowledgeSampleReceived(mouldNumber As String, profileNumber As String)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try

            If (_connectionManager1Channel Is Nothing) Then
                Throw New ApplicationException("ConnectionManager is nothing. Aborting")
            End If

            Dim sampleAck As New MouldNumberAcknowledgeMessage()
            sampleAck.MouldNumber = mouldNumber
            sampleAck.ProfileNumber = profileNumber

            Dim xml As String = _messageBuilder.BuildXmlFor(sampleAck)
            xml += Environment.NewLine 'eol terminating characters CR-LF
            _connectionManager1Channel.SendData(xml, waitForResponse:=False)


        Catch ex As Exception
            _log.Error("Error sending Sample Acknowledgement data, " + ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.DataTransmitFailed)
        End Try

    End Sub

    ''' <summary>
    ''' Sends ack mesasge back to remote client with the mould set and profile number
    ''' in response to a Mould Set request. 
    ''' </summary>
    ''' <param name="moulds"></param>
    ''' <param name="profileNumber"></param>
    ''' <remarks></remarks>
    Public Sub AcknowledgeSetReceived(moulds As List(Of String), profileNumber As String, setNumber As String)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try

            If (_connectionManager1Channel Is Nothing) Then
                Throw New ApplicationException("ConnectionManager is nothing. Aborting.")
            End If

            Dim sampleAck As New MouldSetAcknowledgeMessage()
            sampleAck.MouldNumbers = moulds
            sampleAck.Profile = profileNumber
            sampleAck.SetNumber = setNumber
            sampleAck.SetQuantity = moulds.Count

            Dim xml As String = _messageBuilder.BuildXmlFor(sampleAck)
            xml += Environment.NewLine 'eol terminating characters CR-LF
            Dim responseData As String = _connectionManager1Channel.SendData(xml, waitForResponse:=False)


        Catch ex As Exception
            _log.Error("Error sending set ack message, " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.DataTransmitFailed)
        End Try

    End Sub


    ''' <summary>
    ''' Transmits test result to line controller
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SendTestResult(testNumber As Integer, testDate As String, testTime As String, testID As String,
                              mouldNumber As Integer, maxPressure As Decimal, burst As Boolean, profileNo As String,
                              profileName As String, profileUnits As Integer, profilePress1Min As Boolean, profileSp1 As Single,
                              profileRamp1 As Single, profileDwellTime1 As Integer,
                              profileSP2 As Single, profileRamp2 As Single,
                              profileDwellTime2 As Integer, isResultValid As Boolean)

        If _comType = TypeOfCommunication.SerialOverTCP Then
            SendTestResultAgr(mouldNumber, maxPressure, burst, isResultValid)
            _mouldNumberSaved = mouldNumber
            _maxPressureSaved = maxPressure
            _burstSaved = burst
            _isResultValidSaved = isResultValid

        Else
            SendTestResultiAFIS(testNumber, testDate, testTime, testID, mouldNumber, maxPressure, burst, profileNo,
                              profileName, profileUnits, profilePress1Min, profileSp1, profileRamp1, profileDwellTime1,
                              profileSP2, profileRamp2, profileDwellTime2, isResultValid)
        End If


    End Sub

    Private Sub SendTestResultiAFIS(testNumber As Integer, testDate As String, testTime As String, testID As String,
                            mouldNumber As Integer, maxPressure As Decimal, burst As Boolean, profileNo As String,
                            profileName As String, profileUnits As Integer, profilePress1Min As Boolean, profileSp1 As Single,
                            profileRamp1 As Single, profileDwellTime1 As Integer,
                            profileSP2 As Single, profileRamp2 As Single,
                            profileDwellTime2 As Integer, isResultValid As Boolean)
        Try

            If (Not IsRemoteCommunicationsEnabled()) Then Return

            If (_connectionManager1Channel Is Nothing) Then
                Throw New ApplicationException("ConnectionManager is nothing")
            End If

            Dim resultMsg As New TestResultMessage()
            resultMsg.ID = testNumber
            resultMsg.DidBurst = burst
            resultMsg.IsResultValid = isResultValid
            resultMsg.MaxPressure = maxPressure
            resultMsg.Mould = mouldNumber

            If profileUnits = 0 Then
                resultMsg.PressureUnit = "barg"
                resultMsg.MaxPressure = Math.Round(resultMsg.MaxPressure, 2)
            ElseIf profileUnits = 1 Then
                resultMsg.PressureUnit = "psi"
                resultMsg.MaxPressure = Math.Round(resultMsg.MaxPressure, 1)
            Else
                resultMsg.PressureUnit = "kg/cm^2"
            End If

            resultMsg.PressureValue = IIf(profilePress1Min, "1mineqv", "act")
            resultMsg.Profile = profileNo
            resultMsg.Time = DateTime.Now.ToString("yyyy-mm-ddThh:mm:ss")
            resultMsg.TestPressureList = New List(Of Double) From {profileSp1, profileSP2}
            resultMsg.TestRampList = New List(Of Double) From {profileRamp1, profileRamp2}
            resultMsg.TestDwellTimeList = New List(Of Double) From {profileDwellTime1, profileDwellTime2}

            Dim xml As String = _messageBuilder.BuildXmlFor(resultMsg)
            xml += Environment.NewLine
            _connectionManager1Channel.SendData(xml, waitForResponse:=False)

        Catch remoteEx As NoRemoteClientConnectedException
            _log.Error(String.Format("Error sending test number {0} result, Error:", testNumber, remoteEx.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        Catch parseEx As MessageParseException
            _log.Error(String.Format("Error sending test number {0} result, Error:", testNumber, parseEx.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error(String.Format("Error sending test number {0} result, Error:", testNumber, timeout.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        Catch ex As Exception
            _log.Error(String.Format("Error sending test number {0} result, Error:", testNumber, ex.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        End Try

    End Sub

    ''' <summary>
    ''' Queries PLC for status of the 'RemoteConnectionEnable' status bit
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsRemoteCommunicationsEnabled()

        Dim isEnabled = False

        Try
            isEnabled = PlcDriverUtilities.ReadPLCValue(Of Boolean)("RemoteConnectionEnable", Me._plcDriver)
        Catch ex As Exception
            _log.Error("Error while checking if remote communications is enabled, " & ex.ToString())
        End Try

        Return isEnabled

    End Function


#Region "AgrMessages"
    ''' <summary>
    ''' Request number for bottle from agr supervisor, in response get ack or nak
    ''' if nak try again with correct message sequence
    ''' if ack, start timer and prepare for bottle number from supervisory system
    ''' </summary>
    ''' <param name="seqNum"></param>
    ''' <remarks></remarks>
    Public Sub RequestMouldSampleAgr(Optional seqNum As Integer = -1)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Dim wasRequestSuccessful As Boolean

        Try
            Dim messageToSend As Byte()
            Dim messageOk As Boolean = False
            Dim repeats As Integer = 0


            messageToSend = _agrMessageBuilder1Channel.BuildForSerial(New AgrCavityNumberDataRequest())


            ' Send and check response, if responsetype!=ack send again with correct sequence number
            Do Until messageOk Or repeats > 1

                Dim messageReceived As Byte() = _connectionManager1Channel.SendData(messageToSend, True)
                Dim messageReceivedParsed As IMessage = AgrMessageParser.CreateMessage(messageReceived)

                If messageReceivedParsed.MessageType = MessageType.CavityNumberInputData Then
                    Me.ProcessCavityInputData(CType(messageReceivedParsed, AgrCavityNumberInputData))
                    messageOk = True
                    _log.Debug("Cavity received, try " & repeats)
                Else
                    _log.Debug("Cavity not available, try " & repeats)
                End If

                repeats = repeats + 1
            Loop


            wasRequestSuccessful = messageOk

        Catch parseEx As MessageParseException
            _log.Error("Error requesting mould sample, message parse error: " & parseEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error("Error requesting mould sample, communications timeout: " & timeout.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch remoteClientEx As NoRemoteClientConnectedException
            _log.Error("Error requesting mould sample, no remote client: " & remoteClientEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Catch ex As Exception
            _log.Error("Error requesting mould sample, exception: " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldFailed)
        Finally

            ' if the mould number was not set then send the default mould number
            ' to the PLC. 
            If (Not wasRequestSuccessful) Then

                Dim defaultMouldNumber As String = PlcDriverUtilities.ReadPLCValue(Of String)("RemoteConnectionDefaultMouldNumber", Me._plcDriver)
                'Dim defaultMouldNumber As String = "127"
                PlcDriverUtilities.WritePlcValue("ContCountEnter", 1, Me._plcDriver)
                PlcDriverUtilities.WritePlcValue("MEnter0", defaultMouldNumber, Me._plcDriver)
                PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)
            End If

        End Try

    End Sub
    ''' <summary>
    ''' Write bottle number to plc and confirm
    ''' </summary>
    ''' <param name="mouldSetResponse"></param>
    ''' <remarks></remarks>
    Public Sub ProcessCavityInputData(mouldSetResponse As AgrCavityNumberInputData)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try

            ' we need to check the number of available slots versus the number returned in the set
            Dim freeSlot As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me._plcDriver)
            If (freeSlot = 0) Then

                ' throw new alarm so we 
                _log.Error(String.Format("No free slots for a new request"))
                _alarmManager.ActivateAlarmBit(HMISourceAlarms.NotEnoughFreeSlots)
                Return

            End If

            ' set the mould number quantity in the PLC and pulse the entry tag
            PlcDriverUtilities.WritePlcValue("ContCountEnter", 1, Me._plcDriver)
            PlcDriverUtilities.WritePlcValue("MEnter0", mouldSetResponse.CavityNumber, Me._plcDriver)

            ' acknowledge the entry operation
            PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)

            ' acknowledge
            Me.AckCavityNumberReceived(mouldSetResponse)


        Catch parseEx As MessageParseException
            _log.Error("Error requesting mould set, message parse error: " & parseEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.MessageParseError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error("Error requesting mould set, communications timeout: " & timeout.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch remoteClientEx As NoRemoteClientConnectedException
            _log.Error("Error requesting mould set, no remote client: " & remoteClientEx.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        Catch ex As Exception
            _log.Error("Error requesting mould set, exception: " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RequestMouldSetFailed)
        End Try


    End Sub

    ''' <summary>
    ''' Send results, wait for response
    ''' if nak and less than 2 repeats try to send again with sequence number from nak
    ''' </summary>
    ''' <param name="mouldNumber"></param>
    ''' <param name="maxPressure"></param>
    ''' <param name="burst"></param>
    ''' <param name="isResultValid"></param>
    ''' <param name="statusRequest"></param>
    ''' <remarks></remarks>
    Private Sub SendTestResultAgr(mouldNumber As Integer, maxPressure As Decimal, burst As Boolean, isResultValid As Boolean, Optional statusRequest As Boolean = False)
        Try
            If (Not IsRemoteCommunicationsEnabled()) Then Return

            If (_connectionManager2Channel Is Nothing) Then
                Throw New ApplicationException("ConnectionManager is nothing")
            End If

            Dim messageToSend As Byte()
            Dim messageOk As Boolean = False
            Dim repeats As Integer = 0

            'check end of stroke alarm
            'Dim endStrokeAlarmActive = (From alarm In _alarmManager.SystemAlarms
            'Where alarm.BitPosition = 12 And alarm.Condition = AlarmCondition.Active).Count() > 0

            Dim endStrokeAlarmActive = PlcDriverUtilities.ReadPLCValue(Of Boolean)("St.Test.Status.4", Me._plcDriver)
            Dim alarmCriticalActive = PlcDriverUtilities.ReadPLCValue(Of Boolean)("Alarms_CriticalActive", Me._plcDriver)
            Dim carouselNotIndexing = (From alarm In _alarmManager.SystemAlarms
            Where alarm.BitPosition = 84 And alarm.Condition = AlarmCondition.Active).Count() > 0

            'check if send with already prepared sequence number

            messageToSend = _agrMessageBuilder2Channel.BuildForSerial(
                New AgrPressureTestOutput(mouldNumber, maxPressure, burst, isResultValid, endStrokeAlarmActive, carouselNotIndexing, alarmCriticalActive, statusRequest))

            Do Until (messageOk Or repeats > 1)

                Dim messageReceived As Byte() = _connectionManager2Channel.SendData(messageToSend, True)
                Dim messageReceivedType As MessageType = checkAckType(messageReceived, messageToSend)

                If messageReceivedType = MessageType.AckMessage Then
                    messageOk = True
                    _log.Debug("Tests sent, try: " & repeats)
                Else
                    _log.Debug("Tests not sent, try: " & repeats)
                End If

                repeats = repeats + 1
            Loop



        Catch remoteEx As NoRemoteClientConnectedException
            _log.Error(String.Format("Error sending mould number {0} result, Error:", mouldNumber, remoteEx.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoRemoteClientConnected)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        Catch timeout As RemoteReadDataTimeoutException
            _log.Error(String.Format("Error sending mould number {0} result, Error:", mouldNumber, timeout.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteDataReadTimeout)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        Catch ex As Exception
            _log.Error(String.Format("Error sending mould number {0} result, Error:", mouldNumber, ex.ToString()))
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.TestResultTransmitFailed)
        End Try

    End Sub

    ''' <summary>
    ''' Send ack
    ''' </summary>
    ''' <param name="mouldSetResponse"></param>
    ''' <remarks></remarks>
    Private Sub AckCavityNumberReceived(mouldSetResponse As AgrCavityNumberInputData)

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try
            Dim messageToSend As Byte() = _agrMessageBuilder1Channel.BuildForSerial(
                New AgrAckMessage(mouldSetResponse.SequenceNumber, mouldSetResponse.CommandCode))

            If (_connectionManager1Channel Is Nothing) Then
                Throw New ApplicationException("ConnectionManager is nothing. Aborting")
            End If

            _connectionManager1Channel.SendData(messageToSend)

        Catch ex As Exception
            _log.Error("Error sending Sample Acknowledgement data, " + ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.DataTransmitFailed)
        End Try
    End Sub

    ''' <summary>
    ''' Send channnel status
    ''' </summary>
    ''' <param name="message"></param>
    ''' <remarks></remarks>
    Private Sub ProcessChannelStatus(message As AgrChannelStatusRequest, Optional Channel2 As Boolean = False)

        Dim messageToSend As Byte()
        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Try



            If (Not Channel2) Then
                messageToSend = _agrMessageBuilder1Channel.BuildForSerial(New AgrAckMessage(message.SequenceNumber, message.CommandCode))
                If (_connectionManager1Channel Is Nothing) Then
                    Throw New ApplicationException("ConnectionManager is nothing. Aborting")
                End If
                _connectionManager1Channel.SendData(messageToSend)
            Else
                messageToSend = _agrMessageBuilder2Channel.BuildForSerial(New AgrAckMessage(message.SequenceNumber, message.CommandCode))
                _connectionManager2Channel.SendData(messageToSend)
                Me.SendTestResultAgr(0, _maxPressureSaved, False, True, True)
                If (_connectionManager2Channel Is Nothing) Then
                    Throw New ApplicationException("ConnectionManager is nothing. Aborting")
                End If

            End If



        Catch ex As Exception
            _log.Error("Error sending Sample Acknowledgement data, " + ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.DataTransmitFailed)
        End Try
    End Sub

    ''' <summary>
    ''' If nak message received
    ''' </summary>
    ''' <param name="message"></param>
    ''' <remarks></remarks>
    Private Sub ProcessNAckMessage(message As AgrNAckMessage)

        Select Case message.RequestedCommandCode
            Case &H34 'data request
                Me.RequestMouldSampleAgr(message.RequestedSequenceNumber)
                Return
            Case &H31 ' Pressure test resutls
                Me.SendTestResultAgr(_mouldNumberSaved, _maxPressureSaved, _burstSaved, _isResultValidSaved, message.RequestedSequenceNumber)
                Return
        End Select




    End Sub

    Private Function checkAckType(messageReceived As Byte(), messageSent As Byte())

        Dim message As IMessage = AgrMessageParser.CreateMessage(messageReceived) ' parse bytes to Imessage

        If message.MessageType = MessageType.AckMessage Then ' check type
            Dim messageConverted As AgrAckMessage = CType(message, AgrAckMessage) ' convert type
            'If messageConverted.RequestedCommandCode = messageSent(1) And (messageConverted.RequestedSequenceNumber = messageSent(2)) Then ' if data is as requested return true
            If messageConverted.RequestedCommandCode = messageSent(1) Then ' if data is as requested return true
                Return message.MessageType
            End If
        ElseIf message.MessageType = MessageType.NAckMessage Then ' check type
            Dim messageConverted As AgrNAckMessage = CType(message, AgrNAckMessage) ' convert type
            If messageConverted.RequestedCommandCode = messageSent(1) Then ' if data is as requested return true
                Return message.MessageType
            End If
        End If

        Return MessageType.Unknown
    End Function

    Private Sub OntimerCavityTimeout(sender As Object, e As EventArgs)
        _timerCavityTimeout.Stop()

        If (Not IsRemoteCommunicationsEnabled()) Then Return

        Dim defaultMouldNumber As String = PlcDriverUtilities.ReadPLCValue(Of String)("RemoteConnectionDefaultMouldNumber", Me._plcDriver)

        PlcDriverUtilities.WritePlcValue("ContCountEnter", 1, Me._plcDriver)
        PlcDriverUtilities.WritePlcValue("MEnter0", defaultMouldNumber, Me._plcDriver)
        PlcDriverUtilities.PulsePlcTag("Mould_Entry_Ack", True, Me._plcDriver)

    End Sub

#End Region
End Class
