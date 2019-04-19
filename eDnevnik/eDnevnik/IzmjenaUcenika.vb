Public Class IzmjenaUcenika

    ' ----------------------------------------
    Private Sub TextBoxjmbg_Enter(sender As Object, e As EventArgs) Handles TextBoxjmbg.Enter
        If (TextBoxjmbg.Text = "Jedinstveni matični broj") Then
            TextBoxjmbg.Text = ""
            TextBoxjmbg.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxjmbg_Leave(sender As Object, e As EventArgs) Handles TextBoxjmbg.Leave
        If (TextBoxjmbg.Text = "") Then
            TextBoxjmbg.Text = "Jedinstveni matični broj"
            TextBoxjmbg.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxIme_Enter(sender As Object, e As EventArgs) Handles TextBoxIme.Enter
        If (TextBoxIme.Text = "Ime učenika") Then
            TextBoxIme.Text = ""
            TextBoxIme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxIme_Leave(sender As Object, e As EventArgs) Handles TextBoxIme.Leave
        If (TextBoxIme.Text = "") Then
            TextBoxIme.Text = "Ime učenika"
            TextBoxIme.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxPrezime_Enter(sender As Object, e As EventArgs) Handles TextBoxPrezime.Enter
        If (TextBoxPrezime.Text = "Prezime učenika") Then
            TextBoxPrezime.Text = ""
            TextBoxPrezime.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxPrezime_Leave(sender As Object, e As EventArgs) Handles TextBoxPrezime.Leave
        If (TextBoxPrezime.Text = "") Then
            TextBoxPrezime.Text = "Prezime učenika"
            TextBoxPrezime.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxAdresa_Enter(sender As Object, e As EventArgs) Handles TextBoxAdresa.Enter
        If (TextBoxAdresa.Text = "Adresa") Then
            TextBoxAdresa.Text = ""
            TextBoxAdresa.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxAdresa_Leave(sender As Object, e As EventArgs) Handles TextBoxAdresa.Leave
        If (TextBoxAdresa.Text = "") Then
            TextBoxAdresa.Text = "Adresa"
            TextBoxAdresa.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxDatumR_Enter(sender As Object, e As EventArgs) Handles TextBoxDatumR.Enter
        If (TextBoxDatumR.Text = "Datum rođenja") Then
            TextBoxDatumR.Text = ""
            TextBoxDatumR.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxDatumR_Leave(sender As Object, e As EventArgs) Handles TextBoxDatumR.Leave
        If (TextBoxDatumR.Text = "") Then
            TextBoxDatumR.Text = "Datum rođenja"
            TextBoxDatumR.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxSifra_Enter(sender As Object, e As EventArgs) Handles TextBoxSifra.Enter
        If (TextBoxSifra.Text = "Šifra učenika") Then
            TextBoxSifra.Text = ""
            TextBoxSifra.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxSifra_Leave(sender As Object, e As EventArgs) Handles TextBoxSifra.Leave
        If (TextBoxSifra.Text = "") Then
            TextBoxSifra.Text = "Šifra učenika"
            TextBoxSifra.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxImeRod_Enter(sender As Object, e As EventArgs) Handles TextBoxImeRod.Enter
        If (TextBoxImeRod.Text = "Ime roditelja") Then
            TextBoxImeRod.Text = ""
            TextBoxImeRod.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxImeRod_Leave(sender As Object, e As EventArgs) Handles TextBoxImeRod.Leave
        If (TextBoxImeRod.Text = "") Then
            TextBoxImeRod.Text = "Ime roditelja"
            TextBoxImeRod.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxGodina_Enter(sender As Object, e As EventArgs) Handles TextBoxGodina.Enter
        If (TextBoxGodina.Text = "Godina") Then
            TextBoxGodina.Text = ""
            TextBoxGodina.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxGodina_Leave(sender As Object, e As EventArgs) Handles TextBoxGodina.Leave
        If (TextBoxGodina.Text = "") Then
            TextBoxGodina.Text = "Godina"
            TextBoxGodina.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxOdjeljenje_Enter(sender As Object, e As EventArgs) Handles TextBoxOdjeljenje.Enter
        If (TextBoxOdjeljenje.Text = "Odjeljenje") Then
            TextBoxOdjeljenje.Text = ""
            TextBoxOdjeljenje.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxOdjeljenje_Leave(sender As Object, e As EventArgs) Handles TextBoxOdjeljenje.Leave
        If (TextBoxOdjeljenje.Text = "") Then
            TextBoxOdjeljenje.Text = "Odjeljenje"
            TextBoxOdjeljenje.ForeColor = Color.Gray
        End If
    End Sub
    ' ----------------------------------------------
    Private Sub ButtonNazad_Click(sender As Object, e As EventArgs) Handles ButtonNazad.Click
        Me.Hide()
        Form2Admin.Show()
    End Sub
End Class