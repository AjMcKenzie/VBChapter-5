﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaceGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RaceGame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picOCar = New System.Windows.Forms.PictureBox()
        Me.picRCar = New System.Windows.Forms.PictureBox()
        Me.picBCar = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.radOBet = New System.Windows.Forms.RadioButton()
        Me.radBBet = New System.Windows.Forms.RadioButton()
        Me.radRBet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblORaceS = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBRaceS = New System.Windows.Forms.Label()
        Me.lblRRaceS = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblBet = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(605, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 265)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(116, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 265)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'picOCar
        '
        Me.picOCar.Image = CType(resources.GetObject("picOCar.Image"), System.Drawing.Image)
        Me.picOCar.Location = New System.Drawing.Point(12, 12)
        Me.picOCar.Name = "picOCar"
        Me.picOCar.Size = New System.Drawing.Size(99, 47)
        Me.picOCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOCar.TabIndex = 2
        Me.picOCar.TabStop = False
        '
        'picRCar
        '
        Me.picRCar.Image = CType(resources.GetObject("picRCar.Image"), System.Drawing.Image)
        Me.picRCar.Location = New System.Drawing.Point(11, 176)
        Me.picRCar.Name = "picRCar"
        Me.picRCar.Size = New System.Drawing.Size(99, 47)
        Me.picRCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRCar.TabIndex = 3
        Me.picRCar.TabStop = False
        '
        'picBCar
        '
        Me.picBCar.Image = CType(resources.GetObject("picBCar.Image"), System.Drawing.Image)
        Me.picBCar.Location = New System.Drawing.Point(12, 90)
        Me.picBCar.Name = "picBCar"
        Me.picBCar.Size = New System.Drawing.Size(99, 47)
        Me.picBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBCar.TabIndex = 4
        Me.picBCar.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(133, 229)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(218, 229)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(310, 229)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(409, 229)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(658, 327)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(106, 25)
        Me.btnGo.TabIndex = 11
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(770, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 25)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(770, 327)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 25)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'radOBet
        '
        Me.radOBet.AutoSize = True
        Me.radOBet.Location = New System.Drawing.Point(6, 19)
        Me.radOBet.Name = "radOBet"
        Me.radOBet.Size = New System.Drawing.Size(79, 17)
        Me.radOBet.TabIndex = 14
        Me.radOBet.TabStop = True
        Me.radOBet.Text = "Orange Car"
        Me.radOBet.UseVisualStyleBackColor = True
        '
        'radBBet
        '
        Me.radBBet.AutoSize = True
        Me.radBBet.Location = New System.Drawing.Point(6, 43)
        Me.radBBet.Name = "radBBet"
        Me.radBBet.Size = New System.Drawing.Size(65, 17)
        Me.radBBet.TabIndex = 15
        Me.radBBet.TabStop = True
        Me.radBBet.Text = "Blue Car"
        Me.radBBet.UseVisualStyleBackColor = True
        '
        'radRBet
        '
        Me.radRBet.AutoSize = True
        Me.radRBet.Location = New System.Drawing.Point(6, 70)
        Me.radRBet.Name = "radRBet"
        Me.radRBet.Size = New System.Drawing.Size(64, 17)
        Me.radRBet.TabIndex = 16
        Me.radRBet.TabStop = True
        Me.radRBet.Text = "Red Car"
        Me.radRBet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRBet)
        Me.GroupBox1.Controls.Add(Me.radBBet)
        Me.GroupBox1.Controls.Add(Me.radOBet)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 103)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Betting Station"
        '
        'lblORaceS
        '
        Me.lblORaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblORaceS.Location = New System.Drawing.Point(6, 25)
        Me.lblORaceS.Name = "lblORaceS"
        Me.lblORaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblORaceS.TabIndex = 18
        Me.lblORaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRRaceS)
        Me.GroupBox2.Controls.Add(Me.lblBRaceS)
        Me.GroupBox2.Controls.Add(Me.lblORaceS)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 87)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scores"
        '
        'lblBRaceS
        '
        Me.lblBRaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRaceS.Location = New System.Drawing.Point(6, 59)
        Me.lblBRaceS.Name = "lblBRaceS"
        Me.lblBRaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblBRaceS.TabIndex = 19
        Me.lblBRaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRRaceS
        '
        Me.lblRRaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRRaceS.Location = New System.Drawing.Point(154, 25)
        Me.lblRRaceS.Name = "lblRRaceS"
        Me.lblRRaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblRRaceS.TabIndex = 20
        Me.lblRRaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(508, 229)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'lblWinner
        '
        Me.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWinner.Location = New System.Drawing.Point(475, 299)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(113, 31)
        Me.lblWinner.TabIndex = 21
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBet
        '
        Me.lblBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBet.Location = New System.Drawing.Point(475, 343)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(113, 31)
        Me.lblBet.TabIndex = 22
        Me.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RaceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 398)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.picBCar)
        Me.Controls.Add(Me.picOCar)
        Me.Controls.Add(Me.picRCar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "RaceGame"
        Me.Text = "RaceGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picOCar As System.Windows.Forms.PictureBox
    Friend WithEvents picRCar As System.Windows.Forms.PictureBox
    Friend WithEvents picBCar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents radOBet As System.Windows.Forms.RadioButton
    Friend WithEvents radBBet As System.Windows.Forms.RadioButton
    Friend WithEvents radRBet As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblORaceS As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRRaceS As System.Windows.Forms.Label
    Friend WithEvents lblBRaceS As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblBet As System.Windows.Forms.Label
End Class
