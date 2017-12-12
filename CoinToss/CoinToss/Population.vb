Public Class Population

    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim intCount As Integer = 1
        Dim dblTotal As Double


        lstPredict.Items.Add("Day       Approximate Population")
        lstPredict.Items.Add("-----------------------------------")
        dblTotal = 2
        lstPredict.Items.Add(intCount & "         " & cboStartingNumber.Text)
        For intCount = intCount + 1 To cboDaysToMultiply.Text
            dblTotal = (txtDailyIncrease.Text / 100) * dblTotal + dblTotal
            lstPredict.Items.Add(intCount.ToString & "        " & dblTotal.ToString("n"))
        Next


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPredict.Items.Clear()
    End Sub
End Class