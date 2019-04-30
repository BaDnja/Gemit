Imports System.Net.Mail

Public Class Send_Email

    Private Sub setAlltxtDefault()
        TxtSubject.Text = Nothing
        txtMessage.Text = Nothing
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Try
            Dim smtp_server As New SmtpClient
            Dim email As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("gemit.main@gmail.com", "gmPw123!")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"


            If TxtSubject.Text <> "" And txtMessage.Text <> "" Then
                email.From = New MailAddress("gemit.main@gmail.com")
                email.To.Add("gms.supp1@gmail.com")
                email.Subject = TxtSubject.Text
                email.Body = txtMessage.Text
                smtp_server.Send(email)
                MessageBox.Show("Mail successfully sended!")
                setAlltxtDefault()
            Else
                MessageBox.Show("Ispravno ispunite polja!")
                setAlltxtDefault()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonNazad_Click(sender As Object, e As EventArgs) Handles ButtonNazad.Click
        setAlltxtDefault()
        Me.Hide()
        FormRegistracija.Show()
    End Sub
End Class