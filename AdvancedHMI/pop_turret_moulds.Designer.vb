<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_turret_moulds
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim RotationScale1 As MfgControl.AdvancedHMI.Controls.RotationScale = New MfgControl.AdvancedHMI.Controls.RotationScale()
        Dim TranslationScale1 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale2 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale3 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale4 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim RotationScale2 As MfgControl.AdvancedHMI.Controls.RotationScale = New MfgControl.AdvancedHMI.Controls.RotationScale()
        Dim TranslationScale5 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale6 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale7 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale8 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim RotationScale3 As MfgControl.AdvancedHMI.Controls.RotationScale = New MfgControl.AdvancedHMI.Controls.RotationScale()
        Dim TranslationScale9 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale10 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale11 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale12 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_turret_moulds))
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.BasicLabel14 = New AdvancedHMIControls.BasicLabel()
        Me.AnimatingPictureBox13 = New AdvancedHMIControls.AnimatingPictureBox()
        Me.TestStationLabel = New System.Windows.Forms.Label()
        Me.LoadStationLabel = New System.Windows.Forms.Label()
        Me.FillStationLabel = New System.Windows.Forms.Label()
        Me.BasicLabel13 = New AdvancedHMIControls.BasicLabel()
        Me.AnimatingPictureBox12 = New AdvancedHMIControls.AnimatingPictureBox()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.AnimatingPictureBox1 = New AdvancedHMIControls.AnimatingPictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ReverseBasicButton = New AdvancedHMIControls.BasicButton()
        Me.ForwardBasicButton = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimatingPictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimatingPictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimatingPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InstructionsLabel.Location = New System.Drawing.Point(106, 6)
        Me.InstructionsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(325, 32)
        Me.InstructionsLabel.TabIndex = 0
        Me.InstructionsLabel.Text = "Confirm Mould Numbers "
        Me.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.tick
        Me.CloseButton.Location = New System.Drawing.Point(239, 386)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(74, 46)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'BasicLabel14
        '
        Me.BasicLabel14.AutoSize = True
        Me.BasicLabel14.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel14.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel14.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel14.DisplayAsTime = False
        Me.BasicLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel14.Highlight = False
        Me.BasicLabel14.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel14.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel14.HighlightKeyCharacter = "!"
        Me.BasicLabel14.KeypadAlphaNumeric = False
        Me.BasicLabel14.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel14.KeypadMaxValue = 0.0R
        Me.BasicLabel14.KeypadMinValue = 0.0R
        Me.BasicLabel14.KeypadScaleFactor = 1.0R
        Me.BasicLabel14.KeypadShowCurrentValue = False
        Me.BasicLabel14.KeypadText = Nothing
        Me.BasicLabel14.KeypadWidth = 300
        Me.BasicLabel14.Location = New System.Drawing.Point(150, 99)
        Me.BasicLabel14.Name = "BasicLabel14"
        Me.BasicLabel14.NumericFormat = "00"
        Me.BasicLabel14.PLCAddressHighlight = "StationActivation[0].2"
        Me.BasicLabel14.PLCAddressKeypad = ""
        Me.BasicLabel14.PLCAddressValue = "ST.Load.Mould_No"
        Me.BasicLabel14.PLCAddressVisible = "StationActivation[0].2"
        Me.BasicLabel14.PollRate = 0
        Me.BasicLabel14.Size = New System.Drawing.Size(19, 13)
        Me.BasicLabel14.TabIndex = 353
        Me.BasicLabel14.Text = "00"
        Me.BasicLabel14.Value = "0"
        Me.BasicLabel14.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel14.ValueLeftPadLength = 2
        Me.BasicLabel14.ValuePrefix = Nothing
        Me.BasicLabel14.ValueScaleFactor = 1.0R
        Me.BasicLabel14.ValueSuffix = Nothing
        '
        'AnimatingPictureBox13
        '
        Me.AnimatingPictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.AnimatingPictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimatingPictureBox13.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnimatingPictureBox13.Image = CType(resources.GetObject("AnimatingPictureBox13.Image"), System.Drawing.Image)
        RotationScale1.RotationCCWAngle = 0.0!
        RotationScale1.RotationCWAngle = 90.0!
        RotationScale1.RotationMaxValueCCW = 0.0!
        RotationScale1.RotationMaxValueCW = 90.0!
        RotationScale1.XPosition = 0
        RotationScale1.YPosition = 0
        Me.AnimatingPictureBox13.ImageRotationScale = RotationScale1
        Me.AnimatingPictureBox13.ImageRotationValue = 0.0!
        TranslationScale1.ErrorValue = 1.0R
        TranslationScale1.InputMaxValue = 1.0R
        TranslationScale1.InputMinValue = 0.0R
        TranslationScale1.OutputMaxValue = 1.0R
        TranslationScale1.OutputMinValue = 0.0R
        Me.AnimatingPictureBox13.ImageSizeXScale = TranslationScale1
        Me.AnimatingPictureBox13.ImageSizeXValue = 1.0R
        TranslationScale2.ErrorValue = 1.0R
        TranslationScale2.InputMaxValue = 1.0R
        TranslationScale2.InputMinValue = 0.0R
        TranslationScale2.OutputMaxValue = 1.0R
        TranslationScale2.OutputMinValue = 0.0R
        Me.AnimatingPictureBox13.ImageSizeYScale = TranslationScale2
        Me.AnimatingPictureBox13.ImageSizeYValue = 1.0R
        TranslationScale3.ErrorValue = 0.0R
        TranslationScale3.InputMaxValue = 100.0R
        TranslationScale3.InputMinValue = 0.0R
        TranslationScale3.OutputMaxValue = 100.0R
        TranslationScale3.OutputMinValue = 0.0R
        Me.AnimatingPictureBox13.ImageTranslateXScale = TranslationScale3
        Me.AnimatingPictureBox13.ImageTranslateXValue = 0
        TranslationScale4.ErrorValue = 0.0R
        TranslationScale4.InputMaxValue = 100.0R
        TranslationScale4.InputMinValue = 0.0R
        TranslationScale4.OutputMaxValue = 100.0R
        TranslationScale4.OutputMinValue = 0.0R
        Me.AnimatingPictureBox13.ImageTranslateYScale = TranslationScale4
        Me.AnimatingPictureBox13.ImageTranslateYValue = 0
        Me.AnimatingPictureBox13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnimatingPictureBox13.KeypadMaxValue = 0.0R
        Me.AnimatingPictureBox13.KeypadMinValue = 0.0R
        Me.AnimatingPictureBox13.KeypadScaleFactor = 1.0R
        Me.AnimatingPictureBox13.KeypadText = Nothing
        Me.AnimatingPictureBox13.KeypadWidth = 300
        Me.AnimatingPictureBox13.Location = New System.Drawing.Point(148, 57)
        Me.AnimatingPictureBox13.Name = "AnimatingPictureBox13"
        Me.AnimatingPictureBox13.PLCAddressVisible = "StationActivation[0].2"
        Me.AnimatingPictureBox13.Size = New System.Drawing.Size(23, 40)
        Me.AnimatingPictureBox13.TabIndex = 352
        Me.AnimatingPictureBox13.TabStop = False
        '
        'TestStationLabel
        '
        Me.TestStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestStationLabel.Location = New System.Drawing.Point(332, 333)
        Me.TestStationLabel.Name = "TestStationLabel"
        Me.TestStationLabel.Size = New System.Drawing.Size(130, 20)
        Me.TestStationLabel.TabIndex = 351
        Me.TestStationLabel.Text = "Test station"
        '
        'LoadStationLabel
        '
        Me.LoadStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadStationLabel.Location = New System.Drawing.Point(86, 112)
        Me.LoadStationLabel.Name = "LoadStationLabel"
        Me.LoadStationLabel.Size = New System.Drawing.Size(128, 20)
        Me.LoadStationLabel.TabIndex = 350
        Me.LoadStationLabel.Text = "Load station"
        Me.LoadStationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FillStationLabel
        '
        Me.FillStationLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillStationLabel.Location = New System.Drawing.Point(335, 45)
        Me.FillStationLabel.Name = "FillStationLabel"
        Me.FillStationLabel.Size = New System.Drawing.Size(124, 20)
        Me.FillStationLabel.TabIndex = 349
        Me.FillStationLabel.Text = "Fill station"
        Me.FillStationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicLabel13
        '
        Me.BasicLabel13.AutoSize = True
        Me.BasicLabel13.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel13.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel13.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel13.DisplayAsTime = False
        Me.BasicLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel13.Highlight = False
        Me.BasicLabel13.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel13.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel13.HighlightKeyCharacter = "!"
        Me.BasicLabel13.KeypadAlphaNumeric = False
        Me.BasicLabel13.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel13.KeypadMaxValue = 0.0R
        Me.BasicLabel13.KeypadMinValue = 0.0R
        Me.BasicLabel13.KeypadScaleFactor = 1.0R
        Me.BasicLabel13.KeypadShowCurrentValue = False
        Me.BasicLabel13.KeypadText = Nothing
        Me.BasicLabel13.KeypadWidth = 300
        Me.BasicLabel13.Location = New System.Drawing.Point(377, 307)
        Me.BasicLabel13.Name = "BasicLabel13"
        Me.BasicLabel13.NumericFormat = "00"
        Me.BasicLabel13.PLCAddressHighlight = "StationActivation[0].0"
        Me.BasicLabel13.PLCAddressKeypad = ""
        Me.BasicLabel13.PLCAddressValue = "ST.Test.Mould_No"
        Me.BasicLabel13.PLCAddressVisible = "StationActivation[0].0"
        Me.BasicLabel13.PollRate = 0
        Me.BasicLabel13.Size = New System.Drawing.Size(19, 13)
        Me.BasicLabel13.TabIndex = 347
        Me.BasicLabel13.Text = "00"
        Me.BasicLabel13.Value = "0"
        Me.BasicLabel13.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel13.ValueLeftPadLength = 2
        Me.BasicLabel13.ValuePrefix = Nothing
        Me.BasicLabel13.ValueScaleFactor = 1.0R
        Me.BasicLabel13.ValueSuffix = Nothing
        '
        'AnimatingPictureBox12
        '
        Me.AnimatingPictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.AnimatingPictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimatingPictureBox12.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnimatingPictureBox12.Image = CType(resources.GetObject("AnimatingPictureBox12.Image"), System.Drawing.Image)
        RotationScale2.RotationCCWAngle = 0.0!
        RotationScale2.RotationCWAngle = 90.0!
        RotationScale2.RotationMaxValueCCW = 0.0!
        RotationScale2.RotationMaxValueCW = 90.0!
        RotationScale2.XPosition = 0
        RotationScale2.YPosition = 0
        Me.AnimatingPictureBox12.ImageRotationScale = RotationScale2
        Me.AnimatingPictureBox12.ImageRotationValue = 0.0!
        TranslationScale5.ErrorValue = 1.0R
        TranslationScale5.InputMaxValue = 1.0R
        TranslationScale5.InputMinValue = 0.0R
        TranslationScale5.OutputMaxValue = 1.0R
        TranslationScale5.OutputMinValue = 0.0R
        Me.AnimatingPictureBox12.ImageSizeXScale = TranslationScale5
        Me.AnimatingPictureBox12.ImageSizeXValue = 1.0R
        TranslationScale6.ErrorValue = 1.0R
        TranslationScale6.InputMaxValue = 1.0R
        TranslationScale6.InputMinValue = 0.0R
        TranslationScale6.OutputMaxValue = 1.0R
        TranslationScale6.OutputMinValue = 0.0R
        Me.AnimatingPictureBox12.ImageSizeYScale = TranslationScale6
        Me.AnimatingPictureBox12.ImageSizeYValue = 1.0R
        TranslationScale7.ErrorValue = 0.0R
        TranslationScale7.InputMaxValue = 100.0R
        TranslationScale7.InputMinValue = 0.0R
        TranslationScale7.OutputMaxValue = 100.0R
        TranslationScale7.OutputMinValue = 0.0R
        Me.AnimatingPictureBox12.ImageTranslateXScale = TranslationScale7
        Me.AnimatingPictureBox12.ImageTranslateXValue = 0
        TranslationScale8.ErrorValue = 0.0R
        TranslationScale8.InputMaxValue = 100.0R
        TranslationScale8.InputMinValue = 0.0R
        TranslationScale8.OutputMaxValue = 100.0R
        TranslationScale8.OutputMinValue = 0.0R
        Me.AnimatingPictureBox12.ImageTranslateYScale = TranslationScale8
        Me.AnimatingPictureBox12.ImageTranslateYValue = 0
        Me.AnimatingPictureBox12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnimatingPictureBox12.KeypadMaxValue = 0.0R
        Me.AnimatingPictureBox12.KeypadMinValue = 0.0R
        Me.AnimatingPictureBox12.KeypadScaleFactor = 1.0R
        Me.AnimatingPictureBox12.KeypadText = Nothing
        Me.AnimatingPictureBox12.KeypadWidth = 300
        Me.AnimatingPictureBox12.Location = New System.Drawing.Point(375, 263)
        Me.AnimatingPictureBox12.Name = "AnimatingPictureBox12"
        Me.AnimatingPictureBox12.PLCAddressVisible = "StationActivation[0].0"
        Me.AnimatingPictureBox12.Size = New System.Drawing.Size(23, 40)
        Me.AnimatingPictureBox12.TabIndex = 346
        Me.AnimatingPictureBox12.TabStop = False
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Gray
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
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
        Me.BasicLabel2.Location = New System.Drawing.Point(387, 128)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = "00"
        Me.BasicLabel2.PLCAddressHighlight = "StationActivation[0].1"
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = "ST.Fill.Mould_No"
        Me.BasicLabel2.PLCAddressVisible = "StationActivation[0].1"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(19, 13)
        Me.BasicLabel2.TabIndex = 345
        Me.BasicLabel2.Text = "00"
        Me.BasicLabel2.Value = "0"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel2.ValueLeftPadLength = 2
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'AnimatingPictureBox1
        '
        Me.AnimatingPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.AnimatingPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimatingPictureBox1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnimatingPictureBox1.Image = CType(resources.GetObject("AnimatingPictureBox1.Image"), System.Drawing.Image)
        RotationScale3.RotationCCWAngle = 0.0!
        RotationScale3.RotationCWAngle = 90.0!
        RotationScale3.RotationMaxValueCCW = 0.0!
        RotationScale3.RotationMaxValueCW = 90.0!
        RotationScale3.XPosition = 0
        RotationScale3.YPosition = 0
        Me.AnimatingPictureBox1.ImageRotationScale = RotationScale3
        Me.AnimatingPictureBox1.ImageRotationValue = 0.0!
        TranslationScale9.ErrorValue = 1.0R
        TranslationScale9.InputMaxValue = 1.0R
        TranslationScale9.InputMinValue = 0.0R
        TranslationScale9.OutputMaxValue = 1.0R
        TranslationScale9.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageSizeXScale = TranslationScale9
        Me.AnimatingPictureBox1.ImageSizeXValue = 1.0R
        TranslationScale10.ErrorValue = 1.0R
        TranslationScale10.InputMaxValue = 1.0R
        TranslationScale10.InputMinValue = 0.0R
        TranslationScale10.OutputMaxValue = 1.0R
        TranslationScale10.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageSizeYScale = TranslationScale10
        Me.AnimatingPictureBox1.ImageSizeYValue = 1.0R
        TranslationScale11.ErrorValue = 0.0R
        TranslationScale11.InputMaxValue = 100.0R
        TranslationScale11.InputMinValue = 0.0R
        TranslationScale11.OutputMaxValue = 100.0R
        TranslationScale11.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageTranslateXScale = TranslationScale11
        Me.AnimatingPictureBox1.ImageTranslateXValue = 0
        TranslationScale12.ErrorValue = 0.0R
        TranslationScale12.InputMaxValue = 100.0R
        TranslationScale12.InputMinValue = 0.0R
        TranslationScale12.OutputMaxValue = 100.0R
        TranslationScale12.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageTranslateYScale = TranslationScale12
        Me.AnimatingPictureBox1.ImageTranslateYValue = 0
        Me.AnimatingPictureBox1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnimatingPictureBox1.KeypadMaxValue = 0.0R
        Me.AnimatingPictureBox1.KeypadMinValue = 0.0R
        Me.AnimatingPictureBox1.KeypadScaleFactor = 1.0R
        Me.AnimatingPictureBox1.KeypadText = Nothing
        Me.AnimatingPictureBox1.KeypadWidth = 300
        Me.AnimatingPictureBox1.Location = New System.Drawing.Point(386, 82)
        Me.AnimatingPictureBox1.Name = "AnimatingPictureBox1"
        Me.AnimatingPictureBox1.PLCAddressVisible = "StationActivation[0].1"
        Me.AnimatingPictureBox1.Size = New System.Drawing.Size(23, 40)
        Me.AnimatingPictureBox1.TabIndex = 344
        Me.AnimatingPictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Turret
        Me.PictureBox4.Location = New System.Drawing.Point(84, 45)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(329, 321)
        Me.PictureBox4.TabIndex = 348
        Me.PictureBox4.TabStop = False
        '
        'ReverseBasicButton
        '
        Me.ReverseBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.ReverseBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ReverseBasicButton.Highlight = False
        Me.ReverseBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.ReverseBasicButton.Image = CType(resources.GetObject("ReverseBasicButton.Image"), System.Drawing.Image)
        Me.ReverseBasicButton.Location = New System.Drawing.Point(450, 202)
        Me.ReverseBasicButton.MaximumHoldTime = 99999
        Me.ReverseBasicButton.MinimumHoldTime = 0
        Me.ReverseBasicButton.Name = "ReverseBasicButton"
        Me.ReverseBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ReverseBasicButton.PLCAddressClick = "TurretShiftRev"
        Me.ReverseBasicButton.SelectTextAlternate = False
        Me.ReverseBasicButton.Size = New System.Drawing.Size(66, 44)
        Me.ReverseBasicButton.TabIndex = 406
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
        Me.ForwardBasicButton.Location = New System.Drawing.Point(450, 141)
        Me.ForwardBasicButton.MaximumHoldTime = 99999
        Me.ForwardBasicButton.MinimumHoldTime = 0
        Me.ForwardBasicButton.Name = "ForwardBasicButton"
        Me.ForwardBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ForwardBasicButton.PLCAddressClick = "TurretShiftFwd"
        Me.ForwardBasicButton.SelectTextAlternate = False
        Me.ForwardBasicButton.Size = New System.Drawing.Size(66, 44)
        Me.ForwardBasicButton.TabIndex = 405
        Me.ForwardBasicButton.TextAlternate = Nothing
        Me.ForwardBasicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ForwardBasicButton.UseVisualStyleBackColor = True
        Me.ForwardBasicButton.ValueToWrite = 0
        '
        'pop_turret_moulds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(546, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReverseBasicButton)
        Me.Controls.Add(Me.ForwardBasicButton)
        Me.Controls.Add(Me.BasicLabel14)
        Me.Controls.Add(Me.AnimatingPictureBox13)
        Me.Controls.Add(Me.TestStationLabel)
        Me.Controls.Add(Me.LoadStationLabel)
        Me.Controls.Add(Me.FillStationLabel)
        Me.Controls.Add(Me.BasicLabel13)
        Me.Controls.Add(Me.AnimatingPictureBox12)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.AnimatingPictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pop_turret_moulds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimatingPictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimatingPictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimatingPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructionsLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents BasicLabel14 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnimatingPictureBox13 As AdvancedHMIControls.AnimatingPictureBox
    Friend WithEvents TestStationLabel As System.Windows.Forms.Label
    Friend WithEvents LoadStationLabel As System.Windows.Forms.Label
    Friend WithEvents FillStationLabel As System.Windows.Forms.Label
    Friend WithEvents BasicLabel13 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnimatingPictureBox12 As AdvancedHMIControls.AnimatingPictureBox
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AnimatingPictureBox1 As AdvancedHMIControls.AnimatingPictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ReverseBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents ForwardBasicButton As AdvancedHMIControls.BasicButton
End Class
