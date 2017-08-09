

Public Class base_manual_2

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub


    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub


    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click

        PlcDriverUtilities.PulsePlcTag("MainSeq.Auto", True, Me.EthernetIPforCLXCom1)

        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub PgOpenManualButton_Click(sender As Object, e As EventArgs)
        base_manual.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicButton2_Click(sender As Object, e As EventArgs)
        base_manual_3.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicButton15_Click(sender As Object, e As EventArgs) Handles ManualMode1BasicButton.Click
        base_manual.Show() 'Manual Mode 1 page
        Me.Visible = False
    End Sub

    Private Sub BasicButton14_Click(sender As Object, e As EventArgs) Handles ManualMode2BasicButton.Click

    End Sub

    Private Sub PgOpenManualButton_Click_1(sender As Object, e As EventArgs) Handles ManualMode3BasicButton.Click
        base_manual_3.Show() 'Manual Mode 3 page
        Me.Visible = False
    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicIndicator10_Click(sender As Object, e As EventArgs) Handles BasicIndicator10.Click

    End Sub

    Private Sub TurretReadyLabel_Click(sender As Object, e As EventArgs) Handles TurretReadyLabel.Click

    End Sub

    Private Sub BasicIndicator2_Click(sender As Object, e As EventArgs) Handles BasicIndicator2.Click

    End Sub

    Private Sub TurretActiveLabel_Click(sender As Object, e As EventArgs) Handles TurretActiveLabel.Click

    End Sub

    Private Sub TurretFaultedLabel_Click(sender As Object, e As EventArgs) Handles TurretFaultedLabel.Click

    End Sub

    Private Sub TurretAtReferenceLabel_Click(sender As Object, e As EventArgs) Handles TurretAtReferenceLabel.Click

    End Sub

    Private Sub BasicIndicator7_Click(sender As Object, e As EventArgs) Handles BasicIndicator7.Click

    End Sub

    Private Sub BasicIndicator1_Click(sender As Object, e As EventArgs) Handles BasicIndicator1.Click

    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles TurretResetButton.Click

    End Sub

    Private Sub base_manual_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub
End Class
