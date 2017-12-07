<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomNumberGame
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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblAwnser = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(62, 133)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(89, 23)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(62, 95)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(89, 20)
        Me.txtGuess.TabIndex = 1
        '
        'lblAwnser
        '
        Me.lblAwnser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAwnser.Location = New System.Drawing.Point(37, 37)
        Me.lblAwnser.Name = "lblAwnser"
        Me.lblAwnser.Size = New System.Drawing.Size(165, 44)
        Me.lblAwnser.TabIndex = 2
        Me.lblAwnser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWrong
        '
        Me.lblWrong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWrong.Location = New System.Drawing.Point(282, 131)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(55, 26)
        Me.lblWrong.TabIndex = 3
        Me.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(246, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "How many you got wrong:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Guess a number between 1 and 100"
        '
        'RandomNumberGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 168)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAwnser)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "RandomNumberGame"
        Me.Text = "RandomNumberGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents lblAwnser As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
