<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightOnLightOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightOnLightOff))
        Me.picLightOff = New System.Windows.Forms.PictureBox()
        Me.picLightOn = New System.Windows.Forms.PictureBox()
        Me.btnLightSwitch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBrokenBulb = New System.Windows.Forms.PictureBox()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrokenBulb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLightOff
        '
        Me.picLightOff.Image = CType(resources.GetObject("picLightOff.Image"), System.Drawing.Image)
        Me.picLightOff.Location = New System.Drawing.Point(184, 12)
        Me.picLightOff.Name = "picLightOff"
        Me.picLightOff.Size = New System.Drawing.Size(193, 191)
        Me.picLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLightOff.TabIndex = 0
        Me.picLightOff.TabStop = False
        '
        'picLightOn
        '
        Me.picLightOn.Image = CType(resources.GetObject("picLightOn.Image"), System.Drawing.Image)
        Me.picLightOn.Location = New System.Drawing.Point(184, 12)
        Me.picLightOn.Name = "picLightOn"
        Me.picLightOn.Size = New System.Drawing.Size(193, 191)
        Me.picLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLightOn.TabIndex = 1
        Me.picLightOn.TabStop = False
        Me.picLightOn.Visible = False
        '
        'btnLightSwitch
        '
        Me.btnLightSwitch.Location = New System.Drawing.Point(184, 252)
        Me.btnLightSwitch.Name = "btnLightSwitch"
        Me.btnLightSwitch.Size = New System.Drawing.Size(75, 23)
        Me.btnLightSwitch.TabIndex = 2
        Me.btnLightSwitch.Text = "Light Switch"
        Me.btnLightSwitch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(295, 303)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 17)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(154, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How Many Times does " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the annoying " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kid turn on the light:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picBrokenBulb
        '
        Me.picBrokenBulb.Image = CType(resources.GetObject("picBrokenBulb.Image"), System.Drawing.Image)
        Me.picBrokenBulb.Location = New System.Drawing.Point(184, 12)
        Me.picBrokenBulb.Name = "picBrokenBulb"
        Me.picBrokenBulb.Size = New System.Drawing.Size(193, 191)
        Me.picBrokenBulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBrokenBulb.TabIndex = 6
        Me.picBrokenBulb.TabStop = False
        Me.picBrokenBulb.Visible = False
        '
        'LightOnLightOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 357)
        Me.Controls.Add(Me.picBrokenBulb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLightSwitch)
        Me.Controls.Add(Me.picLightOn)
        Me.Controls.Add(Me.picLightOff)
        Me.Name = "LightOnLightOff"
        Me.Text = "LightOnLightOff"
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrokenBulb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLightOff As System.Windows.Forms.PictureBox
    Friend WithEvents picLightOn As System.Windows.Forms.PictureBox
    Friend WithEvents btnLightSwitch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picBrokenBulb As System.Windows.Forms.PictureBox
End Class
