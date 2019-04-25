Public Class Encryption
    Private cryptoServiceProvider As System.Security.Cryptography.RNGCryptoServiceProvider

    Public Shared Function hashString(str1 As String, str2 As String) As String
        Dim str = str1 + str2
        Return encryptString(str)
    End Function

    Public Shared Function generateSalt() As String
        Using cryptoServiceProvider As New System.Security.Cryptography.RNGCryptoServiceProvider
            Dim stringBuilder As New System.Text.StringBuilder()
            Dim data As Byte() = New Byte(4) {}

            For i = 0 To 6
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                stringBuilder.Append(value)
            Next
            Return encryptString(stringBuilder.ToString())
        End Using
    End Function

    Private Shared Function encryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)

        Return Convert.ToBase64String(hashed)
    End Function
End Class
