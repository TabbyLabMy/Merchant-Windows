Public Class ChangePassword 

    Dim wsTabby As New wsTabby.Service1
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtOldPassword.Text = "" Then
            MsgBox("Please Fill In Old Password", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtNewPassword.Text = "" Then
            MsgBox("Please Fill In New Password", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtNewPassword2.Text = "" Then
            MsgBox("Please Fill In New Password (Repeat)", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If txtNewPassword.Text <> txtNewPassword2.Text Then
            MsgBox("Please Make Sure Both Password Match", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dsResult As New DataSet
        Dim HashPassword As String = ComputeHmacSha256HashDefaultKey(txtOldPassword.Text)
        dsResult = wsTabby.LoginXML(moPublic.pvLoginID, HashPassword)

        If dsResult.Tables(0).Rows(0).Item("ReturnCode") = 1 Then
            If wsTabby.MCChangePassword(moPublic.MerchantID, txtNewPassword.Text) = True Then
                MsgBox("Password Change Successfully", MsgBoxStyle.Information)
                moPublic.ChangePasswordYesNo = True
                Me.Close()
            End If
        Else
            MsgBox("Wrong Old Password", MsgBoxStyle.Exclamation)
        End If


    End Sub
End Class