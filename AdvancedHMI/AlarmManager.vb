Imports System.Linq
Imports System.Collections.Generic
Imports System.IO
Imports log4net



Public Enum AlarmCondition
    Active
    InActive
End Enum

Public Enum HMISourceAlarms

    NoRemoteClientConnected = 31
    NoConveyorSlotsFree = 32
    RemoteCommunicationsError = 33
    DataTransmitFailed = 34
    MessageParseError = 35
    RemoteDataReadTimeout = 36
    TestResultTransmitFailed = 38
    FailedToSaveTestResultToCSV = 39
    NotEnoughFreeSlots = 40
    RemoteCommunicationDisabled = 41
    RequestMouldSetFailed = 42
    RequestMouldFailed = 43

End Enum

''' <summary>
''' Maintains list of currently active alarms adding new alarms to an alarm history
''' </summary>
''' <remarks></remarks>
Public Class AlarmManager

    Private _systemAlarms As List(Of Alarm)
    Private _historicalAlarms As List(Of Alarm)
    Private _plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom
    Public Event ActiveAlarmsChanged()
    Public Event HistoricalAlarmsChanged()
    Shared _log As ILog = LogManager.GetLogger(GetType(AlarmManager))



    Public Property SystemAlarms As List(Of Alarm)

        Get
            Return _systemAlarms
        End Get

        Set(value As List(Of Alarm))
            _systemAlarms = value
        End Set

    End Property


    Public Property HistoricalAlarms As List(Of Alarm)

        Get
            Return _historicalAlarms
        End Get

        Set(value As List(Of Alarm))
            _historicalAlarms = value
        End Set

    End Property


    ''' <summary>
    ''' Sets alarm bit high. 
    ''' </summary>
    ''' <param name="alarmBit"></param>
    ''' <remarks></remarks>
    Public Sub ActivateAlarmBit(alarmBit As HMISourceAlarms)

        Try

            ' resolve what bank number to use
            Dim alarmBitNumber As Integer = Convert.ToInt32(alarmBit)
            Dim bankNumber As Integer = 0

            If (alarmBitNumber > 31) Then
                alarmBitNumber = alarmBitNumber - 32
                bankNumber = 1
            End If

            If (alarmBitNumber > 63) Then
                alarmBitNumber = alarmBitNumber - 64
                bankNumber = 2
            End If

            PlcDriverUtilities.WritePlcValue("Alarms.Handler" & bankNumber & "." & alarmBitNumber, 1, Me._plcDriver)

        Catch ex As Exception

        End Try

    End Sub


    ''' <summary>
    ''' Called by base_home when active alarms is changed
    ''' </summary>
    ''' <param name="activeAlarms"></param>
    ''' <param name="bank">The PLC uses 3 DINTs to store all alarms. We have a file with individual alarm codes which
    ''' map to bit positions in the DINTs,  DINT[0] bits 0..31, DINT[1] bit 32..63, DINT[2] bit 65..97 </param>
    ''' <remarks></remarks>
    Public Sub ActiveAlarmsChangedHandler(activeAlarms As Int32, bank As Integer)

        Dim bankOffet As Integer = bank * 32

        Dim bits As BitArray = New BitArray(New Int32() {activeAlarms})
        Dim alarmBits(bits.Count) As Boolean
        bits.CopyTo(alarmBits, 0)

        ' get back a list of bits which are not active in our current ActiveAlarms list
        Dim newActiveAlarms As List(Of Alarm) = New List(Of Alarm)
        ' skip the first bit as BitArray is returning an array size 33
        For arrayIndex = 0 To alarmBits.Count - 1
            Dim loopIndex = arrayIndex + bankOffet
            Dim alarm = Me.SystemAlarms.Where(Function(x) x.BitPosition = loopIndex).FirstOrDefault()
            If (Not alarm Is Nothing) Then
                If (alarm.Condition = AlarmCondition.InActive) And (alarmBits(arrayIndex) = True) Then
                    alarm.Condition = AlarmCondition.Active
                    alarm.ActiveOn = DateTime.Now
                    newActiveAlarms.Add(alarm)
                ElseIf alarmBits(arrayIndex) = False Then
                    alarm.Condition = AlarmCondition.InActive
                End If

            End If
        Next

        AppendNewAlarmsToAlarmHistory(newActiveAlarms)

        ' notify interested parties, like the Alarm screen. 
        RaiseEvent ActiveAlarmsChanged()

    End Sub

    ''' <summary>
    ''' Appends the alarms to the history list and 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AppendNewAlarmsToAlarmHistory(alarms As List(Of Alarm))

        Try

            Dim strPath = HmiSettingsResolver.GetSettingValue("Misc", "AlarmHistoryPath").ToString()

            strPath = strPath & Path.DirectorySeparatorChar & "AlarmHistory.csv"

            ' check if history file needs to be archived
            ArchiveAlarmHistory(strPath)

            ' append the results to the file
            Using writer As New StreamWriter(strPath, True)

                For Each Alarm In alarms

                    Dim newLine = Alarm.ActiveOn & "," & Alarm.BitPosition & "," & Alarm.Description
                    writer.WriteLine(newLine)
                Next

                writer.Close()

            End Using


            alarms.ForEach(Sub(a)

                               Me.HistoricalAlarms.Add(a.Clone)

                           End Sub)

        Catch ex As Exception
            _log.Error("Error adding alarms to history file, " & ex.ToString())
        End Try

    End Sub


    ''' <summary>
    ''' Checks if the AlarmHistory file size is above a specific number of KBs  (500)
    ''' and renames it, then deletes the existing history file.  
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ArchiveAlarmHistory(alarmHistoryFilePath As String)

        Try

     
            If (Not File.Exists(alarmHistoryFilePath)) Then Return

            ' check the size of the file
            Dim alarmFile As New FileInfo(alarmHistoryFilePath)
            Dim fileSizeInKB As Decimal = alarmFile.Length \ 1024
            If (fileSizeInKB > 500) Then

                alarmFile.CopyTo(alarmFile.FullName & ".archive." & Date.Now.ToString("ddMMMyyyyThhmmss"))
                alarmFile.Delete()
            End If

        Catch ex As Exception
            _log.Error("Error attempting to archive alarm file, " & ex.ToString())
        End Try


    End Sub


    ''' <summary>
    ''' Alarm messages are stored in language files. We need
    ''' to load for the current language with the bit position for each alarm. 
    ''' The PLC uses a DINT (32bits) for representing thee state of alarms
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadAlarmMessagesFromDisk()

        Try
            ' populate the system alarms using the translation manager
            For Each element As KeyValuePair(Of Integer, String) In LanguageManager.AlarmTranslations
                Dim newAlarm = New Alarm()
                newAlarm.BitPosition = element.Key
                newAlarm.Description = element.Value
                newAlarm.Condition = AlarmCondition.InActive
                Me.SystemAlarms.Add(newAlarm)
            Next

        Catch ex As Exception
            _log.Error("Error loading alarm language messages from disk, " & ex.ToString())
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    ''' <summary>
    ''' If user changes the language then we need to update the
    ''' messages for each alarm
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateAlarmMessageForLanguage()

        For Each Alarm In Me.SystemAlarms
            If (LanguageManager.AlarmTranslations.ContainsKey(Alarm.BitPosition)) Then
                Dim translation = LanguageManager.AlarmTranslations.Where(Function(k) k.Key = Alarm.BitPosition).FirstOrDefault
                Alarm.Description = translation.Value
            End If
        Next

    End Sub



    ''' <summary>
    ''' Loads the last X from the AlarmsHistory csv filee
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadHistoricalAlarmsFromDisk()

        Try

            Dim strPath As String = HmiSettingsResolver.GetSettingValue("Misc", "AlarmHistoryPath").ToString()

            strPath = Path.Combine(strPath, "AlarmHistory.csv")

            ' ensure the file exists before continuing
            If (File.Exists(strPath) = False) Then Return


            Using reader = New StreamReader(strPath)

                While Not reader.EndOfStream

                    Dim line = reader.ReadLine()
                    Dim splitChars As Char() = {","}
                    Dim alarmInfo() = line.Split(splitChars)

                    ' ensure there aare three elements
                    If (alarmInfo.Length < 3) Then Continue While

                    Dim alarm = New Alarm()
                    alarm.Condition = AlarmCondition.InActive
                    alarm.ActiveOn = alarmInfo(0)
                    alarm.BitPosition = alarmInfo(1)
                    alarm.Description = alarmInfo(2)

                    Me.HistoricalAlarms.Add(alarm)

                End While

            End Using

        Catch ex As Exception
            _log.Error("Error loading historical alarms from disk, " & ex.ToString())
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub New(plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)

        Me._plcDriver = plcDriver
        Me.SystemAlarms = New List(Of Alarm)
        Me.HistoricalAlarms = New List(Of Alarm)

        LoadAlarmMessagesFromDisk()
        LoadHistoricalAlarmsFromDisk()

    End Sub


End Class

Public Class Alarm
    Implements ICloneable

    Public Condition As AlarmCondition
    Public Description As String
    Public BitPosition As Integer
    Public ActiveOn As DateTime

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim alarm As New Alarm
        alarm.BitPosition = Me.BitPosition
        alarm.ActiveOn = Me.ActiveOn
        alarm.Condition = Me.Condition
        alarm.Description = Me.Description

        Return alarm
    End Function
End Class
