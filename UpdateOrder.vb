Public Class UpdateOrder
    Dim offerInfo As DataTable
    Private Sub BtnUpdateOrder_Click(sender As Object, e As EventArgs) Handles BtnUpdateOrder.Click

        'VALIDATOR
        Dim ContactNoErrorMessage = validateContacField(TxtMaskedContactNo.Text)
        Dim FirstNameErrorMessage = validateMandatoryField(TxtFirstName.Text, "FirstName")
        Dim AddressErrorMessage = validateMandatoryField(TxtAddress.Text, "Address")
        Dim orderTypeErrorMessage As String = validateSelectionField(CmbOrderType.SelectedItem, "OrderType")
        Dim StatusErrorMessage As String = validateSelectionField(ListStatus.SelectedItem, "Status")


        If ContactNoErrorMessage.length <> 0 Then
            MsgBox(ContactNoErrorMessage)
            Return
        End If

        If FirstNameErrorMessage.length <> 0 Then
            MsgBox(FirstNameErrorMessage)
            Return
        End If

        If AddressErrorMessage.length <> 0 Then
            MsgBox(AddressErrorMessage)
            Return
        End If

        If orderTypeErrorMessage.Length <> 0 Then
            MsgBox(orderTypeErrorMessage)
            Return
        End If

        If StatusErrorMessage.Length <> 0 Then
            MsgBox(StatusErrorMessage)
            Return
        End If





        Dim OrderN As String = LblOrderId.Text
        Dim updateQuery As String = "update Orders set OrderDate='" + DTOrderDate.Value.ToString("yyyy-MM-dd") + "',OrderType='" + CmbOrderType.SelectedItem + "',ExpectedDeliveryTime='" + DTExpectedDeliveryDate.Value.ToString("yyyy-MM-dd") + "',Status='" + ListStatus.SelectedItem + "' where OrderId= '" + OrderN + "'"
        executeUpdateQuery(updateQuery)


        Dim CustomerN As String = TxtMaskedContactNo.Text
        updateQuery = "update Customer set FirstName='" + TxtFirstName.Text + "',LastName='" + TxtLastName.Text + "',Email='" + TxtEmail.Text + "',Address='" + TxtAddress.Text + "' where ContactNo= '" + TxtMaskedContactNo.Text + "'"
        executeUpdateQuery(updateQuery)
        MsgBox("Offer updated successfully")
        UpdateOrder.ActiveForm.Close()
    End Sub




End Class
