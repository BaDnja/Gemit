Public Class Upit


    Private Function checkYear(str As String) As Boolean
        Dim value As Boolean = False

        If str <> String.Empty Then
            Try
                If str >= 1 And str <= 4 Then
                    value = True
                ElseIf str >= 5 Then
                    MessageBox.Show("1: Unesite godinu između 1 i 4")
                End If
            Catch ex As Exception
                MessageBox.Show("2: Unesite ispravnu godinu između 1 i 4")
            End Try
        Else
            MessageBox.Show("3: Unesite godinu između 1 i 4")
        End If
        Return value
    End Function

    Public Sub setYear()
        Profil.m_year = getYear()
    End Sub

    Public Function getYear() As String
        Return txtYear.Text
        'MessageBox.Show(txtYear.Text)
    End Function

    Private Function checkClass(str As String) As Boolean
        Dim value As Boolean = False

        If str <> String.Empty Then
            Try
                If str = "a" Or str = "b" Or str = "c" Then
                    value = True
                End If
            Catch ex As Exception
                MessageBox.Show("1: Unesite ispravno odjeljenje: a/b/c")
            End Try
        Else
            MessageBox.Show("2: Unesite ispravno odjeljenje: a/b/c")
        End If
        Return value
    End Function

    Public Function getClass() As String
        Return txtClass.Text
        'MessageBox.Show(txtClass.Text)
    End Function

    Public Sub setClass()
        Profil.m_class = getClass()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkYear(txtYear.Text) = True And checkClass(txtClass.Text) = True Then
            setYear()
            setClass()
            Me.Hide()
            Profil.Show()
        End If
    End Sub
End Class