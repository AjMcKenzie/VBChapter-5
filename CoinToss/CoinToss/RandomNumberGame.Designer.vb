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
        Me.lblAwnser = New System.Windows.Forms.Label()
        Me.lblGotWrong = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(44, 129)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(89, 23)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblAwnser
        '
        Me.lblAwnser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAwnser.Location = New System.Drawing.Point(12, 34)
        Me.lblAwnser.Name = "lblAwnser"
        Me.lblAwnser.Size = New System.Drawing.Size(165, 44)
        Me.lblAwnser.TabIndex = 2
        Me.lblAwnser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGotWrong
        '
        Me.lblGotWrong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGotWrong.Location = New System.Drawing.Point(12, 90)
        Me.lblGotWrong.Name = "lblGotWrong"
        Me.lblGotWrong.Size = New System.Drawing.Size(165, 27)
        Me.lblGotWrong.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Guess a number between 1 and 100"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(44, 158)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RandomNumberGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 188)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGotWrong)
        Me.Controls.Add(Me.lblAwnser)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "RandomNumberGame"
        Me.Text = "RandomNumberGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblAwnser As System.Windows.Forms.Label
    Friend WithEvents lblGotWrong As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
