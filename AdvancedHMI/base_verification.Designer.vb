<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_verification))
        Me.PressureVerificationLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.RunInd = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.StartVerificationRoutineLabel = New System.Windows.Forms.Label()
        Me.PressureSetPointBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.SetPointLabel = New System.Windows.Forms.Label()
        Me.SystemMeasurementLabel = New System.Windows.Forms.Label()
        Me.PressureSystemReadingBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.GaugeReadingLabel = New System.Windows.Forms.Label()
        Me.SaveVerificationBasicButton = New AdvancedHMIControls.BasicButton()
        Me.CancelVerificationBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PressureGaugeReadingBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.SetPointUnitLabel = New System.Windows.Forms.Label()
        Me.SystemMeasurementUnitLabel = New System.Windows.Forms.Label()
        Me.GaugeReadingUnitLabel = New System.Windows.Forms.Label()
        Me.VerificationStepLabel = New System.Windows.Forms.Label()
        Me.CurrentStepNumberLabel1 = New System.Windows.Forms.Label()
        Me.CurrentStepNumberLabel2 = New System.Windows.Forms.Label()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.CaptureBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PreviousStepBasicButton = New AdvancedHMIControls.BasicButton()
        Me.NextVerificationBasicButton = New AdvancedHMIControls.BasicButton()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.StopBasicButton = New AdvancedHMIControls.BasicButton()
        Me.StartBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.PressureVerificationPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.GaugeSerialNumberLabel = New System.Windows.Forms.Label()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PressureVerificationPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PressureVerificationLabel
        '
        Me.PressureVerificationLabel.BackColor = System.Drawing.Color.White
        Me.PressureVerificationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureVerificationLabel.ForeColor = System.Drawing.Color.DimGray
        Me.PressureVerificationLabel.Location = New System.Drawing.Point(196, 47)
        Me.PressureVerificationLabel.Name = "PressureVerificationLabel"
        Me.PressureVerificationLabel.Size = New System.Drawing.Size(219, 40)
        Me.PressureVerificationLabel.TabIndex = 271
        Me.PressureVerificationLabel.Text = "Pressure Verification"
        Me.PressureVerificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 300
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'RunInd
        '
        Me.RunInd.Color1 = System.Drawing.Color.Gray
        Me.RunInd.Color2 = System.Drawing.Color.LimeGreen
        Me.RunInd.Color3 = System.Drawing.Color.Red
        Me.RunInd.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunInd.ForeColor = System.Drawing.Color.Black
        Me.RunInd.Location = New System.Drawing.Point(219, 146)
        Me.RunInd.Name = "RunInd"
        Me.RunInd.OutlineColor = System.Drawing.Color.Transparent
        Me.RunInd.OutlineWidth = 1
        Me.RunInd.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunInd.PLCAddressVisible = "CalVerification.Running"
        Me.RunInd.SelectColor2 = True
        Me.RunInd.SelectColor3 = False
        Me.RunInd.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.RunInd.Size = New System.Drawing.Size(104, 57)
        Me.RunInd.TabIndex = 314
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.Black
        Me.BasicIndicator1.Location = New System.Drawing.Point(329, 146)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressVisible = "NOT CalVerification.Running"
        Me.BasicIndicator1.SelectColor2 = True
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator1.Size = New System.Drawing.Size(104, 57)
        Me.BasicIndicator1.TabIndex = 315
        '
        'StartVerificationRoutineLabel
        '
        Me.StartVerificationRoutineLabel.AutoSize = True
        Me.StartVerificationRoutineLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartVerificationRoutineLabel.Location = New System.Drawing.Point(38, 109)
        Me.StartVerificationRoutineLabel.Name = "StartVerificationRoutineLabel"
        Me.StartVerificationRoutineLabel.Size = New System.Drawing.Size(192, 21)
        Me.StartVerificationRoutineLabel.TabIndex = 353
        Me.StartVerificationRoutineLabel.Text = "Start verification routine:"
        '
        'PressureSetPointBasicLabel
        '
        Me.PressureSetPointBasicLabel.BackColor = System.Drawing.Color.Transparent
        Me.PressureSetPointBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureSetPointBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PressureSetPointBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureSetPointBasicLabel.DisplayAsTime = False
        Me.PressureSetPointBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointBasicLabel.ForeColor = System.Drawing.Color.Black
        Me.PressureSetPointBasicLabel.Highlight = False
        Me.PressureSetPointBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.PressureSetPointBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureSetPointBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureSetPointBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PressureSetPointBasicLabel.KeypadAlphaNumeric = False
        Me.PressureSetPointBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureSetPointBasicLabel.KeypadMinValue = 0.0R
        Me.PressureSetPointBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureSetPointBasicLabel.KeypadShowCurrentValue = False
        Me.PressureSetPointBasicLabel.KeypadText = Nothing
        Me.PressureSetPointBasicLabel.KeypadWidth = 400
        Me.PressureSetPointBasicLabel.Location = New System.Drawing.Point(312, 352)
        Me.PressureSetPointBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PressureSetPointBasicLabel.Name = "PressureSetPointBasicLabel"
        Me.PressureSetPointBasicLabel.NumericFormat = "000.00"
        Me.PressureSetPointBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PressureSetPointBasicLabel.PLCAddressKeypad = "CalVer.Edit_SP1"
        Me.PressureSetPointBasicLabel.PLCAddressValue = "CalVer.SP1"
        Me.PressureSetPointBasicLabel.PollRate = 0
        Me.PressureSetPointBasicLabel.Size = New System.Drawing.Size(61, 27)
        Me.PressureSetPointBasicLabel.TabIndex = 355
        Me.PressureSetPointBasicLabel.Text = "025.00"
        Me.PressureSetPointBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PressureSetPointBasicLabel.UseMnemonic = False
        Me.PressureSetPointBasicLabel.Value = "25"
        Me.PressureSetPointBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureSetPointBasicLabel.ValueLeftPadLength = 0
        Me.PressureSetPointBasicLabel.ValuePrefix = Nothing
        Me.PressureSetPointBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureSetPointBasicLabel.ValueSuffix = Nothing
        '
        'SetPointLabel
        '
        Me.SetPointLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetPointLabel.Location = New System.Drawing.Point(42, 354)
        Me.SetPointLabel.Name = "SetPointLabel"
        Me.SetPointLabel.Size = New System.Drawing.Size(247, 21)
        Me.SetPointLabel.TabIndex = 364
        Me.SetPointLabel.Text = "Set Point:"
        Me.SetPointLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SystemMeasurementLabel
        '
        Me.SystemMeasurementLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemMeasurementLabel.Location = New System.Drawing.Point(13, 392)
        Me.SystemMeasurementLabel.Name = "SystemMeasurementLabel"
        Me.SystemMeasurementLabel.Size = New System.Drawing.Size(276, 21)
        Me.SystemMeasurementLabel.TabIndex = 366
        Me.SystemMeasurementLabel.Text = "System Measurement:"
        Me.SystemMeasurementLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PressureSystemReadingBasicLabel
        '
        Me.PressureSystemReadingBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PressureSystemReadingBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureSystemReadingBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PressureSystemReadingBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureSystemReadingBasicLabel.DisplayAsTime = False
        Me.PressureSystemReadingBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSystemReadingBasicLabel.ForeColor = System.Drawing.Color.Green
        Me.PressureSystemReadingBasicLabel.Highlight = False
        Me.PressureSystemReadingBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.PressureSystemReadingBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureSystemReadingBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureSystemReadingBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PressureSystemReadingBasicLabel.KeypadAlphaNumeric = False
        Me.PressureSystemReadingBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSystemReadingBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSystemReadingBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureSystemReadingBasicLabel.KeypadMinValue = 0.0R
        Me.PressureSystemReadingBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureSystemReadingBasicLabel.KeypadShowCurrentValue = False
        Me.PressureSystemReadingBasicLabel.KeypadText = Nothing
        Me.PressureSystemReadingBasicLabel.KeypadWidth = 400
        Me.PressureSystemReadingBasicLabel.Location = New System.Drawing.Point(312, 390)
        Me.PressureSystemReadingBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PressureSystemReadingBasicLabel.Name = "PressureSystemReadingBasicLabel"
        Me.PressureSystemReadingBasicLabel.NumericFormat = "000.00"
        Me.PressureSystemReadingBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PressureSystemReadingBasicLabel.PLCAddressKeypad = ""
        Me.PressureSystemReadingBasicLabel.PLCAddressValue = "CalVer.Edit_System1"
        Me.PressureSystemReadingBasicLabel.PollRate = 0
        Me.PressureSystemReadingBasicLabel.Size = New System.Drawing.Size(61, 27)
        Me.PressureSystemReadingBasicLabel.TabIndex = 367
        Me.PressureSystemReadingBasicLabel.Text = "000.01"
        Me.PressureSystemReadingBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PressureSystemReadingBasicLabel.UseMnemonic = False
        Me.PressureSystemReadingBasicLabel.Value = "000.01"
        Me.PressureSystemReadingBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureSystemReadingBasicLabel.ValueLeftPadLength = 0
        Me.PressureSystemReadingBasicLabel.ValuePrefix = Nothing
        Me.PressureSystemReadingBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureSystemReadingBasicLabel.ValueSuffix = Nothing
        '
        'GaugeReadingLabel
        '
        Me.GaugeReadingLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GaugeReadingLabel.Location = New System.Drawing.Point(17, 429)
        Me.GaugeReadingLabel.Name = "GaugeReadingLabel"
        Me.GaugeReadingLabel.Size = New System.Drawing.Size(271, 21)
        Me.GaugeReadingLabel.TabIndex = 371
        Me.GaugeReadingLabel.Text = "Gauge Reading:"
        Me.GaugeReadingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SaveVerificationBasicButton
        '
        Me.SaveVerificationBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveVerificationBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SaveVerificationBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveVerificationBasicButton.ForeColor = System.Drawing.Color.Black
        Me.SaveVerificationBasicButton.Highlight = False
        Me.SaveVerificationBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.SaveVerificationBasicButton.Location = New System.Drawing.Point(65, 634)
        Me.SaveVerificationBasicButton.MaximumHoldTime = 3000
        Me.SaveVerificationBasicButton.MinimumHoldTime = 500
        Me.SaveVerificationBasicButton.Name = "SaveVerificationBasicButton"
        Me.SaveVerificationBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SaveVerificationBasicButton.PLCAddressClick = "CalVerification.Bits[0].2"
        Me.SaveVerificationBasicButton.SelectTextAlternate = False
        Me.SaveVerificationBasicButton.Size = New System.Drawing.Size(190, 61)
        Me.SaveVerificationBasicButton.TabIndex = 392
        Me.SaveVerificationBasicButton.Text = "Save Verification"
        Me.SaveVerificationBasicButton.TextAlternate = Nothing
        Me.SaveVerificationBasicButton.UseVisualStyleBackColor = True
        Me.SaveVerificationBasicButton.ValueToWrite = 0
        '
        'CancelVerificationBasicButton
        '
        Me.CancelVerificationBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.CancelVerificationBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CancelVerificationBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelVerificationBasicButton.ForeColor = System.Drawing.Color.Black
        Me.CancelVerificationBasicButton.Highlight = False
        Me.CancelVerificationBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.CancelVerificationBasicButton.Location = New System.Drawing.Point(336, 634)
        Me.CancelVerificationBasicButton.MaximumHoldTime = 3000
        Me.CancelVerificationBasicButton.MinimumHoldTime = 500
        Me.CancelVerificationBasicButton.Name = "CancelVerificationBasicButton"
        Me.CancelVerificationBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CancelVerificationBasicButton.PLCAddressClick = "CalVerification.Bits[0].3"
        Me.CancelVerificationBasicButton.SelectTextAlternate = False
        Me.CancelVerificationBasicButton.Size = New System.Drawing.Size(192, 61)
        Me.CancelVerificationBasicButton.TabIndex = 393
        Me.CancelVerificationBasicButton.Text = "Cancel"
        Me.CancelVerificationBasicButton.TextAlternate = Nothing
        Me.CancelVerificationBasicButton.UseVisualStyleBackColor = True
        Me.CancelVerificationBasicButton.ValueToWrite = 0
        '
        'PressureGaugeReadingBasicLabel
        '
        Me.PressureGaugeReadingBasicLabel.BackColor = System.Drawing.Color.Transparent
        Me.PressureGaugeReadingBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureGaugeReadingBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PressureGaugeReadingBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureGaugeReadingBasicLabel.DisplayAsTime = False
        Me.PressureGaugeReadingBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureGaugeReadingBasicLabel.ForeColor = System.Drawing.Color.Black
        Me.PressureGaugeReadingBasicLabel.Highlight = False
        Me.PressureGaugeReadingBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.PressureGaugeReadingBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureGaugeReadingBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureGaugeReadingBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PressureGaugeReadingBasicLabel.KeypadAlphaNumeric = False
        Me.PressureGaugeReadingBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureGaugeReadingBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureGaugeReadingBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureGaugeReadingBasicLabel.KeypadMinValue = 0.0R
        Me.PressureGaugeReadingBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureGaugeReadingBasicLabel.KeypadShowCurrentValue = False
        Me.PressureGaugeReadingBasicLabel.KeypadText = Nothing
        Me.PressureGaugeReadingBasicLabel.KeypadWidth = 400
        Me.PressureGaugeReadingBasicLabel.Location = New System.Drawing.Point(312, 426)
        Me.PressureGaugeReadingBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PressureGaugeReadingBasicLabel.Name = "PressureGaugeReadingBasicLabel"
        Me.PressureGaugeReadingBasicLabel.NumericFormat = "000.00"
        Me.PressureGaugeReadingBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PressureGaugeReadingBasicLabel.PLCAddressKeypad = "CalVer.Gauge1"
        Me.PressureGaugeReadingBasicLabel.PLCAddressValue = "CalVer.Edit_Gauge1"
        Me.PressureGaugeReadingBasicLabel.PollRate = 0
        Me.PressureGaugeReadingBasicLabel.Size = New System.Drawing.Size(61, 27)
        Me.PressureGaugeReadingBasicLabel.TabIndex = 397
        Me.PressureGaugeReadingBasicLabel.Text = "025.00"
        Me.PressureGaugeReadingBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PressureGaugeReadingBasicLabel.UseMnemonic = False
        Me.PressureGaugeReadingBasicLabel.Value = "25"
        Me.PressureGaugeReadingBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureGaugeReadingBasicLabel.ValueLeftPadLength = 0
        Me.PressureGaugeReadingBasicLabel.ValuePrefix = Nothing
        Me.PressureGaugeReadingBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureGaugeReadingBasicLabel.ValueSuffix = Nothing
        '
        'SetPointUnitLabel
        '
        Me.SetPointUnitLabel.AutoSize = True
        Me.SetPointUnitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetPointUnitLabel.Location = New System.Drawing.Point(381, 358)
        Me.SetPointUnitLabel.Name = "SetPointUnitLabel"
        Me.SetPointUnitLabel.Size = New System.Drawing.Size(34, 21)
        Me.SetPointUnitLabel.TabIndex = 398
        Me.SetPointUnitLabel.Text = "bar"
        '
        'SystemMeasurementUnitLabel
        '
        Me.SystemMeasurementUnitLabel.AutoSize = True
        Me.SystemMeasurementUnitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemMeasurementUnitLabel.Location = New System.Drawing.Point(379, 390)
        Me.SystemMeasurementUnitLabel.Name = "SystemMeasurementUnitLabel"
        Me.SystemMeasurementUnitLabel.Size = New System.Drawing.Size(34, 21)
        Me.SystemMeasurementUnitLabel.TabIndex = 399
        Me.SystemMeasurementUnitLabel.Text = "bar"
        '
        'GaugeReadingUnitLabel
        '
        Me.GaugeReadingUnitLabel.AutoSize = True
        Me.GaugeReadingUnitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GaugeReadingUnitLabel.Location = New System.Drawing.Point(381, 428)
        Me.GaugeReadingUnitLabel.Name = "GaugeReadingUnitLabel"
        Me.GaugeReadingUnitLabel.Size = New System.Drawing.Size(34, 21)
        Me.GaugeReadingUnitLabel.TabIndex = 400
        Me.GaugeReadingUnitLabel.Text = "bar"
        '
        'VerificationStepLabel
        '
        Me.VerificationStepLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerificationStepLabel.Location = New System.Drawing.Point(3, 308)
        Me.VerificationStepLabel.Name = "VerificationStepLabel"
        Me.VerificationStepLabel.Size = New System.Drawing.Size(185, 21)
        Me.VerificationStepLabel.TabIndex = 401
        Me.VerificationStepLabel.Text = "Verification Step"
        Me.VerificationStepLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CurrentStepNumberLabel1
        '
        Me.CurrentStepNumberLabel1.AutoSize = True
        Me.CurrentStepNumberLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStepNumberLabel1.Location = New System.Drawing.Point(193, 308)
        Me.CurrentStepNumberLabel1.Name = "CurrentStepNumberLabel1"
        Me.CurrentStepNumberLabel1.Size = New System.Drawing.Size(19, 21)
        Me.CurrentStepNumberLabel1.TabIndex = 403
        Me.CurrentStepNumberLabel1.Text = "1"
        '
        'CurrentStepNumberLabel2
        '
        Me.CurrentStepNumberLabel2.AutoSize = True
        Me.CurrentStepNumberLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStepNumberLabel2.Location = New System.Drawing.Point(295, 508)
        Me.CurrentStepNumberLabel2.Name = "CurrentStepNumberLabel2"
        Me.CurrentStepNumberLabel2.Size = New System.Drawing.Size(19, 21)
        Me.CurrentStepNumberLabel2.TabIndex = 406
        Me.CurrentStepNumberLabel2.Text = "1"
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
        Me.CurrentDateTime.TabIndex = 407
        Me.CurrentDateTime.Text = "05-12-2016 09:10:27"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 410
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(176, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 409
        Me.PictureBox5.TabStop = False
        '
        'CaptureBasicButton
        '
        Me.CaptureBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.CaptureBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CaptureBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaptureBasicButton.ForeColor = System.Drawing.Color.Black
        Me.CaptureBasicButton.Highlight = False
        Me.CaptureBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.CaptureBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.trigger
        Me.CaptureBasicButton.Location = New System.Drawing.Point(440, 379)
        Me.CaptureBasicButton.MaximumHoldTime = 3000
        Me.CaptureBasicButton.MinimumHoldTime = 500
        Me.CaptureBasicButton.Name = "CaptureBasicButton"
        Me.CaptureBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CaptureBasicButton.PLCAddressClick = "CalVerification.Bits[0].4"
        Me.CaptureBasicButton.SelectTextAlternate = False
        Me.CaptureBasicButton.Size = New System.Drawing.Size(64, 51)
        Me.CaptureBasicButton.TabIndex = 405
        Me.CaptureBasicButton.TextAlternate = Nothing
        Me.CaptureBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CaptureBasicButton.UseVisualStyleBackColor = True
        Me.CaptureBasicButton.ValueToWrite = 0
        '
        'PreviousStepBasicButton
        '
        Me.PreviousStepBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.PreviousStepBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PreviousStepBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousStepBasicButton.ForeColor = System.Drawing.Color.Black
        Me.PreviousStepBasicButton.Highlight = False
        Me.PreviousStepBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.PreviousStepBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.left222
        Me.PreviousStepBasicButton.Location = New System.Drawing.Point(201, 497)
        Me.PreviousStepBasicButton.MaximumHoldTime = 3000
        Me.PreviousStepBasicButton.MinimumHoldTime = 500
        Me.PreviousStepBasicButton.Name = "PreviousStepBasicButton"
        Me.PreviousStepBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PreviousStepBasicButton.PLCAddressClick = ""
        Me.PreviousStepBasicButton.SelectTextAlternate = False
        Me.PreviousStepBasicButton.Size = New System.Drawing.Size(76, 47)
        Me.PreviousStepBasicButton.TabIndex = 404
        Me.PreviousStepBasicButton.TextAlternate = Nothing
        Me.PreviousStepBasicButton.UseVisualStyleBackColor = True
        Me.PreviousStepBasicButton.ValueToWrite = 0
        '
        'NextVerificationBasicButton
        '
        Me.NextVerificationBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.NextVerificationBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.NextVerificationBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextVerificationBasicButton.ForeColor = System.Drawing.Color.Black
        Me.NextVerificationBasicButton.Highlight = False
        Me.NextVerificationBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.NextVerificationBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.right11
        Me.NextVerificationBasicButton.Location = New System.Drawing.Point(329, 497)
        Me.NextVerificationBasicButton.MaximumHoldTime = 3000
        Me.NextVerificationBasicButton.MinimumHoldTime = 500
        Me.NextVerificationBasicButton.Name = "NextVerificationBasicButton"
        Me.NextVerificationBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.NextVerificationBasicButton.PLCAddressClick = ""
        Me.NextVerificationBasicButton.SelectTextAlternate = False
        Me.NextVerificationBasicButton.Size = New System.Drawing.Size(76, 47)
        Me.NextVerificationBasicButton.TabIndex = 402
        Me.NextVerificationBasicButton.TextAlternate = Nothing
        Me.NextVerificationBasicButton.UseVisualStyleBackColor = True
        Me.NextVerificationBasicButton.ValueToWrite = 0
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
        Me.AlmInd.TabIndex = 394
        Me.AlmInd.TabStop = False
        '
        'StopBasicButton
        '
        Me.StopBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.StopBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.StopBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopBasicButton.ForeColor = System.Drawing.Color.Black
        Me.StopBasicButton.Highlight = False
        Me.StopBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.StopBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.plain17
        Me.StopBasicButton.Location = New System.Drawing.Point(334, 150)
        Me.StopBasicButton.MaximumHoldTime = 3000
        Me.StopBasicButton.MinimumHoldTime = 500
        Me.StopBasicButton.Name = "StopBasicButton"
        Me.StopBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopBasicButton.PLCAddressClick = "CalVerification.Bits[0].1"
        Me.StopBasicButton.SelectTextAlternate = False
        Me.StopBasicButton.Size = New System.Drawing.Size(94, 49)
        Me.StopBasicButton.TabIndex = 313
        Me.StopBasicButton.Text = "Stop"
        Me.StopBasicButton.TextAlternate = Nothing
        Me.StopBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.StopBasicButton.UseVisualStyleBackColor = True
        Me.StopBasicButton.ValueToWrite = 0
        '
        'StartBasicButton
        '
        Me.StartBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.StartBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.StartBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBasicButton.ForeColor = System.Drawing.Color.Black
        Me.StartBasicButton.Highlight = False
        Me.StartBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.StartBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.play18m
        Me.StartBasicButton.Location = New System.Drawing.Point(224, 150)
        Me.StartBasicButton.MaximumHoldTime = 3000
        Me.StartBasicButton.MinimumHoldTime = 500
        Me.StartBasicButton.Name = "StartBasicButton"
        Me.StartBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StartBasicButton.PLCAddressClick = "CalVerification.Bits[0].0"
        Me.StartBasicButton.SelectTextAlternate = False
        Me.StartBasicButton.Size = New System.Drawing.Size(94, 49)
        Me.StartBasicButton.TabIndex = 312
        Me.StartBasicButton.Text = "Start"
        Me.StartBasicButton.TextAlternate = Nothing
        Me.StartBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.StartBasicButton.UseVisualStyleBackColor = True
        Me.StartBasicButton.ValueToWrite = 0
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
        'PressureVerificationPictureBox
        '
        Me.PressureVerificationPictureBox.BackColor = System.Drawing.Color.White
        Me.PressureVerificationPictureBox.Image = CType(resources.GetObject("PressureVerificationPictureBox.Image"), System.Drawing.Image)
        Me.PressureVerificationPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.PressureVerificationPictureBox.Name = "PressureVerificationPictureBox"
        Me.PressureVerificationPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.PressureVerificationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PressureVerificationPictureBox.TabIndex = 272
        Me.PressureVerificationPictureBox.TabStop = False
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
        'BasicLabel5
        '
        Me.BasicLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel5.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel5.KeypadAlphaNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0.0R
        Me.BasicLabel5.KeypadMinValue = 0.0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 400
        Me.BasicLabel5.Location = New System.Drawing.Point(299, 243)
        Me.BasicLabel5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = Nothing
        Me.BasicLabel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel5.PLCAddressKeypad = "CalVer.Edit_Serial"
        Me.BasicLabel5.PLCAddressValue = "CalVer.Edit_Serial"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(205, 27)
        Me.BasicLabel5.TabIndex = 412
        Me.BasicLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel5.UseMnemonic = False
        Me.BasicLabel5.Value = ""
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        '
        'GaugeSerialNumberLabel
        '
        Me.GaugeSerialNumberLabel.AutoSize = True
        Me.GaugeSerialNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GaugeSerialNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GaugeSerialNumberLabel.Location = New System.Drawing.Point(50, 243)
        Me.GaugeSerialNumberLabel.Name = "GaugeSerialNumberLabel"
        Me.GaugeSerialNumberLabel.Size = New System.Drawing.Size(165, 21)
        Me.GaugeSerialNumberLabel.TabIndex = 411
        Me.GaugeSerialNumberLabel.Text = "Gauge Serial Number"
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
        Me.AccessLevelLabel.TabIndex = 413
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_verification
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(632, 689)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.GaugeSerialNumberLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.CurrentStepNumberLabel2)
        Me.Controls.Add(Me.CaptureBasicButton)
        Me.Controls.Add(Me.PreviousStepBasicButton)
        Me.Controls.Add(Me.CurrentStepNumberLabel1)
        Me.Controls.Add(Me.NextVerificationBasicButton)
        Me.Controls.Add(Me.VerificationStepLabel)
        Me.Controls.Add(Me.GaugeReadingUnitLabel)
        Me.Controls.Add(Me.SystemMeasurementUnitLabel)
        Me.Controls.Add(Me.SetPointUnitLabel)
        Me.Controls.Add(Me.PressureGaugeReadingBasicLabel)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.CancelVerificationBasicButton)
        Me.Controls.Add(Me.SaveVerificationBasicButton)
        Me.Controls.Add(Me.GaugeReadingLabel)
        Me.Controls.Add(Me.PressureSystemReadingBasicLabel)
        Me.Controls.Add(Me.SystemMeasurementLabel)
        Me.Controls.Add(Me.SetPointLabel)
        Me.Controls.Add(Me.PressureSetPointBasicLabel)
        Me.Controls.Add(Me.StartVerificationRoutineLabel)
        Me.Controls.Add(Me.StopBasicButton)
        Me.Controls.Add(Me.StartBasicButton)
        Me.Controls.Add(Me.RunInd)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.PressureVerificationPictureBox)
        Me.Controls.Add(Me.PressureVerificationLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_verification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Verification"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PressureVerificationPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PressureVerificationPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PressureVerificationLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents StopBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents StartBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RunInd As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents StartVerificationRoutineLabel As System.Windows.Forms.Label
    Friend WithEvents PressureSetPointBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents SystemMeasurementLabel As System.Windows.Forms.Label
    Friend WithEvents SetPointLabel As System.Windows.Forms.Label
    Friend WithEvents GaugeReadingLabel As System.Windows.Forms.Label
    Friend WithEvents PressureSystemReadingBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents CancelVerificationBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents SaveVerificationBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents NextVerificationBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents VerificationStepLabel As System.Windows.Forms.Label
    Friend WithEvents GaugeReadingUnitLabel As System.Windows.Forms.Label
    Friend WithEvents SystemMeasurementUnitLabel As System.Windows.Forms.Label
    Friend WithEvents SetPointUnitLabel As System.Windows.Forms.Label
    Friend WithEvents PressureGaugeReadingBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents CurrentStepNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents PreviousStepBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents CaptureBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents CurrentStepNumberLabel2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents GaugeSerialNumberLabel As System.Windows.Forms.Label
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
