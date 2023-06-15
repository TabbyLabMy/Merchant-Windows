Public Class Main 

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frm As New Login
        frm.ShowDialog()
        If LoginYesNo = False Then
            End
        Else
            Dim frmDashboard As New Dashboardvb
            frmDashboard.MdiParent = Me
            frmDashboard.Show()
        End If



    End Sub

    Private Sub btnDashbaord_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDashbaord.ItemClick
        Dim frm As New Dashboardvb
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnTerminal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTerminal.ItemClick
        Dim frm As New Terminal
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnLogout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLogout.ItemClick
        Dim frm As New Login
        frm.ShowDialog()
        If LoginYesNo = False Then
            Me.Close()
        Else
            Dim frm2 As New Dashboardvb
            frm2.MdiParent = Me
            frm2.Show()
        End If

    End Sub

    Private Sub btnTransactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransactions.ItemClick
        Dim frm As New Transaction
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnMyProfile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMyProfile.ItemClick
        Dim frm As New MyProfile
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnBalance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBalance.ItemClick
        Dim frm As New Balance
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub btnChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangePassword.ItemClick
        Dim frm As New ChangePassword
        frm.ShowDialog()
        If ChangePasswordYesNo = True Then
            ChangePasswordYesNo = False
            btnLogout_ItemClick(sender, e)
        End If


    End Sub
End Class