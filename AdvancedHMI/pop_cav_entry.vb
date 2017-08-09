Public Class pop_cav_entry

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelEntry.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles ConfirmEntry.Click

        Try
            ' using the BasicButton to write the PLC value is causing the HMI to lock up so
            ' writing here instead
            PlcDriverUtilities.WritePlcValue("Mould_Entry_Ack", 1, EthernetIPforCLXCom1)
            Threading.Thread.Sleep(500)
            PlcDriverUtilities.WritePlcValue("Mould_Entry_Ack", 0, EthernetIPforCLXCom1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub


    Private Sub pop_cav_entry_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub
End Class