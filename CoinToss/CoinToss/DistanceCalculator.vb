Public Class DistanceCalculator
    Dim Speed As Decimal
    Dim Time As Decimal
    Dim Distance As Decimal
    Dim Hours As Decimal
    Sub Calc()
        Hours = Hours + 1
        Distance = Speed * Hours
        listDistance.Items.Add(Hours & "              " & Distance.ToString)
    End Sub

    Sub Clear()
        listDistance.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Speed = InputBox("Enter the speed vehical in miles-per-hour")
        Time = InputBox("Enter the amount of time, in hours")

        listDistance.Items.Add("Vehicle Speed: " & Speed & " MPH")
        listDistance.Items.Add("Time Traveled: " & Time & " hours")
        listDistance.Items.Add("Hours      Distance Traveled")
        listDistance.Items.Add("------------------------------------------------------")
        Do While Hours < Time
            Calc()
        Loop
        listDistance.Items.Add("Total Distance: " & Distance.ToString)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class