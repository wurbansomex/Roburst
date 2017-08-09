<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rec_name_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rec_name_edit))
        Me.ConfirmEdits = New System.Windows.Forms.Button()
        Me.CancelEdits = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EditRecipeNameLabel = New System.Windows.Forms.Label()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmEdits
        '
        Me.ConfirmEdits.Image = CType(resources.GetObject("ConfirmEdits.Image"), System.Drawing.Image)
        Me.ConfirmEdits.Location = New System.Drawing.Point(143, 73)
        Me.ConfirmEdits.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmEdits.Name = "ConfirmEdits"
        Me.ConfirmEdits.Size = New System.Drawing.Size(74, 46)
        Me.ConfirmEdits.TabIndex = 72
        Me.ConfirmEdits.UseVisualStyleBackColor = True
        '
        'CancelEdits
        '
        Me.CancelEdits.Image = CType(resources.GetObject("CancelEdits.Image"), System.Drawing.Image)
        Me.CancelEdits.Location = New System.Drawing.Point(57, 73)
        Me.CancelEdits.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelEdits.Name = "CancelEdits"
        Me.CancelEdits.Size = New System.Drawing.Size(74, 46)
        Me.CancelEdits.TabIndex = 73
        Me.CancelEdits.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(33, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 21)
        Me.TextBox1.TabIndex = 0
        '
        'EditRecipeNameLabel
        '
        Me.EditRecipeNameLabel.AutoSize = True
        Me.EditRecipeNameLabel.Location = New System.Drawing.Point(92, 9)
        Me.EditRecipeNameLabel.Name = "EditRecipeNameLabel"
        Me.EditRecipeNameLabel.Size = New System.Drawing.Size(86, 13)
        Me.EditRecipeNameLabel.TabIndex = 75
        Me.EditRecipeNameLabel.Text = "Edit recipe name"
        '
        'rec_name_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(279, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.EditRecipeNameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CancelEdits)
        Me.Controls.Add(Me.ConfirmEdits)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "rec_name_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmEdits As System.Windows.Forms.Button
    Friend WithEvents CancelEdits As System.Windows.Forms.Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EditRecipeNameLabel As System.Windows.Forms.Label
End Class
