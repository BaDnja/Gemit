Imports System.Data.SQLite

Public Class FormRegistracija
    ' Subs collection for setting default properties to Text boxes
    Private Sub setDefaultTxtBoxIme()
        TextBoxIme.Text = "Unesite ime"
        TextBoxIme.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxPrezime()
        TextBoxPrezime.Text = "Prezime"
        TextBoxPrezime.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxSifra()
        TextBoxSifra.Text = "Šifra"
        TextBoxSifra.UseSystemPasswordChar = False
        TextBoxSifra.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxJmbg()
        TextBoxJmbg.Text = "Matični broj"
        TextBoxJmbg.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxKorIme()
        TextBoxKorIme.Text = "Korisničko ime"
        TextBoxKorIme.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxRod()
        TextBoxRod.Text = "Ime roditelja"
        TextBoxRod.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxAdresa()
        TextBoxAdresa.Text = "Adresa"
        TextBoxAdresa.ForeColor = Color.Gray
    End Sub

    Private Sub setDefaultTxtBoxDatum()
        TextBoxDatum.Text = "Datum rođenja"
        TextBoxDatum.ForeColor = Color.Gray
    End Sub

    Private Sub setAllTxtDefault()
        setDefaultTxtBoxIme()
        setDefaultTxtBoxPrezime()
        setDefaultTxtBoxSifra()
        setDefaultTxtBoxJmbg()
        setDefaultTxtBoxKorIme()
        setDefaultTxtBoxRod()
        setDefaultTxtBoxAdresa()
        setDefaultTxtBoxDatum()
    End Sub


    '-----------------------------

    '--------------------------------------------------------
    Private Sub TextBoxIme_Enter(sender As Object, e As EventArgs) Handles TextBoxIme.Enter
        If (TextBoxIme.Text = "Unesite ime") Then
            TextBoxIme.Text = ""
            TextBoxIme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxIme_Leave(sender As Object, e As EventArgs) Handles TextBoxIme.Leave
        If (TextBoxIme.Text = "") Then
            setDefaultTxtBoxIme()
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
            setDefaultTxtBoxPrezime()
        End If
    End Sub

    Private Sub TextBoxJmbg_Enter(sender As Object, e As EventArgs) Handles TextBoxJmbg.Enter
        If (TextBoxJmbg.Text = "Matični broj") Then
            TextBoxJmbg.Text = ""
            TextBoxJmbg.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxJmbg_Leave(sender As Object, e As EventArgs) Handles TextBoxJmbg.Leave
        If (TextBoxJmbg.Text = "") Then
            setDefaultTxtBoxJmbg()
        End If
    End Sub

    Private Sub TextBoxKorIme_Enter(sender As Object, e As EventArgs) Handles TextBoxKorIme.Enter
        If (TextBoxKorIme.Text = "Korisničko ime") Then
            TextBoxKorIme.Text = ""
            TextBoxKorIme.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxKorIme_Leave(sender As Object, e As EventArgs) Handles TextBoxKorIme.Leave
        If (TextBoxKorIme.Text = "") Then
            setDefaultTxtBoxKorIme()
        End If
    End Sub

    Private Sub TextBoxSifra_Enter(sender As Object, e As EventArgs) Handles TextBoxSifra.Enter
        'ButtonEye.Show()
        If (TextBoxSifra.Text = "Šifra") Then
            TextBoxSifra.Text = ""
            TextBoxSifra.UseSystemPasswordChar = True
            TextBoxSifra.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxSifra_Leave(sender As Object, e As EventArgs) Handles TextBoxSifra.Leave
        'ButtonEye.Hide()
        If (TextBoxSifra.Text = "") Then
            setDefaultTxtBoxSifra()
        End If
    End Sub

    Private Sub TextBoxRod_Enter(sender As Object, e As EventArgs) Handles TextBoxRod.Enter
        If (TextBoxRod.Text = "Ime roditelja") Then
            TextBoxRod.Text = ""
            TextBoxRod.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxRod_Leave(sender As Object, e As EventArgs) Handles TextBoxRod.Leave
        If (TextBoxRod.Text = "") Then
            setDefaultTxtBoxRod()
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
            setDefaultTxtBoxAdresa()
        End If
    End Sub

    Private Sub TextBoxDatum_Enter(sender As Object, e As EventArgs) Handles TextBoxDatum.Enter
        If (TextBoxDatum.Text = "Datum rođenja") Then
            TextBoxDatum.Text = ""
            TextBoxDatum.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxDatum_Leave(sender As Object, e As EventArgs) Handles TextBoxDatum.Leave
        If (TextBoxDatum.Text = "") Then
            setDefaultTxtBoxDatum()
        End If
    End Sub

    '--------------------------------------------------------
    Private Sub ButtonNazad_Click(sender As Object, e As EventArgs) Handles ButtonNazad.Click
        setAllTxtDefault()
        Me.Hide()
        Form1Login.Show()
    End Sub

    Private Function isAccountTypeValid(state As Boolean) As Boolean
        Dim value As Boolean = False
        If RadioButtonProfesor.Checked = False And RadioButtonUcenik.Checked = False And RadioButtonAdmin.Checked = False Then
            MessageBox.Show("Odaberite tip računa!")
            value = False
        Else
            value = True
        End If
        Return value
    End Function

    Private Function isFirstNameValid(str As String) As Boolean
        Dim value As Boolean = False
        If Not TextBoxIme.Text = "" Or TextBoxIme.Text = "Unesite ime" Then
            value = True
        Else
            value = False
        End If
        Return value
    End Function

    Private Function isLastNameValid(str As String) As Boolean
        Dim value As Boolean = False
        If Not TextBoxPrezime.Text = "" Or TextBoxPrezime.Text = "Prezime" Then
            value = True
        Else
            value = False
        End If
        Return value
    End Function

    Private Function isJmbgValid(table As String, jmbg As String) As Boolean
        Dim sql As String = String.Format("SELECT * FROM {0} WHERE {1} = @uJmbg", table, jmbg)
        Dim value As Boolean = False
        Dim db As New Database

        Try
            Using conn As New SQLiteConnection(db.connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@uJmbg", TextBoxJmbg.Text)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            value = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return value
    End Function

    Private Function isUsernameValid(table As String, username As String) As Boolean
        Dim sql As String = String.Format("SELECT * FROM {0} WHERE {1} = @uUsername", table, username)
        Dim value As Boolean = False
        Dim db As New Database

        Try
            Using conn As New SQLiteConnection(db.connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@uUsername", TextBoxKorIme.Text)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            value = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return value
    End Function

    Private Function isPasswordValid(table As String, password As String) As Boolean
        Dim sql As String = String.Format("SELECT * FROM {0} WHERE {1} = @uPassword", table, password)
        Dim value As Boolean = False
        Dim db As New Database

        Try
            Using conn As New SQLiteConnection(db.connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@uPassword", Encryption.hashString(TextBoxSifra.Text, TextBoxJmbg.Text))
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            value = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Return value
        MessageBox.Show(value)
    End Function

    Private Sub ButtonRegistracija_Click(sender As Object, e As EventArgs) Handles ButtonRegistracija.Click
        'isJmbgValid("tbl_user", "user_jmbg")
        'isUsernameValid("tbl_user", "user_username")
        'isPasswordValid("tbl_user", "user_password")
    End Sub
End Class