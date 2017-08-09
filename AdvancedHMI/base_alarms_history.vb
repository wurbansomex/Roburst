
Public Class base_alarms_history

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private _alarmManager As AlarmManager

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged



        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        AlarmsActive(base_home.AlmInd.Visible)

        DisplayHistoricalAlarms()

    End Sub


    Private Sub PictureBox_key_Click(sender As Object, e As EventArgs) Handles PictureBox_key.Click
        pop_log_in_out.Show()
    End Sub

    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' initialise the alarm list view
        Me.HistoricalAlarmsListView.View = View.Details
        Me.HistoricalAlarmsListView.GridLines = True
        Me.HistoricalAlarmsListView.FullRowSelect = True
        Me.HistoricalAlarmsListView.HeaderStyle = ColumnHeaderStyle.None

        Me.HistoricalAlarmsListView.Columns.Add("", 120)
        Me.HistoricalAlarmsListView.Columns.Add("", 40)
        Me.HistoricalAlarmsListView.Columns.Add("", 375)


    End Sub


    Private Sub DisplayHistoricalAlarms()

        If (Me.Visible = False) Then Return
        If (Me._alarmManager Is Nothing) Then Return

        ' return list of active alarms in descending order
        Dim historicalAlarms = Me._alarmManager.HistoricalAlarms.OrderByDescending(Function(x) x.ActiveOn).Take(100)

        Me.HistoricalAlarmsListView.SuspendLayout()
        Me.HistoricalAlarmsListView.Items.Clear()

        For Each alarm In historicalAlarms

            Dim arr(3) As String
            arr(0) = alarm.ActiveOn.ToString("dd MMM yyyy HH:mm:ss")
            arr(1) = alarm.BitPosition.ToString("D4")
            arr(2) = alarm.Description

            Me.HistoricalAlarmsListView.Items.Add(New ListViewItem(arr))

        Next

        Me.HistoricalAlarmsListView.ResumeLayout()

    End Sub

    ''' <summary>
    ''' Can't pass in ctor as none of the forms in this app are instanatiated using New
    ''' </summary>
    ''' <param name="alarmManager"></param>
    ''' <remarks></remarks>
    Public Sub SetAlarmManager(ByRef alarmManager As AlarmManager)
        Me._alarmManager = alarmManager

    End Sub


    Private Sub ViewActiveAlarmBasicButton_Click(sender As Object, e As EventArgs) Handles ViewActiveAlarmBasicButton.Click
        Me.Visible = False
        base_alarms.Show()
    End Sub

    Private Sub base_alarms_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive

    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub
End Class
