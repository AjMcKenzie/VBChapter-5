<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinToss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoinToss))
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTails = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeads = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHeads
        '
        Me.picHeads.Image = CType(resources.GetObject("picHeads.Image"), System.Drawing.Image)
        Me.picHeads.Location = New System.Drawing.Point(131, 25)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(175, 139)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeads.TabIndex = 0
        Me.picHeads.TabStop = False
        Me.picHeads.Visible = False
        '
        'picTails
        '
        Me.picTails.Image = CType(resources.GetObject("picTails.Image"), System.Drawing.Image)
        Me.picTails.Location = New System.Drawing.Point(131, 25)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(175, 139)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTails.TabIndex = 1
        Me.picTails.TabStop = False
        Me.picTails.Visible = False
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(61, 223)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(136, 42)
        Me.btnToss.TabIndex = 2
        Me.btnToss.Text = "Toss the Coin"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 223)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 42)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTails
        '
        Me.lblTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTails.Location = New System.Drawing.Point(427, 230)
        Me.lblTails.Name = "lblTails"
        Me.lblTails.Size = New System.Drawing.Size(43, 35)
        Me.lblTails.TabIndex = 3
        Me.lblTails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Heads"
        '
        'lblHeads
        '
        Me.lblHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeads.Location = New System.Drawing.Point(12, 230)
        Me.lblHeads.Name = "lblHeads"
        Me.lblHeads.Size = New System.Drawing.Size(43, 35)
        Me.lblHeads.TabIndex = 8
        Me.lblHeads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tails"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 274)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHeads)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTails)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Name = "Form1"
        Me.Text = "Coin Flip"
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTails As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHeads As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
