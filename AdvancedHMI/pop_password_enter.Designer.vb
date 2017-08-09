<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_password_enter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_password_enter))
        Me.EnterPasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EnterBtn = New AdvancedHMIControls.BasicButton()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnterPasswordLabel
        '
        Me.EnterPasswordLabel.AutoSize = True
        Me.EnterPasswordLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterPasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EnterPasswordLabel.Location = New System.Drawing.Point(46, 28)
        Me.EnterPasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EnterPasswordLabel.Name = "EnterPasswordLabel"
        Me.EnterPasswordLabel.Size = New System.Drawing.Size(120, 21)
        Me.EnterPasswordLabel.TabIndex = 0
        Me.EnterPasswordLabel.Text = "Enter password:"
        Me.EnterPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(50, 56)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(177, 21)
        Me.PasswordTextBox.TabIndex = 1
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
        'EnterBtn
        '
        Me.EnterBtn.BackColor = System.Drawing.SystemColors.Control
        Me.EnterBtn.ComComponent = Me.EthernetIPforCLXCom1
        Me.EnterBtn.Highlight = False
        Me.EnterBtn.HighlightColor = System.Drawing.Color.Green
        Me.EnterBtn.Image = CType(resources.GetObject("EnterBtn.Image"), System.Drawing.Image)
        Me.EnterBtn.Location = New System.Drawing.Point(152, 98)
        Me.EnterBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.EnterBtn.MaximumHoldTime = 3000
        Me.EnterBtn.MinimumHoldTime = 500
        Me.EnterBtn.Name = "EnterBtn"
        Me.EnterBtn.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.EnterBtn.PLCAddressClick = ""
        Me.EnterBtn.PLCAddressHighlight = ""
        Me.EnterBtn.PLCAddressSelectTextAlternate = ""
        Me.EnterBtn.PLCAddressText = ""
        Me.EnterBtn.PLCAddressVisible = ""
        Me.EnterBtn.SelectTextAlternate = False
        Me.EnterBtn.Size = New System.Drawing.Size(74, 46)
        Me.EnterBtn.TabIndex = 76
        Me.EnterBtn.TextAlternate = Nothing
        Me.EnterBtn.UseVisualStyleBackColor = True
        Me.EnterBtn.ValueToWrite = 0
        '
        'CancelBtn
        '
        Me.CancelBtn.Image = CType(resources.GetObject("CancelBtn.Image"), System.Drawing.Image)
        Me.CancelBtn.Location = New System.Drawing.Point(50, 98)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(74, 46)
        Me.CancelBtn.TabIndex = 75
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'pop_password_enter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(278, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.EnterBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EnterPasswordLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pop_password_enter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnterPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents EnterBtn As AdvancedHMIControls.BasicButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
