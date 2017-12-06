Public Class SumOfNumbers

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim intSum As Integer
        Dim input As Integer

        input = InputBox("Enter a positive integer value.")
        For i As Integer = 0 To input
            intSum += i
        Next

        MessageBox.Show("The sum of numbers 1 through " & input & " is " & intSum)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class