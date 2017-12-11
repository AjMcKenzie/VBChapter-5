Public Class DistanceCalculator
    Dim Speed As Decimal
    Dim Time As Decimal
    Dim Distance As Decimal
    Dim Hours As Decimal
    Sub Calc()
        Hours = Hours + 1
        Distance = Speed * Hours
        lstDistance.Items.Add(Hours & "              " & Distance.ToString)
    End Sub

    Sub Clear()
        lstDistance.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Speed = InputBox("Enter the speed vehical in miles-per-hour")
        Time = InputBox("Enter the amount of time, in hours")

        lstDistance.Items.Add("Vehicle Speed: " & Speed & " MPH")
        lstDistance.Items.Add("Time Traveled: " & Time & " hours")
        lstDistance.Items.Add("Hours      Distance Traveled")
        lstDistance.Items.Add("------------------------------------------------------")
        Do While Hours < Time
            Calc()
        Loop
        lstDistance.Items.Add("Total Distance: " & Distance.ToString)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class