
Public Class base_alarms

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0
    Private _alarmManager As AlarmManager

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        EthernetIPforCLXCom1.DisableSubscriptions = Not Me.Visible

        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        AlarmsActive(base_home.AlmInd.Visible)

        DisplayActiveAlarms()

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
        Me.AxctiveAlarmsListView.View = View.Details
        Me.AxctiveAlarmsListView.GridLines = True
        Me.AxctiveAlarmsListView.FullRowSelect = True
        Me.AxctiveAlarmsListView.HeaderStyle = ColumnHeaderStyle.None

        Me.AxctiveAlarmsListView.Columns.Add("", 120)
        Me.AxctiveAlarmsListView.Columns.Add("", 40)
        Me.AxctiveAlarmsListView.Columns.Add("", 375)


    End Sub


    Private Sub DisplayActiveAlarms()

        If (Me.Visible = False) Then Return
        If (Me._alarmManager Is Nothing) Then Return

        ' return list of active alarms in descending order
        Dim activeAlarms = Me._alarmManager.SystemAlarms.Where(Function(a) a.Condition = AlarmCondition.Active) _
                                                        .OrderByDescending(Function(x) x.ActiveOn) _
                                                        .ToList()

        Me.AxctiveAlarmsListView.SuspendLayout()
        Me.AxctiveAlarmsListView.Items.Clear()

        For Each alarm In activeAlarms

            Dim arr(3) As String
            arr(0) = alarm.ActiveOn.ToString("dd MMM yyyy HH:mm:ss")
            arr(1) = alarm.BitPosition.ToString("D4")
            arr(2) = alarm.Description

            Me.AxctiveAlarmsListView.Items.Add(New ListViewItem(arr))

        Next

        ' auto scroll 
        If (Me.AxctiveAlarmsListView.Items.Count > 0) Then
            Me.AxctiveAlarmsListView.Items(Me.AxctiveAlarmsListView.Items.Count - 1).EnsureVisible()
        End If

        Me.AxctiveAlarmsListView.ResumeLayout()

    End Sub

    ''' <summary>
    ''' Can't pass in ctor as none of the forms in this app are instanatiated using New
    ''' </summary>
    ''' <param name="alarmManager"></param>
    ''' <remarks></remarks>
    Public Sub SetAlarmManager(ByRef alarmManager As AlarmManager)
        Me._alarmManager = alarmManager

        ' subscribe to active alarms changed event
        AddHandler Me._alarmManager.ActiveAlarmsChanged, AddressOf DisplayActiveAlarms

    End Sub


    Private Sub AlarmHistoryBasicButton_Click(sender As Object, e As EventArgs) Handles AlarmHistoryButton.Click

        Me.Visible = False
        base_alarms_history.SetAlarmManager(Me._alarmManager)
        base_alarms_history.Show()

    End Sub

    Private Sub base_alarms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive

    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

End Class
