Imports System.Xml
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic
Imports System.Collections
Imports System.Linq
Imports Somex.Roburst.Integration.Common
Imports log4net
Imports log4net.Config
Imports CGC.Common.Security.IdleTime


Public Class base_home

    Private _remoteDataManager As RemoteDataManager
    Private _alarmManager As AlarmManager
    Private _idleTimeNotifier As IdleTimeNotifier
    Private _selectedLanguage As LanguageManager.SupportedLanguages
    Private securityLevel As Integer = 0
    Private _conveyorCount As Integer = 0
    Public IsRunning As Boolean = False


    Public Event AlarmsActive(alarmState As Boolean)

    Protected Overridable Sub OnAlarmsActive(alarmState As Boolean)
        RaiseEvent AlarmsActive(alarmState)
    End Sub

    Shared _log As ILog = LogManager.GetLogger(GetType(base_home))

    Public Property SelectedLanguage() As LanguageManager.SupportedLanguages
        Get
            Return _selectedLanguage
        End Get
        Set(ByVal value As LanguageManager.SupportedLanguages)
            _selectedLanguage = value
        End Set
    End Property


    Private Sub AlmInd_Click(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
    End Sub

    Private Sub PgOpenAlarmsButton_Click(sender As Object, e As EventArgs) Handles PgOpenAlarmsButton.Click
        base_alarms.Show()
    End Sub

    Private Sub PgOpenLoadButton_Click(sender As Object, e As EventArgs) Handles PgOpenLoadButton.Click
        base_load.Show()
    End Sub

    Private Sub PgOpenResultsButton_Click(sender As Object, e As EventArgs) Handles PgOpenResultsButton.Click
        base_results.Show()
    End Sub

    Private Sub PgOpenManualButton_Click(sender As Object, e As EventArgs) Handles PgOpenManualButton.Click
        Dim isMachineRunning As Boolean = IsRunning

        If (isMachineRunning) Then
            MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachineBeforeChangingToManualPrompt), LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachinePrompt), _
                                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        ' switch to manual mode
        Try
            PlcDriverUtilities.PulsePlcTag("MainSeq.Manual", True, Me.EthernetIPforCLXCom1)
            base_manual.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PgOpenIOButton_Click(sender As Object, e As EventArgs) Handles PgOpenIOButton.Click
        base_io.Show()
    End Sub

    Private Sub PgOpenSettingsButton_Click(sender As Object, e As EventArgs) Handles PgOpenSettingsButton.Click
        base_settings.Show()
    End Sub

    Private Sub PgOpenCalibrationButton_Click(sender As Object, e As EventArgs) Handles PgOpenCalibrationButton.Click
        Dim isMachineRunning As Boolean = IsRunning
        If (isMachineRunning) Then
            MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachineBeforeChangingToManualPrompt), LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachinePrompt), _
                                                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        base_calibration.Show()
    End Sub
    Private Sub PgOopenSecButton_Click(sender As Object, e As EventArgs) Handles PgOopenSecButton.Click
        base_sec.Show()
        base_sec.PassParameter(securityLevel)
    End Sub
    Private Sub PgOpenHelpButton_Click(sender As Object, e As EventArgs) Handles PgOpenHelpButton.Click
        base_help.Show()
    End Sub

    Private Sub PgOpenDeviceButton_Click(sender As Object, e As EventArgs) Handles PgOpenDeviceButton.Click
        base_devices.Show()
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub PgOpenRecEditButton_Click(sender As Object, e As EventArgs) Handles PgOpenRecEditButton.Click
        base_rec_edit.Show()
    End Sub

    Private Sub BasicButton3_Click(sender As Object, e As EventArgs) Handles MouldsManualEntry.Click
        Try
            pop_mould_number_entry.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadProfileButton.Click
        base_load.Show()
    End Sub

    Private Sub base_home_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        ' stop idle time monitor
        If (Not _idleTimeNotifier Is Nothing) Then
            _idleTimeNotifier.StartMonitoring()
        End If

        ' close the serial port for exporting results
        SerialResultsExporter.ClosePort()

        ' save plc settings back to ini file. Originally the PLC was storing the settings
        ' we are now loading them from ini file and restoring to PLC on startup and
        ' saving back to ini on close
        PLCSettingsRepository.SavePlcSettings(Me.EthernetIPforCLXCom1)
        HmiSettingsResolver.SaveSettingValue("Misc", "Language", Convert.ToInt32(_selectedLanguage))
        ' stop remote comms
        Me.StopRemoteCommunications()
    End Sub

    Private Sub base_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' configure log4net logging framework
            XmlConfigurator.ConfigureAndWatch(New FileInfo(".\\Log4netConfig.config"))

            ' action for showing splashscreen
            Dim action As New Action(Sub()

                                         base_splashScreen.Show()
                                         Application.DoEvents()

                                         ' very little processing on form load but the form still needs
                                         ' approx. 5 second to update graphics etc. 
                                         System.Threading.Thread.Sleep(5000)
                                         base_splashScreen.Close()

                                     End Sub)

            ' display the splash screen
            action.BeginInvoke(Nothing, Nothing)

            ' restore the PLC settings
            PLCSettingsRepository.LoadPlcSettings(Me.EthernetIPforCLXCom1)


            ' load  langugage from PLC and setup UI for that language
            Dim languageValueInPLC As Integer = LanguageManager.SupportedLanguages.English

            Try
                languageValueInPLC = HmiSettingsResolver.GetSettingValue("Misc", "Language")
            Catch ex As Exception
                languageValueInPLC = LanguageManager.SupportedLanguages.English
            End Try

            If (languageValueInPLC = 0) Then
                languageValueInPLC = LanguageManager.SupportedLanguages.English
            End If

            _selectedLanguage = languageValueInPLC
            LoadSelectedLanguage(_selectedLanguage)


            ' initialise the profile manager, loading the profiles 
            ' from disk
            ProfileManager.Initialise()


            ' initalise the alarm manager
            _alarmManager = New AlarmManager(Me.EthernetIPforCLXCom1)
            ' pass the alarmManager to base_alarms so he has access to curret list  of active alarms 
            base_alarms.SetAlarmManager(_alarmManager)

            ' set operator permissions on form load, in case an Eng or Admin
            ' was logged in and walked away after HMI was shutdown
            SetOperatorPermissions()

            ' reset login to operator
            Try
                PlcDriverUtilities.WritePlcValue("HMI.SecurityLevel", 0, EthernetIPforCLXCom1)
            Catch ex As Exception
                _log.Error("Error setting securityLevel to 0," & ex.Message)
                MessageBox.Show(ex.Message)
            End Try

            ' configure idletime monitor
            ' configure idle time monitor
            _idleTimeNotifier = New IdleTimeNotifier(Convert.ToInt32(HmiSettingsResolver.GetSettingValue("Security", "IdleTimeInSeconds")))
            AddHandler _idleTimeNotifier.IdleTimeElapsed, AddressOf IdleTimeElapsed
            _idleTimeNotifier.StartMonitoring()


            ' initalise the operation mode manager for remote data exchange
            _remoteDataManager = New RemoteDataManager(Me.EthernetIPforCLXCom1, Me._alarmManager)
            _remoteDataManager.CurrentMode = IIf(PlcDriverUtilities.ReadPLCValue(Of Boolean)("machine_remote", Me.EthernetIPforCLXCom1), ModesOfOperation.auto, ModesOfOperation.local)
            _remoteDataManager.StartCommunications()

            ' open serial port for exporting results. If this fails, 
            ' the SerialResultsExporter will attempt to reopen it
            ' for each bottle result processed
            SerialResultsExporter.OpenPort()

            ' start time synchronisation
            HeartBeatTimer.Interval = 1000
            HeartBeatTimer.Enabled = True

            ' reset this play in case the HMI shut down before resetting
            ' the Ack. Without this the PLC could potientially stop emptying
            ' the result buffer
            PlcDriverUtilities.WritePlcValue("ResultReadyAck", 0, Me.EthernetIPforCLXCom1)

            Me.AlarmsMute.Interval = 5000
            Me.AlarmsMute.Enabled = True


        Catch ex As Exception
            _log.Error("Error loading base_home," + ex.ToString())
        End Try

    End Sub

    ''' <summary>
    ''' Idle Time has elapsed, set bit in plc
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub IdleTimeElapsed(sender As Object, e As IdleTimeElapsedEventArgs)

        Try

            ' log out the current user
            PlcDriverUtilities.WritePlcValue("HMI.Logout", 1, Me.EthernetIPforCLXCom1)
            Threading.Thread.Sleep(100)
            PlcDriverUtilities.WritePlcValue("HMI.Logout", 0, Me.EthernetIPforCLXCom1)

            ' hide all open forms except this one
            CloseAllVisibleFormsExceptThis()

        Catch ex As Exception
            _log.Error("Error handling IdleTime, " + ex.ToString())

        End Try

    End Sub

    ''' <summary>
    ''' Hide all open forms, except  the form calling the code ie base_home
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CloseAllVisibleFormsExceptThis()

        Try


            For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
                Dim form As Form = System.Windows.Forms.Application.OpenForms(i)

                ' don't close the dialog box
                If (form.Name = Me.Name) Then Continue For
                If (form.Visible = False) Then Continue For

                form.Invoke(Sub() form.Hide(), Nothing)

            Next i
        Catch ex As Exception
            _log.Error("Error closing visible forms, " + ex.ToString())
        End Try

    End Sub


    Private Sub SetOperatorPermissions()

        PgOpenHelpButton.Enabled = True
        PgOpenDeviceButton.Enabled = True
        PgOpenIOButton.Enabled = True
        PgOpenManualButton.Enabled = False
        PgOpenVerificationButton.Enabled = True
        PgOpenAlarmsButton.Enabled = True
        PgOpenResultsButton.Enabled = True
        PgOpenLoadButton.Enabled = True
        PgOpenCalibrationButton.Enabled = False
        PgOpenVerificationButton.Enabled = False
        PgOpenSettingsButton.Enabled = False
        PgOopenSecButton.Enabled = False
        PgOpenRecEditButton.Enabled = False

    End Sub

    Private Sub SetEngineerPermissions()
        PgOpenHelpButton.Enabled = True
        PgOpenDeviceButton.Enabled = True
        PgOpenIOButton.Enabled = True
        PgOpenManualButton.Enabled = False
        PgOpenVerificationButton.Enabled = True
        PgOpenAlarmsButton.Enabled = True
        PgOpenResultsButton.Enabled = True
        PgOpenLoadButton.Enabled = True
        PgOpenCalibrationButton.Enabled = True
        PgOpenVerificationButton.Enabled = True
        PgOpenSettingsButton.Enabled = False
        PgOopenSecButton.Enabled = True
        PgOpenRecEditButton.Enabled = True
    End Sub

    Private Sub SetAdminPermissions()
        PgOpenHelpButton.Enabled = True
        PgOpenDeviceButton.Enabled = True
        PgOpenIOButton.Enabled = True
        PgOpenManualButton.Enabled = True
        PgOpenVerificationButton.Enabled = True
        PgOpenAlarmsButton.Enabled = True
        PgOpenResultsButton.Enabled = True

        PgOpenLoadButton.Enabled = True

        PgOpenCalibrationButton.Enabled = True
        PgOpenVerificationButton.Enabled = True
        PgOpenSettingsButton.Enabled = True
        PgOopenSecButton.Enabled = True
        PgOpenRecEditButton.Enabled = True
    End Sub

    ''' <summary>
    ''' Compile the values in the PLC results tags into an XML file with one test record. Also
    ''' transmits data to line controller
    ''' </summary>
    ''' <remarks></remarks>
    Private Function ExportResults() As Integer

        Dim resultDirectory As String = HmiSettingsResolver.GetSettingValue("Misc", "ResultsPath")
        Dim TestNumber As Integer = 0

        Try

            'Read the PLC results tags into VB variables
            TestNumber = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.TestNo", Me.EthernetIPforCLXCom1)
            Dim TestDate As String = DateTime.Now.ToString("dd/MMM/yyyy")
            Dim TestTime As String = DateTime.Now.ToString("HH:mm:ss")
            Dim TestID = GetPlcTestTimeStamp()
            Dim ResultValid = PlcDriverUtilities.ReadPLCValue(Of Boolean)("RecordM.ResultValid", Me.EthernetIPforCLXCom1)
            Dim MouldNumber As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.MouldNo", Me.EthernetIPforCLXCom1)
            Dim MaxPressure As Single = PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.MaxPressure", Me.EthernetIPforCLXCom1)
            Dim Burst As Boolean = PlcDriverUtilities.ReadPLCValue(Of Boolean)("RecordM.Burst_Y_N", Me.EthernetIPforCLXCom1)
            Dim ProfileNo As String = PlcDriverUtilities.ReadPLCValue(Of String)("RecordM.TestProfileNo", Me.EthernetIPforCLXCom1)
            Dim ProfileName As String = ProfileNo ' profile name no longer stored in the PLC. Assigning ProfileNo instead of removing name from all export functions
            Dim ProfileUnits As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.TestProfileDetails.Units", Me.EthernetIPforCLXCom1)
            Dim ProfilePress1min As Boolean = PlcDriverUtilities.ReadPLCValue(Of Boolean)("RecordM.TestProfileDetails.One_Min_Equiv", Me.EthernetIPforCLXCom1)
            Dim ProfileSP1 As Single = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.TestProfileDetails.SP1", Me.EthernetIPforCLXCom1), 2)
            Dim ProfileRamp1 As Single = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.TestProfileDetails.Ramp1", Me.EthernetIPforCLXCom1), 2)
            Dim ProfileDwellTime1 As Integer = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.TestProfileDetails.DwellTime1", Me.EthernetIPforCLXCom1), 2)
            Dim ProfileSP2 As Single = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.TestProfileDetails.SP2", Me.EthernetIPforCLXCom1), 2)
            Dim ProfileRamp2 As Single = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Single)("RecordM.TestProfileDetails.Ramp2", Me.EthernetIPforCLXCom1), 2)
            Dim ProfileDwellTime2 As Integer = Math.Round(PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.TestProfileDetails.DwellTime2", Me.EthernetIPforCLXCom1), 2)


            ' send results out serial port. No alarms generated, exceptions are written to log file
            SerialResultsExporter.ExportResults(TestNumber, TestDate, TestTime, TestID, MouldNumber, MaxPressure, Burst, ProfileNo, ProfileName,
                                                 ProfileUnits, ProfilePress1min, ProfileSP1, ProfileRamp1, ProfileDwellTime1, ProfileSP2, ProfileRamp2,
                                                 ProfileDwellTime2, ResultValid)

            ' export the results to Line Controller. The method will handle any exceptions
            ' and set alarm active
            Me._remoteDataManager.SendTestResult(TestNumber, TestDate, TestTime, TestID, MouldNumber, MaxPressure, Burst, ProfileNo, ProfileName,
                                                 ProfileUnits, ProfilePress1min, ProfileSP1, ProfileRamp1, ProfileDwellTime1, ProfileSP2, ProfileRamp2,
                                                 ProfileDwellTime2, ResultValid)

            ' save result to csv file
            If (Not Directory.Exists(resultDirectory)) Then
                Directory.CreateDirectory(resultDirectory)

                If (Not Directory.Exists(resultDirectory)) Then
                    MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.CouldNotCreateResultDirectory) & " " & resultDirectory, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return TestNumber
                End If
            End If

            Dim resultExport As ResultExporter = New ResultExporter()

            ' save the results to XML
            Dim isSaved As Boolean = resultExport.ExportToXML(TestNumber, TestDate, TestTime, TestID, MouldNumber, MaxPressure, Burst, ProfileNo, ProfileName,
                                                              ProfileUnits, ProfilePress1min, ProfileSP1, ProfileRamp1, ProfileDwellTime1, ProfileSP2, ProfileRamp2, ProfileDwellTime2,
                                                              resultDirectory, ResultValid)

            ' save the results to CSV file
            resultExport.AppendToCSV(TestNumber, TestDate, TestTime, TestID, MouldNumber, MaxPressure, Burst, ProfileNo, ProfileName,
                                                              ProfileUnits, ProfilePress1min, ProfileSP1, ProfileRamp1, ProfileDwellTime1, ProfileSP2, ProfileRamp2, ProfileDwellTime2,
                                                              resultDirectory, ResultValid)

        Catch ex As Exception

            _log.Error("Error exporting xml result data, " & ex.ToString())
            _alarmManager.ActivateAlarmBit(HMISourceAlarms.FailedToSaveTestResultToCSV)

        End Try

        Return TestNumber

    End Function



#Region "Language Buttons"
    Private Sub EnglishPictureBox_Click(sender As Object, e As EventArgs) Handles EnglishPictureBox.Click

        LoadSelectedLanguage(LanguageManager.SupportedLanguages.English)

    End Sub

    Private Sub GermanPictureBox_Click(sender As Object, e As EventArgs) Handles GermanPictureBox.Click

        LoadSelectedLanguage(LanguageManager.SupportedLanguages.German)

    End Sub

    Private Sub FrenchPictureBox_Click(sender As Object, e As EventArgs) Handles FrenchPictureBox.Click

        LoadSelectedLanguage(LanguageManager.SupportedLanguages.French)

    End Sub

    Private Sub SpanishPictureBox_Click(sender As Object, e As EventArgs) Handles SpanishPictureBox.Click

        LoadSelectedLanguage(LanguageManager.SupportedLanguages.Spanish)

    End Sub


    Private Sub DutchPictureBox_Click(sender As Object, e As EventArgs) Handles DutchPictureBox.Click

        LoadSelectedLanguage(LanguageManager.SupportedLanguages.Dutch)

    End Sub

    Private Sub ItalianPictureBox_Click(sender As Object, e As EventArgs) Handles ItalianPictureBox.Click
        LoadSelectedLanguage(LanguageManager.SupportedLanguages.Italian)
    End Sub

    Private Sub CzechPictureBox_Click(sender As Object, e As EventArgs) Handles CzechPictureBox.Click
        LoadSelectedLanguage(LanguageManager.SupportedLanguages.Czech)
    End Sub

#End Region


    Private Function GetPlcTestTimeStamp() As String

        Dim year As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Year", Me.EthernetIPforCLXCom1)
        Dim month As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Month", Me.EthernetIPforCLXCom1)
        Dim day As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Day", Me.EthernetIPforCLXCom1)
        Dim hour As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Hour", Me.EthernetIPforCLXCom1)
        Dim minute As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Minute", Me.EthernetIPforCLXCom1)
        Dim second As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("RecordM.Date_Time.Second", Me.EthernetIPforCLXCom1)
        Dim monthAbbrev As String

        If (month = 0) Then
            monthAbbrev = "0"
        Else
            monthAbbrev = MonthName(month, True)
        End If

        Dim timeStamp = hour.ToString() & ":" & _
                        minute.ToString() & ":" & _
                        second.ToString() & " " & _
                        day.ToString() & "/" & _
                        monthAbbrev & "/" & _
                        year.ToString()


        Return timeStamp

    End Function


    Private Sub LoadSelectedLanguage(selectedLanguage As LanguageManager.SupportedLanguages)

        Try

            Me.Cursor = Cursors.WaitCursor

            Application.DoEvents()

            _selectedLanguage = selectedLanguage

            LanguageManager.LoadTranslationsFor(_selectedLanguage)
            LanguageManager.LoadAlarmsFor(_selectedLanguage)
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
            LanguageManager.LoadUserMessaagesFor(_selectedLanguage)
            If (Not Me._alarmManager Is Nothing) Then Me._alarmManager.UpdateAlarmMessageForLanguage()
            PlcDriverUtilities.WritePlcValue("HMI.Language", _selectedLanguage, Me.EthernetIPforCLXCom1)

        Catch ex As Exception
            _log.Error("Error selecting language, " & _selectedLanguage.ToString() & "," & ex.ToString())
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub



    Private Sub LocalModeButton_Click(sender As Object, e As EventArgs) Handles LocalModeButton.Click

        ' update the mode of operation
        Me._remoteDataManager.CurrentMode = ModesOfOperation.local

    End Sub

    Private Sub RemoteModeButton_Click(sender As Object, e As EventArgs) Handles RemoteModeButton.Click

        Me._remoteDataManager.CurrentMode = ModesOfOperation.auto

    End Sub




    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        Try

            'If (MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.ClearOfBottlesPrompt), _
            '                                                   LanguageManager.GetUserMessage(LanguageManager.UserMessages.ConfirmationRequired), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            '    Return
            'End If

            ' check if the turret was moved by the user
            Dim wasTurretManuallyMoved = PlcDriverUtilities.ReadPLCValue(Of Boolean)("TurretManuallyMoved", Me.EthernetIPforCLXCom1)
            If (wasTurretManuallyMoved) Then

                ' display diaglog prompting user
                Dim popup = New pop_turret_moulds()
                popup.ShowDialog()

            End If


            PlcDriverUtilities.PulsePlcTag("MainSeq.Start", True, Me.EthernetIPforCLXCom1)


        Catch ex As Exception
            _log.Error("Could not start main sequence, " & ex.ToString())
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    ''' <summary>
    ''' Sends the current time to the PLC
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HeatBeatTimer_Tick(sender As Object, e As EventArgs) Handles HeartBeatTimer.Tick

        Try
            ' set the heartbeat bit high
            PlcDriverUtilities.WritePlcValue("HMI_HeartBeat", 1, EthernetIPforCLXCom1)

        Catch ex As Exception
            _log.Error("Failed to write HeartBeat")
        End Try

    End Sub

    Public Sub StopRemoteCommunications()

        If (Not Me._remoteDataManager Is Nothing) Then
            _log.Debug("Stopping remote communications")
            Me._remoteDataManager.StopCommunications()
        End If

    End Sub

    Public Sub StartRemoteCommunications()

        If (Not Me._remoteDataManager Is Nothing) Then
            _log.Debug("Starting remote communications")
            Me._remoteDataManager.StartCommunications()
        End If

    End Sub

    Private Sub TestExportResultsButton_Click(sender As Object, e As EventArgs)

        ' start timer to send data out the serial port
        'Me.TestSerialCommsTimer.Enabled = True

        ExportResults()
    End Sub


    Private testNumber As Integer
    Private Sub TestSerialCommsTimer_Tick(sender As Object, e As EventArgs) Handles TestSerialCommsTimer.Tick

        testNumber += 1
        SerialResultsExporter.ExportResults(testNumber, Date.Now.ToString("ddMMyy"), Date.Now.ToString("hhmmss"), Date.Now.ToString("ddMMyy hhmmss"), 1234, 10.12, True, 0, "profile name",
                                                0, False, 0, 0, 0, 0, 0,
                                                0, True)
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
    End Sub

    Private Sub StopToClearStation_Click(sender As Object, e As EventArgs) Handles StopToClearStation.Click, StopToClearConveyor.Click
        Dim isMachineRunning As Boolean = IsRunning

        If (isMachineRunning) Then
            MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachineBeforeChangingToManualPrompt), LanguageManager.GetUserMessage(LanguageManager.UserMessages.StopMachinePrompt), _
                                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
    End Sub

    Private Sub DataSubscriberAll_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriberAll.DataChanged
        Select Case e.SubscriptionID
            Case 1 'Security Level
                DataSubscriber_base_home_DataChanged(sender, e)
            Case 2 'Alarms Handler 0
                DataSubscriber_alarmsActivated_DataChanged(sender, e)
            Case 3 'Alarms Handler 1
                DataSubscriber_alarmsActivatedBank2_DataChanged(sender, e)
            Case 4 'Alarms Handler 2
                DataSubscriber_alarmsActivatedBank3_DataChanged(sender, e)
            Case 5 'Results Ready
                DataSubscriber_XML_DataChanged(sender, e)
            Case 6 'Alarms Active
                DataSubscriber_Alarm_DataChanged(sender, e)
            Case 7 'Remote Sample Request
                DataSubscriber_BottleArriving_DataChanged(sender, e)
            Case 8 'Conveyor Free Slots
                ConveyorFreeSlotsDataSubscriber_DataChanged(sender, e)
            Case 9 'Alarms Critical Active
                DataSubscriber_CriticalAlarm_DataChanged(sender, e)
            Case 10 'Main Seq Running
                DataSubscriber_RunningState_DataChanged(sender, e)
            Case 11 'Machine Status
                DataSubscriber1_DataChanged(sender, e)
            Case 12 'Machine Remote
                DataSubscriber_RemoteState_DataChanged(sender, e)
            Case 13 'Manual Mode Entry
                DataSubscriber_ManualMouldEntryState_DataChanged(sender, e)
            Case 14 'Profile Load No
                DataSubscriber_ProfileNumber_DataChanged(sender, e)
            Case 15 'Low burst Timeout
                DataSubscriber_LowBurstTimeout_DataChanged(sender, e)
        End Select

    End Sub

    Private Sub DataSubscriber_base_home_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        'Set visibility of alarm indicator based on PLC bit Alarms.Active (from data subscriber)
        securityLevel = CInt(e.Values(0))

        _log.Debug("Security Access Level Changed to " & securityLevel)

        If securityLevel = 0 Then
            SetOperatorPermissions()
        ElseIf securityLevel = 1 Then
            SetEngineerPermissions()
        ElseIf securityLevel = 2 Then
            SetAdminPermissions()
        ElseIf securityLevel = 3 Then
            SetAdminPermissions()
        End If

    End Sub

    ''' <summary>
    ''' Route the DINT representing the alarms to the alarm manager. It will
    ''' determine what has changed in the DINT and what alarms are active. 
    ''' There are two DINTs in the PLC for alarms. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataSubscriber_alarmsActivated_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If (Me._alarmManager Is Nothing) Then Return


        _log.Debug("Alarm bank 0 changed, " & Convert.ToInt32(e.Values(0)).ToString())
        Me._alarmManager.ActiveAlarmsChangedHandler(Convert.ToInt32(e.Values(0)), 0)

        If (Convert.ToInt32(e.Values(0)) > 0) Then
            OnAlarmsActive(True)
        Else
            OnAlarmsActive(False)
        End If
    End Sub

    ''' <summary>
    ''' Route the DINT representing the alarms to the alarm manager. It will
    ''' determine what has changed in the DINT and what alarms are active. 
    ''' There are two DINTs in the PLC for alarms. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataSubscriber_alarmsActivatedBank2_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If (Me._alarmManager Is Nothing) Then Return

        _log.Debug("Alarm bank 1 changed, " & Convert.ToInt32(e.Values(0)).ToString())
        Me._alarmManager.ActiveAlarmsChangedHandler(Convert.ToInt32(e.Values(0)), 1)

        If (Convert.ToInt32(e.Values(0)) > 0) Then
            OnAlarmsActive(True)
        Else
            OnAlarmsActive(False)
        End If
    End Sub


    ''' <summary>
    ''' Route the DINT representing the alarms to the alarm manager. It will
    ''' determine what has changed in the DINT and what alarms are active. 
    ''' There are two DINTs in the PLC for alarms. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataSubscriber_alarmsActivatedBank3_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        Dim alarms As Integer = 0
        If (Me._alarmManager Is Nothing) Then Return

        'Mute PLC 74 alarm 2.10
        If (Me.AlarmsMute.Enabled) Then
            alarms = Convert.ToInt32(e.Values(0)) And Not 1024
        Else
            alarms = Convert.ToInt32(e.Values(0))
        End If

        _log.Debug("Alarm bank 2 changed, " & alarms)
        Me._alarmManager.ActiveAlarmsChangedHandler(alarms, 2)

        If (Convert.ToInt32(alarms) > 0) Then
            OnAlarmsActive(True)
        Else
            OnAlarmsActive(False)
        End If
    End Sub

    Private Sub DataSubscriber_XML_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Try

            ' rev 1.0.0.8
            ' xml dataChanged firing on startup
            ' an object null reference unhandled exception is occurring as a result
            ' check that both the remoteManager and alarmManager are instantiated before
            ' exporting results
            If (Me._alarmManager Is Nothing) Then Return
            If (Me._remoteDataManager Is Nothing) Then Return

            ' export results on rising edge
            If e.Values(0) = True Then
                Dim testNumnber As Integer = ExportResults()

                ' rev 1.0.0.17 New tags for acknowleding the result and returning the test id handled by HMI
                PlcDriverUtilities.WritePlcValue("ResultTestIDAck", testNumnber, Me.EthernetIPforCLXCom1)
                PlcDriverUtilities.WritePlcValue("ResultReadyAck", 1, Me.EthernetIPforCLXCom1)
            Else
                PlcDriverUtilities.WritePlcValue("ResultReadyAck", 0, Me.EthernetIPforCLXCom1)
            End If

        Catch ex As Exception
            _log.Error("Unexpected error in DataSubscriber_XML_DataChanged," & ex.ToString())
            ' reset the ack to prevent the PLC from locking the buffer up. Unlikely this
            ' will ever be called as ExportResults has exception handlers.
            PlcDriverUtilities.WritePlcValue("ResultReadyAck", 0, Me.EthernetIPforCLXCom1)
        Finally

        End Try

    End Sub

    Private Sub DataSubscriber_Alarm_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        Try
            Dim isInAlarm As Boolean = e.Values(0)

            AlmInd.Visible = isInAlarm

            _log.Debug("Alarm Active Changed: isInAlarm " & isInAlarm)

        Catch ex As Exception
            OnAlarmsActive(True)
            _log.Debug("Alarm Active Changed: casting Error")
        End Try


    End Sub

    ''' <summary>
    ''' Handler for Bottle Triggering sensor on conveyor. 
    ''' If sensor is high, request mould number or set off numbers, depending
    ''' on the mode of operatios. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataSubscriber_BottleArriving_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Try

            ' Has bottle has arrived ? 
            If (Convert.ToBoolean(e.Values(0)) = True) Then

                ' check the mode of operation, ignore all bottles coming down the line
                ' if we're in local
                If (Me._remoteDataManager.CurrentMode = ModesOfOperation.local) Then Return

                If (Me._remoteDataManager Is Nothing) Then Return

                ' set busy for each bottle we process
                If Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Rdy Then

                    Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Busy
                End If

                ' send ack to PLC that we've detected the bottle 
                PlcDriverUtilities.PulsePlcTag("RemoteSampleRequestAck", True, Me.EthernetIPforCLXCom1)

                ' we need to alarm here as local mode is not selected and
                ' remote communications is disabled. 
                If (Not Me._remoteDataManager.IsRemoteCommunicationsEnabled()) Then
                    Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationDisabled)
                    Return
                End If

                ' check how many free slot there are on the conveyor
                Dim freeSlot As Integer = PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me.EthernetIPforCLXCom1)
                If (freeSlot = 0) Then
                    ' raise alarm
                    Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.NoConveyorSlotsFree)
                    Return

                End If

                'pop_simple_dialog.MessageToDisplay = LanguageManager.GetUserMessage(LanguageManager.UserMessages.RetrievingMouldNumber)
                'pop_simple_dialog.Show()
                'Application.DoEvents()

                ' check what mode we are in.
                If (Me._remoteDataManager.CurrentMode = ModesOfOperation.auto) Then
                    _remoteDataManager.RequestMouldSample()
                ElseIf (Me._remoteDataManager.CurrentMode = ModesOfOperation.semi And _conveyorCount = 0) Then
                    _remoteDataManager.RequestSet()
                End If

            End If

        Catch ex As Exception
            _log.Error("Error handling bottle: " & ex.ToString())
            Me._alarmManager.ActivateAlarmBit(HMISourceAlarms.RemoteCommunicationsError)
        Finally

            'pop_simple_dialog.Close()

            ' reset busy as long as it has not transitioned to another state besides busy
            If (Not Me._remoteDataManager Is Nothing) Then
                If Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Busy Then
                    Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Rdy
                End If

            End If

        End Try

    End Sub

    Private Sub ConveyorFreeSlotsDataSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Dim numberOfFreeSlots = Convert.ToInt32(e.Values(0))
        _conveyorCount = 100 - numberOfFreeSlots

        _log.Debug("Conveyor Free Slots Changed, number free is " & numberOfFreeSlots)

        If (Me._remoteDataManager Is Nothing) Then Return
        If (Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Fault) Then Return
        If (PlcDriverUtilities.ReadPLCValue(Of Boolean)("Alarms_CriticalActive", Me.EthernetIPforCLXCom1)) Then Return
        If (Not PlcDriverUtilities.ReadPLCValue(Of Boolean)("MainSeq.Running", Me.EthernetIPforCLXCom1)) Then Return

        If (numberOfFreeSlots = 0) Then
            Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Busy
        Else
            Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Rdy
        End If

    End Sub

    Private Sub DataSubscriber_CriticalAlarm_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Dim isCritical As Boolean = e.Values(0)

        _log.Debug("Critical Alarm Active Changed : isCritical " & isCritical)

        If (Not Me._remoteDataManager Is Nothing) Then

            If (isCritical) Then
                Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Fault
            Else

                ' before changing to Rdy check if that we haven't changed
                ' to busy while the alarms were active
                If (PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me.EthernetIPforCLXCom1) = 0) Then
                    Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Busy
                ElseIf (Not PlcDriverUtilities.ReadPLCValue(Of Boolean)("MainSeq.Running", Me.EthernetIPforCLXCom1)) Then
                    Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Stopped
                Else
                    Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Rdy
                End If

            End If
        End If

    End Sub

    Private Sub DataSubscriber_RunningState_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        IsRunning = e.Values(0)

        _log.Debug("Running State Chanaged : isRunning " & IsRunning)

        If PlcDriverUtilities.ReadPLCValue(Of Boolean)("Alarms_CriticalActive", Me.EthernetIPforCLXCom1) Then Return
        If (PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me.EthernetIPforCLXCom1) = 0) Then Return

        If (Not Me._remoteDataManager Is Nothing) Then

            If (IsRunning) Then
                Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Rdy
            Else
                Me._remoteDataManager.CurrentMachineState = RemoteDataManager.MachineStates.Stopped
            End If

        End If

    End Sub

    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Try
            machineStatusLabel.Text = LanguageManager.GetUserMessage(CInt(e.Values(0)))
        Catch ex As Exception
            machineStatusLabel.Text = "Fault"
        End Try

    End Sub

    Private Sub DataSubscriber_RemoteState_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If (Convert.ToBoolean(e.Values(0)) = True) Then
            Me.MouldsManualEntry.Visible = False
        Else

            ' enable it if manual entry setting is enabled
            Me.MouldsManualEntry.Visible = Not (PlcDriverUtilities.ReadPLCValue(Of Boolean)("HMI.Manual[1].8", Me.EthernetIPforCLXCom1))

        End If
    End Sub

    ''' <summary>
    ''' Hide the Manual Mould Entry button if Manual Entry is disabled
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataSubscriber_ManualMouldEntryState_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        ' if user has enabled manual entry
        If (Convert.ToBoolean(e.Values(0)) = False) Then

            ' only show the button if not operating in remote mode. 
            Me.MouldsManualEntry.Visible = Not (PlcDriverUtilities.ReadPLCValue(Of Boolean)("machine_remote", Me.EthernetIPforCLXCom1))
        Else
            Me.MouldsManualEntry.Visible = False

        End If
    End Sub

    Private Sub DataSubscriber_ProfileNumber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Try

            Dim profileNumber As String = e.Values(0).ToString()
            If (String.IsNullOrEmpty(profileNumber)) Then
                'Me.ProfileNumberLabel.Text = "-----"
                Me.ProfileNameLabel.Text = ""
                Return
            End If

            'Me.ProfileNumberLabel.Text = profileNumber

            ' find matching profile so we can show the profile name
            Dim matchingProfile As ProfileDetails = ProfileManager.GetProfileForNumber(profileNumber)

            ' update the Profile Name label
            If (matchingProfile Is Nothing) Then
                Me.ProfileNameLabel.Text = String.Empty
            Else
                Me.ProfileNameLabel.Text = matchingProfile.Name
            End If

        Catch ex As Exception
            _log.Error("Error subscribing to profileNumber DataChanged, " & ex.Message)

        End Try

    End Sub

    Private Sub DataSubscriber_LowBurstTimeout_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)

        Try

            If (Convert.ToBoolean(e.Values(0)) = True) Then
                pop_low_burst_timeout.Show()
            Else
                pop_low_burst_timeout.Visible = False
            End If

        Catch ex As Exception
            _log.Error("Error handling low burst timeout change, " & ex.ToString())
        End Try

    End Sub

    Private Sub PgOpenVerificationButton_Click(sender As Object, e As EventArgs) Handles PgOpenVerificationButton.Click
        base_verification.Show()
    End Sub

    Private Sub SaveTimeToPLC_Tick(sender As Object, e As EventArgs) Handles SaveTimeToPLC.Tick

        Try

            ' write the current time  to the PLC
            Dim cuurrentTime = Date.Now

            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Year", cuurrentTime.Year, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Month", cuurrentTime.Month, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Day", cuurrentTime.Day, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Hour", cuurrentTime.Hour, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Minute", cuurrentTime.Minute, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI_DateTime.Second", cuurrentTime.Second, EthernetIPforCLXCom1)

        Catch ex As Exception
            ' fail silently

        End Try
    End Sub

    Private Sub AlarmsMute_Tick(sender As Object, e As EventArgs) Handles AlarmsMute.Tick
        Me.AlarmsMute.Enabled = False
    End Sub
End Class

