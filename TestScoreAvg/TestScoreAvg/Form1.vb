Public Class Form1

    Private Sub btnGetScores_Click(sender As Object, e As EventArgs) Handles btnGetScores.Click
        Dim intNumScores As Integer = 5
        Dim dblTestScore As Double
        Dim dblTotal As Double = 0
        Dim dblAverage As Double
        Dim strInput As String
        Dim intCount As Integer = 1

        strInput = InputBox("How many test scores do you want to average?")

        If Integer.TryParse(strInput, intNumScores) Then
            Do Until intCount > intNumScores
                strInput = InputBox("Enter test Score " & intCount.ToString())
                If Double.TryParse(strInput, dblTestScore) Then
                    dblTotal += dblTestScore
                    intCount += 1
                Else
                    MessageBox.Show("Enter a numeric test score.")
                End If
            Loop
            If intNumScores > 0 Then
                dblAverage = dblTotal / intNumScores
                lblAverage.Text = dblAverage.ToString()
            End If
        Else
            MessageBox.Show("Enter an integer value for number of test scores.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
