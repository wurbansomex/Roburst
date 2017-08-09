

Public Class base_trend

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If components IsNot Nothing Then
            Dim drv As Drivers.IComComponent
            '*****************************
            '* Search for comm components
            '*****************************
            For i As Integer = 0 To components.Components.Count - 1
                If components.Components(i).GetType.GetInterface("Drivers.IComComponent") IsNot Nothing Then
                    '* 13-JUL-14 changed to directcast
                    drv = DirectCast(components.Components.Item(i), Drivers.IComComponent)
                    'drv = components.Components.Item(i)
                    '* Stop/Start polling based on form visibility
                    drv.DisableSubscriptions = Not Me.Visible
                End If
            Next
        End If

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub

    '************************************************************
    '* This will guarantee that even hidden forms are all closed
    '* when the main application is closed
    '************************************************************
    'Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Environment.Exit(0)
    'End Sub


    '**************************************
    '* Filling the form with a gradient
    '**************************************










    Private Sub DataSubscriber_alarms_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber_alarms.DataChanged
        'Set visibility of alarm indicator based on PLC bit Alarms.Active (from data subscriber)
        AlmInd.Visible = e.Values(0)
        'If e.Values(0) Then
        '    base_alarms.Show()
        '    Me.Visible = False
        'End If

    End Sub

    'Private _inactiveTimeRetriever As cIdleTimeStool

    'Private Sub InactivityTimer_Tick(sender As Object, e As EventArgs) Handles InactivityTimer.Tick
    '    'Calculates for how long we have been idle
    '    Dim inactiveTime = _inactiveTimeRetriever.GetInactiveTime

    '    If (inactiveTime.Value.TotalMinutes > 10) Then
    '        'Idle
    '        SecLevelZero()
    '    End If


    'End Sub

    ''Set the PLC variable containing the security level to zero
    'Private Sub SecLevelZero()
    '    EthernetIPforCLXCom1.Write("HMI.SecurityLevel", 0)
    'End Sub








    Private Sub LoadCurrentRecipe(sender As Object, e As EventArgs)
        Dim ActRecipe As Integer

        'Always edit the current recipe loaded
        ActRecipe = CInt(EthernetIPforCLXCom1.Read("RecipeLoad_index"))
        EthernetIPforCLXCom1.Write("RecipeIndex_Edit", ActRecipe)

        base_rec_edit.Show()
        Me.Visible = False
    End Sub



    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber_results.DataChanged
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub








    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub


    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub
End Class
