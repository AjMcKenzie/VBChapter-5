<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightTriangle
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCside = New System.Windows.Forms.RadioButton()
        Me.radBside = New System.Windows.Forms.RadioButton()
        Me.radAside = New System.Windows.Forms.RadioButton()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCside)
        Me.GroupBox1.Controls.Add(Me.radBside)
        Me.GroupBox1.Controls.Add(Me.radAside)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 128)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'radCside
        '
        Me.radCside.AutoSize = True
        Me.radCside.Location = New System.Drawing.Point(6, 86)
        Me.radCside.Name = "radCside"
        Me.radCside.Size = New System.Drawing.Size(104, 17)
        Me.radCside.TabIndex = 2
        Me.radCside.TabStop = True
        Me.radCside.Text = "Solve For C Side"
        Me.radCside.UseVisualStyleBackColor = True
        '
        'radBside
        '
        Me.radBside.AutoSize = True
        Me.radBside.Location = New System.Drawing.Point(6, 52)
        Me.radBside.Name = "radBside"
        Me.radBside.Size = New System.Drawing.Size(104, 17)
        Me.radBside.TabIndex = 1
        Me.radBside.TabStop = True
        Me.radBside.Text = "Solve For B Side"
        Me.radBside.UseVisualStyleBackColor = True
        '
        'radAside
        '
        Me.radAside.AutoSize = True
        Me.radAside.Location = New System.Drawing.Point(6, 19)
        Me.radAside.Name = "radAside"
        Me.radAside.Size = New System.Drawing.Size(104, 17)
        Me.radAside.TabIndex = 0
        Me.radAside.TabStop = True
        Me.radAside.Text = "Solve For A Side"
        Me.radAside.UseVisualStyleBackColor = True
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(165, 78)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(100, 20)
        Me.txtSideA.TabIndex = 1
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(165, 109)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(100, 20)
        Me.txtSideB.TabIndex = 2
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(165, 146)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(100, 20)
        Me.txtSideC.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(172, 184)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 30)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(172, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(172, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RightTriangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 314)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RightTriangle"
        Me.Text = "RightTriangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCside As System.Windows.Forms.RadioButton
    Friend WithEvents radBside As System.Windows.Forms.RadioButton
    Friend WithEvents radAside As System.Windows.Forms.RadioButton
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
