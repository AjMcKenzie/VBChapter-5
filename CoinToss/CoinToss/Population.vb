Public Class Population

    Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim NumOrganisms As Integer
        Dim AverageDaily As Decimal
        Dim NumDaysMultiply As Integer
        Dim NumDM As Integer
        Dim Growth As Decimal
        Dim AVGDays As Decimal

        NumOrganisms = (cboStartingNumber.Text)
        AverageDaily = (txtDailyIncrease.Text)
        NumDaysMultiply = (cboDaysToMultiply.Text)

        Do While NumDM < NumDaysMultiply
            NumDM = NumDM + 1
            lstPredict.Items.Add(NumDM)
           
        Loop

        AVGDays = AverageDaily * NumOrganisms / 100
        Growth = AVGDays + NumDM
        lstPredict.Items.Add(Growth)


       
       
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPredict.Items.Clear()
    End Sub
End Class