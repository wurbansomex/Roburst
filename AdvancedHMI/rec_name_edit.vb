Public Class rec_name_edit

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub


    Private oskProcess As Process

    'Start the on-screen keyboard when this form loads
    Private Sub rec_name_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OnScreenKeyBoardViewer.ShowOnScreenKeyboard()
        TextBox1.Focus()
        TextBox1.SelectionStart = 0


        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If


    End Sub

    

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles ConfirmEdits.Click

        PlcDriverUtilities.WritePlcValue("ProfileEdit.name", TextBox1.Text, Me.EthernetIPforCLXCom1)

        'Close on-screen keyboard
        OnScreenKeyBoardViewer.CloseOnScreenKeyboard()

        Me.Close()

    End Sub


    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelEdits.Click
        'Close on-screen keyboard
        OnScreenKeyBoardViewer.CloseOnScreenKeyboard()
        base_rec_edit.Show()
        Me.Close()


    End Sub




End Class