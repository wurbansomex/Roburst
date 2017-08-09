Imports System.Windows.Forms
Imports System.Linq
Imports System.Collections.Generic
Imports System.Collections
Imports System.IO




Public Class LanguageManager

    Public Shared Translations As Dictionary(Of String, String)
    Public Shared AlarmTranslations As Dictionary(Of Integer, String)
    Public Shared UserMessageTranslations As Dictionary(Of Integer, String)
    Public Shared DefalultLanguage As SupportedLanguages

    Public Enum SupportedLanguages

        English = 1
        French = 2
        German = 3
        Spanish = 4
        Dutch = 5
        Italian = 6
        Czech = 7

    End Enum

    Public Enum UserMessages

        MessageNotFound = 0
        StopMachineBeforeChangingToManualPrompt = 1
        ClearOfBottlesPrompt = 2
        ConfirmationRequired = 3
        RemoveThePressureGauge = 4
        RemoveGauge = 5
        StopMachinePrompt = 6
        RetrievingMouldNumber = 7
        NoFreeSlotsOnConveyor = 8
        QuantityExceedsNumberOfFreeSlots = 9
        ShutdownPrompt = 10
        XMLResultFileSaveFailed = 11
        CouldNotCreateResultDirectory = 12
        ErrorGeneratingResultsFiles = 13
        ErrorCreatingRemoteDataManager = 14
        InvalidIPAddress = 15
        RequestMouldSet = 16
        ConfirmLoadingOfProfile = 17
        ProfileFileNotFound = 18
        ErrorLoadingProfiles = 19
        ConfirmSaveProfile = 20
        ProfileSaveComplete = 21
        ProfileLoadComplete = 22


    End Enum

    ''' <summary>
    ''' Reads the contents of the translation file for selected langugage
    ''' </summary>
    ''' <param name="language"></param>
    ''' <remarks></remarks>
    Public Shared Sub LoadTranslationsFor(language As SupportedLanguages)


        Dim strPath = HmiSettingsResolver.GetSettingValue("Misc", "LanguageFiles").ToString()

        strPath = strPath & Path.DirectorySeparatorChar &
                  language.ToString & Path.DirectorySeparatorChar & "Controls.txt"

        translations = New Dictionary(Of String, String)

        Using reader As New StreamReader(strPath)

            While Not reader.EndOfStream

                Dim line As String = reader.ReadLine
                Dim split As String() = line.Split("=")
                If (Not split.Count = 2) Then Continue While
                If (translations.ContainsKey(split(0))) Then Continue While

                translations.Add(split(0), split(1))

            End While

        End Using

    End Sub

    Public Shared Sub LoadAlarmsFor(language As SupportedLanguages)

        Dim strPath = HmiSettingsResolver.GetSettingValue("Misc", "LanguageFiles").ToString()

        strPath = strPath & Path.DirectorySeparatorChar &
                  language.ToString & Path.DirectorySeparatorChar & "Alarms.txt"

        alarmTranslations = New Dictionary(Of Integer, String)

        Using reader As New StreamReader(strPath)

            While Not reader.EndOfStream

                Dim line As String = reader.ReadLine
                Dim split As String() = line.Split("=")
                If (Not split.Count = 2) Then Continue While
                If (alarmTranslations.ContainsKey(split(0))) Then Continue While

                alarmTranslations.Add(CInt(split(0)), split(1))

            End While

        End Using

    End Sub

    Public Shared Sub LoadUserMessaagesFor(language As SupportedLanguages)

        Dim strPath = HmiSettingsResolver.GetSettingValue("Misc", "LanguageFiles").ToString()

        strPath = strPath & Path.DirectorySeparatorChar &
                  language.ToString & Path.DirectorySeparatorChar & "UserMessages.txt"

        UserMessageTranslations = New Dictionary(Of Integer, String)

        Using reader As New StreamReader(strPath)

            While Not reader.EndOfStream

                Dim line As String = reader.ReadLine
                Dim split As String() = line.Split("=")
                If (Not split.Count = 2) Then Continue While
                If (UserMessageTranslations.ContainsKey(split(0))) Then Continue While

                UserMessageTranslations.Add(CInt(split(0)), split(1))

            End While

        End Using

    End Sub


    Public Shared Function GetUserMessage(userMessage As UserMessages)

        Dim message = String.Empty
        If (UserMessageTranslations.ContainsKey(userMessage)) Then
            message = UserMessageTranslations(userMessage)
        Else
            message = String.Format(UserMessageTranslations(UserMessages.MessageNotFound), userMessage)
        End If

        Return message

    End Function


    ''' <summary>
    ''' Translates the text and caption properties for a children of control passed as
    ''' parameter
    ''' </summary>
    ''' <param name="control"></param>
    ''' <param name="language"></param>
    ''' <remarks></remarks>
    Public Shared Sub TranslateControlsFor(control As Form, language As SupportedLanguages)

        ' get all labels and command buttons and set their text and caption properties
        Dim labels = GetAllLabels(control)
        For Each label As Label In labels
            Dim lookupName As String = control.Name & "." & label.Name
            If (Not translations.ContainsKey(lookupName)) Then Continue For

            label.Text = translations(lookupName)
        Next

        Dim buttons = GetAllButtons(control)
        For Each button As Button In buttons
            Dim lookupName As String = control.Name & "." & button.Name
            If (Not translations.ContainsKey(lookupName)) Then Continue For

            button.Text = translations(lookupName)
        Next

    End Sub

   
    Public Shared Function GetAllButtons(control As Control) As IEnumerable(Of Control)

        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllButtons(ctrl)).Concat(controls).Where(Function(c) TypeOf c Is Button)
    End Function

    Public Shared Function GetAllLabels(control As Control) As IEnumerable(Of Control)

        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllButtons(ctrl)).Concat(controls).Where(Function(c) TypeOf c Is Label)
    End Function


End Class
