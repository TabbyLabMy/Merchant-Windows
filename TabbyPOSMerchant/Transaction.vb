Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export

Public Class Transaction

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboDateFrom.DateTime = Now.AddDays(-1)
        Me.cboDateTo.DateTime = Now
        RefreshGrid()
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

    End Sub


    Private Sub btnDateRange7Days_Click(sender As Object, e As EventArgs) Handles btnDateRange7Days.Click
        cboDateFrom.DateTime = Now.AddDays(-7)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()

    End Sub

    Private Sub btnDateRange30Days_Click(sender As Object, e As EventArgs) Handles btnDateRange30Days.Click
        cboDateFrom.DateTime = Now.AddDays(-30)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()

    End Sub

    Private Sub btnDateRange90Days_Click(sender As Object, e As EventArgs) Handles btnDateRange90Days.Click
        cboDateFrom.DateTime = Now.AddDays(-90)
        cboDateTo.DateTime = Now
        RefreshGridDateRange()

    End Sub

    Private Sub btnDateRangeReset_Click(sender As Object, e As EventArgs) Handles btnDateRangeReset.Click
        If cboDateFrom.DateTime = Nothing Then
            Exit Sub
        End If
        If cboDateTo.DateTime = Nothing Then
            Exit Sub
        End If

        RefreshGridDateRange()


    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim saveDialog As New SaveFileDialog
        saveDialog.Title = "Export To "
        saveDialog.Filter = "Microsoft Excel|*.xls|HTML Document|*.html|Text Files|*.txt|XML Document|*.xml"
        If saveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Select Case saveDialog.FilterIndex
                    Case 1
                        Call exportTo(New ExportXlsProvider(saveDialog.FileName), GridView1)
                    Case 2
                        Call exportTo(New ExportHtmlProvider(saveDialog.FileName), GridView1)
                    Case 3
                        Call exportTo(New ExportTxtProvider(saveDialog.FileName), GridView1)
                    Case 4
                        Call exportTo(New ExportXmlProvider(saveDialog.FileName), GridView1)
                End Select
                MsgBox("Successfully Export to " & saveDialog.FileName & ".", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Fail To Export : " & ex.Message, MsgBoxStyle.Information)
            End Try


        End If
    End Sub

    Private Sub exportTo(ByVal provider As DevExpress.XtraExport.IExportProvider, ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim link As BaseExportLink = grid.CreateExportLink(provider)
        CType(link, GridViewExportLink).ExpandAll = False
        link.ExportTo(True)

    End Sub

End Class