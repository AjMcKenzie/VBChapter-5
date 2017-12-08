<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Population
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
        Me.cboDaysToMultiply = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDailyIncrease = New System.Windows.Forms.TextBox()
        Me.listPredict = New System.Windows.Forms.ListBox()
        Me.btnPredict = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboStartingNumber = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboDaysToMultiply
        '
        Me.cboDaysToMultiply.FormattingEnabled = True
        Me.cboDaysToMultiply.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboDaysToMultiply.Location = New System.Drawing.Point(252, 81)
        Me.cboDaysToMultiply.Name = "cboDaysToMultiply"
        Me.cboDaysToMultiply.Size = New System.Drawing.Size(102, 21)
        Me.cboDaysToMultiply.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter/Select the number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of days it will be left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to multiply:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Average daily " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "population increase " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as percentage:"
        '
        'txtDailyIncrease
        '
        Me.txtDailyIncrease.Location = New System.Drawing.Point(15, 81)
        Me.txtDailyIncrease.Name = "txtDailyIncrease"
        Me.txtDailyIncrease.Size = New System.Drawing.Size(100, 20)
        Me.txtDailyIncrease.TabIndex = 4
        '
        'listPredict
        '
        Me.listPredict.FormattingEnabled = True
        Me.listPredict.Location = New System.Drawing.Point(69, 108)
        Me.listPredict.Name = "listPredict"
        Me.listPredict.Size = New System.Drawing.Size(225, 147)
        Me.listPredict.TabIndex = 5
        '
        'btnPredict
        '
        Me.btnPredict.Location = New System.Drawing.Point(54, 309)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(84, 36)
        Me.btnPredict.TabIndex = 6
        Me.btnPredict.Text = "Predict Growth"
        Me.btnPredict.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(144, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboStartingNumber
        '
        Me.cboStartingNumber.FormattingEnabled = True
        Me.cboStartingNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboStartingNumber.Location = New System.Drawing.Point(126, 80)
        Me.cboStartingNumber.Name = "cboStartingNumber"
        Me.cboStartingNumber.Size = New System.Drawing.Size(102, 21)
        Me.cboStartingNumber.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter/Select the number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of starting organisms:"
        '
        'Population
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 357)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboStartingNumber)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPredict)
        Me.Controls.Add(Me.listPredict)
        Me.Controls.Add(Me.txtDailyIncrease)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDaysToMultiply)
        Me.Name = "Population"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDaysToMultiply As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDailyIncrease As System.Windows.Forms.TextBox
    Friend WithEvents listPredict As System.Windows.Forms.ListBox
    Friend WithEvents btnPredict As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cboStartingNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
