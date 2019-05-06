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

    Private Sub setDefaultTxtBoxJmbg()
        TextBoxJmbg.Text = "Matični broj"
        TextBoxJmbg.ForeColor = Color.Gray
    End Sub

    Public Sub setAllTxtDefault()
        setDefaultTxtBoxIme()
        setDefaultTxtBoxSifra()
        setDefaultTxtBoxJmbg()
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
    ' ---------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.createPredefinedDatabase()
        ButtonEye.Hide()
    End Sub

    Public Sub setStudentID()
        Dim conn As New SQLiteConnection(Database.connectionString)
        Dim sql As String = String.Format("SELECT user_id FROM tbl_user where user_jmbg={0}", TextBoxJmbg.Text)
        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
            lblId.DataBindings.Add("Text", dt, "user_id")
            lblId.Hide()
            Profil.m_student_id = lblId.Text
        Catch ex As Exception
            conn.Dispose()
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonPrijava_Click(sender As Object, e As EventArgs) Handles ButtonPrijava.Click

        If RadioButtonProfesor.Checked = False And RadioButtonUcenik.Checked = False And RadioButtonAdmin.Checked = False Then
            MessageBox.Show("Odaberite tip računa!")
        Else
            If TextBoxJmbg.Text.Length <> 13 Then
                MessageBox.Show("Dužina Matičnog broja nije ispravna!")
                TextBoxJmbg.Clear()
                TextBoxSifra.Clear()
            Else
                If RadioButtonProfesor.Checked() Then
                    If Database.isUserValid("tbl_user") = True Then
                        MessageBox.Show("Profesor ulogovan")
                        Me.Hide()
                        Profil.Show()
                    Else
                        MessageBox.Show("Profesor ne postoji!")
                        setAllTxtDefault()
                    End If
                End If

                If RadioButtonUcenik.Checked() Then
                    If Database.isUserValid("tbl_user") = True Then
                        setStudentID()
                        MessageBox.Show("Učenik ulogovan!")
                        Me.Hide()
                        If Profil.checkIfStudentInfoExist() = False Then
                            Upit.Show()
                        Else
                            Profil.Show()
                        End If

                    Else
                        MessageBox.Show("Učenik ne postoji!")
                        setAllTxtDefault()
                    End If
                End If

                If RadioButtonAdmin.Checked() Then

                    If Database.isUserValid("tbl_user") = True Then
                        Me.Hide()
                        'Form2Admin.Show()
                        Profil.Show()
                    Else
                        MessageBox.Show("Admin ne postoji!")
                        setAllTxtDefault()
                    End If
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

    Private Sub ButtonRegistracija_Click(sender As Object, e As EventArgs) Handles ButtonRegistracija.Click
        setAllTxtDefault()
        Me.Hide()
        FormRegistracija.Show()
    End Sub
End Class
