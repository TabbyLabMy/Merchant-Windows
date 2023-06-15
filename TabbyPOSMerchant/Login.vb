Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Dim wsTabby As New wsTabby.Service1

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginYesNo = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dsResult As New DataSet
        Dim HashPassword As String = ComputeHmacSha256HashDefaultKey(txtLoginPassword.Text)
        dsResult = wsTabby.LoginXML(txtLoginID.Text, HashPassword)
        If dsResult.Tables(0).Rows(0).Item("ReturnCode") = 1 Then
            pvLoginID = txtLoginID.Text
            'get merchant info
            MerchantID = dsResult.Tables(1).Rows(0).Item("ID")

            LoginYesNo = True
            Me.Close()
        Else



            LoginYesNo = False
            MsgBox("Wrong ID or Password", MsgBoxStyle.Exclamation)
        End If

    End Sub

  

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtLoginID.Text = "lee@o3malaysia.com"
        txtLoginPassword.Text = "ooo123"
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        Dim frm As New ForgotPassword
        frm.ShowDialog()

    End Sub
End Class