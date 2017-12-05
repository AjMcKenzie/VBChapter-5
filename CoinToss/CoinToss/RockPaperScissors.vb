Public Class RockPaperScissors
    Dim intScore As Integer

    Private Sub picScissors_Click(sender As Object, e As EventArgs) Handles picScissors.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Choose- Rock. You Choose- Scissors." & vbCrLf & "                                         You Lose!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Pc Choose- Paper. You Choose- Scissors." & vbCrLf & "                                     You Win!")
            intScore = intScore + 1
        ElseIf intShoot = 2 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Pc Choose- Scissors. You Choose- Scissors." & vbCrLf & "                                  You Tie!")
        End If
        lblWins.Text = intScore.ToString
    End Sub

    Private Sub picPaper_Click(sender As Object, e As EventArgs) Handles picPaper.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "         Pc Choose- Rock. You Choose- Paper." & vbCrLf & "                                       You Win!")
            intScore = intScore + 1
        ElseIf intShoot = 1 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "         Pc Choose- Paper. You Choose- Paper." & vbCrLf & "                                       You Tie!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "         Pc Choose- Scissors. You Choose- Paper." & vbCrLf & "                                   You Lose!")
        End If
        lblWins.Text = intScore.ToString
    End Sub

    Private Sub picRock_Click(sender As Object, e As EventArgs) Handles picRock.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Pc Choose- Rock. You Choose- Rock. " & vbCrLf & "                                  You Tie!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Pc Choose- Paper. You Choose- Rock." & vbCrLf & "                                  You Lose!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("                               Pc VS Player!" & vbCrLf & "        Pc Choose- Scissors. You Choose- Rock." & vbCrLf & "                               You Win!")
            intScore = intScore + 1
        End If
        lblWins.Text = intScore.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class