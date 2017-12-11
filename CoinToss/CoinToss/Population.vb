Public Class Population

    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim Growth As Decimal 'Final awnser
        Dim StartNum As Integer
        Dim NumDays As Integer
        Dim AvgIncrease As Decimal
        Dim ND As Decimal

        StartNum = (cboStartingNumber.Text)
        NumDays = (cboDaysToMultiply.Text)
        AvgIncrease = (txtDailyIncrease.Text)

        Do While ND < NumDays
            ND = ND + 1
            lstPredict.Items.Add(ND)
        Loop

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPredict.Items.Clear()
    End Sub
End Class