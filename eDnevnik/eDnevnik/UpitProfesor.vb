Imports System.Data.SQLite

Public Class UpitProfesor
    Dim database As New Database
    Dim conn As String = database.connectionString
    Dim brojac As Integer = 0

    ' Sub for loading data from data grid view into textboxes
    Private Sub CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataView.CellMouseClick
        On Error Resume Next
        txtSubject.Text = DataView.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub loadSubjects()
        Dim connection As New SQLiteConnection(conn)
        Try
            connection.Open()
        Catch ex As Exception
            connection.Dispose()
            conn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dt As New DataTable
        Try
            If txtSearch.Text.Length <> 0 Then
                Form2Admin.daFill(String.Format("SELECT subject_name FROM tbl_subject WHERE user_id is null AND subject_name='{0}' COLLATE NOCASE;", txtSearch.Text), dt)
            Else
                Form2Admin.daFill("SELECT subject_name FROM tbl_subject WHERE user_id is null;", dt)
            End If
            DataView.DataSource = Nothing
            DataView.DataSource = dt
        Catch ex As Exception
            MsgBox("Greška pri učitavanju predmeta; Poruka: " + ex.Message)
        End Try

        dt.Dispose()
        dt = Nothing
        connection.Close()
        connection.Dispose()
        connection = Nothing
    End Sub

    Private Sub updateUserId()
        Dim sql As String = String.Format("UPDATE tbl_subject SET user_id='{0}' WHERE subject_name='{1}';", Profil.m_user_id, txtSubject.Text)

        Try
            Profil.executeNonQuery(sql)
        Catch ex As Exception
            MessageBox.Show("Greška pri upisivanju korisničkog ID-a; Poruka: " + ex.Message)
        End Try
    End Sub

    Private Sub UpitProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSubjects()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If brojac < 5 Then
            brojac += 1
            If txtSubject.Text <> String.Empty Then
                updateUserId()
                loadSubjects()
                txtSubject.Clear()
            Else
                MessageBox.Show("Odaberite predmet a zatim kliknite dugme.")
            End If
        Else
            MessageBox.Show("Odabrali ste maksimalno 5 predmeta!")
            Me.Hide()
            Profil.Show()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadSubjects()
    End Sub

    Private Sub btnOpenProfile_Click(sender As Object, e As EventArgs) Handles btnOpenProfile.Click
        Me.Hide()
        Profil.Show()
    End Sub
End Class