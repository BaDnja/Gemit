Imports System.Data.SQLite

Public Class Profil
    Dim database As New Database
    Dim upit As New Upit
    Dim conn As String = database.connectionString
    Public m_user_id As String
    Public m_year As String
    Public m_class As String

    Private Sub setReadOnlyText(state As Boolean)
        txtIme.ReadOnly = state
        txtPrezime.ReadOnly = state
        txtRod.ReadOnly = state
        txtAdresa.ReadOnly = state
        txtDatumR.ReadOnly = state
        txtYear.ReadOnly = state
        txtClass.ReadOnly = state
    End Sub

    Private Sub clearAllText()
        txtIme.Clear()
        txtPrezime.Clear()
        txtRod.Clear()
        txtAdresa.Clear()
        txtDatumR.Clear()
    End Sub

    Public Function checkUserInfo(table As String, id As String) As Boolean
        ' Function that will check if professor choosed subject
        ' In other case, it checks if student info exists
        ' Depends on arguments provided.
        Dim value As Boolean = False
        Dim conn As New SQLiteConnection(database.connectionString)
        Dim query As String = String.Format("SELECT * FROM {0} WHERE {1}='{2}';", table, id, m_user_id)
        Dim da As New SQLiteDataAdapter(query, conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                value = True
            End If
        Catch ex As Exception
            conn.Dispose()
            MsgBox("1: " + ex.Message)
            Exit Function
        End Try
        Return value
    End Function

    Private Sub insertStudentInfo()
        If checkUserInfo("tbl_student_info", "student_id") = False Then
            Try
                Dim sql As String = String.Format("INSERT INTO tbl_student_info (student_id, year, class) VALUES ({0}, {1}, '{2}')", m_user_id, m_year, m_class)
                executeNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MessageBox.Show("insert student info error")
            End Try
        End If
    End Sub

    Private Function getTypeinfo() As Integer
        Dim value As Integer = Nothing

        If Form1Login.RadioButtonAdmin.Checked() = False And Form1Login.RadioButtonProfesor.Checked() = False And Form1Login.RadioButtonUcenik.Checked() = False Then
            value = 0
        Else
            If Form1Login.RadioButtonAdmin.Checked() = True Then
                value = 1
                PictureBox1.Image = My.Resources.admin_128x128
            ElseIf Form1Login.RadioButtonProfesor.Checked() = True Then
                value = 2
                PictureBox1.Image = My.Resources.teacher_128x128
            ElseIf Form1Login.RadioButtonUcenik.Checked() = True Then
                value = 3
                PictureBox1.Image = My.Resources.student_128x128
                insertStudentInfo()
            End If
        End If
        Return value
    End Function

    Private Sub setBtnOpenProperties()
        If getTypeinfo() = 1 Then
            btnOpen.Text = "Otvori administratorski panel"
        ElseIf getTypeinfo() = 2 Then
            btnOpen.Text = "Otvori dnevnik"
        ElseIf getTypeinfo() = 3 Then
            btnOpen.Text = "Otvori pregled ocjena"
        End If
    End Sub

    Private Sub displayProfileInfo()
        setBtnOpenProperties()

        Dim conn As New SQLiteConnection(database.connectionString)
        Dim query As String = String.Format("SELECT * FROM tbl_user WHERE user_jmbg='{0}'", Form1Login.TextBoxJmbg.Text)
        Dim da As New SQLiteDataAdapter(query, conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
            'lblId.DataBindings.Add("Text", dt, "user_id")
            'lblId.Hide()
            txtIme.DataBindings.Add("Text", dt, "user_first_name")
            txtPrezime.DataBindings.Add("Text", dt, "user_last_name")
            txtRod.DataBindings.Add("Text", dt, "user_parent_name")
            txtAdresa.DataBindings.Add("Text", dt, "user_address")
            txtDatumR.DataBindings.Add("Text", dt, "user_birthdate")
            txtJmbg.DataBindings.Add("Text", dt, "user_jmbg")
            txtKorIme.DataBindings.Add("Text", dt, "user_username")
        Catch ex As Exception
            conn.Dispose()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If getTypeinfo() = 3 Then
            GroupBoxStud.Show()
            insertStudentInfo()
            Dim query1 As String = String.Format("SELECT * FROM tbl_student_info WHERE student_id={0}", m_user_id)
            Dim da1 As New SQLiteDataAdapter(query1, conn)
            Dim dt1 As New DataTable

            Try
                da1.Fill(dt1)
                txtYear.DataBindings.Add("Text", dt1, "year")
                txtClass.DataBindings.Add("Text", dt1, "class")
            Catch ex As Exception
                conn.Dispose()
                MsgBox(ex.Message)
            End Try

            da1.Dispose()
            da1 = Nothing
            dt1.Dispose()
            dt1 = Nothing
        End If


        da.Dispose()
        da = Nothing
        dt.Dispose()
        dt = Nothing
        conn.Close()
    End Sub

    ' execute non query
    Public Function executeNonQuery(command As String) As Boolean
        Using SqlConn As New SQLiteConnection(conn)
            Try
                SqlConn.Open()
                Dim cmd As New SQLiteCommand(command, SqlConn)
                cmd.ExecuteNonQuery()
                SqlConn.Close()
                Return True
            Catch ex As Exception
                MessageBox.Show("execute non sql error: " + ex.Message)
            End Try
            Return False
        End Using

    End Function

    Private Sub updateFields()
        Dim sql As String = String.Format("UPDATE tbl_user SET user_first_name= '{0}', user_last_name= '{1}', user_parent_name= '{2}',
                            user_address= '{3}', user_birthdate= '{4}' WHERE user_jmbg= '{5}';",
                            txtIme.Text, txtPrezime.Text, txtRod.Text, txtAdresa.Text, txtDatumR.Text, txtJmbg.Text)

        Dim sql2 As String = String.Format("UPDATE tbl_student_info SET year='{0}', class='{1}' WHERE student_id='{2}'",
                                            txtYear.Text, txtClass.Text, m_user_id)

        Dim execute As Boolean = executeNonQuery(sql)
        Dim execute2 As Boolean = executeNonQuery(sql2)
        If execute = True And execute2 = True Then
            MessageBox.Show("Spremanje podataka uspjelo!")
        Else
            MessageBox.Show("Spremanje podataka nije uspjelo...")
        End If
    End Sub

    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSaveChanges.Hide()
        GroupBoxStud.Hide()
        setReadOnlyText(True)
        displayProfileInfo()
    End Sub

    Private Sub ButtonOdjava_Click(sender As Object, e As EventArgs) Handles ButtonOdjava.Click
        Me.Hide()
        Form1Login.setAllTxtDefault()
        clearAllText()
        Form1Login.Show()
    End Sub

    Private Sub btnEnableChanges_Click(sender As Object, e As EventArgs) Handles btnEnableChanges.Click
        btnSaveChanges.Show()
        If btnEnableChanges.Text = "Omogući izmjene" Then
            setReadOnlyText(False)
            btnEnableChanges.Text = "Onemogući izmjene"
        ElseIf btnEnableChanges.Text = "Onemogući izmjene" Then
            setReadOnlyText(True)
            btnEnableChanges.Text = "Omogući izmjene"
        End If

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        updateFields()
        btnEnableChanges.Text = "Omogući izmjene"
        setReadOnlyText(True)
        btnSaveChanges.Hide()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If getTypeinfo() = 1 Then
            Me.Hide()
            Form2Admin.Show()
        ElseIf getTypeinfo() = 2 Then
            Me.Hide()
            Dnevnik.Show()
        ElseIf getTypeinfo() = 3 Then
            Ocjene.Show()
        End If
    End Sub

    Private Sub btnChangePw_Click(sender As Object, e As EventArgs) Handles btnChangePw.Click
        Me.Hide()
        IzmjenaSifre.Show()
    End Sub
End Class