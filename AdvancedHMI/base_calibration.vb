

Public Class base_calibration

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        AlarmsActive(base_home.AlmInd.Visible)

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

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub SaveCalibrationBasicButton_Click(sender As Object, e As EventArgs) Handles SaveCalibrationBasicButton.Click

        MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveThePressureGauge), _
                        LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveGauge), MessageBoxButtons.OK)

    End Sub

    Private Sub CancelBasicButton_Click(sender As Object, e As EventArgs) Handles CancelBasicButton.Click
        MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveThePressureGauge), _
                        LanguageManager.GetUserMessage(LanguageManager.UserMessages.RemoveGauge), MessageBoxButtons.OK)
    End Sub

    Private Sub SaveCalibrationPoint2BasicButton_Click(sender As Object, e As EventArgs) Handles SaveCalibrationPoint2BasicButton.Click

    End Sub

    Private Sub base_calibration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub
End Class
