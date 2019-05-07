Imports System.Data.SQLite

Public Class Database
    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim fileName As String = "eDnevnikDatabase.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data source = {0}", fullPath)

    Dim createUserTypeTable As String = "CREATE TABLE tbl_user_type(
	                                                type_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                                type_name TEXT NOT NULL);"

    Dim createUserTable As String = "CREATE TABLE tbl_user(
	                                            user_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                            user_type INTEGER NOT NULL,
	                                            user_first_name TEXT NOT NULL,
	                                            user_last_name TEXT NOT NULL,
	                                            user_parent_name TEXT NULL,
	                                            user_jmbg TEXT NULL UNIQUE NOT NULL,
	                                            user_address TEXT NULL,
	                                            user_birthdate TEXT NULL,
	                                            user_username TEXT NOT NULL UNIQUE,
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
	                                                user_id INTEGER,
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

    Dim createRegTable As String = "CREATE TABLE tbl_registration(
                                            reg_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                            reg_type_id INTEGER NOT NULL,
                                            reg_first_name TEXT NOT NULL,
                                            reg_last_name TEXT NOT NULL,
                                            reg_parent_name TEXT NULL,
                                            reg_jmbg TEXT NULL UNIQUE NOT NULL,
                                            reg_address TEXT NULL,
                                            reg_birthdate TEXT NULL,
                                            reg_username TEXT NOT NULL UNIQUE,
                                            reg_password TEXT NOT NULL);"


    Dim subjectList As String() = {"Ekonomija", "ET - Prakticna nastava", "Fizicko vaspitanje", "Geografija", "Informatika", "Istorija", "Knjigovodstvo",
                "Marketing", "Matematika", "PPT - Latinski jezik", "PPT - Prakticna nastava", "PPT - Pravo", "Srpski jezik", "ET - Geografija",
                "ET - Monetarna ekonomija i bankarstvo", "ET - Poslovna komunikacija", "Poslovna informatika", "PPT - Istorija",
                "PPT - Marketing", "Demokratija i ljudska prava", "ET - Matematika", "ET - Pravo", "ET - Sociologija i filozofija",
                "Monetarna ekonomija i bankarstvo", "PPT - Poslovna komunikacija", "PPT - Privredna matematika", "ET - Ekonomija", "ET - Privredna matematika",
                "PPT - Monetarna ekonomija i bankarstvo", "PPT - Sociologija i filozofija", "Statistika", "Biologija", "Fizika", "Hemija", "Latinski jezik", "Likovna kultura",
                "Muzicka kultura", "Racunarstvo i informatika", "Srpski jezik i knjizevnost", "INF - Operativni sistemi i racunarske mreze", "INF - Programiranje", "OPSTI - Likovna kultura",
                "OPSTI - Muzicka kultura", "OPSTI - Racunarstvo i informatika", "Psihologija", "INF - Modeli i baze podataka", "INF - Primjena racunara", "INF - Racunarski sistemi",
                "INF - Sociologija", "OPSTI - Filozofija", "OPSTI - Geografija", "OPSTI - Istorija", "Filozofija", "INF - Komunikologija", "INF - Multimedijalni dizajn",
                "OPSTI - Biologija", "OPSTI - Hemija", "OPSTI - Sociologija", "FAR - Zdravstvena zastita sa prvom pomoci", "FIZ - Zdravstvena njega i rehabilitacija",
                "MT - Zdravstvena njega", "Strani jezik", "ZST - FAR - Anatomija i fiziologija", "ZST - Morfologija zuba", "FAR - Analiticka hemija", "FAR - Botanika",
                "FAR - Farmaceutska tehnologija", "FAR - Farmakognozija", "FAR - Matematika", "FIZ - Osnove masaze", "Mikrobiologija", "MT - FIZ - Fiziologija",
                "MT - FIZ - Medicinska psihologija", "MT - FIZ Patologija", "ZST - Fiksna protetika", "ZST - MT - FIZ - Higijena sa zdravstvenim vaspitanjem",
                "ZST - Tehnologija zubotehnickog materijala", "ZST - Zdravstvena njega", "FAR - Farmaceutska hemija", "FAR - Higijena sa zdravstvenim vaspitanjem",
                "FAR - MT - FIZ - Medicinska biohemija", "FIZ - Fizikalna terapija", "FIZ - Kineziologija", "FIZ - Osnove klinicke medicine", "MT - FIZ - Farmakologija",
                "MT - Hirurgija", "MT - Infektologija", "MT - Interna medicina", "MT - Zdravstvena njega sa porodicnom medicinom", "ZST - Bolesti zuba",
                "ZST - Parodontologija i oralna medicina", "ZST - Totalna proteza", "FAR - Farmakologija", "FAR - Sanitarna hemija", "FAR - Uvod u kozmetologiju",
                "FIZ - Kineziterapija", "FIZ - Specijalna rehabilitacija", "MT - Ginekologija i akuserstvo", "MT - Neuropsihijatrija", "MT - Pedijatrija", "Sociologija i etika",
                "ZST - Djecija i preventivna stomatologija", "ZST - Oralna hirurgija", "ZST - Ortopedija vilica", "ZST - Parcijalna proteza"}

    Dim insertIntoUserType As String = "INSERT INTO tbl_user_type (type_name) VALUES ('Administrator'), ('Professor'), ('Student');"

    Dim insertAdminIntoUser As String = String.Format("INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_jmbg, user_username, user_password) VALUES (1, 'Amar', 'Badnjević', '0909998163305', 'amar.badnjevic', '{0}');", Encryption.hashString("password123", "0909998163305"))

    Dim insertProfIntoUser As String = String.Format("INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_jmbg, user_username, user_password) VALUES (2, 'Rešad', 'Hajdarpašić', '0607989245678', 'resad.hajdarpasic', '{0}');", Encryption.hashString("password123", "0607989245678"))

    Dim insertStudIntoUser As String = String.Format("INSERT INTO tbl_user (user_type, user_first_name, user_last_name, user_jmbg, user_username, user_password) VALUES (3, 'Ognjen', 'Vujasinovic', '1234567891012', 'ognjen.vujasinovic', '{0}');", Encryption.hashString("password123", "1234567891012"))

    Public Sub createPredefinedDatabase()
        If Not duplicateDatabase(fullPath) Then



            execute(createUserTypeTable)
            execute(createUserTable)
            execute(createStudentInfoTable)
            execute(createSubjectTable)
            execute(createScoreTable)
            execute(createRegTable)
            execute(insertIntoUserType)
            execute(insertAdminIntoUser)
            execute(insertProfIntoUser)
            execute(insertStudIntoUser)
            insertSubject()


        End If
    End Sub

    Private Sub insertSubject()
        Dim value As String
        For Each item As String In subjectList
            value = item
            Dim insertIntoSubject As String = String.Format("INSERT INTO tbl_subject (subject_name) VALUES ('{0}')", value)
            execute(insertIntoSubject)
        Next
    End Sub

    ' Sub for creating tables and inserting data into tables
    Public Sub execute(command As String)
        Using SqlConn As New SQLiteConnection(connectionString)
            SqlConn.Open()
            Dim cmd As New SQLiteCommand(command, SqlConn)
            cmd.ExecuteNonQuery()
            SqlConn.Close()
        End Using
    End Sub

    Public Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Function isUserValid(table As String) As Boolean
        Dim sql As String = String.Format("SELECT * FROM '{0}' WHERE user_type=@type AND user_username = @username AND user_password = @password AND user_jmbg='{1}'", table, Form1Login.TextBoxJmbg.Text)
        Dim isValid As Boolean = False
        Try
            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", Form1Login.TextBoxIme.Text)
                    cmd.Parameters.AddWithValue("@password", Encryption.hashString(Form1Login.TextBoxSifra.Text, Form1Login.TextBoxJmbg.Text))
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