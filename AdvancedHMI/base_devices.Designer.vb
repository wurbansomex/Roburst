<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class base_devices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base_devices))
        Me.DeviceStatusLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.CurrentDateTime = New AdvancedHMIControls.DateTimeDisplay()
        Me.PickUnitLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.ClampOpenFeedbackLabel = New System.Windows.Forms.Label()
        Me.ClampSolenoidLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator3 = New AdvancedHMIControls.BasicIndicator()
        Me.BusyLabel = New System.Windows.Forms.Label()
        Me.SetOnLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator4 = New AdvancedHMIControls.BasicIndicator()
        Me.InPositionLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator5 = New AdvancedHMIControls.BasicIndicator()
        Me.AlarmLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator6 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretVsdLabel = New System.Windows.Forms.Label()
        Me.TurretFaultedLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator7 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretAtReferenceLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator8 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretActiveLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator9 = New AdvancedHMIControls.BasicIndicator()
        Me.TurretReadyLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator10 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorVsdLabel = New System.Windows.Forms.Label()
        Me.ConveyorFaultedLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator11 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorActiveLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator13 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorReadyLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator14 = New AdvancedHMIControls.BasicIndicator()
        Me.DateTime1 = New AdvancedHMIControls.DateTimeDisplay()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.ConveyorVSDPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.SearchPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TurretHomeLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator12 = New AdvancedHMIControls.BasicIndicator()
        Me.ConveyorAtReferenceLabel = New System.Windows.Forms.Label()
        Me.BasicIndicator15 = New AdvancedHMIControls.BasicIndicator()
        Me.TargetPositionLabel = New System.Windows.Forms.Label()
        Me.TargetPositionValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.PickUnitCurrentPositionLabel = New System.Windows.Forms.Label()
        Me.PickUnitCurrentPosition = New AdvancedHMIControls.BasicLabel()
        Me.AccessLevelLabel = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyorVSDPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeviceStatusLabel
        '
        Me.DeviceStatusLabel.BackColor = System.Drawing.Color.White
        Me.DeviceStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceStatusLabel.ForeColor = System.Drawing.Color.DimGray
        Me.DeviceStatusLabel.Location = New System.Drawing.Point(196, 47)
        Me.DeviceStatusLabel.Name = "DeviceStatusLabel"
        Me.DeviceStatusLabel.Size = New System.Drawing.Size(219, 40)
        Me.DeviceStatusLabel.TabIndex = 271
        Me.DeviceStatusLabel.Text = "Device Status"
        Me.DeviceStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'CurrentDateTime
        '
        Me.CurrentDateTime.BackColor = System.Drawing.Color.White
        Me.CurrentDateTime.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.CurrentDateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.CurrentDateTime.Location = New System.Drawing.Point(7, 3)
        Me.CurrentDateTime.Name = "CurrentDateTime"
        Me.CurrentDateTime.Size = New System.Drawing.Size(171, 23)
        Me.CurrentDateTime.TabIndex = 118
        Me.CurrentDateTime.Text = "30-11-2016 14:51:26"
        Me.CurrentDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PickUnitLabel
        '
        Me.PickUnitLabel.AutoSize = True
        Me.PickUnitLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitLabel.Location = New System.Drawing.Point(133, 126)
        Me.PickUnitLabel.Name = "PickUnitLabel"
        Me.PickUnitLabel.Size = New System.Drawing.Size(64, 20)
        Me.PickUnitLabel.TabIndex = 340
        Me.PickUnitLabel.Text = "Pick unit"
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Location = New System.Drawing.Point(216, 354)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "inPickSt_ClampOpen"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator1.TabIndex = 342
        '
        'ClampOpenFeedbackLabel
        '
        Me.ClampOpenFeedbackLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClampOpenFeedbackLabel.Location = New System.Drawing.Point(16, 354)
        Me.ClampOpenFeedbackLabel.Name = "ClampOpenFeedbackLabel"
        Me.ClampOpenFeedbackLabel.Size = New System.Drawing.Size(169, 15)
        Me.ClampOpenFeedbackLabel.TabIndex = 345
        Me.ClampOpenFeedbackLabel.Text = "Clamp open feedback"
        Me.ClampOpenFeedbackLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ClampSolenoidLabel
        '
        Me.ClampSolenoidLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClampSolenoidLabel.Location = New System.Drawing.Point(11, 328)
        Me.ClampSolenoidLabel.Name = "ClampSolenoidLabel"
        Me.ClampSolenoidLabel.Size = New System.Drawing.Size(174, 15)
        Me.ClampSolenoidLabel.TabIndex = 347
        Me.ClampSolenoidLabel.Text = "Clamp solenoid"
        Me.ClampSolenoidLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Location = New System.Drawing.Point(216, 330)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "outPickSt_Clamp"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator2.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator2.TabIndex = 346
        '
        'BasicIndicator3
        '
        Me.BasicIndicator3.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator3.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator3.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator3.Location = New System.Drawing.Point(370, 164)
        Me.BasicIndicator3.Name = "BasicIndicator3"
        Me.BasicIndicator3.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator3.OutlineWidth = 1
        Me.BasicIndicator3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator3.PLCAddressSelectColor2 = "iPickUnit.BUSY"
        Me.BasicIndicator3.SelectColor2 = False
        Me.BasicIndicator3.SelectColor3 = False
        Me.BasicIndicator3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator3.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator3.TabIndex = 348
        '
        'BusyLabel
        '
        Me.BusyLabel.AutoSize = True
        Me.BusyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusyLabel.Location = New System.Drawing.Point(392, 162)
        Me.BusyLabel.Name = "BusyLabel"
        Me.BusyLabel.Size = New System.Drawing.Size(32, 15)
        Me.BusyLabel.TabIndex = 349
        Me.BusyLabel.Text = "Busy"
        '
        'SetOnLabel
        '
        Me.SetOnLabel.AutoSize = True
        Me.SetOnLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetOnLabel.Location = New System.Drawing.Point(392, 186)
        Me.SetOnLabel.Name = "SetOnLabel"
        Me.SetOnLabel.Size = New System.Drawing.Size(39, 15)
        Me.SetOnLabel.TabIndex = 351
        Me.SetOnLabel.Text = "SetOn"
        '
        'BasicIndicator4
        '
        Me.BasicIndicator4.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator4.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator4.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator4.Location = New System.Drawing.Point(370, 188)
        Me.BasicIndicator4.Name = "BasicIndicator4"
        Me.BasicIndicator4.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator4.OutlineWidth = 1
        Me.BasicIndicator4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator4.PLCAddressSelectColor2 = "iPickUnit.SETON"
        Me.BasicIndicator4.SelectColor2 = False
        Me.BasicIndicator4.SelectColor3 = False
        Me.BasicIndicator4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator4.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator4.TabIndex = 350
        '
        'InPositionLabel
        '
        Me.InPositionLabel.AutoSize = True
        Me.InPositionLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPositionLabel.Location = New System.Drawing.Point(392, 209)
        Me.InPositionLabel.Name = "InPositionLabel"
        Me.InPositionLabel.Size = New System.Drawing.Size(63, 15)
        Me.InPositionLabel.TabIndex = 353
        Me.InPositionLabel.Text = "In position"
        '
        'BasicIndicator5
        '
        Me.BasicIndicator5.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator5.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator5.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator5.Location = New System.Drawing.Point(370, 211)
        Me.BasicIndicator5.Name = "BasicIndicator5"
        Me.BasicIndicator5.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator5.OutlineWidth = 1
        Me.BasicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator5.PLCAddressSelectColor2 = "iPickUnit.INP"
        Me.BasicIndicator5.SelectColor2 = False
        Me.BasicIndicator5.SelectColor3 = False
        Me.BasicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator5.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator5.TabIndex = 352
        '
        'AlarmLabel
        '
        Me.AlarmLabel.AutoSize = True
        Me.AlarmLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmLabel.Location = New System.Drawing.Point(392, 233)
        Me.AlarmLabel.Name = "AlarmLabel"
        Me.AlarmLabel.Size = New System.Drawing.Size(39, 15)
        Me.AlarmLabel.TabIndex = 355
        Me.AlarmLabel.Text = "Alarm"
        '
        'BasicIndicator6
        '
        Me.BasicIndicator6.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator6.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator6.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator6.Location = New System.Drawing.Point(370, 235)
        Me.BasicIndicator6.Name = "BasicIndicator6"
        Me.BasicIndicator6.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator6.OutlineWidth = 1
        Me.BasicIndicator6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator6.PLCAddressSelectColor2 = "iPickUnit.ALARM"
        Me.BasicIndicator6.SelectColor2 = False
        Me.BasicIndicator6.SelectColor3 = False
        Me.BasicIndicator6.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator6.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator6.TabIndex = 354
        '
        'TurretVsdLabel
        '
        Me.TurretVsdLabel.AutoSize = True
        Me.TurretVsdLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretVsdLabel.Location = New System.Drawing.Point(29, 436)
        Me.TurretVsdLabel.Name = "TurretVsdLabel"
        Me.TurretVsdLabel.Size = New System.Drawing.Size(80, 20)
        Me.TurretVsdLabel.TabIndex = 357
        Me.TurretVsdLabel.Text = "Turret VSD"
        '
        'TurretFaultedLabel
        '
        Me.TurretFaultedLabel.AutoSize = True
        Me.TurretFaultedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretFaultedLabel.Location = New System.Drawing.Point(178, 704)
        Me.TurretFaultedLabel.Name = "TurretFaultedLabel"
        Me.TurretFaultedLabel.Size = New System.Drawing.Size(46, 15)
        Me.TurretFaultedLabel.TabIndex = 365
        Me.TurretFaultedLabel.Text = "Faulted"
        '
        'BasicIndicator7
        '
        Me.BasicIndicator7.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator7.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator7.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator7.Location = New System.Drawing.Point(156, 702)
        Me.BasicIndicator7.Name = "BasicIndicator7"
        Me.BasicIndicator7.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator7.OutlineWidth = 1
        Me.BasicIndicator7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator7.PLCAddressSelectColor2 = "TurretDrive:I.Faulted"
        Me.BasicIndicator7.SelectColor2 = False
        Me.BasicIndicator7.SelectColor3 = False
        Me.BasicIndicator7.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator7.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator7.TabIndex = 364
        '
        'TurretAtReferenceLabel
        '
        Me.TurretAtReferenceLabel.AutoSize = True
        Me.TurretAtReferenceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretAtReferenceLabel.Location = New System.Drawing.Point(178, 680)
        Me.TurretAtReferenceLabel.Name = "TurretAtReferenceLabel"
        Me.TurretAtReferenceLabel.Size = New System.Drawing.Size(71, 15)
        Me.TurretAtReferenceLabel.TabIndex = 363
        Me.TurretAtReferenceLabel.Text = "At reference"
        '
        'BasicIndicator8
        '
        Me.BasicIndicator8.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator8.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator8.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator8.Location = New System.Drawing.Point(156, 678)
        Me.BasicIndicator8.Name = "BasicIndicator8"
        Me.BasicIndicator8.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator8.OutlineWidth = 1
        Me.BasicIndicator8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator8.PLCAddressSelectColor2 = "TurretDrive:I.AtReference"
        Me.BasicIndicator8.SelectColor2 = False
        Me.BasicIndicator8.SelectColor3 = False
        Me.BasicIndicator8.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator8.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator8.TabIndex = 362
        '
        'TurretActiveLabel
        '
        Me.TurretActiveLabel.AutoSize = True
        Me.TurretActiveLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretActiveLabel.Location = New System.Drawing.Point(178, 657)
        Me.TurretActiveLabel.Name = "TurretActiveLabel"
        Me.TurretActiveLabel.Size = New System.Drawing.Size(40, 15)
        Me.TurretActiveLabel.TabIndex = 361
        Me.TurretActiveLabel.Text = "Active"
        '
        'BasicIndicator9
        '
        Me.BasicIndicator9.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator9.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator9.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator9.Location = New System.Drawing.Point(156, 655)
        Me.BasicIndicator9.Name = "BasicIndicator9"
        Me.BasicIndicator9.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator9.OutlineWidth = 1
        Me.BasicIndicator9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator9.PLCAddressSelectColor2 = "TurretDrive:I.Active"
        Me.BasicIndicator9.SelectColor2 = False
        Me.BasicIndicator9.SelectColor3 = False
        Me.BasicIndicator9.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator9.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator9.TabIndex = 360
        '
        'TurretReadyLabel
        '
        Me.TurretReadyLabel.AutoSize = True
        Me.TurretReadyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretReadyLabel.Location = New System.Drawing.Point(178, 633)
        Me.TurretReadyLabel.Name = "TurretReadyLabel"
        Me.TurretReadyLabel.Size = New System.Drawing.Size(39, 15)
        Me.TurretReadyLabel.TabIndex = 359
        Me.TurretReadyLabel.Text = "Ready"
        '
        'BasicIndicator10
        '
        Me.BasicIndicator10.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator10.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator10.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator10.Location = New System.Drawing.Point(156, 631)
        Me.BasicIndicator10.Name = "BasicIndicator10"
        Me.BasicIndicator10.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator10.OutlineWidth = 1
        Me.BasicIndicator10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator10.PLCAddressSelectColor2 = "TurretDrive:I.Ready"
        Me.BasicIndicator10.SelectColor2 = False
        Me.BasicIndicator10.SelectColor3 = False
        Me.BasicIndicator10.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator10.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator10.TabIndex = 358
        '
        'ConveyorVsdLabel
        '
        Me.ConveyorVsdLabel.AutoSize = True
        Me.ConveyorVsdLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorVsdLabel.Location = New System.Drawing.Point(293, 436)
        Me.ConveyorVsdLabel.Name = "ConveyorVsdLabel"
        Me.ConveyorVsdLabel.Size = New System.Drawing.Size(103, 20)
        Me.ConveyorVsdLabel.TabIndex = 367
        Me.ConveyorVsdLabel.Text = "Conveyor VSD"
        '
        'ConveyorFaultedLabel
        '
        Me.ConveyorFaultedLabel.AutoSize = True
        Me.ConveyorFaultedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorFaultedLabel.Location = New System.Drawing.Point(444, 698)
        Me.ConveyorFaultedLabel.Name = "ConveyorFaultedLabel"
        Me.ConveyorFaultedLabel.Size = New System.Drawing.Size(46, 15)
        Me.ConveyorFaultedLabel.TabIndex = 375
        Me.ConveyorFaultedLabel.Text = "Faulted"
        '
        'BasicIndicator11
        '
        Me.BasicIndicator11.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator11.Color2 = System.Drawing.Color.Red
        Me.BasicIndicator11.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator11.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator11.Location = New System.Drawing.Point(422, 696)
        Me.BasicIndicator11.Name = "BasicIndicator11"
        Me.BasicIndicator11.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator11.OutlineWidth = 1
        Me.BasicIndicator11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator11.PLCAddressSelectColor2 = "ConveyorDrive:I.Faulted"
        Me.BasicIndicator11.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator11.SelectColor2 = False
        Me.BasicIndicator11.SelectColor3 = False
        Me.BasicIndicator11.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator11.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator11.TabIndex = 374
        '
        'ConveyorActiveLabel
        '
        Me.ConveyorActiveLabel.AutoSize = True
        Me.ConveyorActiveLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorActiveLabel.Location = New System.Drawing.Point(444, 649)
        Me.ConveyorActiveLabel.Name = "ConveyorActiveLabel"
        Me.ConveyorActiveLabel.Size = New System.Drawing.Size(40, 15)
        Me.ConveyorActiveLabel.TabIndex = 371
        Me.ConveyorActiveLabel.Text = "Active"
        '
        'BasicIndicator13
        '
        Me.BasicIndicator13.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator13.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator13.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator13.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator13.Location = New System.Drawing.Point(422, 647)
        Me.BasicIndicator13.Name = "BasicIndicator13"
        Me.BasicIndicator13.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator13.OutlineWidth = 1
        Me.BasicIndicator13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator13.PLCAddressSelectColor2 = "ConveyorDrive:I.Active"
        Me.BasicIndicator13.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator13.SelectColor2 = False
        Me.BasicIndicator13.SelectColor3 = False
        Me.BasicIndicator13.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator13.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator13.TabIndex = 370
        '
        'ConveyorReadyLabel
        '
        Me.ConveyorReadyLabel.AutoSize = True
        Me.ConveyorReadyLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorReadyLabel.Location = New System.Drawing.Point(444, 625)
        Me.ConveyorReadyLabel.Name = "ConveyorReadyLabel"
        Me.ConveyorReadyLabel.Size = New System.Drawing.Size(39, 15)
        Me.ConveyorReadyLabel.TabIndex = 369
        Me.ConveyorReadyLabel.Text = "Ready"
        '
        'BasicIndicator14
        '
        Me.BasicIndicator14.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator14.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator14.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator14.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator14.Location = New System.Drawing.Point(422, 623)
        Me.BasicIndicator14.Name = "BasicIndicator14"
        Me.BasicIndicator14.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator14.OutlineWidth = 1
        Me.BasicIndicator14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator14.PLCAddressSelectColor2 = "ConveyorDrive:I.Ready"
        Me.BasicIndicator14.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator14.SelectColor2 = False
        Me.BasicIndicator14.SelectColor3 = False
        Me.BasicIndicator14.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator14.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator14.TabIndex = 368
        '
        'DateTime1
        '
        Me.DateTime1.BackColor = System.Drawing.Color.White
        Me.DateTime1.DisplayFormat = "dd/MM/yyyy HH:mm:ss"
        Me.DateTime1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime1.ForeColor = System.Drawing.Color.DimGray
        Me.DateTime1.Location = New System.Drawing.Point(29, 5)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(149, 23)
        Me.DateTime1.TabIndex = 405
        Me.DateTime1.Text = "30-11-2016 14:51:26"
        Me.DateTime1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.time
        Me.PictureBox3.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox3.TabIndex = 408
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.user
        Me.PictureBox7.Location = New System.Drawing.Point(175, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox7.TabIndex = 407
        Me.PictureBox7.TabStop = False
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
        Me.AlmInd.TabIndex = 377
        Me.AlmInd.TabStop = False
        Me.AlmInd.Visible = False
        '
        'ConveyorVSDPictureBox
        '
        Me.ConveyorVSDPictureBox.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Conveyor_View_Small
        Me.ConveyorVSDPictureBox.Location = New System.Drawing.Point(296, 463)
        Me.ConveyorVSDPictureBox.Name = "ConveyorVSDPictureBox"
        Me.ConveyorVSDPictureBox.Size = New System.Drawing.Size(281, 143)
        Me.ConveyorVSDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ConveyorVSDPictureBox.TabIndex = 366
        Me.ConveyorVSDPictureBox.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Turret
        Me.PictureBox5.Location = New System.Drawing.Point(35, 462)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(192, 160)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.PgOpenHomeButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(150, 44)
        Me.PgOpenHomeButton.TabIndex = 289
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PgOpenHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'SearchPictureBox
        '
        Me.SearchPictureBox.BackColor = System.Drawing.Color.White
        Me.SearchPictureBox.Image = CType(resources.GetObject("SearchPictureBox.Image"), System.Drawing.Image)
        Me.SearchPictureBox.Location = New System.Drawing.Point(141, 47)
        Me.SearchPictureBox.Name = "SearchPictureBox"
        Me.SearchPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SearchPictureBox.TabIndex = 272
        Me.SearchPictureBox.TabStop = False
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
        Me.PictureBox4.Location = New System.Drawing.Point(221, 126)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(237, 281)
        Me.PictureBox4.TabIndex = 341
        Me.PictureBox4.TabStop = False
        '
        'TurretHomeLabel
        '
        Me.TurretHomeLabel.AutoSize = True
        Me.TurretHomeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurretHomeLabel.Location = New System.Drawing.Point(102, 633)
        Me.TurretHomeLabel.Name = "TurretHomeLabel"
        Me.TurretHomeLabel.Size = New System.Drawing.Size(40, 15)
        Me.TurretHomeLabel.TabIndex = 438
        Me.TurretHomeLabel.Text = "Home"
        '
        'BasicIndicator12
        '
        Me.BasicIndicator12.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator12.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator12.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator12.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator12.Location = New System.Drawing.Point(80, 633)
        Me.BasicIndicator12.Name = "BasicIndicator12"
        Me.BasicIndicator12.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator12.OutlineWidth = 1
        Me.BasicIndicator12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator12.PLCAddressSelectColor2 = "Local:1:I.Data.0"
        Me.BasicIndicator12.SelectColor2 = False
        Me.BasicIndicator12.SelectColor3 = False
        Me.BasicIndicator12.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator12.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator12.TabIndex = 437
        '
        'ConveyorAtReferenceLabel
        '
        Me.ConveyorAtReferenceLabel.AutoSize = True
        Me.ConveyorAtReferenceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConveyorAtReferenceLabel.Location = New System.Drawing.Point(444, 673)
        Me.ConveyorAtReferenceLabel.Name = "ConveyorAtReferenceLabel"
        Me.ConveyorAtReferenceLabel.Size = New System.Drawing.Size(71, 15)
        Me.ConveyorAtReferenceLabel.TabIndex = 440
        Me.ConveyorAtReferenceLabel.Text = "At reference"
        '
        'BasicIndicator15
        '
        Me.BasicIndicator15.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator15.Color2 = System.Drawing.Color.Lime
        Me.BasicIndicator15.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator15.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator15.Location = New System.Drawing.Point(422, 671)
        Me.BasicIndicator15.Name = "BasicIndicator15"
        Me.BasicIndicator15.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator15.OutlineWidth = 1
        Me.BasicIndicator15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator15.PLCAddressSelectColor2 = "ConveyorDrive:I.AtReference"
        Me.BasicIndicator15.PLCAddressVisible = "NOT Conveyor.Bits[0].0"
        Me.BasicIndicator15.SelectColor2 = False
        Me.BasicIndicator15.SelectColor3 = False
        Me.BasicIndicator15.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator15.Size = New System.Drawing.Size(18, 18)
        Me.BasicIndicator15.TabIndex = 439
        '
        'TargetPositionLabel
        '
        Me.TargetPositionLabel.AutoSize = True
        Me.TargetPositionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPositionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TargetPositionLabel.Location = New System.Drawing.Point(340, 345)
        Me.TargetPositionLabel.Name = "TargetPositionLabel"
        Me.TargetPositionLabel.Size = New System.Drawing.Size(101, 19)
        Me.TargetPositionLabel.TabIndex = 444
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
        Me.TargetPositionValueBasicLabel.HighlightColor = System.Drawing.Color.Gray
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
        Me.TargetPositionValueBasicLabel.Location = New System.Drawing.Point(344, 365)
        Me.TargetPositionValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.TargetPositionValueBasicLabel.Name = "TargetPositionValueBasicLabel"
        Me.TargetPositionValueBasicLabel.NumericFormat = "000.0"
        Me.TargetPositionValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TargetPositionValueBasicLabel.PLCAddressKeypad = ""
        Me.TargetPositionValueBasicLabel.PLCAddressValue = "iPickUnit.Target_Position"
        Me.TargetPositionValueBasicLabel.PollRate = 0
        Me.TargetPositionValueBasicLabel.Size = New System.Drawing.Size(97, 27)
        Me.TargetPositionValueBasicLabel.TabIndex = 443
        Me.TargetPositionValueBasicLabel.Text = "001.0"
        Me.TargetPositionValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TargetPositionValueBasicLabel.UseMnemonic = False
        Me.TargetPositionValueBasicLabel.Value = "100.0"
        Me.TargetPositionValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TargetPositionValueBasicLabel.ValueLeftPadLength = 0
        Me.TargetPositionValueBasicLabel.ValuePrefix = Nothing
        Me.TargetPositionValueBasicLabel.ValueScaleFactor = 0.01R
        Me.TargetPositionValueBasicLabel.ValueSuffix = Nothing
        '
        'PickUnitCurrentPositionLabel
        '
        Me.PickUnitCurrentPositionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.PickUnitCurrentPositionLabel.AutoSize = True
        Me.PickUnitCurrentPositionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUnitCurrentPositionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PickUnitCurrentPositionLabel.Location = New System.Drawing.Point(340, 275)
        Me.PickUnitCurrentPositionLabel.Name = "PickUnitCurrentPositionLabel"
        Me.PickUnitCurrentPositionLabel.Size = New System.Drawing.Size(109, 19)
        Me.PickUnitCurrentPositionLabel.TabIndex = 442
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
        Me.PickUnitCurrentPosition.HighlightColor = System.Drawing.Color.Gray
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
        Me.PickUnitCurrentPosition.Location = New System.Drawing.Point(344, 294)
        Me.PickUnitCurrentPosition.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.PickUnitCurrentPosition.Name = "PickUnitCurrentPosition"
        Me.PickUnitCurrentPosition.NumericFormat = "000.0"
        Me.PickUnitCurrentPosition.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PickUnitCurrentPosition.PLCAddressKeypad = ""
        Me.PickUnitCurrentPosition.PLCAddressValue = "iPickUnit.Current_Position"
        Me.PickUnitCurrentPosition.PollRate = 0
        Me.PickUnitCurrentPosition.Size = New System.Drawing.Size(97, 27)
        Me.PickUnitCurrentPosition.TabIndex = 441
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
        Me.AccessLevelLabel.TabIndex = 445
        Me.AccessLevelLabel.Text = "Operator"
        Me.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccessLevelLabel.TextPrefix = Nothing
        Me.AccessLevelLabel.Value = 0
        '
        'base_devices
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(600, 742)
        Me.Controls.Add(Me.AccessLevelLabel)
        Me.Controls.Add(Me.TargetPositionLabel)
        Me.Controls.Add(Me.TargetPositionValueBasicLabel)
        Me.Controls.Add(Me.PickUnitCurrentPositionLabel)
        Me.Controls.Add(Me.PickUnitCurrentPosition)
        Me.Controls.Add(Me.ConveyorAtReferenceLabel)
        Me.Controls.Add(Me.BasicIndicator15)
        Me.Controls.Add(Me.TurretHomeLabel)
        Me.Controls.Add(Me.BasicIndicator12)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.ConveyorFaultedLabel)
        Me.Controls.Add(Me.BasicIndicator11)
        Me.Controls.Add(Me.ConveyorActiveLabel)
        Me.Controls.Add(Me.BasicIndicator13)
        Me.Controls.Add(Me.ConveyorReadyLabel)
        Me.Controls.Add(Me.BasicIndicator14)
        Me.Controls.Add(Me.ConveyorVsdLabel)
        Me.Controls.Add(Me.ConveyorVSDPictureBox)
        Me.Controls.Add(Me.TurretFaultedLabel)
        Me.Controls.Add(Me.BasicIndicator7)
        Me.Controls.Add(Me.TurretAtReferenceLabel)
        Me.Controls.Add(Me.BasicIndicator8)
        Me.Controls.Add(Me.TurretActiveLabel)
        Me.Controls.Add(Me.BasicIndicator9)
        Me.Controls.Add(Me.TurretReadyLabel)
        Me.Controls.Add(Me.BasicIndicator10)
        Me.Controls.Add(Me.TurretVsdLabel)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.AlarmLabel)
        Me.Controls.Add(Me.BasicIndicator6)
        Me.Controls.Add(Me.InPositionLabel)
        Me.Controls.Add(Me.BasicIndicator5)
        Me.Controls.Add(Me.SetOnLabel)
        Me.Controls.Add(Me.BasicIndicator4)
        Me.Controls.Add(Me.BusyLabel)
        Me.Controls.Add(Me.BasicIndicator3)
        Me.Controls.Add(Me.ClampSolenoidLabel)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.ClampOpenFeedbackLabel)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.PickUnitLabel)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.Controls.Add(Me.SearchPictureBox)
        Me.Controls.Add(Me.DeviceStatusLabel)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.CurrentDateTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "base_devices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somex.Roburst.HMI.DeviceStatus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyorVSDPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentDateTime As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SearchPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DeviceStatusLabel As System.Windows.Forms.Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents PickUnitLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents AlarmLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator6 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents InPositionLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator5 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents SetOnLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator4 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BusyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator3 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ClampSolenoidLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ClampOpenFeedbackLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents TurretFaultedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator7 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretAtReferenceLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator8 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretActiveLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator9 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretReadyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator10 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TurretVsdLabel As System.Windows.Forms.Label
    Friend WithEvents ConveyorVSDPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ConveyorFaultedLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator11 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorActiveLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator13 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorReadyLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator14 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorVsdLabel As System.Windows.Forms.Label
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTime1 As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents TurretHomeLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator12 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents ConveyorAtReferenceLabel As System.Windows.Forms.Label
    Friend WithEvents BasicIndicator15 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents TargetPositionLabel As System.Windows.Forms.Label
    Friend WithEvents TargetPositionValueBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PickUnitCurrentPositionLabel As System.Windows.Forms.Label
    Friend WithEvents PickUnitCurrentPosition As AdvancedHMIControls.BasicLabel
    Friend WithEvents AccessLevelLabel As AdvancedHMIControls.MessageDisplayByValue
End Class
