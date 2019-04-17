

Public Class Form1Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Database As New Database()
        Database.createPredefinedDatabase()

        TextBox1.Text = "Ime"
        TextBox2.Text = "Prezime"
        TextBox3.Text = "Korisnička šifra"
    End Sub
End Class
