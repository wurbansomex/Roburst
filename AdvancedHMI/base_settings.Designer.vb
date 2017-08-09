<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_settings))
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.HzBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.SecondsBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.ConveyorSpeedValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.WashDownTimerValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.ConveyorSpeedBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.WashDownTimerBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.BottleUnderTestDetectionPressureLabel = New System.Windows.Forms.Label()
        Me.BottleUnderTestDetectionPressureValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.BarLabel = New System.Windows.Forms.Label()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.LowBurstValueUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.LowBurstValueTimeoutLabel = New AdvancedHMIControls.BasicLabel()
        Me.CulletBinUsageSettingLabel = New AdvancedHMIControls.BasicLabel()
        Me.CulletBinDisabledButton = New AdvancedHMIControls.BasicButton()
        Me.CulletBinEnabledButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorToPickDistanceLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.ConveyorToPickDistanceUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.DisableConveyorButton = New AdvancedHMIControls.BasicButton()
        Me.ConveyorEnabledButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.EnableConveyorLabel = New AdvancedHMIControls.BasicLabel()
        Me.RemoteConnectionPortNumberLabel = New System.Windows.Forms.Label()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.RemoteConnectionsIPAddressLabel = New System.Windows.Forms.Label()
        Me.RemoteIPAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SetIPAddressButton = New AdvancedHMIControls.BasicButton()
        Me.PickUpClampsCloseDelayUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.PickUpClampsCloseDelayBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.DisableRemoteCommunicationsButton = New AdvancedHMIControls.BasicButton()
        Me.EnableRemoteCommunicationsButton = New AdvancedHMIControls.BasicButton()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.RemoteCommunicationsEnabledLabel = New AdvancedHMIControls.BasicLabel()
        Me.RemoteCommsDefaultMouldNumber = New AdvancedHMIControls.BasicLabel()
        Me.RemoteCommsErrorMouldNumber = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.RemoteConnectionsTimeoutLabel = New System.Windows.Forms.Label()
        Me.RemoteConnectionsTimeoutUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.PlaceGripOpenHeightUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.PlaceGripOpenHeightBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.AppExit = New System.Windows.Forms.Button()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.SettingsPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FastFillRateUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.FastFillRateLabel = New AdvancedHMIControls.BasicLabel()
        Me.FineFillRateUnitsLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.FineFillRateLabel = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.FastFineRatioLabel = New AdvancedHMIControls.BasicLabel()
        Me.Settings2BasicButton = New AdvancedHMIControls.BasicButton()
        Me.ClearStationMouldBufferBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ClearMouldsBufferButton = New AdvancedHMIControls.BasicButton()
        Me.ClearStationMouldBufferCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClearMouldsBufferCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClearStationMouldBufferCheckBoxLabel = New AdvancedHMIControls.BasicLabel()
        Me.ClearMouldsBufferCheckBoxLabel = New AdvancedHMIControls.BasicLabel()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblPLCVersion = New System.Windows.Forms.Label()
        Me.PurgeTimerUnits = New AdvancedHMIControls.BasicLabel()
        Me.PurgeTimerValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PurgeTimerBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.Settings3BasicButton = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SettingsLabel.Text = "Settings 1"
        Me.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'HzBasicLabel
        '
        Me.HzBasicLabel.AutoSize = True
        Me.HzBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.HzBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.HzBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.HzBasicLabel.DisplayAsTime = False
        Me.HzBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HzBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.HzBasicLabel.Highlight = False
        Me.HzBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.HzBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.HzBasicLabel.HighlightKeyCharacter = "!"
        Me.HzBasicLabel.KeypadAlphaNumeric = False
        Me.HzBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.HzBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.HzBasicLabel.KeypadMaxValue = 0.0R
        Me.HzBasicLabel.KeypadMinValue = 0.0R
        Me.HzBasicLabel.KeypadScaleFactor = 1.0R
        Me.HzBasicLabel.KeypadShowCurrentValue = False
        Me.HzBasicLabel.KeypadText = Nothing
        Me.HzBasicLabel.KeypadWidth = 300
        Me.HzBasicLabel.Location = New System.Drawing.Point(465, 195)
        Me.HzBasicLabel.Name = "HzBasicLabel"
        Me.HzBasicLabel.NumericFormat = Nothing
        Me.HzBasicLabel.PLCAddressHighlight = "NOT Conveyor.Bits[0].0"
        Me.HzBasicLabel.PLCAddressKeypad = ""
        Me.HzBasicLabel.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.HzBasicLabel.PollRate = 0
        Me.HzBasicLabel.Size = New System.Drawing.Size(27, 20)
        Me.HzBasicLabel.TabIndex = 329
        Me.HzBasicLabel.Text = "Hz"
        Me.HzBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.HzBasicLabel.Value = "Hz"
        Me.HzBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HzBasicLabel.ValueLeftPadLength = 0
        Me.HzBasicLabel.ValuePrefix = Nothing
        Me.HzBasicLabel.ValueScaleFactor = 1.0R
        Me.HzBasicLabel.ValueSuffix = Nothing
        '
        'SecondsBasicLabel
        '
        Me.SecondsBasicLabel.AutoSize = True
        Me.SecondsBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.SecondsBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.SecondsBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.SecondsBasicLabel.DisplayAsTime = False
        Me.SecondsBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SecondsBasicLabel.Highlight = False
        Me.SecondsBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.SecondsBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.SecondsBasicLabel.HighlightKeyCharacter = "!"
        Me.SecondsBasicLabel.KeypadAlphaNumeric = False
        Me.SecondsBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.SecondsBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SecondsBasicLabel.KeypadMaxValue = 0.0R
        Me.SecondsBasicLabel.KeypadMinValue = 0.0R
        Me.SecondsBasicLabel.KeypadScaleFactor = 1.0R
        Me.SecondsBasicLabel.KeypadShowCurrentValue = False
        Me.SecondsBasicLabel.KeypadText = Nothing
        Me.SecondsBasicLabel.KeypadWidth = 300
        Me.SecondsBasicLabel.Location = New System.Drawing.Point(465, 133)
        Me.SecondsBasicLabel.Name = "SecondsBasicLabel"
        Me.SecondsBasicLabel.NumericFormat = Nothing
        Me.SecondsBasicLabel.PLCAddressKeypad = ""
        Me.SecondsBasicLabel.PollRate = 0
        Me.SecondsBasicLabel.Size = New System.Drawing.Size(65, 20)
        Me.SecondsBasicLabel.TabIndex = 328
        Me.SecondsBasicLabel.Text = "Seconds"
        Me.SecondsBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.SecondsBasicLabel.Value = "Seconds"
        Me.SecondsBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SecondsBasicLabel.ValueLeftPadLength = 0
        Me.SecondsBasicLabel.ValuePrefix = Nothing
        Me.SecondsBasicLabel.ValueScaleFactor = 1.0R
        Me.SecondsBasicLabel.ValueSuffix = Nothing
        '
        'ConveyorSpeedValueBasicLabel
        '
        Me.ConveyorSpeedValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.ConveyorSpeedValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ConveyorSpeedValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ConveyorSpeedValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorSpeedValueBasicLabel.DisplayAsTime = False
        Me.ConveyorSpeedValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorSpeedValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorSpeedValueBasicLabel.Highlight = False
        Me.ConveyorSpeedValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ConveyorSpeedValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ConveyorSpeedValueBasicLabel.HighlightKeyCharacter = "!"
        Me.ConveyorSpeedValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConveyorSpeedValueBasicLabel.KeypadAlphaNumeric = False
        Me.ConveyorSpeedValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorSpeedValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorSpeedValueBasicLabel.KeypadMaxValue = 1000000.0R
        Me.ConveyorSpeedValueBasicLabel.KeypadMinValue = 0.0R
        Me.ConveyorSpeedValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.ConveyorSpeedValueBasicLabel.KeypadShowCurrentValue = False
        Me.ConveyorSpeedValueBasicLabel.KeypadText = Nothing
        Me.ConveyorSpeedValueBasicLabel.KeypadWidth = 400
        Me.ConveyorSpeedValueBasicLabel.Location = New System.Drawing.Point(330, 194)
        Me.ConveyorSpeedValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.ConveyorSpeedValueBasicLabel.Name = "ConveyorSpeedValueBasicLabel"
        Me.ConveyorSpeedValueBasicLabel.NumericFormat = "00.0"
        Me.ConveyorSpeedValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ConveyorSpeedValueBasicLabel.PLCAddressHighlight = "NOT Conveyor.Bits[0].0"
        Me.ConveyorSpeedValueBasicLabel.PLCAddressKeypad = "Conveyor.Parameters.Real[0]"
        Me.ConveyorSpeedValueBasicLabel.PLCAddressValue = "Conveyor.Parameters.Real[0]"
        Me.ConveyorSpeedValueBasicLabel.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.ConveyorSpeedValueBasicLabel.PollRate = 0
        Me.ConveyorSpeedValueBasicLabel.Size = New System.Drawing.Size(121, 22)
        Me.ConveyorSpeedValueBasicLabel.TabIndex = 322
        Me.ConveyorSpeedValueBasicLabel.Text = "00.0"
        Me.ConveyorSpeedValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConveyorSpeedValueBasicLabel.UseMnemonic = False
        Me.ConveyorSpeedValueBasicLabel.Value = "0.0"
        Me.ConveyorSpeedValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConveyorSpeedValueBasicLabel.ValueLeftPadLength = 0
        Me.ConveyorSpeedValueBasicLabel.ValuePrefix = Nothing
        Me.ConveyorSpeedValueBasicLabel.ValueScaleFactor = 1.0R
        Me.ConveyorSpeedValueBasicLabel.ValueSuffix = Nothing
        '
        'WashDownTimerValueBasicLabel
        '
        Me.WashDownTimerValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.WashDownTimerValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.WashDownTimerValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WashDownTimerValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.WashDownTimerValueBasicLabel.DisplayAsTime = False
        Me.WashDownTimerValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WashDownTimerValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WashDownTimerValueBasicLabel.Highlight = False
        Me.WashDownTimerValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.WashDownTimerValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.WashDownTimerValueBasicLabel.HighlightKeyCharacter = "!"
        Me.WashDownTimerValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WashDownTimerValueBasicLabel.KeypadAlphaNumeric = False
        Me.WashDownTimerValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WashDownTimerValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.WashDownTimerValueBasicLabel.KeypadMaxValue = 1000000.0R
        Me.WashDownTimerValueBasicLabel.KeypadMinValue = 0.0R
        Me.WashDownTimerValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.WashDownTimerValueBasicLabel.KeypadShowCurrentValue = False
        Me.WashDownTimerValueBasicLabel.KeypadText = Nothing
        Me.WashDownTimerValueBasicLabel.KeypadWidth = 400
        Me.WashDownTimerValueBasicLabel.Location = New System.Drawing.Point(330, 132)
        Me.WashDownTimerValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.WashDownTimerValueBasicLabel.Name = "WashDownTimerValueBasicLabel"
        Me.WashDownTimerValueBasicLabel.NumericFormat = "00"
        Me.WashDownTimerValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.WashDownTimerValueBasicLabel.PLCAddressKeypad = "WashDownTimer"
        Me.WashDownTimerValueBasicLabel.PLCAddressValue = "WashDownTimer"
        Me.WashDownTimerValueBasicLabel.PollRate = 0
        Me.WashDownTimerValueBasicLabel.Size = New System.Drawing.Size(121, 22)
        Me.WashDownTimerValueBasicLabel.TabIndex = 321
        Me.WashDownTimerValueBasicLabel.Text = "00"
        Me.WashDownTimerValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WashDownTimerValueBasicLabel.UseMnemonic = False
        Me.WashDownTimerValueBasicLabel.Value = " 0"
        Me.WashDownTimerValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WashDownTimerValueBasicLabel.ValueLeftPadLength = 0
        Me.WashDownTimerValueBasicLabel.ValuePrefix = Nothing
        Me.WashDownTimerValueBasicLabel.ValueScaleFactor = 1.0R
        Me.WashDownTimerValueBasicLabel.ValueSuffix = Nothing
        '
        'ConveyorSpeedBasicLabel
        '
        Me.ConveyorSpeedBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.ConveyorSpeedBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ConveyorSpeedBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorSpeedBasicLabel.DisplayAsTime = False
        Me.ConveyorSpeedBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorSpeedBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorSpeedBasicLabel.Highlight = False
        Me.ConveyorSpeedBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ConveyorSpeedBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ConveyorSpeedBasicLabel.HighlightKeyCharacter = "!"
        Me.ConveyorSpeedBasicLabel.KeypadAlphaNumeric = False
        Me.ConveyorSpeedBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ConveyorSpeedBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorSpeedBasicLabel.KeypadMaxValue = 0.0R
        Me.ConveyorSpeedBasicLabel.KeypadMinValue = 0.0R
        Me.ConveyorSpeedBasicLabel.KeypadScaleFactor = 1.0R
        Me.ConveyorSpeedBasicLabel.KeypadShowCurrentValue = False
        Me.ConveyorSpeedBasicLabel.KeypadText = Nothing
        Me.ConveyorSpeedBasicLabel.KeypadWidth = 300
        Me.ConveyorSpeedBasicLabel.Location = New System.Drawing.Point(144, 192)
        Me.ConveyorSpeedBasicLabel.Name = "ConveyorSpeedBasicLabel"
        Me.ConveyorSpeedBasicLabel.NumericFormat = Nothing
        Me.ConveyorSpeedBasicLabel.PLCAddressHighlight = "NOT Conveyor.Bits[0].0"
        Me.ConveyorSpeedBasicLabel.PLCAddressKeypad = ""
        Me.ConveyorSpeedBasicLabel.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.ConveyorSpeedBasicLabel.PollRate = 0
        Me.ConveyorSpeedBasicLabel.Size = New System.Drawing.Size(161, 20)
        Me.ConveyorSpeedBasicLabel.TabIndex = 311
        Me.ConveyorSpeedBasicLabel.Text = "Conveyor Speed"
        Me.ConveyorSpeedBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ConveyorSpeedBasicLabel.Value = "Conveyor Speed"
        Me.ConveyorSpeedBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConveyorSpeedBasicLabel.ValueLeftPadLength = 0
        Me.ConveyorSpeedBasicLabel.ValuePrefix = Nothing
        Me.ConveyorSpeedBasicLabel.ValueScaleFactor = 1.0R
        Me.ConveyorSpeedBasicLabel.ValueSuffix = Nothing
        '
        'WashDownTimerBasicLabel
        '
        Me.WashDownTimerBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.WashDownTimerBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.WashDownTimerBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.WashDownTimerBasicLabel.DisplayAsTime = False
        Me.WashDownTimerBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WashDownTimerBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WashDownTimerBasicLabel.Highlight = False
        Me.WashDownTimerBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.WashDownTimerBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.WashDownTimerBasicLabel.HighlightKeyCharacter = "!"
        Me.WashDownTimerBasicLabel.KeypadAlphaNumeric = False
        Me.WashDownTimerBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.WashDownTimerBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.WashDownTimerBasicLabel.KeypadMaxValue = 0.0R
        Me.WashDownTimerBasicLabel.KeypadMinValue = 0.0R
        Me.WashDownTimerBasicLabel.KeypadScaleFactor = 1.0R
        Me.WashDownTimerBasicLabel.KeypadShowCurrentValue = False
        Me.WashDownTimerBasicLabel.KeypadText = Nothing
        Me.WashDownTimerBasicLabel.KeypadWidth = 300
        Me.WashDownTimerBasicLabel.Location = New System.Drawing.Point(126, 132)
        Me.WashDownTimerBasicLabel.Name = "WashDownTimerBasicLabel"
        Me.WashDownTimerBasicLabel.NumericFormat = Nothing
        Me.WashDownTimerBasicLabel.PLCAddressKeypad = ""
        Me.WashDownTimerBasicLabel.PollRate = 0
        Me.WashDownTimerBasicLabel.Size = New System.Drawing.Size(179, 20)
        Me.WashDownTimerBasicLabel.TabIndex = 310
        Me.WashDownTimerBasicLabel.Text = "Wash Down Timer"
        Me.WashDownTimerBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.WashDownTimerBasicLabel.Value = "Wash Down Timer"
        Me.WashDownTimerBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WashDownTimerBasicLabel.ValueLeftPadLength = 0
        Me.WashDownTimerBasicLabel.ValuePrefix = Nothing
        Me.WashDownTimerBasicLabel.ValueScaleFactor = 1.0R
        Me.WashDownTimerBasicLabel.ValueSuffix = Nothing
        '
        'BottleUnderTestDetectionPressureLabel
        '
        Me.BottleUnderTestDetectionPressureLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BottleUnderTestDetectionPressureLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BottleUnderTestDetectionPressureLabel.Location = New System.Drawing.Point(36, 103)
        Me.BottleUnderTestDetectionPressureLabel.Name = "BottleUnderTestDetectionPressureLabel"
        Me.BottleUnderTestDetectionPressureLabel.Size = New System.Drawing.Size(269, 20)
        Me.BottleUnderTestDetectionPressureLabel.TabIndex = 379
        Me.BottleUnderTestDetectionPressureLabel.Text = "Bottle Under Test Detection Pressure"
        Me.BottleUnderTestDetectionPressureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BottleUnderTestDetectionPressureValueBasicLabel
        '
        Me.BottleUnderTestDetectionPressureValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.BottleUnderTestDetectionPressureValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BottleUnderTestDetectionPressureValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.BottleUnderTestDetectionPressureValueBasicLabel.DisplayAsTime = False
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Highlight = False
        Me.BottleUnderTestDetectionPressureValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.BottleUnderTestDetectionPressureValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.BottleUnderTestDetectionPressureValueBasicLabel.HighlightKeyCharacter = "!"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadAlphaNumeric = False
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadMaxValue = 1000000.0R
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadMinValue = 0.0R
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadShowCurrentValue = False
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadText = Nothing
        Me.BottleUnderTestDetectionPressureValueBasicLabel.KeypadWidth = 400
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Location = New System.Drawing.Point(330, 103)
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Name = "BottleUnderTestDetectionPressureValueBasicLabel"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.NumericFormat = "0.0"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BottleUnderTestDetectionPressureValueBasicLabel.PLCAddressKeypad = "TestSt_BottleDetect"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.PLCAddressValue = "TestSt_BottleDetect"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.PollRate = 0
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Size = New System.Drawing.Size(121, 20)
        Me.BottleUnderTestDetectionPressureValueBasicLabel.TabIndex = 380
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Text = "0.0"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BottleUnderTestDetectionPressureValueBasicLabel.UseMnemonic = False
        Me.BottleUnderTestDetectionPressureValueBasicLabel.Value = " 0.0"
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ValueLeftPadLength = 0
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ValuePrefix = Nothing
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ValueScaleFactor = 1.0R
        Me.BottleUnderTestDetectionPressureValueBasicLabel.ValueSuffix = Nothing
        '
        'BarLabel
        '
        Me.BarLabel.AutoSize = True
        Me.BarLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BarLabel.Location = New System.Drawing.Point(465, 103)
        Me.BarLabel.Name = "BarLabel"
        Me.BarLabel.Size = New System.Drawing.Size(32, 20)
        Me.BarLabel.TabIndex = 381
        Me.BarLabel.Text = "bar"
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
        Me.CurrentDateTime.Text = "30-11-2016 15:16:48"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LowBurstValueUnitsLabel
        '
        Me.LowBurstValueUnitsLabel.AutoSize = True
        Me.LowBurstValueUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.LowBurstValueUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LowBurstValueUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.LowBurstValueUnitsLabel.DisplayAsTime = False
        Me.LowBurstValueUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowBurstValueUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueUnitsLabel.Highlight = False
        Me.LowBurstValueUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.LowBurstValueUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.LowBurstValueUnitsLabel.HighlightKeyCharacter = "!"
        Me.LowBurstValueUnitsLabel.KeypadAlphaNumeric = False
        Me.LowBurstValueUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LowBurstValueUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueUnitsLabel.KeypadMaxValue = 0.0R
        Me.LowBurstValueUnitsLabel.KeypadMinValue = 0.0R
        Me.LowBurstValueUnitsLabel.KeypadScaleFactor = 1.0R
        Me.LowBurstValueUnitsLabel.KeypadShowCurrentValue = False
        Me.LowBurstValueUnitsLabel.KeypadText = Nothing
        Me.LowBurstValueUnitsLabel.KeypadWidth = 300
        Me.LowBurstValueUnitsLabel.Location = New System.Drawing.Point(465, 226)
        Me.LowBurstValueUnitsLabel.Name = "LowBurstValueUnitsLabel"
        Me.LowBurstValueUnitsLabel.NumericFormat = Nothing
        Me.LowBurstValueUnitsLabel.PLCAddressKeypad = ""
        Me.LowBurstValueUnitsLabel.PollRate = 0
        Me.LowBurstValueUnitsLabel.Size = New System.Drawing.Size(65, 20)
        Me.LowBurstValueUnitsLabel.TabIndex = 413
        Me.LowBurstValueUnitsLabel.Text = "Seconds"
        Me.LowBurstValueUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LowBurstValueUnitsLabel.Value = "Seconds"
        Me.LowBurstValueUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LowBurstValueUnitsLabel.ValueLeftPadLength = 0
        Me.LowBurstValueUnitsLabel.ValuePrefix = Nothing
        Me.LowBurstValueUnitsLabel.ValueScaleFactor = 1.0R
        Me.LowBurstValueUnitsLabel.ValueSuffix = Nothing
        '
        'BasicLabel2
        '
        Me.BasicLabel2.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 1000000.0R
        Me.BasicLabel2.KeypadMinValue = 0.0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 400
        Me.BasicLabel2.Location = New System.Drawing.Point(330, 225)
        Me.BasicLabel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = "00"
        Me.BasicLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel2.PLCAddressKeypad = "LBVTimeout"
        Me.BasicLabel2.PLCAddressValue = "LBVTimeout"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel2.TabIndex = 412
        Me.BasicLabel2.Text = "00"
        Me.BasicLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel2.UseMnemonic = False
        Me.BasicLabel2.Value = " 0"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'LowBurstValueTimeoutLabel
        '
        Me.LowBurstValueTimeoutLabel.BackColor = System.Drawing.Color.Gray
        Me.LowBurstValueTimeoutLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LowBurstValueTimeoutLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.LowBurstValueTimeoutLabel.DisplayAsTime = False
        Me.LowBurstValueTimeoutLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowBurstValueTimeoutLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueTimeoutLabel.Highlight = False
        Me.LowBurstValueTimeoutLabel.HighlightColor = System.Drawing.Color.Gray
        Me.LowBurstValueTimeoutLabel.HighlightForeColor = System.Drawing.Color.White
        Me.LowBurstValueTimeoutLabel.HighlightKeyCharacter = "!"
        Me.LowBurstValueTimeoutLabel.KeypadAlphaNumeric = False
        Me.LowBurstValueTimeoutLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LowBurstValueTimeoutLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LowBurstValueTimeoutLabel.KeypadMaxValue = 0.0R
        Me.LowBurstValueTimeoutLabel.KeypadMinValue = 0.0R
        Me.LowBurstValueTimeoutLabel.KeypadScaleFactor = 1.0R
        Me.LowBurstValueTimeoutLabel.KeypadShowCurrentValue = False
        Me.LowBurstValueTimeoutLabel.KeypadText = Nothing
        Me.LowBurstValueTimeoutLabel.KeypadWidth = 300
        Me.LowBurstValueTimeoutLabel.Location = New System.Drawing.Point(112, 222)
        Me.LowBurstValueTimeoutLabel.Name = "LowBurstValueTimeoutLabel"
        Me.LowBurstValueTimeoutLabel.NumericFormat = Nothing
        Me.LowBurstValueTimeoutLabel.PLCAddressKeypad = ""
        Me.LowBurstValueTimeoutLabel.PollRate = 0
        Me.LowBurstValueTimeoutLabel.Size = New System.Drawing.Size(193, 20)
        Me.LowBurstValueTimeoutLabel.TabIndex = 411
        Me.LowBurstValueTimeoutLabel.Text = "Low Burst Value Timeout"
        Me.LowBurstValueTimeoutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LowBurstValueTimeoutLabel.Value = "Low Burst Value Timeout"
        Me.LowBurstValueTimeoutLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LowBurstValueTimeoutLabel.ValueLeftPadLength = 0
        Me.LowBurstValueTimeoutLabel.ValuePrefix = Nothing
        Me.LowBurstValueTimeoutLabel.ValueScaleFactor = 1.0R
        Me.LowBurstValueTimeoutLabel.ValueSuffix = Nothing
        '
        'CulletBinUsageSettingLabel
        '
        Me.CulletBinUsageSettingLabel.BackColor = System.Drawing.Color.Gray
        Me.CulletBinUsageSettingLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.CulletBinUsageSettingLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.CulletBinUsageSettingLabel.DisplayAsTime = False
        Me.CulletBinUsageSettingLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CulletBinUsageSettingLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CulletBinUsageSettingLabel.Highlight = False
        Me.CulletBinUsageSettingLabel.HighlightColor = System.Drawing.Color.Gray
        Me.CulletBinUsageSettingLabel.HighlightForeColor = System.Drawing.Color.White
        Me.CulletBinUsageSettingLabel.HighlightKeyCharacter = "!"
        Me.CulletBinUsageSettingLabel.KeypadAlphaNumeric = False
        Me.CulletBinUsageSettingLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.CulletBinUsageSettingLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CulletBinUsageSettingLabel.KeypadMaxValue = 0.0R
        Me.CulletBinUsageSettingLabel.KeypadMinValue = 0.0R
        Me.CulletBinUsageSettingLabel.KeypadScaleFactor = 1.0R
        Me.CulletBinUsageSettingLabel.KeypadShowCurrentValue = False
        Me.CulletBinUsageSettingLabel.KeypadText = Nothing
        Me.CulletBinUsageSettingLabel.KeypadWidth = 300
        Me.CulletBinUsageSettingLabel.Location = New System.Drawing.Point(171, 367)
        Me.CulletBinUsageSettingLabel.Name = "CulletBinUsageSettingLabel"
        Me.CulletBinUsageSettingLabel.NumericFormat = Nothing
        Me.CulletBinUsageSettingLabel.PLCAddressKeypad = ""
        Me.CulletBinUsageSettingLabel.PollRate = 0
        Me.CulletBinUsageSettingLabel.Size = New System.Drawing.Size(134, 20)
        Me.CulletBinUsageSettingLabel.TabIndex = 414
        Me.CulletBinUsageSettingLabel.Text = "Cullet Bin Usage"
        Me.CulletBinUsageSettingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CulletBinUsageSettingLabel.Value = "Cullet Bin Usage"
        Me.CulletBinUsageSettingLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CulletBinUsageSettingLabel.ValueLeftPadLength = 0
        Me.CulletBinUsageSettingLabel.ValuePrefix = Nothing
        Me.CulletBinUsageSettingLabel.ValueScaleFactor = 1.0R
        Me.CulletBinUsageSettingLabel.ValueSuffix = Nothing
        '
        'CulletBinDisabledButton
        '
        Me.CulletBinDisabledButton.BackColor = System.Drawing.SystemColors.Control
        Me.CulletBinDisabledButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CulletBinDisabledButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CulletBinDisabledButton.ForeColor = System.Drawing.Color.Black
        Me.CulletBinDisabledButton.Highlight = False
        Me.CulletBinDisabledButton.HighlightColor = System.Drawing.Color.Green
        Me.CulletBinDisabledButton.Location = New System.Drawing.Point(394, 361)
        Me.CulletBinDisabledButton.MaximumHoldTime = 3000
        Me.CulletBinDisabledButton.MinimumHoldTime = 500
        Me.CulletBinDisabledButton.Name = "CulletBinDisabledButton"
        Me.CulletBinDisabledButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetFalse
        Me.CulletBinDisabledButton.PLCAddressClick = "TestStation.Bits[0].1"
        Me.CulletBinDisabledButton.SelectTextAlternate = False
        Me.CulletBinDisabledButton.Size = New System.Drawing.Size(70, 32)
        Me.CulletBinDisabledButton.TabIndex = 416
        Me.CulletBinDisabledButton.Text = "Off"
        Me.CulletBinDisabledButton.TextAlternate = Nothing
        Me.CulletBinDisabledButton.UseVisualStyleBackColor = True
        Me.CulletBinDisabledButton.ValueToWrite = 4
        '
        'CulletBinEnabledButton
        '
        Me.CulletBinEnabledButton.BackColor = System.Drawing.SystemColors.Control
        Me.CulletBinEnabledButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.CulletBinEnabledButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CulletBinEnabledButton.ForeColor = System.Drawing.Color.Black
        Me.CulletBinEnabledButton.Highlight = False
        Me.CulletBinEnabledButton.HighlightColor = System.Drawing.Color.Green
        Me.CulletBinEnabledButton.Location = New System.Drawing.Point(318, 361)
        Me.CulletBinEnabledButton.MaximumHoldTime = 3000
        Me.CulletBinEnabledButton.MinimumHoldTime = 500
        Me.CulletBinEnabledButton.Name = "CulletBinEnabledButton"
        Me.CulletBinEnabledButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.CulletBinEnabledButton.PLCAddressClick = "TestStation.Bits[0].1"
        Me.CulletBinEnabledButton.SelectTextAlternate = False
        Me.CulletBinEnabledButton.Size = New System.Drawing.Size(70, 32)
        Me.CulletBinEnabledButton.TabIndex = 415
        Me.CulletBinEnabledButton.Text = "On"
        Me.CulletBinEnabledButton.TextAlternate = Nothing
        Me.CulletBinEnabledButton.UseVisualStyleBackColor = True
        Me.CulletBinEnabledButton.ValueToWrite = 3
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Location = New System.Drawing.Point(316, 359)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "TestStation.Bits[0].1"
        Me.BasicIndicator1.SelectColor2 = True
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator1.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator1.TabIndex = 417
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Location = New System.Drawing.Point(392, 359)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "NOT TestStation.Bits[0].1"
        Me.BasicIndicator2.SelectColor2 = True
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator2.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator2.TabIndex = 418
        '
        'ConveyorToPickDistanceLabel
        '
        Me.ConveyorToPickDistanceLabel.BackColor = System.Drawing.Color.Gray
        Me.ConveyorToPickDistanceLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ConveyorToPickDistanceLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorToPickDistanceLabel.DisplayAsTime = False
        Me.ConveyorToPickDistanceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorToPickDistanceLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorToPickDistanceLabel.Highlight = False
        Me.ConveyorToPickDistanceLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ConveyorToPickDistanceLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ConveyorToPickDistanceLabel.HighlightKeyCharacter = "!"
        Me.ConveyorToPickDistanceLabel.KeypadAlphaNumeric = False
        Me.ConveyorToPickDistanceLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ConveyorToPickDistanceLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorToPickDistanceLabel.KeypadMaxValue = 0.0R
        Me.ConveyorToPickDistanceLabel.KeypadMinValue = 0.0R
        Me.ConveyorToPickDistanceLabel.KeypadScaleFactor = 1.0R
        Me.ConveyorToPickDistanceLabel.KeypadShowCurrentValue = False
        Me.ConveyorToPickDistanceLabel.KeypadText = Nothing
        Me.ConveyorToPickDistanceLabel.KeypadWidth = 300
        Me.ConveyorToPickDistanceLabel.Location = New System.Drawing.Point(112, 291)
        Me.ConveyorToPickDistanceLabel.Name = "ConveyorToPickDistanceLabel"
        Me.ConveyorToPickDistanceLabel.NumericFormat = Nothing
        Me.ConveyorToPickDistanceLabel.PLCAddressKeypad = ""
        Me.ConveyorToPickDistanceLabel.PollRate = 0
        Me.ConveyorToPickDistanceLabel.Size = New System.Drawing.Size(193, 20)
        Me.ConveyorToPickDistanceLabel.TabIndex = 419
        Me.ConveyorToPickDistanceLabel.Text = "Conveyor to Pick Distance"
        Me.ConveyorToPickDistanceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ConveyorToPickDistanceLabel.Value = "Conveyor to Pick Distance"
        Me.ConveyorToPickDistanceLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConveyorToPickDistanceLabel.ValueLeftPadLength = 0
        Me.ConveyorToPickDistanceLabel.ValuePrefix = Nothing
        Me.ConveyorToPickDistanceLabel.ValueScaleFactor = 1.0R
        Me.ConveyorToPickDistanceLabel.ValueSuffix = Nothing
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 1000000.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 400
        Me.BasicLabel1.Location = New System.Drawing.Point(330, 287)
        Me.BasicLabel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "00"
        Me.BasicLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel1.PLCAddressKeypad = "ConveyorDistance"
        Me.BasicLabel1.PLCAddressValue = "ConveyorDistance"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel1.TabIndex = 420
        Me.BasicLabel1.Text = "00"
        Me.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel1.UseMnemonic = False
        Me.BasicLabel1.Value = " 0"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'ConveyorToPickDistanceUnitsLabel
        '
        Me.ConveyorToPickDistanceUnitsLabel.AutoSize = True
        Me.ConveyorToPickDistanceUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.ConveyorToPickDistanceUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ConveyorToPickDistanceUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorToPickDistanceUnitsLabel.DisplayAsTime = False
        Me.ConveyorToPickDistanceUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorToPickDistanceUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorToPickDistanceUnitsLabel.Highlight = False
        Me.ConveyorToPickDistanceUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ConveyorToPickDistanceUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ConveyorToPickDistanceUnitsLabel.HighlightKeyCharacter = "!"
        Me.ConveyorToPickDistanceUnitsLabel.KeypadAlphaNumeric = False
        Me.ConveyorToPickDistanceUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ConveyorToPickDistanceUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ConveyorToPickDistanceUnitsLabel.KeypadMaxValue = 0.0R
        Me.ConveyorToPickDistanceUnitsLabel.KeypadMinValue = 0.0R
        Me.ConveyorToPickDistanceUnitsLabel.KeypadScaleFactor = 1.0R
        Me.ConveyorToPickDistanceUnitsLabel.KeypadShowCurrentValue = False
        Me.ConveyorToPickDistanceUnitsLabel.KeypadText = Nothing
        Me.ConveyorToPickDistanceUnitsLabel.KeypadWidth = 300
        Me.ConveyorToPickDistanceUnitsLabel.Location = New System.Drawing.Point(465, 288)
        Me.ConveyorToPickDistanceUnitsLabel.Name = "ConveyorToPickDistanceUnitsLabel"
        Me.ConveyorToPickDistanceUnitsLabel.NumericFormat = Nothing
        Me.ConveyorToPickDistanceUnitsLabel.PLCAddressKeypad = ""
        Me.ConveyorToPickDistanceUnitsLabel.PollRate = 0
        Me.ConveyorToPickDistanceUnitsLabel.Size = New System.Drawing.Size(22, 20)
        Me.ConveyorToPickDistanceUnitsLabel.TabIndex = 421
        Me.ConveyorToPickDistanceUnitsLabel.Text = "m"
        Me.ConveyorToPickDistanceUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ConveyorToPickDistanceUnitsLabel.Value = "m"
        Me.ConveyorToPickDistanceUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConveyorToPickDistanceUnitsLabel.ValueLeftPadLength = 0
        Me.ConveyorToPickDistanceUnitsLabel.ValuePrefix = Nothing
        Me.ConveyorToPickDistanceUnitsLabel.ValueScaleFactor = 1.0R
        Me.ConveyorToPickDistanceUnitsLabel.ValueSuffix = Nothing
        '
        'DisableConveyorButton
        '
        Me.DisableConveyorButton.BackColor = System.Drawing.SystemColors.Control
        Me.DisableConveyorButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.DisableConveyorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableConveyorButton.ForeColor = System.Drawing.Color.Black
        Me.DisableConveyorButton.Highlight = False
        Me.DisableConveyorButton.HighlightColor = System.Drawing.Color.Green
        Me.DisableConveyorButton.Location = New System.Drawing.Point(395, 319)
        Me.DisableConveyorButton.MaximumHoldTime = 3000
        Me.DisableConveyorButton.MinimumHoldTime = 500
        Me.DisableConveyorButton.Name = "DisableConveyorButton"
        Me.DisableConveyorButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetFalse
        Me.DisableConveyorButton.PLCAddressClick = "Conveyor.Bits[0].0"
        Me.DisableConveyorButton.SelectTextAlternate = False
        Me.DisableConveyorButton.Size = New System.Drawing.Size(70, 32)
        Me.DisableConveyorButton.TabIndex = 424
        Me.DisableConveyorButton.Text = "Local"
        Me.DisableConveyorButton.TextAlternate = Nothing
        Me.DisableConveyorButton.UseVisualStyleBackColor = True
        Me.DisableConveyorButton.ValueToWrite = 4
        '
        'ConveyorEnabledButton
        '
        Me.ConveyorEnabledButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConveyorEnabledButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ConveyorEnabledButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorEnabledButton.ForeColor = System.Drawing.Color.Black
        Me.ConveyorEnabledButton.Highlight = False
        Me.ConveyorEnabledButton.HighlightColor = System.Drawing.Color.Green
        Me.ConveyorEnabledButton.Location = New System.Drawing.Point(319, 319)
        Me.ConveyorEnabledButton.MaximumHoldTime = 3000
        Me.ConveyorEnabledButton.MinimumHoldTime = 500
        Me.ConveyorEnabledButton.Name = "ConveyorEnabledButton"
        Me.ConveyorEnabledButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.ConveyorEnabledButton.PLCAddressClick = "Conveyor.Bits[0].0"
        Me.ConveyorEnabledButton.SelectTextAlternate = False
        Me.ConveyorEnabledButton.Size = New System.Drawing.Size(70, 32)
        Me.ConveyorEnabledButton.TabIndex = 423
        Me.ConveyorEnabledButton.Text = "Remote"
        Me.ConveyorEnabledButton.TextAlternate = Nothing
        Me.ConveyorEnabledButton.UseVisualStyleBackColor = True
        Me.ConveyorEnabledButton.ValueToWrite = 3
        '
        'BasicIndicator
        '
        Me.BasicIndicator.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator.Location = New System.Drawing.Point(317, 317)
        Me.BasicIndicator.Name = "BasicIndicator"
        Me.BasicIndicator.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator.OutlineWidth = 1
        Me.BasicIndicator.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator.PLCAddressSelectColor2 = "Conveyor.Bits[0].0"
        Me.BasicIndicator.SelectColor2 = True
        Me.BasicIndicator.SelectColor3 = False
        Me.BasicIndicator.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator.TabIndex = 425
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(393, 317)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator4.SelectColor2 = True
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator4.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator4.TabIndex = 426
        '
        'EnableConveyorLabel
        '
        Me.EnableConveyorLabel.BackColor = System.Drawing.Color.Gray
        Me.EnableConveyorLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.EnableConveyorLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.EnableConveyorLabel.DisplayAsTime = False
        Me.EnableConveyorLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableConveyorLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EnableConveyorLabel.Highlight = False
        Me.EnableConveyorLabel.HighlightColor = System.Drawing.Color.Gray
        Me.EnableConveyorLabel.HighlightForeColor = System.Drawing.Color.White
        Me.EnableConveyorLabel.HighlightKeyCharacter = "!"
        Me.EnableConveyorLabel.KeypadAlphaNumeric = False
        Me.EnableConveyorLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.EnableConveyorLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.EnableConveyorLabel.KeypadMaxValue = 0.0R
        Me.EnableConveyorLabel.KeypadMinValue = 0.0R
        Me.EnableConveyorLabel.KeypadScaleFactor = 1.0R
        Me.EnableConveyorLabel.KeypadShowCurrentValue = False
        Me.EnableConveyorLabel.KeypadText = Nothing
        Me.EnableConveyorLabel.KeypadWidth = 300
        Me.EnableConveyorLabel.Location = New System.Drawing.Point(166, 325)
        Me.EnableConveyorLabel.Name = "EnableConveyorLabel"
        Me.EnableConveyorLabel.NumericFormat = Nothing
        Me.EnableConveyorLabel.PLCAddressKeypad = ""
        Me.EnableConveyorLabel.PollRate = 0
        Me.EnableConveyorLabel.Size = New System.Drawing.Size(139, 20)
        Me.EnableConveyorLabel.TabIndex = 422
        Me.EnableConveyorLabel.Text = "Enable Conveyor"
        Me.EnableConveyorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.EnableConveyorLabel.Value = "Enable Conveyor"
        Me.EnableConveyorLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EnableConveyorLabel.ValueLeftPadLength = 0
        Me.EnableConveyorLabel.ValuePrefix = Nothing
        Me.EnableConveyorLabel.ValueScaleFactor = 1.0R
        Me.EnableConveyorLabel.ValueSuffix = Nothing
        '
        'RemoteConnectionPortNumberLabel
        '
        Me.RemoteConnectionPortNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RemoteConnectionPortNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteConnectionPortNumberLabel.Location = New System.Drawing.Point(55, 434)
        Me.RemoteConnectionPortNumberLabel.Name = "RemoteConnectionPortNumberLabel"
        Me.RemoteConnectionPortNumberLabel.Size = New System.Drawing.Size(250, 20)
        Me.RemoteConnectionPortNumberLabel.TabIndex = 427
        Me.RemoteConnectionPortNumberLabel.Text = "Remote Connections Port Number"
        Me.RemoteConnectionPortNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel3
        '
        Me.BasicLabel3.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 1000000.0R
        Me.BasicLabel3.KeypadMinValue = 0.0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 400
        Me.BasicLabel3.Location = New System.Drawing.Point(330, 434)
        Me.BasicLabel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = "00"
        Me.BasicLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel3.PLCAddressKeypad = "RemoteConnectionPort"
        Me.BasicLabel3.PLCAddressValue = "RemoteConnectionPort"
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel3.TabIndex = 428
        Me.BasicLabel3.Text = "11001"
        Me.BasicLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel3.UseMnemonic = False
        Me.BasicLabel3.Value = "11001"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        '
        'RemoteConnectionsIPAddressLabel
        '
        Me.RemoteConnectionsIPAddressLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RemoteConnectionsIPAddressLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteConnectionsIPAddressLabel.Location = New System.Drawing.Point(78, 468)
        Me.RemoteConnectionsIPAddressLabel.Name = "RemoteConnectionsIPAddressLabel"
        Me.RemoteConnectionsIPAddressLabel.Size = New System.Drawing.Size(227, 20)
        Me.RemoteConnectionsIPAddressLabel.TabIndex = 429
        Me.RemoteConnectionsIPAddressLabel.Text = "Remote Connections IP Address"
        Me.RemoteConnectionsIPAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RemoteIPAddressTextBox
        '
        Me.RemoteIPAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteIPAddressTextBox.Location = New System.Drawing.Point(330, 464)
        Me.RemoteIPAddressTextBox.Name = "RemoteIPAddressTextBox"
        Me.RemoteIPAddressTextBox.Size = New System.Drawing.Size(121, 23)
        Me.RemoteIPAddressTextBox.TabIndex = 430
        Me.RemoteIPAddressTextBox.Text = "192.168.40.1"
        '
        'SetIPAddressButton
        '
        Me.SetIPAddressButton.BackColor = System.Drawing.SystemColors.Control
        Me.SetIPAddressButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SetIPAddressButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetIPAddressButton.ForeColor = System.Drawing.Color.Black
        Me.SetIPAddressButton.Highlight = False
        Me.SetIPAddressButton.HighlightColor = System.Drawing.Color.Green
        Me.SetIPAddressButton.Location = New System.Drawing.Point(471, 464)
        Me.SetIPAddressButton.MaximumHoldTime = 3000
        Me.SetIPAddressButton.MinimumHoldTime = 500
        Me.SetIPAddressButton.Name = "SetIPAddressButton"
        Me.SetIPAddressButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.SetIPAddressButton.PLCAddressClick = ""
        Me.SetIPAddressButton.SelectTextAlternate = False
        Me.SetIPAddressButton.Size = New System.Drawing.Size(70, 25)
        Me.SetIPAddressButton.TabIndex = 431
        Me.SetIPAddressButton.Text = "Set"
        Me.SetIPAddressButton.TextAlternate = Nothing
        Me.SetIPAddressButton.UseVisualStyleBackColor = True
        Me.SetIPAddressButton.ValueToWrite = 3
        '
        'PickUpClampsCloseDelayUnitsLabel
        '
        Me.PickUpClampsCloseDelayUnitsLabel.AutoSize = True
        Me.PickUpClampsCloseDelayUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.PickUpClampsCloseDelayUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PickUpClampsCloseDelayUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PickUpClampsCloseDelayUnitsLabel.DisplayAsTime = False
        Me.PickUpClampsCloseDelayUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUpClampsCloseDelayUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUpClampsCloseDelayUnitsLabel.Highlight = False
        Me.PickUpClampsCloseDelayUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PickUpClampsCloseDelayUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PickUpClampsCloseDelayUnitsLabel.HighlightKeyCharacter = "!"
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadAlphaNumeric = False
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadMaxValue = 0.0R
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadMinValue = 0.0R
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadScaleFactor = 1.0R
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadShowCurrentValue = False
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadText = Nothing
        Me.PickUpClampsCloseDelayUnitsLabel.KeypadWidth = 300
        Me.PickUpClampsCloseDelayUnitsLabel.Location = New System.Drawing.Point(465, 257)
        Me.PickUpClampsCloseDelayUnitsLabel.Name = "PickUpClampsCloseDelayUnitsLabel"
        Me.PickUpClampsCloseDelayUnitsLabel.NumericFormat = Nothing
        Me.PickUpClampsCloseDelayUnitsLabel.PLCAddressKeypad = ""
        Me.PickUpClampsCloseDelayUnitsLabel.PollRate = 0
        Me.PickUpClampsCloseDelayUnitsLabel.Size = New System.Drawing.Size(65, 20)
        Me.PickUpClampsCloseDelayUnitsLabel.TabIndex = 434
        Me.PickUpClampsCloseDelayUnitsLabel.Text = "Seconds"
        Me.PickUpClampsCloseDelayUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.PickUpClampsCloseDelayUnitsLabel.Value = "Seconds"
        Me.PickUpClampsCloseDelayUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PickUpClampsCloseDelayUnitsLabel.ValueLeftPadLength = 0
        Me.PickUpClampsCloseDelayUnitsLabel.ValuePrefix = Nothing
        Me.PickUpClampsCloseDelayUnitsLabel.ValueScaleFactor = 1.0R
        Me.PickUpClampsCloseDelayUnitsLabel.ValueSuffix = Nothing
        '
        'BasicLabel5
        '
        Me.BasicLabel5.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel5.KeypadAlphaNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 1000000.0R
        Me.BasicLabel5.KeypadMinValue = 0.0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 400
        Me.BasicLabel5.Location = New System.Drawing.Point(330, 256)
        Me.BasicLabel5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = "00"
        Me.BasicLabel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel5.PLCAddressKeypad = "LoadStation.Parameters.Real[0]"
        Me.BasicLabel5.PLCAddressValue = "LoadStation.Parameters.Real[0]"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel5.TabIndex = 433
        Me.BasicLabel5.Text = "00"
        Me.BasicLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel5.UseMnemonic = False
        Me.BasicLabel5.Value = " 0"
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        '
        'PickUpClampsCloseDelayBasicLabel
        '
        Me.PickUpClampsCloseDelayBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PickUpClampsCloseDelayBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PickUpClampsCloseDelayBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PickUpClampsCloseDelayBasicLabel.DisplayAsTime = False
        Me.PickUpClampsCloseDelayBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUpClampsCloseDelayBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUpClampsCloseDelayBasicLabel.Highlight = False
        Me.PickUpClampsCloseDelayBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PickUpClampsCloseDelayBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PickUpClampsCloseDelayBasicLabel.HighlightKeyCharacter = "!"
        Me.PickUpClampsCloseDelayBasicLabel.KeypadAlphaNumeric = False
        Me.PickUpClampsCloseDelayBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PickUpClampsCloseDelayBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PickUpClampsCloseDelayBasicLabel.KeypadMaxValue = 0.0R
        Me.PickUpClampsCloseDelayBasicLabel.KeypadMinValue = 0.0R
        Me.PickUpClampsCloseDelayBasicLabel.KeypadScaleFactor = 1.0R
        Me.PickUpClampsCloseDelayBasicLabel.KeypadShowCurrentValue = False
        Me.PickUpClampsCloseDelayBasicLabel.KeypadText = Nothing
        Me.PickUpClampsCloseDelayBasicLabel.KeypadWidth = 300
        Me.PickUpClampsCloseDelayBasicLabel.Location = New System.Drawing.Point(95, 258)
        Me.PickUpClampsCloseDelayBasicLabel.Name = "PickUpClampsCloseDelayBasicLabel"
        Me.PickUpClampsCloseDelayBasicLabel.NumericFormat = Nothing
        Me.PickUpClampsCloseDelayBasicLabel.PLCAddressKeypad = ""
        Me.PickUpClampsCloseDelayBasicLabel.PollRate = 0
        Me.PickUpClampsCloseDelayBasicLabel.Size = New System.Drawing.Size(210, 20)
        Me.PickUpClampsCloseDelayBasicLabel.TabIndex = 432
        Me.PickUpClampsCloseDelayBasicLabel.Text = "Pick Up Clamps Close Delay"
        Me.PickUpClampsCloseDelayBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.PickUpClampsCloseDelayBasicLabel.Value = "Pick Up Clamps Close Delay"
        Me.PickUpClampsCloseDelayBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PickUpClampsCloseDelayBasicLabel.ValueLeftPadLength = 0
        Me.PickUpClampsCloseDelayBasicLabel.ValuePrefix = Nothing
        Me.PickUpClampsCloseDelayBasicLabel.ValueScaleFactor = 1.0R
        Me.PickUpClampsCloseDelayBasicLabel.ValueSuffix = Nothing
        '
        'DisableRemoteCommunicationsButton
        '
        Me.DisableRemoteCommunicationsButton.BackColor = System.Drawing.SystemColors.Control
        Me.DisableRemoteCommunicationsButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.DisableRemoteCommunicationsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableRemoteCommunicationsButton.ForeColor = System.Drawing.Color.Black
        Me.DisableRemoteCommunicationsButton.Highlight = False
        Me.DisableRemoteCommunicationsButton.HighlightColor = System.Drawing.Color.Green
        Me.DisableRemoteCommunicationsButton.Location = New System.Drawing.Point(393, 523)
        Me.DisableRemoteCommunicationsButton.MaximumHoldTime = 3000
        Me.DisableRemoteCommunicationsButton.MinimumHoldTime = 500
        Me.DisableRemoteCommunicationsButton.Name = "DisableRemoteCommunicationsButton"
        Me.DisableRemoteCommunicationsButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetFalse
        Me.DisableRemoteCommunicationsButton.PLCAddressClick = "RemoteConnectionEnable"
        Me.DisableRemoteCommunicationsButton.SelectTextAlternate = False
        Me.DisableRemoteCommunicationsButton.Size = New System.Drawing.Size(70, 32)
        Me.DisableRemoteCommunicationsButton.TabIndex = 437
        Me.DisableRemoteCommunicationsButton.Text = "No"
        Me.DisableRemoteCommunicationsButton.TextAlternate = Nothing
        Me.DisableRemoteCommunicationsButton.UseVisualStyleBackColor = True
        Me.DisableRemoteCommunicationsButton.ValueToWrite = 4
        '
        'EnableRemoteCommunicationsButton
        '
        Me.EnableRemoteCommunicationsButton.BackColor = System.Drawing.SystemColors.Control
        Me.EnableRemoteCommunicationsButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.EnableRemoteCommunicationsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableRemoteCommunicationsButton.ForeColor = System.Drawing.Color.Black
        Me.EnableRemoteCommunicationsButton.Highlight = False
        Me.EnableRemoteCommunicationsButton.HighlightColor = System.Drawing.Color.Green
        Me.EnableRemoteCommunicationsButton.Location = New System.Drawing.Point(317, 523)
        Me.EnableRemoteCommunicationsButton.MaximumHoldTime = 3000
        Me.EnableRemoteCommunicationsButton.MinimumHoldTime = 500
        Me.EnableRemoteCommunicationsButton.Name = "EnableRemoteCommunicationsButton"
        Me.EnableRemoteCommunicationsButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.EnableRemoteCommunicationsButton.PLCAddressClick = "RemoteConnectionEnable"
        Me.EnableRemoteCommunicationsButton.SelectTextAlternate = False
        Me.EnableRemoteCommunicationsButton.Size = New System.Drawing.Size(70, 32)
        Me.EnableRemoteCommunicationsButton.TabIndex = 436
        Me.EnableRemoteCommunicationsButton.Text = "Yes"
        Me.EnableRemoteCommunicationsButton.TextAlternate = Nothing
        Me.EnableRemoteCommunicationsButton.UseVisualStyleBackColor = True
        Me.EnableRemoteCommunicationsButton.ValueToWrite = 3
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator3.Location = New System.Drawing.Point(315, 521)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor2 = "RemoteConnectionEnable"
        Me.BasicIndicator3.SelectColor2 = True
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator3.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator3.TabIndex = 438
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator5.Location = New System.Drawing.Point(391, 521)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "NOT RemoteConnectionEnable"
        Me.BasicIndicator5.SelectColor2 = True
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator5.Size = New System.Drawing.Size(74, 36)
        Me.BasicIndicator5.TabIndex = 439
        '
        'RemoteCommunicationsEnabledLabel
        '
        Me.RemoteCommunicationsEnabledLabel.BackColor = System.Drawing.Color.Gray
        Me.RemoteCommunicationsEnabledLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RemoteCommunicationsEnabledLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemoteCommunicationsEnabledLabel.DisplayAsTime = False
        Me.RemoteCommunicationsEnabledLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteCommunicationsEnabledLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommunicationsEnabledLabel.Highlight = False
        Me.RemoteCommunicationsEnabledLabel.HighlightColor = System.Drawing.Color.Gray
        Me.RemoteCommunicationsEnabledLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RemoteCommunicationsEnabledLabel.HighlightKeyCharacter = "!"
        Me.RemoteCommunicationsEnabledLabel.KeypadAlphaNumeric = False
        Me.RemoteCommunicationsEnabledLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RemoteCommunicationsEnabledLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommunicationsEnabledLabel.KeypadMaxValue = 0.0R
        Me.RemoteCommunicationsEnabledLabel.KeypadMinValue = 0.0R
        Me.RemoteCommunicationsEnabledLabel.KeypadScaleFactor = 1.0R
        Me.RemoteCommunicationsEnabledLabel.KeypadShowCurrentValue = False
        Me.RemoteCommunicationsEnabledLabel.KeypadText = Nothing
        Me.RemoteCommunicationsEnabledLabel.KeypadWidth = 300
        Me.RemoteCommunicationsEnabledLabel.Location = New System.Drawing.Point(42, 528)
        Me.RemoteCommunicationsEnabledLabel.Name = "RemoteCommunicationsEnabledLabel"
        Me.RemoteCommunicationsEnabledLabel.NumericFormat = Nothing
        Me.RemoteCommunicationsEnabledLabel.PLCAddressKeypad = ""
        Me.RemoteCommunicationsEnabledLabel.PollRate = 0
        Me.RemoteCommunicationsEnabledLabel.Size = New System.Drawing.Size(263, 20)
        Me.RemoteCommunicationsEnabledLabel.TabIndex = 435
        Me.RemoteCommunicationsEnabledLabel.Text = "Remote Communications Enabled"
        Me.RemoteCommunicationsEnabledLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.RemoteCommunicationsEnabledLabel.Value = "Remote Communications Enabled"
        Me.RemoteCommunicationsEnabledLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemoteCommunicationsEnabledLabel.ValueLeftPadLength = 0
        Me.RemoteCommunicationsEnabledLabel.ValuePrefix = Nothing
        Me.RemoteCommunicationsEnabledLabel.ValueScaleFactor = 1.0R
        Me.RemoteCommunicationsEnabledLabel.ValueSuffix = Nothing
        '
        'RemoteCommsDefaultMouldNumber
        '
        Me.RemoteCommsDefaultMouldNumber.BackColor = System.Drawing.Color.Gray
        Me.RemoteCommsDefaultMouldNumber.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RemoteCommsDefaultMouldNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RemoteCommsDefaultMouldNumber.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemoteCommsDefaultMouldNumber.DisplayAsTime = False
        Me.RemoteCommsDefaultMouldNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteCommsDefaultMouldNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommsDefaultMouldNumber.Highlight = False
        Me.RemoteCommsDefaultMouldNumber.HighlightColor = System.Drawing.Color.Gray
        Me.RemoteCommsDefaultMouldNumber.HighlightForeColor = System.Drawing.Color.White
        Me.RemoteCommsDefaultMouldNumber.HighlightKeyCharacter = "!"
        Me.RemoteCommsDefaultMouldNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoteCommsDefaultMouldNumber.KeypadAlphaNumeric = False
        Me.RemoteCommsDefaultMouldNumber.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteCommsDefaultMouldNumber.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommsDefaultMouldNumber.KeypadMaxValue = 1000000.0R
        Me.RemoteCommsDefaultMouldNumber.KeypadMinValue = 0.0R
        Me.RemoteCommsDefaultMouldNumber.KeypadScaleFactor = 1.0R
        Me.RemoteCommsDefaultMouldNumber.KeypadShowCurrentValue = False
        Me.RemoteCommsDefaultMouldNumber.KeypadText = Nothing
        Me.RemoteCommsDefaultMouldNumber.KeypadWidth = 400
        Me.RemoteCommsDefaultMouldNumber.Location = New System.Drawing.Point(330, 564)
        Me.RemoteCommsDefaultMouldNumber.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.RemoteCommsDefaultMouldNumber.Name = "RemoteCommsDefaultMouldNumber"
        Me.RemoteCommsDefaultMouldNumber.NumericFormat = "00"
        Me.RemoteCommsDefaultMouldNumber.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.RemoteCommsDefaultMouldNumber.PLCAddressKeypad = "RemoteConnectionDefaultMouldNumber"
        Me.RemoteCommsDefaultMouldNumber.PLCAddressValue = "RemoteConnectionDefaultMouldNumber"
        Me.RemoteCommsDefaultMouldNumber.PollRate = 0
        Me.RemoteCommsDefaultMouldNumber.Size = New System.Drawing.Size(121, 22)
        Me.RemoteCommsDefaultMouldNumber.TabIndex = 441
        Me.RemoteCommsDefaultMouldNumber.Text = "127"
        Me.RemoteCommsDefaultMouldNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoteCommsDefaultMouldNumber.UseMnemonic = False
        Me.RemoteCommsDefaultMouldNumber.Value = "127"
        Me.RemoteCommsDefaultMouldNumber.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemoteCommsDefaultMouldNumber.ValueLeftPadLength = 0
        Me.RemoteCommsDefaultMouldNumber.ValuePrefix = Nothing
        Me.RemoteCommsDefaultMouldNumber.ValueScaleFactor = 1.0R
        Me.RemoteCommsDefaultMouldNumber.ValueSuffix = Nothing
        '
        'RemoteCommsErrorMouldNumber
        '
        Me.RemoteCommsErrorMouldNumber.BackColor = System.Drawing.Color.Gray
        Me.RemoteCommsErrorMouldNumber.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RemoteCommsErrorMouldNumber.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemoteCommsErrorMouldNumber.DisplayAsTime = False
        Me.RemoteCommsErrorMouldNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteCommsErrorMouldNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommsErrorMouldNumber.Highlight = False
        Me.RemoteCommsErrorMouldNumber.HighlightColor = System.Drawing.Color.Gray
        Me.RemoteCommsErrorMouldNumber.HighlightForeColor = System.Drawing.Color.White
        Me.RemoteCommsErrorMouldNumber.HighlightKeyCharacter = "!"
        Me.RemoteCommsErrorMouldNumber.KeypadAlphaNumeric = False
        Me.RemoteCommsErrorMouldNumber.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RemoteCommsErrorMouldNumber.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteCommsErrorMouldNumber.KeypadMaxValue = 0.0R
        Me.RemoteCommsErrorMouldNumber.KeypadMinValue = 0.0R
        Me.RemoteCommsErrorMouldNumber.KeypadScaleFactor = 1.0R
        Me.RemoteCommsErrorMouldNumber.KeypadShowCurrentValue = False
        Me.RemoteCommsErrorMouldNumber.KeypadText = Nothing
        Me.RemoteCommsErrorMouldNumber.KeypadWidth = 300
        Me.RemoteCommsErrorMouldNumber.Location = New System.Drawing.Point(2, 566)
        Me.RemoteCommsErrorMouldNumber.Name = "RemoteCommsErrorMouldNumber"
        Me.RemoteCommsErrorMouldNumber.NumericFormat = Nothing
        Me.RemoteCommsErrorMouldNumber.PLCAddressKeypad = ""
        Me.RemoteCommsErrorMouldNumber.PollRate = 0
        Me.RemoteCommsErrorMouldNumber.Size = New System.Drawing.Size(303, 20)
        Me.RemoteCommsErrorMouldNumber.TabIndex = 440
        Me.RemoteCommsErrorMouldNumber.Text = "Remote Communications Default Mould #"
        Me.RemoteCommsErrorMouldNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.RemoteCommsErrorMouldNumber.Value = "Remote Communications Default Mould #"
        Me.RemoteCommsErrorMouldNumber.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemoteCommsErrorMouldNumber.ValueLeftPadLength = 0
        Me.RemoteCommsErrorMouldNumber.ValuePrefix = Nothing
        Me.RemoteCommsErrorMouldNumber.ValueScaleFactor = 1.0R
        Me.RemoteCommsErrorMouldNumber.ValueSuffix = Nothing
        '
        'BasicLabel4
        '
        Me.BasicLabel4.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel4.KeypadAlphaNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 1000000.0R
        Me.BasicLabel4.KeypadMinValue = 0.0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 400
        Me.BasicLabel4.Location = New System.Drawing.Point(330, 494)
        Me.BasicLabel4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = "00"
        Me.BasicLabel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel4.PLCAddressKeypad = "RemoteConnectionTimeout"
        Me.BasicLabel4.PLCAddressValue = "RemoteConnectionTimeout"
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel4.TabIndex = 443
        Me.BasicLabel4.Text = "2000"
        Me.BasicLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel4.UseMnemonic = False
        Me.BasicLabel4.Value = "2000"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        '
        'RemoteConnectionsTimeoutLabel
        '
        Me.RemoteConnectionsTimeoutLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RemoteConnectionsTimeoutLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteConnectionsTimeoutLabel.Location = New System.Drawing.Point(88, 497)
        Me.RemoteConnectionsTimeoutLabel.Name = "RemoteConnectionsTimeoutLabel"
        Me.RemoteConnectionsTimeoutLabel.Size = New System.Drawing.Size(217, 20)
        Me.RemoteConnectionsTimeoutLabel.TabIndex = 442
        Me.RemoteConnectionsTimeoutLabel.Text = "Remote Connections Time Out"
        Me.RemoteConnectionsTimeoutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RemoteConnectionsTimeoutUnitsLabel
        '
        Me.RemoteConnectionsTimeoutUnitsLabel.AutoSize = True
        Me.RemoteConnectionsTimeoutUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.RemoteConnectionsTimeoutUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RemoteConnectionsTimeoutUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemoteConnectionsTimeoutUnitsLabel.DisplayAsTime = False
        Me.RemoteConnectionsTimeoutUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteConnectionsTimeoutUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteConnectionsTimeoutUnitsLabel.Highlight = False
        Me.RemoteConnectionsTimeoutUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.RemoteConnectionsTimeoutUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RemoteConnectionsTimeoutUnitsLabel.HighlightKeyCharacter = "!"
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadAlphaNumeric = False
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadMaxValue = 0.0R
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadMinValue = 0.0R
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadScaleFactor = 1.0R
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadShowCurrentValue = False
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadText = Nothing
        Me.RemoteConnectionsTimeoutUnitsLabel.KeypadWidth = 300
        Me.RemoteConnectionsTimeoutUnitsLabel.Location = New System.Drawing.Point(465, 494)
        Me.RemoteConnectionsTimeoutUnitsLabel.Name = "RemoteConnectionsTimeoutUnitsLabel"
        Me.RemoteConnectionsTimeoutUnitsLabel.NumericFormat = Nothing
        Me.RemoteConnectionsTimeoutUnitsLabel.PLCAddressKeypad = ""
        Me.RemoteConnectionsTimeoutUnitsLabel.PollRate = 0
        Me.RemoteConnectionsTimeoutUnitsLabel.Size = New System.Drawing.Size(28, 20)
        Me.RemoteConnectionsTimeoutUnitsLabel.TabIndex = 444
        Me.RemoteConnectionsTimeoutUnitsLabel.Text = "ms"
        Me.RemoteConnectionsTimeoutUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.RemoteConnectionsTimeoutUnitsLabel.Value = "ms"
        Me.RemoteConnectionsTimeoutUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemoteConnectionsTimeoutUnitsLabel.ValueLeftPadLength = 0
        Me.RemoteConnectionsTimeoutUnitsLabel.ValuePrefix = Nothing
        Me.RemoteConnectionsTimeoutUnitsLabel.ValueScaleFactor = 1.0R
        Me.RemoteConnectionsTimeoutUnitsLabel.ValueSuffix = Nothing
        '
        'PlaceGripOpenHeightUnitsLabel
        '
        Me.PlaceGripOpenHeightUnitsLabel.AutoSize = True
        Me.PlaceGripOpenHeightUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.PlaceGripOpenHeightUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PlaceGripOpenHeightUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PlaceGripOpenHeightUnitsLabel.DisplayAsTime = False
        Me.PlaceGripOpenHeightUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceGripOpenHeightUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceGripOpenHeightUnitsLabel.Highlight = False
        Me.PlaceGripOpenHeightUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PlaceGripOpenHeightUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PlaceGripOpenHeightUnitsLabel.HighlightKeyCharacter = "!"
        Me.PlaceGripOpenHeightUnitsLabel.KeypadAlphaNumeric = False
        Me.PlaceGripOpenHeightUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PlaceGripOpenHeightUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceGripOpenHeightUnitsLabel.KeypadMaxValue = 0.0R
        Me.PlaceGripOpenHeightUnitsLabel.KeypadMinValue = 0.0R
        Me.PlaceGripOpenHeightUnitsLabel.KeypadScaleFactor = 1.0R
        Me.PlaceGripOpenHeightUnitsLabel.KeypadShowCurrentValue = False
        Me.PlaceGripOpenHeightUnitsLabel.KeypadText = Nothing
        Me.PlaceGripOpenHeightUnitsLabel.KeypadWidth = 300
        Me.PlaceGripOpenHeightUnitsLabel.Location = New System.Drawing.Point(465, 405)
        Me.PlaceGripOpenHeightUnitsLabel.Name = "PlaceGripOpenHeightUnitsLabel"
        Me.PlaceGripOpenHeightUnitsLabel.NumericFormat = Nothing
        Me.PlaceGripOpenHeightUnitsLabel.PLCAddressKeypad = ""
        Me.PlaceGripOpenHeightUnitsLabel.PollRate = 0
        Me.PlaceGripOpenHeightUnitsLabel.Size = New System.Drawing.Size(35, 20)
        Me.PlaceGripOpenHeightUnitsLabel.TabIndex = 447
        Me.PlaceGripOpenHeightUnitsLabel.Text = "mm"
        Me.PlaceGripOpenHeightUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.PlaceGripOpenHeightUnitsLabel.Value = "mm"
        Me.PlaceGripOpenHeightUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PlaceGripOpenHeightUnitsLabel.ValueLeftPadLength = 0
        Me.PlaceGripOpenHeightUnitsLabel.ValuePrefix = Nothing
        Me.PlaceGripOpenHeightUnitsLabel.ValueScaleFactor = 1.0R
        Me.PlaceGripOpenHeightUnitsLabel.ValueSuffix = Nothing
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 1000000.0R
        Me.BasicLabel7.KeypadMinValue = 0.0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 400
        Me.BasicLabel7.Location = New System.Drawing.Point(330, 403)
        Me.BasicLabel7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = "00"
        Me.BasicLabel7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel7.PLCAddressKeypad = "PlaceGripOpenHeight"
        Me.BasicLabel7.PLCAddressValue = "PlaceGripOpenHeight"
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel7.TabIndex = 446
        Me.BasicLabel7.Text = "00"
        Me.BasicLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel7.UseMnemonic = False
        Me.BasicLabel7.Value = " 0"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        '
        'PlaceGripOpenHeightBasicLabel
        '
        Me.PlaceGripOpenHeightBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PlaceGripOpenHeightBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PlaceGripOpenHeightBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PlaceGripOpenHeightBasicLabel.DisplayAsTime = False
        Me.PlaceGripOpenHeightBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceGripOpenHeightBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceGripOpenHeightBasicLabel.Highlight = False
        Me.PlaceGripOpenHeightBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.PlaceGripOpenHeightBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PlaceGripOpenHeightBasicLabel.HighlightKeyCharacter = "!"
        Me.PlaceGripOpenHeightBasicLabel.KeypadAlphaNumeric = False
        Me.PlaceGripOpenHeightBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PlaceGripOpenHeightBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PlaceGripOpenHeightBasicLabel.KeypadMaxValue = 0.0R
        Me.PlaceGripOpenHeightBasicLabel.KeypadMinValue = 0.0R
        Me.PlaceGripOpenHeightBasicLabel.KeypadScaleFactor = 1.0R
        Me.PlaceGripOpenHeightBasicLabel.KeypadShowCurrentValue = False
        Me.PlaceGripOpenHeightBasicLabel.KeypadText = Nothing
        Me.PlaceGripOpenHeightBasicLabel.KeypadWidth = 300
        Me.PlaceGripOpenHeightBasicLabel.Location = New System.Drawing.Point(82, 404)
        Me.PlaceGripOpenHeightBasicLabel.Name = "PlaceGripOpenHeightBasicLabel"
        Me.PlaceGripOpenHeightBasicLabel.NumericFormat = Nothing
        Me.PlaceGripOpenHeightBasicLabel.PLCAddressKeypad = ""
        Me.PlaceGripOpenHeightBasicLabel.PollRate = 0
        Me.PlaceGripOpenHeightBasicLabel.Size = New System.Drawing.Size(223, 20)
        Me.PlaceGripOpenHeightBasicLabel.TabIndex = 445
        Me.PlaceGripOpenHeightBasicLabel.Text = "Place Grip Open Height PGOH"
        Me.PlaceGripOpenHeightBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.PlaceGripOpenHeightBasicLabel.Value = "Place Grip Open Height PGOH"
        Me.PlaceGripOpenHeightBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PlaceGripOpenHeightBasicLabel.ValueLeftPadLength = 0
        Me.PlaceGripOpenHeightBasicLabel.ValuePrefix = Nothing
        Me.PlaceGripOpenHeightBasicLabel.ValueScaleFactor = 1.0R
        Me.PlaceGripOpenHeightBasicLabel.ValueSuffix = Nothing
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
        'FastFillRateUnitsLabel
        '
        Me.FastFillRateUnitsLabel.AutoSize = True
        Me.FastFillRateUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.FastFillRateUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FastFillRateUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FastFillRateUnitsLabel.DisplayAsTime = False
        Me.FastFillRateUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastFillRateUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastFillRateUnitsLabel.Highlight = False
        Me.FastFillRateUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FastFillRateUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FastFillRateUnitsLabel.HighlightKeyCharacter = "!"
        Me.FastFillRateUnitsLabel.KeypadAlphaNumeric = False
        Me.FastFillRateUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FastFillRateUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FastFillRateUnitsLabel.KeypadMaxValue = 0.0R
        Me.FastFillRateUnitsLabel.KeypadMinValue = 0.0R
        Me.FastFillRateUnitsLabel.KeypadScaleFactor = 1.0R
        Me.FastFillRateUnitsLabel.KeypadShowCurrentValue = False
        Me.FastFillRateUnitsLabel.KeypadText = Nothing
        Me.FastFillRateUnitsLabel.KeypadWidth = 300
        Me.FastFillRateUnitsLabel.Location = New System.Drawing.Point(465, 597)
        Me.FastFillRateUnitsLabel.Name = "FastFillRateUnitsLabel"
        Me.FastFillRateUnitsLabel.NumericFormat = Nothing
        Me.FastFillRateUnitsLabel.PLCAddressKeypad = ""
        Me.FastFillRateUnitsLabel.PollRate = 0
        Me.FastFillRateUnitsLabel.Size = New System.Drawing.Size(35, 20)
        Me.FastFillRateUnitsLabel.TabIndex = 450
        Me.FastFillRateUnitsLabel.Text = "cc/s"
        Me.FastFillRateUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.FastFillRateUnitsLabel.Value = "cc/s"
        Me.FastFillRateUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FastFillRateUnitsLabel.ValueLeftPadLength = 0
        Me.FastFillRateUnitsLabel.ValuePrefix = Nothing
        Me.FastFillRateUnitsLabel.ValueScaleFactor = 1.0R
        Me.FastFillRateUnitsLabel.ValueSuffix = Nothing
        '
        'BasicLabel8
        '
        Me.BasicLabel8.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.DisplayAsTime = False
        Me.BasicLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel8.KeypadAlphaNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 1000000.0R
        Me.BasicLabel8.KeypadMinValue = 0.0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 400
        Me.BasicLabel8.Location = New System.Drawing.Point(330, 596)
        Me.BasicLabel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = "000.00"
        Me.BasicLabel8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel8.PLCAddressKeypad = "FastFillRate"
        Me.BasicLabel8.PLCAddressValue = "FastFillRate"
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel8.TabIndex = 449
        Me.BasicLabel8.Text = "000.00"
        Me.BasicLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel8.UseMnemonic = False
        Me.BasicLabel8.Value = " 0"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        '
        'FastFillRateLabel
        '
        Me.FastFillRateLabel.BackColor = System.Drawing.Color.Gray
        Me.FastFillRateLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FastFillRateLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FastFillRateLabel.DisplayAsTime = False
        Me.FastFillRateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastFillRateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastFillRateLabel.Highlight = False
        Me.FastFillRateLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FastFillRateLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FastFillRateLabel.HighlightKeyCharacter = "!"
        Me.FastFillRateLabel.KeypadAlphaNumeric = False
        Me.FastFillRateLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FastFillRateLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FastFillRateLabel.KeypadMaxValue = 0.0R
        Me.FastFillRateLabel.KeypadMinValue = 0.0R
        Me.FastFillRateLabel.KeypadScaleFactor = 1.0R
        Me.FastFillRateLabel.KeypadShowCurrentValue = False
        Me.FastFillRateLabel.KeypadText = Nothing
        Me.FastFillRateLabel.KeypadWidth = 300
        Me.FastFillRateLabel.Location = New System.Drawing.Point(196, 597)
        Me.FastFillRateLabel.Name = "FastFillRateLabel"
        Me.FastFillRateLabel.NumericFormat = Nothing
        Me.FastFillRateLabel.PLCAddressKeypad = ""
        Me.FastFillRateLabel.PollRate = 0
        Me.FastFillRateLabel.Size = New System.Drawing.Size(109, 20)
        Me.FastFillRateLabel.TabIndex = 448
        Me.FastFillRateLabel.Text = "Fast Fill Rate"
        Me.FastFillRateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FastFillRateLabel.Value = "Fast Fill Rate"
        Me.FastFillRateLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FastFillRateLabel.ValueLeftPadLength = 0
        Me.FastFillRateLabel.ValuePrefix = Nothing
        Me.FastFillRateLabel.ValueScaleFactor = 1.0R
        Me.FastFillRateLabel.ValueSuffix = Nothing
        '
        'FineFillRateUnitsLabel
        '
        Me.FineFillRateUnitsLabel.AutoSize = True
        Me.FineFillRateUnitsLabel.BackColor = System.Drawing.Color.Gray
        Me.FineFillRateUnitsLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FineFillRateUnitsLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FineFillRateUnitsLabel.DisplayAsTime = False
        Me.FineFillRateUnitsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FineFillRateUnitsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FineFillRateUnitsLabel.Highlight = False
        Me.FineFillRateUnitsLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FineFillRateUnitsLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FineFillRateUnitsLabel.HighlightKeyCharacter = "!"
        Me.FineFillRateUnitsLabel.KeypadAlphaNumeric = False
        Me.FineFillRateUnitsLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FineFillRateUnitsLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FineFillRateUnitsLabel.KeypadMaxValue = 0.0R
        Me.FineFillRateUnitsLabel.KeypadMinValue = 0.0R
        Me.FineFillRateUnitsLabel.KeypadScaleFactor = 1.0R
        Me.FineFillRateUnitsLabel.KeypadShowCurrentValue = False
        Me.FineFillRateUnitsLabel.KeypadText = Nothing
        Me.FineFillRateUnitsLabel.KeypadWidth = 300
        Me.FineFillRateUnitsLabel.Location = New System.Drawing.Point(465, 629)
        Me.FineFillRateUnitsLabel.Name = "FineFillRateUnitsLabel"
        Me.FineFillRateUnitsLabel.NumericFormat = Nothing
        Me.FineFillRateUnitsLabel.PLCAddressKeypad = ""
        Me.FineFillRateUnitsLabel.PollRate = 0
        Me.FineFillRateUnitsLabel.Size = New System.Drawing.Size(35, 20)
        Me.FineFillRateUnitsLabel.TabIndex = 453
        Me.FineFillRateUnitsLabel.Text = "cc/s"
        Me.FineFillRateUnitsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.FineFillRateUnitsLabel.Value = "cc/s"
        Me.FineFillRateUnitsLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FineFillRateUnitsLabel.ValueLeftPadLength = 0
        Me.FineFillRateUnitsLabel.ValuePrefix = Nothing
        Me.FineFillRateUnitsLabel.ValueScaleFactor = 1.0R
        Me.FineFillRateUnitsLabel.ValueSuffix = Nothing
        '
        'BasicLabel9
        '
        Me.BasicLabel9.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel9.DisplayAsTime = False
        Me.BasicLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.Highlight = False
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel9.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel9.KeypadAlphaNumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 1000000.0R
        Me.BasicLabel9.KeypadMinValue = 0.0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 400
        Me.BasicLabel9.Location = New System.Drawing.Point(330, 628)
        Me.BasicLabel9.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = "000.00"
        Me.BasicLabel9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel9.PLCAddressKeypad = "FineFillRate"
        Me.BasicLabel9.PLCAddressValue = "FineFillRate"
        Me.BasicLabel9.PollRate = 0
        Me.BasicLabel9.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel9.TabIndex = 452
        Me.BasicLabel9.Text = "000.00"
        Me.BasicLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel9.UseMnemonic = False
        Me.BasicLabel9.Value = " 0"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel9.ValueLeftPadLength = 0
        Me.BasicLabel9.ValuePrefix = Nothing
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        '
        'FineFillRateLabel
        '
        Me.FineFillRateLabel.BackColor = System.Drawing.Color.Gray
        Me.FineFillRateLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FineFillRateLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FineFillRateLabel.DisplayAsTime = False
        Me.FineFillRateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FineFillRateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FineFillRateLabel.Highlight = False
        Me.FineFillRateLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FineFillRateLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FineFillRateLabel.HighlightKeyCharacter = "!"
        Me.FineFillRateLabel.KeypadAlphaNumeric = False
        Me.FineFillRateLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FineFillRateLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FineFillRateLabel.KeypadMaxValue = 0.0R
        Me.FineFillRateLabel.KeypadMinValue = 0.0R
        Me.FineFillRateLabel.KeypadScaleFactor = 1.0R
        Me.FineFillRateLabel.KeypadShowCurrentValue = False
        Me.FineFillRateLabel.KeypadText = Nothing
        Me.FineFillRateLabel.KeypadWidth = 300
        Me.FineFillRateLabel.Location = New System.Drawing.Point(199, 630)
        Me.FineFillRateLabel.Name = "FineFillRateLabel"
        Me.FineFillRateLabel.NumericFormat = Nothing
        Me.FineFillRateLabel.PLCAddressKeypad = ""
        Me.FineFillRateLabel.PollRate = 0
        Me.FineFillRateLabel.Size = New System.Drawing.Size(106, 20)
        Me.FineFillRateLabel.TabIndex = 451
        Me.FineFillRateLabel.Text = "Fine Fill Rate"
        Me.FineFillRateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FineFillRateLabel.Value = "Fine Fill Rate"
        Me.FineFillRateLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FineFillRateLabel.ValueLeftPadLength = 0
        Me.FineFillRateLabel.ValuePrefix = Nothing
        Me.FineFillRateLabel.ValueScaleFactor = 1.0R
        Me.FineFillRateLabel.ValueSuffix = Nothing
        '
        'BasicLabel10
        '
        Me.BasicLabel10.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel10.DisplayAsTime = False
        Me.BasicLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.Highlight = False
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Gray
        Me.BasicLabel10.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel10.KeypadAlphaNumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 1000000.0R
        Me.BasicLabel10.KeypadMinValue = 0.0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 400
        Me.BasicLabel10.Location = New System.Drawing.Point(330, 660)
        Me.BasicLabel10.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = "00.00"
        Me.BasicLabel10.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel10.PLCAddressKeypad = "FastFineFillRatio"
        Me.BasicLabel10.PLCAddressValue = "FastFineFillRatio"
        Me.BasicLabel10.PollRate = 0
        Me.BasicLabel10.Size = New System.Drawing.Size(121, 22)
        Me.BasicLabel10.TabIndex = 455
        Me.BasicLabel10.Text = "00.00"
        Me.BasicLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicLabel10.UseMnemonic = False
        Me.BasicLabel10.Value = " 0"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel10.ValueLeftPadLength = 0
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 1.0R
        Me.BasicLabel10.ValueSuffix = Nothing
        '
        'FastFineRatioLabel
        '
        Me.FastFineRatioLabel.BackColor = System.Drawing.Color.Gray
        Me.FastFineRatioLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.FastFineRatioLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.FastFineRatioLabel.DisplayAsTime = False
        Me.FastFineRatioLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastFineRatioLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastFineRatioLabel.Highlight = False
        Me.FastFineRatioLabel.HighlightColor = System.Drawing.Color.Gray
        Me.FastFineRatioLabel.HighlightForeColor = System.Drawing.Color.White
        Me.FastFineRatioLabel.HighlightKeyCharacter = "!"
        Me.FastFineRatioLabel.KeypadAlphaNumeric = False
        Me.FastFineRatioLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.FastFineRatioLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.FastFineRatioLabel.KeypadMaxValue = 0.0R
        Me.FastFineRatioLabel.KeypadMinValue = 0.0R
        Me.FastFineRatioLabel.KeypadScaleFactor = 1.0R
        Me.FastFineRatioLabel.KeypadShowCurrentValue = False
        Me.FastFineRatioLabel.KeypadText = Nothing
        Me.FastFineRatioLabel.KeypadWidth = 300
        Me.FastFineRatioLabel.Location = New System.Drawing.Point(162, 663)
        Me.FastFineRatioLabel.Name = "FastFineRatioLabel"
        Me.FastFineRatioLabel.NumericFormat = Nothing
        Me.FastFineRatioLabel.PLCAddressKeypad = ""
        Me.FastFineRatioLabel.PollRate = 0
        Me.FastFineRatioLabel.Size = New System.Drawing.Size(143, 20)
        Me.FastFineRatioLabel.TabIndex = 454
        Me.FastFineRatioLabel.Text = "Fast/Fine Fill Ratio"
        Me.FastFineRatioLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FastFineRatioLabel.Value = "Fast/Fine Fill Ratio"
        Me.FastFineRatioLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FastFineRatioLabel.ValueLeftPadLength = 0
        Me.FastFineRatioLabel.ValuePrefix = Nothing
        Me.FastFineRatioLabel.ValueScaleFactor = 1.0R
        Me.FastFineRatioLabel.ValueSuffix = Nothing
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
        Me.Settings2BasicButton.Location = New System.Drawing.Point(175, 756)
        Me.Settings2BasicButton.MaximumHoldTime = 3000
        Me.Settings2BasicButton.MinimumHoldTime = 500
        Me.Settings2BasicButton.Name = "Settings2BasicButton"
        Me.Settings2BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Settings2BasicButton.PLCAddressClick = ""
        Me.Settings2BasicButton.SelectTextAlternate = False
        Me.Settings2BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.Settings2BasicButton.TabIndex = 456
        Me.Settings2BasicButton.Text = "Settings 2"
        Me.Settings2BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings2BasicButton.TextAlternate = Nothing
        Me.Settings2BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Settings2BasicButton.UseVisualStyleBackColor = True
        Me.Settings2BasicButton.ValueToWrite = 0
        '
        'ClearStationMouldBufferBasicButton
        '
        Me.ClearStationMouldBufferBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearStationMouldBufferBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ClearStationMouldBufferBasicButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearStationMouldBufferBasicButton.ForeColor = System.Drawing.Color.Black
        Me.ClearStationMouldBufferBasicButton.Highlight = False
        Me.ClearStationMouldBufferBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ClearStationMouldBufferBasicButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottle53
        Me.ClearStationMouldBufferBasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClearStationMouldBufferBasicButton.Location = New System.Drawing.Point(84, 695)
        Me.ClearStationMouldBufferBasicButton.MaximumHoldTime = 3000
        Me.ClearStationMouldBufferBasicButton.MinimumHoldTime = 500
        Me.ClearStationMouldBufferBasicButton.Name = "ClearStationMouldBufferBasicButton"
        Me.ClearStationMouldBufferBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ClearStationMouldBufferBasicButton.PLCAddressClick = "Station_Clear"
        Me.ClearStationMouldBufferBasicButton.SelectTextAlternate = False
        Me.ClearStationMouldBufferBasicButton.Size = New System.Drawing.Size(191, 44)
        Me.ClearStationMouldBufferBasicButton.TabIndex = 458
        Me.ClearStationMouldBufferBasicButton.Text = "Clear Station Moulds"
        Me.ClearStationMouldBufferBasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearStationMouldBufferBasicButton.TextAlternate = Nothing
        Me.ClearStationMouldBufferBasicButton.UseVisualStyleBackColor = True
        Me.ClearStationMouldBufferBasicButton.ValueToWrite = 0
        '
        'ClearMouldsBufferButton
        '
        Me.ClearMouldsBufferButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearMouldsBufferButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ClearMouldsBufferButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearMouldsBufferButton.ForeColor = System.Drawing.Color.Black
        Me.ClearMouldsBufferButton.Highlight = False
        Me.ClearMouldsBufferButton.HighlightColor = System.Drawing.Color.Green
        Me.ClearMouldsBufferButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottle53
        Me.ClearMouldsBufferButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClearMouldsBufferButton.Location = New System.Drawing.Point(333, 695)
        Me.ClearMouldsBufferButton.MaximumHoldTime = 3000
        Me.ClearMouldsBufferButton.MinimumHoldTime = 500
        Me.ClearMouldsBufferButton.Name = "ClearMouldsBufferButton"
        Me.ClearMouldsBufferButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ClearMouldsBufferButton.PLCAddressClick = "MouldBuffer_Clear"
        Me.ClearMouldsBufferButton.SelectTextAlternate = False
        Me.ClearMouldsBufferButton.Size = New System.Drawing.Size(191, 44)
        Me.ClearMouldsBufferButton.TabIndex = 457
        Me.ClearMouldsBufferButton.Text = "Clear Conveyor Mould"
        Me.ClearMouldsBufferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearMouldsBufferButton.TextAlternate = Nothing
        Me.ClearMouldsBufferButton.UseVisualStyleBackColor = True
        Me.ClearMouldsBufferButton.ValueToWrite = 0
        '
        'ClearStationMouldBufferCheckBox
        '
        Me.ClearStationMouldBufferCheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearStationMouldBufferCheckBox.Checked = True
        Me.ClearStationMouldBufferCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClearStationMouldBufferCheckBox.Location = New System.Drawing.Point(38, 701)
        Me.ClearStationMouldBufferCheckBox.Name = "ClearStationMouldBufferCheckBox"
        Me.ClearStationMouldBufferCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearStationMouldBufferCheckBox.Size = New System.Drawing.Size(19, 15)
        Me.ClearStationMouldBufferCheckBox.TabIndex = 460
        Me.ClearStationMouldBufferCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearStationMouldBufferCheckBox.UseVisualStyleBackColor = True
        '
        'ClearMouldsBufferCheckBox
        '
        Me.ClearMouldsBufferCheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearMouldsBufferCheckBox.Checked = True
        Me.ClearMouldsBufferCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClearMouldsBufferCheckBox.Location = New System.Drawing.Point(548, 701)
        Me.ClearMouldsBufferCheckBox.Name = "ClearMouldsBufferCheckBox"
        Me.ClearMouldsBufferCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearMouldsBufferCheckBox.Size = New System.Drawing.Size(25, 15)
        Me.ClearMouldsBufferCheckBox.TabIndex = 462
        Me.ClearMouldsBufferCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearMouldsBufferCheckBox.UseVisualStyleBackColor = True
        '
        'ClearStationMouldBufferCheckBoxLabel
        '
        Me.ClearStationMouldBufferCheckBoxLabel.BackColor = System.Drawing.Color.Gray
        Me.ClearStationMouldBufferCheckBoxLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ClearStationMouldBufferCheckBoxLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ClearStationMouldBufferCheckBoxLabel.DisplayAsTime = False
        Me.ClearStationMouldBufferCheckBoxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ClearStationMouldBufferCheckBoxLabel.ForeColor = System.Drawing.Color.White
        Me.ClearStationMouldBufferCheckBoxLabel.Highlight = False
        Me.ClearStationMouldBufferCheckBoxLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ClearStationMouldBufferCheckBoxLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ClearStationMouldBufferCheckBoxLabel.HighlightKeyCharacter = "!"
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadAlphaNumeric = False
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadMaxValue = 0.0R
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadMinValue = 0.0R
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadScaleFactor = 1.0R
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadShowCurrentValue = False
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadText = Nothing
        Me.ClearStationMouldBufferCheckBoxLabel.KeypadWidth = 300
        Me.ClearStationMouldBufferCheckBoxLabel.Location = New System.Drawing.Point(17, 719)
        Me.ClearStationMouldBufferCheckBoxLabel.Name = "ClearStationMouldBufferCheckBoxLabel"
        Me.ClearStationMouldBufferCheckBoxLabel.NumericFormat = Nothing
        Me.ClearStationMouldBufferCheckBoxLabel.PLCAddressKeypad = ""
        Me.ClearStationMouldBufferCheckBoxLabel.PollRate = 0
        Me.ClearStationMouldBufferCheckBoxLabel.Size = New System.Drawing.Size(56, 14)
        Me.ClearStationMouldBufferCheckBoxLabel.TabIndex = 463
        Me.ClearStationMouldBufferCheckBoxLabel.Text = "Show"
        Me.ClearStationMouldBufferCheckBoxLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearStationMouldBufferCheckBoxLabel.Value = "Show"
        Me.ClearStationMouldBufferCheckBoxLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ClearStationMouldBufferCheckBoxLabel.ValueLeftPadLength = 0
        Me.ClearStationMouldBufferCheckBoxLabel.ValuePrefix = Nothing
        Me.ClearStationMouldBufferCheckBoxLabel.ValueScaleFactor = 1.0R
        Me.ClearStationMouldBufferCheckBoxLabel.ValueSuffix = Nothing
        '
        'ClearMouldsBufferCheckBoxLabel
        '
        Me.ClearMouldsBufferCheckBoxLabel.BackColor = System.Drawing.Color.Gray
        Me.ClearMouldsBufferCheckBoxLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ClearMouldsBufferCheckBoxLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ClearMouldsBufferCheckBoxLabel.DisplayAsTime = False
        Me.ClearMouldsBufferCheckBoxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ClearMouldsBufferCheckBoxLabel.ForeColor = System.Drawing.Color.White
        Me.ClearMouldsBufferCheckBoxLabel.Highlight = False
        Me.ClearMouldsBufferCheckBoxLabel.HighlightColor = System.Drawing.Color.Gray
        Me.ClearMouldsBufferCheckBoxLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ClearMouldsBufferCheckBoxLabel.HighlightKeyCharacter = "!"
        Me.ClearMouldsBufferCheckBoxLabel.KeypadAlphaNumeric = False
        Me.ClearMouldsBufferCheckBoxLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ClearMouldsBufferCheckBoxLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ClearMouldsBufferCheckBoxLabel.KeypadMaxValue = 0.0R
        Me.ClearMouldsBufferCheckBoxLabel.KeypadMinValue = 0.0R
        Me.ClearMouldsBufferCheckBoxLabel.KeypadScaleFactor = 1.0R
        Me.ClearMouldsBufferCheckBoxLabel.KeypadShowCurrentValue = False
        Me.ClearMouldsBufferCheckBoxLabel.KeypadText = Nothing
        Me.ClearMouldsBufferCheckBoxLabel.KeypadWidth = 300
        Me.ClearMouldsBufferCheckBoxLabel.Location = New System.Drawing.Point(532, 719)
        Me.ClearMouldsBufferCheckBoxLabel.Name = "ClearMouldsBufferCheckBoxLabel"
        Me.ClearMouldsBufferCheckBoxLabel.NumericFormat = Nothing
        Me.ClearMouldsBufferCheckBoxLabel.PLCAddressKeypad = ""
        Me.ClearMouldsBufferCheckBoxLabel.PollRate = 0
        Me.ClearMouldsBufferCheckBoxLabel.Size = New System.Drawing.Size(56, 14)
        Me.ClearMouldsBufferCheckBoxLabel.TabIndex = 464
        Me.ClearMouldsBufferCheckBoxLabel.Text = "Show"
        Me.ClearMouldsBufferCheckBoxLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearMouldsBufferCheckBoxLabel.Value = "Show"
        Me.ClearMouldsBufferCheckBoxLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ClearMouldsBufferCheckBoxLabel.ValueLeftPadLength = 0
        Me.ClearMouldsBufferCheckBoxLabel.ValuePrefix = Nothing
        Me.ClearMouldsBufferCheckBoxLabel.ValueScaleFactor = 1.0R
        Me.ClearMouldsBufferCheckBoxLabel.ValueSuffix = Nothing
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
        Me.AccessLevelLabel.TabIndex = 465
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.White
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.DimGray
        Me.lblVersion.Location = New System.Drawing.Point(506, 74)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(89, 13)
        Me.lblVersion.TabIndex = 466
        Me.lblVersion.Text = "Label1"
        '
        'lblPLCVersion
        '
        Me.lblPLCVersion.BackColor = System.Drawing.Color.White
        Me.lblPLCVersion.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLCVersion.ForeColor = System.Drawing.Color.DimGray
        Me.lblPLCVersion.Location = New System.Drawing.Point(421, 74)
        Me.lblPLCVersion.Name = "lblPLCVersion"
        Me.lblPLCVersion.Size = New System.Drawing.Size(86, 13)
        Me.lblPLCVersion.TabIndex = 467
        Me.lblPLCVersion.Text = "Label1"
        '
        'PurgeTimerUnits
        '
        Me.PurgeTimerUnits.AutoSize = True
        Me.PurgeTimerUnits.BackColor = System.Drawing.Color.Gray
        Me.PurgeTimerUnits.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PurgeTimerUnits.ComComponent = Me.EthernetIPforCLXCom1
        Me.PurgeTimerUnits.DisplayAsTime = False
        Me.PurgeTimerUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTimerUnits.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerUnits.Highlight = False
        Me.PurgeTimerUnits.HighlightColor = System.Drawing.Color.Gray
        Me.PurgeTimerUnits.HighlightForeColor = System.Drawing.Color.White
        Me.PurgeTimerUnits.HighlightKeyCharacter = "!"
        Me.PurgeTimerUnits.KeypadAlphaNumeric = False
        Me.PurgeTimerUnits.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PurgeTimerUnits.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerUnits.KeypadMaxValue = 0.0R
        Me.PurgeTimerUnits.KeypadMinValue = 0.0R
        Me.PurgeTimerUnits.KeypadScaleFactor = 1.0R
        Me.PurgeTimerUnits.KeypadShowCurrentValue = False
        Me.PurgeTimerUnits.KeypadText = Nothing
        Me.PurgeTimerUnits.KeypadWidth = 300
        Me.PurgeTimerUnits.Location = New System.Drawing.Point(465, 164)
        Me.PurgeTimerUnits.Name = "PurgeTimerUnits"
        Me.PurgeTimerUnits.NumericFormat = Nothing
        Me.PurgeTimerUnits.PLCAddressKeypad = ""
        Me.PurgeTimerUnits.PollRate = 0
        Me.PurgeTimerUnits.Size = New System.Drawing.Size(65, 20)
        Me.PurgeTimerUnits.TabIndex = 470
        Me.PurgeTimerUnits.Text = "Seconds"
        Me.PurgeTimerUnits.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.PurgeTimerUnits.Value = "Seconds"
        Me.PurgeTimerUnits.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PurgeTimerUnits.ValueLeftPadLength = 0
        Me.PurgeTimerUnits.ValuePrefix = Nothing
        Me.PurgeTimerUnits.ValueScaleFactor = 1.0R
        Me.PurgeTimerUnits.ValueSuffix = Nothing
        '
        'PurgeTimerValueBasicLabel
        '
        Me.PurgeTimerValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PurgeTimerValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PurgeTimerValueBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PurgeTimerValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PurgeTimerValueBasicLabel.DisplayAsTime = False
        Me.PurgeTimerValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTimerValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerValueBasicLabel.Highlight = False
        Me.PurgeTimerValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PurgeTimerValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PurgeTimerValueBasicLabel.HighlightKeyCharacter = "!"
        Me.PurgeTimerValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurgeTimerValueBasicLabel.KeypadAlphaNumeric = False
        Me.PurgeTimerValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTimerValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerValueBasicLabel.KeypadMaxValue = 1000000.0R
        Me.PurgeTimerValueBasicLabel.KeypadMinValue = 0.0R
        Me.PurgeTimerValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.PurgeTimerValueBasicLabel.KeypadShowCurrentValue = False
        Me.PurgeTimerValueBasicLabel.KeypadText = Nothing
        Me.PurgeTimerValueBasicLabel.KeypadWidth = 400
        Me.PurgeTimerValueBasicLabel.Location = New System.Drawing.Point(330, 163)
        Me.PurgeTimerValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PurgeTimerValueBasicLabel.Name = "PurgeTimerValueBasicLabel"
        Me.PurgeTimerValueBasicLabel.NumericFormat = "00"
        Me.PurgeTimerValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PurgeTimerValueBasicLabel.PLCAddressKeypad = "TestStation.Parameters.Real[1]"
        Me.PurgeTimerValueBasicLabel.PLCAddressValue = "TestStation.Parameters.Real[1]"
        Me.PurgeTimerValueBasicLabel.PollRate = 0
        Me.PurgeTimerValueBasicLabel.Size = New System.Drawing.Size(121, 22)
        Me.PurgeTimerValueBasicLabel.TabIndex = 469
        Me.PurgeTimerValueBasicLabel.Text = "00"
        Me.PurgeTimerValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurgeTimerValueBasicLabel.UseMnemonic = False
        Me.PurgeTimerValueBasicLabel.Value = " 0"
        Me.PurgeTimerValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PurgeTimerValueBasicLabel.ValueLeftPadLength = 0
        Me.PurgeTimerValueBasicLabel.ValuePrefix = Nothing
        Me.PurgeTimerValueBasicLabel.ValueScaleFactor = 1.0R
        Me.PurgeTimerValueBasicLabel.ValueSuffix = Nothing
        '
        'PurgeTimerBasicLabel
        '
        Me.PurgeTimerBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.PurgeTimerBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PurgeTimerBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PurgeTimerBasicLabel.DisplayAsTime = False
        Me.PurgeTimerBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTimerBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerBasicLabel.Highlight = False
        Me.PurgeTimerBasicLabel.HighlightColor = System.Drawing.Color.Gray
        Me.PurgeTimerBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PurgeTimerBasicLabel.HighlightKeyCharacter = "!"
        Me.PurgeTimerBasicLabel.KeypadAlphaNumeric = False
        Me.PurgeTimerBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PurgeTimerBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PurgeTimerBasicLabel.KeypadMaxValue = 0.0R
        Me.PurgeTimerBasicLabel.KeypadMinValue = 0.0R
        Me.PurgeTimerBasicLabel.KeypadScaleFactor = 1.0R
        Me.PurgeTimerBasicLabel.KeypadShowCurrentValue = False
        Me.PurgeTimerBasicLabel.KeypadText = Nothing
        Me.PurgeTimerBasicLabel.KeypadWidth = 300
        Me.PurgeTimerBasicLabel.Location = New System.Drawing.Point(126, 161)
        Me.PurgeTimerBasicLabel.Name = "PurgeTimerBasicLabel"
        Me.PurgeTimerBasicLabel.NumericFormat = Nothing
        Me.PurgeTimerBasicLabel.PLCAddressKeypad = ""
        Me.PurgeTimerBasicLabel.PollRate = 0
        Me.PurgeTimerBasicLabel.Size = New System.Drawing.Size(179, 20)
        Me.PurgeTimerBasicLabel.TabIndex = 468
        Me.PurgeTimerBasicLabel.Text = "Purge Timer"
        Me.PurgeTimerBasicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.PurgeTimerBasicLabel.Value = "Purge Timer"
        Me.PurgeTimerBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PurgeTimerBasicLabel.ValueLeftPadLength = 0
        Me.PurgeTimerBasicLabel.ValuePrefix = Nothing
        Me.PurgeTimerBasicLabel.ValueScaleFactor = 1.0R
        Me.PurgeTimerBasicLabel.ValueSuffix = Nothing
        '
        'Settings3BasicButton
        '
        Me.Settings3BasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.Settings3BasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.Settings3BasicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings3BasicButton.ForeColor = System.Drawing.Color.Black
        Me.Settings3BasicButton.Highlight = False
        Me.Settings3BasicButton.HighlightColor = System.Drawing.Color.Green
        Me.Settings3BasicButton.Image = CType(resources.GetObject("Settings3BasicButton.Image"), System.Drawing.Image)
        Me.Settings3BasicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Settings3BasicButton.Location = New System.Drawing.Point(333, 756)
        Me.Settings3BasicButton.MaximumHoldTime = 3000
        Me.Settings3BasicButton.MinimumHoldTime = 500
        Me.Settings3BasicButton.Name = "Settings3BasicButton"
        Me.Settings3BasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Settings3BasicButton.PLCAddressClick = ""
        Me.Settings3BasicButton.PLCAddressVisible = "HMILevel3Access"
        Me.Settings3BasicButton.SelectTextAlternate = False
        Me.Settings3BasicButton.Size = New System.Drawing.Size(136, 44)
        Me.Settings3BasicButton.TabIndex = 471
        Me.Settings3BasicButton.Text = "Settings 3"
        Me.Settings3BasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings3BasicButton.TextAlternate = Nothing
        Me.Settings3BasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Settings3BasicButton.UseVisualStyleBackColor = True
        Me.Settings3BasicButton.ValueToWrite = 0
        '
        'base_settings
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 814)
        Me.Controls.Add(Me.Settings3BasicButton)
        Me.Controls.Add(Me.PurgeTimerUnits)
        Me.Controls.Add(Me.PurgeTimerValueBasicLabel)
        Me.Controls.Add(Me.PurgeTimerBasicLabel)
        Me.Controls.Add(Me.lblPLCVersion)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.ClearMouldsBufferCheckBoxLabel)
        Me.Controls.Add(Me.ClearStationMouldBufferCheckBoxLabel)
        Me.Controls.Add(Me.ClearMouldsBufferCheckBox)
        Me.Controls.Add(Me.ClearStationMouldBufferCheckBox)
        Me.Controls.Add(Me.ClearStationMouldBufferBasicButton)
        Me.Controls.Add(Me.ClearMouldsBufferButton)
        Me.Controls.Add(Me.Settings2BasicButton)
        Me.Controls.Add(Me.AppExit)
        Me.Controls.Add(Me.BasicLabel10)
        Me.Controls.Add(Me.FastFineRatioLabel)
        Me.Controls.Add(Me.FineFillRateUnitsLabel)
        Me.Controls.Add(Me.BasicLabel9)
        Me.Controls.Add(Me.FineFillRateLabel)
        Me.Controls.Add(Me.FastFillRateUnitsLabel)
        Me.Controls.Add(Me.BasicLabel8)
        Me.Controls.Add(Me.FastFillRateLabel)
        Me.Controls.Add(Me.PlaceGripOpenHeightUnitsLabel)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.PlaceGripOpenHeightBasicLabel)
        Me.Controls.Add(Me.RemoteConnectionsTimeoutUnitsLabel)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.RemoteConnectionsTimeoutLabel)
        Me.Controls.Add(Me.RemoteCommsDefaultMouldNumber)
        Me.Controls.Add(Me.RemoteCommsErrorMouldNumber)
        Me.Controls.Add(Me.DisableRemoteCommunicationsButton)
        Me.Controls.Add(Me.EnableRemoteCommunicationsButton)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.RemoteCommunicationsEnabledLabel)
        Me.Controls.Add(Me.PickUpClampsCloseDelayUnitsLabel)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.PickUpClampsCloseDelayBasicLabel)
        Me.Controls.Add(Me.SetIPAddressButton)
        Me.Controls.Add(Me.RemoteIPAddressTextBox)
        Me.Controls.Add(Me.RemoteConnectionsIPAddressLabel)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.RemoteConnectionPortNumberLabel)
        Me.Controls.Add(Me.DisableConveyorButton)
        Me.Controls.Add(Me.ConveyorEnabledButton)
        Me.Controls.Add(Me.BasicIndicator)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.EnableConveyorLabel)
        Me.Controls.Add(Me.ConveyorToPickDistanceUnitsLabel)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.ConveyorToPickDistanceLabel)
        Me.Controls.Add(Me.CulletBinDisabledButton)
        Me.Controls.Add(Me.CulletBinEnabledButton)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.CulletBinUsageSettingLabel)
        Me.Controls.Add(Me.LowBurstValueUnitsLabel)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.LowBurstValueTimeoutLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.BarLabel)
        Me.Controls.Add(Me.BottleUnderTestDetectionPressureValueBasicLabel)
        Me.Controls.Add(Me.BottleUnderTestDetectionPressureLabel)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.HzBasicLabel)
        Me.Controls.Add(Me.SecondsBasicLabel)
        Me.Controls.Add(Me.ConveyorSpeedValueBasicLabel)
        Me.Controls.Add(Me.WashDownTimerValueBasicLabel)
        Me.Controls.Add(Me.ConveyorSpeedBasicLabel)
        Me.Controls.Add(Me.WashDownTimerBasicLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.SettingsPictureBox)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ConveyorSpeedValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents WashDownTimerValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ConveyorSpeedBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents WashDownTimerBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents HzBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents SecondsBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents BottleUnderTestDetectionPressureLabel As System.Windows.Forms.Label
    Friend WithEvents BarLabel As System.Windows.Forms.Label
    Friend WithEvents BottleUnderTestDetectionPressureValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents LowBurstValueUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents LowBurstValueTimeoutLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents CulletBinUsageSettingLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents CulletBinDisabledButton As AdvancedHMIControls.BasicButton
    Friend WithEvents CulletBinEnabledButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorToPickDistanceLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents ConveyorToPickDistanceUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents DisableConveyorButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ConveyorEnabledButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents EnableConveyorLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents RemoteConnectionPortNumberLabel As System.Windows.Forms.Label
    Friend WithEvents RemoteConnectionsIPAddressLabel As System.Windows.Forms.Label
    Friend WithEvents SetIPAddressButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RemoteIPAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PickUpClampsCloseDelayUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PickUpClampsCloseDelayBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents DisableRemoteCommunicationsButton As AdvancedHMIControls.BasicButton
    Friend WithEvents EnableRemoteCommunicationsButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents RemoteCommunicationsEnabledLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents RemoteCommsDefaultMouldNumber As AdvancedHMIControls.BasicLabel
    Friend WithEvents RemoteCommsErrorMouldNumber As AdvancedHMIControls.BasicLabel
    Friend WithEvents RemoteConnectionsTimeoutUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents RemoteConnectionsTimeoutLabel As System.Windows.Forms.Label
    Friend WithEvents PlaceGripOpenHeightUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PlaceGripOpenHeightBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents FastFineRatioLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents FineFillRateUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents FineFillRateLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents FastFillRateUnitsLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents FastFillRateLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents Settings2BasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ClearStationMouldBufferBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ClearMouldsBufferButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ClearStationMouldBufferCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClearMouldsBufferCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClearMouldsBufferCheckBoxLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ClearStationMouldBufferCheckBoxLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblPLCVersion As System.Windows.Forms.Label
    Friend WithEvents PurgeTimerUnits As AdvancedHMIControls.BasicLabel
    Friend WithEvents PurgeTimerValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PurgeTimerBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents Settings3BasicButton As AdvancedHMIControls.BasicButton
End Class
