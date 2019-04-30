Imports System.Data.SQLite

Public Class Form2Admin
    Dim database As New Database
    Dim conn As String = database.connectionString
    Dim currentTable As String = String.Empty

    ' Clear all input fields
    Private Sub clearAllFields()
        txtIme.Clear()
        txtPrezime.Clear()
        txtRod.Clear()
        txtAdresa.Clear()
        txtDatumR.Clear()
        txtSearch.Clear()
    End Sub

    ' fill data adapter
    Private Sub daFill(ByVal query As String, ByVal tbl As DataTable)
        Dim connection As New SQLiteConnection(conn)
        Dim da As New SQLiteDataAdapter(query, connection)
        da.Fill(tbl)
        da.Dispose()
        da = Nothing
    End Sub

    ' import data and refresh
    Private Sub importAndRefresh(tableName As String)
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
            daFill(String.Format("SELECT * FROM {0}", tableName), dt)
            DataView.DataSource = Nothing
            DataView.DataSource = dt
            currentTable = tableName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dt.Dispose()
        dt = Nothing
        connection.Close()
        connection.Dispose()
        connection = Nothing

        clearAllFields()


    End Sub

    ' Sub for loading data from data grid view into textboxes
    Private Sub CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataView.CellMouseClick
        On Error Resume Next
        lblType.Text = DataView.Rows(e.RowIndex).Cells(1).Value
        lblType.Hide()
        txtIme.Text = DataView.Rows(e.RowIndex).Cells(2).Value
        txtPrezime.Text = DataView.Rows(e.RowIndex).Cells(3).Value
        txtRod.Text = DataView.Rows(e.RowIndex).Cells(4).Value
        lblJmbg.Text = DataView.Rows(e.RowIndex).Cells(5).Value
        lblJmbg.Hide()
        txtAdresa.Text = DataView.Rows(e.RowIndex).Cells(6).Value
        txtDatumR.Text = DataView.Rows(e.RowIndex).Cells(7).Value
        lblKorIme.Text = DataView.Rows(e.RowIndex).Cells(8).Value
        lblKorIme.Hide()
        lblPassword.Text = DataView.Rows(e.RowIndex).Cells(9).Value
        lblPassword.Hide()
    End Sub

    ' approve registration sub
    Private Sub approveRegistration()
        Dim sql As String = String.Format("INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_parent_name, user_jmbg, user_address, user_birthdate,
                                            user_username, user_password) VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}');",
                                            lblType.Text, txtIme.Text, txtPrezime.Text, txtRod.Text, lblJmbg.Text,
                                            txtAdresa.Text, txtDatumR.Text, lblKorIme.Text, lblPassword.Text)

        Dim execute As Boolean = executeNonQuery(sql)
        If execute = True Then
            MessageBox.Show("Odobrenje uspjelo!")
            delete("tbl_registration", "reg_jmbg")
            importAndRefresh(currentTable)
        Else
            MessageBox.Show("Prvo odaberite zahtjev kojeg želite pregledati a zatim odobrite registraciju ili obrišite zahtjev!")
        End If

    End Sub

    ' delete
    Private Function delete(table As String, jmbg As String)
        Dim value As Boolean = False
        Dim sql As String = String.Format("DELETE FROM {0} WHERE {1} = {2}", table, jmbg, lblJmbg.Text)

        Dim execute As Boolean = executeNonQuery(sql)
        If execute = True Then
            importAndRefresh(currentTable)
            value = True
        Else
            MessageBox.Show("Prvo odaberite osobu koju želite pregledati a zatim izvršite brisanje!")
        End If
        Return value
    End Function

    ' update
    Private Sub update()
        Dim sql As String = String.Format("UPDATE tbl_user SET user_first_name= '{0}', user_last_name= '{1}', user_parent_name= '{2}',
                            user_address= '{3}', user_birthdate= '{4}' WHERE user_jmbg= {5};",
                            txtIme.Text, txtPrezime.Text, txtRod.Text, txtAdresa.Text, txtDatumR.Text, lblJmbg.Text)

        Dim execute As Boolean = executeNonQuery(sql)
        If execute = True Then
            importAndRefresh(currentTable)
            MessageBox.Show("Ažuriranje uspjelo!")
        Else
            MessageBox.Show("Prvo odaberite osobu koju želite pregledati a zatim izvršite ažuriranje!")
        End If
    End Sub

    ' get info about which radiobutton is checked
    Private Function getRBinfo() As Integer
        Dim value As Integer = Nothing

        If RBIme.Checked() = False And RBPrezime.Checked() = False And RBJmbg.Checked() = False And RBKorIme.Checked() = False Then
            value = 0
        Else
            If RBIme.Checked() = True Then
                value = 1
            End If

            If RBPrezime.Checked() = True Then
                value = 2
            End If

            If RBJmbg.Checked() = True Then
                value = 3
            End If

            If RBKorIme.Checked() = True Then
                value = 4
            End If
        End If
        Return value
    End Function

    ' Functon for search Sub
    Private Sub FindInput(tableName As String, searchFilter As String, searchInput As String)
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
            daFill(String.Format("SELECT * FROM {0} WHERE {1}= '{2}'", tableName, searchFilter, searchInput), dt)
            DataView.DataSource = Nothing
            DataView.DataSource = dt
            currentTable = tableName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dt.Dispose()
        dt = Nothing
        connection.Close()
        connection.Dispose()
        connection = Nothing
    End Sub


    ' search
    Private Sub search()
        Dim value As Integer = getRBinfo()

        Select Case value
            Case 0
                MessageBox.Show("Odaberite tip filtriranja")
            Case 1
                If currentTable = "tbl_user" Then
                    FindInput("tbl_user", "user_first_name", txtSearch.Text)
                Else
                    FindInput("tbl_registration", "reg_first_name", txtSearch.Text)
                End If
            Case 2
                If currentTable = "tbl_user" Then
                    FindInput("tbl_user", "user_last_name", txtSearch.Text)
                Else
                    FindInput("tbl_registration", "reg_last_name", txtSearch.Text)
                End If
            Case 3
                If currentTable = "tbl_user" Then
                    FindInput("tbl_user", "user_jmbg", txtSearch.Text)
                Else
                    FindInput("tbl_registration", "reg_jmbg", txtSearch.Text)
                End If
            Case 4
                If currentTable = "tbl_user" Then
                    FindInput("tbl_user", "user_username", txtSearch.Text)
                Else
                    FindInput("tbl_registration", "reg_username", txtSearch.Text)
                End If
            Case Else
                MessageBox.Show("Unesite tekst u polje za pretraživanje!")
        End Select
    End Sub

    ' execute non query
    Public Function executeNonQuery(command As String) As Boolean
        Dim value As Boolean = False
        Using SqlConn As New SQLiteConnection(conn)
            Try
                SqlConn.Open()
                Dim cmd As New SQLiteCommand(command, SqlConn)
                cmd.ExecuteNonQuery()
                SqlConn.Close()
                value = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return value
        End Using

    End Function


    Private Sub Form2Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpdate.Show()
        btnAcceptReg.Hide()
        importAndRefresh("tbl_user")
    End Sub

    Private Sub ButtonOdjava_Click(sender As Object, e As EventArgs) Handles ButtonOdjava.Click
        Me.Hide()
        Form1Login.Show()
    End Sub

    Private Sub btnRegReq_Click(sender As Object, e As EventArgs) Handles btnRegReq.Click
        btnUpdate.Hide()
        btnAcceptReg.Show()
        importAndRefresh("tbl_registration")
    End Sub

    Private Sub BtnKorisnici_Click(sender As Object, e As EventArgs) Handles BtnKorisnici.Click
        btnAcceptReg.Hide()
        btnUpdate.Show()
        importAndRefresh("tbl_user")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        importAndRefresh(currentTable)
    End Sub

    Private Sub btnAcceptReg_Click(sender As Object, e As EventArgs) Handles btnAcceptReg.Click
        approveRegistration()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim delValue As Boolean = False
        If currentTable = "tbl_user" Then
            delValue = delete("tbl_user", "user_jmbg")
            If delValue = True Then
                MessageBox.Show("Brisanje uspjelo!")
            End If
        End If
        If currentTable = "tbl_registration" Then
            delValue = delete("tbl_registration", "reg_jmbg")
            If delValue = True Then
                MessageBox.Show("Brisanje uspjelo!")
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        update()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search()
    End Sub
End Class