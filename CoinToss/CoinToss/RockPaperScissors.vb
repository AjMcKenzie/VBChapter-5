Public Class RockPaperScissors

    Private Sub picScissors_Click(sender As Object, e As EventArgs) Handles picScissors.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc VS Player! Pc Choose- Rock. You Choose- Scissors. You Lose!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc VS Player! Pc Choose- Paper. You Choose- Scissors. You Win!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc VS Player! Pc Choose- Scissors. You Choose- Scissors. You Tie!")
        End If
    End Sub

    Private Sub picPaper_Click(sender As Object, e As EventArgs) Handles picPaper.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc Choose- Rock. You Choose- Paper. You Win!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc Choose- Paper. You Choose- Paper. You Tie!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc Choose- Scissors. You Choose- Paper. You Lose!")
        End If
    End Sub

    Private Sub picRock_Click(sender As Object, e As EventArgs) Handles picRock.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc Choose- Rock. You Choose- Rock. You Tie!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc Choose- Paper. You Choose- Rock. You Lose!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc Choose- Scissors. You Choose- Rock. You Win!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class