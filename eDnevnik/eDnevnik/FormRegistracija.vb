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

    ' Function returns integer value that corresponds checked radioButton
    Private Function accountType() As Integer
        Dim value As Integer = 0
        If isAccountTypeValid() Then
            If RadioButtonAdmin.Checked() Then
                value = 1
            End If
            If RadioButtonProfesor.Checked() Then
                value = 2
            End If

            If RadioButtonUcenik.Checked() Then
                value = 3
            End If
        End If
        'MessageBox.Show(value)
        Return value
    End Function

    ' Function returns True if at least one of three given radioButtons is checked
    Private Function isAccountTypeValid() As Boolean
        Dim value As Boolean = False
        If RadioButtonProfesor.Checked = False And RadioButtonUcenik.Checked = False And RadioButtonAdmin.Checked = False Then
            MessageBox.Show("Odaberite tip računa!")
            value = False
        Else
            value = True
        End If
        'MessageBox.Show(value)
        Return value
    End Function

    ' Function that will return True if a certain field is passed validation
    Private Function isValidField(validationParam As String, txtbox As String) As Boolean
        Dim value As Boolean = False
        If txtbox <> validationParam And txtbox <> "" Then
            value = True
        Else
            value = False
        End If
        'MessageBox.Show(value)
        Return value
    End Function

    ' Function that will return input for non-required fields. That input will be stored in the table
    Private Function returnFieldInput(validationParam As String, txtbox As String) As String
        Dim value As String = String.Empty
        If txtbox <> validationParam And txtbox <> "" Then
            value = txtbox
        Else
            value = String.Empty
        End If
        'MessageBox.Show(value)
        Return value
    End Function

    ' Function that checks if a particular account already exist in registration table or user table
    Private Function doesExistRecord(table As String, column As String, txtBox As String)
        Dim sql As String = String.Format("SELECT * FROM {0} WHERE {1} = @argument", table, column)
        Dim value As Boolean = False
        Dim db As New Database

        Try
            Using conn As New SQLiteConnection(db.connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@argument", txtBox)
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
        'MessageBox.Show(value)
    End Function

    Private Function isValidRegistration() As Boolean
        Dim value As Boolean = False
        Dim type As Integer = accountType()

        Dim FnameValid As Boolean = isValidField("Unesite ime", TextBoxIme.Text)
        Dim LnameValid As Boolean = isValidField("Prezime", TextBoxPrezime.Text)
        Dim jmbgValid As Boolean = isValidField("Matični broj", TextBoxJmbg.Text)
        Dim UsernameValid As Boolean = isValidField("Korisničko ime", TextBoxKorIme.Text)
        Dim passwordValid As Boolean = isValidField("Šifra", TextBoxSifra.Text)

        Dim ParentName As String = returnFieldInput("Ime roditelja", TextBoxRod.Text)
        Dim Address As String = returnFieldInput("Adresa", TextBoxAdresa.Text)
        Dim BDate As String = returnFieldInput("Datum rođenja", TextBoxDatum.Text)


        Dim jmbgReg As Boolean = doesExistRecord("tbl_registration", "reg_jmbg", TextBoxJmbg.Text)
        Dim jmbgUser As Boolean = doesExistRecord("tbl_user", "user_jmbg", TextBoxJmbg.Text)

        Dim password As String = Encryption.hashString(TextBoxSifra.Text, TextBoxJmbg.Text)

        Dim sqlCommand As String = String.Format("INSERT INTO tbl_registration (reg_type_id, reg_first_name, reg_last_name, reg_jmbg, reg_username, reg_password, reg_parent_name, reg_address, reg_birthdate) VALUES ({0},'{1}', '{2}', {3}, 
                                                            '{4}', '{5}', '{6}', '{7}', '{8}')", type, TextBoxIme.Text, TextBoxPrezime.Text, TextBoxJmbg.Text, TextBoxKorIme.Text, password, ParentName, Address, BDate)



        If isAccountTypeValid() = False Then
            MessageBox.Show("Odaberite tip računa!")
        Else
            If FnameValid = True And LnameValid = True Then
                ' Check if user already sent registration request and does user already exist
                ' Check only jmbg because it has UNIQUE property
                If jmbgUser = True Then
                    MessageBox.Show("Korisnik već postoji!")
                End If
                If jmbgReg = True Then
                    MessageBox.Show("Već ste poslali zahtjev, pričekajte odobrenje!")
                Else
                    If jmbgValid = False Or TextBoxJmbg.Text.Length <> 13 Then
                        MessageBox.Show("Ispravno unesite matični broj! Provjerite dužinu broja!")
                    Else
                        If UsernameValid = False Then
                            MessageBox.Show("Ispravno unesite korisničko ime!")
                        Else
                            If passwordValid = False Then
                                MessageBox.Show("Ispravno unesite šifru!")
                            Else
                                value = True
                                Dim database As New Database
                                database.execute(sqlCommand)
                            End If
                        End If
                    End If

                End If

            Else
                MessageBox.Show("Neispravno uneseno ime ili prezime!")
            End If
        End If
        Return value
    End Function

    Private Sub ButtonRegistracija_Click(sender As Object, e As EventArgs) Handles ButtonRegistracija.Click
        If isValidRegistration() = True Then

            MessageBox.Show("Uspješna registacija. Molimo pričekajte odobrenje administratora!")
            setAllTxtDefault()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Send_Email.Show()
    End Sub
End Class