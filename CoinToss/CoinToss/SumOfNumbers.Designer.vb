<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SumOfNumbers
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
        Me.btnEnterNumbers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnterNumbers
        '
        Me.btnEnterNumbers.Location = New System.Drawing.Point(67, 60)
        Me.btnEnterNumbers.Name = "btnEnterNumbers"
        Me.btnEnterNumbers.Size = New System.Drawing.Size(142, 39)
        Me.btnEnterNumbers.TabIndex = 0
        Me.btnEnterNumbers.Text = "Enter Numbers"
        Me.btnEnterNumbers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 60)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'SumOfNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 151)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNumbers)
        Me.Name = "SumOfNumbers"
        Me.Text = "SumOfNumbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterNumbers As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
