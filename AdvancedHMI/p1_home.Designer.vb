<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p1_home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p1_home))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.PgOpenHomeButton = New System.Windows.Forms.Button()
        Me.PgOpenAlarmsButton = New System.Windows.Forms.Button()
        Me.PgOpenResultsButton = New System.Windows.Forms.Button()
        Me.PgOpenSettingsButton = New System.Windows.Forms.Button()
        Me.PgOpenManualButton = New System.Windows.Forms.Button()
        Me.PgOpenStatusButton = New System.Windows.Forms.Button()
        Me.PgOpenRecipeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AppExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TestEntImp = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PositionInd = New AdvancedHMIControls.BasicLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WriteTestBtn = New System.Windows.Forms.Button()
        Me.MergeTestBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        'PgOpenHomeButton
        '
        Me.PgOpenHomeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenHomeButton.Location = New System.Drawing.Point(630, 496)
        Me.PgOpenHomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenHomeButton.Name = "PgOpenHomeButton"
        Me.PgOpenHomeButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenHomeButton.TabIndex = 3
        Me.PgOpenHomeButton.Text = "Home"
        Me.PgOpenHomeButton.UseVisualStyleBackColor = True
        '
        'PgOpenAlarmsButton
        '
        Me.PgOpenAlarmsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenAlarmsButton.Location = New System.Drawing.Point(630, 438)
        Me.PgOpenAlarmsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenAlarmsButton.Name = "PgOpenAlarmsButton"
        Me.PgOpenAlarmsButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenAlarmsButton.TabIndex = 4
        Me.PgOpenAlarmsButton.Text = "Alarms"
        Me.PgOpenAlarmsButton.UseVisualStyleBackColor = True
        '
        'PgOpenResultsButton
        '
        Me.PgOpenResultsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenResultsButton.Location = New System.Drawing.Point(630, 378)
        Me.PgOpenResultsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenResultsButton.Name = "PgOpenResultsButton"
        Me.PgOpenResultsButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenResultsButton.TabIndex = 5
        Me.PgOpenResultsButton.Text = "Results"
        Me.PgOpenResultsButton.UseVisualStyleBackColor = True
        '
        'PgOpenSettingsButton
        '
        Me.PgOpenSettingsButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenSettingsButton.Location = New System.Drawing.Point(630, 318)
        Me.PgOpenSettingsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenSettingsButton.Name = "PgOpenSettingsButton"
        Me.PgOpenSettingsButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenSettingsButton.TabIndex = 6
        Me.PgOpenSettingsButton.Text = "Settings"
        Me.PgOpenSettingsButton.UseVisualStyleBackColor = True
        '
        'PgOpenManualButton
        '
        Me.PgOpenManualButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenManualButton.Location = New System.Drawing.Point(630, 258)
        Me.PgOpenManualButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenManualButton.Name = "PgOpenManualButton"
        Me.PgOpenManualButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenManualButton.TabIndex = 7
        Me.PgOpenManualButton.Text = "Manual"
        Me.PgOpenManualButton.UseVisualStyleBackColor = True
        '
        'PgOpenStatusButton
        '
        Me.PgOpenStatusButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenStatusButton.Location = New System.Drawing.Point(630, 198)
        Me.PgOpenStatusButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenStatusButton.Name = "PgOpenStatusButton"
        Me.PgOpenStatusButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenStatusButton.TabIndex = 8
        Me.PgOpenStatusButton.Text = "Status"
        Me.PgOpenStatusButton.UseVisualStyleBackColor = True
        '
        'PgOpenRecipeButton
        '
        Me.PgOpenRecipeButton.ForeColor = System.Drawing.Color.Black
        Me.PgOpenRecipeButton.Location = New System.Drawing.Point(630, 138)
        Me.PgOpenRecipeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PgOpenRecipeButton.Name = "PgOpenRecipeButton"
        Me.PgOpenRecipeButton.Size = New System.Drawing.Size(140, 44)
        Me.PgOpenRecipeButton.TabIndex = 9
        Me.PgOpenRecipeButton.Text = "Recipe"
        Me.PgOpenRecipeButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 62)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'AppExit
        '
        Me.AppExit.ForeColor = System.Drawing.Color.Black
        Me.AppExit.Location = New System.Drawing.Point(26, 496)
        Me.AppExit.Margin = New System.Windows.Forms.Padding(4)
        Me.AppExit.Name = "AppExit"
        Me.AppExit.Size = New System.Drawing.Size(142, 44)
        Me.AppExit.TabIndex = 11
        Me.AppExit.Text = "Exit HMI + End"
        Me.AppExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TestEntImp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(38, 143)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(97, 54)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'TestEntImp
        '
        Me.TestEntImp.AutoSize = True
        Me.TestEntImp.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.TestEntImp.ComComponent = Me.EthernetIPforCLXCom1
        Me.TestEntImp.Dock = System.Windows.Forms.DockStyle.Right
        Me.TestEntImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestEntImp.ForeColor = System.Drawing.Color.Navy
        Me.TestEntImp.HighlightColor = System.Drawing.Color.Red
        Me.TestEntImp.HighlightKeyCharacter = "!"
        Me.TestEntImp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TestEntImp.KeypadAlphaNumeric = False
        Me.TestEntImp.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestEntImp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.TestEntImp.KeypadMaxValue = 0.0R
        Me.TestEntImp.KeypadMinValue = 0.0R
        Me.TestEntImp.KeypadScaleFactor = 1.0R
        Me.TestEntImp.KeypadText = Nothing
        Me.TestEntImp.KeypadWidth = 600
        Me.TestEntImp.Location = New System.Drawing.Point(4, 19)
        Me.TestEntImp.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.TestEntImp.Name = "TestEntImp"
        Me.TestEntImp.NumericFormat = "000.00"
        Me.TestEntImp.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TestEntImp.PLCAddressKeypad = "TestImpulse"
        Me.TestEntImp.PLCAddressValue = "TestImpulse"
        Me.TestEntImp.PLCAddressVisible = ""
        Me.TestEntImp.PollRate = 0
        Me.TestEntImp.Size = New System.Drawing.Size(90, 32)
        Me.TestEntImp.TabIndex = 55
        Me.TestEntImp.Text = "111.11"
        Me.TestEntImp.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.TestEntImp.Value = "111.11"
        Me.TestEntImp.ValuePrefix = Nothing
        Me.TestEntImp.ValueScaleFactor = 1.0R
        Me.TestEntImp.ValueSuffix = Nothing
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
        Me.BasicLabel1.Location = New System.Drawing.Point(36, 121)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = ""
        Me.BasicLabel1.PLCAddressVisible = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(88, 17)
        Me.BasicLabel1.TabIndex = 59
        Me.BasicLabel1.Text = "Test Impulse"
        Me.BasicLabel1.Value = "Test Impulse"
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
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
        Me.BasicLabel2.Location = New System.Drawing.Point(163, 121)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = ""
        Me.BasicLabel2.PLCAddressVisible = ""
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(428, 17)
        Me.BasicLabel2.TabIndex = 61
        Me.BasicLabel2.Text = "Impulse units 0=degrees 1=V(m/s) 2=V^2 3=KE 4=IE 5=in/s 6=cm/s"
        Me.BasicLabel2.Value = "Impulse units 0=degrees 1=V(m/s) 2=V^2 3=KE 4=IE 5=in/s 6=cm/s"
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BasicLabel3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(197, 143)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(67, 54)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BasicLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.ForeColor = System.Drawing.Color.Navy
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0.0R
        Me.BasicLabel3.KeypadMinValue = 0.0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 600
        Me.BasicLabel3.Location = New System.Drawing.Point(37, 19)
        Me.BasicLabel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = "0"
        Me.BasicLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BasicLabel3.PLCAddressKeypad = "TestImpUnits"
        Me.BasicLabel3.PLCAddressValue = "TestImpUnits"
        Me.BasicLabel3.PLCAddressVisible = ""
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(27, 32)
        Me.BasicLabel3.TabIndex = 55
        Me.BasicLabel3.Text = "1"
        Me.BasicLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BasicLabel3.Value = "1"
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.PositionInd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(35, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(162, 52)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Angle result"
        '
        'PositionInd
        '
        Me.PositionInd.AutoSize = True
        Me.PositionInd.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PositionInd.ComComponent = Me.EthernetIPforCLXCom1
        Me.PositionInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionInd.ForeColor = System.Drawing.Color.Navy
        Me.PositionInd.HighlightColor = System.Drawing.Color.Red
        Me.PositionInd.HighlightKeyCharacter = "!"
        Me.PositionInd.KeypadAlphaNumeric = False
        Me.PositionInd.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PositionInd.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PositionInd.KeypadMaxValue = 0.0R
        Me.PositionInd.KeypadMinValue = 0.0R
        Me.PositionInd.KeypadScaleFactor = 1.0R
        Me.PositionInd.KeypadText = Nothing
        Me.PositionInd.KeypadWidth = 300
        Me.PositionInd.Location = New System.Drawing.Point(66, 21)
        Me.PositionInd.Name = "PositionInd"
        Me.PositionInd.NumericFormat = "0000.00"
        Me.PositionInd.PLCAddressKeypad = ""
        Me.PositionInd.PLCAddressValue = "TestAngleRes"
        Me.PositionInd.PLCAddressVisible = ""
        Me.PositionInd.PollRate = 0
        Me.PositionInd.Size = New System.Drawing.Size(71, 24)
        Me.PositionInd.TabIndex = 55
        Me.PositionInd.Text = "999.99"
        Me.PositionInd.Value = "999.99"
        Me.PositionInd.ValuePrefix = Nothing
        Me.PositionInd.ValueScaleFactor = 1.0R
        Me.PositionInd.ValueSuffix = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 22)
        Me.TextBox1.TabIndex = 125
        '
        'WriteTestBtn
        '
        Me.WriteTestBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteTestBtn.ForeColor = System.Drawing.Color.Black
        Me.WriteTestBtn.Location = New System.Drawing.Point(38, 318)
        Me.WriteTestBtn.Name = "WriteTestBtn"
        Me.WriteTestBtn.Size = New System.Drawing.Size(149, 35)
        Me.WriteTestBtn.TabIndex = 124
        Me.WriteTestBtn.Text = "File write test"
        Me.WriteTestBtn.UseVisualStyleBackColor = True
        '
        'MergeTestBtn
        '
        Me.MergeTestBtn.Location = New System.Drawing.Point(197, 318)
        Me.MergeTestBtn.Name = "MergeTestBtn"
        Me.MergeTestBtn.Size = New System.Drawing.Size(128, 35)
        Me.MergeTestBtn.TabIndex = 126
        Me.MergeTestBtn.Text = "Merge"
        Me.MergeTestBtn.UseVisualStyleBackColor = True
        '
        'p1_home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.MergeTestBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WriteTestBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AppExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PgOpenRecipeButton)
        Me.Controls.Add(Me.PgOpenStatusButton)
        Me.Controls.Add(Me.PgOpenManualButton)
        Me.Controls.Add(Me.PgOpenSettingsButton)
        Me.Controls.Add(Me.PgOpenResultsButton)
        Me.Controls.Add(Me.PgOpenAlarmsButton)
        Me.Controls.Add(Me.PgOpenHomeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "p1_home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents PgOpenRecipeButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenStatusButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenManualButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenSettingsButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenResultsButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenAlarmsButton As System.Windows.Forms.Button
    Friend WithEvents PgOpenHomeButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AppExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TestEntImp As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PositionInd As AdvancedHMIControls.BasicLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WriteTestBtn As System.Windows.Forms.Button
    Friend WithEvents MergeTestBtn As System.Windows.Forms.Button
End Class
