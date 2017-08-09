Imports System.IO

Public Class base_help

    Private _selectedLanguage As LanguageManager.SupportedLanguages = 0

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged


        If _selectedLanguage <> base_home.SelectedLanguage Then
            _selectedLanguage = base_home.SelectedLanguage
            LanguageManager.TranslateControlsFor(Me, _selectedLanguage)
        End If

        If (Me.Visible) Then
            LoadHelpFiles()
        End If

        AlarmsActive(base_home.AlmInd.Visible)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        Me.HelpFilesTable.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))

        Dim link As LinkLabel = New LinkLabel()
        link.Text = "Click me"
        Me.HelpFilesTable.Controls.Add(link)

        Me.HelpFilesTable.RowCount += 1

    End Sub

    Private Sub base_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler base_home.AlarmsActive, AddressOf AlarmsActive
    End Sub
    Private Sub AlarmsActive(alarmState As Boolean)
        AlmInd.Visible = alarmState
    End Sub

    Private Sub HelpFileLinkClickHandler(sender As Object, e As LinkLabelLinkClickedEventArgs)

        '  the path to the help file is containedd in the tag of the linkLabel which
        ' generated this event
        Dim link As LinkLabel = CType(sender, LinkLabel)
        Try
            System.Diagnostics.Process.Start(CType(link.Tag, FileInfo).FullName)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub LoadHelpFiles()

        ' load all help files in the Help directory
        Dim fileCounter As Integer
        Dim strPath As String = HmiSettingsResolver.GetSettingValue("Misc", "HelpFilesPath").ToString()

        strPath = Path.Combine(strPath, base_home.SelectedLanguage.ToString())


        Me.HelpFilesTable.RowCount = 0
        Me.HelpFilesTable.RowStyles.Clear()
        Me.HelpFilesTable.SuspendLayout()
        Me.HelpFilesTable.Height = 0
        Me.HelpFilesTable.Controls.Clear()

        For Each file As FileInfo In New DirectoryInfo(strPath).GetFiles()

            fileCounter += 1

            ' add a link label to the helpFile table and encode the path to
            ' file in the labels tag property
            Dim link As New LinkLabel()
            link.Text = file.Name
            link.Tag = file
            link.ForeColor = Color.WhiteSmoke
            link.LinkColor = Color.White
            link.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            link.AutoSize = True
            link.Anchor = AnchorStyles.Left
            link.Margin = New Padding

            AddHandler link.LinkClicked, AddressOf HelpFileLinkClickHandler


            Dim fileNumber As New Label
            fileNumber.Text = fileCounter
            fileNumber.ForeColor = Color.WhiteSmoke
            fileNumber.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            fileNumber.Margin = New Padding(3)
            fileNumber.Anchor = AnchorStyles.Left


            ' add a new row to the table layout panel
            Me.HelpFilesTable.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
            Me.HelpFilesTable.Controls.Add(fileNumber)
            Me.HelpFilesTable.Controls.Add(link)

            Me.HelpFilesTable.Height += 35

        Next

        Me.HelpFilesTable.ResumeLayout()

    End Sub
End Class
