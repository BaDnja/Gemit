Public Class Form2Admin
    Private Sub Form2Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonNazad_Click(sender As Object, e As EventArgs) Handles ButtonNazad.Click
        Me.Hide()
        Form1Login.Show()
    End Sub

    Private Sub ButtonAddProf_Click(sender As Object, e As EventArgs) Handles ButtonAddProf.Click
        Me.Hide()
        SpremanjeProfesora.Show()
    End Sub

    Private Sub ButtonModProf_Click(sender As Object, e As EventArgs) Handles ButtonModProf.Click
        Me.Hide()
        IzmjenaProfesora.Show()
    End Sub

    Private Sub ButtonDelProf_Click(sender As Object, e As EventArgs) Handles ButtonDelProf.Click
        Me.Hide()
        BrisanjeProfesora.Show()
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        Me.Hide()
        SpremanjeUcenika.Show()
    End Sub

    Private Sub ButtonModStudent_Click(sender As Object, e As EventArgs) Handles ButtonModStudent.Click
        Me.Hide()
        IzmjenaUcenika.Show()
    End Sub

    Private Sub ButtonDelStudent_Click(sender As Object, e As EventArgs) Handles ButtonDelStudent.Click
        Me.Hide()
        BrisanjeUcenika.Show()
    End Sub

    Private Sub ButtonAddAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAddAdmin.Click
        Me.Hide()
        SpremanjeAdmina.Show()
    End Sub

    Private Sub ButtonModAdmin_Click(sender As Object, e As EventArgs) Handles ButtonModAdmin.Click
        Me.Hide()
        IzmjenaAdmina.Show()
    End Sub

    Private Sub ButtonDelAdmin_Click(sender As Object, e As EventArgs) Handles ButtonDelAdmin.Click
        Me.Hide()
        BrisanjeAdmina.Show()
    End Sub

    Private Sub ButtonInboxProf_Click(sender As Object, e As EventArgs) Handles ButtonInboxProf.Click
        Me.Hide()
        InboxProfesori.Show()
    End Sub

    Private Sub ButtonInboxStud_Click(sender As Object, e As EventArgs) Handles ButtonInboxStud.Click
        Me.Hide()
        InboxUcenici.Show()
    End Sub

    Private Sub ButtonInboxAdmin_Click(sender As Object, e As EventArgs) Handles ButtonInboxAdmin.Click
        Me.Hide()
        InboxAdmini.Show()
    End Sub
End Class