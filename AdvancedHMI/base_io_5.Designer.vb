<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_io_5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_io_5))
        Me.DigitalOutputsLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.SquareIlluminatedButton9 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton8 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton7 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton6 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton5 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton4 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.TopUpValveLabel = New System.Windows.Forms.Label()
        Me.VentValveLabel = New System.Windows.Forms.Label()
        Me.WashDownValveLabel = New System.Windows.Forms.Label()
        Me.MachineRunningOutputLabel = New System.Windows.Forms.Label()
        Me.SpareO56Label = New System.Windows.Forms.Label()
        Me.SpareO57Label = New System.Windows.Forms.Label()
        Me.StationSlowFillValveLabel = New System.Windows.Forms.Label()
        Me.SquareIlluminatedButton2 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.StationFastFillValveLabel = New System.Windows.Forms.Label()
        Me.SquareIlluminatedButton1 = New AdvancedHMIControls.SquareIlluminatedButton()
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
        Me.DigitalOutputsPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalOutputsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DigitalOutputsLabel
        '
        Me.DigitalOutputsLabel.BackColor = System.Drawing.Color.White
        Me.DigitalOutputsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalOutputsLabel.ForeColor = System.Drawing.Color.DimGray
        Me.DigitalOutputsLabel.Location = New System.Drawing.Point(196, 47)
        Me.DigitalOutputsLabel.Name = "DigitalOutputsLabel"
        Me.DigitalOutputsLabel.Size = New System.Drawing.Size(219, 40)
        Me.DigitalOutputsLabel.TabIndex = 271
        Me.DigitalOutputsLabel.Text = "Digital outputs"
        Me.DigitalOutputsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'SquareIlluminatedButton9
        '
        Me.SquareIlluminatedButton9.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton9.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton9.Location = New System.Drawing.Point(374, 486)
        Me.SquareIlluminatedButton9.Name = "SquareIlluminatedButton9"
        Me.SquareIlluminatedButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton9.PLCAddressClick = ""
        Me.SquareIlluminatedButton9.PLCAddressText = ""
        Me.SquareIlluminatedButton9.PLCAddressValue = "Local:5:O.Data.7"
        Me.SquareIlluminatedButton9.PLCAddressVisible = ""
        Me.SquareIlluminatedButton9.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton9.TabIndex = 344
        Me.SquareIlluminatedButton9.Value = False
        '
        'SquareIlluminatedButton8
        '
        Me.SquareIlluminatedButton8.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton8.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton8.Location = New System.Drawing.Point(374, 448)
        Me.SquareIlluminatedButton8.Name = "SquareIlluminatedButton8"
        Me.SquareIlluminatedButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton8.PLCAddressClick = ""
        Me.SquareIlluminatedButton8.PLCAddressText = ""
        Me.SquareIlluminatedButton8.PLCAddressValue = "Local:5:O.Data.6"
        Me.SquareIlluminatedButton8.PLCAddressVisible = ""
        Me.SquareIlluminatedButton8.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton8.TabIndex = 343
        Me.SquareIlluminatedButton8.Value = False
        '
        'SquareIlluminatedButton7
        '
        Me.SquareIlluminatedButton7.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton7.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton7.Location = New System.Drawing.Point(374, 410)
        Me.SquareIlluminatedButton7.Name = "SquareIlluminatedButton7"
        Me.SquareIlluminatedButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton7.PLCAddressClick = ""
        Me.SquareIlluminatedButton7.PLCAddressText = ""
        Me.SquareIlluminatedButton7.PLCAddressValue = "Local:5:O.Data.5"
        Me.SquareIlluminatedButton7.PLCAddressVisible = ""
        Me.SquareIlluminatedButton7.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton7.TabIndex = 342
        Me.SquareIlluminatedButton7.Value = False
        '
        'SquareIlluminatedButton6
        '
        Me.SquareIlluminatedButton6.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton6.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton6.Location = New System.Drawing.Point(374, 372)
        Me.SquareIlluminatedButton6.Name = "SquareIlluminatedButton6"
        Me.SquareIlluminatedButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton6.PLCAddressClick = ""
        Me.SquareIlluminatedButton6.PLCAddressText = ""
        Me.SquareIlluminatedButton6.PLCAddressValue = "Local:5:O.Data.4"
        Me.SquareIlluminatedButton6.PLCAddressVisible = ""
        Me.SquareIlluminatedButton6.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton6.TabIndex = 341
        Me.SquareIlluminatedButton6.Value = False
        '
        'SquareIlluminatedButton5
        '
        Me.SquareIlluminatedButton5.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton5.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton5.Location = New System.Drawing.Point(374, 334)
        Me.SquareIlluminatedButton5.Name = "SquareIlluminatedButton5"
        Me.SquareIlluminatedButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton5.PLCAddressClick = ""
        Me.SquareIlluminatedButton5.PLCAddressText = ""
        Me.SquareIlluminatedButton5.PLCAddressValue = "Local:5:O.Data.3"
        Me.SquareIlluminatedButton5.PLCAddressVisible = ""
        Me.SquareIlluminatedButton5.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton5.TabIndex = 340
        Me.SquareIlluminatedButton5.Value = False
        '
        'SquareIlluminatedButton4
        '
        Me.SquareIlluminatedButton4.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton4.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton4.Location = New System.Drawing.Point(374, 296)
        Me.SquareIlluminatedButton4.Name = "SquareIlluminatedButton4"
        Me.SquareIlluminatedButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton4.PLCAddressClick = ""
        Me.SquareIlluminatedButton4.PLCAddressText = ""
        Me.SquareIlluminatedButton4.PLCAddressValue = "Local:5:O.Data.2"
        Me.SquareIlluminatedButton4.PLCAddressVisible = ""
        Me.SquareIlluminatedButton4.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton4.TabIndex = 339
        Me.SquareIlluminatedButton4.Value = False
        '
        'TopUpValveLabel
        '
        Me.TopUpValveLabel.AutoSize = True
        Me.TopUpValveLabel.BackColor = System.Drawing.Color.Gray
        Me.TopUpValveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopUpValveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TopUpValveLabel.Location = New System.Drawing.Point(29, 295)
        Me.TopUpValveLabel.Name = "TopUpValveLabel"
        Me.TopUpValveLabel.Size = New System.Drawing.Size(128, 19)
        Me.TopUpValveLabel.TabIndex = 338
        Me.TopUpValveLabel.Text = "O:5.2 Top Up Valve"
        Me.TopUpValveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VentValveLabel
        '
        Me.VentValveLabel.AutoSize = True
        Me.VentValveLabel.BackColor = System.Drawing.Color.Gray
        Me.VentValveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentValveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VentValveLabel.Location = New System.Drawing.Point(29, 333)
        Me.VentValveLabel.Name = "VentValveLabel"
        Me.VentValveLabel.Size = New System.Drawing.Size(112, 19)
        Me.VentValveLabel.TabIndex = 337
        Me.VentValveLabel.Text = "O:5.3 Vent Valve"
        Me.VentValveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WashDownValveLabel
        '
        Me.WashDownValveLabel.AutoSize = True
        Me.WashDownValveLabel.BackColor = System.Drawing.Color.Gray
        Me.WashDownValveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WashDownValveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WashDownValveLabel.Location = New System.Drawing.Point(29, 371)
        Me.WashDownValveLabel.Name = "WashDownValveLabel"
        Me.WashDownValveLabel.Size = New System.Drawing.Size(157, 19)
        Me.WashDownValveLabel.TabIndex = 336
        Me.WashDownValveLabel.Text = "O:5.4 Wash Down Valve"
        Me.WashDownValveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MachineRunningOutputLabel
        '
        Me.MachineRunningOutputLabel.AutoSize = True
        Me.MachineRunningOutputLabel.BackColor = System.Drawing.Color.Gray
        Me.MachineRunningOutputLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineRunningOutputLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MachineRunningOutputLabel.Location = New System.Drawing.Point(29, 409)
        Me.MachineRunningOutputLabel.Name = "MachineRunningOutputLabel"
        Me.MachineRunningOutputLabel.Size = New System.Drawing.Size(153, 19)
        Me.MachineRunningOutputLabel.TabIndex = 335
        Me.MachineRunningOutputLabel.Text = "O:5.5 Machine Running"
        Me.MachineRunningOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpareO56Label
        '
        Me.SpareO56Label.AutoSize = True
        Me.SpareO56Label.BackColor = System.Drawing.Color.Gray
        Me.SpareO56Label.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpareO56Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpareO56Label.Location = New System.Drawing.Point(29, 447)
        Me.SpareO56Label.Name = "SpareO56Label"
        Me.SpareO56Label.Size = New System.Drawing.Size(105, 19)
        Me.SpareO56Label.TabIndex = 334
        Me.SpareO56Label.Text = "O:5.6 Spare DO"
        Me.SpareO56Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpareO57Label
        '
        Me.SpareO57Label.AutoSize = True
        Me.SpareO57Label.BackColor = System.Drawing.Color.Gray
        Me.SpareO57Label.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpareO57Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpareO57Label.Location = New System.Drawing.Point(29, 485)
        Me.SpareO57Label.Name = "SpareO57Label"
        Me.SpareO57Label.Size = New System.Drawing.Size(105, 19)
        Me.SpareO57Label.TabIndex = 333
        Me.SpareO57Label.Text = "O:5.7 Spare DO"
        Me.SpareO57Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StationSlowFillValveLabel
        '
        Me.StationSlowFillValveLabel.AutoSize = True
        Me.StationSlowFillValveLabel.BackColor = System.Drawing.Color.Gray
        Me.StationSlowFillValveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StationSlowFillValveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StationSlowFillValveLabel.Location = New System.Drawing.Point(29, 257)
        Me.StationSlowFillValveLabel.Name = "StationSlowFillValveLabel"
        Me.StationSlowFillValveLabel.Size = New System.Drawing.Size(178, 19)
        Me.StationSlowFillValveLabel.TabIndex = 332
        Me.StationSlowFillValveLabel.Text = "O:5.1 Station Slow Fill Valve"
        Me.StationSlowFillValveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SquareIlluminatedButton2
        '
        Me.SquareIlluminatedButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton2.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton2.Location = New System.Drawing.Point(374, 258)
        Me.SquareIlluminatedButton2.Name = "SquareIlluminatedButton2"
        Me.SquareIlluminatedButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton2.PLCAddressClick = ""
        Me.SquareIlluminatedButton2.PLCAddressText = ""
        Me.SquareIlluminatedButton2.PLCAddressValue = "Local:5:O.Data.1"
        Me.SquareIlluminatedButton2.PLCAddressVisible = ""
        Me.SquareIlluminatedButton2.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton2.TabIndex = 331
        Me.SquareIlluminatedButton2.Value = False
        '
        'StationFastFillValveLabel
        '
        Me.StationFastFillValveLabel.AutoSize = True
        Me.StationFastFillValveLabel.BackColor = System.Drawing.Color.Gray
        Me.StationFastFillValveLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StationFastFillValveLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StationFastFillValveLabel.Location = New System.Drawing.Point(29, 219)
        Me.StationFastFillValveLabel.Name = "StationFastFillValveLabel"
        Me.StationFastFillValveLabel.Size = New System.Drawing.Size(175, 19)
        Me.StationFastFillValveLabel.TabIndex = 329
        Me.StationFastFillValveLabel.Text = "O:5.0 Station Fast Fill Valve"
        Me.StationFastFillValveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SquareIlluminatedButton1
        '
        Me.SquareIlluminatedButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton1.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColors.Green
        Me.SquareIlluminatedButton1.Location = New System.Drawing.Point(374, 220)
        Me.SquareIlluminatedButton1.Name = "SquareIlluminatedButton1"
        Me.SquareIlluminatedButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton1.PLCAddressClick = ""
        Me.SquareIlluminatedButton1.PLCAddressText = ""
        Me.SquareIlluminatedButton1.PLCAddressValue = "Local:5:O.Data.0"
        Me.SquareIlluminatedButton1.PLCAddressVisible = ""
        Me.SquareIlluminatedButton1.Size = New System.Drawing.Size(40, 24)
        Me.SquareIlluminatedButton1.TabIndex = 328
        Me.SquareIlluminatedButton1.Value = False
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
        Me.CurrentDateTime.Text = "30-11-2016 14:52:11"
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
        Me.AlmInd.TabIndex = 378
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
        Me.DigitalInputs1Button.Location = New System.Drawing.Point(442, 474)
        Me.DigitalInputs1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalInputs1Button.Name = "DigitalInputs1Button"
        Me.DigitalInputs1Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalInputs1Button.TabIndex = 366
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
        Me.DigitalInputs2Button.Location = New System.Drawing.Point(442, 525)
        Me.DigitalInputs2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalInputs2Button.Name = "DigitalInputs2Button"
        Me.DigitalInputs2Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalInputs2Button.TabIndex = 365
        Me.DigitalInputs2Button.Text = "Digital Inputs 2"
        Me.DigitalInputs2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalInputs2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalInputs2Button.UseVisualStyleBackColor = True
        '
        'AnalogsButton
        '
        Me.AnalogsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogsButton.ForeColor = System.Drawing.Color.Black
        Me.AnalogsButton.Image = CType(resources.GetObject("AnalogsButton.Image"), System.Drawing.Image)
        Me.AnalogsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AnalogsButton.Location = New System.Drawing.Point(442, 576)
        Me.AnalogsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AnalogsButton.Name = "AnalogsButton"
        Me.AnalogsButton.Size = New System.Drawing.Size(150, 44)
        Me.AnalogsButton.TabIndex = 364
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
        Me.DigitalOutputs1Button.Location = New System.Drawing.Point(442, 627)
        Me.DigitalOutputs1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalOutputs1Button.Name = "DigitalOutputs1Button"
        Me.DigitalOutputs1Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalOutputs1Button.TabIndex = 363
        Me.DigitalOutputs1Button.Text = "Digital Outputs 1"
        Me.DigitalOutputs1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DigitalOutputs1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DigitalOutputs1Button.UseVisualStyleBackColor = True
        '
        'DigitalOutputs2Button
        '
        Me.DigitalOutputs2Button.Enabled = False
        Me.DigitalOutputs2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalOutputs2Button.ForeColor = System.Drawing.Color.Black
        Me.DigitalOutputs2Button.Image = CType(resources.GetObject("DigitalOutputs2Button.Image"), System.Drawing.Image)
        Me.DigitalOutputs2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DigitalOutputs2Button.Location = New System.Drawing.Point(442, 678)
        Me.DigitalOutputs2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.DigitalOutputs2Button.Name = "DigitalOutputs2Button"
        Me.DigitalOutputs2Button.Size = New System.Drawing.Size(150, 44)
        Me.DigitalOutputs2Button.TabIndex = 362
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
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(0, 756)
        Me.PgOpenHomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 326
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'DigitalOutputsPictureBox
        '
        Me.DigitalOutputsPictureBox.BackColor = System.Drawing.Color.White
        Me.DigitalOutputsPictureBox.Image = CType(resources.GetObject("DigitalOutputsPictureBox.Image"), System.Drawing.Image)
        Me.DigitalOutputsPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.DigitalOutputsPictureBox.Name = "DigitalOutputsPictureBox"
        Me.DigitalOutputsPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.DigitalOutputsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DigitalOutputsPictureBox.TabIndex = 272
        Me.DigitalOutputsPictureBox.TabStop = False
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
        'base_io_5
        '
        Me.AutoScroll = True
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
        Me.Controls.Add(Me.SquareIlluminatedButton9)
        Me.Controls.Add(Me.SquareIlluminatedButton8)
        Me.Controls.Add(Me.SquareIlluminatedButton7)
        Me.Controls.Add(Me.SquareIlluminatedButton6)
        Me.Controls.Add(Me.SquareIlluminatedButton5)
        Me.Controls.Add(Me.SquareIlluminatedButton4)
        Me.Controls.Add(Me.TopUpValveLabel)
        Me.Controls.Add(Me.VentValveLabel)
        Me.Controls.Add(Me.WashDownValveLabel)
        Me.Controls.Add(Me.MachineRunningOutputLabel)
        Me.Controls.Add(Me.SpareO56Label)
        Me.Controls.Add(Me.SpareO57Label)
        Me.Controls.Add(Me.StationSlowFillValveLabel)
        Me.Controls.Add(Me.SquareIlluminatedButton2)
        Me.Controls.Add(Me.StationFastFillValveLabel)
        Me.Controls.Add(Me.SquareIlluminatedButton1)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.DigitalOutputsPictureBox)
        Me.Controls.Add(Me.DigitalOutputsLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_io_5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.IO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalOutputsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DigitalOutputsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DigitalOutputsLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SquareIlluminatedButton9 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton8 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton7 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton6 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton5 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton4 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents TopUpValveLabel As System.Windows.Forms.Label
    Friend WithEvents VentValveLabel As System.Windows.Forms.Label
    Friend WithEvents WashDownValveLabel As System.Windows.Forms.Label
    Friend WithEvents MachineRunningOutputLabel As System.Windows.Forms.Label
    Friend WithEvents SpareO56Label As System.Windows.Forms.Label
    Friend WithEvents SpareO57Label As System.Windows.Forms.Label
    Friend WithEvents StationSlowFillValveLabel As System.Windows.Forms.Label
    Friend WithEvents SquareIlluminatedButton2 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents StationFastFillValveLabel As System.Windows.Forms.Label
    Friend WithEvents SquareIlluminatedButton1 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
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
