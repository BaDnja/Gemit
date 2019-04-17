

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Database As New Database()
        Database.createPredefinedDatabase()
    End Sub
End Class
