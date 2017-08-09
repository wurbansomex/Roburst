Imports log4net

Public Class pop_password_enter

    Private Shared _log As ILog = LogManager.GetLogger(GetType(pop_password_enter))
    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private oskProcess As Process

    Private Sub pop_password_enter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Blank the contents of the password text string
        PlcDriverUtilities.WritePlcValue("HMI.PasswordTry", "xxxxxxxx", EthernetIPforCLXCom1)

        'Start the on-screen keyboard
        OnScreenKeyBoardViewer.ShowOnScreenKeyboard()

        ' Check if user enters Carraige Return and attempt to log in the user
        AddHandler Me.PasswordTextBox.KeyDown, Sub(o, y)
                                                   If y.KeyCode = Keys.Return Then LoginUser()
                                               End Sub

        'Put the cursor at the start of the password box
        PasswordTextBox.Focus()
        PasswordTextBox.SelectionStart = 0

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If


    End Sub

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click

        LoginUser()

    End Sub

    Private Sub LoginUser()

        Try

            ' Write contents of password box to PLC tag
            PlcDriverUtilities.WritePlcValue("HMI.PasswordTry", PasswordTextBox.Text, EthernetIPforCLXCom1)
            PlcDriverUtilities.WritePlcValue("HMI.EnterPassword", 1, EthernetIPforCLXCom1)
            Threading.Thread.Sleep(500)
            PlcDriverUtilities.WritePlcValue("HMI.EnterPassword", 0, EthernetIPforCLXCom1)

            'Close on-screen keyboard
            OnScreenKeyBoardViewer.CloseOnScreenKeyboard()

            Me.Close()

        Catch ex As Exception
            _log.Error("Error logging in user, " & ex.Message)
        End Try

    End Sub


    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        'Close on-screen keyboard
        OnScreenKeyBoardViewer.CloseOnScreenKeyboard()

        Me.Close()

    End Sub

    Private Sub MessageDisplayByValue4_Click(sender As Object, e As EventArgs)

    End Sub

End Class