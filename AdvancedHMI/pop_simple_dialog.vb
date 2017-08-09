Public Class pop_simple_dialog

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private _messageToDisplay As String

    Private Sub pop_rec_loaded_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Property MessageToDisplay
        Get
            Return _messageToDisplay
        End Get
        Set(value)
            _messageToDisplay = value
            Me.OperatorPromptLabel.Text = _messageToDisplay
        End Set
    End Property

End Class