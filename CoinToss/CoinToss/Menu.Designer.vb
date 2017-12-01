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
        Me.SuspendLayout()
        '
        'btnLightGame
        '
        Me.btnLightGame.Location = New System.Drawing.Point(136, 97)
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
        Me.btnCoinToss.Location = New System.Drawing.Point(136, 126)
        Me.btnCoinToss.Name = "btnCoinToss"
        Me.btnCoinToss.Size = New System.Drawing.Size(75, 23)
        Me.btnCoinToss.TabIndex = 2
        Me.btnCoinToss.Text = "Coin Toss"
        Me.btnCoinToss.UseVisualStyleBackColor = True
        '
        'btnRaceGame
        '
        Me.btnRaceGame.Location = New System.Drawing.Point(136, 155)
        Me.btnRaceGame.Name = "btnRaceGame"
        Me.btnRaceGame.Size = New System.Drawing.Size(75, 23)
        Me.btnRaceGame.TabIndex = 3
        Me.btnRaceGame.Text = "Race Game"
        Me.btnRaceGame.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 321)
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
End Class
