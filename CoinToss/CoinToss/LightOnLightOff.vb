Public Class LightOnLightOff
    Sub TurnLightOn()
        picLightOn.Visible = True
        picLightOff.Visible = False
        picBrokenBulb.Visible = False
        intLightTurnOn += 1
    End Sub
    Sub TurnLightOff()
        picLightOn.Visible = False
        picLightOff.Visible = True
        picBrokenBulb.Visible = False
    End Sub
    Sub LightBroken()
        picLightOn.Visible = False
        picLightOff.Visible = False
        picBrokenBulb.Visible = True
        btnLightSwitch.Visible = False
    End Sub
     
    Dim intLightTurnOn As Integer

    Private Sub btnLightSwitch_Click(sender As Object, e As EventArgs) Handles btnLightSwitch.Click
        Dim intLightOn As Integer
        Dim intLightBroken As Integer = 10
        Dim rand As New Random

        intLightOn = rand.Next(2)

        If intLightOn = 0 Then
            TurnLightOn()
        Else
            TurnLightOff()
        End If

        If intLightTurnOn = intLightBroken Then
            LightBroken()
        End If

        lblResult.Text = intLightTurnOn.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class