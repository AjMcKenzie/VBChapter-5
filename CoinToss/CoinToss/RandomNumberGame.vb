Public Class RandomNumberGame

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim rand As New Random
        Dim PCNumber As Integer
        Dim userGuess As Integer
        Dim Wrong As Integer

        PCNumber = rand.Next(100)

        Do While userGuess <> PCNumber
            userGuess = InputBox("Enter a number between 1 and 100")
            If userGuess > PCNumber Then
                MessageBox.Show("Guess to High! Try again.")
                Wrong = Wrong + 1
            ElseIf userGuess < PCNumber Then
                MessageBox.Show("Guess to Low! Try again.")
                Wrong = Wrong + 1
            End If
        Loop
        lblWrong.Text = Wrong.ToString
        lblAwnser.Text = ("Correct! The number was " & PCNumber & "!")
    End Sub
End Class