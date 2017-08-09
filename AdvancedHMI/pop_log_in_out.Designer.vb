<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_log_in_out
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
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.LoginBasicButton = New AdvancedHMIControls.BasicButton()
        Me.LogoutBasicButton = New AdvancedHMIControls.BasicButton()
        Me.CancelBasicButton = New System.Windows.Forms.Button()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LoginBasicButton
        '
        Me.LoginBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.LoginBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.LoginBasicButton.Highlight = False
        Me.LoginBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.LoginBasicButton.Location = New System.Drawing.Point(18, 20)
        Me.LoginBasicButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBasicButton.MaximumHoldTime = 3000
        Me.LoginBasicButton.MinimumHoldTime = 500
        Me.LoginBasicButton.Name = "LoginBasicButton"
        Me.LoginBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LoginBasicButton.PLCAddressClick = ""
        Me.LoginBasicButton.SelectTextAlternate = False
        Me.LoginBasicButton.Size = New System.Drawing.Size(118, 46)
        Me.LoginBasicButton.TabIndex = 76
        Me.LoginBasicButton.Text = "Log in"
        Me.LoginBasicButton.TextAlternate = Nothing
        Me.LoginBasicButton.UseVisualStyleBackColor = True
        Me.LoginBasicButton.ValueToWrite = 0
        '
        'LogoutBasicButton
        '
        Me.LogoutBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.LogoutBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.LogoutBasicButton.Highlight = False
        Me.LogoutBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.LogoutBasicButton.Location = New System.Drawing.Point(18, 83)
        Me.LogoutBasicButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutBasicButton.MaximumHoldTime = 3000
        Me.LogoutBasicButton.MinimumHoldTime = 500
        Me.LogoutBasicButton.Name = "LogoutBasicButton"
        Me.LogoutBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LogoutBasicButton.PLCAddressClick = ""
        Me.LogoutBasicButton.SelectTextAlternate = False
        Me.LogoutBasicButton.Size = New System.Drawing.Size(118, 46)
        Me.LogoutBasicButton.TabIndex = 77
        Me.LogoutBasicButton.Text = "Log out"
        Me.LogoutBasicButton.TextAlternate = Nothing
        Me.LogoutBasicButton.UseVisualStyleBackColor = True
        Me.LogoutBasicButton.ValueToWrite = 0
        '
        'CancelBasicButton
        '
        Me.CancelBasicButton.Location = New System.Drawing.Point(18, 146)
        Me.CancelBasicButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBasicButton.Name = "CancelBasicButton"
        Me.CancelBasicButton.Size = New System.Drawing.Size(118, 46)
        Me.CancelBasicButton.TabIndex = 78
        Me.CancelBasicButton.Text = "Cancel"
        Me.CancelBasicButton.UseVisualStyleBackColor = True
        '
        'pop_log_in_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(152, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBasicButton)
        Me.Controls.Add(Me.LogoutBasicButton)
        Me.Controls.Add(Me.LoginBasicButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pop_log_in_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents LoginBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents LogoutBasicButton As AdvancedHMIControls.BasicButton
    Friend WithEvents CancelBasicButton As System.Windows.Forms.Button
End Class
