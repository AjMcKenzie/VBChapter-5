Public Class CoinToss
    Dim intHeads As Integer = 0
    Dim intTails As Integer = 0


    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim rand As New Random
        Dim intSideUp As Integer
        intSideUp = rand.Next(2)

        If intSideUp = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
            intTails += 1
            lblTails.Text = intTails.ToString("n")
        End If

        If intSideUp = 1 Then
            picTails.Visible = False
            picHeads.Visible = True
            intHeads += 1
            lblHeads.Text = intHeads.ToString("n")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
