Public Class Terminal 

    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        Dim wsTabby As New wsTabby.Service1
        Dim dt As New DataTable
        dt = wsTabby.MCGetTerminal(moPublic.MerchantID)
        Me.GridControl1.DataSource = dt

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class