<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_template
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
        Dim RotationScale1 As MfgControl.AdvancedHMI.Controls.RotationScale = New MfgControl.AdvancedHMI.Controls.RotationScale()
        Dim TranslationScale1 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale2 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale3 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim TranslationScale4 As MfgControl.AdvancedHMI.Controls.TranslationScale = New MfgControl.AdvancedHMI.Controls.TranslationScale()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_template))
        Me.HomeLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber_alarms = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.DataSubscriber_results = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.AnimatingPictureBox1 = New AdvancedHMIControls.AnimatingPictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.HomePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        CType(Me.DataSubscriber_alarms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber_results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimatingPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeLabel
        '
        Me.HomeLabel.BackColor = System.Drawing.Color.White
        Me.HomeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeLabel.ForeColor = System.Drawing.Color.DimGray
        Me.HomeLabel.Location = New System.Drawing.Point(196, 47)
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(219, 40)
        Me.HomeLabel.TabIndex = 271
        Me.HomeLabel.Text = "Home"
        Me.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.40.1"
        Me.EthernetIPforCLXCom1.PollRateOverride = 300
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.SynchronizingObject = Me
        '
        'DataSubscriber_alarms
        '
        Me.DataSubscriber_alarms.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber_alarms.PLCAddressValue = New Drivers.PLCAddressItem("Alarms.Active")
        Me.DataSubscriber_alarms.PollRate = 1000
        Me.DataSubscriber_alarms.SynchronizingObject = Me
        Me.DataSubscriber_alarms.Value = Nothing
        '
        'DataSubscriber_results
        '
        Me.DataSubscriber_results.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber_results.PLCAddressValue = New Drivers.PLCAddressItem("results_ready")
        Me.DataSubscriber_results.PollRate = 300
        Me.DataSubscriber_results.SynchronizingObject = Me
        Me.DataSubscriber_results.Value = Nothing
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(12, 715)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = ""
        Me.BasicLabel1.PLCAddressVisible = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(130, 13)
        Me.BasicLabel1.TabIndex = 293
        Me.BasicLabel1.Text = "1, 150, 299, 448; 756"
        Me.BasicLabel1.Value = "1, 150, 299, 448; 756"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'AnimatingPictureBox1
        '
        Me.AnimatingPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.AnimatingPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimatingPictureBox1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnimatingPictureBox1.Image = CType(resources.GetObject("AnimatingPictureBox1.Image"), System.Drawing.Image)
        RotationScale1.RotationCCWAngle = 0.0!
        RotationScale1.RotationCWAngle = 90.0!
        RotationScale1.RotationMaxValueCCW = 0.0!
        RotationScale1.RotationMaxValueCW = 90.0!
        RotationScale1.XPosition = 0
        RotationScale1.YPosition = 0
        Me.AnimatingPictureBox1.ImageRotationScale = RotationScale1
        Me.AnimatingPictureBox1.ImageRotationValue = 0.0!
        TranslationScale1.ErrorValue = 1.0R
        TranslationScale1.InputMaxValue = 1.0R
        TranslationScale1.InputMinValue = 0.0R
        TranslationScale1.OutputMaxValue = 1.0R
        TranslationScale1.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageSizeXScale = TranslationScale1
        Me.AnimatingPictureBox1.ImageSizeXValue = 1.0R
        TranslationScale2.ErrorValue = 1.0R
        TranslationScale2.InputMaxValue = 1.0R
        TranslationScale2.InputMinValue = 0.0R
        TranslationScale2.OutputMaxValue = 1.0R
        TranslationScale2.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageSizeYScale = TranslationScale2
        Me.AnimatingPictureBox1.ImageSizeYValue = 1.0R
        TranslationScale3.ErrorValue = 0.0R
        TranslationScale3.InputMaxValue = 100.0R
        TranslationScale3.InputMinValue = 0.0R
        TranslationScale3.OutputMaxValue = 100.0R
        TranslationScale3.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageTranslateXScale = TranslationScale3
        Me.AnimatingPictureBox1.ImageTranslateXValue = 0
        TranslationScale4.ErrorValue = 0.0R
        TranslationScale4.InputMaxValue = 100.0R
        TranslationScale4.InputMinValue = 0.0R
        TranslationScale4.OutputMaxValue = 100.0R
        TranslationScale4.OutputMinValue = 0.0R
        Me.AnimatingPictureBox1.ImageTranslateYScale = TranslationScale4
        Me.AnimatingPictureBox1.ImageTranslateYValue = 0
        Me.AnimatingPictureBox1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnimatingPictureBox1.KeypadMaxValue = 0.0R
        Me.AnimatingPictureBox1.KeypadMinValue = 0.0R
        Me.AnimatingPictureBox1.KeypadScaleFactor = 1.0R
        Me.AnimatingPictureBox1.KeypadText = Nothing
        Me.AnimatingPictureBox1.KeypadWidth = 300
        Me.AnimatingPictureBox1.Location = New System.Drawing.Point(141, 223)
        Me.AnimatingPictureBox1.Name = "AnimatingPictureBox1"
        Me.AnimatingPictureBox1.PLCAddressImageRotationValue = ""
        Me.AnimatingPictureBox1.PLCAddressImageTranslateXValue = ""
        Me.AnimatingPictureBox1.PLCAddressImageTranslateYValue = ""
        Me.AnimatingPictureBox1.PLCAddressKeypad = ""
        Me.AnimatingPictureBox1.PLCAddressVisible = "Stations[0].Occ"
        Me.AnimatingPictureBox1.Size = New System.Drawing.Size(23, 40)
        Me.AnimatingPictureBox1.TabIndex = 294
        Me.AnimatingPictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(448, 756)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 44)
        Me.Button3.TabIndex = 292
        Me.Button3.Text = "Home"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(299, 756)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 44)
        Me.Button2.TabIndex = 291
        Me.Button2.Text = "Home"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(150, 756)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 290
        Me.Button1.Text = "Home"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
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
        'HomePictureBox
        '
        Me.HomePictureBox.BackColor = System.Drawing.Color.White
        Me.HomePictureBox.Image = CType(resources.GetObject("HomePictureBox.Image"), System.Drawing.Image)
        Me.HomePictureBox.Location = New System.Drawing.Point(141, 47)
        Me.HomePictureBox.Name = "HomePictureBox"
        Me.HomePictureBox.Size = New System.Drawing.Size(46, 40)
        Me.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.HomePictureBox.TabIndex = 272
        Me.HomePictureBox.TabStop = False
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
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0.0R
        Me.BasicLabel2.KeypadMinValue = 0.0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(140, 265)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = "00"
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = "Stations[0].Mould_No"
        Me.BasicLabel2.PLCAddressVisible = "Stations[0].Occ"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(21, 13)
        Me.BasicLabel2.TabIndex = 295
        Me.BasicLabel2.Text = "00"
        Me.BasicLabel2.Value = "0"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.BasicLabel2.ValueLeftPadLength = 2
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.Transparent
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.bellRed
        Me.AlmInd.Location = New System.Drawing.Point(68, 56)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(34, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 378
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
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
        Me.AccessLevelLabel.Location = New System.Drawing.Point(199, 8)
        Me.AccessLevelLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Messages.Add(CType(resources.GetObject("AccessLevelLabel.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.AccessLevelLabel.Name = "AccessLevelLabel"
        Me.AccessLevelLabel.PLCAddressValue = "HMI.SecurityLevel"
        Me.AccessLevelLabel.PLCAddressVisible = ""
        Me.AccessLevelLabel.ShowMessageNumber = False
        Me.AccessLevelLabel.Size = New System.Drawing.Size(65, 19)
        Me.AccessLevelLabel.SpeakMessage = False
        Me.AccessLevelLabel.TabIndex = 406
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.Value = 0
        '
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(29, 5)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(149, 23)
        Me.CurrentDateTime.TabIndex = 405
        Me.CurrentDateTime.Text = "18/08/2015 12:49:30"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'base_template
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.AnimatingPictureBox1)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.HomePictureBox)
        Me.Controls.Add(Me.HomeLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_template"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvancedHMI v3.97c"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSubscriber_alarms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber_results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimatingPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HomePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents HomeLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSubscriber_alarms As AdvancedHMIControls.DataSubscriber
    Friend WithEvents DataSubscriber_results As AdvancedHMIControls.DataSubscriber
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents AnimatingPictureBox1 As AdvancedHMIControls.AnimatingPictureBox
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
End Class
