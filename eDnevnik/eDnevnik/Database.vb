Imports System.Data.SQLite

Public Class Database
    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim fileName As String = "eDnevnikDatabase.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data source = {0}", fullPath)

    Public Sub createPredefinedDatabase()
        If Not duplicateDatabase(fullPath) Then

            Dim createTableAdministrator As String = "CREATE TABLE `administrator` (
	                                                    `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                                    `username`	TEXT NOT NULL,
	                                                    `password`	TEXT NOT NULL
                                                        );"
            Dim createTableOcjena As String = "CREATE TABLE `ocjena` (
	                                            `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                            `jmbg_ucenik`	INTEGER NOT NULL,
	                                            `sifra_predmeta`	TEXT NOT NULL,
	                                            `datum_ocjene`	TEXT NOT NULL,
	                                            `dodjeljena_ocjena`	INTEGER NOT NULL
                                                );"

            Dim createTablePredmet As String = "CREATE TABLE `predmet` (
	                                            `sifra_predmeta`	TEXT NOT NULL,
	                                            `naziv`	TEXT NOT NULL,
	                                            `jmbg_profesor`	INTEGER NOT NULL
                                                );"

            Dim createTableProfesor As String = "CREATE TABLE `profesor` (
	                                            `jmbg`	INTEGER NOT NULL,
	                                            `ime`	TEXT NOT NULL,
	                                            `prezime`	TEXT NOT NULL,
	                                            `adresa`	TEXT NOT NULL,
	                                            `datum_rodjenja`	TEXT NOT NULL
                                                );"

            Dim createTableUcenik As String = "CREATE TABLE `ucenik` (
	                                            `jmbg`	INTEGER NOT NULL,
	                                            `ime`	TEXT NOT NULL,
	                                            `prezime`	TEXT NOT NULL,
	                                            `ime_roditelja`	TEXT NOT NULL,
	                                            `adresa`	TEXT NOT NULL,
	                                            `datum_rodjenja`	TEXT NOT NULL,
	                                            `godina`	INTEGER NOT NULL,
	                                            `odjeljenje`	INTEGER NOT NULL
                                                );"

            Using SqlConn As New SQLiteConnection(connectionString)
                SqlConn.Open()
                Dim cmdAdmin As New SQLiteCommand(createTableAdministrator, SqlConn)
                cmdAdmin.ExecuteNonQuery()

                Dim cmdOcjena As New SQLiteCommand(createTableOcjena, SqlConn)
                cmdOcjena.ExecuteNonQuery()

                Dim cmdPredmet As New SQLiteCommand(createTablePredmet, SqlConn)
                cmdPredmet.ExecuteNonQuery()

                Dim cmdProfesor As New SQLiteCommand(createTableProfesor, SqlConn)
                cmdProfesor.ExecuteNonQuery()

                Dim cmdUcenik As New SQLiteCommand(createTableUcenik, SqlConn)
                cmdUcenik.ExecuteNonQuery()

            End Using
        End If
    End Sub

    Public Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

End Class