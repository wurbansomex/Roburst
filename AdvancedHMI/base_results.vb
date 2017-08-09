Imports System.Xml
Imports System.IO

Public Class base_results

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    Dim dailyXMLpath As String
    Dim dailyCSVpath As String

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPForCLXCom1.DisableSubscriptions = Not Me.Visible

        AlarmsActive(base_home.AlmInd.Visible)

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

    End Sub


    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles ResultsPictureBox.Click

    End Sub

    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
      pop_log_in_out.Show()
    End Sub



    Private Sub AlmInd_Click_1(sender As Object, e As EventArgs) Handles AlmInd.Click
        base_alarms.Show()
        Me.Visible = False
    End Sub

    Private Sub base_results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

    Private Sub ResultsLabel_Click(sender As Object, e As EventArgs) Handles ResultsLabel.Click

    End Sub

    Private Sub BasicLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OneMinuteValueBasicLabel_Click(sender As Object, e As EventArgs) Handles OneMinuteValueBasicLabel.Click

    End Sub
End Class
