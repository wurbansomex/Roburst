<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.AlmInd = New System.Windows.Forms.PictureBox()
        Me.PictureBox_key = New System.Windows.Forms.PictureBox()
        Me.MessageDisplayByValue4 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.DateTime1 = New AdvancedHMIControls.DateTimeDisplay()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EthernetIPforCLXCom1.PollRateOverride = 525
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'AlmInd
        '
        Me.AlmInd.BackColor = System.Drawing.Color.White
        Me.AlmInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmInd.Image = CType(resources.GetObject("AlmInd.Image"), System.Drawing.Image)
        Me.AlmInd.Location = New System.Drawing.Point(264, 18)
        Me.AlmInd.Name = "AlmInd"
        Me.AlmInd.Size = New System.Drawing.Size(39, 31)
        Me.AlmInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlmInd.TabIndex = 121
        Me.AlmInd.TabStop = False
        '
        'PictureBox_key
        '
        Me.PictureBox_key.BackColor = System.Drawing.Color.White
        Me.PictureBox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_key.Image = CType(resources.GetObject("PictureBox_key.Image"), System.Drawing.Image)
        Me.PictureBox_key.Location = New System.Drawing.Point(567, 18)
        Me.PictureBox_key.Name = "PictureBox_key"
        Me.PictureBox_key.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox_key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_key.TabIndex = 120
        Me.PictureBox_key.TabStop = False
        '
        'MessageDisplayByValue4
        '
        Me.MessageDisplayByValue4.AutoSize = True
        Me.MessageDisplayByValue4.BackColor = System.Drawing.Color.White
        Me.MessageDisplayByValue4.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplayByValue4.ForeColor = System.Drawing.Color.DimGray
        Me.MessageDisplayByValue4.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue4.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue4.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue4.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue4.IniFileName = Nothing
        Me.MessageDisplayByValue4.Location = New System.Drawing.Point(363, 24)
        Me.MessageDisplayByValue4.Margin = New System.Windows.Forms.Padding(0)
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Name = "MessageDisplayByValue4"
        Me.MessageDisplayByValue4.PLCAddressValue = "HMI.SecurityLevel"
        Me.MessageDisplayByValue4.PLCAddressVisible = ""
        Me.MessageDisplayByValue4.ShowMessageNumber = False
        Me.MessageDisplayByValue4.Size = New System.Drawing.Size(143, 19)
        Me.MessageDisplayByValue4.SpeakMessage = False
        Me.MessageDisplayByValue4.TabIndex = 119
        Me.MessageDisplayByValue4.Text = "Access level: Operator"
        Me.MessageDisplayByValue4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MessageDisplayByValue4.Value = 0
        '
        'DateTime1
        '
        Me.DateTime1.BackColor = System.Drawing.Color.White
        Me.DateTime1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime1.ForeColor = System.Drawing.Color.DimGray
        Me.DateTime1.Location = New System.Drawing.Point(612, 23)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(171, 23)
        Me.DateTime1.TabIndex = 118
        Me.DateTime1.Text = "20/07/2015 15:44:45"
        Me.DateTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.banner_800x62
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 58)
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.AlmInd)
        Me.Controls.Add(Me.PictureBox_key)
        Me.Controls.Add(Me.MessageDisplayByValue4)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "AdvancedHMI v3.97c"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlmInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents AlmInd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_key As System.Windows.Forms.PictureBox
    Friend WithEvents MessageDisplayByValue4 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents DateTime1 As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
