Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtists.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cboArtists.SelectedIndex = -1

        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty
        cboPlays.SelectedIndex = -1
        lblArtist.Text = String.Empty
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
