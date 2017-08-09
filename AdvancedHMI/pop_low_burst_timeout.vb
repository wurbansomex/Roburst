Public Class pop_low_burst_timeout

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    Private Sub pop_rec_loaded_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub



    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Try
            PlcDriverUtilities.WritePlcValue("TestStation.Bits[0].0", 1, EthernetIPforCLXCom1)
            System.Threading.Thread.Sleep(500)
            PlcDriverUtilities.WritePlcValue("TestStation.Bits[0].0", 0, EthernetIPforCLXCom1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Hide()
    End Sub
End Class