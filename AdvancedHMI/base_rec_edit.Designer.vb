<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_rec_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_rec_edit))
        Me.ProfileEditLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.PressureSetPointLabel = New System.Windows.Forms.Label()
        Me.PressureUnitsLabel = New System.Windows.Forms.Label()
        Me.RampRateLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ActualOneMinuteEquivalentLabel = New System.Windows.Forms.Label()
        Me.LowBurstValueLabel = New System.Windows.Forms.Label()
        Me.DwellTimeUnitLabel = New System.Windows.Forms.Label()
        Me.DwellTimeLabel = New System.Windows.Forms.Label()
        Me.Phase1Label = New System.Windows.Forms.Label()
        Me.Phase2Label = New System.Windows.Forms.Label()
        Me.LowBurstValueUnitKgSqCmBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.RampRateUnitKgSqCmPerSecBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PressureSetPointUnitKgSqCmBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.RampRateUnitPsiPerSecBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.RampRateUnitBarPerSecBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PressureSetPointUnitPsiBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PressureSetPointUnitBargBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.NeckGripUnitsLabel = New System.Windows.Forms.Label()
        Me.NeckGripSizeLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VolumeLabel = New AdvancedHMIControls.BasicLabel()
        Me.FinishHeightLabel = New AdvancedHMIControls.BasicLabel()
        Me.LabelHeightLabel = New AdvancedHMIControls.BasicLabel()
        Me.BottleHeightLabel = New AdvancedHMIControls.BasicLabel()
        Me.BottleHeightTextBox = New System.Windows.Forms.TextBox()
        Me.BottleLabelHeightTextBox = New System.Windows.Forms.TextBox()
        Me.BottleFinishHeightTextBox = New System.Windows.Forms.TextBox()
        Me.BottleVolumeTextBox = New System.Windows.Forms.TextBox()
        Me.LowBurstTextBox = New System.Windows.Forms.TextBox()
        Me.NeckGripTextBox = New System.Windows.Forms.TextBox()
        Me.PressureSetpoint1TextBox = New System.Windows.Forms.TextBox()
        Me.RampRate1TextBox = New System.Windows.Forms.TextBox()
        Me.DwellTime1TextBox = New System.Windows.Forms.TextBox()
        Me.DwellTime2TextBox = New System.Windows.Forms.TextBox()
        Me.RampRate2TextBox = New System.Windows.Forms.TextBox()
        Me.PressureSetpoint2TextBox = New System.Windows.Forms.TextBox()
        Me.P60RadioButton = New System.Windows.Forms.RadioButton()
        Me.PrRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PlaceHeightAdjustmentLabel = New AdvancedHMIControls.BasicLabel()
        Me.PlaceHeightAdjustmentTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileNameTextBox = New System.Windows.Forms.TextBox()
        Me.PressureUnitBarRadioButton = New System.Windows.Forms.RadioButton()
        Me.PressureUnitPsiRadioButton = New System.Windows.Forms.RadioButton()
        Me.PressureUnitKgcm2RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteProfileButton = New System.Windows.Forms.Button()
        Me.NewRecipeButton = New System.Windows.Forms.Button()
        Me.CopyProfileButton = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PgOpenHomeButton = New AdvancedHMIControls.BasicButton()
        Me.RecSaveBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ProfileEditPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LineNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LineNumberLabel = New AdvancedHMIControls.BasicLabel()
        Me.DataEntryErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileEditPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataEntryErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileEditLabel
        '
        Me.ProfileEditLabel.BackColor = System.Drawing.Color.White
        Me.ProfileEditLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileEditLabel.ForeColor = System.Drawing.Color.DimGray
        Me.ProfileEditLabel.Location = New System.Drawing.Point(196, 47)
        Me.ProfileEditLabel.Name = "ProfileEditLabel"
        Me.ProfileEditLabel.Size = New System.Drawing.Size(219, 40)
        Me.ProfileEditLabel.TabIndex = 271
        Me.ProfileEditLabel.Text = "Profile Edit"
        Me.ProfileEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'PressureSetPointLabel
        '
        Me.PressureSetPointLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointLabel.Location = New System.Drawing.Point(235, 612)
        Me.PressureSetPointLabel.Name = "PressureSetPointLabel"
        Me.PressureSetPointLabel.Size = New System.Drawing.Size(185, 20)
        Me.PressureSetPointLabel.TabIndex = 307
        Me.PressureSetPointLabel.Text = "Pressure setpoint"
        Me.PressureSetPointLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PressureUnitsLabel
        '
        Me.PressureUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitsLabel.Location = New System.Drawing.Point(235, 483)
        Me.PressureUnitsLabel.Name = "PressureUnitsLabel"
        Me.PressureUnitsLabel.Size = New System.Drawing.Size(142, 20)
        Me.PressureUnitsLabel.TabIndex = 308
        Me.PressureUnitsLabel.Text = "Pressure units"
        Me.PressureUnitsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RampRateLabel
        '
        Me.RampRateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRateLabel.Location = New System.Drawing.Point(235, 649)
        Me.RampRateLabel.Name = "RampRateLabel"
        Me.RampRateLabel.Size = New System.Drawing.Size(185, 20)
        Me.RampRateLabel.TabIndex = 316
        Me.RampRateLabel.Text = "Ramp rate"
        Me.RampRateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(494, 749)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 19)
        Me.Label9.TabIndex = 315
        '
        'ActualOneMinuteEquivalentLabel
        '
        Me.ActualOneMinuteEquivalentLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualOneMinuteEquivalentLabel.Location = New System.Drawing.Point(235, 532)
        Me.ActualOneMinuteEquivalentLabel.Name = "ActualOneMinuteEquivalentLabel"
        Me.ActualOneMinuteEquivalentLabel.Size = New System.Drawing.Size(142, 20)
        Me.ActualOneMinuteEquivalentLabel.TabIndex = 317
        Me.ActualOneMinuteEquivalentLabel.Text = "Use P60 or Pr"
        Me.ActualOneMinuteEquivalentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LowBurstValueLabel
        '
        Me.LowBurstValueLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowBurstValueLabel.Location = New System.Drawing.Point(240, 316)
        Me.LowBurstValueLabel.Name = "LowBurstValueLabel"
        Me.LowBurstValueLabel.Size = New System.Drawing.Size(264, 20)
        Me.LowBurstValueLabel.TabIndex = 335
        Me.LowBurstValueLabel.Text = "Low burst value"
        Me.LowBurstValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DwellTimeUnitLabel
        '
        Me.DwellTimeUnitLabel.AutoSize = True
        Me.DwellTimeUnitLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DwellTimeUnitLabel.Location = New System.Drawing.Point(407, 700)
        Me.DwellTimeUnitLabel.Name = "DwellTimeUnitLabel"
        Me.DwellTimeUnitLabel.Size = New System.Drawing.Size(15, 19)
        Me.DwellTimeUnitLabel.TabIndex = 332
        Me.DwellTimeUnitLabel.Text = "s"
        '
        'DwellTimeLabel
        '
        Me.DwellTimeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DwellTimeLabel.Location = New System.Drawing.Point(235, 685)
        Me.DwellTimeLabel.Name = "DwellTimeLabel"
        Me.DwellTimeLabel.Size = New System.Drawing.Size(185, 20)
        Me.DwellTimeLabel.TabIndex = 333
        Me.DwellTimeLabel.Text = "Dwell time"
        Me.DwellTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Phase1Label
        '
        Me.Phase1Label.AutoSize = True
        Me.Phase1Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase1Label.Location = New System.Drawing.Point(443, 587)
        Me.Phase1Label.Name = "Phase1Label"
        Me.Phase1Label.Size = New System.Drawing.Size(70, 20)
        Me.Phase1Label.TabIndex = 352
        Me.Phase1Label.Text = "Phase #1"
        '
        'Phase2Label
        '
        Me.Phase2Label.AutoSize = True
        Me.Phase2Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase2Label.Location = New System.Drawing.Point(522, 587)
        Me.Phase2Label.Name = "Phase2Label"
        Me.Phase2Label.Size = New System.Drawing.Size(70, 20)
        Me.Phase2Label.TabIndex = 353
        Me.Phase2Label.Text = "Phase #2"
        '
        'LowBurstValueUnitKgSqCmBasicLabel
        '
        Me.LowBurstValueUnitKgSqCmBasicLabel.AutoSize = True
        Me.LowBurstValueUnitKgSqCmBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.LowBurstValueUnitKgSqCmBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LowBurstValueUnitKgSqCmBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.LowBurstValueUnitKgSqCmBasicLabel.DisplayAsTime = False
        Me.LowBurstValueUnitKgSqCmBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowBurstValueUnitKgSqCmBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueUnitKgSqCmBasicLabel.Highlight = False
        Me.LowBurstValueUnitKgSqCmBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.LowBurstValueUnitKgSqCmBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.LowBurstValueUnitKgSqCmBasicLabel.HighlightKeyCharacter = "!"
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadAlphaNumeric = False
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadMaxValue = 0.0R
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadMinValue = 0.0R
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadScaleFactor = 1.0R
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadShowCurrentValue = False
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadText = Nothing
        Me.LowBurstValueUnitKgSqCmBasicLabel.KeypadWidth = 300
        Me.LowBurstValueUnitKgSqCmBasicLabel.Location = New System.Drawing.Point(448, 336)
        Me.LowBurstValueUnitKgSqCmBasicLabel.Name = "LowBurstValueUnitKgSqCmBasicLabel"
        Me.LowBurstValueUnitKgSqCmBasicLabel.NumericFormat = Nothing
        Me.LowBurstValueUnitKgSqCmBasicLabel.PLCAddressHighlight = "prof_edit_KgCM2_True"
        Me.LowBurstValueUnitKgSqCmBasicLabel.PLCAddressKeypad = ""
        Me.LowBurstValueUnitKgSqCmBasicLabel.PLCAddressVisible = "prof_edit_KgCM2_True"
        Me.LowBurstValueUnitKgSqCmBasicLabel.PollRate = 0
        Me.LowBurstValueUnitKgSqCmBasicLabel.Size = New System.Drawing.Size(56, 19)
        Me.LowBurstValueUnitKgSqCmBasicLabel.TabIndex = 348
        Me.LowBurstValueUnitKgSqCmBasicLabel.Text = "Kg/cm2"
        Me.LowBurstValueUnitKgSqCmBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LowBurstValueUnitKgSqCmBasicLabel.Value = "Kg/cm2"
        Me.LowBurstValueUnitKgSqCmBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LowBurstValueUnitKgSqCmBasicLabel.ValueLeftPadLength = 0
        Me.LowBurstValueUnitKgSqCmBasicLabel.ValuePrefix = Nothing
        Me.LowBurstValueUnitKgSqCmBasicLabel.ValueScaleFactor = 1.0R
        Me.LowBurstValueUnitKgSqCmBasicLabel.ValueSuffix = Nothing
        '
        'RampRateUnitKgSqCmPerSecBasicLabel
        '
        Me.RampRateUnitKgSqCmPerSecBasicLabel.AutoSize = True
        Me.RampRateUnitKgSqCmPerSecBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.RampRateUnitKgSqCmPerSecBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RampRateUnitKgSqCmPerSecBasicLabel.DisplayAsTime = False
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Highlight = False
        Me.RampRateUnitKgSqCmPerSecBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.RampRateUnitKgSqCmPerSecBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RampRateUnitKgSqCmPerSecBasicLabel.HighlightKeyCharacter = "!"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadAlphaNumeric = False
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadMaxValue = 0.0R
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadMinValue = 0.0R
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadScaleFactor = 1.0R
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadShowCurrentValue = False
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadText = Nothing
        Me.RampRateUnitKgSqCmPerSecBasicLabel.KeypadWidth = 300
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Location = New System.Drawing.Point(355, 666)
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Name = "RampRateUnitKgSqCmPerSecBasicLabel"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.NumericFormat = Nothing
        Me.RampRateUnitKgSqCmPerSecBasicLabel.PLCAddressHighlight = "prof_edit_KgCM2_True"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.PLCAddressKeypad = ""
        Me.RampRateUnitKgSqCmPerSecBasicLabel.PLCAddressVisible = "prof_edit_KgCM2_True"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.PollRate = 0
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Size = New System.Drawing.Size(67, 19)
        Me.RampRateUnitKgSqCmPerSecBasicLabel.TabIndex = 346
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Text = "Kg/cm2/s"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.Value = "Kg/cm2/s"
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ValueLeftPadLength = 0
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ValuePrefix = Nothing
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ValueScaleFactor = 1.0R
        Me.RampRateUnitKgSqCmPerSecBasicLabel.ValueSuffix = Nothing
        '
        'PressureSetPointUnitKgSqCmBasicLabel
        '
        Me.PressureSetPointUnitKgSqCmBasicLabel.AutoSize = True
        Me.PressureSetPointUnitKgSqCmBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitKgSqCmBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureSetPointUnitKgSqCmBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureSetPointUnitKgSqCmBasicLabel.DisplayAsTime = False
        Me.PressureSetPointUnitKgSqCmBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointUnitKgSqCmBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitKgSqCmBasicLabel.Highlight = False
        Me.PressureSetPointUnitKgSqCmBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitKgSqCmBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureSetPointUnitKgSqCmBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadAlphaNumeric = False
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadMinValue = 0.0R
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadShowCurrentValue = False
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadText = Nothing
        Me.PressureSetPointUnitKgSqCmBasicLabel.KeypadWidth = 300
        Me.PressureSetPointUnitKgSqCmBasicLabel.Location = New System.Drawing.Point(366, 630)
        Me.PressureSetPointUnitKgSqCmBasicLabel.Name = "PressureSetPointUnitKgSqCmBasicLabel"
        Me.PressureSetPointUnitKgSqCmBasicLabel.NumericFormat = Nothing
        Me.PressureSetPointUnitKgSqCmBasicLabel.PLCAddressHighlight = "prof_edit_KgCM2_True"
        Me.PressureSetPointUnitKgSqCmBasicLabel.PLCAddressKeypad = ""
        Me.PressureSetPointUnitKgSqCmBasicLabel.PLCAddressVisible = "prof_edit_KgCM2_True"
        Me.PressureSetPointUnitKgSqCmBasicLabel.PollRate = 0
        Me.PressureSetPointUnitKgSqCmBasicLabel.Size = New System.Drawing.Size(56, 19)
        Me.PressureSetPointUnitKgSqCmBasicLabel.TabIndex = 345
        Me.PressureSetPointUnitKgSqCmBasicLabel.Text = "Kg/cm2"
        Me.PressureSetPointUnitKgSqCmBasicLabel.Value = "Kg/cm2"
        Me.PressureSetPointUnitKgSqCmBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureSetPointUnitKgSqCmBasicLabel.ValueLeftPadLength = 0
        Me.PressureSetPointUnitKgSqCmBasicLabel.ValuePrefix = Nothing
        Me.PressureSetPointUnitKgSqCmBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureSetPointUnitKgSqCmBasicLabel.ValueSuffix = Nothing
        '
        'RampRateUnitPsiPerSecBasicLabel
        '
        Me.RampRateUnitPsiPerSecBasicLabel.AutoSize = True
        Me.RampRateUnitPsiPerSecBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.RampRateUnitPsiPerSecBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RampRateUnitPsiPerSecBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RampRateUnitPsiPerSecBasicLabel.DisplayAsTime = False
        Me.RampRateUnitPsiPerSecBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRateUnitPsiPerSecBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitPsiPerSecBasicLabel.Highlight = False
        Me.RampRateUnitPsiPerSecBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.RampRateUnitPsiPerSecBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RampRateUnitPsiPerSecBasicLabel.HighlightKeyCharacter = "!"
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadAlphaNumeric = False
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadMaxValue = 0.0R
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadMinValue = 0.0R
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadScaleFactor = 1.0R
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadShowCurrentValue = False
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadText = Nothing
        Me.RampRateUnitPsiPerSecBasicLabel.KeypadWidth = 300
        Me.RampRateUnitPsiPerSecBasicLabel.Location = New System.Drawing.Point(383, 666)
        Me.RampRateUnitPsiPerSecBasicLabel.Name = "RampRateUnitPsiPerSecBasicLabel"
        Me.RampRateUnitPsiPerSecBasicLabel.NumericFormat = Nothing
        Me.RampRateUnitPsiPerSecBasicLabel.PLCAddressHighlight = "prof_edit_PSI_True"
        Me.RampRateUnitPsiPerSecBasicLabel.PLCAddressKeypad = ""
        Me.RampRateUnitPsiPerSecBasicLabel.PLCAddressVisible = "prof_edit_PSI_True"
        Me.RampRateUnitPsiPerSecBasicLabel.PollRate = 0
        Me.RampRateUnitPsiPerSecBasicLabel.Size = New System.Drawing.Size(39, 19)
        Me.RampRateUnitPsiPerSecBasicLabel.TabIndex = 328
        Me.RampRateUnitPsiPerSecBasicLabel.Text = "PSI/s"
        Me.RampRateUnitPsiPerSecBasicLabel.Value = "PSI/s"
        Me.RampRateUnitPsiPerSecBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RampRateUnitPsiPerSecBasicLabel.ValueLeftPadLength = 0
        Me.RampRateUnitPsiPerSecBasicLabel.ValuePrefix = Nothing
        Me.RampRateUnitPsiPerSecBasicLabel.ValueScaleFactor = 1.0R
        Me.RampRateUnitPsiPerSecBasicLabel.ValueSuffix = Nothing
        '
        'RampRateUnitBarPerSecBasicLabel
        '
        Me.RampRateUnitBarPerSecBasicLabel.AutoSize = True
        Me.RampRateUnitBarPerSecBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.RampRateUnitBarPerSecBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RampRateUnitBarPerSecBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RampRateUnitBarPerSecBasicLabel.DisplayAsTime = False
        Me.RampRateUnitBarPerSecBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRateUnitBarPerSecBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitBarPerSecBasicLabel.Highlight = False
        Me.RampRateUnitBarPerSecBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.RampRateUnitBarPerSecBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RampRateUnitBarPerSecBasicLabel.HighlightKeyCharacter = "!"
        Me.RampRateUnitBarPerSecBasicLabel.KeypadAlphaNumeric = False
        Me.RampRateUnitBarPerSecBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RampRateUnitBarPerSecBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RampRateUnitBarPerSecBasicLabel.KeypadMaxValue = 0.0R
        Me.RampRateUnitBarPerSecBasicLabel.KeypadMinValue = 0.0R
        Me.RampRateUnitBarPerSecBasicLabel.KeypadScaleFactor = 1.0R
        Me.RampRateUnitBarPerSecBasicLabel.KeypadShowCurrentValue = False
        Me.RampRateUnitBarPerSecBasicLabel.KeypadText = Nothing
        Me.RampRateUnitBarPerSecBasicLabel.KeypadWidth = 300
        Me.RampRateUnitBarPerSecBasicLabel.Location = New System.Drawing.Point(382, 666)
        Me.RampRateUnitBarPerSecBasicLabel.Name = "RampRateUnitBarPerSecBasicLabel"
        Me.RampRateUnitBarPerSecBasicLabel.NumericFormat = Nothing
        Me.RampRateUnitBarPerSecBasicLabel.PLCAddressHighlight = "prof_edit_Bar_True"
        Me.RampRateUnitBarPerSecBasicLabel.PLCAddressKeypad = ""
        Me.RampRateUnitBarPerSecBasicLabel.PLCAddressVisible = "prof_edit_Bar_True"
        Me.RampRateUnitBarPerSecBasicLabel.PollRate = 0
        Me.RampRateUnitBarPerSecBasicLabel.Size = New System.Drawing.Size(40, 19)
        Me.RampRateUnitBarPerSecBasicLabel.TabIndex = 327
        Me.RampRateUnitBarPerSecBasicLabel.Text = "Bar/s"
        Me.RampRateUnitBarPerSecBasicLabel.Value = "Bar/s"
        Me.RampRateUnitBarPerSecBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RampRateUnitBarPerSecBasicLabel.ValueLeftPadLength = 0
        Me.RampRateUnitBarPerSecBasicLabel.ValuePrefix = Nothing
        Me.RampRateUnitBarPerSecBasicLabel.ValueScaleFactor = 1.0R
        Me.RampRateUnitBarPerSecBasicLabel.ValueSuffix = Nothing
        '
        'PressureSetPointUnitPsiBasicLabel
        '
        Me.PressureSetPointUnitPsiBasicLabel.AutoSize = True
        Me.PressureSetPointUnitPsiBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitPsiBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureSetPointUnitPsiBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureSetPointUnitPsiBasicLabel.DisplayAsTime = False
        Me.PressureSetPointUnitPsiBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointUnitPsiBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitPsiBasicLabel.Highlight = False
        Me.PressureSetPointUnitPsiBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitPsiBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureSetPointUnitPsiBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureSetPointUnitPsiBasicLabel.KeypadAlphaNumeric = False
        Me.PressureSetPointUnitPsiBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PressureSetPointUnitPsiBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitPsiBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureSetPointUnitPsiBasicLabel.KeypadMinValue = 0.0R
        Me.PressureSetPointUnitPsiBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureSetPointUnitPsiBasicLabel.KeypadShowCurrentValue = False
        Me.PressureSetPointUnitPsiBasicLabel.KeypadText = Nothing
        Me.PressureSetPointUnitPsiBasicLabel.KeypadWidth = 300
        Me.PressureSetPointUnitPsiBasicLabel.Location = New System.Drawing.Point(394, 630)
        Me.PressureSetPointUnitPsiBasicLabel.Name = "PressureSetPointUnitPsiBasicLabel"
        Me.PressureSetPointUnitPsiBasicLabel.NumericFormat = Nothing
        Me.PressureSetPointUnitPsiBasicLabel.PLCAddressHighlight = "prof_edit_PSI_True"
        Me.PressureSetPointUnitPsiBasicLabel.PLCAddressKeypad = ""
        Me.PressureSetPointUnitPsiBasicLabel.PLCAddressVisible = "prof_edit_PSI_True"
        Me.PressureSetPointUnitPsiBasicLabel.PollRate = 0
        Me.PressureSetPointUnitPsiBasicLabel.Size = New System.Drawing.Size(28, 19)
        Me.PressureSetPointUnitPsiBasicLabel.TabIndex = 326
        Me.PressureSetPointUnitPsiBasicLabel.Text = "PSI"
        Me.PressureSetPointUnitPsiBasicLabel.Value = "PSI"
        Me.PressureSetPointUnitPsiBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureSetPointUnitPsiBasicLabel.ValueLeftPadLength = 0
        Me.PressureSetPointUnitPsiBasicLabel.ValuePrefix = Nothing
        Me.PressureSetPointUnitPsiBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureSetPointUnitPsiBasicLabel.ValueSuffix = Nothing
        '
        'PressureSetPointUnitBargBasicLabel
        '
        Me.PressureSetPointUnitBargBasicLabel.AutoSize = True
        Me.PressureSetPointUnitBargBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitBargBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PressureSetPointUnitBargBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PressureSetPointUnitBargBasicLabel.DisplayAsTime = False
        Me.PressureSetPointUnitBargBasicLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetPointUnitBargBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitBargBasicLabel.Highlight = False
        Me.PressureSetPointUnitBargBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PressureSetPointUnitBargBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PressureSetPointUnitBargBasicLabel.HighlightKeyCharacter = "!"
        Me.PressureSetPointUnitBargBasicLabel.KeypadAlphaNumeric = False
        Me.PressureSetPointUnitBargBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PressureSetPointUnitBargBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PressureSetPointUnitBargBasicLabel.KeypadMaxValue = 0.0R
        Me.PressureSetPointUnitBargBasicLabel.KeypadMinValue = 0.0R
        Me.PressureSetPointUnitBargBasicLabel.KeypadScaleFactor = 1.0R
        Me.PressureSetPointUnitBargBasicLabel.KeypadShowCurrentValue = False
        Me.PressureSetPointUnitBargBasicLabel.KeypadText = Nothing
        Me.PressureSetPointUnitBargBasicLabel.KeypadWidth = 300
        Me.PressureSetPointUnitBargBasicLabel.Location = New System.Drawing.Point(383, 629)
        Me.PressureSetPointUnitBargBasicLabel.Name = "PressureSetPointUnitBargBasicLabel"
        Me.PressureSetPointUnitBargBasicLabel.NumericFormat = Nothing
        Me.PressureSetPointUnitBargBasicLabel.PLCAddressHighlight = "prof_edit_Bar_True"
        Me.PressureSetPointUnitBargBasicLabel.PLCAddressKeypad = ""
        Me.PressureSetPointUnitBargBasicLabel.PLCAddressVisible = "prof_edit_Bar_True"
        Me.PressureSetPointUnitBargBasicLabel.PollRate = 0
        Me.PressureSetPointUnitBargBasicLabel.Size = New System.Drawing.Size(39, 19)
        Me.PressureSetPointUnitBargBasicLabel.TabIndex = 325
        Me.PressureSetPointUnitBargBasicLabel.Text = "BarG"
        Me.PressureSetPointUnitBargBasicLabel.Value = "BarG"
        Me.PressureSetPointUnitBargBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PressureSetPointUnitBargBasicLabel.ValueLeftPadLength = 0
        Me.PressureSetPointUnitBargBasicLabel.ValuePrefix = Nothing
        Me.PressureSetPointUnitBargBasicLabel.ValueScaleFactor = 1.0R
        Me.PressureSetPointUnitBargBasicLabel.ValueSuffix = Nothing
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
        Me.CurrentDateTime.TabIndex = 469
        Me.CurrentDateTime.Text = "13-06-2017 11:04:56"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'NeckGripUnitsLabel
        '
        Me.NeckGripUnitsLabel.AutoSize = True
        Me.NeckGripUnitsLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeckGripUnitsLabel.Location = New System.Drawing.Point(471, 375)
        Me.NeckGripUnitsLabel.Name = "NeckGripUnitsLabel"
        Me.NeckGripUnitsLabel.Size = New System.Drawing.Size(33, 19)
        Me.NeckGripUnitsLabel.TabIndex = 475
        Me.NeckGripUnitsLabel.Text = "mm"
        '
        'NeckGripSizeLabel
        '
        Me.NeckGripSizeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeckGripSizeLabel.Location = New System.Drawing.Point(240, 355)
        Me.NeckGripSizeLabel.Name = "NeckGripSizeLabel"
        Me.NeckGripSizeLabel.Size = New System.Drawing.Size(264, 20)
        Me.NeckGripSizeLabel.TabIndex = 474
        Me.NeckGripSizeLabel.Text = "Neck Grip"
        Me.NeckGripSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 19)
        Me.Label4.TabIndex = 546
        Me.Label4.Text = "ml"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 19)
        Me.Label3.TabIndex = 545
        Me.Label3.Text = "mm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 19)
        Me.Label2.TabIndex = 544
        Me.Label2.Text = "mm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 543
        Me.Label1.Text = "mm"
        '
        'VolumeLabel
        '
        Me.VolumeLabel.BackColor = System.Drawing.Color.Gray
        Me.VolumeLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.VolumeLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.VolumeLabel.DisplayAsTime = False
        Me.VolumeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumeLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VolumeLabel.Highlight = False
        Me.VolumeLabel.HighlightColor = System.Drawing.Color.Gray
        Me.VolumeLabel.HighlightForeColor = System.Drawing.Color.White
        Me.VolumeLabel.HighlightKeyCharacter = "!"
        Me.VolumeLabel.KeypadAlphaNumeric = False
        Me.VolumeLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.VolumeLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.VolumeLabel.KeypadMaxValue = 0.0R
        Me.VolumeLabel.KeypadMinValue = 0.0R
        Me.VolumeLabel.KeypadScaleFactor = 1.0R
        Me.VolumeLabel.KeypadShowCurrentValue = False
        Me.VolumeLabel.KeypadText = Nothing
        Me.VolumeLabel.KeypadWidth = 300
        Me.VolumeLabel.Location = New System.Drawing.Point(240, 276)
        Me.VolumeLabel.Name = "VolumeLabel"
        Me.VolumeLabel.NumericFormat = Nothing
        Me.VolumeLabel.PLCAddressKeypad = ""
        Me.VolumeLabel.PollRate = 0
        Me.VolumeLabel.Size = New System.Drawing.Size(264, 20)
        Me.VolumeLabel.TabIndex = 541
        Me.VolumeLabel.Text = "Volume"
        Me.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.VolumeLabel.Value = "Volume"
        Me.VolumeLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VolumeLabel.ValueLeftPadLength = 0
        Me.VolumeLabel.ValuePrefix = Nothing
        Me.VolumeLabel.ValueScaleFactor = 1.0R
        Me.VolumeLabel.ValueSuffix = Nothing
        '
        'FinishHeightLabel
        '
        Me.FinishHeightLabel.BackColor = System.Drawing.Color.Gray
        Me.FinishHeightLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FinishHeightLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FinishHeightLabel.DisplayAsTime = False
        Me.FinishHeightLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishHeightLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FinishHeightLabel.Highlight = False
        Me.FinishHeightLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FinishHeightLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FinishHeightLabel.HighlightKeyCharacter = "!"
        Me.FinishHeightLabel.KeypadAlphaNumeric = False
        Me.FinishHeightLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FinishHeightLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FinishHeightLabel.KeypadMaxValue = 0.0R
        Me.FinishHeightLabel.KeypadMinValue = 0.0R
        Me.FinishHeightLabel.KeypadScaleFactor = 1.0R
        Me.FinishHeightLabel.KeypadShowCurrentValue = False
        Me.FinishHeightLabel.KeypadText = Nothing
        Me.FinishHeightLabel.KeypadWidth = 300
        Me.FinishHeightLabel.Location = New System.Drawing.Point(240, 237)
        Me.FinishHeightLabel.Name = "FinishHeightLabel"
        Me.FinishHeightLabel.NumericFormat = Nothing
        Me.FinishHeightLabel.PLCAddressKeypad = ""
        Me.FinishHeightLabel.PollRate = 0
        Me.FinishHeightLabel.Size = New System.Drawing.Size(264, 20)
        Me.FinishHeightLabel.TabIndex = 539
        Me.FinishHeightLabel.Text = "Finish Height"
        Me.FinishHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FinishHeightLabel.Value = "Finish Height"
        Me.FinishHeightLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FinishHeightLabel.ValueLeftPadLength = 0
        Me.FinishHeightLabel.ValuePrefix = Nothing
        Me.FinishHeightLabel.ValueScaleFactor = 1.0R
        Me.FinishHeightLabel.ValueSuffix = Nothing
        '
        'LabelHeightLabel
        '
        Me.LabelHeightLabel.BackColor = System.Drawing.Color.Gray
        Me.LabelHeightLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LabelHeightLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.LabelHeightLabel.DisplayAsTime = False
        Me.LabelHeightLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeightLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelHeightLabel.Highlight = False
        Me.LabelHeightLabel.HighlightColor = System.Drawing.Color.Gray
        Me.LabelHeightLabel.HighlightForeColor = System.Drawing.Color.White
        Me.LabelHeightLabel.HighlightKeyCharacter = "!"
        Me.LabelHeightLabel.KeypadAlphaNumeric = False
        Me.LabelHeightLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelHeightLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LabelHeightLabel.KeypadMaxValue = 0.0R
        Me.LabelHeightLabel.KeypadMinValue = 0.0R
        Me.LabelHeightLabel.KeypadScaleFactor = 1.0R
        Me.LabelHeightLabel.KeypadShowCurrentValue = False
        Me.LabelHeightLabel.KeypadText = Nothing
        Me.LabelHeightLabel.KeypadWidth = 300
        Me.LabelHeightLabel.Location = New System.Drawing.Point(240, 198)
        Me.LabelHeightLabel.Name = "LabelHeightLabel"
        Me.LabelHeightLabel.NumericFormat = Nothing
        Me.LabelHeightLabel.PLCAddressKeypad = ""
        Me.LabelHeightLabel.PollRate = 0
        Me.LabelHeightLabel.Size = New System.Drawing.Size(264, 20)
        Me.LabelHeightLabel.TabIndex = 537
        Me.LabelHeightLabel.Text = "Label Height"
        Me.LabelHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelHeightLabel.Value = "Label Height"
        Me.LabelHeightLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LabelHeightLabel.ValueLeftPadLength = 0
        Me.LabelHeightLabel.ValuePrefix = Nothing
        Me.LabelHeightLabel.ValueScaleFactor = 1.0R
        Me.LabelHeightLabel.ValueSuffix = Nothing
        '
        'BottleHeightLabel
        '
        Me.BottleHeightLabel.BackColor = System.Drawing.Color.Gray
        Me.BottleHeightLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BottleHeightLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.BottleHeightLabel.DisplayAsTime = False
        Me.BottleHeightLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleHeightLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BottleHeightLabel.Highlight = False
        Me.BottleHeightLabel.HighlightColor = System.Drawing.Color.Gray
        Me.BottleHeightLabel.HighlightForeColor = System.Drawing.Color.White
        Me.BottleHeightLabel.HighlightKeyCharacter = "!"
        Me.BottleHeightLabel.KeypadAlphaNumeric = False
        Me.BottleHeightLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BottleHeightLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BottleHeightLabel.KeypadMaxValue = 0.0R
        Me.BottleHeightLabel.KeypadMinValue = 0.0R
        Me.BottleHeightLabel.KeypadScaleFactor = 1.0R
        Me.BottleHeightLabel.KeypadShowCurrentValue = False
        Me.BottleHeightLabel.KeypadText = Nothing
        Me.BottleHeightLabel.KeypadWidth = 300
        Me.BottleHeightLabel.Location = New System.Drawing.Point(240, 159)
        Me.BottleHeightLabel.Name = "BottleHeightLabel"
        Me.BottleHeightLabel.NumericFormat = Nothing
        Me.BottleHeightLabel.PLCAddressKeypad = ""
        Me.BottleHeightLabel.PollRate = 0
        Me.BottleHeightLabel.Size = New System.Drawing.Size(264, 20)
        Me.BottleHeightLabel.TabIndex = 535
        Me.BottleHeightLabel.Text = "Overall Bottle Height"
        Me.BottleHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BottleHeightLabel.Value = "Overall Bottle Height"
        Me.BottleHeightLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BottleHeightLabel.ValueLeftPadLength = 0
        Me.BottleHeightLabel.ValuePrefix = Nothing
        Me.BottleHeightLabel.ValueScaleFactor = 1.0R
        Me.BottleHeightLabel.ValueSuffix = Nothing
        '
        'BottleHeightTextBox
        '
        Me.BottleHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleHeightTextBox.Location = New System.Drawing.Point(511, 157)
        Me.BottleHeightTextBox.Name = "BottleHeightTextBox"
        Me.BottleHeightTextBox.Size = New System.Drawing.Size(77, 24)
        Me.BottleHeightTextBox.TabIndex = 547
        '
        'BottleLabelHeightTextBox
        '
        Me.BottleLabelHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleLabelHeightTextBox.Location = New System.Drawing.Point(511, 196)
        Me.BottleLabelHeightTextBox.Name = "BottleLabelHeightTextBox"
        Me.BottleLabelHeightTextBox.Size = New System.Drawing.Size(77, 24)
        Me.BottleLabelHeightTextBox.TabIndex = 548
        '
        'BottleFinishHeightTextBox
        '
        Me.BottleFinishHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleFinishHeightTextBox.Location = New System.Drawing.Point(511, 235)
        Me.BottleFinishHeightTextBox.Name = "BottleFinishHeightTextBox"
        Me.BottleFinishHeightTextBox.Size = New System.Drawing.Size(77, 24)
        Me.BottleFinishHeightTextBox.TabIndex = 549
        '
        'BottleVolumeTextBox
        '
        Me.BottleVolumeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleVolumeTextBox.Location = New System.Drawing.Point(511, 274)
        Me.BottleVolumeTextBox.Name = "BottleVolumeTextBox"
        Me.BottleVolumeTextBox.Size = New System.Drawing.Size(77, 24)
        Me.BottleVolumeTextBox.TabIndex = 550
        '
        'LowBurstTextBox
        '
        Me.LowBurstTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowBurstTextBox.Location = New System.Drawing.Point(511, 314)
        Me.LowBurstTextBox.Name = "LowBurstTextBox"
        Me.LowBurstTextBox.Size = New System.Drawing.Size(77, 24)
        Me.LowBurstTextBox.TabIndex = 551
        '
        'NeckGripTextBox
        '
        Me.NeckGripTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeckGripTextBox.Location = New System.Drawing.Point(511, 353)
        Me.NeckGripTextBox.Name = "NeckGripTextBox"
        Me.NeckGripTextBox.Size = New System.Drawing.Size(77, 24)
        Me.NeckGripTextBox.TabIndex = 552
        '
        'PressureSetpoint1TextBox
        '
        Me.PressureSetpoint1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetpoint1TextBox.Location = New System.Drawing.Point(428, 610)
        Me.PressureSetpoint1TextBox.Name = "PressureSetpoint1TextBox"
        Me.PressureSetpoint1TextBox.Size = New System.Drawing.Size(77, 24)
        Me.PressureSetpoint1TextBox.TabIndex = 556
        '
        'RampRate1TextBox
        '
        Me.RampRate1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRate1TextBox.Location = New System.Drawing.Point(428, 647)
        Me.RampRate1TextBox.Name = "RampRate1TextBox"
        Me.RampRate1TextBox.Size = New System.Drawing.Size(77, 24)
        Me.RampRate1TextBox.TabIndex = 557
        '
        'DwellTime1TextBox
        '
        Me.DwellTime1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DwellTime1TextBox.Location = New System.Drawing.Point(428, 683)
        Me.DwellTime1TextBox.Name = "DwellTime1TextBox"
        Me.DwellTime1TextBox.Size = New System.Drawing.Size(77, 24)
        Me.DwellTime1TextBox.TabIndex = 558
        '
        'DwellTime2TextBox
        '
        Me.DwellTime2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DwellTime2TextBox.Location = New System.Drawing.Point(511, 683)
        Me.DwellTime2TextBox.Name = "DwellTime2TextBox"
        Me.DwellTime2TextBox.Size = New System.Drawing.Size(77, 24)
        Me.DwellTime2TextBox.TabIndex = 561
        '
        'RampRate2TextBox
        '
        Me.RampRate2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RampRate2TextBox.Location = New System.Drawing.Point(511, 647)
        Me.RampRate2TextBox.Name = "RampRate2TextBox"
        Me.RampRate2TextBox.Size = New System.Drawing.Size(77, 24)
        Me.RampRate2TextBox.TabIndex = 560
        '
        'PressureSetpoint2TextBox
        '
        Me.PressureSetpoint2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureSetpoint2TextBox.Location = New System.Drawing.Point(511, 610)
        Me.PressureSetpoint2TextBox.Name = "PressureSetpoint2TextBox"
        Me.PressureSetpoint2TextBox.Size = New System.Drawing.Size(77, 24)
        Me.PressureSetpoint2TextBox.TabIndex = 559
        '
        'P60RadioButton
        '
        Me.P60RadioButton.AutoSize = True
        Me.P60RadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P60RadioButton.Location = New System.Drawing.Point(15, 16)
        Me.P60RadioButton.Name = "P60RadioButton"
        Me.P60RadioButton.Size = New System.Drawing.Size(44, 17)
        Me.P60RadioButton.TabIndex = 562
        Me.P60RadioButton.TabStop = True
        Me.P60RadioButton.Text = "P60"
        Me.P60RadioButton.UseVisualStyleBackColor = True
        '
        'PrRadioButton
        '
        Me.PrRadioButton.AutoSize = True
        Me.PrRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrRadioButton.Location = New System.Drawing.Point(78, 16)
        Me.PrRadioButton.Name = "PrRadioButton"
        Me.PrRadioButton.Size = New System.Drawing.Size(35, 17)
        Me.PrRadioButton.TabIndex = 563
        Me.PrRadioButton.TabStop = True
        Me.PrRadioButton.Text = "Pr"
        Me.PrRadioButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 566
        Me.Label5.Text = "mm"
        '
        'PlaceHeightAdjustmentLabel
        '
        Me.PlaceHeightAdjustmentLabel.BackColor = System.Drawing.Color.Gray
        Me.PlaceHeightAdjustmentLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PlaceHeightAdjustmentLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PlaceHeightAdjustmentLabel.DisplayAsTime = False
        Me.PlaceHeightAdjustmentLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceHeightAdjustmentLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceHeightAdjustmentLabel.Highlight = False
        Me.PlaceHeightAdjustmentLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PlaceHeightAdjustmentLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PlaceHeightAdjustmentLabel.HighlightKeyCharacter = "!"
        Me.PlaceHeightAdjustmentLabel.KeypadAlphaNumeric = False
        Me.PlaceHeightAdjustmentLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PlaceHeightAdjustmentLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceHeightAdjustmentLabel.KeypadMaxValue = 0.0R
        Me.PlaceHeightAdjustmentLabel.KeypadMinValue = 0.0R
        Me.PlaceHeightAdjustmentLabel.KeypadScaleFactor = 1.0R
        Me.PlaceHeightAdjustmentLabel.KeypadShowCurrentValue = False
        Me.PlaceHeightAdjustmentLabel.KeypadText = Nothing
        Me.PlaceHeightAdjustmentLabel.KeypadWidth = 300
        Me.PlaceHeightAdjustmentLabel.Location = New System.Drawing.Point(240, 395)
        Me.PlaceHeightAdjustmentLabel.Name = "PlaceHeightAdjustmentLabel"
        Me.PlaceHeightAdjustmentLabel.NumericFormat = Nothing
        Me.PlaceHeightAdjustmentLabel.PLCAddressKeypad = ""
        Me.PlaceHeightAdjustmentLabel.PollRate = 0
        Me.PlaceHeightAdjustmentLabel.Size = New System.Drawing.Size(264, 20)
        Me.PlaceHeightAdjustmentLabel.TabIndex = 564
        Me.PlaceHeightAdjustmentLabel.Text = "Place Height Adjustment"
        Me.PlaceHeightAdjustmentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.PlaceHeightAdjustmentLabel.Value = "Place Height Adjustment"
        Me.PlaceHeightAdjustmentLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PlaceHeightAdjustmentLabel.ValueLeftPadLength = 0
        Me.PlaceHeightAdjustmentLabel.ValuePrefix = Nothing
        Me.PlaceHeightAdjustmentLabel.ValueScaleFactor = 1.0R
        Me.PlaceHeightAdjustmentLabel.ValueSuffix = Nothing
        '
        'PlaceHeightAdjustmentTextBox
        '
        Me.PlaceHeightAdjustmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceHeightAdjustmentTextBox.Location = New System.Drawing.Point(511, 393)
        Me.PlaceHeightAdjustmentTextBox.Name = "PlaceHeightAdjustmentTextBox"
        Me.PlaceHeightAdjustmentTextBox.Size = New System.Drawing.Size(77, 24)
        Me.PlaceHeightAdjustmentTextBox.TabIndex = 567
        '
        'ProfileNameTextBox
        '
        Me.ProfileNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileNameTextBox.Location = New System.Drawing.Point(240, 104)
        Me.ProfileNameTextBox.Name = "ProfileNameTextBox"
        Me.ProfileNameTextBox.Size = New System.Drawing.Size(217, 29)
        Me.ProfileNameTextBox.TabIndex = 568
        '
        'PressureUnitBarRadioButton
        '
        Me.PressureUnitBarRadioButton.AutoSize = True
        Me.PressureUnitBarRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitBarRadioButton.Location = New System.Drawing.Point(15, 17)
        Me.PressureUnitBarRadioButton.Name = "PressureUnitBarRadioButton"
        Me.PressureUnitBarRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.PressureUnitBarRadioButton.TabIndex = 569
        Me.PressureUnitBarRadioButton.TabStop = True
        Me.PressureUnitBarRadioButton.Text = "Bar"
        Me.PressureUnitBarRadioButton.UseVisualStyleBackColor = True
        '
        'PressureUnitPsiRadioButton
        '
        Me.PressureUnitPsiRadioButton.AutoSize = True
        Me.PressureUnitPsiRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitPsiRadioButton.Location = New System.Drawing.Point(78, 17)
        Me.PressureUnitPsiRadioButton.Name = "PressureUnitPsiRadioButton"
        Me.PressureUnitPsiRadioButton.Size = New System.Drawing.Size(42, 17)
        Me.PressureUnitPsiRadioButton.TabIndex = 570
        Me.PressureUnitPsiRadioButton.TabStop = True
        Me.PressureUnitPsiRadioButton.Text = "PSI"
        Me.PressureUnitPsiRadioButton.UseVisualStyleBackColor = True
        '
        'PressureUnitKgcm2RadioButton
        '
        Me.PressureUnitKgcm2RadioButton.AutoSize = True
        Me.PressureUnitKgcm2RadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitKgcm2RadioButton.Location = New System.Drawing.Point(138, 17)
        Me.PressureUnitKgcm2RadioButton.Name = "PressureUnitKgcm2RadioButton"
        Me.PressureUnitKgcm2RadioButton.Size = New System.Drawing.Size(62, 17)
        Me.PressureUnitKgcm2RadioButton.TabIndex = 571
        Me.PressureUnitKgcm2RadioButton.TabStop = True
        Me.PressureUnitKgcm2RadioButton.Text = "kg/cm2"
        Me.PressureUnitKgcm2RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PressureUnitKgcm2RadioButton)
        Me.GroupBox1.Controls.Add(Me.PressureUnitBarRadioButton)
        Me.GroupBox1.Controls.Add(Me.PressureUnitPsiRadioButton)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(385, 469)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 45)
        Me.GroupBox1.TabIndex = 572
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.P60RadioButton)
        Me.GroupBox2.Controls.Add(Me.PrRadioButton)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(385, 520)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 45)
        Me.GroupBox2.TabIndex = 573
        Me.GroupBox2.TabStop = False
        '
        'DeleteProfileButton
        '
        Me.DeleteProfileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProfileButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.delete_profile
        Me.DeleteProfileButton.Location = New System.Drawing.Point(505, 104)
        Me.DeleteProfileButton.Name = "DeleteProfileButton"
        Me.DeleteProfileButton.Size = New System.Drawing.Size(45, 31)
        Me.DeleteProfileButton.TabIndex = 575
        Me.DeleteProfileButton.UseVisualStyleBackColor = True
        '
        'NewRecipeButton
        '
        Me.NewRecipeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecipeButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.new_profile
        Me.NewRecipeButton.Location = New System.Drawing.Point(552, 104)
        Me.NewRecipeButton.Name = "NewRecipeButton"
        Me.NewRecipeButton.Size = New System.Drawing.Size(45, 31)
        Me.NewRecipeButton.TabIndex = 574
        Me.NewRecipeButton.UseVisualStyleBackColor = True
        '
        'CopyProfileButton
        '
        Me.CopyProfileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyProfileButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.copy
        Me.CopyProfileButton.Location = New System.Drawing.Point(459, 104)
        Me.CopyProfileButton.Name = "CopyProfileButton"
        Me.CopyProfileButton.Size = New System.Drawing.Size(45, 31)
        Me.CopyProfileButton.TabIndex = 477
        Me.CopyProfileButton.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 472
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(175, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 471
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
        Me.AlmInd.TabIndex = 468
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenHomeButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenHomeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHomeButton.Highlight = False
        Me.PgOpenHomeButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenHomeButton.Image = CType(resources.GetObject("PgOpenHomeButton.Image"), System.Drawing.Image)
        Me.PgOpenHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(0, 757)
        Me.PgOpenHomeButton.MaximumHoldTime = 3000
        Me.PgOpenHomeButton.MinimumHoldTime = 500
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenHomeButton.PLCAddressClick = "HMI_cancel_rec_edit"
        Me.PgOpenHomeButton.SelectTextAlternate = False
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 342
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextAlternate = Nothing
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        Me.PgOpenHomeButton.ValueToWrite = 0
        '
        'RecSaveBasicButton
        '
        Me.RecSaveBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.RecSaveBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RecSaveBasicButton.Highlight = False
        Me.RecSaveBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.RecSaveBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.profile_save
        Me.RecSaveBasicButton.Location = New System.Drawing.Point(500, 757)
        Me.RecSaveBasicButton.MaximumHoldTime = 3000
        Me.RecSaveBasicButton.MinimumHoldTime = 500
        Me.RecSaveBasicButton.Name = "RecSaveBasicButton"
        Me.RecSaveBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RecSaveBasicButton.PLCAddressClick = ""
        Me.RecSaveBasicButton.PLCAddressVisible = "HMI.Level1Access"
        Me.RecSaveBasicButton.SelectTextAlternate = False
        Me.RecSaveBasicButton.Size = New System.Drawing.Size(99, 44)
        Me.RecSaveBasicButton.TabIndex = 338
        Me.RecSaveBasicButton.TextAlternate = Nothing
        Me.RecSaveBasicButton.UseVisualStyleBackColor = True
        Me.RecSaveBasicButton.ValueToWrite = 0
        '
        'ProfileEditPictureBox
        '
        Me.ProfileEditPictureBox.BackColor = System.Drawing.Color.White
        Me.ProfileEditPictureBox.Image = CType(resources.GetObject("ProfileEditPictureBox.Image"), System.Drawing.Image)
        Me.ProfileEditPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.ProfileEditPictureBox.Name = "ProfileEditPictureBox"
        Me.ProfileEditPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.ProfileEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProfileEditPictureBox.TabIndex = 272
        Me.ProfileEditPictureBox.TabStop = False
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
        'LineNumberTextBox
        '
        Me.LineNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNumberTextBox.Location = New System.Drawing.Point(511, 433)
        Me.LineNumberTextBox.Name = "LineNumberTextBox"
        Me.LineNumberTextBox.Size = New System.Drawing.Size(77, 24)
        Me.LineNumberTextBox.TabIndex = 579
        '
        'LineNumberLabel
        '
        Me.LineNumberLabel.BackColor = System.Drawing.Color.Gray
        Me.LineNumberLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LineNumberLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.LineNumberLabel.DisplayAsTime = False
        Me.LineNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LineNumberLabel.Highlight = False
        Me.LineNumberLabel.HighlightColor = System.Drawing.Color.Gray
        Me.LineNumberLabel.HighlightForeColor = System.Drawing.Color.White
        Me.LineNumberLabel.HighlightKeyCharacter = "!"
        Me.LineNumberLabel.KeypadAlphaNumeric = False
        Me.LineNumberLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LineNumberLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LineNumberLabel.KeypadMaxValue = 0.0R
        Me.LineNumberLabel.KeypadMinValue = 0.0R
        Me.LineNumberLabel.KeypadScaleFactor = 1.0R
        Me.LineNumberLabel.KeypadShowCurrentValue = False
        Me.LineNumberLabel.KeypadText = Nothing
        Me.LineNumberLabel.KeypadWidth = 300
        Me.LineNumberLabel.Location = New System.Drawing.Point(240, 435)
        Me.LineNumberLabel.Name = "LineNumberLabel"
        Me.LineNumberLabel.NumericFormat = Nothing
        Me.LineNumberLabel.PLCAddressKeypad = ""
        Me.LineNumberLabel.PollRate = 0
        Me.LineNumberLabel.Size = New System.Drawing.Size(264, 20)
        Me.LineNumberLabel.TabIndex = 577
        Me.LineNumberLabel.Text = "Line"
        Me.LineNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LineNumberLabel.Value = "Line"
        Me.LineNumberLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LineNumberLabel.ValueLeftPadLength = 0
        Me.LineNumberLabel.ValuePrefix = Nothing
        Me.LineNumberLabel.ValueScaleFactor = 1.0R
        Me.LineNumberLabel.ValueSuffix = Nothing
        '
        'DataEntryErrorProvider
        '
        Me.DataEntryErrorProvider.ContainerControl = Me
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
        Me.AccessLevelLabel.TabIndex = 580
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 29)
        Me.TextBox1.TabIndex = 588
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Gray
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(12, 147)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(217, 571)
        Me.ListBox1.TabIndex = 589
        '
        'base_rec_edit
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 801)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.LineNumberTextBox)
        Me.Controls.Add(Me.LineNumberLabel)
        Me.Controls.Add(Me.DeleteProfileButton)
        Me.Controls.Add(Me.NewRecipeButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProfileNameTextBox)
        Me.Controls.Add(Me.PlaceHeightAdjustmentTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PlaceHeightAdjustmentLabel)
        Me.Controls.Add(Me.DwellTime2TextBox)
        Me.Controls.Add(Me.RampRate2TextBox)
        Me.Controls.Add(Me.PressureSetpoint2TextBox)
        Me.Controls.Add(Me.DwellTime1TextBox)
        Me.Controls.Add(Me.RampRate1TextBox)
        Me.Controls.Add(Me.PressureSetpoint1TextBox)
        Me.Controls.Add(Me.NeckGripTextBox)
        Me.Controls.Add(Me.LowBurstTextBox)
        Me.Controls.Add(Me.BottleVolumeTextBox)
        Me.Controls.Add(Me.BottleFinishHeightTextBox)
        Me.Controls.Add(Me.BottleLabelHeightTextBox)
        Me.Controls.Add(Me.BottleHeightTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VolumeLabel)
        Me.Controls.Add(Me.FinishHeightLabel)
        Me.Controls.Add(Me.LabelHeightLabel)
        Me.Controls.Add(Me.BottleHeightLabel)
        Me.Controls.Add(Me.CopyProfileButton)
        Me.Controls.Add(Me.NeckGripUnitsLabel)
        Me.Controls.Add(Me.NeckGripSizeLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.Phase2Label)
        Me.Controls.Add(Me.Phase1Label)
        Me.Controls.Add(Me.LowBurstValueUnitKgSqCmBasicLabel)
        Me.Controls.Add(Me.RampRateUnitKgSqCmPerSecBasicLabel)
        Me.Controls.Add(Me.PressureSetPointUnitKgSqCmBasicLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.RecSaveBasicButton)
        Me.Controls.Add(Me.LowBurstValueLabel)
        Me.Controls.Add(Me.DwellTimeLabel)
        Me.Controls.Add(Me.DwellTimeUnitLabel)
        Me.Controls.Add(Me.RampRateUnitPsiPerSecBasicLabel)
        Me.Controls.Add(Me.RampRateUnitBarPerSecBasicLabel)
        Me.Controls.Add(Me.PressureSetPointUnitPsiBasicLabel)
        Me.Controls.Add(Me.PressureSetPointUnitBargBasicLabel)
        Me.Controls.Add(Me.ActualOneMinuteEquivalentLabel)
        Me.Controls.Add(Me.RampRateLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PressureUnitsLabel)
        Me.Controls.Add(Me.PressureSetPointLabel)
        Me.Controls.Add(Me.ProfileEditPictureBox)
        Me.Controls.Add(Me.ProfileEditLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_rec_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.ProfileEdit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileEditPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataEntryErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProfileEditPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProfileEditLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PressureUnitsLabel As System.Windows.Forms.Label
    Friend WithEvents PressureSetPointLabel As System.Windows.Forms.Label
    Friend WithEvents LowBurstValueLabel As System.Windows.Forms.Label
    Friend WithEvents RampRateUnitPsiPerSecBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents RampRateUnitBarPerSecBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PressureSetPointUnitPsiBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PressureSetPointUnitBargBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ActualOneMinuteEquivalentLabel As System.Windows.Forms.Label
    Friend WithEvents RampRateLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RecSaveBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenHomeButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PressureSetPointUnitKgSqCmBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents LowBurstValueUnitKgSqCmBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents RampRateUnitKgSqCmPerSecBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents DwellTimeLabel As System.Windows.Forms.Label
    Friend WithEvents DwellTimeUnitLabel As System.Windows.Forms.Label
    Friend WithEvents Phase2Label As System.Windows.Forms.Label
    Friend WithEvents Phase1Label As System.Windows.Forms.Label
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents NeckGripUnitsLabel As System.Windows.Forms.Label
    Friend WithEvents NeckGripSizeLabel As System.Windows.Forms.Label
    Friend WithEvents CopyProfileButton As System.Windows.Forms.Button
    Friend WithEvents PrRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents P60RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DwellTime2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents RampRate2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureSetpoint2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DwellTime1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents RampRate1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureSetpoint1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NeckGripTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LowBurstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BottleVolumeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BottleFinishHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BottleLabelHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BottleHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VolumeLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents FinishHeightLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents LabelHeightLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BottleHeightLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PlaceHeightAdjustmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PlaceHeightAdjustmentLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ProfileNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureUnitKgcm2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PressureUnitPsiRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PressureUnitBarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NewRecipeButton As System.Windows.Forms.Button
    Friend WithEvents DeleteProfileButton As System.Windows.Forms.Button
    Friend WithEvents LineNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LineNumberLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents DataEntryErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
