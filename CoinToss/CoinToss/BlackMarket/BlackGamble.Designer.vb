<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackGamble
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
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBlack
        '
        Me.lblBlack.AutoSize = True
        Me.lblBlack.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblBlack.Location = New System.Drawing.Point(61, 9)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(336, 67)
        Me.lblBlack.TabIndex = 0
        Me.lblBlack.Text = "Black Gamble"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(22, 379)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(51, 24)
        Me.btnHelp.TabIndex = 1
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'BlackGamble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(435, 422)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblBlack)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "BlackGamble"
        Me.Text = "BlackGamble"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBlack As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
