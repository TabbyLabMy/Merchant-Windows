Imports System.Text.RegularExpressions

Public Class ForgotPassword

    Dim wsTabby As New wsTabby.Service1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtLoginID.Text = "" Then
            MsgBox("Please Fill In Password", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If IsValidEmail(txtLoginID.Text) = False Then
            MsgBox("Please Fill In Valid Email", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If wsTabby.MCForgotPassword(txtLoginID.Text) = True Then
            MsgBox("Successfully Retrieve Password." & vbCrLf & "Please Check Your Email Inbox.", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Error, Please Contact Customer Support", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Public Function IsValidEmail(email As String) As Boolean
        Dim emailRegex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        Dim match As Match = emailRegex.Match(email)
        Return match.Success
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class