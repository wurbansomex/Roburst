<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_profile_number
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
        Me.NewProfileLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProfileLabel = New System.Windows.Forms.Label()
        Me.CreateProfileButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.NewProfileNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NewProfileLabel
        '
        Me.NewProfileLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewProfileLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NewProfileLabel.Location = New System.Drawing.Point(9, 19)
        Me.NewProfileLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NewProfileLabel.Name = "NewProfileLabel"
        Me.NewProfileLabel.Size = New System.Drawing.Size(325, 32)
        Me.NewProfileLabel.TabIndex = 0
        Me.NewProfileLabel.Text = "New Profile Number"
        Me.NewProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'ProfileLabel
        '
        Me.ProfileLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ProfileLabel.Location = New System.Drawing.Point(11, 78)
        Me.ProfileLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProfileLabel.Name = "ProfileLabel"
        Me.ProfileLabel.Size = New System.Drawing.Size(212, 56)
        Me.ProfileLabel.TabIndex = 296
        Me.ProfileLabel.Text = "Select Profile Number"
        Me.ProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CreateProfileButton
        '
        Me.CreateProfileButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.tick
        Me.CreateProfileButton.Location = New System.Drawing.Point(220, 172)
        Me.CreateProfileButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateProfileButton.Name = "CreateProfileButton"
        Me.CreateProfileButton.Size = New System.Drawing.Size(74, 46)
        Me.CreateProfileButton.TabIndex = 2
        Me.CreateProfileButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.cancel
        Me.CancelBtn.Location = New System.Drawing.Point(80, 172)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(74, 46)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'NewProfileNumberTextBox
        '
        Me.NewProfileNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewProfileNumberTextBox.Location = New System.Drawing.Point(159, 93)
        Me.NewProfileNumberTextBox.Name = "NewProfileNumberTextBox"
        Me.NewProfileNumberTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NewProfileNumberTextBox.TabIndex = 1
        '
        'pop_profile_number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(371, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.NewProfileNumberTextBox)
        Me.Controls.Add(Me.CreateProfileButton)
        Me.Controls.Add(Me.ProfileLabel)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.NewProfileLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pop_profile_number"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewProfileLabel As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProfileLabel As System.Windows.Forms.Label
    Friend WithEvents CreateProfileButton As System.Windows.Forms.Button
    Friend WithEvents NewProfileNumberTextBox As System.Windows.Forms.TextBox
End Class
