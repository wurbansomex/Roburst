<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_calibration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_calibration))
        Me.CalibrationLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.RunInd = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.StartCalibrationRoutineLabel = New System.Windows.Forms.Label()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.PressureCalibrationPoint1Label = New System.Windows.Forms.Label()
        Me.PercentagePoint1Label = New System.Windows.Forms.Label()
        Me.Percentage1Label = New System.Windows.Forms.Label()
        Me.AnalogInput1Label = New System.Windows.Forms.Label()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.AnalogInputPoint1CalibrationLabel = New System.Windows.Forms.Label()
        Me.Bar1Label = New System.Windows.Forms.Label()
        Me.ActualPressure1Label = New System.Windows.Forms.Label()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.Bar2Label = New System.Windows.Forms.Label()
        Me.ActualPressure2Label = New System.Windows.Forms.Label()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.AnalogInputPoint2CalibrationLabel = New System.Windows.Forms.Label()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.AnalogInput2Label = New System.Windows.Forms.Label()
        Me.Percentage2Label = New System.Windows.Forms.Label()
        Me.PercentagePoint2Label = New System.Windows.Forms.Label()
        Me.PressureCalibrationPoint2Label = New System.Windows.Forms.Label()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.SaveCalibrationBasicButton = New AdvancedHMIControls.BasicButton()
        Me.CancelBasicButton = New AdvancedHMIControls.BasicButton()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.GaugeSerialNumberLabel = New System.Windows.Forms.Label()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.SaveCalibrationPoint2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.RunCalibrationPoint2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.SaveCalibrationPoint1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.RunCalibrationPoint1BasicButton = New AdvancedHMIControls.BasicButton()
        Me.StopBasicButton = New AdvancedHMIControls.BasicButton()
        Me.StartBasicButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
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
        'CalibrationLabel
        '
        Me.CalibrationLabel.BackColor = System.Drawing.Color.White
        Me.CalibrationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalibrationLabel.ForeColor = System.Drawing.Color.DimGray
        Me.CalibrationLabel.Location = New System.Drawing.Point(196, 47)
        Me.CalibrationLabel.Name = "CalibrationLabel"
        Me.CalibrationLabel.Size = New System.Drawing.Size(219, 40)
        Me.CalibrationLabel.TabIndex = 271
        Me.CalibrationLabel.Text = "Calibration"
        Me.CalibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'RunInd
        '
        Me.RunInd.Color1 = System.Drawing.Color.Gray
        Me.RunInd.Color2 = System.Drawing.Color.LimeGreen
        Me.RunInd.Color3 = System.Drawing.Color.Red
        Me.RunInd.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunInd.ForeColor = System.Drawing.Color.Black
        Me.RunInd.Location = New System.Drawing.Point(219, 134)
        Me.RunInd.Name = "RunInd"
        Me.RunInd.OutlineColor = System.Drawing.Color.Transparent
        Me.RunInd.OutlineWidth = 1
        Me.RunInd.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunInd.PLCAddressVisible = "Calibration.Running"
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
        Me.BasicIndicator1.Location = New System.Drawing.Point(329, 134)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressVisible = "NOT Calibration.Running"
        Me.BasicIndicator1.SelectColor2 = True
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator1.Size = New System.Drawing.Size(104, 57)
        Me.BasicIndicator1.TabIndex = 315
        '
        'StartCalibrationRoutineLabel
        '
        Me.StartCalibrationRoutineLabel.AutoSize = True
        Me.StartCalibrationRoutineLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartCalibrationRoutineLabel.Location = New System.Drawing.Point(38, 97)
        Me.StartCalibrationRoutineLabel.Name = "StartCalibrationRoutineLabel"
        Me.StartCalibrationRoutineLabel.Size = New System.Drawing.Size(187, 21)
        Me.StartCalibrationRoutineLabel.TabIndex = 353
        Me.StartCalibrationRoutineLabel.Text = "Start calibration routine:"
        '
        'BasicLabel3
        '
        Me.BasicLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0.0R
        Me.BasicLabel3.KeypadMinValue = 0.0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 400
        Me.BasicLabel3.Location = New System.Drawing.Point(312, 306)
        Me.BasicLabel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = "000"
        Me.BasicLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel3.PLCAddressKeypad = "cal.Point1"
        Me.BasicLabel3.PLCAddressValue = "cal.Point1"
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel3.TabIndex = 355
        Me.BasicLabel3.Text = "025"
        Me.BasicLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel3.UseMnemonic = False
        Me.BasicLabel3.Value = "25"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        '
        'PressureCalibrationPoint1Label
        '
        Me.PressureCalibrationPoint1Label.AutoSize = True
        Me.PressureCalibrationPoint1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureCalibrationPoint1Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PressureCalibrationPoint1Label.Location = New System.Drawing.Point(38, 270)
        Me.PressureCalibrationPoint1Label.Name = "PressureCalibrationPoint1Label"
        Me.PressureCalibrationPoint1Label.Size = New System.Drawing.Size(210, 21)
        Me.PressureCalibrationPoint1Label.TabIndex = 363
        Me.PressureCalibrationPoint1Label.Text = "Pressure Calibration Point 1"
        '
        'PercentagePoint1Label
        '
        Me.PercentagePoint1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentagePoint1Label.Location = New System.Drawing.Point(12, 308)
        Me.PercentagePoint1Label.Name = "PercentagePoint1Label"
        Me.PercentagePoint1Label.Size = New System.Drawing.Size(275, 21)
        Me.PercentagePoint1Label.TabIndex = 364
        Me.PercentagePoint1Label.Text = "% Point 1:"
        Me.PercentagePoint1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Percentage1Label
        '
        Me.Percentage1Label.AutoSize = True
        Me.Percentage1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage1Label.Location = New System.Drawing.Point(380, 312)
        Me.Percentage1Label.Name = "Percentage1Label"
        Me.Percentage1Label.Size = New System.Drawing.Size(23, 21)
        Me.Percentage1Label.TabIndex = 365
        Me.Percentage1Label.Text = "%"
        '
        'AnalogInput1Label
        '
        Me.AnalogInput1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInput1Label.Location = New System.Drawing.Point(16, 344)
        Me.AnalogInput1Label.Name = "AnalogInput1Label"
        Me.AnalogInput1Label.Size = New System.Drawing.Size(275, 21)
        Me.AnalogInput1Label.TabIndex = 366
        Me.AnalogInput1Label.Text = "Analog Input:"
        Me.AnalogInput1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Black
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.ForeColor = System.Drawing.Color.Green
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 400
        Me.BasicLabel1.Location = New System.Drawing.Point(312, 344)
        Me.BasicLabel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "000.00"
        Me.BasicLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = "TestSt_Pressure.Raw"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel1.TabIndex = 367
        Me.BasicLabel1.Text = "000.01"
        Me.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel1.UseMnemonic = False
        Me.BasicLabel1.Value = "000.01"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.Black
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel7.ForeColor = System.Drawing.Color.Green
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0.0R
        Me.BasicLabel7.KeypadMinValue = 0.0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 400
        Me.BasicLabel7.Location = New System.Drawing.Point(312, 380)
        Me.BasicLabel7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = "000.00"
        Me.BasicLabel7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PLCAddressValue = "Cal.Raw1"
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel7.TabIndex = 369
        Me.BasicLabel7.Text = "000.01"
        Me.BasicLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel7.UseMnemonic = False
        Me.BasicLabel7.Value = "000.01"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        '
        'AnalogInputPoint1CalibrationLabel
        '
        Me.AnalogInputPoint1CalibrationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInputPoint1CalibrationLabel.Location = New System.Drawing.Point(-26, 380)
        Me.AnalogInputPoint1CalibrationLabel.Name = "AnalogInputPoint1CalibrationLabel"
        Me.AnalogInputPoint1CalibrationLabel.Size = New System.Drawing.Size(313, 21)
        Me.AnalogInputPoint1CalibrationLabel.TabIndex = 368
        Me.AnalogInputPoint1CalibrationLabel.Text = "Analog Input Point 1 Calibration:"
        Me.AnalogInputPoint1CalibrationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Bar1Label
        '
        Me.Bar1Label.AutoSize = True
        Me.Bar1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1Label.Location = New System.Drawing.Point(380, 422)
        Me.Bar1Label.Name = "Bar1Label"
        Me.Bar1Label.Size = New System.Drawing.Size(34, 21)
        Me.Bar1Label.TabIndex = 372
        Me.Bar1Label.Text = "bar"
        '
        'ActualPressure1Label
        '
        Me.ActualPressure1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualPressure1Label.Location = New System.Drawing.Point(32, 418)
        Me.ActualPressure1Label.Name = "ActualPressure1Label"
        Me.ActualPressure1Label.Size = New System.Drawing.Size(259, 21)
        Me.ActualPressure1Label.TabIndex = 371
        Me.ActualPressure1Label.Text = "Actual Pressure:"
        Me.ActualPressure1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel8
        '
        Me.BasicLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.DisplayAsTime = False
        Me.BasicLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel8.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel8.KeypadAlphaNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 0.0R
        Me.BasicLabel8.KeypadMinValue = 0.0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 400
        Me.BasicLabel8.Location = New System.Drawing.Point(312, 416)
        Me.BasicLabel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = "000.00"
        Me.BasicLabel8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel8.PLCAddressKeypad = "Cal.Scaled1"
        Me.BasicLabel8.PLCAddressValue = "Cal.Scaled1"
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel8.TabIndex = 370
        Me.BasicLabel8.Text = "100.00"
        Me.BasicLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel8.UseMnemonic = False
        Me.BasicLabel8.Value = "100"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        '
        'Bar2Label
        '
        Me.Bar2Label.AutoSize = True
        Me.Bar2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2Label.Location = New System.Drawing.Point(380, 618)
        Me.Bar2Label.Name = "Bar2Label"
        Me.Bar2Label.Size = New System.Drawing.Size(34, 21)
        Me.Bar2Label.TabIndex = 385
        Me.Bar2Label.Text = "bar"
        '
        'ActualPressure2Label
        '
        Me.ActualPressure2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualPressure2Label.Location = New System.Drawing.Point(20, 614)
        Me.ActualPressure2Label.Name = "ActualPressure2Label"
        Me.ActualPressure2Label.Size = New System.Drawing.Size(271, 21)
        Me.ActualPressure2Label.TabIndex = 384
        Me.ActualPressure2Label.Text = "Actual Pressure:"
        Me.ActualPressure2Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel2
        '
        Me.BasicLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel2.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0.0R
        Me.BasicLabel2.KeypadMinValue = 0.0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 400
        Me.BasicLabel2.Location = New System.Drawing.Point(312, 612)
        Me.BasicLabel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = "000.00"
        Me.BasicLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel2.PLCAddressKeypad = "Cal.Scaled2"
        Me.BasicLabel2.PLCAddressValue = "Cal.Scaled2"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel2.TabIndex = 383
        Me.BasicLabel2.Text = "000.01"
        Me.BasicLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel2.UseMnemonic = False
        Me.BasicLabel2.Value = "000.01"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'BasicLabel4
        '
        Me.BasicLabel4.BackColor = System.Drawing.Color.Black
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel4.ForeColor = System.Drawing.Color.Green
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel4.KeypadAlphaNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0.0R
        Me.BasicLabel4.KeypadMinValue = 0.0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 400
        Me.BasicLabel4.Location = New System.Drawing.Point(312, 576)
        Me.BasicLabel4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = "000.00"
        Me.BasicLabel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PLCAddressValue = "Cal.Raw2"
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel4.TabIndex = 382
        Me.BasicLabel4.Text = "000.01"
        Me.BasicLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel4.UseMnemonic = False
        Me.BasicLabel4.Value = "000.01"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        '
        'AnalogInputPoint2CalibrationLabel
        '
        Me.AnalogInputPoint2CalibrationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInputPoint2CalibrationLabel.Location = New System.Drawing.Point(-26, 576)
        Me.AnalogInputPoint2CalibrationLabel.Name = "AnalogInputPoint2CalibrationLabel"
        Me.AnalogInputPoint2CalibrationLabel.Size = New System.Drawing.Size(316, 21)
        Me.AnalogInputPoint2CalibrationLabel.TabIndex = 381
        Me.AnalogInputPoint2CalibrationLabel.Text = "Analog Input Point 2 Calibration:"
        Me.AnalogInputPoint2CalibrationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel9
        '
        Me.BasicLabel9.BackColor = System.Drawing.Color.Black
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel9.DisplayAsTime = False
        Me.BasicLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel9.ForeColor = System.Drawing.Color.Green
        Me.BasicLabel9.Highlight = False
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel9.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel9.KeypadAlphaNumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 0.0R
        Me.BasicLabel9.KeypadMinValue = 0.0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 400
        Me.BasicLabel9.Location = New System.Drawing.Point(312, 540)
        Me.BasicLabel9.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = "000.00"
        Me.BasicLabel9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel9.PLCAddressKeypad = ""
        Me.BasicLabel9.PLCAddressValue = "TestSt_Pressure.Raw"
        Me.BasicLabel9.PollRate = 0
        Me.BasicLabel9.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel9.TabIndex = 380
        Me.BasicLabel9.Text = "000.01"
        Me.BasicLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel9.UseMnemonic = False
        Me.BasicLabel9.Value = "000.01"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel9.ValueLeftPadLength = 0
        Me.BasicLabel9.ValuePrefix = Nothing
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        '
        'AnalogInput2Label
        '
        Me.AnalogInput2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInput2Label.Location = New System.Drawing.Point(20, 540)
        Me.AnalogInput2Label.Name = "AnalogInput2Label"
        Me.AnalogInput2Label.Size = New System.Drawing.Size(271, 21)
        Me.AnalogInput2Label.TabIndex = 379
        Me.AnalogInput2Label.Text = "Analog Input:"
        Me.AnalogInput2Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Percentage2Label
        '
        Me.Percentage2Label.AutoSize = True
        Me.Percentage2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage2Label.Location = New System.Drawing.Point(380, 508)
        Me.Percentage2Label.Name = "Percentage2Label"
        Me.Percentage2Label.Size = New System.Drawing.Size(23, 21)
        Me.Percentage2Label.TabIndex = 378
        Me.Percentage2Label.Text = "%"
        '
        'PercentagePoint2Label
        '
        Me.PercentagePoint2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentagePoint2Label.Location = New System.Drawing.Point(16, 504)
        Me.PercentagePoint2Label.Name = "PercentagePoint2Label"
        Me.PercentagePoint2Label.Size = New System.Drawing.Size(274, 21)
        Me.PercentagePoint2Label.TabIndex = 377
        Me.PercentagePoint2Label.Text = "% Point 2:"
        Me.PercentagePoint2Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PressureCalibrationPoint2Label
        '
        Me.PressureCalibrationPoint2Label.AutoSize = True
        Me.PressureCalibrationPoint2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureCalibrationPoint2Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PressureCalibrationPoint2Label.Location = New System.Drawing.Point(38, 457)
        Me.PressureCalibrationPoint2Label.Name = "PressureCalibrationPoint2Label"
        Me.PressureCalibrationPoint2Label.Size = New System.Drawing.Size(210, 21)
        Me.PressureCalibrationPoint2Label.TabIndex = 376
        Me.PressureCalibrationPoint2Label.Text = "Pressure Calibration Point 2"
        '
        'BasicLabel10
        '
        Me.BasicLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel10.DisplayAsTime = False
        Me.BasicLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel10.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel10.Highlight = False
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel10.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel10.KeypadAlphaNumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 0.0R
        Me.BasicLabel10.KeypadMinValue = 0.0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 400
        Me.BasicLabel10.Location = New System.Drawing.Point(312, 502)
        Me.BasicLabel10.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = "000.00"
        Me.BasicLabel10.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel10.PLCAddressKeypad = "cal.Point2"
        Me.BasicLabel10.PLCAddressValue = "cal.Point2"
        Me.BasicLabel10.PollRate = 0
        Me.BasicLabel10.Size = New System.Drawing.Size(61, 27)
        Me.BasicLabel10.TabIndex = 375
        Me.BasicLabel10.Text = "075.00"
        Me.BasicLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel10.UseMnemonic = False
        Me.BasicLabel10.Value = "75"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel10.ValueLeftPadLength = 0
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 1.0R
        Me.BasicLabel10.ValueSuffix = Nothing
        '
        'SaveCalibrationBasicButton
        '
        Me.SaveCalibrationBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveCalibrationBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SaveCalibrationBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCalibrationBasicButton.ForeColor = System.Drawing.Color.Black
        Me.SaveCalibrationBasicButton.Highlight = False
        Me.SaveCalibrationBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.SaveCalibrationBasicButton.Location = New System.Drawing.Point(79, 669)
        Me.SaveCalibrationBasicButton.MaximumHoldTime = 3000
        Me.SaveCalibrationBasicButton.MinimumHoldTime = 500
        Me.SaveCalibrationBasicButton.Name = "SaveCalibrationBasicButton"
        Me.SaveCalibrationBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SaveCalibrationBasicButton.PLCAddressClick = "Calibration.Bits[0].4"
        Me.SaveCalibrationBasicButton.SelectTextAlternate = False
        Me.SaveCalibrationBasicButton.Size = New System.Drawing.Size(187, 61)
        Me.SaveCalibrationBasicButton.TabIndex = 392
        Me.SaveCalibrationBasicButton.Text = "Save Calibration"
        Me.SaveCalibrationBasicButton.TextAlternate = Nothing
        Me.SaveCalibrationBasicButton.UseVisualStyleBackColor = True
        Me.SaveCalibrationBasicButton.ValueToWrite = 0
        '
        'CancelBasicButton
        '
        Me.CancelBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.CancelBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CancelBasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBasicButton.ForeColor = System.Drawing.Color.Black
        Me.CancelBasicButton.Highlight = False
        Me.CancelBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.CancelBasicButton.Location = New System.Drawing.Point(345, 670)
        Me.CancelBasicButton.MaximumHoldTime = 3000
        Me.CancelBasicButton.MinimumHoldTime = 500
        Me.CancelBasicButton.Name = "CancelBasicButton"
        Me.CancelBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.CancelBasicButton.PLCAddressClick = "Calibration.Bits[0].7"
        Me.CancelBasicButton.SelectTextAlternate = False
        Me.CancelBasicButton.Size = New System.Drawing.Size(188, 61)
        Me.CancelBasicButton.TabIndex = 393
        Me.CancelBasicButton.Text = "Cancel"
        Me.CancelBasicButton.TextAlternate = Nothing
        Me.CancelBasicButton.UseVisualStyleBackColor = True
        Me.CancelBasicButton.ValueToWrite = 0
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(28, 5)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 405
        Me.CurrentDateTime.Text = "30-11-2016 14:50:55"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GaugeSerialNumberLabel
        '
        Me.GaugeSerialNumberLabel.AutoSize = True
        Me.GaugeSerialNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GaugeSerialNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GaugeSerialNumberLabel.Location = New System.Drawing.Point(38, 213)
        Me.GaugeSerialNumberLabel.Name = "GaugeSerialNumberLabel"
        Me.GaugeSerialNumberLabel.Size = New System.Drawing.Size(82, 21)
        Me.GaugeSerialNumberLabel.TabIndex = 409
        Me.GaugeSerialNumberLabel.Text = "Gauge SN"
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
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Gray
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
        Me.BasicLabel5.Location = New System.Drawing.Point(312, 213)
        Me.BasicLabel5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = Nothing
        Me.BasicLabel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel5.PLCAddressKeypad = "Cal.Serial"
        Me.BasicLabel5.PLCAddressValue = "Cal.Serial"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(221, 27)
        Me.BasicLabel5.TabIndex = 410
        Me.BasicLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel5.UseMnemonic = False
        Me.BasicLabel5.Value = ""
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(5, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 408
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(174, 6)
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
        Me.AlmInd.TabIndex = 394
        Me.AlmInd.TabStop = False
        '
        'SaveCalibrationPoint2BasicButton
        '
        Me.SaveCalibrationPoint2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveCalibrationPoint2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SaveCalibrationPoint2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCalibrationPoint2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.SaveCalibrationPoint2BasicButton.Highlight = False
        Me.SaveCalibrationPoint2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.SaveCalibrationPoint2BasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.save
        Me.SaveCalibrationPoint2BasicButton.Location = New System.Drawing.Point(459, 573)
        Me.SaveCalibrationPoint2BasicButton.MaximumHoldTime = 3000
        Me.SaveCalibrationPoint2BasicButton.MinimumHoldTime = 500
        Me.SaveCalibrationPoint2BasicButton.Name = "SaveCalibrationPoint2BasicButton"
        Me.SaveCalibrationPoint2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SaveCalibrationPoint2BasicButton.PLCAddressClick = "Calibration.Bits[0].3"
        Me.SaveCalibrationPoint2BasicButton.SelectTextAlternate = False
        Me.SaveCalibrationPoint2BasicButton.Size = New System.Drawing.Size(74, 62)
        Me.SaveCalibrationPoint2BasicButton.TabIndex = 391
        Me.SaveCalibrationPoint2BasicButton.TextAlternate = Nothing
        Me.SaveCalibrationPoint2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveCalibrationPoint2BasicButton.UseVisualStyleBackColor = True
        Me.SaveCalibrationPoint2BasicButton.ValueToWrite = 0
        '
        'RunCalibrationPoint2BasicButton
        '
        Me.RunCalibrationPoint2BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.RunCalibrationPoint2BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunCalibrationPoint2BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunCalibrationPoint2BasicButton.ForeColor = System.Drawing.Color.Black
        Me.RunCalibrationPoint2BasicButton.Highlight = False
        Me.RunCalibrationPoint2BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.RunCalibrationPoint2BasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.trigger
        Me.RunCalibrationPoint2BasicButton.Location = New System.Drawing.Point(459, 507)
        Me.RunCalibrationPoint2BasicButton.MaximumHoldTime = 3000
        Me.RunCalibrationPoint2BasicButton.MinimumHoldTime = 500
        Me.RunCalibrationPoint2BasicButton.Name = "RunCalibrationPoint2BasicButton"
        Me.RunCalibrationPoint2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunCalibrationPoint2BasicButton.PLCAddressClick = "Calibration.Bits[0].2"
        Me.RunCalibrationPoint2BasicButton.SelectTextAlternate = False
        Me.RunCalibrationPoint2BasicButton.Size = New System.Drawing.Size(74, 60)
        Me.RunCalibrationPoint2BasicButton.TabIndex = 390
        Me.RunCalibrationPoint2BasicButton.TextAlternate = Nothing
        Me.RunCalibrationPoint2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RunCalibrationPoint2BasicButton.UseVisualStyleBackColor = True
        Me.RunCalibrationPoint2BasicButton.ValueToWrite = 0
        '
        'SaveCalibrationPoint1BasicButton
        '
        Me.SaveCalibrationPoint1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveCalibrationPoint1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SaveCalibrationPoint1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCalibrationPoint1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.SaveCalibrationPoint1BasicButton.Highlight = False
        Me.SaveCalibrationPoint1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.SaveCalibrationPoint1BasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.save
        Me.SaveCalibrationPoint1BasicButton.Location = New System.Drawing.Point(459, 377)
        Me.SaveCalibrationPoint1BasicButton.MaximumHoldTime = 3000
        Me.SaveCalibrationPoint1BasicButton.MinimumHoldTime = 500
        Me.SaveCalibrationPoint1BasicButton.Name = "SaveCalibrationPoint1BasicButton"
        Me.SaveCalibrationPoint1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SaveCalibrationPoint1BasicButton.PLCAddressClick = "Calibration.Bits[0].1"
        Me.SaveCalibrationPoint1BasicButton.SelectTextAlternate = False
        Me.SaveCalibrationPoint1BasicButton.Size = New System.Drawing.Size(74, 57)
        Me.SaveCalibrationPoint1BasicButton.TabIndex = 389
        Me.SaveCalibrationPoint1BasicButton.TextAlternate = Nothing
        Me.SaveCalibrationPoint1BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveCalibrationPoint1BasicButton.UseVisualStyleBackColor = True
        Me.SaveCalibrationPoint1BasicButton.ValueToWrite = 0
        '
        'RunCalibrationPoint1BasicButton
        '
        Me.RunCalibrationPoint1BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.RunCalibrationPoint1BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunCalibrationPoint1BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunCalibrationPoint1BasicButton.ForeColor = System.Drawing.Color.Black
        Me.RunCalibrationPoint1BasicButton.Highlight = False
        Me.RunCalibrationPoint1BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.RunCalibrationPoint1BasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.trigger
        Me.RunCalibrationPoint1BasicButton.Location = New System.Drawing.Point(459, 312)
        Me.RunCalibrationPoint1BasicButton.MaximumHoldTime = 3000
        Me.RunCalibrationPoint1BasicButton.MinimumHoldTime = 500
        Me.RunCalibrationPoint1BasicButton.Name = "RunCalibrationPoint1BasicButton"
        Me.RunCalibrationPoint1BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunCalibrationPoint1BasicButton.PLCAddressClick = "Calibration.Bits[0].0"
        Me.RunCalibrationPoint1BasicButton.SelectTextAlternate = False
        Me.RunCalibrationPoint1BasicButton.Size = New System.Drawing.Size(74, 59)
        Me.RunCalibrationPoint1BasicButton.TabIndex = 388
        Me.RunCalibrationPoint1BasicButton.TextAlternate = Nothing
        Me.RunCalibrationPoint1BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RunCalibrationPoint1BasicButton.UseVisualStyleBackColor = True
        Me.RunCalibrationPoint1BasicButton.ValueToWrite = 0
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
        Me.StopBasicButton.Location = New System.Drawing.Point(334, 138)
        Me.StopBasicButton.MaximumHoldTime = 3000
        Me.StopBasicButton.MinimumHoldTime = 500
        Me.StopBasicButton.Name = "StopBasicButton"
        Me.StopBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopBasicButton.PLCAddressClick = "Calibration.Bits[0].6"
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
        Me.StartBasicButton.Location = New System.Drawing.Point(224, 138)
        Me.StartBasicButton.MaximumHoldTime = 3000
        Me.StartBasicButton.MinimumHoldTime = 500
        Me.StartBasicButton.Name = "StartBasicButton"
        Me.StartBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StartBasicButton.PLCAddressClick = "Calibration.Bits[0].5"
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
        Me.PgOpenHomeButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 289
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
        Me.AccessLevelLabel.TabIndex = 411
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_calibration
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.GaugeSerialNumberLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.CancelBasicButton)
        Me.Controls.Add(Me.SaveCalibrationBasicButton)
        Me.Controls.Add(Me.SaveCalibrationPoint2BasicButton)
        Me.Controls.Add(Me.RunCalibrationPoint2BasicButton)
        Me.Controls.Add(Me.SaveCalibrationPoint1BasicButton)
        Me.Controls.Add(Me.RunCalibrationPoint1BasicButton)
        Me.Controls.Add(Me.Bar2Label)
        Me.Controls.Add(Me.ActualPressure2Label)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.AnalogInputPoint2CalibrationLabel)
        Me.Controls.Add(Me.BasicLabel9)
        Me.Controls.Add(Me.AnalogInput2Label)
        Me.Controls.Add(Me.Percentage2Label)
        Me.Controls.Add(Me.PercentagePoint2Label)
        Me.Controls.Add(Me.PressureCalibrationPoint2Label)
        Me.Controls.Add(Me.BasicLabel10)
        Me.Controls.Add(Me.Bar1Label)
        Me.Controls.Add(Me.ActualPressure1Label)
        Me.Controls.Add(Me.BasicLabel8)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.AnalogInputPoint1CalibrationLabel)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.AnalogInput1Label)
        Me.Controls.Add(Me.Percentage1Label)
        Me.Controls.Add(Me.PercentagePoint1Label)
        Me.Controls.Add(Me.PressureCalibrationPoint1Label)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.StartCalibrationRoutineLabel)
        Me.Controls.Add(Me.StopBasicButton)
        Me.Controls.Add(Me.StartBasicButton)
        Me.Controls.Add(Me.RunInd)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.CalibrationLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_calibration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Calibrate"
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
    Friend WithEvents CalibrationLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents StopBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents StartBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RunInd As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents StartCalibrationRoutineLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnalogInput1Label As System.Windows.Forms.Label
    Friend WithEvents Percentage1Label As System.Windows.Forms.Label
    Friend WithEvents PercentagePoint1Label As System.Windows.Forms.Label
    Friend WithEvents PressureCalibrationPoint1Label As System.Windows.Forms.Label
    Friend WithEvents Bar1Label As System.Windows.Forms.Label
    Friend WithEvents ActualPressure1Label As System.Windows.Forms.Label
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnalogInputPoint1CalibrationLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Bar2Label As System.Windows.Forms.Label
    Friend WithEvents ActualPressure2Label As System.Windows.Forms.Label
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnalogInputPoint2CalibrationLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnalogInput2Label As System.Windows.Forms.Label
    Friend WithEvents Percentage2Label As System.Windows.Forms.Label
    Friend WithEvents PercentagePoint2Label As System.Windows.Forms.Label
    Friend WithEvents PressureCalibrationPoint2Label As System.Windows.Forms.Label
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents CancelBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents SaveCalibrationBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents SaveCalibrationPoint2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RunCalibrationPoint2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents SaveCalibrationPoint1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RunCalibrationPoint1BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents GaugeSerialNumberLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
