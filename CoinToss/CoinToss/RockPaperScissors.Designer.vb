<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RockPaperScissors))
        Me.lblResult = New System.Windows.Forms.Label()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(104, 162)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(331, 89)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picRock
        '
        Me.picRock.Image = CType(resources.GetObject("picRock.Image"), System.Drawing.Image)
        Me.picRock.Location = New System.Drawing.Point(12, 24)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(125, 101)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 4
        Me.picRock.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = CType(resources.GetObject("picPaper.Image"), System.Drawing.Image)
        Me.picPaper.Location = New System.Drawing.Point(197, 24)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(125, 101)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 5
        Me.picPaper.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = CType(resources.GetObject("picScissors.Image"), System.Drawing.Image)
        Me.picScissors.Location = New System.Drawing.Point(409, 24)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(125, 101)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 6
        Me.picScissors.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(221, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 387)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "RockPaperScissors"
        Me.Text = "RockPaperScissors"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents picRock As System.Windows.Forms.PictureBox
    Friend WithEvents picPaper As System.Windows.Forms.PictureBox
    Friend WithEvents picScissors As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
