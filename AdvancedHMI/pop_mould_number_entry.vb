Public Class pop_mould_number_entry

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0




    'End Sub
    Private Sub EnterBtn_Click(sender As Object, e As EventArgs)

        Try

            ' pulse bit in plc to initiate the paste operation
            PlcDriverUtilities.WritePlcValue("Index_ProfileEdit_Up", 1, EthernetIPforCLXCom1)
            System.Threading.Thread.Sleep(400)
            PlcDriverUtilities.WritePlcValue("Index_ProfileEdit_Up", 0, EthernetIPforCLXCom1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Close()
        End Try

    End Sub




    Private Sub pop_mould_number_entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Try

            ' check the quantity is <= number of free slots on conveyor
            Dim numberOfFreeSlots = PlcDriverUtilities.ReadPLCValue(Of Integer)("ConveyorFreeSlots", Me.EthernetIPforCLXCom1)
            If (numberOfFreeSlots = 0) Then
                MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.NoFreeSlotsOnConveyor), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If (Convert.ToInt32(Me.MouldQuantityBasicLabel.Text) > numberOfFreeSlots) Then
                MessageBox.Show(LanguageManager.GetUserMessage(LanguageManager.UserMessages.QuantityExceedsNumberOfFreeSlots), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            pop_cav_entry.ShowDialog()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        Finally

        End Try

    End Sub
End Class