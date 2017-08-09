<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_mould_number_entry
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
        Me.FormHeadingLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UserPromptLabel = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.MouldQuantityBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.NumberOfAvailableSlotsLabel = New System.Windows.Forms.Label()
        Me.ContainerPickHeightValueBasicLabel = New AdvancedHMIControls.BasicLabel()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormHeadingLabel
        '
        Me.FormHeadingLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormHeadingLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormHeadingLabel.Location = New System.Drawing.Point(1, 19)
        Me.FormHeadingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FormHeadingLabel.Name = "FormHeadingLabel"
        Me.FormHeadingLabel.Size = New System.Drawing.Size(325, 32)
        Me.FormHeadingLabel.TabIndex = 0
        Me.FormHeadingLabel.Text = "Mould Quantity"
        Me.FormHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'UserPromptLabel
        '
        Me.UserPromptLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPromptLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UserPromptLabel.Location = New System.Drawing.Point(11, 72)
        Me.UserPromptLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserPromptLabel.Name = "UserPromptLabel"
        Me.UserPromptLabel.Size = New System.Drawing.Size(209, 38)
        Me.UserPromptLabel.TabIndex = 296
        Me.UserPromptLabel.Text = "Enter quantity of moulds"
        Me.UserPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelBtn
        '
        Me.CancelBtn.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.cancel
        Me.CancelBtn.Location = New System.Drawing.Point(71, 172)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(74, 46)
        Me.CancelBtn.TabIndex = 75
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.right11
        Me.NextButton.Location = New System.Drawing.Point(195, 172)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(74, 46)
        Me.NextButton.TabIndex = 298
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'MouldQuantityBasicLabel
        '
        Me.MouldQuantityBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.MouldQuantityBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.MouldQuantityBasicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MouldQuantityBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.MouldQuantityBasicLabel.DisplayAsTime = False
        Me.MouldQuantityBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MouldQuantityBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MouldQuantityBasicLabel.Highlight = False
        Me.MouldQuantityBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.MouldQuantityBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.MouldQuantityBasicLabel.HighlightKeyCharacter = "!"
        Me.MouldQuantityBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MouldQuantityBasicLabel.KeypadAlphaNumeric = False
        Me.MouldQuantityBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MouldQuantityBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.MouldQuantityBasicLabel.KeypadMaxValue = 10000.0R
        Me.MouldQuantityBasicLabel.KeypadMinValue = 1.0R
        Me.MouldQuantityBasicLabel.KeypadScaleFactor = 1.0R
        Me.MouldQuantityBasicLabel.KeypadShowCurrentValue = False
        Me.MouldQuantityBasicLabel.KeypadText = Nothing
        Me.MouldQuantityBasicLabel.KeypadWidth = 400
        Me.MouldQuantityBasicLabel.Location = New System.Drawing.Point(225, 72)
        Me.MouldQuantityBasicLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 7)
        Me.MouldQuantityBasicLabel.Name = "MouldQuantityBasicLabel"
        Me.MouldQuantityBasicLabel.NumericFormat = "000"
        Me.MouldQuantityBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.MouldQuantityBasicLabel.PLCAddressKeypad = "ContCountEnter"
        Me.MouldQuantityBasicLabel.PLCAddressValue = "ContCountEnter"
        Me.MouldQuantityBasicLabel.PollRate = 0
        Me.MouldQuantityBasicLabel.Size = New System.Drawing.Size(56, 29)
        Me.MouldQuantityBasicLabel.TabIndex = 550
        Me.MouldQuantityBasicLabel.Text = "000"
        Me.MouldQuantityBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MouldQuantityBasicLabel.UseMnemonic = False
        Me.MouldQuantityBasicLabel.Value = "000"
        Me.MouldQuantityBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(48)
        Me.MouldQuantityBasicLabel.ValueLeftPadLength = 2
        Me.MouldQuantityBasicLabel.ValuePrefix = Nothing
        Me.MouldQuantityBasicLabel.ValueScaleFactor = 1.0R
        Me.MouldQuantityBasicLabel.ValueSuffix = Nothing
        '
        'NumberOfAvailableSlotsLabel
        '
        Me.NumberOfAvailableSlotsLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfAvailableSlotsLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumberOfAvailableSlotsLabel.Location = New System.Drawing.Point(11, 110)
        Me.NumberOfAvailableSlotsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfAvailableSlotsLabel.Name = "NumberOfAvailableSlotsLabel"
        Me.NumberOfAvailableSlotsLabel.Size = New System.Drawing.Size(209, 38)
        Me.NumberOfAvailableSlotsLabel.TabIndex = 551
        Me.NumberOfAvailableSlotsLabel.Text = "Number of available slots:"
        Me.NumberOfAvailableSlotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContainerPickHeightValueBasicLabel
        '
        Me.ContainerPickHeightValueBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.ContainerPickHeightValueBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ContainerPickHeightValueBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.ContainerPickHeightValueBasicLabel.DisplayAsTime = False
        Me.ContainerPickHeightValueBasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerPickHeightValueBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ContainerPickHeightValueBasicLabel.Highlight = False
        Me.ContainerPickHeightValueBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.ContainerPickHeightValueBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.ContainerPickHeightValueBasicLabel.HighlightKeyCharacter = "!"
        Me.ContainerPickHeightValueBasicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContainerPickHeightValueBasicLabel.KeypadAlphaNumeric = False
        Me.ContainerPickHeightValueBasicLabel.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerPickHeightValueBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ContainerPickHeightValueBasicLabel.KeypadMaxValue = 0.0R
        Me.ContainerPickHeightValueBasicLabel.KeypadMinValue = 0.0R
        Me.ContainerPickHeightValueBasicLabel.KeypadScaleFactor = 1.0R
        Me.ContainerPickHeightValueBasicLabel.KeypadShowCurrentValue = False
        Me.ContainerPickHeightValueBasicLabel.KeypadText = Nothing
        Me.ContainerPickHeightValueBasicLabel.KeypadWidth = 400
        Me.ContainerPickHeightValueBasicLabel.Location = New System.Drawing.Point(225, 116)
        Me.ContainerPickHeightValueBasicLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 9)
        Me.ContainerPickHeightValueBasicLabel.Name = "ContainerPickHeightValueBasicLabel"
        Me.ContainerPickHeightValueBasicLabel.NumericFormat = "000"
        Me.ContainerPickHeightValueBasicLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ContainerPickHeightValueBasicLabel.PLCAddressKeypad = ""
        Me.ContainerPickHeightValueBasicLabel.PLCAddressValue = "ConveyorFreeSlots"
        Me.ContainerPickHeightValueBasicLabel.PollRate = 0
        Me.ContainerPickHeightValueBasicLabel.Size = New System.Drawing.Size(56, 27)
        Me.ContainerPickHeightValueBasicLabel.TabIndex = 552
        Me.ContainerPickHeightValueBasicLabel.Text = "000"
        Me.ContainerPickHeightValueBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ContainerPickHeightValueBasicLabel.UseMnemonic = False
        Me.ContainerPickHeightValueBasicLabel.Value = "000"
        Me.ContainerPickHeightValueBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContainerPickHeightValueBasicLabel.ValueLeftPadLength = 0
        Me.ContainerPickHeightValueBasicLabel.ValuePrefix = Nothing
        Me.ContainerPickHeightValueBasicLabel.ValueScaleFactor = 1.0R
        Me.ContainerPickHeightValueBasicLabel.ValueSuffix = Nothing
        '
        'pop_mould_number_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(337, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.ContainerPickHeightValueBasicLabel)
        Me.Controls.Add(Me.NumberOfAvailableSlotsLabel)
        Me.Controls.Add(Me.MouldQuantityBasicLabel)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.UserPromptLabel)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.FormHeadingLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pop_mould_number_entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormHeadingLabel As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UserPromptLabel As System.Windows.Forms.Label
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents MouldQuantityBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents NumberOfAvailableSlotsLabel As System.Windows.Forms.Label
    Friend WithEvents ContainerPickHeightValueBasicLabel As AdvancedHMIControls.BasicLabel
End Class
