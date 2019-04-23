Imports System.Data.SQLite

Public Class Form1Login
    Dim Database As New Database()

    ' Subs collection for setting default properties to Text boxes
    Private Sub setDefaultTxtBoxIme()
        TextBoxIme.Text = "Korisničko ime"
        TextBoxIme.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxSifra()
        TextBoxSifra.Text = "Šifra"
        TextBoxSifra.UseSystemPasswordChar = False
        TextBoxSifra.ForeColor = Color.Gray
    End Sub

    '-----------------------------
    Private Sub TextBoxIme_Enter(sender As Object, e As EventArgs) Handles TextBoxIme.Enter
        If (TextBoxIme.Text = "Korisničko ime") Then
            TextBoxIme.Text = ""
            TextBoxIme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxIme_Leave(sender As Object, e As EventArgs) Handles TextBoxIme.Leave
        If (TextBoxIme.Text = "") Then
            setDefaultTxtBoxIme()
        End If
    End Sub

    Private Sub TextBoxSifra_Enter(sender As Object, e As EventArgs) Handles TextBoxSifra.Enter
        ButtonEye.Show()
        If (TextBoxSifra.Text = "Šifra") Then
            TextBoxSifra.Text = ""
            TextBoxSifra.UseSystemPasswordChar = True
            TextBoxSifra.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxSifra_Leave(sender As Object, e As EventArgs) Handles TextBoxSifra.Leave
        ButtonEye.Hide()
        If (TextBoxSifra.Text = "") Then
            setDefaultTxtBoxSifra()
        End If
    End Sub
    ' ---------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.createPredefinedDatabase()
        ButtonEye.Hide()
    End Sub

    Private Sub ButtonPrijava_Click(sender As Object, e As EventArgs) Handles ButtonPrijava.Click

        If RadioButtonProfesor.Checked = False And RadioButtonUcenik.Checked = False And RadioButtonAdmin.Checked = False Then
            MessageBox.Show("Odaberite tip računa!")
        Else
            If RadioButtonProfesor.Checked() Then
                If Database.isUserValid() = True Then
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                    MessageBox.Show("Profesor ulogovan")
                Else
                    MessageBox.Show("Profesor ne postoji!")
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                End If
            End If

            If RadioButtonUcenik.Checked() Then
                If Database.isUserValid() = True Then
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                    MessageBox.Show("Učenik ulogovan")
                Else
                    MessageBox.Show("Učenik ne postoji!")
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                End If
            End If


            If RadioButtonAdmin.Checked() Then

                If Database.isUserValid() = True Then
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                    Me.Hide()
                    Form2Admin.Show()
                Else
                    MessageBox.Show("Admin ne postoji!")
                    setDefaultTxtBoxIme()
                    setDefaultTxtBoxSifra()
                End If
            End If
        End If


    End Sub

    Private Sub ButtonEye_MouseEnter(sender As Object, e As EventArgs) Handles ButtonEye.MouseEnter

        TextBoxSifra.UseSystemPasswordChar = False
    End Sub

    Private Sub ButtonEye_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEye.MouseLeave

        TextBoxSifra.UseSystemPasswordChar = True
    End Sub
End Class
