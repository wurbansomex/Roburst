<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_io_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_io_3))
        Me.AnalogIOLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.WaterPressureRawValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.WaterPressureTransducerLabel = New System.Windows.Forms.Label()
        Me.AnalogInputsBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.RawLabel = New System.Windows.Forms.Label()
        Me.ScaledLabel = New System.Windows.Forms.Label()
        Me.WaterPressureScaledValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.Barg1Label = New System.Windows.Forms.Label()
        Me.Barg2Label = New System.Windows.Forms.Label()
        Me.TestPressureScaledValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.TestPressureRawValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.TestPressureLabel = New System.Windows.Forms.Label()
        Me.AnalogOutputsBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.SpareO30Label = New System.Windows.Forms.Label()
        Me.ProportionalPressureRegulatorLabel = New System.Windows.Forms.Label()
        Me.SpareO30RawValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.ProportionalPressureRegulatorRawValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.Percentage2Label = New System.Windows.Forms.Label()
        Me.Percentage1Label = New System.Windows.Forms.Label()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.DigitalInputs1Button = New System.Windows.Forms.Button()
        Me.DigitalInputs2Button = New System.Windows.Forms.Button()
        Me.AnalogsButton = New System.Windows.Forms.Button()
        Me.DigitalOutputs1Button = New System.Windows.Forms.Button()
        Me.DigitalOutputs2Button = New System.Windows.Forms.Button()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.AnalogIOPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalogIOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnalogIOLabel
        '
        Me.AnalogIOLabel.BackColor = System.Drawing.Color.White
        Me.AnalogIOLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogIOLabel.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogIOLabel.Location = New System.Drawing.Point(196, 47)
        Me.AnalogIOLabel.Name = "AnalogIOLabel"
        Me.AnalogIOLabel.Size = New System.Drawing.Size(219, 40)
        Me.AnalogIOLabel.TabIndex = 271
        Me.AnalogIOLabel.Text = "Analog IO"
        Me.AnalogIOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'WaterPressureRawValueBasicLabel
        '
        Me.WaterPressureRawValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.WaterPressureRawValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.WaterPressureRawValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WaterPressureRawValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.WaterPressureRawValueBasicLabel.DisplayAsTime = False
        Me.WaterPressureRawValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPressureRawValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WaterPressureRawValueBasicLabel.Highlight = False
        Me.WaterPressureRawValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.WaterPressureRawValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.WaterPressureRawValueBasicLabel.HighlightKeyCharacter = "!"
        Me.WaterPressureRawValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WaterPressureRawValueBasicLabel.KeypadAlphaNumeric = False
        Me.WaterPressureRawValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPressureRawValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.WaterPressureRawValueBasicLabel.KeypadMaxValue = 0.0R
        Me.WaterPressureRawValueBasicLabel.KeypadMinValue = 0.0R
        Me.WaterPressureRawValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.WaterPressureRawValueBasicLabel.KeypadShowCurrentValue = False
        Me.WaterPressureRawValueBasicLabel.KeypadText = Nothing
        Me.WaterPressureRawValueBasicLabel.KeypadWidth = 400
        Me.WaterPressureRawValueBasicLabel.Location = New System.Drawing.Point(323, 178)
        Me.WaterPressureRawValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.WaterPressureRawValueBasicLabel.Name = "WaterPressureRawValueBasicLabel"
        Me.WaterPressureRawValueBasicLabel.NumericFormat = "0.0"
        Me.WaterPressureRawValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.WaterPressureRawValueBasicLabel.PLCAddressKeypad = ""
        Me.WaterPressureRawValueBasicLabel.PLCAddressValue = "TestSt_Pressure.Raw"
        Me.WaterPressureRawValueBasicLabel.PollRate = 0
        Me.WaterPressureRawValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.WaterPressureRawValueBasicLabel.TabIndex = 365
        Me.WaterPressureRawValueBasicLabel.Text = "9.9"
        Me.WaterPressureRawValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WaterPressureRawValueBasicLabel.UseMnemonic = False
        Me.WaterPressureRawValueBasicLabel.Value = "9.9"
        Me.WaterPressureRawValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WaterPressureRawValueBasicLabel.ValueLeftPadLength = 0
        Me.WaterPressureRawValueBasicLabel.ValuePrefix = Nothing
        Me.WaterPressureRawValueBasicLabel.ValueScaleFactor = 1.0R
        Me.WaterPressureRawValueBasicLabel.ValueSuffix = Nothing
        '
        'WaterPressureTransducerLabel
        '
        Me.WaterPressureTransducerLabel.BackColor = System.Drawing.Color.Gray
        Me.WaterPressureTransducerLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPressureTransducerLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WaterPressureTransducerLabel.Location = New System.Drawing.Point(5, 181)
        Me.WaterPressureTransducerLabel.Name = "WaterPressureTransducerLabel"
        Me.WaterPressureTransducerLabel.Size = New System.Drawing.Size(300, 19)
        Me.WaterPressureTransducerLabel.TabIndex = 364
        Me.WaterPressureTransducerLabel.Text = "I:2:0 Test Station Presssure"
        Me.WaterPressureTransducerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnalogInputsBasicLabel
        '
        Me.AnalogInputsBasicLabel.AutoSize = True
        Me.AnalogInputsBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.AnalogInputsBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.AnalogInputsBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogInputsBasicLabel.DisplayAsTime = False
        Me.AnalogInputsBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInputsBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogInputsBasicLabel.Highlight = False
        Me.AnalogInputsBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.AnalogInputsBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.AnalogInputsBasicLabel.HighlightKeyCharacter = "!"
        Me.AnalogInputsBasicLabel.KeypadAlphaNumeric = False
        Me.AnalogInputsBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.AnalogInputsBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogInputsBasicLabel.KeypadMaxValue = 0.0R
        Me.AnalogInputsBasicLabel.KeypadMinValue = 0.0R
        Me.AnalogInputsBasicLabel.KeypadScaleFactor = 1.0R
        Me.AnalogInputsBasicLabel.KeypadShowCurrentValue = False
        Me.AnalogInputsBasicLabel.KeypadText = Nothing
        Me.AnalogInputsBasicLabel.KeypadWidth = 300
        Me.AnalogInputsBasicLabel.Location = New System.Drawing.Point(12, 123)
        Me.AnalogInputsBasicLabel.Name = "AnalogInputsBasicLabel"
        Me.AnalogInputsBasicLabel.NumericFormat = Nothing
        Me.AnalogInputsBasicLabel.PLCAddressKeypad = ""
        Me.AnalogInputsBasicLabel.PollRate = 0
        Me.AnalogInputsBasicLabel.Size = New System.Drawing.Size(111, 21)
        Me.AnalogInputsBasicLabel.TabIndex = 363
        Me.AnalogInputsBasicLabel.Text = "Analog inputs"
        Me.AnalogInputsBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AnalogInputsBasicLabel.Value = "Analog inputs"
        Me.AnalogInputsBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnalogInputsBasicLabel.ValueLeftPadLength = 0
        Me.AnalogInputsBasicLabel.ValuePrefix = Nothing
        Me.AnalogInputsBasicLabel.ValueScaleFactor = 1.0R
        Me.AnalogInputsBasicLabel.ValueSuffix = Nothing
        '
        'RawLabel
        '
        Me.RawLabel.AutoSize = True
        Me.RawLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RawLabel.Location = New System.Drawing.Point(319, 142)
        Me.RawLabel.Name = "RawLabel"
        Me.RawLabel.Size = New System.Drawing.Size(36, 19)
        Me.RawLabel.TabIndex = 366
        Me.RawLabel.Text = "Raw"
        '
        'ScaledLabel
        '
        Me.ScaledLabel.AutoSize = True
        Me.ScaledLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScaledLabel.Location = New System.Drawing.Point(441, 143)
        Me.ScaledLabel.Name = "ScaledLabel"
        Me.ScaledLabel.Size = New System.Drawing.Size(50, 19)
        Me.ScaledLabel.TabIndex = 368
        Me.ScaledLabel.Text = "Scaled"
        '
        'WaterPressureScaledValueBasicLabel
        '
        Me.WaterPressureScaledValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.WaterPressureScaledValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.WaterPressureScaledValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WaterPressureScaledValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.WaterPressureScaledValueBasicLabel.DisplayAsTime = False
        Me.WaterPressureScaledValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPressureScaledValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WaterPressureScaledValueBasicLabel.Highlight = False
        Me.WaterPressureScaledValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.WaterPressureScaledValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.WaterPressureScaledValueBasicLabel.HighlightKeyCharacter = "!"
        Me.WaterPressureScaledValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WaterPressureScaledValueBasicLabel.KeypadAlphaNumeric = False
        Me.WaterPressureScaledValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPressureScaledValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.WaterPressureScaledValueBasicLabel.KeypadMaxValue = 0.0R
        Me.WaterPressureScaledValueBasicLabel.KeypadMinValue = 0.0R
        Me.WaterPressureScaledValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.WaterPressureScaledValueBasicLabel.KeypadShowCurrentValue = False
        Me.WaterPressureScaledValueBasicLabel.KeypadText = Nothing
        Me.WaterPressureScaledValueBasicLabel.KeypadWidth = 400
        Me.WaterPressureScaledValueBasicLabel.Location = New System.Drawing.Point(445, 179)
        Me.WaterPressureScaledValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.WaterPressureScaledValueBasicLabel.Name = "WaterPressureScaledValueBasicLabel"
        Me.WaterPressureScaledValueBasicLabel.NumericFormat = "0.0"
        Me.WaterPressureScaledValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.WaterPressureScaledValueBasicLabel.PLCAddressKeypad = ""
        Me.WaterPressureScaledValueBasicLabel.PLCAddressValue = "TestSt_Pressure.Scaled"
        Me.WaterPressureScaledValueBasicLabel.PollRate = 0
        Me.WaterPressureScaledValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.WaterPressureScaledValueBasicLabel.TabIndex = 367
        Me.WaterPressureScaledValueBasicLabel.Text = "9.9"
        Me.WaterPressureScaledValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WaterPressureScaledValueBasicLabel.UseMnemonic = False
        Me.WaterPressureScaledValueBasicLabel.Value = "9.9"
        Me.WaterPressureScaledValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WaterPressureScaledValueBasicLabel.ValueLeftPadLength = 0
        Me.WaterPressureScaledValueBasicLabel.ValuePrefix = Nothing
        Me.WaterPressureScaledValueBasicLabel.ValueScaleFactor = 1.0R
        Me.WaterPressureScaledValueBasicLabel.ValueSuffix = Nothing
        '
        'Barg1Label
        '
        Me.Barg1Label.AutoSize = True
        Me.Barg1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barg1Label.Location = New System.Drawing.Point(555, 184)
        Me.Barg1Label.Name = "Barg1Label"
        Me.Barg1Label.Size = New System.Drawing.Size(31, 15)
        Me.Barg1Label.TabIndex = 369
        Me.Barg1Label.Text = "barg"
        '
        'Barg2Label
        '
        Me.Barg2Label.AutoSize = True
        Me.Barg2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barg2Label.Location = New System.Drawing.Point(556, 219)
        Me.Barg2Label.Name = "Barg2Label"
        Me.Barg2Label.Size = New System.Drawing.Size(31, 15)
        Me.Barg2Label.TabIndex = 373
        Me.Barg2Label.Text = "barg"
        '
        'TestPressureScaledValueBasicLabel
        '
        Me.TestPressureScaledValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.TestPressureScaledValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.TestPressureScaledValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TestPressureScaledValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.TestPressureScaledValueBasicLabel.DisplayAsTime = False
        Me.TestPressureScaledValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestPressureScaledValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TestPressureScaledValueBasicLabel.Highlight = False
        Me.TestPressureScaledValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.TestPressureScaledValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.TestPressureScaledValueBasicLabel.HighlightKeyCharacter = "!"
        Me.TestPressureScaledValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TestPressureScaledValueBasicLabel.KeypadAlphaNumeric = False
        Me.TestPressureScaledValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestPressureScaledValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.TestPressureScaledValueBasicLabel.KeypadMaxValue = 0.0R
        Me.TestPressureScaledValueBasicLabel.KeypadMinValue = 0.0R
        Me.TestPressureScaledValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.TestPressureScaledValueBasicLabel.KeypadShowCurrentValue = False
        Me.TestPressureScaledValueBasicLabel.KeypadText = Nothing
        Me.TestPressureScaledValueBasicLabel.KeypadWidth = 400
        Me.TestPressureScaledValueBasicLabel.Location = New System.Drawing.Point(446, 214)
        Me.TestPressureScaledValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.TestPressureScaledValueBasicLabel.Name = "TestPressureScaledValueBasicLabel"
        Me.TestPressureScaledValueBasicLabel.NumericFormat = "0.0"
        Me.TestPressureScaledValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TestPressureScaledValueBasicLabel.PLCAddressKeypad = ""
        Me.TestPressureScaledValueBasicLabel.PLCAddressValue = "TestSt_AirPressure.Scaled"
        Me.TestPressureScaledValueBasicLabel.PollRate = 0
        Me.TestPressureScaledValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.TestPressureScaledValueBasicLabel.TabIndex = 372
        Me.TestPressureScaledValueBasicLabel.Text = "9.9"
        Me.TestPressureScaledValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TestPressureScaledValueBasicLabel.UseMnemonic = False
        Me.TestPressureScaledValueBasicLabel.Value = "9.9"
        Me.TestPressureScaledValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TestPressureScaledValueBasicLabel.ValueLeftPadLength = 0
        Me.TestPressureScaledValueBasicLabel.ValuePrefix = Nothing
        Me.TestPressureScaledValueBasicLabel.ValueScaleFactor = 1.0R
        Me.TestPressureScaledValueBasicLabel.ValueSuffix = Nothing
        '
        'TestPressureRawValueBasicLabel
        '
        Me.TestPressureRawValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.TestPressureRawValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.TestPressureRawValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TestPressureRawValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.TestPressureRawValueBasicLabel.DisplayAsTime = False
        Me.TestPressureRawValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestPressureRawValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TestPressureRawValueBasicLabel.Highlight = False
        Me.TestPressureRawValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.TestPressureRawValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.TestPressureRawValueBasicLabel.HighlightKeyCharacter = "!"
        Me.TestPressureRawValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TestPressureRawValueBasicLabel.KeypadAlphaNumeric = False
        Me.TestPressureRawValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestPressureRawValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.TestPressureRawValueBasicLabel.KeypadMaxValue = 0.0R
        Me.TestPressureRawValueBasicLabel.KeypadMinValue = 0.0R
        Me.TestPressureRawValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.TestPressureRawValueBasicLabel.KeypadShowCurrentValue = False
        Me.TestPressureRawValueBasicLabel.KeypadText = Nothing
        Me.TestPressureRawValueBasicLabel.KeypadWidth = 400
        Me.TestPressureRawValueBasicLabel.Location = New System.Drawing.Point(324, 213)
        Me.TestPressureRawValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.TestPressureRawValueBasicLabel.Name = "TestPressureRawValueBasicLabel"
        Me.TestPressureRawValueBasicLabel.NumericFormat = "0.0"
        Me.TestPressureRawValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TestPressureRawValueBasicLabel.PLCAddressKeypad = ""
        Me.TestPressureRawValueBasicLabel.PLCAddressValue = "TestSt_AirPressure.Raw"
        Me.TestPressureRawValueBasicLabel.PollRate = 0
        Me.TestPressureRawValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.TestPressureRawValueBasicLabel.TabIndex = 371
        Me.TestPressureRawValueBasicLabel.Text = "9.9"
        Me.TestPressureRawValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TestPressureRawValueBasicLabel.UseMnemonic = False
        Me.TestPressureRawValueBasicLabel.Value = "9.9"
        Me.TestPressureRawValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TestPressureRawValueBasicLabel.ValueLeftPadLength = 0
        Me.TestPressureRawValueBasicLabel.ValuePrefix = Nothing
        Me.TestPressureRawValueBasicLabel.ValueScaleFactor = 1.0R
        Me.TestPressureRawValueBasicLabel.ValueSuffix = Nothing
        '
        'TestPressureLabel
        '
        Me.TestPressureLabel.BackColor = System.Drawing.Color.Gray
        Me.TestPressureLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestPressureLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TestPressureLabel.Location = New System.Drawing.Point(47, 222)
        Me.TestPressureLabel.Name = "TestPressureLabel"
        Me.TestPressureLabel.Size = New System.Drawing.Size(258, 19)
        Me.TestPressureLabel.TabIndex = 370
        Me.TestPressureLabel.Text = "I:2:1 Test pressure"
        Me.TestPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnalogOutputsBasicLabel
        '
        Me.AnalogOutputsBasicLabel.AutoSize = True
        Me.AnalogOutputsBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.AnalogOutputsBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.AnalogOutputsBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogOutputsBasicLabel.DisplayAsTime = False
        Me.AnalogOutputsBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogOutputsBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogOutputsBasicLabel.Highlight = False
        Me.AnalogOutputsBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.AnalogOutputsBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.AnalogOutputsBasicLabel.HighlightKeyCharacter = "!"
        Me.AnalogOutputsBasicLabel.KeypadAlphaNumeric = False
        Me.AnalogOutputsBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.AnalogOutputsBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogOutputsBasicLabel.KeypadMaxValue = 0.0R
        Me.AnalogOutputsBasicLabel.KeypadMinValue = 0.0R
        Me.AnalogOutputsBasicLabel.KeypadScaleFactor = 1.0R
        Me.AnalogOutputsBasicLabel.KeypadShowCurrentValue = False
        Me.AnalogOutputsBasicLabel.KeypadText = Nothing
        Me.AnalogOutputsBasicLabel.KeypadWidth = 300
        Me.AnalogOutputsBasicLabel.Location = New System.Drawing.Point(12, 319)
        Me.AnalogOutputsBasicLabel.Name = "AnalogOutputsBasicLabel"
        Me.AnalogOutputsBasicLabel.NumericFormat = Nothing
        Me.AnalogOutputsBasicLabel.PLCAddressKeypad = ""
        Me.AnalogOutputsBasicLabel.PollRate = 0
        Me.AnalogOutputsBasicLabel.Size = New System.Drawing.Size(123, 21)
        Me.AnalogOutputsBasicLabel.TabIndex = 374
        Me.AnalogOutputsBasicLabel.Text = "Analog outputs"
        Me.AnalogOutputsBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AnalogOutputsBasicLabel.Value = "Analog outputs"
        Me.AnalogOutputsBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnalogOutputsBasicLabel.ValueLeftPadLength = 0
        Me.AnalogOutputsBasicLabel.ValuePrefix = Nothing
        Me.AnalogOutputsBasicLabel.ValueScaleFactor = 1.0R
        Me.AnalogOutputsBasicLabel.ValueSuffix = Nothing
        '
        'SpareO30Label
        '
        Me.SpareO30Label.BackColor = System.Drawing.Color.Gray
        Me.SpareO30Label.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpareO30Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpareO30Label.Location = New System.Drawing.Point(20, 398)
        Me.SpareO30Label.Name = "SpareO30Label"
        Me.SpareO30Label.Size = New System.Drawing.Size(297, 19)
        Me.SpareO30Label.TabIndex = 376
        Me.SpareO30Label.Text = "O:3:0 Spare"
        Me.SpareO30Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProportionalPressureRegulatorLabel
        '
        Me.ProportionalPressureRegulatorLabel.BackColor = System.Drawing.Color.Gray
        Me.ProportionalPressureRegulatorLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProportionalPressureRegulatorLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProportionalPressureRegulatorLabel.Location = New System.Drawing.Point(16, 360)
        Me.ProportionalPressureRegulatorLabel.Name = "ProportionalPressureRegulatorLabel"
        Me.ProportionalPressureRegulatorLabel.Size = New System.Drawing.Size(301, 19)
        Me.ProportionalPressureRegulatorLabel.TabIndex = 375
        Me.ProportionalPressureRegulatorLabel.Text = "O:3:0 Proportional pressure regulator"
        Me.ProportionalPressureRegulatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpareO30RawValueBasicLabel
        '
        Me.SpareO30RawValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.SpareO30RawValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.SpareO30RawValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpareO30RawValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.SpareO30RawValueBasicLabel.DisplayAsTime = False
        Me.SpareO30RawValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpareO30RawValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpareO30RawValueBasicLabel.Highlight = False
        Me.SpareO30RawValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.SpareO30RawValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.SpareO30RawValueBasicLabel.HighlightKeyCharacter = "!"
        Me.SpareO30RawValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SpareO30RawValueBasicLabel.KeypadAlphaNumeric = False
        Me.SpareO30RawValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpareO30RawValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SpareO30RawValueBasicLabel.KeypadMaxValue = 0.0R
        Me.SpareO30RawValueBasicLabel.KeypadMinValue = 0.0R
        Me.SpareO30RawValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.SpareO30RawValueBasicLabel.KeypadShowCurrentValue = False
        Me.SpareO30RawValueBasicLabel.KeypadText = Nothing
        Me.SpareO30RawValueBasicLabel.KeypadWidth = 400
        Me.SpareO30RawValueBasicLabel.Location = New System.Drawing.Point(324, 390)
        Me.SpareO30RawValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.SpareO30RawValueBasicLabel.Name = "SpareO30RawValueBasicLabel"
        Me.SpareO30RawValueBasicLabel.NumericFormat = "0.0"
        Me.SpareO30RawValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.SpareO30RawValueBasicLabel.PLCAddressKeypad = ""
        Me.SpareO30RawValueBasicLabel.PLCAddressValue = "Local:3:O.Ch1Data"
        Me.SpareO30RawValueBasicLabel.PollRate = 0
        Me.SpareO30RawValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.SpareO30RawValueBasicLabel.TabIndex = 379
        Me.SpareO30RawValueBasicLabel.Text = "9.9"
        Me.SpareO30RawValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SpareO30RawValueBasicLabel.UseMnemonic = False
        Me.SpareO30RawValueBasicLabel.Value = "9.9"
        Me.SpareO30RawValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SpareO30RawValueBasicLabel.ValueLeftPadLength = 0
        Me.SpareO30RawValueBasicLabel.ValuePrefix = Nothing
        Me.SpareO30RawValueBasicLabel.ValueScaleFactor = 1.0R
        Me.SpareO30RawValueBasicLabel.ValueSuffix = Nothing
        '
        'ProportionalPressureRegulatorRawValueBasicLabel
        '
        Me.ProportionalPressureRegulatorRawValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.ProportionalPressureRegulatorRawValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ProportionalPressureRegulatorRawValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ProportionalPressureRegulatorRawValueBasicLabel.DisplayAsTime = False
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Highlight = False
        Me.ProportionalPressureRegulatorRawValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ProportionalPressureRegulatorRawValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ProportionalPressureRegulatorRawValueBasicLabel.HighlightKeyCharacter = "!"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadAlphaNumeric = False
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadMaxValue = 0.0R
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadMinValue = 0.0R
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadShowCurrentValue = False
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadText = Nothing
        Me.ProportionalPressureRegulatorRawValueBasicLabel.KeypadWidth = 400
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Location = New System.Drawing.Point(323, 355)
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Name = "ProportionalPressureRegulatorRawValueBasicLabel"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.NumericFormat = "0.0"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ProportionalPressureRegulatorRawValueBasicLabel.PLCAddressKeypad = ""
        Me.ProportionalPressureRegulatorRawValueBasicLabel.PLCAddressValue = "pidPressureControl.out"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.PollRate = 0
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Size = New System.Drawing.Size(104, 27)
        Me.ProportionalPressureRegulatorRawValueBasicLabel.TabIndex = 378
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Text = "9.9"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProportionalPressureRegulatorRawValueBasicLabel.UseMnemonic = False
        Me.ProportionalPressureRegulatorRawValueBasicLabel.Value = "9.9"
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ValueLeftPadLength = 0
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ValuePrefix = Nothing
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ValueScaleFactor = 1.0R
        Me.ProportionalPressureRegulatorRawValueBasicLabel.ValueSuffix = Nothing
        '
        'Percentage2Label
        '
        Me.Percentage2Label.AutoSize = True
        Me.Percentage2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage2Label.Location = New System.Drawing.Point(437, 395)
        Me.Percentage2Label.Name = "Percentage2Label"
        Me.Percentage2Label.Size = New System.Drawing.Size(17, 15)
        Me.Percentage2Label.TabIndex = 381
        Me.Percentage2Label.Text = "%"
        '
        'Percentage1Label
        '
        Me.Percentage1Label.AutoSize = True
        Me.Percentage1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage1Label.Location = New System.Drawing.Point(436, 360)
        Me.Percentage1Label.Name = "Percentage1Label"
        Me.Percentage1Label.Size = New System.Drawing.Size(17, 15)
        Me.Percentage1Label.TabIndex = 380
        Me.Percentage1Label.Text = "%"
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
        Me.CurrentDateTime.Text = "30-11-2016 14:51:56"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.Transparent
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bellRed
        Me.AlmInd.Location = New System.Drawing.Point(65, 56)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(34, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 387
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'DigitalInputs1Button
        '
        Me.DigitalInputs1Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.DigitalInputs1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalInputs1Button.ForeColor = System.Drawing.Color.Black
        Me.DigitalInputs1Button.Image = CType(resources.GetObject("DigitalInputs1Button.Image"), System.Drawing.Image)
        Me.DigitalInputs1Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DigitalInputs1Button.Location = New System.Drawing.Point(444, 471)
        Me.DigitalInputs1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalInputs1Button.Name = "DigitalInputs1Button"
        Me.DigitalInputs1Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalInputs1Button.TabIndex = 386
        Me.DigitalInputs1Button.Text = "Digital Inputs 1"
        Me.DigitalInputs1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalInputs1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalInputs1Button.UseVisualStyleBackColor = True
        '
        'DigitalInputs2Button
        '
        Me.DigitalInputs2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalInputs2Button.ForeColor = System.Drawing.Color.Black
        Me.DigitalInputs2Button.Image = CType(resources.GetObject("DigitalInputs2Button.Image"), System.Drawing.Image)
        Me.DigitalInputs2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DigitalInputs2Button.Location = New System.Drawing.Point(444, 522)
        Me.DigitalInputs2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalInputs2Button.Name = "DigitalInputs2Button"
        Me.DigitalInputs2Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalInputs2Button.TabIndex = 385
        Me.DigitalInputs2Button.Text = "Digital Inputs 2"
        Me.DigitalInputs2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalInputs2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalInputs2Button.UseVisualStyleBackColor = True
        '
        'AnalogsButton
        '
        Me.AnalogsButton.Enabled = False
        Me.AnalogsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogsButton.ForeColor = System.Drawing.Color.Black
        Me.AnalogsButton.Image = CType(resources.GetObject("AnalogsButton.Image"), System.Drawing.Image)
        Me.AnalogsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AnalogsButton.Location = New System.Drawing.Point(444, 573)
        Me.AnalogsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AnalogsButton.Name = "AnalogsButton"
        Me.AnalogsButton.Size = New System.Drawing.Size(150, 44)
        Me.AnalogsButton.TabIndex = 384
        Me.AnalogsButton.Text = "Analogs"
        Me.AnalogsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AnalogsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AnalogsButton.UseVisualStyleBackColor = True
        '
        'DigitalOutputs1Button
        '
        Me.DigitalOutputs1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalOutputs1Button.ForeColor = System.Drawing.Color.Black
        Me.DigitalOutputs1Button.Image = CType(resources.GetObject("DigitalOutputs1Button.Image"), System.Drawing.Image)
        Me.DigitalOutputs1Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DigitalOutputs1Button.Location = New System.Drawing.Point(444, 624)
        Me.DigitalOutputs1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalOutputs1Button.Name = "DigitalOutputs1Button"
        Me.DigitalOutputs1Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalOutputs1Button.TabIndex = 383
        Me.DigitalOutputs1Button.Text = "Digital Outputs 1"
        Me.DigitalOutputs1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalOutputs1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalOutputs1Button.UseVisualStyleBackColor = True
        '
        'DigitalOutputs2Button
        '
        Me.DigitalOutputs2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalOutputs2Button.ForeColor = System.Drawing.Color.Black
        Me.DigitalOutputs2Button.Image = CType(resources.GetObject("DigitalOutputs2Button.Image"), System.Drawing.Image)
        Me.DigitalOutputs2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DigitalOutputs2Button.Location = New System.Drawing.Point(444, 675)
        Me.DigitalOutputs2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalOutputs2Button.Name = "DigitalOutputs2Button"
        Me.DigitalOutputs2Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalOutputs2Button.TabIndex = 382
        Me.DigitalOutputs2Button.Text = "Digital Outputs 2"
        Me.DigitalOutputs2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalOutputs2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalOutputs2Button.UseVisualStyleBackColor = True
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
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 361
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'AnalogIOPictureBox
        '
        Me.AnalogIOPictureBox.BackColor = System.Drawing.Color.White
        Me.AnalogIOPictureBox.Image = CType(resources.GetObject("AnalogIOPictureBox.Image"), System.Drawing.Image)
        Me.AnalogIOPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.AnalogIOPictureBox.Name = "AnalogIOPictureBox"
        Me.AnalogIOPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.AnalogIOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AnalogIOPictureBox.TabIndex = 272
        Me.AnalogIOPictureBox.TabStop = False
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
        Me.AccessLevelLabel.TabIndex = 409
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_io_3
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.DigitalInputs1Button)
        Me.Controls.Add(Me.DigitalInputs2Button)
        Me.Controls.Add(Me.AnalogsButton)
        Me.Controls.Add(Me.DigitalOutputs1Button)
        Me.Controls.Add(Me.DigitalOutputs2Button)
        Me.Controls.Add(Me.Percentage2Label)
        Me.Controls.Add(Me.Percentage1Label)
        Me.Controls.Add(Me.SpareO30RawValueBasicLabel)
        Me.Controls.Add(Me.ProportionalPressureRegulatorRawValueBasicLabel)
        Me.Controls.Add(Me.SpareO30Label)
        Me.Controls.Add(Me.ProportionalPressureRegulatorLabel)
        Me.Controls.Add(Me.AnalogOutputsBasicLabel)
        Me.Controls.Add(Me.Barg2Label)
        Me.Controls.Add(Me.TestPressureScaledValueBasicLabel)
        Me.Controls.Add(Me.TestPressureRawValueBasicLabel)
        Me.Controls.Add(Me.TestPressureLabel)
        Me.Controls.Add(Me.Barg1Label)
        Me.Controls.Add(Me.ScaledLabel)
        Me.Controls.Add(Me.WaterPressureScaledValueBasicLabel)
        Me.Controls.Add(Me.RawLabel)
        Me.Controls.Add(Me.WaterPressureRawValueBasicLabel)
        Me.Controls.Add(Me.WaterPressureTransducerLabel)
        Me.Controls.Add(Me.AnalogInputsBasicLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.AnalogIOPictureBox)
        Me.Controls.Add(Me.AnalogIOLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_io_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.IO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalogIOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AnalogIOPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents AnalogIOLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents WaterPressureRawValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents WaterPressureTransducerLabel As System.Windows.Forms.Label
    Friend WithEvents AnalogInputsBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ScaledLabel As System.Windows.Forms.Label
    Friend WithEvents WaterPressureScaledValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents RawLabel As System.Windows.Forms.Label
    Friend WithEvents SpareO30Label As System.Windows.Forms.Label
    Friend WithEvents ProportionalPressureRegulatorLabel As System.Windows.Forms.Label
    Friend WithEvents AnalogOutputsBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents Barg2Label As System.Windows.Forms.Label
    Friend WithEvents TestPressureScaledValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents TestPressureRawValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents TestPressureLabel As System.Windows.Forms.Label
    Friend WithEvents Barg1Label As System.Windows.Forms.Label
    Friend WithEvents Percentage2Label As System.Windows.Forms.Label
    Friend WithEvents Percentage1Label As System.Windows.Forms.Label
    Friend WithEvents SpareO30RawValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ProportionalPressureRegulatorRawValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents DigitalInputs1Button As System.Windows.Forms.Button
    Friend WithEvents DigitalInputs2Button As System.Windows.Forms.Button
    Friend WithEvents AnalogsButton As System.Windows.Forms.Button
    Friend WithEvents DigitalOutputs1Button As System.Windows.Forms.Button
    Friend WithEvents DigitalOutputs2Button As System.Windows.Forms.Button
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
