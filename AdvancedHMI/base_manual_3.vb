

Public Class base_manual_3

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

        If (Me.Visible) Then
            ' hide the conveyor vsd pic if setting disabled
            Dim showPic As Boolean = (PlcDriverUtilities.ReadPLCValue(Of Boolean)("TestStation.Bits[0].1", Me.EthernetIPforCLXCom1))
            Me.PictureBox7.Visible = showPic
            Me.CulletBinLabel.Visible = showPic
            Me.RetractedLabel.Visible = showPic
            Me.ExtendedLabel.Visible = showPic
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
        base_manual_2.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenManualButton_Click_1(sender As Object, e As EventArgs) Handles ManualMode3BasicButton.Click

    End Sub

    Private Sub BasicButton17_Click(sender As Object, e As EventArgs) Handles ManualMode1BasicButton.Click
        base_manual.Show() 'Manual Mode 1 page
        Me.Visible = False
    End Sub

    Private Sub BasicButton18_Click(sender As Object, e As EventArgs) Handles ManualMode2BasicButton.Click
        base_manual_2.Show() 'Manual Mode 2 page
        Me.Visible = False
    End Sub


    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub base_manual_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub
End Class
