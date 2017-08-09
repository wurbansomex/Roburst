

Public Class base_devices

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
            Dim showPic As Boolean = Not (PlcDriverUtilities.ReadPLCValue(Of Boolean)("Conveyor.Bits[0].0", Me.EthernetIPforCLXCom1))
            Me.ConveyorVSDPictureBox.Visible = showPic
            Me.ConveyorVsdLabel.Visible = showPic
            Me.ConveyorReadyLabel.Visible = showPic
            Me.ConveyorActiveLabel.Visible = showPic
            Me.ConveyorAtReferenceLabel.Visible = showPic
            Me.ConveyorFaultedLabel.Visible = showPic
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

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub


    Private Sub base_devices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

    Private Sub ConveyorVSDPictureBox_Click(sender As Object, e As EventArgs) Handles ConveyorVSDPictureBox.Click

    End Sub

    Private Sub ConveyorVsdLabel_Click(sender As Object, e As EventArgs) Handles ConveyorVsdLabel.Click

    End Sub
End Class
