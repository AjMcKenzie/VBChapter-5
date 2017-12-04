Public Class Menu

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLightGame_Click(sender As Object, e As EventArgs) Handles btnLightGame.Click
        Dim Box = New LightOnLightOff()
        Box.Show()
    End Sub

    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New CoinToss()
        Box.Show()
    End Sub

    Private Sub btnRaceGame_Click(sender As Object, e As EventArgs) Handles btnRaceGame.Click
        Dim Box = New RaceGame()
        Box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box = New RockPaperScissors()
        Box.Show()
    End Sub
End Class