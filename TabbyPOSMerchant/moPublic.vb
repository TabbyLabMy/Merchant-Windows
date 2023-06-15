Imports System.Security.Cryptography

Module moPublic
    Public LoginYesNo As Boolean
    Public MerchantID As Integer
    Public ChangePasswordYesNo As Boolean
    Public pvLoginID As String

    Public Function ComputeHmacSha256HashDefaultKey(ByVal message As String) As String
        Dim encoding As New System.Text.UTF8Encoding
        Dim secretBytes As Byte() = encoding.GetBytes(My.Settings.DefaultKey)
        Dim messageBytes As Byte() = encoding.GetBytes(message)

        Dim hash As Byte()
        Using hmacsha256 As New HMACSHA256(secretBytes)
            hash = hmacsha256.ComputeHash(messageBytes)
        End Using

        Return BitConverter.ToString(hash).Replace("-", "").ToUpper()

    End Function
End Module
