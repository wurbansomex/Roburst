<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_home))
        Me.HomeLabel = New System.Windows.Forms.Label()
        Me.FillStationLabel = New System.Windows.Forms.Label()
        Me.LoadStationLabel = New System.Windows.Forms.Label()
        Me.TestStationLabel = New System.Windows.Forms.Label()
        Me.TestNumberLabel = New System.Windows.Forms.Label()
        Me.PressureLabel = New System.Windows.Forms.Label()
        Me.TestProfileLabel = New System.Windows.Forms.Label()
        Me.HeartBeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TestSerialCommsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProfileNameLabel = New System.Windows.Forms.Label()
        Me.CycleStoppingLabel = New AdvancedHMIControls.BasicLabel()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BasicIndicator6 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.MouldsManualEntry = New AdvancedHMIControls.BasicButton()
        Me.MessageDisplayByValue1 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.BasicLabel16 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel15 = New AdvancedHMIControls.BasicLabel()
        Me.RemoteModeButton = New AdvancedHMIControls.BasicButton()
        Me.LocalModeButton = New AdvancedHMIControls.BasicButton()
        Me.ProfileNumberLabel = New AdvancedHMIControls.BasicLabel()
        Me.RunInd = New AdvancedHMIControls.BasicIndicator()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.machineStatusLabel = New AdvancedHMIControls.BasicLabel()
        Me.DataSubscriberAll = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.StopToClearConveyor = New AdvancedHMIControls.BasicButton()
        Me.StopToClearStation = New AdvancedHMIControls.BasicButton()
        Me.CzechPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClearMouldsBufferButton = New AdvancedHMIControls.BasicButton()
        Me.ClearStationMouldBufferBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ItalianPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DutchPictureBox = New System.Windows.Forms.PictureBox()
        Me.SpanishPictureBox = New System.Windows.Forms.PictureBox()
        Me.FrenchPictureBox = New System.Windows.Forms.PictureBox()
        Me.GermanPictureBox = New System.Windows.Forms.PictureBox()
        Me.EnglishPictureBox = New System.Windows.Forms.PictureBox()
        Me.BasicLabel12 = New AdvancedHMIControls.BasicLabel()
        Me.LoadProfileButton = New System.Windows.Forms.Button()
        Me.StopButton = New AdvancedHMIControls.BasicButton()
        Me.StartButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenHelpButton = New AdvancedHMIControls.BasicButton()
        Me.PgOopenSecButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenSettingsButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenCalibrationButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenDeviceButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenIOButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenManualButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenVerificationButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenResultsButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenRecEditButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenLoadButton = New AdvancedHMIControls.BasicButton()
        Me.PgOpenAlarmsButton = New AdvancedHMIControls.BasicButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel11 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel17 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel18 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel19 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel20 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel21 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel22 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel23 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel24 = New AdvancedHMIControls.BasicLabel()
        Me.SaveTimeToPLC = New System.Windows.Forms.Timer(Me.components)
        Me.AlarmsMute = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriberAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CzechPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItalianPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DutchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpanishPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrenchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GermanPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnglishPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeLabel
        '
        Me.HomeLabel.BackColor = System.Drawing.Color.White
        Me.HomeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeLabel.ForeColor = System.Drawing.Color.DimGray
        Me.HomeLabel.Location = New System.Drawing.Point(196, 47)
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(89, 40)
        Me.HomeLabel.TabIndex = 271
        Me.HomeLabel.Text = "Home"
        Me.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FillStationLabel
        '
        Me.FillStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillStationLabel.Location = New System.Drawing.Point(289, 248)
        Me.FillStationLabel.Name = "FillStationLabel"
        Me.FillStationLabel.Size = New System.Drawing.Size(171, 51)
        Me.FillStationLabel.TabIndex = 339
        Me.FillStationLabel.Text = "Fill station"
        Me.FillStationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LoadStationLabel
        '
        Me.LoadStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadStationLabel.Location = New System.Drawing.Point(1, 330)
        Me.LoadStationLabel.Name = "LoadStationLabel"
        Me.LoadStationLabel.Size = New System.Drawing.Size(191, 20)
        Me.LoadStationLabel.TabIndex = 340
        Me.LoadStationLabel.Text = "Load station"
        Me.LoadStationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TestStationLabel
        '
        Me.TestStationLabel.BackColor = System.Drawing.Color.Transparent
        Me.TestStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestStationLabel.Location = New System.Drawing.Point(242, 568)
        Me.TestStationLabel.Name = "TestStationLabel"
        Me.TestStationLabel.Size = New System.Drawing.Size(172, 20)
        Me.TestStationLabel.TabIndex = 341
        Me.TestStationLabel.Text = "Test station"
        Me.TestStationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TestNumberLabel
        '
        Me.TestNumberLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestNumberLabel.Location = New System.Drawing.Point(365, 416)
        Me.TestNumberLabel.Name = "TestNumberLabel"
        Me.TestNumberLabel.Size = New System.Drawing.Size(111, 25)
        Me.TestNumberLabel.TabIndex = 344
        Me.TestNumberLabel.Text = "Test ID"
        Me.TestNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PressureLabel
        '
        Me.PressureLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureLabel.Location = New System.Drawing.Point(365, 444)
        Me.PressureLabel.Name = "PressureLabel"
        Me.PressureLabel.Size = New System.Drawing.Size(113, 26)
        Me.PressureLabel.TabIndex = 346
        Me.PressureLabel.Text = "Max. Pressure"
        Me.PressureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TestProfileLabel
        '
        Me.TestProfileLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TestProfileLabel.Location = New System.Drawing.Point(18, 113)
        Me.TestProfileLabel.Name = "TestProfileLabel"
        Me.TestProfileLabel.Size = New System.Drawing.Size(148, 30)
        Me.TestProfileLabel.TabIndex = 369
        Me.TestProfileLabel.Text = "Test Profile"
        Me.TestProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HeartBeatTimer
        '
        Me.HeartBeatTimer.Interval = 3000
        '
        'TestSerialCommsTimer
        '
        Me.TestSerialCommsTimer.Interval = 1000
        '
        'ProfileNameLabel
        '
        Me.ProfileNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProfileNameLabel.Location = New System.Drawing.Point(183, 142)
        Me.ProfileNameLabel.Name = "ProfileNameLabel"
        Me.ProfileNameLabel.Size = New System.Drawing.Size(349, 25)
        Me.ProfileNameLabel.TabIndex = 403
        Me.ProfileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CycleStoppingLabel
        '
        Me.CycleStoppingLabel.BackColor = System.Drawing.Color.Gray
        Me.CycleStoppingLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.CycleStoppingLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.CycleStoppingLabel.DisplayAsTime = False
        Me.CycleStoppingLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CycleStoppingLabel.ForeColor = System.Drawing.Color.Orange
        Me.CycleStoppingLabel.Highlight = False
        Me.CycleStoppingLabel.HighlightColor = System.Drawing.Color.Red
        Me.CycleStoppingLabel.HighlightForeColor = System.Drawing.Color.White
        Me.CycleStoppingLabel.HighlightKeyCharacter = "!"
        Me.CycleStoppingLabel.KeypadAlphaNumeric = False
        Me.CycleStoppingLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.CycleStoppingLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CycleStoppingLabel.KeypadMaxValue = 0.0R
        Me.CycleStoppingLabel.KeypadMinValue = 0.0R
        Me.CycleStoppingLabel.KeypadScaleFactor = 1.0R
        Me.CycleStoppingLabel.KeypadShowCurrentValue = False
        Me.CycleStoppingLabel.KeypadText = Nothing
        Me.CycleStoppingLabel.KeypadWidth = 300
        Me.CycleStoppingLabel.Location = New System.Drawing.Point(12, 231)
        Me.CycleStoppingLabel.Name = "CycleStoppingLabel"
        Me.CycleStoppingLabel.NumericFormat = Nothing
        Me.CycleStoppingLabel.PLCAddressHighlight = "MainSeq.CycleStop"
        Me.CycleStoppingLabel.PLCAddressKeypad = ""
        Me.CycleStoppingLabel.PLCAddressVisible = "MainSeq.CycleStop"
        Me.CycleStoppingLabel.PollRate = 0
        Me.CycleStoppingLabel.Size = New System.Drawing.Size(217, 28)
        Me.CycleStoppingLabel.TabIndex = 401
        Me.CycleStoppingLabel.Text = "Cycle Stopping"
        Me.CycleStoppingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CycleStoppingLabel.Value = "Cycle Stopping"
        Me.CycleStoppingLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.CycleStoppingLabel.ValueLeftPadLength = 2
        Me.CycleStoppingLabel.ValuePrefix = Nothing
        Me.CycleStoppingLabel.ValueScaleFactor = 1.0R
        Me.CycleStoppingLabel.ValueSuffix = Nothing
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 225
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'BasicIndicator6
        '
        Me.BasicIndicator6.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator6.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator6.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator6.Location = New System.Drawing.Point(246, 506)
        Me.BasicIndicator6.Name = "BasicIndicator6"
        Me.BasicIndicator6.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator6.OutlineWidth = 1
        Me.BasicIndicator6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator6.PLCAddressSelectColor2 = "TestStation.Running"
        Me.BasicIndicator6.SelectColor2 = False
        Me.BasicIndicator6.SelectColor3 = False
        Me.BasicIndicator6.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator6.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator6.TabIndex = 397
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator5.Location = New System.Drawing.Point(249, 313)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "FillStation.Running"
        Me.BasicIndicator5.SelectColor2 = False
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator5.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator5.TabIndex = 396
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(81, 405)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "LoadStation.Running"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator4.TabIndex = 395
        '
        'MouldsManualEntry
        '
        Me.MouldsManualEntry.BackColor = System.Drawing.SystemColors.Control
        Me.MouldsManualEntry.ComComponent = Me.EthernetIPforCLXCom1
        Me.MouldsManualEntry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MouldsManualEntry.ForeColor = System.Drawing.Color.Black
        Me.MouldsManualEntry.Highlight = False
        Me.MouldsManualEntry.HighlightColor = System.Drawing.Color.Green
        Me.MouldsManualEntry.Location = New System.Drawing.Point(369, 176)
        Me.MouldsManualEntry.MaximumHoldTime = 3000
        Me.MouldsManualEntry.MinimumHoldTime = 500
        Me.MouldsManualEntry.Name = "MouldsManualEntry"
        Me.MouldsManualEntry.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.MouldsManualEntry.PLCAddressClick = ""
        Me.MouldsManualEntry.SelectTextAlternate = False
        Me.MouldsManualEntry.Size = New System.Drawing.Size(108, 49)
        Me.MouldsManualEntry.TabIndex = 355
        Me.MouldsManualEntry.Text = "Number entry"
        Me.MouldsManualEntry.TextAlternate = Nothing
        Me.MouldsManualEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MouldsManualEntry.UseVisualStyleBackColor = True
        Me.MouldsManualEntry.ValueToWrite = 0
        '
        'MessageDisplayByValue1
        '
        Me.MessageDisplayByValue1.AutoSize = True
        Me.MessageDisplayByValue1.BackColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue1.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplayByValue1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MessageDisplayByValue1.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue1.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue1.IniFileName = Nothing
        Me.MessageDisplayByValue1.Location = New System.Drawing.Point(543, 449)
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Name = "MessageDisplayByValue1"
        Me.MessageDisplayByValue1.PLCAddressValue = "ST.Test.Profile.Units"
        Me.MessageDisplayByValue1.PLCAddressVisible = ""
        Me.MessageDisplayByValue1.ShowMessageNumber = False
        Me.MessageDisplayByValue1.Size = New System.Drawing.Size(31, 15)
        Me.MessageDisplayByValue1.SpeakMessage = False
        Me.MessageDisplayByValue1.TabIndex = 348
        Me.MessageDisplayByValue1.Text = "barg"
        Me.MessageDisplayByValue1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.MessageDisplayByValue1.TextPrefix = Nothing
        Me.MessageDisplayByValue1.Value = 0
        '
        'BasicLabel16
        '
        Me.BasicLabel16.AutoSize = True
        Me.BasicLabel16.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel16.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel16.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel16.DisplayAsTime = False
        Me.BasicLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel16.Highlight = False
        Me.BasicLabel16.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel16.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel16.HighlightKeyCharacter = "!"
        Me.BasicLabel16.KeypadAlphaNumeric = False
        Me.BasicLabel16.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel16.KeypadMaxValue = 0.0R
        Me.BasicLabel16.KeypadMinValue = 0.0R
        Me.BasicLabel16.KeypadScaleFactor = 1.0R
        Me.BasicLabel16.KeypadShowCurrentValue = False
        Me.BasicLabel16.KeypadText = Nothing
        Me.BasicLabel16.KeypadWidth = 300
        Me.BasicLabel16.Location = New System.Drawing.Point(495, 444)
        Me.BasicLabel16.MinimumSize = New System.Drawing.Size(30, 0)
        Me.BasicLabel16.Name = "BasicLabel16"
        Me.BasicLabel16.NumericFormat = "00"
        Me.BasicLabel16.PLCAddressKeypad = ""
        Me.BasicLabel16.PLCAddressValue = "Test_MaxPressure"
        Me.BasicLabel16.PollRate = 10
        Me.BasicLabel16.Size = New System.Drawing.Size(38, 22)
        Me.BasicLabel16.TabIndex = 347
        Me.BasicLabel16.Text = "000"
        Me.BasicLabel16.Value = "0"
        Me.BasicLabel16.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel16.ValueLeftPadLength = 3
        Me.BasicLabel16.ValuePrefix = Nothing
        Me.BasicLabel16.ValueScaleFactor = 1.0R
        Me.BasicLabel16.ValueSuffix = Nothing
        '
        'BasicLabel15
        '
        Me.BasicLabel15.AutoSize = True
        Me.BasicLabel15.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel15.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BasicLabel15.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel15.DisplayAsTime = False
        Me.BasicLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel15.Highlight = False
        Me.BasicLabel15.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel15.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel15.HighlightKeyCharacter = "!"
        Me.BasicLabel15.KeypadAlphaNumeric = False
        Me.BasicLabel15.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel15.KeypadMaxValue = 0.0R
        Me.BasicLabel15.KeypadMinValue = 0.0R
        Me.BasicLabel15.KeypadScaleFactor = 1.0R
        Me.BasicLabel15.KeypadShowCurrentValue = False
        Me.BasicLabel15.KeypadText = Nothing
        Me.BasicLabel15.KeypadWidth = 300
        Me.BasicLabel15.Location = New System.Drawing.Point(495, 412)
        Me.BasicLabel15.MinimumSize = New System.Drawing.Size(30, 0)
        Me.BasicLabel15.Name = "BasicLabel15"
        Me.BasicLabel15.NumericFormat = "00"
        Me.BasicLabel15.PLCAddressKeypad = ""
        Me.BasicLabel15.PLCAddressValue = "ST.Test.Test_No"
        Me.BasicLabel15.PollRate = 10
        Me.BasicLabel15.Size = New System.Drawing.Size(38, 22)
        Me.BasicLabel15.TabIndex = 345
        Me.BasicLabel15.Text = "000"
        Me.BasicLabel15.Value = "0"
        Me.BasicLabel15.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel15.ValueLeftPadLength = 3
        Me.BasicLabel15.ValuePrefix = Nothing
        Me.BasicLabel15.ValueScaleFactor = 1.0R
        Me.BasicLabel15.ValueSuffix = Nothing
        '
        'RemoteModeButton
        '
        Me.RemoteModeButton.BackColor = System.Drawing.SystemColors.Control
        Me.RemoteModeButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemoteModeButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteModeButton.ForeColor = System.Drawing.Color.Black
        Me.RemoteModeButton.Highlight = False
        Me.RemoteModeButton.HighlightColor = System.Drawing.Color.Green
        Me.RemoteModeButton.Location = New System.Drawing.Point(494, 231)
        Me.RemoteModeButton.MaximumHoldTime = 3000
        Me.RemoteModeButton.MinimumHoldTime = 500
        Me.RemoteModeButton.Name = "RemoteModeButton"
        Me.RemoteModeButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RemoteModeButton.PLCAddressClick = "hmi_remote"
        Me.RemoteModeButton.PLCAddressVisible = "RemoteConnectionEnable"
        Me.RemoteModeButton.SelectTextAlternate = False
        Me.RemoteModeButton.Size = New System.Drawing.Size(94, 49)
        Me.RemoteModeButton.TabIndex = 310
        Me.RemoteModeButton.Text = "Remote"
        Me.RemoteModeButton.TextAlternate = Nothing
        Me.RemoteModeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RemoteModeButton.UseVisualStyleBackColor = True
        Me.RemoteModeButton.ValueToWrite = 0
        '
        'LocalModeButton
        '
        Me.LocalModeButton.BackColor = System.Drawing.SystemColors.Control
        Me.LocalModeButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.LocalModeButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalModeButton.ForeColor = System.Drawing.Color.Black
        Me.LocalModeButton.Highlight = False
        Me.LocalModeButton.HighlightColor = System.Drawing.Color.Green
        Me.LocalModeButton.Location = New System.Drawing.Point(494, 176)
        Me.LocalModeButton.MaximumHoldTime = 3000
        Me.LocalModeButton.MinimumHoldTime = 500
        Me.LocalModeButton.Name = "LocalModeButton"
        Me.LocalModeButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LocalModeButton.PLCAddressClick = "hmi_local"
        Me.LocalModeButton.SelectTextAlternate = False
        Me.LocalModeButton.Size = New System.Drawing.Size(94, 49)
        Me.LocalModeButton.TabIndex = 309
        Me.LocalModeButton.Text = "Local"
        Me.LocalModeButton.TextAlternate = Nothing
        Me.LocalModeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LocalModeButton.UseVisualStyleBackColor = True
        Me.LocalModeButton.ValueToWrite = 0
        '
        'ProfileNumberLabel
        '
        Me.ProfileNumberLabel.BackColor = System.Drawing.Color.Gray
        Me.ProfileNumberLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ProfileNumberLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ProfileNumberLabel.DisplayAsTime = False
        Me.ProfileNumberLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProfileNumberLabel.Highlight = False
        Me.ProfileNumberLabel.HighlightColor = System.Drawing.Color.Red
        Me.ProfileNumberLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ProfileNumberLabel.HighlightKeyCharacter = "!"
        Me.ProfileNumberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProfileNumberLabel.KeypadAlphaNumeric = False
        Me.ProfileNumberLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileNumberLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ProfileNumberLabel.KeypadMaxValue = 0.0R
        Me.ProfileNumberLabel.KeypadMinValue = 0.0R
        Me.ProfileNumberLabel.KeypadScaleFactor = 1.0R
        Me.ProfileNumberLabel.KeypadShowCurrentValue = False
        Me.ProfileNumberLabel.KeypadText = Nothing
        Me.ProfileNumberLabel.KeypadWidth = 400
        Me.ProfileNumberLabel.Location = New System.Drawing.Point(183, 116)
        Me.ProfileNumberLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ProfileNumberLabel.Name = "ProfileNumberLabel"
        Me.ProfileNumberLabel.NumericFormat = Nothing
        Me.ProfileNumberLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ProfileNumberLabel.PLCAddressKeypad = ""
        Me.ProfileNumberLabel.PLCAddressValue = "ProfileLoad.No"
        Me.ProfileNumberLabel.PollRate = 0
        Me.ProfileNumberLabel.Size = New System.Drawing.Size(349, 25)
        Me.ProfileNumberLabel.TabIndex = 308
        Me.ProfileNumberLabel.Text = "-----"
        Me.ProfileNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProfileNumberLabel.Value = "-----"
        Me.ProfileNumberLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProfileNumberLabel.ValueLeftPadLength = 0
        Me.ProfileNumberLabel.ValuePrefix = Nothing
        Me.ProfileNumberLabel.ValueScaleFactor = 1.0R
        Me.ProfileNumberLabel.ValueSuffix = Nothing
        '
        'RunInd
        '
        Me.RunInd.Color1 = System.Drawing.Color.Gray
        Me.RunInd.Color2 = System.Drawing.Color.LimeGreen
        Me.RunInd.Color3 = System.Drawing.Color.Red
        Me.RunInd.ComComponent = Me.EthernetIPforCLXCom1
        Me.RunInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunInd.ForeColor = System.Drawing.Color.Black
        Me.RunInd.Location = New System.Drawing.Point(13, 172)
        Me.RunInd.Name = "RunInd"
        Me.RunInd.OutlineColor = System.Drawing.Color.Transparent
        Me.RunInd.OutlineWidth = 1
        Me.RunInd.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.RunInd.PLCAddressVisible = "MainSeq.Running"
        Me.RunInd.SelectColor2 = True
        Me.RunInd.SelectColor3 = False
        Me.RunInd.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.RunInd.Size = New System.Drawing.Size(104, 57)
        Me.RunInd.TabIndex = 303
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
        Me.AccessLevelLabel.TabIndex = 119
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(24, 3)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 118
        Me.CurrentDateTime.Text = "20-04-2017 09:00:49"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator1.Color3 = System.Drawing.Color.DarkOrange
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.Black
        Me.BasicIndicator1.Location = New System.Drawing.Point(125, 172)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "NOT MainSeq.CycleStop"
        Me.BasicIndicator1.PLCAddressSelectColor3 = "MainSeq.CycleStop"
        Me.BasicIndicator1.PLCAddressVisible = "NOT MainSeq.Running"
        Me.BasicIndicator1.SelectColor2 = True
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator1.Size = New System.Drawing.Size(104, 57)
        Me.BasicIndicator1.TabIndex = 311
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator2.ForeColor = System.Drawing.Color.Black
        Me.BasicIndicator2.Location = New System.Drawing.Point(489, 172)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressVisible = "Not machine_remote"
        Me.BasicIndicator2.SelectColor2 = True
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator2.Size = New System.Drawing.Size(104, 57)
        Me.BasicIndicator2.TabIndex = 312
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.Gray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.LimeGreen
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator3.ForeColor = System.Drawing.Color.Black
        Me.BasicIndicator3.Location = New System.Drawing.Point(488, 227)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressVisible = "machine_remote"
        Me.BasicIndicator3.SelectColor2 = True
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator3.Size = New System.Drawing.Size(104, 57)
        Me.BasicIndicator3.TabIndex = 313
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.SystemColors.Control
        Me.BasicButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BasicButton1.Location = New System.Drawing.Point(236, 176)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.BasicButton1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BasicButton1.PLCAddressClick = "MainSeq.Bits[0].9"
        Me.BasicButton1.PLCAddressVisible = "MainSeq.Bits[0].8"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(94, 49)
        Me.BasicButton1.TabIndex = 461
        Me.BasicButton1.Text = "Next Bottle"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 1
        '
        'machineStatusLabel
        '
        Me.machineStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.machineStatusLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.machineStatusLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.machineStatusLabel.DisplayAsTime = False
        Me.machineStatusLabel.ForeColor = System.Drawing.Color.Gold
        Me.machineStatusLabel.Highlight = False
        Me.machineStatusLabel.HighlightColor = System.Drawing.Color.Gold
        Me.machineStatusLabel.HighlightForeColor = System.Drawing.Color.White
        Me.machineStatusLabel.HighlightKeyCharacter = "!"
        Me.machineStatusLabel.KeypadAlphaNumeric = False
        Me.machineStatusLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.machineStatusLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.machineStatusLabel.KeypadMaxValue = 0.0R
        Me.machineStatusLabel.KeypadMinValue = 0.0R
        Me.machineStatusLabel.KeypadScaleFactor = 1.0R
        Me.machineStatusLabel.KeypadShowCurrentValue = False
        Me.machineStatusLabel.KeypadText = Nothing
        Me.machineStatusLabel.KeypadWidth = 300
        Me.machineStatusLabel.Location = New System.Drawing.Point(0, 95)
        Me.machineStatusLabel.Name = "machineStatusLabel"
        Me.machineStatusLabel.NumericFormat = Nothing
        Me.machineStatusLabel.PLCAddressHighlight = "machineStatus"
        Me.machineStatusLabel.PLCAddressKeypad = ""
        Me.machineStatusLabel.PLCAddressValue = "machineStatus"
        Me.machineStatusLabel.PLCAddressVisible = "machineStatus"
        Me.machineStatusLabel.PollRate = 0
        Me.machineStatusLabel.Size = New System.Drawing.Size(600, 13)
        Me.machineStatusLabel.TabIndex = 465
        Me.machineStatusLabel.Text = "BasicLabel"
        Me.machineStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.machineStatusLabel.Value = "BasicLabel"
        Me.machineStatusLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.machineStatusLabel.ValueLeftPadLength = 0
        Me.machineStatusLabel.ValuePrefix = Nothing
        Me.machineStatusLabel.ValueScaleFactor = 1.0R
        Me.machineStatusLabel.ValueSuffix = Nothing
        '
        'DataSubscriberAll
        '
        Me.DataSubscriberAll.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems2"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems3"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems4"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems5"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems6"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems7"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems8"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems9"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems10"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems11"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems12"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems13"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriberAll.PLCAddressValueItems14"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriberAll.PollRate = 0
        Me.DataSubscriberAll.SynchronizingObject = Me
        Me.DataSubscriberAll.Value = Nothing
        '
        'StopToClearConveyor
        '
        Me.StopToClearConveyor.BackColor = System.Drawing.SystemColors.Control
        Me.StopToClearConveyor.ComComponent = Me.EthernetIPforCLXCom1
        Me.StopToClearConveyor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopToClearConveyor.ForeColor = System.Drawing.Color.Black
        Me.StopToClearConveyor.Highlight = False
        Me.StopToClearConveyor.HighlightColor = System.Drawing.Color.Green
        Me.StopToClearConveyor.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottle53
        Me.StopToClearConveyor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StopToClearConveyor.Location = New System.Drawing.Point(406, 541)
        Me.StopToClearConveyor.MaximumHoldTime = 3000
        Me.StopToClearConveyor.MinimumHoldTime = 500
        Me.StopToClearConveyor.Name = "StopToClearConveyor"
        Me.StopToClearConveyor.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopToClearConveyor.PLCAddressClick = ""
        Me.StopToClearConveyor.PLCAddressVisible = "MainSeq.Running"
        Me.StopToClearConveyor.SelectTextAlternate = False
        Me.StopToClearConveyor.Size = New System.Drawing.Size(191, 44)
        Me.StopToClearConveyor.TabIndex = 464
        Me.StopToClearConveyor.Text = "Stop Machine To Clear Moulds"
        Me.StopToClearConveyor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopToClearConveyor.TextAlternate = Nothing
        Me.StopToClearConveyor.UseVisualStyleBackColor = True
        Me.StopToClearConveyor.ValueToWrite = 0
        '
        'StopToClearStation
        '
        Me.StopToClearStation.BackColor = System.Drawing.SystemColors.Control
        Me.StopToClearStation.ComComponent = Me.EthernetIPforCLXCom1
        Me.StopToClearStation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopToClearStation.ForeColor = System.Drawing.Color.Black
        Me.StopToClearStation.Highlight = False
        Me.StopToClearStation.HighlightColor = System.Drawing.Color.Green
        Me.StopToClearStation.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottle53
        Me.StopToClearStation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StopToClearStation.Location = New System.Drawing.Point(406, 494)
        Me.StopToClearStation.MaximumHoldTime = 3000
        Me.StopToClearStation.MinimumHoldTime = 500
        Me.StopToClearStation.Name = "StopToClearStation"
        Me.StopToClearStation.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopToClearStation.PLCAddressClick = ""
        Me.StopToClearStation.PLCAddressVisible = "MainSeq.Running"
        Me.StopToClearStation.SelectTextAlternate = False
        Me.StopToClearStation.Size = New System.Drawing.Size(191, 44)
        Me.StopToClearStation.TabIndex = 463
        Me.StopToClearStation.Text = "Stop Machine To Clear Moulds"
        Me.StopToClearStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopToClearStation.TextAlternate = Nothing
        Me.StopToClearStation.UseVisualStyleBackColor = True
        Me.StopToClearStation.ValueToWrite = 0
        '
        'CzechPictureBox
        '
        Me.CzechPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CzechPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.CzechFlag
        Me.CzechPictureBox.Location = New System.Drawing.Point(565, 70)
        Me.CzechPictureBox.Name = "CzechPictureBox"
        Me.CzechPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.CzechPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CzechPictureBox.TabIndex = 462
        Me.CzechPictureBox.TabStop = False
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
        Me.ClearMouldsBufferButton.Location = New System.Drawing.Point(406, 541)
        Me.ClearMouldsBufferButton.MaximumHoldTime = 3000
        Me.ClearMouldsBufferButton.MinimumHoldTime = 500
        Me.ClearMouldsBufferButton.Name = "ClearMouldsBufferButton"
        Me.ClearMouldsBufferButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ClearMouldsBufferButton.PLCAddressClick = "MouldBuffer_Clear"
        Me.ClearMouldsBufferButton.PLCAddressVisible = "Not MainSeq.Running"
        Me.ClearMouldsBufferButton.SelectTextAlternate = False
        Me.ClearMouldsBufferButton.Size = New System.Drawing.Size(191, 44)
        Me.ClearMouldsBufferButton.TabIndex = 460
        Me.ClearMouldsBufferButton.Text = "Clear Conveyor Mould"
        Me.ClearMouldsBufferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearMouldsBufferButton.TextAlternate = Nothing
        Me.ClearMouldsBufferButton.UseVisualStyleBackColor = True
        Me.ClearMouldsBufferButton.ValueToWrite = 0
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
        Me.ClearStationMouldBufferBasicButton.Location = New System.Drawing.Point(406, 494)
        Me.ClearStationMouldBufferBasicButton.MaximumHoldTime = 3000
        Me.ClearStationMouldBufferBasicButton.MinimumHoldTime = 500
        Me.ClearStationMouldBufferBasicButton.Name = "ClearStationMouldBufferBasicButton"
        Me.ClearStationMouldBufferBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ClearStationMouldBufferBasicButton.PLCAddressClick = "Station_Clear"
        Me.ClearStationMouldBufferBasicButton.PLCAddressVisible = "Not MainSeq.Running"
        Me.ClearStationMouldBufferBasicButton.SelectTextAlternate = False
        Me.ClearStationMouldBufferBasicButton.Size = New System.Drawing.Size(191, 44)
        Me.ClearStationMouldBufferBasicButton.TabIndex = 459
        Me.ClearStationMouldBufferBasicButton.Text = "Clear Station Moulds"
        Me.ClearStationMouldBufferBasicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearStationMouldBufferBasicButton.TextAlternate = Nothing
        Me.ClearStationMouldBufferBasicButton.UseVisualStyleBackColor = True
        Me.ClearStationMouldBufferBasicButton.ValueToWrite = 0
        '
        'ItalianPictureBox
        '
        Me.ItalianPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Italy
        Me.ItalianPictureBox.Location = New System.Drawing.Point(530, 70)
        Me.ItalianPictureBox.Name = "ItalianPictureBox"
        Me.ItalianPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.ItalianPictureBox.TabIndex = 402
        Me.ItalianPictureBox.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox6.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.TabIndex = 400
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox5.Location = New System.Drawing.Point(170, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.TabIndex = 399
        Me.PictureBox5.TabStop = False
        '
        'DutchPictureBox
        '
        Me.DutchPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Netherlands
        Me.DutchPictureBox.Location = New System.Drawing.Point(390, 70)
        Me.DutchPictureBox.Name = "DutchPictureBox"
        Me.DutchPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.DutchPictureBox.TabIndex = 398
        Me.DutchPictureBox.TabStop = False
        '
        'SpanishPictureBox
        '
        Me.SpanishPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Spain
        Me.SpanishPictureBox.Location = New System.Drawing.Point(495, 70)
        Me.SpanishPictureBox.Name = "SpanishPictureBox"
        Me.SpanishPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.SpanishPictureBox.TabIndex = 373
        Me.SpanishPictureBox.TabStop = False
        '
        'FrenchPictureBox
        '
        Me.FrenchPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.France
        Me.FrenchPictureBox.Location = New System.Drawing.Point(460, 70)
        Me.FrenchPictureBox.Name = "FrenchPictureBox"
        Me.FrenchPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.FrenchPictureBox.TabIndex = 372
        Me.FrenchPictureBox.TabStop = False
        '
        'GermanPictureBox
        '
        Me.GermanPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Germany
        Me.GermanPictureBox.Location = New System.Drawing.Point(425, 70)
        Me.GermanPictureBox.Name = "GermanPictureBox"
        Me.GermanPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.GermanPictureBox.TabIndex = 371
        Me.GermanPictureBox.TabStop = False
        '
        'EnglishPictureBox
        '
        Me.EnglishPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.English
        Me.EnglishPictureBox.Location = New System.Drawing.Point(355, 70)
        Me.EnglishPictureBox.Name = "EnglishPictureBox"
        Me.EnglishPictureBox.Size = New System.Drawing.Size(30, 21)
        Me.EnglishPictureBox.TabIndex = 370
        Me.EnglishPictureBox.TabStop = False
        '
        'BasicLabel12
        '
        Me.BasicLabel12.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel12.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel12.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel12.DisplayAsTime = False
        Me.BasicLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel12.Highlight = False
        Me.BasicLabel12.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel12.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel12.HighlightKeyCharacter = "!"
        Me.BasicLabel12.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel12.KeypadAlphaNumeric = False
        Me.BasicLabel12.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel12.KeypadMaxValue = 0.0R
        Me.BasicLabel12.KeypadMinValue = 0.0R
        Me.BasicLabel12.KeypadScaleFactor = 1.0R
        Me.BasicLabel12.KeypadShowCurrentValue = False
        Me.BasicLabel12.KeypadText = Nothing
        Me.BasicLabel12.KeypadWidth = 300
        Me.BasicLabel12.Location = New System.Drawing.Point(150, 602)
        Me.BasicLabel12.Name = "BasicLabel12"
        Me.BasicLabel12.NumericFormat = "00"
        Me.BasicLabel12.PLCAddressHighlight = "ConvBottles[0].Occ"
        Me.BasicLabel12.PLCAddressKeypad = ""
        Me.BasicLabel12.PLCAddressValue = "ConvBottles[0].Mould_No"
        Me.BasicLabel12.PLCAddressVisible = "ConvBottles[0].Occ"
        Me.BasicLabel12.PollRate = 0
        Me.BasicLabel12.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel12.TabIndex = 335
        Me.BasicLabel12.Text = "00"
        Me.BasicLabel12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel12.Value = "0"
        Me.BasicLabel12.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel12.ValueLeftPadLength = 2
        Me.BasicLabel12.ValuePrefix = Nothing
        Me.BasicLabel12.ValueScaleFactor = 1.0R
        Me.BasicLabel12.ValueSuffix = Nothing
        '
        'LoadProfileButton
        '
        Me.LoadProfileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadProfileButton.Image = CType(resources.GetObject("LoadProfileButton.Image"), System.Drawing.Image)
        Me.LoadProfileButton.Location = New System.Drawing.Point(538, 112)
        Me.LoadProfileButton.Name = "LoadProfileButton"
        Me.LoadProfileButton.Size = New System.Drawing.Size(54, 32)
        Me.LoadProfileButton.TabIndex = 307
        Me.LoadProfileButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.SystemColors.Control
        Me.StopButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.ForeColor = System.Drawing.Color.Black
        Me.StopButton.Highlight = False
        Me.StopButton.HighlightColor = System.Drawing.Color.Green
        Me.StopButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.plain17
        Me.StopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopButton.Location = New System.Drawing.Point(130, 176)
        Me.StopButton.MaximumHoldTime = 3000
        Me.StopButton.MinimumHoldTime = 500
        Me.StopButton.Name = "StopButton"
        Me.StopButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StopButton.Padding = New System.Windows.Forms.Padding(2, 0, 5, 0)
        Me.StopButton.PLCAddressClick = "MainSeq.Stop"
        Me.StopButton.SelectTextAlternate = False
        Me.StopButton.Size = New System.Drawing.Size(94, 49)
        Me.StopButton.TabIndex = 301
        Me.StopButton.Text = "Stop"
        Me.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StopButton.TextAlternate = Nothing
        Me.StopButton.UseVisualStyleBackColor = True
        Me.StopButton.ValueToWrite = 0
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.Control
        Me.StartButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.Black
        Me.StartButton.Highlight = False
        Me.StartButton.HighlightColor = System.Drawing.Color.Green
        Me.StartButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.play18m
        Me.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartButton.Location = New System.Drawing.Point(20, 176)
        Me.StartButton.MaximumHoldTime = 3000
        Me.StartButton.MinimumHoldTime = 500
        Me.StartButton.Name = "StartButton"
        Me.StartButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.StartButton.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.StartButton.PLCAddressClick = ""
        Me.StartButton.SelectTextAlternate = False
        Me.StartButton.Size = New System.Drawing.Size(94, 49)
        Me.StartButton.TabIndex = 300
        Me.StartButton.Text = "Start"
        Me.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StartButton.TextAlternate = Nothing
        Me.StartButton.UseVisualStyleBackColor = True
        Me.StartButton.ValueToWrite = 0
        '
        'PgOpenHelpButton
        '
        Me.PgOpenHelpButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenHelpButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenHelpButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenHelpButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHelpButton.Highlight = False
        Me.PgOpenHelpButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenHelpButton.Image = CType(resources.GetObject("PgOpenHelpButton.Image"), System.Drawing.Image)
        Me.PgOpenHelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenHelpButton.Location = New System.Drawing.Point(448, 666)
        Me.PgOpenHelpButton.MaximumHoldTime = 3000
        Me.PgOpenHelpButton.MinimumHoldTime = 500
        Me.PgOpenHelpButton.Name = "PgOpenHelpButton"
        Me.PgOpenHelpButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenHelpButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenHelpButton.PLCAddressClick = ""
        Me.PgOpenHelpButton.SelectTextAlternate = False
        Me.PgOpenHelpButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHelpButton.TabIndex = 299
        Me.PgOpenHelpButton.Text = "Help"
        Me.PgOpenHelpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHelpButton.TextAlternate = Nothing
        Me.PgOpenHelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHelpButton.UseVisualStyleBackColor = True
        Me.PgOpenHelpButton.ValueToWrite = 0
        '
        'PgOopenSecButton
        '
        Me.PgOopenSecButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOopenSecButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOopenSecButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOopenSecButton.ForeColor = System.Drawing.Color.Black
        Me.PgOopenSecButton.Highlight = False
        Me.PgOopenSecButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOopenSecButton.Image = CType(resources.GetObject("PgOopenSecButton.Image"), System.Drawing.Image)
        Me.PgOopenSecButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOopenSecButton.Location = New System.Drawing.Point(299, 666)
        Me.PgOopenSecButton.MaximumHoldTime = 3000
        Me.PgOopenSecButton.MinimumHoldTime = 500
        Me.PgOopenSecButton.Name = "PgOopenSecButton"
        Me.PgOopenSecButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOopenSecButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOopenSecButton.PLCAddressClick = ""
        Me.PgOopenSecButton.SelectTextAlternate = False
        Me.PgOopenSecButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOopenSecButton.TabIndex = 298
        Me.PgOopenSecButton.Text = "Security"
        Me.PgOopenSecButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOopenSecButton.TextAlternate = Nothing
        Me.PgOopenSecButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOopenSecButton.UseVisualStyleBackColor = True
        Me.PgOopenSecButton.ValueToWrite = 0
        '
        'PgOpenSettingsButton
        '
        Me.PgOpenSettingsButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenSettingsButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenSettingsButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenSettingsButton.Highlight = False
        Me.PgOpenSettingsButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenSettingsButton.Image = CType(resources.GetObject("PgOpenSettingsButton.Image"), System.Drawing.Image)
        Me.PgOpenSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenSettingsButton.Location = New System.Drawing.Point(448, 711)
        Me.PgOpenSettingsButton.MaximumHoldTime = 3000
        Me.PgOpenSettingsButton.MinimumHoldTime = 500
        Me.PgOpenSettingsButton.Name = "PgOpenSettingsButton"
        Me.PgOpenSettingsButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenSettingsButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenSettingsButton.PLCAddressClick = ""
        Me.PgOpenSettingsButton.SelectTextAlternate = False
        Me.PgOpenSettingsButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenSettingsButton.TabIndex = 297
        Me.PgOpenSettingsButton.Text = "Settings"
        Me.PgOpenSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenSettingsButton.TextAlternate = Nothing
        Me.PgOpenSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenSettingsButton.UseVisualStyleBackColor = True
        Me.PgOpenSettingsButton.ValueToWrite = 0
        '
        'PgOpenCalibrationButton
        '
        Me.PgOpenCalibrationButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenCalibrationButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenCalibrationButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenCalibrationButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenCalibrationButton.Highlight = False
        Me.PgOpenCalibrationButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenCalibrationButton.Image = CType(resources.GetObject("PgOpenCalibrationButton.Image"), System.Drawing.Image)
        Me.PgOpenCalibrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenCalibrationButton.Location = New System.Drawing.Point(1, 666)
        Me.PgOpenCalibrationButton.MaximumHoldTime = 3000
        Me.PgOpenCalibrationButton.MinimumHoldTime = 500
        Me.PgOpenCalibrationButton.Name = "PgOpenCalibrationButton"
        Me.PgOpenCalibrationButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenCalibrationButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PgOpenCalibrationButton.PLCAddressClick = ""
        Me.PgOpenCalibrationButton.SelectTextAlternate = False
        Me.PgOpenCalibrationButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenCalibrationButton.TabIndex = 296
        Me.PgOpenCalibrationButton.Text = "Calibration"
        Me.PgOpenCalibrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenCalibrationButton.TextAlternate = Nothing
        Me.PgOpenCalibrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenCalibrationButton.UseVisualStyleBackColor = True
        Me.PgOpenCalibrationButton.ValueToWrite = 0
        '
        'PgOpenDeviceButton
        '
        Me.PgOpenDeviceButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenDeviceButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenDeviceButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenDeviceButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenDeviceButton.Highlight = False
        Me.PgOpenDeviceButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenDeviceButton.Image = CType(resources.GetObject("PgOpenDeviceButton.Image"), System.Drawing.Image)
        Me.PgOpenDeviceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenDeviceButton.Location = New System.Drawing.Point(1, 711)
        Me.PgOpenDeviceButton.MaximumHoldTime = 3000
        Me.PgOpenDeviceButton.MinimumHoldTime = 500
        Me.PgOpenDeviceButton.Name = "PgOpenDeviceButton"
        Me.PgOpenDeviceButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenDeviceButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenDeviceButton.PLCAddressClick = ""
        Me.PgOpenDeviceButton.SelectTextAlternate = False
        Me.PgOpenDeviceButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenDeviceButton.TabIndex = 295
        Me.PgOpenDeviceButton.Text = "Device status"
        Me.PgOpenDeviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenDeviceButton.TextAlternate = Nothing
        Me.PgOpenDeviceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenDeviceButton.UseVisualStyleBackColor = True
        Me.PgOpenDeviceButton.ValueToWrite = 0
        '
        'PgOpenIOButton
        '
        Me.PgOpenIOButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenIOButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenIOButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenIOButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenIOButton.Highlight = False
        Me.PgOpenIOButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenIOButton.Image = CType(resources.GetObject("PgOpenIOButton.Image"), System.Drawing.Image)
        Me.PgOpenIOButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenIOButton.Location = New System.Drawing.Point(150, 711)
        Me.PgOpenIOButton.MaximumHoldTime = 3000
        Me.PgOpenIOButton.MinimumHoldTime = 500
        Me.PgOpenIOButton.Name = "PgOpenIOButton"
        Me.PgOpenIOButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenIOButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenIOButton.PLCAddressClick = ""
        Me.PgOpenIOButton.SelectTextAlternate = False
        Me.PgOpenIOButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenIOButton.TabIndex = 294
        Me.PgOpenIOButton.Text = "Inputs/outputs"
        Me.PgOpenIOButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenIOButton.TextAlternate = Nothing
        Me.PgOpenIOButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenIOButton.UseVisualStyleBackColor = True
        Me.PgOpenIOButton.ValueToWrite = 0
        '
        'PgOpenManualButton
        '
        Me.PgOpenManualButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenManualButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenManualButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenManualButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenManualButton.Highlight = False
        Me.PgOpenManualButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenManualButton.Image = CType(resources.GetObject("PgOpenManualButton.Image"), System.Drawing.Image)
        Me.PgOpenManualButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenManualButton.Location = New System.Drawing.Point(299, 711)
        Me.PgOpenManualButton.MaximumHoldTime = 3000
        Me.PgOpenManualButton.MinimumHoldTime = 500
        Me.PgOpenManualButton.Name = "PgOpenManualButton"
        Me.PgOpenManualButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenManualButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenManualButton.PLCAddressClick = ""
        Me.PgOpenManualButton.SelectTextAlternate = False
        Me.PgOpenManualButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenManualButton.TabIndex = 293
        Me.PgOpenManualButton.Text = "Manual mode"
        Me.PgOpenManualButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenManualButton.TextAlternate = Nothing
        Me.PgOpenManualButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenManualButton.UseVisualStyleBackColor = True
        Me.PgOpenManualButton.ValueToWrite = 0
        '
        'PgOpenVerificationButton
        '
        Me.PgOpenVerificationButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenVerificationButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenVerificationButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenVerificationButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenVerificationButton.Highlight = False
        Me.PgOpenVerificationButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenVerificationButton.Image = CType(resources.GetObject("PgOpenVerificationButton.Image"), System.Drawing.Image)
        Me.PgOpenVerificationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenVerificationButton.Location = New System.Drawing.Point(150, 666)
        Me.PgOpenVerificationButton.MaximumHoldTime = 3000
        Me.PgOpenVerificationButton.MinimumHoldTime = 500
        Me.PgOpenVerificationButton.Name = "PgOpenVerificationButton"
        Me.PgOpenVerificationButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenVerificationButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenVerificationButton.PLCAddressClick = ""
        Me.PgOpenVerificationButton.SelectTextAlternate = False
        Me.PgOpenVerificationButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenVerificationButton.TabIndex = 292
        Me.PgOpenVerificationButton.Text = "Pressure Verification"
        Me.PgOpenVerificationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenVerificationButton.TextAlternate = Nothing
        Me.PgOpenVerificationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenVerificationButton.UseVisualStyleBackColor = True
        Me.PgOpenVerificationButton.ValueToWrite = 0
        '
        'PgOpenResultsButton
        '
        Me.PgOpenResultsButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenResultsButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenResultsButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenResultsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenResultsButton.Highlight = False
        Me.PgOpenResultsButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenResultsButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.three41
        Me.PgOpenResultsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenResultsButton.Location = New System.Drawing.Point(448, 756)
        Me.PgOpenResultsButton.MaximumHoldTime = 3000
        Me.PgOpenResultsButton.MinimumHoldTime = 500
        Me.PgOpenResultsButton.Name = "PgOpenResultsButton"
        Me.PgOpenResultsButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenResultsButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenResultsButton.PLCAddressClick = ""
        Me.PgOpenResultsButton.SelectTextAlternate = False
        Me.PgOpenResultsButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenResultsButton.TabIndex = 291
        Me.PgOpenResultsButton.Text = "Results"
        Me.PgOpenResultsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenResultsButton.TextAlternate = Nothing
        Me.PgOpenResultsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenResultsButton.UseVisualStyleBackColor = True
        Me.PgOpenResultsButton.ValueToWrite = 0
        '
        'PgOpenRecEditButton
        '
        Me.PgOpenRecEditButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenRecEditButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenRecEditButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenRecEditButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenRecEditButton.Highlight = False
        Me.PgOpenRecEditButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenRecEditButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.write15_24
        Me.PgOpenRecEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenRecEditButton.Location = New System.Drawing.Point(299, 756)
        Me.PgOpenRecEditButton.MaximumHoldTime = 3000
        Me.PgOpenRecEditButton.MinimumHoldTime = 500
        Me.PgOpenRecEditButton.Name = "PgOpenRecEditButton"
        Me.PgOpenRecEditButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenRecEditButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenRecEditButton.PLCAddressClick = ""
        Me.PgOpenRecEditButton.SelectTextAlternate = False
        Me.PgOpenRecEditButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenRecEditButton.TabIndex = 290
        Me.PgOpenRecEditButton.Text = "Profile edit"
        Me.PgOpenRecEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenRecEditButton.TextAlternate = Nothing
        Me.PgOpenRecEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenRecEditButton.UseVisualStyleBackColor = True
        Me.PgOpenRecEditButton.ValueToWrite = 0
        '
        'PgOpenLoadButton
        '
        Me.PgOpenLoadButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenLoadButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenLoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenLoadButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenLoadButton.Highlight = False
        Me.PgOpenLoadButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenLoadButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.square2_24
        Me.PgOpenLoadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenLoadButton.Location = New System.Drawing.Point(150, 756)
        Me.PgOpenLoadButton.MaximumHoldTime = 3000
        Me.PgOpenLoadButton.MinimumHoldTime = 500
        Me.PgOpenLoadButton.Name = "PgOpenLoadButton"
        Me.PgOpenLoadButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenLoadButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenLoadButton.PLCAddressClick = ""
        Me.PgOpenLoadButton.SelectTextAlternate = False
        Me.PgOpenLoadButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenLoadButton.TabIndex = 289
        Me.PgOpenLoadButton.Text = "Profile select"
        Me.PgOpenLoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenLoadButton.TextAlternate = Nothing
        Me.PgOpenLoadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenLoadButton.UseVisualStyleBackColor = True
        Me.PgOpenLoadButton.ValueToWrite = 0
        '
        'PgOpenAlarmsButton
        '
        Me.PgOpenAlarmsButton.BackColor = System.Drawing.SystemColors.Control
        Me.PgOpenAlarmsButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.PgOpenAlarmsButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PgOpenAlarmsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenAlarmsButton.Highlight = False
        Me.PgOpenAlarmsButton.HighlightColor = System.Drawing.Color.Green
        Me.PgOpenAlarmsButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bell72
        Me.PgOpenAlarmsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PgOpenAlarmsButton.Location = New System.Drawing.Point(1, 756)
        Me.PgOpenAlarmsButton.MaximumHoldTime = 3000
        Me.PgOpenAlarmsButton.MinimumHoldTime = 500
        Me.PgOpenAlarmsButton.Name = "PgOpenAlarmsButton"
        Me.PgOpenAlarmsButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PgOpenAlarmsButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.PgOpenAlarmsButton.PLCAddressClick = ""
        Me.PgOpenAlarmsButton.SelectTextAlternate = False
        Me.PgOpenAlarmsButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenAlarmsButton.TabIndex = 288
        Me.PgOpenAlarmsButton.Text = "Alarms"
        Me.PgOpenAlarmsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenAlarmsButton.TextAlternate = Nothing
        Me.PgOpenAlarmsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenAlarmsButton.UseVisualStyleBackColor = True
        Me.PgOpenAlarmsButton.ValueToWrite = 0
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
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.Transparent
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bellRed
        Me.AlmInd.Location = New System.Drawing.Point(65, 56)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(34, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 121
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
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
        Me.PictureBox1.Size = New System.Drawing.Size(174, 59)
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
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Turret
        Me.PictureBox4.Location = New System.Drawing.Point(30, 263)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(329, 321)
        Me.PictureBox4.TabIndex = 338
        Me.PictureBox4.TabStop = False
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(178, 602)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "00"
        Me.BasicLabel1.PLCAddressHighlight = "ConvBottles[1].Occ"
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = "ConvBottles[1].Mould_No"
        Me.BasicLabel1.PLCAddressVisible = "ConvBottles[1].Occ"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel1.TabIndex = 466
        Me.BasicLabel1.Text = "00"
        Me.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel1.Value = "0"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel1.ValueLeftPadLength = 2
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'BasicLabel3
        '
        Me.BasicLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0.0R
        Me.BasicLabel3.KeypadMinValue = 0.0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Location = New System.Drawing.Point(206, 602)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = "00"
        Me.BasicLabel3.PLCAddressHighlight = "ConvBottles[2].Occ"
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PLCAddressValue = "ConvBottles[2].Mould_No"
        Me.BasicLabel3.PLCAddressVisible = "ConvBottles[2].Occ"
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel3.TabIndex = 467
        Me.BasicLabel3.Text = "00"
        Me.BasicLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel3.Value = "0"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel3.ValueLeftPadLength = 2
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        '
        'BasicLabel4
        '
        Me.BasicLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel4.KeypadAlphaNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0.0R
        Me.BasicLabel4.KeypadMinValue = 0.0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 300
        Me.BasicLabel4.Location = New System.Drawing.Point(234, 602)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = "00"
        Me.BasicLabel4.PLCAddressHighlight = "ConvBottles[3].Occ"
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PLCAddressValue = "ConvBottles[3].Mould_No"
        Me.BasicLabel4.PLCAddressVisible = "ConvBottles[3].Occ"
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel4.TabIndex = 468
        Me.BasicLabel4.Text = "00"
        Me.BasicLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel4.Value = "0"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel4.ValueLeftPadLength = 2
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        '
        'BasicLabel5
        '
        Me.BasicLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel5.KeypadAlphaNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0.0R
        Me.BasicLabel5.KeypadMinValue = 0.0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 300
        Me.BasicLabel5.Location = New System.Drawing.Point(262, 602)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = "00"
        Me.BasicLabel5.PLCAddressHighlight = "ConvBottles[4].Occ"
        Me.BasicLabel5.PLCAddressKeypad = ""
        Me.BasicLabel5.PLCAddressValue = "ConvBottles[4].Mould_No"
        Me.BasicLabel5.PLCAddressVisible = "ConvBottles[4].Occ"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel5.TabIndex = 469
        Me.BasicLabel5.Text = "00"
        Me.BasicLabel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel5.Value = "0"
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel5.ValueLeftPadLength = 2
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        '
        'BasicLabel6
        '
        Me.BasicLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel6.DisplayAsTime = False
        Me.BasicLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.Highlight = False
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel6.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel6.KeypadAlphaNumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 0.0R
        Me.BasicLabel6.KeypadMinValue = 0.0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Location = New System.Drawing.Point(290, 602)
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = "00"
        Me.BasicLabel6.PLCAddressHighlight = "ConvBottles[5].Occ"
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PLCAddressValue = "ConvBottles[5].Mould_No"
        Me.BasicLabel6.PLCAddressVisible = "ConvBottles[5].Occ"
        Me.BasicLabel6.PollRate = 0
        Me.BasicLabel6.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel6.TabIndex = 470
        Me.BasicLabel6.Text = "00"
        Me.BasicLabel6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel6.Value = "0"
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel6.ValueLeftPadLength = 2
        Me.BasicLabel6.ValuePrefix = Nothing
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0.0R
        Me.BasicLabel7.KeypadMinValue = 0.0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Location = New System.Drawing.Point(318, 602)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = "00"
        Me.BasicLabel7.PLCAddressHighlight = "ConvBottles[6].Occ"
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PLCAddressValue = "ConvBottles[6].Mould_No"
        Me.BasicLabel7.PLCAddressVisible = "ConvBottles[6].Occ"
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel7.TabIndex = 471
        Me.BasicLabel7.Text = "00"
        Me.BasicLabel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel7.Value = "0"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel7.ValueLeftPadLength = 2
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        '
        'BasicLabel8
        '
        Me.BasicLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel8.DisplayAsTime = False
        Me.BasicLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel8.KeypadAlphaNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 0.0R
        Me.BasicLabel8.KeypadMinValue = 0.0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 300
        Me.BasicLabel8.Location = New System.Drawing.Point(346, 602)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = "00"
        Me.BasicLabel8.PLCAddressHighlight = "ConvBottles[7].Occ"
        Me.BasicLabel8.PLCAddressKeypad = ""
        Me.BasicLabel8.PLCAddressValue = "ConvBottles[7].Mould_No"
        Me.BasicLabel8.PLCAddressVisible = "ConvBottles[7].Occ"
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel8.TabIndex = 472
        Me.BasicLabel8.Text = "00"
        Me.BasicLabel8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel8.Value = "0"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel8.ValueLeftPadLength = 2
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        '
        'BasicLabel9
        '
        Me.BasicLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel9.DisplayAsTime = False
        Me.BasicLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.Highlight = False
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel9.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel9.KeypadAlphaNumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 0.0R
        Me.BasicLabel9.KeypadMinValue = 0.0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 300
        Me.BasicLabel9.Location = New System.Drawing.Point(374, 602)
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = "00"
        Me.BasicLabel9.PLCAddressHighlight = "ConvBottles[8].Occ"
        Me.BasicLabel9.PLCAddressKeypad = ""
        Me.BasicLabel9.PLCAddressValue = "ConvBottles[8].Mould_No"
        Me.BasicLabel9.PLCAddressVisible = "ConvBottles[8].Occ"
        Me.BasicLabel9.PollRate = 0
        Me.BasicLabel9.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel9.TabIndex = 473
        Me.BasicLabel9.Text = "00"
        Me.BasicLabel9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel9.Value = "0"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel9.ValueLeftPadLength = 2
        Me.BasicLabel9.ValuePrefix = Nothing
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        '
        'BasicLabel10
        '
        Me.BasicLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel10.DisplayAsTime = False
        Me.BasicLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.Highlight = False
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel10.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel10.KeypadAlphaNumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 0.0R
        Me.BasicLabel10.KeypadMinValue = 0.0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 300
        Me.BasicLabel10.Location = New System.Drawing.Point(402, 602)
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = "00"
        Me.BasicLabel10.PLCAddressHighlight = "ConvBottles[9].Occ"
        Me.BasicLabel10.PLCAddressKeypad = ""
        Me.BasicLabel10.PLCAddressValue = "ConvBottles[9].Mould_No"
        Me.BasicLabel10.PLCAddressVisible = "ConvBottles[9].Occ"
        Me.BasicLabel10.PollRate = 0
        Me.BasicLabel10.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel10.TabIndex = 474
        Me.BasicLabel10.Text = "00"
        Me.BasicLabel10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel10.Value = "0"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel10.ValueLeftPadLength = 2
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 1.0R
        Me.BasicLabel10.ValueSuffix = Nothing
        '
        'BasicLabel11
        '
        Me.BasicLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel11.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel11.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel11.DisplayAsTime = False
        Me.BasicLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.Highlight = False
        Me.BasicLabel11.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel11.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel11.HighlightKeyCharacter = "!"
        Me.BasicLabel11.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel11.KeypadAlphaNumeric = False
        Me.BasicLabel11.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.KeypadMaxValue = 0.0R
        Me.BasicLabel11.KeypadMinValue = 0.0R
        Me.BasicLabel11.KeypadScaleFactor = 1.0R
        Me.BasicLabel11.KeypadShowCurrentValue = False
        Me.BasicLabel11.KeypadText = Nothing
        Me.BasicLabel11.KeypadWidth = 300
        Me.BasicLabel11.Location = New System.Drawing.Point(430, 602)
        Me.BasicLabel11.Name = "BasicLabel11"
        Me.BasicLabel11.NumericFormat = "00"
        Me.BasicLabel11.PLCAddressHighlight = "ConvBottles[10].Occ"
        Me.BasicLabel11.PLCAddressKeypad = ""
        Me.BasicLabel11.PLCAddressValue = "ConvBottles[10].Mould_No"
        Me.BasicLabel11.PLCAddressVisible = "ConvBottles[10].Occ"
        Me.BasicLabel11.PollRate = 0
        Me.BasicLabel11.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel11.TabIndex = 475
        Me.BasicLabel11.Text = "00"
        Me.BasicLabel11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel11.Value = "0"
        Me.BasicLabel11.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel11.ValueLeftPadLength = 2
        Me.BasicLabel11.ValuePrefix = Nothing
        Me.BasicLabel11.ValueScaleFactor = 1.0R
        Me.BasicLabel11.ValueSuffix = Nothing
        '
        'BasicLabel17
        '
        Me.BasicLabel17.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel17.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel17.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel17.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel17.DisplayAsTime = False
        Me.BasicLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel17.Highlight = False
        Me.BasicLabel17.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel17.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel17.HighlightKeyCharacter = "!"
        Me.BasicLabel17.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel17.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel17.KeypadAlphaNumeric = False
        Me.BasicLabel17.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel17.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel17.KeypadMaxValue = 0.0R
        Me.BasicLabel17.KeypadMinValue = 0.0R
        Me.BasicLabel17.KeypadScaleFactor = 1.0R
        Me.BasicLabel17.KeypadShowCurrentValue = False
        Me.BasicLabel17.KeypadText = Nothing
        Me.BasicLabel17.KeypadWidth = 300
        Me.BasicLabel17.Location = New System.Drawing.Point(458, 602)
        Me.BasicLabel17.Name = "BasicLabel17"
        Me.BasicLabel17.NumericFormat = "00"
        Me.BasicLabel17.PLCAddressHighlight = "ConvBottles[11].Occ"
        Me.BasicLabel17.PLCAddressKeypad = ""
        Me.BasicLabel17.PLCAddressValue = "ConvBottles[11].Mould_No"
        Me.BasicLabel17.PLCAddressVisible = "ConvBottles[11].Occ"
        Me.BasicLabel17.PollRate = 0
        Me.BasicLabel17.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel17.TabIndex = 476
        Me.BasicLabel17.Text = "00"
        Me.BasicLabel17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel17.Value = "0"
        Me.BasicLabel17.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel17.ValueLeftPadLength = 2
        Me.BasicLabel17.ValuePrefix = Nothing
        Me.BasicLabel17.ValueScaleFactor = 1.0R
        Me.BasicLabel17.ValueSuffix = Nothing
        '
        'BasicLabel18
        '
        Me.BasicLabel18.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel18.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel18.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel18.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel18.DisplayAsTime = False
        Me.BasicLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel18.Highlight = False
        Me.BasicLabel18.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel18.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel18.HighlightKeyCharacter = "!"
        Me.BasicLabel18.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel18.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel18.KeypadAlphaNumeric = False
        Me.BasicLabel18.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel18.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel18.KeypadMaxValue = 0.0R
        Me.BasicLabel18.KeypadMinValue = 0.0R
        Me.BasicLabel18.KeypadScaleFactor = 1.0R
        Me.BasicLabel18.KeypadShowCurrentValue = False
        Me.BasicLabel18.KeypadText = Nothing
        Me.BasicLabel18.KeypadWidth = 300
        Me.BasicLabel18.Location = New System.Drawing.Point(486, 602)
        Me.BasicLabel18.Name = "BasicLabel18"
        Me.BasicLabel18.NumericFormat = "00"
        Me.BasicLabel18.PLCAddressHighlight = "ConvBottles[12].Occ"
        Me.BasicLabel18.PLCAddressKeypad = ""
        Me.BasicLabel18.PLCAddressValue = "ConvBottles[12].Mould_No"
        Me.BasicLabel18.PLCAddressVisible = "ConvBottles[12].Occ"
        Me.BasicLabel18.PollRate = 0
        Me.BasicLabel18.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel18.TabIndex = 477
        Me.BasicLabel18.Text = "00"
        Me.BasicLabel18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel18.Value = "0"
        Me.BasicLabel18.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel18.ValueLeftPadLength = 2
        Me.BasicLabel18.ValuePrefix = Nothing
        Me.BasicLabel18.ValueScaleFactor = 1.0R
        Me.BasicLabel18.ValueSuffix = Nothing
        '
        'BasicLabel19
        '
        Me.BasicLabel19.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel19.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel19.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel19.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel19.DisplayAsTime = False
        Me.BasicLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel19.Highlight = False
        Me.BasicLabel19.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel19.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel19.HighlightKeyCharacter = "!"
        Me.BasicLabel19.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel19.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel19.KeypadAlphaNumeric = False
        Me.BasicLabel19.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel19.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel19.KeypadMaxValue = 0.0R
        Me.BasicLabel19.KeypadMinValue = 0.0R
        Me.BasicLabel19.KeypadScaleFactor = 1.0R
        Me.BasicLabel19.KeypadShowCurrentValue = False
        Me.BasicLabel19.KeypadText = Nothing
        Me.BasicLabel19.KeypadWidth = 300
        Me.BasicLabel19.Location = New System.Drawing.Point(514, 602)
        Me.BasicLabel19.Name = "BasicLabel19"
        Me.BasicLabel19.NumericFormat = "00"
        Me.BasicLabel19.PLCAddressHighlight = "ConvBottles[13].Occ"
        Me.BasicLabel19.PLCAddressKeypad = ""
        Me.BasicLabel19.PLCAddressValue = "ConvBottles[13].Mould_No"
        Me.BasicLabel19.PLCAddressVisible = "ConvBottles[13].Occ"
        Me.BasicLabel19.PollRate = 0
        Me.BasicLabel19.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel19.TabIndex = 478
        Me.BasicLabel19.Text = "00"
        Me.BasicLabel19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel19.Value = "0"
        Me.BasicLabel19.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel19.ValueLeftPadLength = 2
        Me.BasicLabel19.ValuePrefix = Nothing
        Me.BasicLabel19.ValueScaleFactor = 1.0R
        Me.BasicLabel19.ValueSuffix = Nothing
        '
        'BasicLabel20
        '
        Me.BasicLabel20.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel20.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel20.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel20.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel20.DisplayAsTime = False
        Me.BasicLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel20.Highlight = False
        Me.BasicLabel20.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel20.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel20.HighlightKeyCharacter = "!"
        Me.BasicLabel20.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel20.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel20.KeypadAlphaNumeric = False
        Me.BasicLabel20.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel20.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel20.KeypadMaxValue = 0.0R
        Me.BasicLabel20.KeypadMinValue = 0.0R
        Me.BasicLabel20.KeypadScaleFactor = 1.0R
        Me.BasicLabel20.KeypadShowCurrentValue = False
        Me.BasicLabel20.KeypadText = Nothing
        Me.BasicLabel20.KeypadWidth = 300
        Me.BasicLabel20.Location = New System.Drawing.Point(542, 602)
        Me.BasicLabel20.Name = "BasicLabel20"
        Me.BasicLabel20.NumericFormat = "00"
        Me.BasicLabel20.PLCAddressHighlight = "ConvBottles[14].Occ"
        Me.BasicLabel20.PLCAddressKeypad = ""
        Me.BasicLabel20.PLCAddressValue = "ConvBottles[14].Mould_No"
        Me.BasicLabel20.PLCAddressVisible = "ConvBottles[14].Occ"
        Me.BasicLabel20.PollRate = 0
        Me.BasicLabel20.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel20.TabIndex = 479
        Me.BasicLabel20.Text = "00"
        Me.BasicLabel20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel20.Value = "0"
        Me.BasicLabel20.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel20.ValueLeftPadLength = 2
        Me.BasicLabel20.ValuePrefix = Nothing
        Me.BasicLabel20.ValueScaleFactor = 1.0R
        Me.BasicLabel20.ValueSuffix = Nothing
        '
        'BasicLabel21
        '
        Me.BasicLabel21.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel21.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel21.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel21.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel21.DisplayAsTime = False
        Me.BasicLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel21.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel21.Highlight = False
        Me.BasicLabel21.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel21.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel21.HighlightKeyCharacter = "!"
        Me.BasicLabel21.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel21.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel21.KeypadAlphaNumeric = False
        Me.BasicLabel21.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel21.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel21.KeypadMaxValue = 0.0R
        Me.BasicLabel21.KeypadMinValue = 0.0R
        Me.BasicLabel21.KeypadScaleFactor = 1.0R
        Me.BasicLabel21.KeypadShowCurrentValue = False
        Me.BasicLabel21.KeypadText = Nothing
        Me.BasicLabel21.KeypadWidth = 300
        Me.BasicLabel21.Location = New System.Drawing.Point(570, 602)
        Me.BasicLabel21.Name = "BasicLabel21"
        Me.BasicLabel21.NumericFormat = "00"
        Me.BasicLabel21.PLCAddressHighlight = "ConvBottles[15].Occ"
        Me.BasicLabel21.PLCAddressKeypad = ""
        Me.BasicLabel21.PLCAddressValue = "ConvBottles[15].Mould_No"
        Me.BasicLabel21.PLCAddressVisible = "ConvBottles[15].Occ"
        Me.BasicLabel21.PollRate = 0
        Me.BasicLabel21.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel21.TabIndex = 480
        Me.BasicLabel21.Text = "00"
        Me.BasicLabel21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel21.Value = "0"
        Me.BasicLabel21.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel21.ValueLeftPadLength = 2
        Me.BasicLabel21.ValuePrefix = Nothing
        Me.BasicLabel21.ValueScaleFactor = 1.0R
        Me.BasicLabel21.ValueSuffix = Nothing
        '
        'BasicLabel22
        '
        Me.BasicLabel22.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel22.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel22.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel22.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel22.DisplayAsTime = False
        Me.BasicLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel22.Highlight = False
        Me.BasicLabel22.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel22.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel22.HighlightKeyCharacter = "!"
        Me.BasicLabel22.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel22.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel22.KeypadAlphaNumeric = False
        Me.BasicLabel22.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel22.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel22.KeypadMaxValue = 0.0R
        Me.BasicLabel22.KeypadMinValue = 0.0R
        Me.BasicLabel22.KeypadScaleFactor = 1.0R
        Me.BasicLabel22.KeypadShowCurrentValue = False
        Me.BasicLabel22.KeypadText = Nothing
        Me.BasicLabel22.KeypadWidth = 300
        Me.BasicLabel22.Location = New System.Drawing.Point(75, 279)
        Me.BasicLabel22.Name = "BasicLabel22"
        Me.BasicLabel22.NumericFormat = "00"
        Me.BasicLabel22.PLCAddressHighlight = "StationActivation[0].2"
        Me.BasicLabel22.PLCAddressKeypad = ""
        Me.BasicLabel22.PLCAddressValue = "ST.Load.Mould_No"
        Me.BasicLabel22.PLCAddressVisible = "StationActivation[0].2"
        Me.BasicLabel22.PollRate = 0
        Me.BasicLabel22.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel22.TabIndex = 481
        Me.BasicLabel22.Text = "00"
        Me.BasicLabel22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel22.Value = "0"
        Me.BasicLabel22.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel22.ValueLeftPadLength = 2
        Me.BasicLabel22.ValuePrefix = Nothing
        Me.BasicLabel22.ValueScaleFactor = 1.0R
        Me.BasicLabel22.ValueSuffix = Nothing
        '
        'BasicLabel23
        '
        Me.BasicLabel23.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel23.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel23.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel23.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel23.DisplayAsTime = False
        Me.BasicLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel23.Highlight = False
        Me.BasicLabel23.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel23.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel23.HighlightKeyCharacter = "!"
        Me.BasicLabel23.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel23.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel23.KeypadAlphaNumeric = False
        Me.BasicLabel23.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel23.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel23.KeypadMaxValue = 0.0R
        Me.BasicLabel23.KeypadMinValue = 0.0R
        Me.BasicLabel23.KeypadScaleFactor = 1.0R
        Me.BasicLabel23.KeypadShowCurrentValue = False
        Me.BasicLabel23.KeypadText = Nothing
        Me.BasicLabel23.KeypadWidth = 300
        Me.BasicLabel23.Location = New System.Drawing.Point(331, 299)
        Me.BasicLabel23.Name = "BasicLabel23"
        Me.BasicLabel23.NumericFormat = "00"
        Me.BasicLabel23.PLCAddressHighlight = "StationActivation[0].1"
        Me.BasicLabel23.PLCAddressKeypad = ""
        Me.BasicLabel23.PLCAddressValue = "ST.Fill.Mould_No"
        Me.BasicLabel23.PLCAddressVisible = "StationActivation[0].1"
        Me.BasicLabel23.PollRate = 0
        Me.BasicLabel23.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel23.TabIndex = 482
        Me.BasicLabel23.Text = "00"
        Me.BasicLabel23.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel23.Value = "0"
        Me.BasicLabel23.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel23.ValueLeftPadLength = 2
        Me.BasicLabel23.ValuePrefix = Nothing
        Me.BasicLabel23.ValueScaleFactor = 1.0R
        Me.BasicLabel23.ValueSuffix = Nothing
        '
        'BasicLabel24
        '
        Me.BasicLabel24.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel24.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel24.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel24.Cursor = System.Windows.Forms.Cursors.Default
        Me.BasicLabel24.DisplayAsTime = False
        Me.BasicLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel24.Highlight = False
        Me.BasicLabel24.HighlightColor = System.Drawing.Color.Transparent
        Me.BasicLabel24.HighlightForeColor = System.Drawing.Color.Transparent
        Me.BasicLabel24.HighlightKeyCharacter = "!"
        Me.BasicLabel24.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bottleNew
        Me.BasicLabel24.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BasicLabel24.KeypadAlphaNumeric = False
        Me.BasicLabel24.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel24.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel24.KeypadMaxValue = 0.0R
        Me.BasicLabel24.KeypadMinValue = 0.0R
        Me.BasicLabel24.KeypadScaleFactor = 1.0R
        Me.BasicLabel24.KeypadShowCurrentValue = False
        Me.BasicLabel24.KeypadText = Nothing
        Me.BasicLabel24.KeypadWidth = 300
        Me.BasicLabel24.Location = New System.Drawing.Point(331, 506)
        Me.BasicLabel24.Name = "BasicLabel24"
        Me.BasicLabel24.NumericFormat = "00"
        Me.BasicLabel24.PLCAddressHighlight = "StationActivation[0].0"
        Me.BasicLabel24.PLCAddressKeypad = ""
        Me.BasicLabel24.PLCAddressValue = "ST.Test.Mould_No"
        Me.BasicLabel24.PLCAddressVisible = "StationActivation[0].0"
        Me.BasicLabel24.PollRate = 0
        Me.BasicLabel24.Size = New System.Drawing.Size(28, 51)
        Me.BasicLabel24.TabIndex = 483
        Me.BasicLabel24.Text = "00"
        Me.BasicLabel24.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BasicLabel24.Value = "0"
        Me.BasicLabel24.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel24.ValueLeftPadLength = 2
        Me.BasicLabel24.ValuePrefix = Nothing
        Me.BasicLabel24.ValueScaleFactor = 1.0R
        Me.BasicLabel24.ValueSuffix = Nothing
        '
        'SaveTimeToPLC
        '
        Me.SaveTimeToPLC.Enabled = True
        Me.SaveTimeToPLC.Interval = 3600000
        '
        'AlarmsMute
        '
        '
        'base_home
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 742)
        Me.Controls.Add(Me.BasicLabel24)
        Me.Controls.Add(Me.BasicLabel23)
        Me.Controls.Add(Me.BasicLabel22)
        Me.Controls.Add(Me.BasicLabel21)
        Me.Controls.Add(Me.BasicLabel20)
        Me.Controls.Add(Me.BasicLabel19)
        Me.Controls.Add(Me.BasicLabel18)
        Me.Controls.Add(Me.BasicLabel17)
        Me.Controls.Add(Me.BasicLabel11)
        Me.Controls.Add(Me.BasicLabel10)
        Me.Controls.Add(Me.BasicLabel9)
        Me.Controls.Add(Me.BasicLabel8)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.BasicLabel6)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.machineStatusLabel)
        Me.Controls.Add(Me.StopToClearConveyor)
        Me.Controls.Add(Me.StopToClearStation)
        Me.Controls.Add(Me.CzechPictureBox)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.ClearMouldsBufferButton)
        Me.Controls.Add(Me.ClearStationMouldBufferBasicButton)
        Me.Controls.Add(Me.ProfileNameLabel)
        Me.Controls.Add(Me.ItalianPictureBox)
        Me.Controls.Add(Me.CycleStoppingLabel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.DutchPictureBox)
        Me.Controls.Add(Me.BasicIndicator6)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.SpanishPictureBox)
        Me.Controls.Add(Me.FrenchPictureBox)
        Me.Controls.Add(Me.GermanPictureBox)
        Me.Controls.Add(Me.EnglishPictureBox)
        Me.Controls.Add(Me.TestProfileLabel)
        Me.Controls.Add(Me.MouldsManualEntry)
        Me.Controls.Add(Me.MessageDisplayByValue1)
        Me.Controls.Add(Me.BasicLabel16)
        Me.Controls.Add(Me.PressureLabel)
        Me.Controls.Add(Me.BasicLabel15)
        Me.Controls.Add(Me.TestNumberLabel)
        Me.Controls.Add(Me.TestStationLabel)
        Me.Controls.Add(Me.LoadStationLabel)
        Me.Controls.Add(Me.FillStationLabel)
        Me.Controls.Add(Me.BasicLabel12)
        Me.Controls.Add(Me.RemoteModeButton)
        Me.Controls.Add(Me.LocalModeButton)
        Me.Controls.Add(Me.ProfileNumberLabel)
        Me.Controls.Add(Me.LoadProfileButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.RunInd)
        Me.Controls.Add(Me.PgOpenHelpButton)
        Me.Controls.Add(Me.PgOopenSecButton)
        Me.Controls.Add(Me.PgOpenSettingsButton)
        Me.Controls.Add(Me.PgOpenCalibrationButton)
        Me.Controls.Add(Me.PgOpenDeviceButton)
        Me.Controls.Add(Me.PgOpenIOButton)
        Me.Controls.Add(Me.PgOpenManualButton)
        Me.Controls.Add(Me.PgOpenVerificationButton)
        Me.Controls.Add(Me.PgOpenResultsButton)
        Me.Controls.Add(Me.PgOpenRecEditButton)
        Me.Controls.Add(Me.PgOpenLoadButton)
        Me.Controls.Add(Me.PgOpenAlarmsButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.HomeLabel)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriberAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CzechPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItalianPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DutchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpanishPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrenchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GermanPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnglishPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents HomeLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenAlarmsButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenLoadButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenRecEditButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenResultsButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenVerificationButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenManualButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenIOButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenDeviceButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenCalibrationButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenSettingsButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOopenSecButton As AdvancedHMIControls.BasicButton
    Friend WithEvents PgOpenHelpButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RemoteModeButton As AdvancedHMIControls.BasicButton
    Friend WithEvents LocalModeButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ProfileNumberLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents LoadProfileButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As AdvancedHMIControls.BasicButton
    Friend WithEvents StartButton As AdvancedHMIControls.BasicButton
    Friend WithEvents RunInd As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BasicLabel12 As AdvancedHMIControls.BasicLabel
    Friend WithEvents MessageDisplayByValue1 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents BasicLabel16 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PressureLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel15 As AdvancedHMIControls.BasicLabel
    Friend WithEvents TestNumberLabel As System.Windows.Forms.Label
    Friend WithEvents TestStationLabel As System.Windows.Forms.Label
    Friend WithEvents LoadStationLabel As System.Windows.Forms.Label
    Friend WithEvents FillStationLabel As System.Windows.Forms.Label
    Friend WithEvents MouldsManualEntry As AdvancedHMIControls.BasicButton
    Friend WithEvents TestProfileLabel As System.Windows.Forms.Label
    Friend WithEvents SpanishPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FrenchPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GermanPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents EnglishPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BasicIndicator6 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents DutchPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents HeartBeatTimer As System.Windows.Forms.Timer
    Friend WithEvents CycleStoppingLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents ItalianPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TestSerialCommsTimer As System.Windows.Forms.Timer
    Friend WithEvents ProfileNameLabel As System.Windows.Forms.Label
    Friend WithEvents ClearStationMouldBufferBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ClearMouldsBufferButton As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents CzechPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents StopToClearStation As AdvancedHMIControls.BasicButton
    Friend WithEvents StopToClearConveyor As AdvancedHMIControls.BasicButton
    Friend WithEvents machineStatusLabel As AdvancedHMIControls.BasicLabel
    Public WithEvents DataSubscriberAll As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents BasicLabel24 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel23 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel22 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel21 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel20 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel19 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel18 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel17 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel11 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Public WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents SaveTimeToPLC As System.Windows.Forms.Timer
    Friend WithEvents AlarmsMute As System.Windows.Forms.Timer
End Class
