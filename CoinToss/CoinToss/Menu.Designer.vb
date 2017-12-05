<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnLightGame = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCoinToss = New System.Windows.Forms.Button()
        Me.btnRaceGame = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLightGame
        '
        Me.btnLightGame.Location = New System.Drawing.Point(136, 84)
        Me.btnLightGame.Name = "btnLightGame"
        Me.btnLightGame.Size = New System.Drawing.Size(75, 23)
        Me.btnLightGame.TabIndex = 0
        Me.btnLightGame.Text = "Light Game"
        Me.btnLightGame.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(136, 286)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCoinToss
        '
        Me.btnCoinToss.Location = New System.Drawing.Point(136, 113)
        Me.btnCoinToss.Name = "btnCoinToss"
        Me.btnCoinToss.Size = New System.Drawing.Size(75, 23)
        Me.btnCoinToss.TabIndex = 2
        Me.btnCoinToss.Text = "Coin Toss"
        Me.btnCoinToss.UseVisualStyleBackColor = True
        '
        'btnRaceGame
        '
        Me.btnRaceGame.Location = New System.Drawing.Point(136, 142)
        Me.btnRaceGame.Name = "btnRaceGame"
        Me.btnRaceGame.Size = New System.Drawing.Size(75, 23)
        Me.btnRaceGame.TabIndex = 3
        Me.btnRaceGame.Text = "Race Game"
        Me.btnRaceGame.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Rock, Paper, Scissors"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Right Trangle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 50)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 321)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRaceGame)
        Me.Controls.Add(Me.btnCoinToss)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLightGame)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLightGame As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCoinToss As System.Windows.Forms.Button
    Friend WithEvents btnRaceGame As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
