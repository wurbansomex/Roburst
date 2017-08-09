<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_sec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_sec))
        Me.SecurityLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.NewEngPassBox = New System.Windows.Forms.TextBox()
        Me.NewEngineeringPasswordBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.NewSupPassBox = New System.Windows.Forms.TextBox()
        Me.NewSupervisorPasswordBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.EngCancelBtn = New System.Windows.Forms.Button()
        Me.SupCancelBtn = New System.Windows.Forms.Button()
        Me.EngEnterBtn = New System.Windows.Forms.Button()
        Me.SupEnterBtn = New System.Windows.Forms.Button()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.SecurityPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SecurityLabel
        '
        Me.SecurityLabel.BackColor = System.Drawing.Color.White
        Me.SecurityLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityLabel.ForeColor = System.Drawing.Color.DimGray
        Me.SecurityLabel.Location = New System.Drawing.Point(196, 47)
        Me.SecurityLabel.Name = "SecurityLabel"
        Me.SecurityLabel.Size = New System.Drawing.Size(219, 40)
        Me.SecurityLabel.TabIndex = 271
        Me.SecurityLabel.Text = "Security"
        Me.SecurityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 165
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'NewEngPassBox
        '
        Me.NewEngPassBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewEngPassBox.Location = New System.Drawing.Point(33, 363)
        Me.NewEngPassBox.Name = "NewEngPassBox"
        Me.NewEngPassBox.Size = New System.Drawing.Size(280, 21)
        Me.NewEngPassBox.TabIndex = 293
        '
        'NewEngineeringPasswordBasicLabel
        '
        Me.NewEngineeringPasswordBasicLabel.AutoSize = True
        Me.NewEngineeringPasswordBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.NewEngineeringPasswordBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.NewEngineeringPasswordBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.NewEngineeringPasswordBasicLabel.DisplayAsTime = False
        Me.NewEngineeringPasswordBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewEngineeringPasswordBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NewEngineeringPasswordBasicLabel.Highlight = False
        Me.NewEngineeringPasswordBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.NewEngineeringPasswordBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.NewEngineeringPasswordBasicLabel.HighlightKeyCharacter = "!"
        Me.NewEngineeringPasswordBasicLabel.KeypadAlphaNumeric = False
        Me.NewEngineeringPasswordBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.NewEngineeringPasswordBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.NewEngineeringPasswordBasicLabel.KeypadMaxValue = 0.0R
        Me.NewEngineeringPasswordBasicLabel.KeypadMinValue = 0.0R
        Me.NewEngineeringPasswordBasicLabel.KeypadScaleFactor = 1.0R
        Me.NewEngineeringPasswordBasicLabel.KeypadShowCurrentValue = False
        Me.NewEngineeringPasswordBasicLabel.KeypadText = Nothing
        Me.NewEngineeringPasswordBasicLabel.KeypadWidth = 300
        Me.NewEngineeringPasswordBasicLabel.Location = New System.Drawing.Point(32, 325)
        Me.NewEngineeringPasswordBasicLabel.Name = "NewEngineeringPasswordBasicLabel"
        Me.NewEngineeringPasswordBasicLabel.NumericFormat = Nothing
        Me.NewEngineeringPasswordBasicLabel.PLCAddressKeypad = ""
        Me.NewEngineeringPasswordBasicLabel.PollRate = 0
        Me.NewEngineeringPasswordBasicLabel.Size = New System.Drawing.Size(213, 21)
        Me.NewEngineeringPasswordBasicLabel.TabIndex = 292
        Me.NewEngineeringPasswordBasicLabel.Text = "New engineering password:"
        Me.NewEngineeringPasswordBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.NewEngineeringPasswordBasicLabel.Value = "New engineering password:"
        Me.NewEngineeringPasswordBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewEngineeringPasswordBasicLabel.ValueLeftPadLength = 0
        Me.NewEngineeringPasswordBasicLabel.ValuePrefix = Nothing
        Me.NewEngineeringPasswordBasicLabel.ValueScaleFactor = 1.0R
        Me.NewEngineeringPasswordBasicLabel.ValueSuffix = Nothing
        '
        'NewSupPassBox
        '
        Me.NewSupPassBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupPassBox.Location = New System.Drawing.Point(33, 218)
        Me.NewSupPassBox.Name = "NewSupPassBox"
        Me.NewSupPassBox.Size = New System.Drawing.Size(280, 21)
        Me.NewSupPassBox.TabIndex = 291
        '
        'NewSupervisorPasswordBasicLabel
        '
        Me.NewSupervisorPasswordBasicLabel.AutoSize = True
        Me.NewSupervisorPasswordBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.NewSupervisorPasswordBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.NewSupervisorPasswordBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.NewSupervisorPasswordBasicLabel.DisplayAsTime = False
        Me.NewSupervisorPasswordBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupervisorPasswordBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NewSupervisorPasswordBasicLabel.Highlight = False
        Me.NewSupervisorPasswordBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.NewSupervisorPasswordBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.NewSupervisorPasswordBasicLabel.HighlightKeyCharacter = "!"
        Me.NewSupervisorPasswordBasicLabel.KeypadAlphaNumeric = False
        Me.NewSupervisorPasswordBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.NewSupervisorPasswordBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.NewSupervisorPasswordBasicLabel.KeypadMaxValue = 0.0R
        Me.NewSupervisorPasswordBasicLabel.KeypadMinValue = 0.0R
        Me.NewSupervisorPasswordBasicLabel.KeypadScaleFactor = 1.0R
        Me.NewSupervisorPasswordBasicLabel.KeypadShowCurrentValue = False
        Me.NewSupervisorPasswordBasicLabel.KeypadText = Nothing
        Me.NewSupervisorPasswordBasicLabel.KeypadWidth = 300
        Me.NewSupervisorPasswordBasicLabel.Location = New System.Drawing.Point(32, 178)
        Me.NewSupervisorPasswordBasicLabel.Name = "NewSupervisorPasswordBasicLabel"
        Me.NewSupervisorPasswordBasicLabel.NumericFormat = Nothing
        Me.NewSupervisorPasswordBasicLabel.PLCAddressKeypad = ""
        Me.NewSupervisorPasswordBasicLabel.PollRate = 0
        Me.NewSupervisorPasswordBasicLabel.Size = New System.Drawing.Size(201, 21)
        Me.NewSupervisorPasswordBasicLabel.TabIndex = 290
        Me.NewSupervisorPasswordBasicLabel.Text = "New supervisor password:"
        Me.NewSupervisorPasswordBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.NewSupervisorPasswordBasicLabel.Value = "New supervisor password:"
        Me.NewSupervisorPasswordBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewSupervisorPasswordBasicLabel.ValueLeftPadLength = 0
        Me.NewSupervisorPasswordBasicLabel.ValuePrefix = Nothing
        Me.NewSupervisorPasswordBasicLabel.ValueScaleFactor = 1.0R
        Me.NewSupervisorPasswordBasicLabel.ValueSuffix = Nothing
        '
        'EngCancelBtn
        '
        Me.EngCancelBtn.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.close47_24
        Me.EngCancelBtn.Location = New System.Drawing.Point(355, 353)
        Me.EngCancelBtn.Name = "EngCancelBtn"
        Me.EngCancelBtn.Size = New System.Drawing.Size(66, 44)
        Me.EngCancelBtn.TabIndex = 297
        Me.EngCancelBtn.UseVisualStyleBackColor = True
        '
        'SupCancelBtn
        '
        Me.SupCancelBtn.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.close47_24
        Me.SupCancelBtn.Location = New System.Drawing.Point(355, 208)
        Me.SupCancelBtn.Name = "SupCancelBtn"
        Me.SupCancelBtn.Size = New System.Drawing.Size(66, 44)
        Me.SupCancelBtn.TabIndex = 296
        Me.SupCancelBtn.UseVisualStyleBackColor = True
        '
        'EngEnterBtn
        '
        Me.EngEnterBtn.Image = CType(resources.GetObject("EngEnterBtn.Image"), System.Drawing.Image)
        Me.EngEnterBtn.Location = New System.Drawing.Point(427, 353)
        Me.EngEnterBtn.Name = "EngEnterBtn"
        Me.EngEnterBtn.Size = New System.Drawing.Size(66, 44)
        Me.EngEnterBtn.TabIndex = 295
        Me.EngEnterBtn.UseVisualStyleBackColor = True
        '
        'SupEnterBtn
        '
        Me.SupEnterBtn.Image = CType(resources.GetObject("SupEnterBtn.Image"), System.Drawing.Image)
        Me.SupEnterBtn.Location = New System.Drawing.Point(427, 208)
        Me.SupEnterBtn.Name = "SupEnterBtn"
        Me.SupEnterBtn.Size = New System.Drawing.Size(66, 44)
        Me.SupEnterBtn.TabIndex = 294
        Me.SupEnterBtn.UseVisualStyleBackColor = True
        '
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenHomeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHomeButton.Image = CType(resources.GetObject("PgOpenHomeButton.Image"), System.Drawing.Image)
        Me.PgOpenHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(1, 754)
        Me.PgOpenHomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 289
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'SecurityPictureBox
        '
        Me.SecurityPictureBox.BackColor = System.Drawing.Color.White
        Me.SecurityPictureBox.Image = CType(resources.GetObject("SecurityPictureBox.Image"), System.Drawing.Image)
        Me.SecurityPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.SecurityPictureBox.Name = "SecurityPictureBox"
        Me.SecurityPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.SecurityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SecurityPictureBox.TabIndex = 272
        Me.SecurityPictureBox.TabStop = False
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
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.Transparent
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bellRed
        Me.AlmInd.Location = New System.Drawing.Point(65, 56)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(34, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 378
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 408
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(175, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 407
        Me.PictureBox5.TabStop = False
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(29, 5)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 405
        Me.CurrentDateTime.Text = "05-12-2016 08:52:32"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AccessLevelLabel
        '
        Me.AccessLevelLabel.AutoSize = True
        Me.AccessLevelLabel.BackColor = System.Drawing.Color.White
        Me.AccessLevelLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.AccessLevelLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessLevelLabel.ForeColor = System.Drawing.Color.DimGray
        Me.AccessLevelLabel.HighlightColor = System.Drawing.Color.Red
        Me.AccessLevelLabel.HighlightColor2 = System.Drawing.Color.Red
        Me.AccessLevelLabel.HighlightKeyCharacter = "!"
        Me.AccessLevelLabel.HighlightKeyCharacter2 = "."
        Me.AccessLevelLabel.IniFileName = Nothing
        Me.AccessLevelLabel.Location = New System.Drawing.Point(199, 7)
        Me.AccessLevelLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Name = "AccessLevelLabel"
        Me.AccessLevelLabel.PLCAddressValue = "HMI.SecurityLevel"
        Me.AccessLevelLabel.PLCAddressVisible = ""
        Me.AccessLevelLabel.ShowMessageNumber = False
        Me.AccessLevelLabel.Size = New System.Drawing.Size(65, 19)
        Me.AccessLevelLabel.SpeakMessage = False
        Me.AccessLevelLabel.TabIndex = 409
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_sec
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.EngCancelBtn)
        Me.Controls.Add(Me.SupCancelBtn)
        Me.Controls.Add(Me.EngEnterBtn)
        Me.Controls.Add(Me.SupEnterBtn)
        Me.Controls.Add(Me.NewEngPassBox)
        Me.Controls.Add(Me.NewEngineeringPasswordBasicLabel)
        Me.Controls.Add(Me.NewSupPassBox)
        Me.Controls.Add(Me.NewSupervisorPasswordBasicLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.SecurityPictureBox)
        Me.Controls.Add(Me.SecurityLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_sec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Security"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SecurityPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SecurityLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents EngCancelBtn As System.Windows.Forms.Button
    Friend WithEvents SupCancelBtn As System.Windows.Forms.Button
    Friend WithEvents EngEnterBtn As System.Windows.Forms.Button
    Friend WithEvents SupEnterBtn As System.Windows.Forms.Button
    Friend WithEvents NewEngPassBox As System.Windows.Forms.TextBox
    Friend WithEvents NewEngineeringPasswordBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents NewSupPassBox As System.Windows.Forms.TextBox
    Friend WithEvents NewSupervisorPasswordBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
