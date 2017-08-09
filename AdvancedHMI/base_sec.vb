Public Class base_sec

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private securityLevel As Integer = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        SecurityLevelChanged()

    End Sub




    Private Sub base_sec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Make the password edit fields initially invisible
        NewSupPassBox.Visible = False
        SupCancelBtn.Visible = False
        SupEnterBtn.Visible = False
        NewEngPassBox.Visible = False
        EngCancelBtn.Visible = False
        EngEnterBtn.Visible = False


        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub


    'Place the cursor at the start of the text box and open the on-screen-keyboard
    Private Sub NewSupPassBox_Click(sender As Object, e As EventArgs) Handles NewSupPassBox.Click
        'OSK_start()
        NewSupPassBox.Focus()
        NewSupPassBox.SelectionStart = 0
    End Sub

    'Place the cursor at the start of the text box and open the on-screen keyboard
    Private Sub NewEngPassBox_Click(sender As Object, e As EventArgs) Handles NewEngPassBox.Click
        'OSK_start()
        NewEngPassBox.Focus()
        NewEngPassBox.SelectionStart = 0
    End Sub



    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        Me.Close()
        base_home.Show()
    End Sub

    'Enter button, new supervisor password
    Private Sub SupEnterBtn_Click(sender As Object, e As EventArgs) Handles SupEnterBtn.Click
        PlcDriverUtilities.WritePlcValue("HMI.PasswordEdit", NewSupPassBox.Text, EthernetIPforCLXCom1)
        PlcDriverUtilities.WritePlcValue("HMI.EnterNewLevel1", 1, EthernetIPforCLXCom1)
        'OSK_close()
        NewSupPassBox.Clear()
        MsgBox("Password changed")
    End Sub

    'Enter button, new engineering password
    Private Sub EngEnterBtn_Click(sender As Object, e As EventArgs) Handles EngEnterBtn.Click
        PlcDriverUtilities.WritePlcValue("HMI.PasswordEdit", NewEngPassBox.Text, EthernetIPforCLXCom1)
        PlcDriverUtilities.WritePlcValue("HMI.EnterNewLevel2", 1, EthernetIPforCLXCom1)
        'OSK_close()
        NewSupPassBox.Clear()
        MsgBox("Password changed")
    End Sub

    Private Sub SupCancelBtn_Click(sender As Object, e As EventArgs) Handles SupCancelBtn.Click
        NewSupPassBox.Clear()
        'OSK_close()
    End Sub

    Private Sub EngCancelBtn_Click(sender As Object, e As EventArgs) Handles EngCancelBtn.Click
        NewEngPassBox.Clear()
        'OSK_close()
    End Sub

    Private Sub DataSubscriber_alarms_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        'Set visibility of alarm indicator based on PLC bit Alarms.Active (from data subscriber)
        AlmInd.Visible = e.Values(0)
    End Sub

    Private Sub SecurityLevelChanged()
        'Set visibility of password edit fields based on PLC tag HMI.SecurityLevel

        If securityLevel >= 1 Then
            NewSupPassBox.Visible = True
            SupCancelBtn.Visible = True
            SupEnterBtn.Visible = True
        End If

        If securityLevel >= 2 Then
            NewEngPassBox.Visible = True
            EngCancelBtn.Visible = True
            EngEnterBtn.Visible = True
        End If

        If securityLevel = 0 Then
            NewEngPassBox.Visible = False
            EngCancelBtn.Visible = False
            EngEnterBtn.Visible = False
            NewSupPassBox.Visible = False
            SupCancelBtn.Visible = False
            SupEnterBtn.Visible = False

        End If



    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub MessageDisplayByValue4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Public Sub PassParameter(securityLevel As Integer)
        Me.securityLevel = securityLevel
        SecurityLevelChanged()
    End Sub

End Class


