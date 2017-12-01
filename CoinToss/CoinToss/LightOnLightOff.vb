Public Class LightOnLightOff
    Dim intLightTurnOn As Integer

    Private Sub btnLightSwitch_Click(sender As Object, e As EventArgs) Handles btnLightSwitch.Click
        Dim intLightOn As Integer
        Dim intLightBroken As Integer = 10
        Dim rand As New Random

        intLightOn = rand.Next(2)

        If intLightOn = 0 Then
            picLightOn.Visible = True
            picLightOff.Visible = False
            picBrokenBulb.Visible = False
            intLightTurnOn += 1
        Else
            picLightOn.Visible = False
            picLightOff.Visible = True
            picBrokenBulb.Visible = False
        End If

        If intLightTurnOn = intLightBroken Then
            picLightOn.Visible = False
            picLightOff.Visible = False
            picBrokenBulb.Visible = True
            btnLightSwitch.Visible = False
        End If
        lblResult.Text = intLightTurnOn.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class