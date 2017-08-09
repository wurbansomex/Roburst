Public Class pop_rec_loaded

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    Private Sub pop_rec_loaded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(236, 240)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub

    Private Sub BasicButton7_Click(sender As Object, e As EventArgs) Handles OkBasicButton.Click
        Me.Close()
    End Sub



End Class