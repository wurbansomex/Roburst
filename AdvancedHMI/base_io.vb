

Public Class base_io

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If
    End Sub


    Private Sub DataSubscriber_results_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.Values(0) Then
            base_results.Show()
            Me.Visible = False
        End If
    End Sub








    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenIO2Button_Click(sender As Object, e As EventArgs) Handles DigitalOutputs2Button.Click
        base_io_5.Show() 'Digital Outputs 2 page
        Me.Visible = False
    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub SquareIlluminatedButton17_Click(sender As Object, e As EventArgs) Handles SquareIlluminatedButton17.Click

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DigitalInputs2Button.Click
        base_io_2.Show() 'Digital Inputs 2 page
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AnalogsButton.Click
        base_io_3.Show() 'Analogs page
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DigitalOutputs1Button.Click
        base_io_4.Show() 'Digital Outputs 1 page
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DigitalInputs1Button.Click

    End Sub

    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub base_io_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub
End Class
