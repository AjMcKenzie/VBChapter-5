Public Class Form1

    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim rand As New Random
        Dim intScore As Integer = 0


            intSideUp = rand.Next(2)
            If intSideUp = 0 Then
                picTails.Visible = True
                picHeads.Visible = False
                If radHeads.Checked = True Then
                    intScore = -1
                    lblScore.Text = intScore.ToString("n")
                ElseIf radTails.Checked = True Then
                    intScore = +1
                    lblScore.Text = intScore.ToString("n")
                End If
            End If

            If intSideUp = 1 Then
                picTails.Visible = False
                picHeads.Visible = True
                If radTails.Checked = True Then
                    intScore = -1
                    lblScore.Text = intScore.ToString("n")
                ElseIf radHeads.Checked = True Then
                intScore = +1
                    lblScore.Text = intScore.ToString("n")
                End If
            End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
