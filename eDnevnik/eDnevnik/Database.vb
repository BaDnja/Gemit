Imports System.Data.SQLite

Public Class Database
    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim fileName As String = "eDnevnikDatabase.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data source = {0}", fullPath)

    Public Sub createPredefinedDatabase()
        If Not duplicateDatabase(fullPath) Then

            Dim createUserTypeTable As String = "CREATE TABLE tbl_user_type(
	                                                type_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                                type_name TEXT NOT NULL);"

            Dim createUserTable As String = "CREATE TABLE tbl_user(
	                                            user_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                            user_type INTEGER NOT NULL,
	                                            user_first_name TEXT NOT NULL,
	                                            user_last_name TEXT NOT NULL,
	                                            user_parent_name TEXT NULL,
	                                            user_jmbg TEXT NULL,
	                                            user_address TEXT NULL,
	                                            user_birthdate TEXT NULL,
	                                            user_username TEXT NOT NULL,
	                                            user_password TEXT NOT NULL,
                                            CONSTRAINT fk_user
                                                FOREIGN KEY (user_type)
                                                REFERENCES tbl_user_type(type_id));"

            Dim createStudentInfoTable As String = "CREATE TABLE tbl_student_info(
	                                                    student_info_id INTEGER PRIMARY KEY NOT NULL,
	                                                    student_id INTEGER NOT NULL,
	                                                    year INTEGER NOT NULL,
	                                                    class TEXT NOT NULL,
                                                    CONSTRAINT fk_user_info
                                                        FOREIGN KEY (student_id)
                                                        REFERENCES tbl_user(user_id));"

            Dim createSubjectTable As String = "CREATE TABLE tbl_subject(
	                                                subject_id INTEGER PRIMARY KEY NOT NULL,
	                                                user_id INTEGER NOT NULL,
	                                                subject_name TEXT NOT NULL,
                                                CONSTRAINT fk_subject
                                                    FOREIGN KEY (user_id)
                                                    REFERENCES tbl_user(user_id));"

            Dim createScoreTable As String = "CREATE TABLE tbl_score(
	                                                score_id INTEGER PRIMARY KEY NOT NULL,
	                                                user_id INTEGER NOT NULL,
	                                                subject_id INTEGER NOT NULL,
	                                                date TEXT NOT NULL,
	                                                score TEXT NOT NULL,
                                                CONSTRAINT fk_score_user
                                                    FOREIGN KEY (user_id)
                                                    REFERENCES tbl_user(user_id),
                                                CONSTRAINT fk_score_subject
                                                    FOREIGN KEY (subject_id)
                                                    REFERENCES tbl_subject(subject_id));"

            Dim insertIntoUserType As String = "INSERT INTO tbl_user_type (type_name) VALUES ('Administrator'), ('Professor'), ('Student');"

            Dim insertAdminIntoUser As String = "INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_username, user_password) VALUES (1, 'Amar', 'Badnjević', 'amar.badnjevic', 'password123');"

            Dim insertProfIntoUser As String = "INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_username, user_password) VALUES (2, 'Rešad', 'Hajdarpašić', 'resad.hajdarpasic', 'pass1!');"

            Dim insertStudIntoUser As String = "INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_username, user_password) VALUES (3, 'Ognjen', 'Vujasinovic', 'ognjen.vujasinovic', 'pw1!');"

            Using SqlConn As New SQLiteConnection(connectionString)
                SqlConn.Open()
                Dim cmdUserType As New SQLiteCommand(createUserTypeTable, SqlConn)
                cmdUserType.ExecuteNonQuery()

                Dim cmdUser As New SQLiteCommand(createUserTable, SqlConn)
                cmdUser.ExecuteNonQuery()

                Dim cmdStudentInfo As New SQLiteCommand(createStudentInfoTable, SqlConn)
                cmdStudentInfo.ExecuteNonQuery()

                Dim cmdSubject As New SQLiteCommand(createSubjectTable, SqlConn)
                cmdSubject.ExecuteNonQuery()

                Dim cmdScore As New SQLiteCommand(createScoreTable, SqlConn)
                cmdScore.ExecuteNonQuery()

                Dim cmdInsertUserType As New SQLiteCommand(insertIntoUserType, SqlConn)
                cmdInsertUserType.ExecuteNonQuery()

                Dim cmdInsertAdminUser As New SQLiteCommand(insertAdminIntoUser, SqlConn)
                cmdInsertAdminUser.ExecuteNonQuery()

                Dim cmdInsertProfUser As New SQLiteCommand(insertProfIntoUser, SqlConn)
                cmdInsertProfUser.ExecuteNonQuery()

                Dim cmdInserStudUser As New SQLiteCommand(insertStudIntoUser, SqlConn)
                cmdInserStudUser.ExecuteNonQuery()

                SqlConn.Close()
            End Using
        End If
    End Sub

    Public Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Function isUserValid() As Boolean
        Dim sql As String = "SELECT * FROM tbl_user WHERE user_type=@type AND user_username = @username AND user_password = @password"
        Dim isValid As Boolean = False
        Try
            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", Form1Login.TextBoxIme.Text)
                    cmd.Parameters.AddWithValue("@password", Form1Login.TextBoxSifra.Text)
                    If Form1Login.RadioButtonAdmin.Checked() Then
                        cmd.Parameters.AddWithValue("@type", 1)
                    End If

                    If Form1Login.RadioButtonProfesor.Checked() Then
                        cmd.Parameters.AddWithValue("@type", 2)
                    End If

                    If Form1Login.RadioButtonUcenik.Checked() Then
                        cmd.Parameters.AddWithValue("@type", 3)
                    End If
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            isValid = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return isValid

    End Function

End Class