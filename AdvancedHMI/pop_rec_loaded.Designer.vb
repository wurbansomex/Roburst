<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_rec_loaded
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_rec_loaded))
        Me.RecipeLoadedBasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.OkBasicButton = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecipeLoadedBasicLabel
        '
        Me.RecipeLoadedBasicLabel.BackColor = System.Drawing.Color.Gray
        Me.RecipeLoadedBasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.RecipeLoadedBasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.RecipeLoadedBasicLabel.DisplayAsTime = False
        Me.RecipeLoadedBasicLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeLoadedBasicLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RecipeLoadedBasicLabel.Highlight = False
        Me.RecipeLoadedBasicLabel.HighlightColor = System.Drawing.Color.Red
        Me.RecipeLoadedBasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.RecipeLoadedBasicLabel.HighlightKeyCharacter = "!"
        Me.RecipeLoadedBasicLabel.KeypadAlphaNumeric = False
        Me.RecipeLoadedBasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.RecipeLoadedBasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.RecipeLoadedBasicLabel.KeypadMaxValue = 0.0R
        Me.RecipeLoadedBasicLabel.KeypadMinValue = 0.0R
        Me.RecipeLoadedBasicLabel.KeypadScaleFactor = 1.0R
        Me.RecipeLoadedBasicLabel.KeypadShowCurrentValue = False
        Me.RecipeLoadedBasicLabel.KeypadText = Nothing
        Me.RecipeLoadedBasicLabel.KeypadWidth = 300
        Me.RecipeLoadedBasicLabel.Location = New System.Drawing.Point(6, 31)
        Me.RecipeLoadedBasicLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RecipeLoadedBasicLabel.Name = "RecipeLoadedBasicLabel"
        Me.RecipeLoadedBasicLabel.NumericFormat = Nothing
        Me.RecipeLoadedBasicLabel.PLCAddressKeypad = ""
        Me.RecipeLoadedBasicLabel.PollRate = 0
        Me.RecipeLoadedBasicLabel.Size = New System.Drawing.Size(250, 27)
        Me.RecipeLoadedBasicLabel.TabIndex = 49
        Me.RecipeLoadedBasicLabel.Text = "Recipe loaded"
        Me.RecipeLoadedBasicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RecipeLoadedBasicLabel.Value = "Recipe loaded"
        Me.RecipeLoadedBasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RecipeLoadedBasicLabel.ValueLeftPadLength = 0
        Me.RecipeLoadedBasicLabel.ValuePrefix = Nothing
        Me.RecipeLoadedBasicLabel.ValueScaleFactor = 1.0R
        Me.RecipeLoadedBasicLabel.ValueSuffix = Nothing
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
        'OkBasicButton
        '
        Me.OkBasicButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBasicButton.BackColor = System.Drawing.SystemColors.Control
        Me.OkBasicButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.OkBasicButton.Highlight = False
        Me.OkBasicButton.HighlightColor = System.Drawing.Color.Green
        Me.OkBasicButton.Image = CType(resources.GetObject("OkBasicButton.Image"), System.Drawing.Image)
        Me.OkBasicButton.Location = New System.Drawing.Point(92, 80)
        Me.OkBasicButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OkBasicButton.MaximumHoldTime = 3000
        Me.OkBasicButton.MinimumHoldTime = 500
        Me.OkBasicButton.Name = "OkBasicButton"
        Me.OkBasicButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.OkBasicButton.PLCAddressClick = ""
        Me.OkBasicButton.SelectTextAlternate = False
        Me.OkBasicButton.Size = New System.Drawing.Size(74, 46)
        Me.OkBasicButton.TabIndex = 105
        Me.OkBasicButton.TextAlternate = Nothing
        Me.OkBasicButton.UseVisualStyleBackColor = True
        Me.OkBasicButton.ValueToWrite = 1
        '
        'pop_rec_loaded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(264, 181)
        Me.Controls.Add(Me.OkBasicButton)
        Me.Controls.Add(Me.RecipeLoadedBasicLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pop_rec_loaded"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecipeLoadedBasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents OkBasicButton As AdvancedHMIControls.BasicButton
End Class
