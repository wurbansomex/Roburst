Public Class base_settings_3

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If


        ' kill the onscreen keyboard
        If (Not Me.Visible) Then
            PLCSettingsRepository.SavePlcSettings(Me.EthernetIPforCLXCom1)
            OnScreenKeyBoardViewer.CloseOnScreenKeyboard()
        End If


    End Sub


    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub


    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub AppExit_Click(sender As Object, e As EventArgs) Handles AppExit.Click

        pop_simple_dialog.MessageToDisplay = LanguageManager.GetUserMessage(LanguageManager.UserMessages.ShutdownPrompt)
        pop_simple_dialog.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(2000)

        ' close any open windows
        For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
            Dim form As Form = System.Windows.Forms.Application.OpenForms(i)

            ' don't close the dialog box
            If (form.Name = pop_simple_dialog.Name) Then Continue For

            form.Visible = False
            form.Close()
        Next i

        pop_simple_dialog.Close()
        Application.DoEvents()
        Application.Exit()
        End
    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub



    Private Sub base_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

    Private Sub Settings1BasicButton_Click(sender As Object, e As EventArgs) Handles Settings1BasicButton.Click
        base_settings.Show() 'Settings page 1
        Me.Visible = False
    End Sub


    Private Sub Settings2BasicButton_Click(sender As Object, e As EventArgs) Handles Settings2BasicButton.Click
        base_settings_2.Show() 'Settings page 1
        Me.Visible = False
    End Sub
End Class
