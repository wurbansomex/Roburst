<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_manual_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_manual_2))
        Me.ManualMode2Label = New System.Windows.Forms.Label()
        Me.TurretLockLabel = New System.Windows.Forms.Label()
        Me.RetractedLabel = New System.Windows.Forms.Label()
        Me.ExtendedLabel = New System.Windows.Forms.Label()
        Me.TurretJogLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TestStationLabel = New System.Windows.Forms.Label()
        Me.LoadStationLabel = New System.Windows.Forms.Label()
        Me.FillStationLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.RetractBasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator9 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.AdvanceBasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator8 = New AdvancedHMIControls.BasicIndicator()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.ManualMode1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.ManualMode2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.ManualMode3BasicButton = New AdvancedHMIControls.BasicButton()
        Me.ReverseBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ForwardBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.ManualMode2PictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TurretFaultedLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator7 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretAtReferenceLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretActiveLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretReadyLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator10 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretResetButton = New AdvancedHMIControls.BasicButton()
        Me.TurretHomeLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretHomeButton = New AdvancedHMIControls.BasicButton()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManualMode2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManualMode2Label
        '
        Me.ManualMode2Label.BackColor = System.Drawing.Color.White
        Me.ManualMode2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode2Label.ForeColor = System.Drawing.Color.DimGray
        Me.ManualMode2Label.Location = New System.Drawing.Point(196, 47)
        Me.ManualMode2Label.Name = "ManualMode2Label"
        Me.ManualMode2Label.Size = New System.Drawing.Size(219, 40)
        Me.ManualMode2Label.TabIndex = 271
        Me.ManualMode2Label.Text = "Manual mode 2"
        Me.ManualMode2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TurretLockLabel
        '
        Me.TurretLockLabel.AutoSize = True
        Me.TurretLockLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretLockLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TurretLockLabel.Location = New System.Drawing.Point(55, 405)
        Me.TurretLockLabel.Name = "TurretLockLabel"
        Me.TurretLockLabel.Size = New System.Drawing.Size(89, 21)
        Me.TurretLockLabel.TabIndex = 392
        Me.TurretLockLabel.Text = "Turret lock"
        Me.TurretLockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RetractedLabel
        '
        Me.RetractedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetractedLabel.Location = New System.Drawing.Point(163, 426)
        Me.RetractedLabel.Name = "RetractedLabel"
        Me.RetractedLabel.Size = New System.Drawing.Size(104, 15)
        Me.RetractedLabel.TabIndex = 397
        Me.RetractedLabel.Text = "Unlocked"
        Me.RetractedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ExtendedLabel
        '
        Me.ExtendedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtendedLabel.Location = New System.Drawing.Point(160, 448)
        Me.ExtendedLabel.Name = "ExtendedLabel"
        Me.ExtendedLabel.Size = New System.Drawing.Size(105, 15)
        Me.ExtendedLabel.TabIndex = 395
        Me.ExtendedLabel.Text = "Locked"
        Me.ExtendedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TurretJogLabel
        '
        Me.TurretJogLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretJogLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TurretJogLabel.Location = New System.Drawing.Point(381, 607)
        Me.TurretJogLabel.Name = "TurretJogLabel"
        Me.TurretJogLabel.Size = New System.Drawing.Size(138, 21)
        Me.TurretJogLabel.TabIndex = 401
        Me.TurretJogLabel.Text = "Turret jog"
        Me.TurretJogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(9, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 10)
        Me.GroupBox1.TabIndex = 417
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 693)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 10)
        Me.GroupBox2.TabIndex = 418
        Me.GroupBox2.TabStop = False
        '
        'TestStationLabel
        '
        Me.TestStationLabel.AutoSize = True
        Me.TestStationLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestStationLabel.Location = New System.Drawing.Point(427, 425)
        Me.TestStationLabel.Name = "TestStationLabel"
        Me.TestStationLabel.Size = New System.Drawing.Size(114, 25)
        Me.TestStationLabel.TabIndex = 421
        Me.TestStationLabel.Text = "Test station"
        '
        'LoadStationLabel
        '
        Me.LoadStationLabel.AutoSize = True
        Me.LoadStationLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadStationLabel.Location = New System.Drawing.Point(76, 252)
        Me.LoadStationLabel.Name = "LoadStationLabel"
        Me.LoadStationLabel.Size = New System.Drawing.Size(122, 25)
        Me.LoadStationLabel.TabIndex = 420
        Me.LoadStationLabel.Text = "Load station"
        '
        'FillStationLabel
        '
        Me.FillStationLabel.AutoSize = True
        Me.FillStationLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillStationLabel.Location = New System.Drawing.Point(416, 196)
        Me.FillStationLabel.Name = "FillStationLabel"
        Me.FillStationLabel.Size = New System.Drawing.Size(103, 25)
        Me.FillStationLabel.TabIndex = 419
        Me.FillStationLabel.Text = "Fill station"
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
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(30, 5)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 422
        Me.CurrentDateTime.Text = "30-11-2016 14:52:46"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RetractBasicButton
        '
        Me.RetractBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.RetractBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RetractBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetractBasicButton.ForeColor = System.Drawing.Color.Black
        Me.RetractBasicButton.Highlight = False
        Me.RetractBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.RetractBasicButton.Location = New System.Drawing.Point(52, 434)
        Me.RetractBasicButton.MaximumHoldTime = 3000
        Me.RetractBasicButton.MinimumHoldTime = 500
        Me.RetractBasicButton.Name = "RetractBasicButton"
        Me.RetractBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RetractBasicButton.PLCAddressClick = "HMI.Manual[0].14"
        Me.RetractBasicButton.SelectTextAlternate = False
        Me.RetractBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.RetractBasicButton.TabIndex = 399
        Me.RetractBasicButton.Text = "Unlock"
        Me.RetractBasicButton.TextAlternate = "Retract"
        Me.RetractBasicButton.UseVisualStyleBackColor = True
        Me.RetractBasicButton.ValueToWrite = 1
        '
        'BasicIndicator9
        '
        Me.BasicIndicator9.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator9.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator9.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator9.Location = New System.Drawing.Point(50, 432)
        Me.BasicIndicator9.Name = "BasicIndicator9"
        Me.BasicIndicator9.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator9.OutlineWidth = 1
        Me.BasicIndicator9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator9.PLCAddressSelectColor2 = "NOT outTurret_Lock"
        Me.BasicIndicator9.SelectColor2 = True
        Me.BasicIndicator9.SelectColor3 = False
        Me.BasicIndicator9.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator9.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator9.TabIndex = 400
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(273, 426)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "inTurret_Unlocked"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator4.TabIndex = 396
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator3.Location = New System.Drawing.Point(273, 448)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor2 = "inTurret_Locked"
        Me.BasicIndicator3.SelectColor2 = False
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator3.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator3.TabIndex = 394
        '
        'AdvanceBasicButton
        '
        Me.AdvanceBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.AdvanceBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.AdvanceBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdvanceBasicButton.ForeColor = System.Drawing.Color.Black
        Me.AdvanceBasicButton.Highlight = False
        Me.AdvanceBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.AdvanceBasicButton.Location = New System.Drawing.Point(52, 471)
        Me.AdvanceBasicButton.MaximumHoldTime = 3000
        Me.AdvanceBasicButton.MinimumHoldTime = 500
        Me.AdvanceBasicButton.Name = "AdvanceBasicButton"
        Me.AdvanceBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.AdvanceBasicButton.PLCAddressClick = "HMI.Manual[0].13"
        Me.AdvanceBasicButton.SelectTextAlternate = False
        Me.AdvanceBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.AdvanceBasicButton.TabIndex = 393
        Me.AdvanceBasicButton.Text = "Lock"
        Me.AdvanceBasicButton.TextAlternate = ""
        Me.AdvanceBasicButton.UseVisualStyleBackColor = True
        Me.AdvanceBasicButton.ValueToWrite = 1
        '
        'BasicIndicator8
        '
        Me.BasicIndicator8.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator8.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator8.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator8.Location = New System.Drawing.Point(50, 469)
        Me.BasicIndicator8.Name = "BasicIndicator8"
        Me.BasicIndicator8.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator8.OutlineWidth = 1
        Me.BasicIndicator8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator8.PLCAddressSelectColor2 = "outTurret_Lock"
        Me.BasicIndicator8.SelectColor2 = True
        Me.BasicIndicator8.SelectColor3 = False
        Me.BasicIndicator8.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator8.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator8.TabIndex = 398
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 425
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(176, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox3.TabIndex = 424
        Me.PictureBox3.TabStop = False
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
        'ManualMode1BasicButton
        '
        Me.ManualMode1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ManualMode1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ManualMode1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.ManualMode1BasicButton.Highlight = False
        Me.ManualMode1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ManualMode1BasicButton.Image = CType(resources.GetObject("ManualMode1BasicButton.Image"), System.Drawing.Image)
        Me.ManualMode1BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualMode1BasicButton.Location = New System.Drawing.Point(194, 756)
        Me.ManualMode1BasicButton.MaximumHoldTime = 3000
        Me.ManualMode1BasicButton.MinimumHoldTime = 500
        Me.ManualMode1BasicButton.Name = "ManualMode1BasicButton"
        Me.ManualMode1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ManualMode1BasicButton.PLCAddressClick = ""
        Me.ManualMode1BasicButton.SelectTextAlternate = False
        Me.ManualMode1BasicButton.Size = New System.Drawing.Size(134, 44)
        Me.ManualMode1BasicButton.TabIndex = 409
        Me.ManualMode1BasicButton.Text = "Manual Mode 1"
        Me.ManualMode1BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualMode1BasicButton.TextAlternate = Nothing
        Me.ManualMode1BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ManualMode1BasicButton.UseVisualStyleBackColor = True
        Me.ManualMode1BasicButton.ValueToWrite = 0
        '
        'ManualMode2BasicButton
        '
        Me.ManualMode2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ManualMode2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ManualMode2BasicButton.Enabled = False
        Me.ManualMode2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.ManualMode2BasicButton.Highlight = False
        Me.ManualMode2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ManualMode2BasicButton.Image = CType(resources.GetObject("ManualMode2BasicButton.Image"), System.Drawing.Image)
        Me.ManualMode2BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualMode2BasicButton.Location = New System.Drawing.Point(329, 756)
        Me.ManualMode2BasicButton.MaximumHoldTime = 3000
        Me.ManualMode2BasicButton.MinimumHoldTime = 500
        Me.ManualMode2BasicButton.Name = "ManualMode2BasicButton"
        Me.ManualMode2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ManualMode2BasicButton.PLCAddressClick = ""
        Me.ManualMode2BasicButton.SelectTextAlternate = False
        Me.ManualMode2BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.ManualMode2BasicButton.TabIndex = 408
        Me.ManualMode2BasicButton.Text = "Manual Mode 2"
        Me.ManualMode2BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualMode2BasicButton.TextAlternate = Nothing
        Me.ManualMode2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ManualMode2BasicButton.UseVisualStyleBackColor = True
        Me.ManualMode2BasicButton.ValueToWrite = 0
        '
        'ManualMode3BasicButton
        '
        Me.ManualMode3BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ManualMode3BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ManualMode3BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode3BasicButton.ForeColor = System.Drawing.Color.Black
        Me.ManualMode3BasicButton.Highlight = False
        Me.ManualMode3BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ManualMode3BasicButton.Image = CType(resources.GetObject("ManualMode3BasicButton.Image"), System.Drawing.Image)
        Me.ManualMode3BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualMode3BasicButton.Location = New System.Drawing.Point(466, 756)
        Me.ManualMode3BasicButton.MaximumHoldTime = 3000
        Me.ManualMode3BasicButton.MinimumHoldTime = 500
        Me.ManualMode3BasicButton.Name = "ManualMode3BasicButton"
        Me.ManualMode3BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ManualMode3BasicButton.PLCAddressClick = ""
        Me.ManualMode3BasicButton.SelectTextAlternate = False
        Me.ManualMode3BasicButton.Size = New System.Drawing.Size(134, 44)
        Me.ManualMode3BasicButton.TabIndex = 407
        Me.ManualMode3BasicButton.Text = "Manual Mode 3"
        Me.ManualMode3BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualMode3BasicButton.TextAlternate = Nothing
        Me.ManualMode3BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ManualMode3BasicButton.UseVisualStyleBackColor = True
        Me.ManualMode3BasicButton.ValueToWrite = 0
        '
        'ReverseBasicButton
        '
        Me.ReverseBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ReverseBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ReverseBasicButton.Highlight = False
        Me.ReverseBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ReverseBasicButton.Image = CType(resources.GetObject("ReverseBasicButton.Image"), System.Drawing.Image)
        Me.ReverseBasicButton.Location = New System.Drawing.Point(475, 649)
        Me.ReverseBasicButton.MaximumHoldTime = 99999
        Me.ReverseBasicButton.MinimumHoldTime = 0
        Me.ReverseBasicButton.Name = "ReverseBasicButton"
        Me.ReverseBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ReverseBasicButton.PLCAddressClick = "HMI.Manual[0].15"
        Me.ReverseBasicButton.SelectTextAlternate = False
        Me.ReverseBasicButton.Size = New System.Drawing.Size(66, 44)
        Me.ReverseBasicButton.TabIndex = 404
        Me.ReverseBasicButton.TextAlternate = Nothing
        Me.ReverseBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ReverseBasicButton.UseVisualStyleBackColor = True
        Me.ReverseBasicButton.ValueToWrite = 0
        '
        'ForwardBasicButton
        '
        Me.ForwardBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ForwardBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ForwardBasicButton.Highlight = False
        Me.ForwardBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ForwardBasicButton.Image = CType(resources.GetObject("ForwardBasicButton.Image"), System.Drawing.Image)
        Me.ForwardBasicButton.Location = New System.Drawing.Point(403, 649)
        Me.ForwardBasicButton.MaximumHoldTime = 99999
        Me.ForwardBasicButton.MinimumHoldTime = 0
        Me.ForwardBasicButton.Name = "ForwardBasicButton"
        Me.ForwardBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ForwardBasicButton.PLCAddressClick = "HMI.Manual[0].16"
        Me.ForwardBasicButton.SelectTextAlternate = False
        Me.ForwardBasicButton.Size = New System.Drawing.Size(66, 44)
        Me.ForwardBasicButton.TabIndex = 403
        Me.ForwardBasicButton.TextAlternate = Nothing
        Me.ForwardBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ForwardBasicButton.UseVisualStyleBackColor = True
        Me.ForwardBasicButton.ValueToWrite = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Turret
        Me.PictureBox4.Location = New System.Drawing.Point(38, 162)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(523, 387)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 391
        Me.PictureBox4.TabStop = False
        '
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'ManualMode2PictureBox
        '
        Me.ManualMode2PictureBox.BackColor = System.Drawing.Color.White
        Me.ManualMode2PictureBox.Image = CType(resources.GetObject("ManualMode2PictureBox.Image"), System.Drawing.Image)
        Me.ManualMode2PictureBox.Location = New System.Drawing.Point(141, 47)
        Me.ManualMode2PictureBox.Name = "ManualMode2PictureBox"
        Me.ManualMode2PictureBox.Size = New System.Drawing.Size(46, 40)
        Me.ManualMode2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ManualMode2PictureBox.TabIndex = 272
        Me.ManualMode2PictureBox.TabStop = False
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
        'TurretFaultedLabel
        '
        Me.TurretFaultedLabel.AutoSize = True
        Me.TurretFaultedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretFaultedLabel.Location = New System.Drawing.Point(198, 664)
        Me.TurretFaultedLabel.Name = "TurretFaultedLabel"
        Me.TurretFaultedLabel.Size = New System.Drawing.Size(46, 15)
        Me.TurretFaultedLabel.TabIndex = 433
        Me.TurretFaultedLabel.Text = "Faulted"
        '
        'BasicIndicator7
        '
        Me.BasicIndicator7.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator7.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator7.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator7.Location = New System.Drawing.Point(176, 662)
        Me.BasicIndicator7.Name = "BasicIndicator7"
        Me.BasicIndicator7.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator7.OutlineWidth = 1
        Me.BasicIndicator7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator7.PLCAddressSelectColor2 = "TurretDrive:I.Faulted"
        Me.BasicIndicator7.SelectColor2 = False
        Me.BasicIndicator7.SelectColor3 = False
        Me.BasicIndicator7.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator7.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator7.TabIndex = 432
        '
        'TurretAtReferenceLabel
        '
        Me.TurretAtReferenceLabel.AutoSize = True
        Me.TurretAtReferenceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretAtReferenceLabel.Location = New System.Drawing.Point(198, 640)
        Me.TurretAtReferenceLabel.Name = "TurretAtReferenceLabel"
        Me.TurretAtReferenceLabel.Size = New System.Drawing.Size(71, 15)
        Me.TurretAtReferenceLabel.TabIndex = 431
        Me.TurretAtReferenceLabel.Text = "At reference"
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Location = New System.Drawing.Point(176, 638)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "TurretDrive:I.AtReference"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator1.TabIndex = 430
        '
        'TurretActiveLabel
        '
        Me.TurretActiveLabel.AutoSize = True
        Me.TurretActiveLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretActiveLabel.Location = New System.Drawing.Point(198, 617)
        Me.TurretActiveLabel.Name = "TurretActiveLabel"
        Me.TurretActiveLabel.Size = New System.Drawing.Size(40, 15)
        Me.TurretActiveLabel.TabIndex = 429
        Me.TurretActiveLabel.Text = "Active"
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Location = New System.Drawing.Point(176, 615)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "TurretDrive:I.Active"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator2.TabIndex = 428
        '
        'TurretReadyLabel
        '
        Me.TurretReadyLabel.AutoSize = True
        Me.TurretReadyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretReadyLabel.Location = New System.Drawing.Point(198, 593)
        Me.TurretReadyLabel.Name = "TurretReadyLabel"
        Me.TurretReadyLabel.Size = New System.Drawing.Size(39, 15)
        Me.TurretReadyLabel.TabIndex = 427
        Me.TurretReadyLabel.Text = "Ready"
        '
        'BasicIndicator10
        '
        Me.BasicIndicator10.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator10.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator10.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator10.Location = New System.Drawing.Point(176, 591)
        Me.BasicIndicator10.Name = "BasicIndicator10"
        Me.BasicIndicator10.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator10.OutlineWidth = 1
        Me.BasicIndicator10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator10.PLCAddressSelectColor2 = "TurretDrive:I.Ready"
        Me.BasicIndicator10.SelectColor2 = False
        Me.BasicIndicator10.SelectColor3 = False
        Me.BasicIndicator10.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator10.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator10.TabIndex = 426
        '
        'TurretResetButton
        '
        Me.TurretResetButton.BackColor = System.Drawing.SystemColors.Control
        Me.TurretResetButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.TurretResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretResetButton.ForeColor = System.Drawing.Color.Black
        Me.TurretResetButton.Highlight = False
        Me.TurretResetButton.HighlightColor = System.Drawing.Color.Green
        Me.TurretResetButton.Location = New System.Drawing.Point(66, 656)
        Me.TurretResetButton.MaximumHoldTime = 3000
        Me.TurretResetButton.MinimumHoldTime = 500
        Me.TurretResetButton.Name = "TurretResetButton"
        Me.TurretResetButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.TurretResetButton.PLCAddressClick = "HMI.Manual[1].5"
        Me.TurretResetButton.SelectTextAlternate = False
        Me.TurretResetButton.Size = New System.Drawing.Size(92, 32)
        Me.TurretResetButton.TabIndex = 434
        Me.TurretResetButton.Text = "Reset"
        Me.TurretResetButton.TextAlternate = ""
        Me.TurretResetButton.UseVisualStyleBackColor = True
        Me.TurretResetButton.ValueToWrite = 1
        '
        'TurretHomeLabel
        '
        Me.TurretHomeLabel.AutoSize = True
        Me.TurretHomeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretHomeLabel.Location = New System.Drawing.Point(198, 568)
        Me.TurretHomeLabel.Name = "TurretHomeLabel"
        Me.TurretHomeLabel.Size = New System.Drawing.Size(40, 15)
        Me.TurretHomeLabel.TabIndex = 436
        Me.TurretHomeLabel.Text = "Home"
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator5.Location = New System.Drawing.Point(176, 566)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "Local:1:I.Data.0"
        Me.BasicIndicator5.SelectColor2 = False
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator5.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator5.TabIndex = 435
        '
        'TurretHomeButton
        '
        Me.TurretHomeButton.BackColor = System.Drawing.SystemColors.Control
        Me.TurretHomeButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.TurretHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretHomeButton.ForeColor = System.Drawing.Color.Black
        Me.TurretHomeButton.Highlight = False
        Me.TurretHomeButton.HighlightColor = System.Drawing.Color.Green
        Me.TurretHomeButton.Location = New System.Drawing.Point(66, 559)
        Me.TurretHomeButton.MaximumHoldTime = 3000
        Me.TurretHomeButton.MinimumHoldTime = 500
        Me.TurretHomeButton.Name = "TurretHomeButton"
        Me.TurretHomeButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.TurretHomeButton.PLCAddressClick = "HMI.Manual[1].6"
        Me.TurretHomeButton.SelectTextAlternate = False
        Me.TurretHomeButton.Size = New System.Drawing.Size(92, 32)
        Me.TurretHomeButton.TabIndex = 437
        Me.TurretHomeButton.Text = "Home"
        Me.TurretHomeButton.TextAlternate = ""
        Me.TurretHomeButton.UseVisualStyleBackColor = True
        Me.TurretHomeButton.ValueToWrite = 1
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
        Me.AccessLevelLabel.TabIndex = 438
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_manual_2
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 742)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.TurretHomeButton)
        Me.Controls.Add(Me.TurretHomeLabel)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.TurretResetButton)
        Me.Controls.Add(Me.TurretFaultedLabel)
        Me.Controls.Add(Me.BasicIndicator7)
        Me.Controls.Add(Me.TurretAtReferenceLabel)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.TurretActiveLabel)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.TurretReadyLabel)
        Me.Controls.Add(Me.BasicIndicator10)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.TestStationLabel)
        Me.Controls.Add(Me.LoadStationLabel)
        Me.Controls.Add(Me.FillStationLabel)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ManualMode1BasicButton)
        Me.Controls.Add(Me.ManualMode2BasicButton)
        Me.Controls.Add(Me.ManualMode3BasicButton)
        Me.Controls.Add(Me.ReverseBasicButton)
        Me.Controls.Add(Me.ForwardBasicButton)
        Me.Controls.Add(Me.RetractedLabel)
        Me.Controls.Add(Me.ExtendedLabel)
        Me.Controls.Add(Me.TurretJogLabel)
        Me.Controls.Add(Me.RetractBasicButton)
        Me.Controls.Add(Me.BasicIndicator9)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.AdvanceBasicButton)
        Me.Controls.Add(Me.BasicIndicator8)
        Me.Controls.Add(Me.TurretLockLabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.ManualMode2PictureBox)
        Me.Controls.Add(Me.ManualMode2Label)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_manual_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Manual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManualMode2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ManualMode2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ManualMode2Label As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TurretLockLabel As System.Windows.Forms.Label
    Friend WithEvents RetractBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator9 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents RetractedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ExtendedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents AdvanceBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator8 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretJogLabel As System.Windows.Forms.Label
    Friend WithEvents ReverseBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ForwardBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ManualMode1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ManualMode2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ManualMode3BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents TestStationLabel As System.Windows.Forms.Label
    Friend WithEvents LoadStationLabel As System.Windows.Forms.Label
    Friend WithEvents FillStationLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents TurretFaultedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator7 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretAtReferenceLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretActiveLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretReadyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator10 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretResetButton As AdvancedHMIControls.BasicButton
    Friend WithEvents TurretHomeLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretHomeButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
