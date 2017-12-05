Public Class RightTriangle

    Sub calcSideA(ByVal Bside As Double, ByVal CSide As Double)
        Dim Aside As Double
        Aside = Math.Sqrt(CSide * CSide - Bside * Bside)
        txtSideA.Text = Aside.ToString("n2")
    End Sub 'Aside
    Sub calcSideB(ByVal Aside As Double, ByVal Cside As Double)
        Dim Bside As Double
        Bside = Math.Sqrt(Cside * Cside - Aside * Aside)
        txtSideB.Text = Bside.ToString("n2")
    End Sub 'Bside
    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtSideC.Text = Cside.ToString("n2")
    End Sub 'Cside
    Sub clear()
        txtSideA.Clear()
        txtSideB.Clear()
        txtSideC.Clear()
        radAside.Checked = False
        radBside.Checked = False
        radCside.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If radAside.Checked = True Then
            calcSideA(CDbl(txtSideB.Text), CDbl(txtSideC.Text))
        ElseIf radBside.Checked = True Then
            calcSideB(CDbl(txtSideA.Text), CDbl(txtSideC.Text))
        ElseIf radCside.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
End Class