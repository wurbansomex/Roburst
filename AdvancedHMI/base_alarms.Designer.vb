<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_alarms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_alarms))
        Me.AlarmsLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.AxctiveAlarmsListView = New System.Windows.Forms.ListView()
        Me.AlarmTimeLabel = New System.Windows.Forms.Label()
        Me.AlarmCodeLabel = New System.Windows.Forms.Label()
        Me.AlarmMessageLabel = New System.Windows.Forms.Label()
        Me.AlarmHistoryButton = New AdvancedHMIControls.BasicButton()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.AcknowledgeBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MessageDisplayByValue1 = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.AlarmsLabel.Text = "Alarms"
        Me.AlarmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 425
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.Timeout = 4000
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
        Me.CurrentDateTime.Text = "30-11-2016 14:49:56"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AxctiveAlarmsListView
        '
        Me.AxctiveAlarmsListView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxctiveAlarmsListView.ForeColor = System.Drawing.Color.Firebrick
        Me.AxctiveAlarmsListView.Location = New System.Drawing.Point(22, 142)
        Me.AxctiveAlarmsListView.Name = "AxctiveAlarmsListView"
        Me.AxctiveAlarmsListView.ShowItemToolTips = True
        Me.AxctiveAlarmsListView.Size = New System.Drawing.Size(566, 511)
        Me.AxctiveAlarmsListView.TabIndex = 405
        Me.AxctiveAlarmsListView.UseCompatibleStateImageBehavior = False
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
        Me.AlarmMessageLabel.Location = New System.Drawing.Point(188, 126)
        Me.AlarmMessageLabel.Name = "AlarmMessageLabel"
        Me.AlarmMessageLabel.Size = New System.Drawing.Size(57, 13)
        Me.AlarmMessageLabel.TabIndex = 408
        Me.AlarmMessageLabel.Text = "Message"
        '
        'AlarmHistoryButton
        '
        Me.AlarmHistoryButton.BackColor = System.Drawing.SystemColors.Control
        Me.AlarmHistoryButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.AlarmHistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmHistoryButton.ForeColor = System.Drawing.Color.Black
        Me.AlarmHistoryButton.Highlight = False
        Me.AlarmHistoryButton.HighlightColor = System.Drawing.Color.Green
        Me.AlarmHistoryButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.calendar
        Me.AlarmHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AlarmHistoryButton.Location = New System.Drawing.Point(23, 668)
        Me.AlarmHistoryButton.MaximumHoldTime = 3000
        Me.AlarmHistoryButton.MinimumHoldTime = 500
        Me.AlarmHistoryButton.Name = "AlarmHistoryButton"
        Me.AlarmHistoryButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.AlarmHistoryButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AlarmHistoryButton.PLCAddressClick = ""
        Me.AlarmHistoryButton.SelectTextAlternate = False
        Me.AlarmHistoryButton.Size = New System.Drawing.Size(167, 42)
        Me.AlarmHistoryButton.TabIndex = 409
        Me.AlarmHistoryButton.Text = "History"
        Me.AlarmHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AlarmHistoryButton.TextAlternate = Nothing
        Me.AlarmHistoryButton.UseVisualStyleBackColor = True
        Me.AlarmHistoryButton.ValueToWrite = 1
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
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(174, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 403
        Me.PictureBox5.TabStop = False
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
        'AcknowledgeBasicButton
        '
        Me.AcknowledgeBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.AcknowledgeBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.AcknowledgeBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcknowledgeBasicButton.ForeColor = System.Drawing.Color.Black
        Me.AcknowledgeBasicButton.Highlight = False
        Me.AcknowledgeBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.AcknowledgeBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.ackAlarms
        Me.AcknowledgeBasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AcknowledgeBasicButton.Location = New System.Drawing.Point(421, 668)
        Me.AcknowledgeBasicButton.MaximumHoldTime = 3000
        Me.AcknowledgeBasicButton.MinimumHoldTime = 500
        Me.AcknowledgeBasicButton.Name = "AcknowledgeBasicButton"
        Me.AcknowledgeBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.AcknowledgeBasicButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AcknowledgeBasicButton.PLCAddressClick = "Alarms.Acknowledge"
        Me.AcknowledgeBasicButton.SelectTextAlternate = False
        Me.AcknowledgeBasicButton.Size = New System.Drawing.Size(167, 42)
        Me.AcknowledgeBasicButton.TabIndex = 295
        Me.AcknowledgeBasicButton.Text = "Acknowledge"
        Me.AcknowledgeBasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AcknowledgeBasicButton.TextAlternate = Nothing
        Me.AcknowledgeBasicButton.UseVisualStyleBackColor = True
        Me.AcknowledgeBasicButton.ValueToWrite = 1
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
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
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
        'MessageDisplayByValue1
        '
        Me.MessageDisplayByValue1.AutoSize = True
        Me.MessageDisplayByValue1.BackColor = System.Drawing.Color.White
        Me.MessageDisplayByValue1.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplayByValue1.ForeColor = System.Drawing.Color.DimGray
        Me.MessageDisplayByValue1.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue1.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue1.IniFileName = Nothing
        Me.MessageDisplayByValue1.Location = New System.Drawing.Point(199, 7)
        Me.MessageDisplayByValue1.Margin = New System.Windows.Forms.Padding(0)
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Name = "MessageDisplayByValue1"
        Me.MessageDisplayByValue1.PLCAddressValue = "HMI.SecurityLevel"
        Me.MessageDisplayByValue1.PLCAddressVisible = ""
        Me.MessageDisplayByValue1.ShowMessageNumber = False
        Me.MessageDisplayByValue1.Size = New System.Drawing.Size(65, 19)
        Me.MessageDisplayByValue1.SpeakMessage = False
        Me.MessageDisplayByValue1.TabIndex = 410
        Me.MessageDisplayByValue1.Text = "Operator"
        Me.MessageDisplayByValue1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MessageDisplayByValue1.TextPrefix = Nothing
        Me.MessageDisplayByValue1.Value = 0
        '
        'base_alarms
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.MessageDisplayByValue1)
        Me.Controls.Add(Me.AlarmHistoryButton)
        Me.Controls.Add(Me.AlarmMessageLabel)
        Me.Controls.Add(Me.AlarmCodeLabel)
        Me.Controls.Add(Me.AlarmTimeLabel)
        Me.Controls.Add(Me.AxctiveAlarmsListView)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.AcknowledgeBasicButton)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.AlarmsLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_alarms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvancedHMI v3.97c"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents AcknowledgeBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents AxctiveAlarmsListView As System.Windows.Forms.ListView
    Friend WithEvents AlarmMessageLabel As System.Windows.Forms.Label
    Friend WithEvents AlarmCodeLabel As System.Windows.Forms.Label
    Friend WithEvents AlarmTimeLabel As System.Windows.Forms.Label
    Friend WithEvents AlarmHistoryButton As AdvancedHMIControls.BasicButton
    Friend WithEvents MessageDisplayByValue1 As AdvancedHMIControls.MessageDisplayByValue
End Class
