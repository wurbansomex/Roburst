Public Class pop_profile_number

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0



    Private Sub pop_profile_paste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasteProfileButton_Click(sender As Object, e As EventArgs) Handles CreateProfileButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class