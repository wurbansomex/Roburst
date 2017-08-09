<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_alarms_history
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_alarms_history))
        Me.AlarmsLabel = New System.Windows.Forms.Label()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.HistoricalAlarmsListView = New System.Windows.Forms.ListView()
        Me.AlarmTimeLabel = New System.Windows.Forms.Label()
        Me.AlarmCodeLabel = New System.Windows.Forms.Label()
        Me.AlarmMessageLabel = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ViewActiveAlarmBasicButton = New AdvancedHMIControls.BasicButton()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlarmsLabel
        '
        Me.AlarmsLabel.BackColor = System.Drawing.Color.White
        Me.AlarmsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmsLabel.ForeColor = System.Drawing.Color.DimGray
        Me.AlarmsLabel.Location = New System.Drawing.Point(196, 47)
        Me.AlarmsLabel.Name = "AlarmsLabel"
        Me.AlarmsLabel.Size = New System.Drawing.Size(219, 40)
        Me.AlarmsLabel.TabIndex = 271
        Me.AlarmsLabel.Text = "Alarms Hist"
        Me.AlarmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(28, 4)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 401
        Me.CurrentDateTime.Text = "07-12-2016 12:15:06"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'HistoricalAlarmsListView
        '
        Me.HistoricalAlarmsListView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoricalAlarmsListView.Location = New System.Drawing.Point(22, 142)
        Me.HistoricalAlarmsListView.Name = "HistoricalAlarmsListView"
        Me.HistoricalAlarmsListView.Size = New System.Drawing.Size(566, 537)
        Me.HistoricalAlarmsListView.TabIndex = 405
        Me.HistoricalAlarmsListView.UseCompatibleStateImageBehavior = False
        '
        'AlarmTimeLabel
        '
        Me.AlarmTimeLabel.AutoSize = True
        Me.AlarmTimeLabel.Location = New System.Drawing.Point(20, 126)
        Me.AlarmTimeLabel.Name = "AlarmTimeLabel"
        Me.AlarmTimeLabel.Size = New System.Drawing.Size(34, 13)
        Me.AlarmTimeLabel.TabIndex = 406
        Me.AlarmTimeLabel.Text = "Time"
        '
        'AlarmCodeLabel
        '
        Me.AlarmCodeLabel.AutoSize = True
        Me.AlarmCodeLabel.Location = New System.Drawing.Point(143, 126)
        Me.AlarmCodeLabel.Name = "AlarmCodeLabel"
        Me.AlarmCodeLabel.Size = New System.Drawing.Size(36, 13)
        Me.AlarmCodeLabel.TabIndex = 407
        Me.AlarmCodeLabel.Text = "Code"
        '
        'AlarmMessageLabel
        '
        Me.AlarmMessageLabel.AutoSize = True
        Me.AlarmMessageLabel.Location = New System.Drawing.Point(189, 126)
        Me.AlarmMessageLabel.Name = "AlarmMessageLabel"
        Me.AlarmMessageLabel.Size = New System.Drawing.Size(57, 13)
        Me.AlarmMessageLabel.TabIndex = 408
        Me.AlarmMessageLabel.Text = "Message"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 404
        Me.PictureBox6.TabStop = False
        '
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.Transparent
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bellRed
        Me.AlmInd.Location = New System.Drawing.Point(65, 56)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(34, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 297
        Me.AlmInd.TabStop = False
        '
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenHomeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHomeButton.Image = CType(resources.GetObject("PgOpenHomeButton.Image"), System.Drawing.Image)
        Me.PgOpenHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(0, 755)
        Me.PgOpenHomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 290
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.calendar
        Me.PictureBox3.Location = New System.Drawing.Point(141, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 272
        Me.PictureBox3.TabStop = False
        '
        'PictureBox_key
        '
        Me.PictureBox_key.BackColor = System.Drawing.Color.White
        Me.PictureBox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_key.Image = CType(resources.GetObject("PictureBox_key.Image"), System.Drawing.Image)
        Me.PictureBox_key.Location = New System.Drawing.Point(13, 56)
        Me.PictureBox_key.Name = "PictureBox_key"
        Me.PictureBox_key.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox_key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_key.TabIndex = 120
        Me.PictureBox_key.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.innovation
        Me.PictureBox1.Location = New System.Drawing.Point(421, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 62)
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(600, 95)
        Me.PictureBox2.TabIndex = 287
        Me.PictureBox2.TabStop = False
        '
        'ViewActiveAlarmBasicButton
        '
        Me.ViewActiveAlarmBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ViewActiveAlarmBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewActiveAlarmBasicButton.ForeColor = System.Drawing.Color.Black
        Me.ViewActiveAlarmBasicButton.Highlight = False
        Me.ViewActiveAlarmBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ViewActiveAlarmBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bell72
        Me.ViewActiveAlarmBasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ViewActiveAlarmBasicButton.Location = New System.Drawing.Point(421, 685)
        Me.ViewActiveAlarmBasicButton.MaximumHoldTime = 3000
        Me.ViewActiveAlarmBasicButton.MinimumHoldTime = 500
        Me.ViewActiveAlarmBasicButton.Name = "ViewActiveAlarmBasicButton"
        Me.ViewActiveAlarmBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ViewActiveAlarmBasicButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ViewActiveAlarmBasicButton.PLCAddressClick = ""
        Me.ViewActiveAlarmBasicButton.SelectTextAlternate = False
        Me.ViewActiveAlarmBasicButton.Size = New System.Drawing.Size(167, 42)
        Me.ViewActiveAlarmBasicButton.TabIndex = 410
        Me.ViewActiveAlarmBasicButton.Text = "Alarms"
        Me.ViewActiveAlarmBasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewActiveAlarmBasicButton.TextAlternate = Nothing
        Me.ViewActiveAlarmBasicButton.UseVisualStyleBackColor = True
        Me.ViewActiveAlarmBasicButton.ValueToWrite = 1
        '
        'base_alarms_history
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.ViewActiveAlarmBasicButton)
        Me.Controls.Add(Me.AlarmMessageLabel)
        Me.Controls.Add(Me.AlarmCodeLabel)
        Me.Controls.Add(Me.AlarmTimeLabel)
        Me.Controls.Add(Me.HistoricalAlarmsListView)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.AlarmsLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_alarms_history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.AlarmHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents AlarmsLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents HistoricalAlarmsListView As System.Windows.Forms.ListView
    Friend WithEvents AlarmMessageLabel As System.Windows.Forms.Label
    Friend WithEvents AlarmCodeLabel As System.Windows.Forms.Label
    Friend WithEvents AlarmTimeLabel As System.Windows.Forms.Label
    Friend WithEvents ViewActiveAlarmBasicButton As AdvancedHMIControls.BasicButton
End Class
