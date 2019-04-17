

Public Class Form1Login
    Private Sub TextBoxIme_Enter(sender As Object, e As EventArgs) Handles TextBoxIme.Enter
        If (TextBoxIme.Text = "Korisničko ime") Then
            TextBoxIme.Text = ""
            TextBoxIme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxIme_Leave(sender As Object, e As EventArgs) Handles TextBoxIme.Leave
        If (TextBoxIme.Text = "") Then
            TextBoxIme.Text = "Korisničko ime"
            TextBoxIme.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxPrezime_Enter(sender As Object, e As EventArgs) Handles TextBoxPrezime.Enter
        If (TextBoxPrezime.Text = "Prezime") Then
            TextBoxPrezime.Text = ""
            TextBoxPrezime.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxPrezime_Leave(sender As Object, e As EventArgs) Handles TextBoxPrezime.Leave
        If (TextBoxPrezime.Text = "") Then
            TextBoxPrezime.Text = "Prezime"
            TextBoxPrezime.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxSifra_Enter(sender As Object, e As EventArgs) Handles TextBoxSifra.Enter
        If (TextBoxSifra.Text = "Šifra") Then
            TextBoxSifra.Text = ""
            TextBoxSifra.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxSifra_Leave(sender As Object, e As EventArgs) Handles TextBoxSifra.Leave
        If (TextBoxSifra.Text = "") Then
            TextBoxSifra.Text = "Šifra"
            TextBoxSifra.ForeColor = Color.Gray
        End If
    End Sub
    ' ---------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Database As New Database()
        Database.createPredefinedDatabase()
    End Sub

    Private Sub ButtonPrijava_Click(sender As Object, e As EventArgs) Handles ButtonPrijava.Click
        Me.Hide()
        Form2Admin.Show()
    End Sub
End Class
