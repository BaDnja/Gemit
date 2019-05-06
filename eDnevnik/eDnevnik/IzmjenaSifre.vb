Public Class IzmjenaSifre

    Private Sub clearAllText()
        txt1.Clear()
        txt2.Clear()
    End Sub

    Private Function validation() As Boolean
        Dim value As Boolean = False

        If txt1.Text <> String.Empty And txt2.Text <> String.Empty Then
            If txt1.Text.Length >= 8 Then
                If txt2.Text = txt1.Text Then
                    value = True
                Else
                    MessageBox.Show("Šifre se ne podudaraju!")
                    clearAllText()
                End If
            Else
                MessageBox.Show("Šifra mora sadržavati minimalno osam znakova!")
                clearAllText()
            End If
        Else
            MessageBox.Show("Polja ne mogu biti prazna!")
        End If
        Return value
    End Function

    Private Sub updatePassword()
        Dim sql As String = String.Format("UPDATE tbl_user SET user_password='{0}'", Encryption.hashString(txt1.Text, Profil.txtJmbg.Text))

        If Form2Admin.executeNonQuery(sql) = True Then
            MsgBox("Ažuriranje šifre uspjelo!")
            clearAllText()
        End If
    End Sub

    Private Sub ButtonNazad_Click_1(sender As Object, e As EventArgs) Handles ButtonNazad.Click
        clearAllText()
        Me.Hide()
        Profil.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validation() = True Then
            updatePassword()
        End If
    End Sub

    Private Sub ButtonEye_MouseEnter(sender As Object, e As EventArgs) Handles ButtonEye.MouseEnter

        txt1.UseSystemPasswordChar = False
        txt2.UseSystemPasswordChar = False
    End Sub

    Private Sub ButtonEye_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEye.MouseLeave

        txt1.UseSystemPasswordChar = True
        txt2.UseSystemPasswordChar = True
    End Sub
End Class