Public Class pop_log_in_out

    Private oskProcess As Process
    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    'Load event
    Private Sub pop_password_enter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub




    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles LoginBasicButton.Click

        ' using AdvancedHMI  BasicButon is far too slow and locks up the HMI
        PlcDriverUtilities.WritePlcValue("HMI.Logout", 1, Me.EthernetIPforCLXCom1)
        Threading.Thread.Sleep(500)
        PlcDriverUtilities.WritePlcValue("HMI.Logout", 0, Me.EthernetIPforCLXCom1)

        pop_password_enter.Show()
        Me.Close()
    End Sub



    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles LogoutBasicButton.Click

        ' using AdvancedHMI  BasicButon is far too slow and locks up the HMI
        PlcDriverUtilities.WritePlcValue("HMI.Logout", 1, Me.EthernetIPforCLXCom1)
        Threading.Thread.Sleep(500)
        PlcDriverUtilities.WritePlcValue("HMI.Logout", 0, Me.EthernetIPforCLXCom1)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelBasicButton.Click
        Me.Close()
    End Sub


End Class