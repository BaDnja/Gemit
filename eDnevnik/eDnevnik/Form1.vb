Imports System.Data.SQLite

Public Class Form1Login
    Dim Database As New Database()

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
        Database.createPredefinedDatabase()

    End Sub

    ' Sub that will set isPassedName as True if NAME is passed login
    Private Function isValidUser(colonName As String, tableName As String, checkParameter As String) As Boolean
        Dim isPassed As Boolean

        Using sqlConn As New SQLiteConnection(Database.connectionString)
            Dim readUser As String = String.Format("SELECT {0} FROM {1} WHERE {0}='{2}'", colonName, tableName, checkParameter)
            Dim cmdUser As New SQLiteCommand(readUser, sqlConn)
            sqlConn.Open()

            Dim readerUser As SQLiteDataReader = cmdUser.ExecuteReader()
            While readerUser.Read()
                For i = 0 To readerUser.FieldCount - 1
                    If readerUser.GetValue(i) = Name Then
                        isPassed = True
                        Exit For
                    End If
                Next
            End While
            sqlConn.Close()
        End Using
        Return isPassed
    End Function

    Private Sub ButtonPrijava_Click(sender As Object, e As EventArgs) Handles ButtonPrijava.Click
        If RadioButtonProfesor.Checked() Then
            Dim c1 As Boolean = isValidUser("ime", "profesor", TextBoxIme.Text)
            'Dim c2 As Boolean = isValidUser("prezime", "profesor", TextBoxPrezime.Text)
            'Dim c3 As Boolean = isValidUser("sifraProfesora", "profesor", TextBoxSifra.Text)
            MessageBox.Show(c1)
            'MessageBox.Show(c2)
            'MessageBox.Show(c3)

            'If c1 = True And c2 = True And c3 = True Then
            '    MessageBox.Show("User passed!")
            'End If

        End If

    End Sub

    Private Sub RadioButtonProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonProfesor.CheckedChanged
        TextBoxPrezime.Show()
    End Sub

    Private Sub RadioButtonUcenik_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUcenik.CheckedChanged
        TextBoxPrezime.Show()
    End Sub

    Private Sub RadioButtonAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAdmin.CheckedChanged
        TextBoxPrezime.Hide()
    End Sub
End Class
