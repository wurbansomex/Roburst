<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_manual))
        Me.ManualMode1Label = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.HomeBasicButton = New AdvancedHMIControls.BasicButton()
        Me.TargetPositionLabel = New System.Windows.Forms.Label()
        Me.TargetPositionValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PickUnitCurrentPositionLabel = New System.Windows.Forms.Label()
        Me.PickUnitCurrentPosition = New AdvancedHMIControls.BasicLabel()
        Me.PickUnitLabel = New System.Windows.Forms.Label()
        Me.CloseBasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.OpenBasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.ContainerClampLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Advance1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.ClampOpenLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.Retracted1Label = New System.Windows.Forms.Label()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.Retracted2Label = New System.Windows.Forms.Label()
        Me.BasicIndicator6 = New AdvancedHMIControls.BasicIndicator()
        Me.Extended2Label = New System.Windows.Forms.Label()
        Me.BasicIndicator7 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator8 = New AdvancedHMIControls.BasicIndicator()
        Me.Retract1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator9 = New AdvancedHMIControls.BasicIndicator()
        Me.Retract2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator10 = New AdvancedHMIControls.BasicIndicator()
        Me.Advance2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator11 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator16 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator17 = New AdvancedHMIControls.BasicIndicator()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DriveToTargetBasicButton = New AdvancedHMIControls.BasicButton()
        Me.DriveLabel = New System.Windows.Forms.Label()
        Me.Extended1Label = New System.Windows.Forms.Label()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.ManualMode1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.ManualMode2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.StopBasicButton = New AdvancedHMIControls.BasicButton()
        Me.RunBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ManualMode3BasicButton = New AdvancedHMIControls.BasicButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.ManualMode1PictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AlarmLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator12 = New AdvancedHMIControls.BasicIndicator()
        Me.InPositionLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator13 = New AdvancedHMIControls.BasicIndicator()
        Me.SetOnLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator14 = New AdvancedHMIControls.BasicIndicator()
        Me.BusyLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator15 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorAtReferenceLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator18 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorFaultedLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator19 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorActiveLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator20 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorReadyLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator21 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorResetButton = New AdvancedHMIControls.BasicButton()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManualMode1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManualMode1Label
        '
        Me.ManualMode1Label.BackColor = System.Drawing.Color.White
        Me.ManualMode1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode1Label.ForeColor = System.Drawing.Color.DimGray
        Me.ManualMode1Label.Location = New System.Drawing.Point(196, 47)
        Me.ManualMode1Label.Name = "ManualMode1Label"
        Me.ManualMode1Label.Size = New System.Drawing.Size(219, 40)
        Me.ManualMode1Label.TabIndex = 271
        Me.ManualMode1Label.Text = "Manual mode 1"
        Me.ManualMode1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'HomeBasicButton
        '
        Me.HomeBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.HomeBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.HomeBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBasicButton.ForeColor = System.Drawing.Color.Black
        Me.HomeBasicButton.Highlight = False
        Me.HomeBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.HomeBasicButton.Location = New System.Drawing.Point(282, 559)
        Me.HomeBasicButton.MaximumHoldTime = 3000
        Me.HomeBasicButton.MinimumHoldTime = 500
        Me.HomeBasicButton.Name = "HomeBasicButton"
        Me.HomeBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.HomeBasicButton.PLCAddressClick = "HMI.Manual[0].8"
        Me.HomeBasicButton.SelectTextAlternate = False
        Me.HomeBasicButton.Size = New System.Drawing.Size(119, 32)
        Me.HomeBasicButton.TabIndex = 350
        Me.HomeBasicButton.Text = "Home"
        Me.HomeBasicButton.TextAlternate = Nothing
        Me.HomeBasicButton.UseVisualStyleBackColor = True
        Me.HomeBasicButton.ValueToWrite = 1
        '
        'TargetPositionLabel
        '
        Me.TargetPositionLabel.AutoSize = True
        Me.TargetPositionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPositionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TargetPositionLabel.Location = New System.Drawing.Point(36, 524)
        Me.TargetPositionLabel.Name = "TargetPositionLabel"
        Me.TargetPositionLabel.Size = New System.Drawing.Size(101, 19)
        Me.TargetPositionLabel.TabIndex = 349
        Me.TargetPositionLabel.Text = "Target Position"
        Me.TargetPositionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TargetPositionValueBasicLabel
        '
        Me.TargetPositionValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.TargetPositionValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.TargetPositionValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TargetPositionValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.TargetPositionValueBasicLabel.DisplayAsTime = False
        Me.TargetPositionValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPositionValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TargetPositionValueBasicLabel.Highlight = False
        Me.TargetPositionValueBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.TargetPositionValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.TargetPositionValueBasicLabel.HighlightKeyCharacter = "!"
        Me.TargetPositionValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TargetPositionValueBasicLabel.KeypadAlphaNumeric = False
        Me.TargetPositionValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPositionValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.TargetPositionValueBasicLabel.KeypadMaxValue = 0.0R
        Me.TargetPositionValueBasicLabel.KeypadMinValue = 0.0R
        Me.TargetPositionValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.TargetPositionValueBasicLabel.KeypadShowCurrentValue = False
        Me.TargetPositionValueBasicLabel.KeypadText = Nothing
        Me.TargetPositionValueBasicLabel.KeypadWidth = 400
        Me.TargetPositionValueBasicLabel.Location = New System.Drawing.Point(187, 525)
        Me.TargetPositionValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.TargetPositionValueBasicLabel.Name = "TargetPositionValueBasicLabel"
        Me.TargetPositionValueBasicLabel.NumericFormat = "000.0"
        Me.TargetPositionValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TargetPositionValueBasicLabel.PLCAddressKeypad = "oPickUnit.TargetPosition"
        Me.TargetPositionValueBasicLabel.PLCAddressValue = "oPickUnit.TargetPosition"
        Me.TargetPositionValueBasicLabel.PollRate = 0
        Me.TargetPositionValueBasicLabel.Size = New System.Drawing.Size(146, 27)
        Me.TargetPositionValueBasicLabel.TabIndex = 348
        Me.TargetPositionValueBasicLabel.Text = "100.0"
        Me.TargetPositionValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TargetPositionValueBasicLabel.UseMnemonic = False
        Me.TargetPositionValueBasicLabel.Value = "100.0"
        Me.TargetPositionValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TargetPositionValueBasicLabel.ValueLeftPadLength = 0
        Me.TargetPositionValueBasicLabel.ValuePrefix = Nothing
        Me.TargetPositionValueBasicLabel.ValueScaleFactor = 1.0R
        Me.TargetPositionValueBasicLabel.ValueSuffix = Nothing
        '
        'PickUnitCurrentPositionLabel
        '
        Me.PickUnitCurrentPositionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.PickUnitCurrentPositionLabel.AutoSize = True
        Me.PickUnitCurrentPositionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitCurrentPositionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUnitCurrentPositionLabel.Location = New System.Drawing.Point(36, 488)
        Me.PickUnitCurrentPositionLabel.Name = "PickUnitCurrentPositionLabel"
        Me.PickUnitCurrentPositionLabel.Size = New System.Drawing.Size(109, 19)
        Me.PickUnitCurrentPositionLabel.TabIndex = 347
        Me.PickUnitCurrentPositionLabel.Text = "Current Position"
        Me.PickUnitCurrentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PickUnitCurrentPosition
        '
        Me.PickUnitCurrentPosition.BackColor = System.Drawing.Color.Gray
        Me.PickUnitCurrentPosition.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PickUnitCurrentPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PickUnitCurrentPosition.ComComponent = Me.EthernetIPforCLXCom1
        Me.PickUnitCurrentPosition.DisplayAsTime = False
        Me.PickUnitCurrentPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitCurrentPosition.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUnitCurrentPosition.Highlight = False
        Me.PickUnitCurrentPosition.HighlightColor = System.Drawing.Color.Red
        Me.PickUnitCurrentPosition.HighlightForeColor = System.Drawing.Color.White
        Me.PickUnitCurrentPosition.HighlightKeyCharacter = "!"
        Me.PickUnitCurrentPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PickUnitCurrentPosition.KeypadAlphaNumeric = False
        Me.PickUnitCurrentPosition.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitCurrentPosition.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PickUnitCurrentPosition.KeypadMaxValue = 90.0R
        Me.PickUnitCurrentPosition.KeypadMinValue = 1.0R
        Me.PickUnitCurrentPosition.KeypadScaleFactor = 1.0R
        Me.PickUnitCurrentPosition.KeypadShowCurrentValue = False
        Me.PickUnitCurrentPosition.KeypadText = Nothing
        Me.PickUnitCurrentPosition.KeypadWidth = 400
        Me.PickUnitCurrentPosition.Location = New System.Drawing.Point(187, 488)
        Me.PickUnitCurrentPosition.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PickUnitCurrentPosition.Name = "PickUnitCurrentPosition"
        Me.PickUnitCurrentPosition.NumericFormat = "000.0"
        Me.PickUnitCurrentPosition.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PickUnitCurrentPosition.PLCAddressKeypad = ""
        Me.PickUnitCurrentPosition.PLCAddressValue = "iPickUnit.Current_Position"
        Me.PickUnitCurrentPosition.PollRate = 0
        Me.PickUnitCurrentPosition.Size = New System.Drawing.Size(146, 27)
        Me.PickUnitCurrentPosition.TabIndex = 346
        Me.PickUnitCurrentPosition.Text = "100.0"
        Me.PickUnitCurrentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PickUnitCurrentPosition.UseMnemonic = False
        Me.PickUnitCurrentPosition.Value = "100.0"
        Me.PickUnitCurrentPosition.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PickUnitCurrentPosition.ValueLeftPadLength = 0
        Me.PickUnitCurrentPosition.ValuePrefix = Nothing
        Me.PickUnitCurrentPosition.ValueScaleFactor = 1.0R
        Me.PickUnitCurrentPosition.ValueSuffix = Nothing
        '
        'PickUnitLabel
        '
        Me.PickUnitLabel.AutoSize = True
        Me.PickUnitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUnitLabel.Location = New System.Drawing.Point(12, 436)
        Me.PickUnitLabel.Name = "PickUnitLabel"
        Me.PickUnitLabel.Size = New System.Drawing.Size(71, 21)
        Me.PickUnitLabel.TabIndex = 344
        Me.PickUnitLabel.Text = "Pick unit"
        Me.PickUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CloseBasicButton
        '
        Me.CloseBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CloseBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBasicButton.ForeColor = System.Drawing.Color.Black
        Me.CloseBasicButton.Highlight = False
        Me.CloseBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.CloseBasicButton.Location = New System.Drawing.Point(149, 665)
        Me.CloseBasicButton.MaximumHoldTime = 3000
        Me.CloseBasicButton.MinimumHoldTime = 500
        Me.CloseBasicButton.Name = "CloseBasicButton"
        Me.CloseBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CloseBasicButton.PLCAddressClick = "HMI.Manual[0].10"
        Me.CloseBasicButton.SelectTextAlternate = False
        Me.CloseBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.CloseBasicButton.TabIndex = 354
        Me.CloseBasicButton.Text = "Close"
        Me.CloseBasicButton.TextAlternate = Nothing
        Me.CloseBasicButton.UseVisualStyleBackColor = True
        Me.CloseBasicButton.ValueToWrite = 1
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Location = New System.Drawing.Point(147, 663)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "outPickSt_Clamp"
        Me.BasicIndicator1.SelectColor2 = True
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator1.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator1.TabIndex = 355
        '
        'OpenBasicButton
        '
        Me.OpenBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.OpenBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.OpenBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenBasicButton.ForeColor = System.Drawing.Color.Black
        Me.OpenBasicButton.Highlight = False
        Me.OpenBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.OpenBasicButton.Location = New System.Drawing.Point(42, 666)
        Me.OpenBasicButton.MaximumHoldTime = 3000
        Me.OpenBasicButton.MinimumHoldTime = 500
        Me.OpenBasicButton.Name = "OpenBasicButton"
        Me.OpenBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.OpenBasicButton.PLCAddressClick = "HMI.Manual[0].9"
        Me.OpenBasicButton.SelectTextAlternate = False
        Me.OpenBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.OpenBasicButton.TabIndex = 352
        Me.OpenBasicButton.Text = "Open"
        Me.OpenBasicButton.TextAlternate = Nothing
        Me.OpenBasicButton.UseVisualStyleBackColor = True
        Me.OpenBasicButton.ValueToWrite = 1
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator5.Location = New System.Drawing.Point(40, 663)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "NOT outPickSt_Clamp"
        Me.BasicIndicator5.SelectColor2 = True
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator5.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator5.TabIndex = 353
        '
        'ContainerClampLabel
        '
        Me.ContainerClampLabel.AutoSize = True
        Me.ContainerClampLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerClampLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ContainerClampLabel.Location = New System.Drawing.Point(36, 623)
        Me.ContainerClampLabel.Name = "ContainerClampLabel"
        Me.ContainerClampLabel.Size = New System.Drawing.Size(109, 19)
        Me.ContainerClampLabel.TabIndex = 351
        Me.ContainerClampLabel.Text = "Container clamp"
        Me.ContainerClampLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(457, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 21)
        Me.Label1.TabIndex = 359
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(389, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 21)
        Me.Label2.TabIndex = 360
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Advance1BasicButton
        '
        Me.Advance1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Advance1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Advance1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Advance1BasicButton.Highlight = False
        Me.Advance1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Advance1BasicButton.Location = New System.Drawing.Point(284, 343)
        Me.Advance1BasicButton.MaximumHoldTime = 3000
        Me.Advance1BasicButton.MinimumHoldTime = 500
        Me.Advance1BasicButton.Name = "Advance1BasicButton"
        Me.Advance1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Advance1BasicButton.PLCAddressClick = "HMI.Manual[0].4"
        Me.Advance1BasicButton.SelectTextAlternate = False
        Me.Advance1BasicButton.Size = New System.Drawing.Size(99, 32)
        Me.Advance1BasicButton.TabIndex = 361
        Me.Advance1BasicButton.Text = "Advance"
        Me.Advance1BasicButton.TextAlternate = ""
        Me.Advance1BasicButton.UseVisualStyleBackColor = True
        Me.Advance1BasicButton.ValueToWrite = 1
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Location = New System.Drawing.Point(403, 674)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "inPickSt_ClampOpen"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator2.TabIndex = 363
        '
        'ClampOpenLabel
        '
        Me.ClampOpenLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClampOpenLabel.Location = New System.Drawing.Point(272, 674)
        Me.ClampOpenLabel.Name = "ClampOpenLabel"
        Me.ClampOpenLabel.Size = New System.Drawing.Size(123, 15)
        Me.ClampOpenLabel.TabIndex = 364
        Me.ClampOpenLabel.Text = "Clamp open"
        Me.ClampOpenLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator3.Location = New System.Drawing.Point(372, 270)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor2 = "inConv_Gate2ext"
        Me.BasicIndicator3.SelectColor2 = False
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator3.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator3.TabIndex = 365
        '
        'Retracted1Label
        '
        Me.Retracted1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retracted1Label.Location = New System.Drawing.Point(287, 294)
        Me.Retracted1Label.Name = "Retracted1Label"
        Me.Retracted1Label.Size = New System.Drawing.Size(84, 15)
        Me.Retracted1Label.TabIndex = 368
        Me.Retracted1Label.Text = "Retracted"
        Me.Retracted1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(372, 293)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "inConv_Gate2ret"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator4.TabIndex = 367
        '
        'Retracted2Label
        '
        Me.Retracted2Label.BackColor = System.Drawing.Color.Transparent
        Me.Retracted2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retracted2Label.Location = New System.Drawing.Point(502, 293)
        Me.Retracted2Label.Name = "Retracted2Label"
        Me.Retracted2Label.Size = New System.Drawing.Size(98, 15)
        Me.Retracted2Label.TabIndex = 372
        Me.Retracted2Label.Text = "Retracted"
        '
        'BasicIndicator6
        '
        Me.BasicIndicator6.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator6.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator6.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator6.Location = New System.Drawing.Point(483, 292)
        Me.BasicIndicator6.Name = "BasicIndicator6"
        Me.BasicIndicator6.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator6.OutlineWidth = 1
        Me.BasicIndicator6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator6.PLCAddressSelectColor2 = "inConv_Gate1ret"
        Me.BasicIndicator6.SelectColor2 = False
        Me.BasicIndicator6.SelectColor3 = False
        Me.BasicIndicator6.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator6.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator6.TabIndex = 371
        '
        'Extended2Label
        '
        Me.Extended2Label.BackColor = System.Drawing.Color.Transparent
        Me.Extended2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Extended2Label.Location = New System.Drawing.Point(502, 273)
        Me.Extended2Label.Name = "Extended2Label"
        Me.Extended2Label.Size = New System.Drawing.Size(92, 15)
        Me.Extended2Label.TabIndex = 370
        Me.Extended2Label.Text = "Extended"
        '
        'BasicIndicator7
        '
        Me.BasicIndicator7.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator7.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator7.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator7.Location = New System.Drawing.Point(482, 271)
        Me.BasicIndicator7.Name = "BasicIndicator7"
        Me.BasicIndicator7.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator7.OutlineWidth = 1
        Me.BasicIndicator7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator7.PLCAddressSelectColor2 = "inConv_Gate1ext"
        Me.BasicIndicator7.SelectColor2 = False
        Me.BasicIndicator7.SelectColor3 = False
        Me.BasicIndicator7.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator7.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator7.TabIndex = 369
        '
        'BasicIndicator8
        '
        Me.BasicIndicator8.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator8.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator8.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator8.Location = New System.Drawing.Point(283, 341)
        Me.BasicIndicator8.Name = "BasicIndicator8"
        Me.BasicIndicator8.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator8.OutlineWidth = 1
        Me.BasicIndicator8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator8.PLCAddressSelectColor2 = "Not outConv_Gate2"
        Me.BasicIndicator8.SelectColor2 = True
        Me.BasicIndicator8.SelectColor3 = False
        Me.BasicIndicator8.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator8.Size = New System.Drawing.Size(102, 36)
        Me.BasicIndicator8.TabIndex = 373
        '
        'Retract1BasicButton
        '
        Me.Retract1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Retract1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Retract1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retract1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Retract1BasicButton.Highlight = False
        Me.Retract1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Retract1BasicButton.Location = New System.Drawing.Point(284, 381)
        Me.Retract1BasicButton.MaximumHoldTime = 3000
        Me.Retract1BasicButton.MinimumHoldTime = 500
        Me.Retract1BasicButton.Name = "Retract1BasicButton"
        Me.Retract1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Retract1BasicButton.PLCAddressClick = "HMI.Manual[0].5"
        Me.Retract1BasicButton.SelectTextAlternate = False
        Me.Retract1BasicButton.Size = New System.Drawing.Size(99, 32)
        Me.Retract1BasicButton.TabIndex = 374
        Me.Retract1BasicButton.Text = "Retract"
        Me.Retract1BasicButton.TextAlternate = "Retract"
        Me.Retract1BasicButton.UseVisualStyleBackColor = True
        Me.Retract1BasicButton.ValueToWrite = 1
        '
        'BasicIndicator9
        '
        Me.BasicIndicator9.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator9.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator9.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator9.Location = New System.Drawing.Point(282, 379)
        Me.BasicIndicator9.Name = "BasicIndicator9"
        Me.BasicIndicator9.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator9.OutlineWidth = 1
        Me.BasicIndicator9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator9.PLCAddressSelectColor2 = "outConv_Gate2"
        Me.BasicIndicator9.SelectColor2 = True
        Me.BasicIndicator9.SelectColor3 = False
        Me.BasicIndicator9.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator9.Size = New System.Drawing.Size(103, 36)
        Me.BasicIndicator9.TabIndex = 375
        '
        'Retract2BasicButton
        '
        Me.Retract2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Retract2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Retract2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retract2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Retract2BasicButton.Highlight = False
        Me.Retract2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Retract2BasicButton.Location = New System.Drawing.Point(494, 381)
        Me.Retract2BasicButton.MaximumHoldTime = 3000
        Me.Retract2BasicButton.MinimumHoldTime = 500
        Me.Retract2BasicButton.Name = "Retract2BasicButton"
        Me.Retract2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Retract2BasicButton.PLCAddressClick = "HMI.Manual[0].3"
        Me.Retract2BasicButton.SelectTextAlternate = False
        Me.Retract2BasicButton.Size = New System.Drawing.Size(95, 32)
        Me.Retract2BasicButton.TabIndex = 378
        Me.Retract2BasicButton.Text = "Retract"
        Me.Retract2BasicButton.TextAlternate = "Retract"
        Me.Retract2BasicButton.UseVisualStyleBackColor = True
        Me.Retract2BasicButton.ValueToWrite = 1
        '
        'BasicIndicator10
        '
        Me.BasicIndicator10.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator10.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator10.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator10.Location = New System.Drawing.Point(492, 379)
        Me.BasicIndicator10.Name = "BasicIndicator10"
        Me.BasicIndicator10.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator10.OutlineWidth = 1
        Me.BasicIndicator10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator10.PLCAddressSelectColor2 = "outConv_Gate1"
        Me.BasicIndicator10.SelectColor2 = True
        Me.BasicIndicator10.SelectColor3 = False
        Me.BasicIndicator10.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator10.Size = New System.Drawing.Size(98, 36)
        Me.BasicIndicator10.TabIndex = 379
        '
        'Advance2BasicButton
        '
        Me.Advance2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Advance2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Advance2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Advance2BasicButton.Highlight = False
        Me.Advance2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Advance2BasicButton.Location = New System.Drawing.Point(495, 344)
        Me.Advance2BasicButton.MaximumHoldTime = 3000
        Me.Advance2BasicButton.MinimumHoldTime = 500
        Me.Advance2BasicButton.Name = "Advance2BasicButton"
        Me.Advance2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Advance2BasicButton.PLCAddressClick = "HMI.Manual[0].2"
        Me.Advance2BasicButton.SelectTextAlternate = False
        Me.Advance2BasicButton.Size = New System.Drawing.Size(95, 32)
        Me.Advance2BasicButton.TabIndex = 376
        Me.Advance2BasicButton.Text = "Advance"
        Me.Advance2BasicButton.TextAlternate = ""
        Me.Advance2BasicButton.UseVisualStyleBackColor = True
        Me.Advance2BasicButton.ValueToWrite = 1
        '
        'BasicIndicator11
        '
        Me.BasicIndicator11.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator11.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator11.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator11.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator11.Location = New System.Drawing.Point(493, 341)
        Me.BasicIndicator11.Name = "BasicIndicator11"
        Me.BasicIndicator11.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator11.OutlineWidth = 1
        Me.BasicIndicator11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator11.PLCAddressSelectColor2 = "Not outConv_Gate1"
        Me.BasicIndicator11.SelectColor2 = True
        Me.BasicIndicator11.SelectColor3 = False
        Me.BasicIndicator11.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator11.Size = New System.Drawing.Size(98, 36)
        Me.BasicIndicator11.TabIndex = 377
        '
        'ConveyorLabel
        '
        Me.ConveyorLabel.AutoSize = True
        Me.ConveyorLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorLabel.Location = New System.Drawing.Point(9, 110)
        Me.ConveyorLabel.Name = "ConveyorLabel"
        Me.ConveyorLabel.Size = New System.Drawing.Size(80, 21)
        Me.ConveyorLabel.TabIndex = 391
        Me.ConveyorLabel.Text = "Conveyor"
        Me.ConveyorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BasicIndicator16
        '
        Me.BasicIndicator16.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator16.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator16.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator16.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator16.Location = New System.Drawing.Point(370, 108)
        Me.BasicIndicator16.Name = "BasicIndicator16"
        Me.BasicIndicator16.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator16.OutlineWidth = 1
        Me.BasicIndicator16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator16.PLCAddressSelectColor2 = "NOT ConveyorDrive:I.Active"
        Me.BasicIndicator16.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator16.SelectColor2 = True
        Me.BasicIndicator16.SelectColor3 = False
        Me.BasicIndicator16.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator16.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator16.TabIndex = 395
        '
        'BasicIndicator17
        '
        Me.BasicIndicator17.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator17.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator17.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator17.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator17.Location = New System.Drawing.Point(272, 108)
        Me.BasicIndicator17.Name = "BasicIndicator17"
        Me.BasicIndicator17.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator17.OutlineWidth = 1
        Me.BasicIndicator17.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator17.PLCAddressSelectColor2 = "ConveyorDrive:I.Active"
        Me.BasicIndicator17.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator17.SelectColor2 = True
        Me.BasicIndicator17.SelectColor3 = False
        Me.BasicIndicator17.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator17.Size = New System.Drawing.Size(96, 36)
        Me.BasicIndicator17.TabIndex = 393
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(297, 623)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 414
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(11, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 10)
        Me.GroupBox1.TabIndex = 416
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 726)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 10)
        Me.GroupBox2.TabIndex = 417
        Me.GroupBox2.TabStop = False
        '
        'DriveToTargetBasicButton
        '
        Me.DriveToTargetBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.DriveToTargetBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.DriveToTargetBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriveToTargetBasicButton.ForeColor = System.Drawing.Color.Black
        Me.DriveToTargetBasicButton.Highlight = False
        Me.DriveToTargetBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.DriveToTargetBasicButton.Location = New System.Drawing.Point(149, 559)
        Me.DriveToTargetBasicButton.MaximumHoldTime = 3000
        Me.DriveToTargetBasicButton.MinimumHoldTime = 500
        Me.DriveToTargetBasicButton.Name = "DriveToTargetBasicButton"
        Me.DriveToTargetBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.DriveToTargetBasicButton.PLCAddressClick = "HMI.Manual[0].6"
        Me.DriveToTargetBasicButton.SelectTextAlternate = False
        Me.DriveToTargetBasicButton.Size = New System.Drawing.Size(125, 32)
        Me.DriveToTargetBasicButton.TabIndex = 420
        Me.DriveToTargetBasicButton.Text = "Drive to Target"
        Me.DriveToTargetBasicButton.TextAlternate = Nothing
        Me.DriveToTargetBasicButton.UseVisualStyleBackColor = True
        Me.DriveToTargetBasicButton.ValueToWrite = 1
        '
        'DriveLabel
        '
        Me.DriveLabel.AutoSize = True
        Me.DriveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DriveLabel.Location = New System.Drawing.Point(38, 565)
        Me.DriveLabel.Name = "DriveLabel"
        Me.DriveLabel.Size = New System.Drawing.Size(41, 19)
        Me.DriveLabel.TabIndex = 421
        Me.DriveLabel.Text = "Drive"
        Me.DriveLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Extended1Label
        '
        Me.Extended1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Extended1Label.Location = New System.Drawing.Point(280, 270)
        Me.Extended1Label.Name = "Extended1Label"
        Me.Extended1Label.Size = New System.Drawing.Size(91, 15)
        Me.Extended1Label.TabIndex = 423
        Me.Extended1Label.Text = "Extended"
        Me.Extended1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.CurrentDateTime.TabIndex = 424
        Me.CurrentDateTime.Text = "30-11-2016 14:52:37"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 427
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(173, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox3.TabIndex = 426
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
        Me.AlmInd.TabIndex = 422
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'ManualMode1BasicButton
        '
        Me.ManualMode1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ManualMode1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ManualMode1BasicButton.Enabled = False
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
        Me.ManualMode1BasicButton.TabIndex = 397
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
        Me.ManualMode2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualMode2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.ManualMode2BasicButton.Highlight = False
        Me.ManualMode2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ManualMode2BasicButton.Image = CType(resources.GetObject("ManualMode2BasicButton.Image"), System.Drawing.Image)
        Me.ManualMode2BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualMode2BasicButton.Location = New System.Drawing.Point(328, 756)
        Me.ManualMode2BasicButton.MaximumHoldTime = 3000
        Me.ManualMode2BasicButton.MinimumHoldTime = 500
        Me.ManualMode2BasicButton.Name = "ManualMode2BasicButton"
        Me.ManualMode2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ManualMode2BasicButton.PLCAddressClick = ""
        Me.ManualMode2BasicButton.SelectTextAlternate = False
        Me.ManualMode2BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.ManualMode2BasicButton.TabIndex = 396
        Me.ManualMode2BasicButton.Text = "Manual Mode 2"
        Me.ManualMode2BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualMode2BasicButton.TextAlternate = Nothing
        Me.ManualMode2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ManualMode2BasicButton.UseVisualStyleBackColor = True
        Me.ManualMode2BasicButton.ValueToWrite = 0
        '
        'StopBasicButton
        '
        Me.StopBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.StopBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.StopBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopBasicButton.ForeColor = System.Drawing.Color.Black
        Me.StopBasicButton.Highlight = False
        Me.StopBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.StopBasicButton.Image = CType(resources.GetObject("StopBasicButton.Image"), System.Drawing.Image)
        Me.StopBasicButton.Location = New System.Drawing.Point(372, 110)
        Me.StopBasicButton.MaximumHoldTime = 3000
        Me.StopBasicButton.MinimumHoldTime = 500
        Me.StopBasicButton.Name = "StopBasicButton"
        Me.StopBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopBasicButton.PLCAddressClick = "HMI.Manual[0].1"
        Me.StopBasicButton.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.StopBasicButton.SelectTextAlternate = False
        Me.StopBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.StopBasicButton.TabIndex = 394
        Me.StopBasicButton.TextAlternate = ""
        Me.StopBasicButton.UseVisualStyleBackColor = True
        Me.StopBasicButton.ValueToWrite = 1
        '
        'RunBasicButton
        '
        Me.RunBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.RunBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunBasicButton.ForeColor = System.Drawing.Color.Black
        Me.RunBasicButton.Highlight = False
        Me.RunBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.RunBasicButton.Image = CType(resources.GetObject("RunBasicButton.Image"), System.Drawing.Image)
        Me.RunBasicButton.Location = New System.Drawing.Point(274, 110)
        Me.RunBasicButton.MaximumHoldTime = 3000
        Me.RunBasicButton.MinimumHoldTime = 500
        Me.RunBasicButton.Name = "RunBasicButton"
        Me.RunBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunBasicButton.PLCAddressClick = "HMI.Manual[0].0"
        Me.RunBasicButton.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.RunBasicButton.SelectTextAlternate = False
        Me.RunBasicButton.Size = New System.Drawing.Size(92, 32)
        Me.RunBasicButton.TabIndex = 392
        Me.RunBasicButton.TextAlternate = ""
        Me.RunBasicButton.UseVisualStyleBackColor = True
        Me.RunBasicButton.ValueToWrite = 1
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
        Me.ManualMode3BasicButton.Location = New System.Drawing.Point(464, 756)
        Me.ManualMode3BasicButton.MaximumHoldTime = 3000
        Me.ManualMode3BasicButton.MinimumHoldTime = 500
        Me.ManualMode3BasicButton.Name = "ManualMode3BasicButton"
        Me.ManualMode3BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ManualMode3BasicButton.PLCAddressClick = ""
        Me.ManualMode3BasicButton.SelectTextAlternate = False
        Me.ManualMode3BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.ManualMode3BasicButton.TabIndex = 390
        Me.ManualMode3BasicButton.Text = "Manual Mode 3"
        Me.ManualMode3BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManualMode3BasicButton.TextAlternate = Nothing
        Me.ManualMode3BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ManualMode3BasicButton.UseVisualStyleBackColor = True
        Me.ManualMode3BasicButton.ValueToWrite = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Conveyor_View
        Me.PictureBox5.Location = New System.Drawing.Point(40, 102)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(504, 235)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 356
        Me.PictureBox5.TabStop = False
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
        'ManualMode1PictureBox
        '
        Me.ManualMode1PictureBox.BackColor = System.Drawing.Color.White
        Me.ManualMode1PictureBox.Image = CType(resources.GetObject("ManualMode1PictureBox.Image"), System.Drawing.Image)
        Me.ManualMode1PictureBox.Location = New System.Drawing.Point(141, 47)
        Me.ManualMode1PictureBox.Name = "ManualMode1PictureBox"
        Me.ManualMode1PictureBox.Size = New System.Drawing.Size(46, 40)
        Me.ManualMode1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ManualMode1PictureBox.TabIndex = 272
        Me.ManualMode1PictureBox.TabStop = False
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
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Pick_Unit_View
        Me.PictureBox4.Location = New System.Drawing.Point(421, 452)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(111, 268)
        Me.PictureBox4.TabIndex = 342
        Me.PictureBox4.TabStop = False
        '
        'AlarmLabel
        '
        Me.AlarmLabel.AutoSize = True
        Me.AlarmLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmLabel.Location = New System.Drawing.Point(536, 620)
        Me.AlarmLabel.Name = "AlarmLabel"
        Me.AlarmLabel.Size = New System.Drawing.Size(39, 15)
        Me.AlarmLabel.TabIndex = 435
        Me.AlarmLabel.Text = "Alarm"
        '
        'BasicIndicator12
        '
        Me.BasicIndicator12.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator12.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator12.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator12.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator12.Location = New System.Drawing.Point(514, 618)
        Me.BasicIndicator12.Name = "BasicIndicator12"
        Me.BasicIndicator12.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator12.OutlineWidth = 1
        Me.BasicIndicator12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator12.PLCAddressSelectColor2 = "iPickUnit.ALARM"
        Me.BasicIndicator12.SelectColor2 = False
        Me.BasicIndicator12.SelectColor3 = False
        Me.BasicIndicator12.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator12.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator12.TabIndex = 434
        '
        'InPositionLabel
        '
        Me.InPositionLabel.AutoSize = True
        Me.InPositionLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPositionLabel.Location = New System.Drawing.Point(536, 596)
        Me.InPositionLabel.Name = "InPositionLabel"
        Me.InPositionLabel.Size = New System.Drawing.Size(63, 15)
        Me.InPositionLabel.TabIndex = 433
        Me.InPositionLabel.Text = "In position"
        '
        'BasicIndicator13
        '
        Me.BasicIndicator13.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator13.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator13.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator13.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator13.Location = New System.Drawing.Point(514, 594)
        Me.BasicIndicator13.Name = "BasicIndicator13"
        Me.BasicIndicator13.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator13.OutlineWidth = 1
        Me.BasicIndicator13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator13.PLCAddressSelectColor2 = "iPickUnit.INP"
        Me.BasicIndicator13.SelectColor2 = False
        Me.BasicIndicator13.SelectColor3 = False
        Me.BasicIndicator13.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator13.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator13.TabIndex = 432
        '
        'SetOnLabel
        '
        Me.SetOnLabel.AutoSize = True
        Me.SetOnLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetOnLabel.Location = New System.Drawing.Point(536, 573)
        Me.SetOnLabel.Name = "SetOnLabel"
        Me.SetOnLabel.Size = New System.Drawing.Size(39, 15)
        Me.SetOnLabel.TabIndex = 431
        Me.SetOnLabel.Text = "SetOn"
        '
        'BasicIndicator14
        '
        Me.BasicIndicator14.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator14.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator14.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator14.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator14.Location = New System.Drawing.Point(514, 571)
        Me.BasicIndicator14.Name = "BasicIndicator14"
        Me.BasicIndicator14.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator14.OutlineWidth = 1
        Me.BasicIndicator14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator14.PLCAddressSelectColor2 = "iPickUnit.SETON"
        Me.BasicIndicator14.SelectColor2 = False
        Me.BasicIndicator14.SelectColor3 = False
        Me.BasicIndicator14.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator14.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator14.TabIndex = 430
        '
        'BusyLabel
        '
        Me.BusyLabel.AutoSize = True
        Me.BusyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusyLabel.Location = New System.Drawing.Point(536, 549)
        Me.BusyLabel.Name = "BusyLabel"
        Me.BusyLabel.Size = New System.Drawing.Size(32, 15)
        Me.BusyLabel.TabIndex = 429
        Me.BusyLabel.Text = "Busy"
        '
        'BasicIndicator15
        '
        Me.BasicIndicator15.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator15.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator15.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator15.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator15.Location = New System.Drawing.Point(514, 547)
        Me.BasicIndicator15.Name = "BasicIndicator15"
        Me.BasicIndicator15.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator15.OutlineWidth = 1
        Me.BasicIndicator15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator15.PLCAddressSelectColor2 = "iPickUnit.BUSY"
        Me.BasicIndicator15.SelectColor2 = False
        Me.BasicIndicator15.SelectColor3 = False
        Me.BasicIndicator15.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator15.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator15.TabIndex = 428
        '
        'ConveyorAtReferenceLabel
        '
        Me.ConveyorAtReferenceLabel.AutoSize = True
        Me.ConveyorAtReferenceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorAtReferenceLabel.Location = New System.Drawing.Point(180, 370)
        Me.ConveyorAtReferenceLabel.Name = "ConveyorAtReferenceLabel"
        Me.ConveyorAtReferenceLabel.Size = New System.Drawing.Size(71, 15)
        Me.ConveyorAtReferenceLabel.TabIndex = 448
        Me.ConveyorAtReferenceLabel.Text = "At reference"
        '
        'BasicIndicator18
        '
        Me.BasicIndicator18.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator18.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator18.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator18.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator18.Location = New System.Drawing.Point(158, 368)
        Me.BasicIndicator18.Name = "BasicIndicator18"
        Me.BasicIndicator18.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator18.OutlineWidth = 1
        Me.BasicIndicator18.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator18.PLCAddressSelectColor2 = "ConveyorDrive:I.AtReference"
        Me.BasicIndicator18.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator18.SelectColor2 = False
        Me.BasicIndicator18.SelectColor3 = False
        Me.BasicIndicator18.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator18.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator18.TabIndex = 447
        '
        'ConveyorFaultedLabel
        '
        Me.ConveyorFaultedLabel.AutoSize = True
        Me.ConveyorFaultedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorFaultedLabel.Location = New System.Drawing.Point(180, 395)
        Me.ConveyorFaultedLabel.Name = "ConveyorFaultedLabel"
        Me.ConveyorFaultedLabel.Size = New System.Drawing.Size(46, 15)
        Me.ConveyorFaultedLabel.TabIndex = 446
        Me.ConveyorFaultedLabel.Text = "Faulted"
        '
        'BasicIndicator19
        '
        Me.BasicIndicator19.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator19.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator19.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator19.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator19.Location = New System.Drawing.Point(158, 393)
        Me.BasicIndicator19.Name = "BasicIndicator19"
        Me.BasicIndicator19.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator19.OutlineWidth = 1
        Me.BasicIndicator19.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator19.PLCAddressSelectColor2 = "ConveyorDrive:I.Faulted"
        Me.BasicIndicator19.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator19.SelectColor2 = False
        Me.BasicIndicator19.SelectColor3 = False
        Me.BasicIndicator19.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator19.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator19.TabIndex = 445
        '
        'ConveyorActiveLabel
        '
        Me.ConveyorActiveLabel.AutoSize = True
        Me.ConveyorActiveLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorActiveLabel.Location = New System.Drawing.Point(180, 346)
        Me.ConveyorActiveLabel.Name = "ConveyorActiveLabel"
        Me.ConveyorActiveLabel.Size = New System.Drawing.Size(40, 15)
        Me.ConveyorActiveLabel.TabIndex = 444
        Me.ConveyorActiveLabel.Text = "Active"
        '
        'BasicIndicator20
        '
        Me.BasicIndicator20.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator20.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator20.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator20.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator20.Location = New System.Drawing.Point(158, 344)
        Me.BasicIndicator20.Name = "BasicIndicator20"
        Me.BasicIndicator20.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator20.OutlineWidth = 1
        Me.BasicIndicator20.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator20.PLCAddressSelectColor2 = "ConveyorDrive:I.Active"
        Me.BasicIndicator20.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator20.SelectColor2 = False
        Me.BasicIndicator20.SelectColor3 = False
        Me.BasicIndicator20.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator20.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator20.TabIndex = 443
        '
        'ConveyorReadyLabel
        '
        Me.ConveyorReadyLabel.AutoSize = True
        Me.ConveyorReadyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorReadyLabel.Location = New System.Drawing.Point(180, 322)
        Me.ConveyorReadyLabel.Name = "ConveyorReadyLabel"
        Me.ConveyorReadyLabel.Size = New System.Drawing.Size(39, 15)
        Me.ConveyorReadyLabel.TabIndex = 442
        Me.ConveyorReadyLabel.Text = "Ready"
        '
        'BasicIndicator21
        '
        Me.BasicIndicator21.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator21.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator21.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator21.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator21.Location = New System.Drawing.Point(158, 320)
        Me.BasicIndicator21.Name = "BasicIndicator21"
        Me.BasicIndicator21.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator21.OutlineWidth = 1
        Me.BasicIndicator21.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator21.PLCAddressSelectColor2 = "ConveyorDrive:I.Ready"
        Me.BasicIndicator21.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator21.SelectColor2 = False
        Me.BasicIndicator21.SelectColor3 = False
        Me.BasicIndicator21.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator21.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator21.TabIndex = 441
        '
        'ConveyorResetButton
        '
        Me.ConveyorResetButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConveyorResetButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorResetButton.ForeColor = System.Drawing.Color.Black
        Me.ConveyorResetButton.Highlight = False
        Me.ConveyorResetButton.HighlightColor = System.Drawing.Color.Green
        Me.ConveyorResetButton.Location = New System.Drawing.Point(60, 386)
        Me.ConveyorResetButton.MaximumHoldTime = 3000
        Me.ConveyorResetButton.MinimumHoldTime = 500
        Me.ConveyorResetButton.Name = "ConveyorResetButton"
        Me.ConveyorResetButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ConveyorResetButton.PLCAddressClick = "HMI.Manual[1].7"
        Me.ConveyorResetButton.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.ConveyorResetButton.SelectTextAlternate = False
        Me.ConveyorResetButton.Size = New System.Drawing.Size(92, 32)
        Me.ConveyorResetButton.TabIndex = 449
        Me.ConveyorResetButton.Text = "Reset"
        Me.ConveyorResetButton.TextAlternate = ""
        Me.ConveyorResetButton.UseVisualStyleBackColor = True
        Me.ConveyorResetButton.ValueToWrite = 1
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
        Me.AccessLevelLabel.TabIndex = 450
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_manual
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 742)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.ConveyorResetButton)
        Me.Controls.Add(Me.ConveyorAtReferenceLabel)
        Me.Controls.Add(Me.BasicIndicator18)
        Me.Controls.Add(Me.ConveyorFaultedLabel)
        Me.Controls.Add(Me.BasicIndicator19)
        Me.Controls.Add(Me.ConveyorActiveLabel)
        Me.Controls.Add(Me.BasicIndicator20)
        Me.Controls.Add(Me.ConveyorReadyLabel)
        Me.Controls.Add(Me.BasicIndicator21)
        Me.Controls.Add(Me.AlarmLabel)
        Me.Controls.Add(Me.BasicIndicator12)
        Me.Controls.Add(Me.InPositionLabel)
        Me.Controls.Add(Me.BasicIndicator13)
        Me.Controls.Add(Me.SetOnLabel)
        Me.Controls.Add(Me.BasicIndicator14)
        Me.Controls.Add(Me.BusyLabel)
        Me.Controls.Add(Me.BasicIndicator15)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.Extended1Label)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.DriveLabel)
        Me.Controls.Add(Me.DriveToTargetBasicButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ManualMode1BasicButton)
        Me.Controls.Add(Me.ManualMode2BasicButton)
        Me.Controls.Add(Me.StopBasicButton)
        Me.Controls.Add(Me.BasicIndicator16)
        Me.Controls.Add(Me.RunBasicButton)
        Me.Controls.Add(Me.BasicIndicator17)
        Me.Controls.Add(Me.ConveyorLabel)
        Me.Controls.Add(Me.ManualMode3BasicButton)
        Me.Controls.Add(Me.Retract2BasicButton)
        Me.Controls.Add(Me.BasicIndicator10)
        Me.Controls.Add(Me.Advance2BasicButton)
        Me.Controls.Add(Me.BasicIndicator11)
        Me.Controls.Add(Me.Retract1BasicButton)
        Me.Controls.Add(Me.BasicIndicator9)
        Me.Controls.Add(Me.Retracted2Label)
        Me.Controls.Add(Me.BasicIndicator6)
        Me.Controls.Add(Me.Extended2Label)
        Me.Controls.Add(Me.BasicIndicator7)
        Me.Controls.Add(Me.Retracted1Label)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.ClampOpenLabel)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.Advance1BasicButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CloseBasicButton)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.OpenBasicButton)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.ContainerClampLabel)
        Me.Controls.Add(Me.HomeBasicButton)
        Me.Controls.Add(Me.TargetPositionLabel)
        Me.Controls.Add(Me.TargetPositionValueBasicLabel)
        Me.Controls.Add(Me.PickUnitCurrentPositionLabel)
        Me.Controls.Add(Me.PickUnitCurrentPosition)
        Me.Controls.Add(Me.PickUnitLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.ManualMode1PictureBox)
        Me.Controls.Add(Me.ManualMode1Label)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BasicIndicator8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Manual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManualMode1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ManualMode1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ManualMode1Label As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents Advance1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents OpenBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ContainerClampLabel As System.Windows.Forms.Label
    Friend WithEvents HomeBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents TargetPositionLabel As System.Windows.Forms.Label
    Friend WithEvents TargetPositionValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PickUnitCurrentPositionLabel As System.Windows.Forms.Label
    Friend WithEvents PickUnitCurrentPosition As AdvancedHMIControls.BasicLabel
    Friend WithEvents PickUnitLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Retracted2Label As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator6 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Extended2Label As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator7 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Retracted1Label As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ClampOpenLabel As System.Windows.Forms.Label
    Friend WithEvents Retract2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator10 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Advance2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator11 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents Retract1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator9 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator8 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ManualMode3BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents StopBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator16 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents RunBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator17 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorLabel As System.Windows.Forms.Label
    Friend WithEvents ManualMode1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ManualMode2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DriveLabel As System.Windows.Forms.Label
    Friend WithEvents DriveToTargetBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents Extended1Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents AlarmLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator12 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents InPositionLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator13 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents SetOnLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator14 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BusyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator15 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorAtReferenceLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator18 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorFaultedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator19 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorActiveLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator20 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorReadyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator21 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorResetButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
