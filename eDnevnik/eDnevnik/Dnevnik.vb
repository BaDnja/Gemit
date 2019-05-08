Imports System.Data.SQLite

Public Class Dnevnik
    Dim database As New Database
    Dim conn As String = database.connectionString
    Dim connection As New SQLiteConnection(conn)

    Private Sub hideElements()
        lblOd.Hide()
        lblOc.Hide()

        CBClass.Hide()
        CBScore.Hide()
    End Sub

    Private Sub populateSubjectCombobox()
        Dim cmd As New SQLiteCommand(String.Format("SELECT subject_id, subject_name FROM tbl_subject WHERE user_id='{0}'", Profil.m_user_id), connection)
        cmbSubject.Items.Clear()
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            cmbSubject.DataSource = table
            cmbSubject.DisplayMember = "subject_name"
            lblSubjectID.DataBindings.Add("Text", table, "subject_id")
            lblSubjectID.Hide()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            connection.Dispose()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function getCurrentDate() As String
        Return String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    End Function

    Private Function checkIfScoreExist() As Boolean
        Dim value As Boolean = False
        Dim sql As String = String.Format("SELECT user_id, subject_id, date FROM tbl_score WHERE user_id='{0}' AND subject_id='{1}' AND date='{2}'",
                                          lblUserID.Text, lblSubjectID.Text, getCurrentDate())


        Using cmd As New SQLiteCommand(connection)
            cmd.CommandText = sql
            connection.Open()
            Using da As New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    value = True
                End If
            End Using
            connection.Close()
        End Using
        Return value
    End Function

    Private Sub insertScore()
        Dim sql As String = String.Format("INSERT INTO tbl_score (user_id, subject_id, date, score) VALUES ({0}, {1}, '{2}', '{3}')",
                                                lblUserID.Text, lblSubjectID.Text, getCurrentDate(), CBScore.SelectedValue)

        If checkIfScoreExist() = False Then
            If lblUserID.Text <> String.Empty Then


                Try
                    connection.Open()
                    Profil.executeNonQuery(sql)
                    connection.Close()
                Catch ex As Exception
                    connection.Close()
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Odaberite učenika!")
            End If
        Else
            MessageBox.Show("Ocjena je već dodana!")
        End If

    End Sub

    Private Sub populateStudentCombobox()
        Dim query As New SQLiteCommand(String.Format("SELECT u.user_id, u.user_first_name, u.user_last_name, u.user_jmbg FROM tbl_student_info 
                                            LEFT JOIN tbl_user u on u.user_id = tbl_student_info.student_id
                                            where tbl_student_info.year = '{0}' AND tbl_student_info.class = '{1}'", CBYear.SelectedValue, CBClass.SelectedValue), connection)
        Dim adapter As New SQLiteDataAdapter(query)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            StudentDataView.DataSource = table
            connection.Close()
        Catch ex As Exception
            connection.Close()
            connection.Dispose()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles StudentDataView.CellMouseClick
        On Error Resume Next
        lblUserID.Text = StudentDataView.Rows(e.RowIndex).Cells(0).Value
        lblUserID.Hide()
    End Sub


    Private Sub populateDefaultCB()
        CBYear.DataSource = {1, 2, 3, 4}
        CBClass.DataSource = {"a", "b", "c"}
        CBScore.DataSource = {1, 2, 3, 4, 5}
    End Sub

    Private Sub btnNazad_Click(sender As Object, e As EventArgs) Handles btnNazad.Click
        Me.Hide()
        Profil.Show()
    End Sub

    Private Sub Dnevnik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hideElements()
        populateDefaultCB()
        populateSubjectCombobox()
        StudentDataView.Columns("user_id").Visible = False
    End Sub

    Private Sub CBYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBYear.SelectedIndexChanged
        populateStudentCombobox()
    End Sub

    Private Sub CBClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBClass.SelectedIndexChanged
        populateStudentCombobox()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertScore()
    End Sub
End Class