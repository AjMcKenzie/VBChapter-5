Public Class Menu

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim input As String
        Dim Box As New BlackGamble
        input = InputBox("Enter a name you want to go by:")
        MessageBox.Show("Well " & input & " you found the Black Gamble. Never thought you would." & vbCrLf & "Click on help to learn more about it.")
        Box.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Box = New RightTriangle()
        Box.Show()
    End Sub
    Private Sub btnSumOfNumbers_Click(sender As Object, e As EventArgs) Handles btnSumOfNumbers.Click
        Dim Box = New SumOfNumbers()
        Box.Show()
    End Sub
End Class