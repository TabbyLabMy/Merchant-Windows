Public Class MyProfile 

    Private Sub btnActive_Click(sender As Object, e As EventArgs) Handles btnActive.Click
        Dim wsTabby As New wsTabby.Service1
        'Str = "UPDATE Customer SET Name = @Name, ContactPerson = @ContactPerson, MobileNo = @MobileNo, "
        'Str = Str() & " AddressLine1 = @AddressLine1, AddressLine2 = @AddressLine2, City = @City, Postcode = @Postcode, "
        'Str = Str() & " State = @State, Country = @Country "
        Dim _Name As String
        Dim _ContactPerson As String
        Dim _MobileNo As String
        Dim _AddressLine1 As String
        Dim _AddressLine2 As String
        Dim _City As String
        Dim _Postcode As String
        Dim _State As String
        Dim _Country As String
        Dim _ERGAddressOwn As String
        Dim _EmailNotification As Integer

        _Name = txtBusinessName.Text
        _ContactPerson = txtPersonIncharge.Text
        _MobileNo = txtPersonInchargeContactNo.Text
        _AddressLine1 = txtAddressLine1.Text
        _AddressLine2 = txtAddressLine2.Text
        _City = txtCity.Text
        _Postcode = txtPostcode.Text
        _State = txtState.Text
        _Country = txtCountry.Text
        _ERGAddressOwn = txtERGWalletAddress.Text
        _EmailNotification = chkNotification.EditValue

        If wsTabby.MCUpdateMyProfile(moPublic.MerchantID, _Name, _ContactPerson, _MobileNo, _AddressLine1, _AddressLine2, _
                                     _City, _Postcode, _State, _Country, _ERGAddressOwn, _EmailNotification) = True Then
            MsgBox("Update Successfully", MsgBoxStyle.Information)
            'Me.Close()

        Else
            MsgBox("Fail to Update", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim wsTabby As New wsTabby.Service1
        Dim dt As New DataTable
        dt = wsTabby.MCGetMerchantInfo(moPublic.MerchantID)
        If dt.Rows.Count > 0 Then
            txtBusinessName.Text = dt.Rows(0).Item("Name").ToString
            txtAddressLine1.Text = dt.Rows(0).Item("AddressLine1").ToString
            txtAddressLine2.Text = dt.Rows(0).Item("AddressLine2").ToString
            txtCity.Text = dt.Rows(0).Item("City").ToString
            txtCountry.Text = dt.Rows(0).Item("Country").ToString
            txtPersonIncharge.Text = dt.Rows(0).Item("ContactPerson").ToString
            txtPersonInchargeContactNo.Text = dt.Rows(0).Item("MobileNo").ToString
            txtPostcode.Text = dt.Rows(0).Item("PostCode").ToString
            txtState.Text = dt.Rows(0).Item("State").ToString
            txtERGWalletAddress.Text = dt.Rows(0).Item("ERGAddressOwn").ToString
            chkNotification.EditValue = dt.Rows(0).Item("EmailNotification")

        End If
    End Sub
End Class