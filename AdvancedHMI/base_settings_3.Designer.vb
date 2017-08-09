<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_settings_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_settings_3))
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.AppExit = New System.Windows.Forms.Button()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.SettingsPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TestSerialCommsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicButton4 = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator7 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator6 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.Settings1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.Settings2BasicButton = New AdvancedHMIControls.BasicButton()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsLabel
        '
        Me.SettingsLabel.BackColor = System.Drawing.Color.White
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsLabel.ForeColor = System.Drawing.Color.DimGray
        Me.SettingsLabel.Location = New System.Drawing.Point(196, 47)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(219, 40)
        Me.SettingsLabel.TabIndex = 271
        Me.SettingsLabel.Text = "Settings 3"
        Me.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 408
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(173, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 407
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
        Me.AlmInd.TabIndex = 378
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'AppExit
        '
        Me.AppExit.BackColor = System.Drawing.Color.Red
        Me.AppExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppExit.ForeColor = System.Drawing.Color.Black
        Me.AppExit.Image = CType(resources.GetObject("AppExit.Image"), System.Drawing.Image)
        Me.AppExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AppExit.Location = New System.Drawing.Point(513, 756)
        Me.AppExit.Margin = New System.Windows.Forms.Padding(4)
        Me.AppExit.Name = "AppExit"
        Me.AppExit.Size = New System.Drawing.Size(87, 44)
        Me.AppExit.TabIndex = 291
        Me.AppExit.Text = "Exit HMI"
        Me.AppExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AppExit.UseVisualStyleBackColor = False
        '
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenHomeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHomeButton.Image = CType(resources.GetObject("PgOpenHomeButton.Image"), System.Drawing.Image)
        Me.PgOpenHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(1, 756)
        Me.PgOpenHomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 289
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'SettingsPictureBox
        '
        Me.SettingsPictureBox.BackColor = System.Drawing.Color.White
        Me.SettingsPictureBox.Image = CType(resources.GetObject("SettingsPictureBox.Image"), System.Drawing.Image)
        Me.SettingsPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.SettingsPictureBox.Name = "SettingsPictureBox"
        Me.SettingsPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.SettingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SettingsPictureBox.TabIndex = 272
        Me.SettingsPictureBox.TabStop = False
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
        'TestSerialCommsTimer
        '
        Me.TestSerialCommsTimer.Interval = 1000
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 325
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.Timeout = 4000
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
        Me.AccessLevelLabel.TabIndex = 472
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'BasicLabel2
        '
        Me.BasicLabel2.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0.0R
        Me.BasicLabel2.KeypadMinValue = 0.0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(42, 176)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressHighlight = "HMILevel3Access"
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressVisible = "HMILevel3Access"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(310, 41)
        Me.BasicLabel2.TabIndex = 463
        Me.BasicLabel2.Text = "Show Mode NO Conveyor with Load Station with Bottle Dropping"
        Me.BasicLabel2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BasicLabel2.Value = "Show Mode NO Conveyor with Load Station with Bottle Dropping"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BasicLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(42, 121)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressHighlight = "HMILevel3Access"
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressVisible = "HMILevel3Access"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(310, 41)
        Me.BasicLabel1.TabIndex = 462
        Me.BasicLabel1.Text = "Show Mode NO Conveyor NO Load Station NO Bottle Dropping"
        Me.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BasicLabel1.Value = "Show Mode NO Conveyor NO Load Station NO Bottle Dropping"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton4.ForeColor = System.Drawing.Color.Black
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicButton4.Location = New System.Drawing.Point(473, 121)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton4.PLCAddressClick = "MainSeq.Bits[0].10"
        Me.BasicButton4.PLCAddressVisible = "HMILevel3Access"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(100, 96)
        Me.BasicButton4.TabIndex = 459
        Me.BasicButton4.Text = "Turn Off"
        Me.BasicButton4.TextAlternate = ""
        Me.BasicButton4.UseVisualStyleBackColor = True
        Me.BasicButton4.ValueToWrite = 1
        '
        'BasicIndicator7
        '
        Me.BasicIndicator7.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator7.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator7.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator7.Location = New System.Drawing.Point(470, 119)
        Me.BasicIndicator7.Name = "BasicIndicator7"
        Me.BasicIndicator7.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator7.OutlineWidth = 1
        Me.BasicIndicator7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator7.PLCAddressSelectColor2 = "MainSeq.Bits[0].10"
        Me.BasicIndicator7.PLCAddressVisible = "HMILevel3Access"
        Me.BasicIndicator7.SelectColor2 = True
        Me.BasicIndicator7.SelectColor3 = False
        Me.BasicIndicator7.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator7.Size = New System.Drawing.Size(106, 101)
        Me.BasicIndicator7.TabIndex = 461
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton3.ForeColor = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicButton3.Location = New System.Drawing.Point(359, 175)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton3.PLCAddressClick = "MainSeq.Bits[0].8"
        Me.BasicButton3.PLCAddressVisible = "HMILevel3Access"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(100, 40)
        Me.BasicButton3.TabIndex = 456
        Me.BasicButton3.Text = "Show Mode B"
        Me.BasicButton3.TextAlternate = ""
        Me.BasicButton3.UseVisualStyleBackColor = True
        Me.BasicButton3.ValueToWrite = 1
        '
        'BasicIndicator6
        '
        Me.BasicIndicator6.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator6.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator6.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator6.Location = New System.Drawing.Point(356, 172)
        Me.BasicIndicator6.Name = "BasicIndicator6"
        Me.BasicIndicator6.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator6.OutlineWidth = 1
        Me.BasicIndicator6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator6.PLCAddressSelectColor2 = "MainSeq.Bits[0].8"
        Me.BasicIndicator6.PLCAddressVisible = "HMILevel3Access"
        Me.BasicIndicator6.SelectColor2 = True
        Me.BasicIndicator6.SelectColor3 = False
        Me.BasicIndicator6.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator6.Size = New System.Drawing.Size(106, 45)
        Me.BasicIndicator6.TabIndex = 458
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicButton2.Location = New System.Drawing.Point(359, 124)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton2.PLCAddressClick = "MainSeq.Bits[0].6"
        Me.BasicButton2.PLCAddressVisible = "HMILevel3Access"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(100, 40)
        Me.BasicButton2.TabIndex = 453
        Me.BasicButton2.Text = "Show Mode A"
        Me.BasicButton2.TextAlternate = ""
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 1
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(356, 121)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "MainSeq.Bits[0].6"
        Me.BasicIndicator4.PLCAddressVisible = "HMILevel3Access"
        Me.BasicIndicator4.SelectColor2 = True
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator4.Size = New System.Drawing.Size(106, 45)
        Me.BasicIndicator4.TabIndex = 455
        '
        'Settings1BasicButton
        '
        Me.Settings1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Settings1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Settings1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Settings1BasicButton.Highlight = False
        Me.Settings1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Settings1BasicButton.Image = CType(resources.GetObject("Settings1BasicButton.Image"), System.Drawing.Image)
        Me.Settings1BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Settings1BasicButton.Location = New System.Drawing.Point(173, 756)
        Me.Settings1BasicButton.MaximumHoldTime = 3000
        Me.Settings1BasicButton.MinimumHoldTime = 500
        Me.Settings1BasicButton.Name = "Settings1BasicButton"
        Me.Settings1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Settings1BasicButton.PLCAddressClick = ""
        Me.Settings1BasicButton.SelectTextAlternate = False
        Me.Settings1BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.Settings1BasicButton.TabIndex = 411
        Me.Settings1BasicButton.Text = "Settings 1"
        Me.Settings1BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings1BasicButton.TextAlternate = Nothing
        Me.Settings1BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Settings1BasicButton.UseVisualStyleBackColor = True
        Me.Settings1BasicButton.ValueToWrite = 0
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(27, 5)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 405
        Me.CurrentDateTime.Text = "30-11-2016 14:53:53"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Settings2BasicButton
        '
        Me.Settings2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Settings2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Settings2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Settings2BasicButton.Highlight = False
        Me.Settings2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Settings2BasicButton.Image = CType(resources.GetObject("Settings2BasicButton.Image"), System.Drawing.Image)
        Me.Settings2BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Settings2BasicButton.Location = New System.Drawing.Point(326, 756)
        Me.Settings2BasicButton.MaximumHoldTime = 3000
        Me.Settings2BasicButton.MinimumHoldTime = 500
        Me.Settings2BasicButton.Name = "Settings2BasicButton"
        Me.Settings2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Settings2BasicButton.PLCAddressClick = ""
        Me.Settings2BasicButton.SelectTextAlternate = False
        Me.Settings2BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.Settings2BasicButton.TabIndex = 473
        Me.Settings2BasicButton.Text = "Settings 2"
        Me.Settings2BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings2BasicButton.TextAlternate = Nothing
        Me.Settings2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Settings2BasicButton.UseVisualStyleBackColor = True
        Me.Settings2BasicButton.ValueToWrite = 0
        '
        'base_settings_3
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 804)
        Me.Controls.Add(Me.Settings2BasicButton)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.BasicButton4)
        Me.Controls.Add(Me.BasicIndicator7)
        Me.Controls.Add(Me.BasicButton3)
        Me.Controls.Add(Me.BasicIndicator6)
        Me.Controls.Add(Me.BasicButton2)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.Settings1BasicButton)
        Me.Controls.Add(Me.AppExit)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.SettingsPictureBox)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_settings_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents AppExit As System.Windows.Forms.Button
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents Settings1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents TestSerialCommsTimer As System.Windows.Forms.Timer
    Friend WithEvents BasicButton4 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator7 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator6 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents Settings2BasicButton As AdvancedHMIControls.BasicButton
End Class
