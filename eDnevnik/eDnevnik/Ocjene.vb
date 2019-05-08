Public Class Ocjene
    Dim database As New Database
    Dim conn As String = database.connectionString
    Dim connection As New SQLite.SQLiteConnection(conn)

    Private Sub displayData(databaseTable As String, column As String, filter As String)
        Dim cmd As New SQLite.SQLiteCommand(String.Format("SELECT tbl_subject.subject_name, tbl_score.score, tbl_score.date
                                            FROM tbl_subject
                                            Left JOIN tbl_score on tbl_subject.subject_id = tbl_score.subject_id
                                            WHERE {0}.{1} = '{2}' COLLATE NOCASE;", databaseTable, column, filter), connection)

        Dim adapter As New SQLite.SQLiteDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            DataView.DataSource = Nothing
            DataView.DataSource = table

            For index As Integer = 1 To DataView.Columns.Count - 1

                DataView.Columns(index).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            connection.Close()
        Catch ex As Exception
            connection.Close()
            connection.Dispose()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNazad_Click(sender As Object, e As EventArgs) Handles btnNazad.Click
        Me.Hide()
        Profil.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        displayData("tbl_subject", "subject_name", txtFilter.Text)
    End Sub

    Private Sub Ocjene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayData("tbl_score", "user_id", Profil.m_user_id)
    End Sub
End Class