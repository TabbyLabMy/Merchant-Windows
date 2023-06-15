Public Class Balance 

    Dim wsTabby As New wsTabby.Service1
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblERG.Text = wsTabby.MCGetBalance(moPublic.MerchantID)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


   
End Class