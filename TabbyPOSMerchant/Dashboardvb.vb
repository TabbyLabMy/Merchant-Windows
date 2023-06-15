Public Class Dashboardvb

    Private Sub Dashboardvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboDateFrom.DateTime = Now.AddDays(-1)
        Me.cboDateTo.DateTime = Now
        RefreshGrid()
        RefreshTodayReport()
    End Sub

    Private Sub RefreshTodayReport()
        Dim wstabby As New wsTabby.Service1
        Dim dt As New DataTable
        dt = wstabby.MCGetTodayReport(MerchantID)
        lblTotalTransaction.Text = dt.Rows(0).Item("TotalTx") & " / " & dt.Rows(0).Item("TotalAmount") & " ERG"
        lblCompletedTransaction.Text = dt.Rows(0).Item("TotalTxCompleted") & " / " & dt.Rows(0).Item("TotalAmountCompleted") & " ERG"
        lblActiveUser.Text = dt.Rows(0).Item("TotalActiveUser")

    End Sub

    Private Sub RefreshGrid()
        Dim wstabby As New wsTabby.Service1
        Dim dt As New DataTable
        dt = wstabby.MCGetTxRecently(MerchantID)
        Me.GridControl1.DataSource = dt

    End Sub


    Private Sub RefreshGridDateRange()
        Dim wstabby As New wsTabby.Service1
        Dim dt As New DataTable
        dt = wstabby.MCGetTx(MerchantID, cboDateFrom.DateTime, cboDateTo.DateTime)
        Me.GridControl1.DataSource = dt

    End Sub

   
    Private Sub btnDateRange24Hour_Click(sender As Object, e As EventArgs) Handles btnDateRange24Hour.Click
        cboDateFrom.DateTime = Now.AddDays(-1)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()
        RefreshTodayReport()
    End Sub


    Private Sub btnDateRange7Days_Click(sender As Object, e As EventArgs) Handles btnDateRange7Days.Click
        cboDateFrom.DateTime = Now.AddDays(-7)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()
        RefreshTodayReport()
    End Sub

    Private Sub btnDateRange30Days_Click(sender As Object, e As EventArgs) Handles btnDateRange30Days.Click
        cboDateFrom.DateTime = Now.AddDays(-30)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()
        RefreshTodayReport()
    End Sub

    Private Sub btnDateRange90Days_Click(sender As Object, e As EventArgs) Handles btnDateRange90Days.Click
        cboDateFrom.DateTime = Now.AddDays(-90)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()
        RefreshTodayReport()
    End Sub

    Private Sub btnDateRangeReset_Click(sender As Object, e As EventArgs) Handles btnDateRangeReset.Click
        If cboDateFrom.DateTime = Nothing Then
            Exit Sub
        End If
        If cboDateTo.DateTime = Nothing Then
            Exit Sub
        End If

        RefreshGridDateRange()
        RefreshTodayReport()

    End Sub
End Class