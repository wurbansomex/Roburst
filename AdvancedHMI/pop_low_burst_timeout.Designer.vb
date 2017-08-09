<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_low_burst_timeout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_low_burst_timeout))
        Me.OperatorPromptBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.OkButton = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OperatorPromptBasicLabel
        '
        Me.OperatorPromptBasicLabel.AutoSize = True
        Me.OperatorPromptBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.OperatorPromptBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.OperatorPromptBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.OperatorPromptBasicLabel.DisplayAsTime = False
        Me.OperatorPromptBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorPromptBasicLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.OperatorPromptBasicLabel.Highlight = False
        Me.OperatorPromptBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.OperatorPromptBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.OperatorPromptBasicLabel.HighlightKeyCharacter = "!"
        Me.OperatorPromptBasicLabel.KeypadAlphaNumeric = False
        Me.OperatorPromptBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.OperatorPromptBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.OperatorPromptBasicLabel.KeypadMaxValue = 0.0R
        Me.OperatorPromptBasicLabel.KeypadMinValue = 0.0R
        Me.OperatorPromptBasicLabel.KeypadScaleFactor = 1.0R
        Me.OperatorPromptBasicLabel.KeypadShowCurrentValue = False
        Me.OperatorPromptBasicLabel.KeypadText = Nothing
        Me.OperatorPromptBasicLabel.KeypadWidth = 300
        Me.OperatorPromptBasicLabel.Location = New System.Drawing.Point(39, 37)
        Me.OperatorPromptBasicLabel.Name = "OperatorPromptBasicLabel"
        Me.OperatorPromptBasicLabel.NumericFormat = Nothing
        Me.OperatorPromptBasicLabel.PLCAddressKeypad = ""
        Me.OperatorPromptBasicLabel.PollRate = 0
        Me.OperatorPromptBasicLabel.Size = New System.Drawing.Size(363, 25)
        Me.OperatorPromptBasicLabel.TabIndex = 450
        Me.OperatorPromptBasicLabel.Text = "Low Burst Timeout. Press OK to proceeed"
        Me.OperatorPromptBasicLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.OperatorPromptBasicLabel.Value = "Low Burst Timeout. Press OK to proceeed"
        Me.OperatorPromptBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OperatorPromptBasicLabel.ValueLeftPadLength = 0
        Me.OperatorPromptBasicLabel.ValuePrefix = Nothing
        Me.OperatorPromptBasicLabel.ValueScaleFactor = 1.0R
        Me.OperatorPromptBasicLabel.ValueSuffix = Nothing
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.Control
        Me.OkButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.OkButton.Highlight = False
        Me.OkButton.HighlightColor = System.Drawing.Color.Green
        Me.OkButton.Image = CType(resources.GetObject("OkButton.Image"), System.Drawing.Image)
        Me.OkButton.Location = New System.Drawing.Point(177, 110)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OkButton.MaximumHoldTime = 3000
        Me.OkButton.MinimumHoldTime = 500
        Me.OkButton.Name = "OkButton"
        Me.OkButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.OkButton.PLCAddressClick = ""
        Me.OkButton.SelectTextAlternate = False
        Me.OkButton.Size = New System.Drawing.Size(74, 46)
        Me.OkButton.TabIndex = 451
        Me.OkButton.TextAlternate = Nothing
        Me.OkButton.UseVisualStyleBackColor = True
        Me.OkButton.ValueToWrite = 0
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
        'pop_low_burst_timeout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(435, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.OperatorPromptBasicLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pop_low_burst_timeout"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OperatorPromptBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents OkButton As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
End Class
