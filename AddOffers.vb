Public Class AddOffers


    Private Sub BtnAddOffer_Click(sender As Object, e As EventArgs) Handles BtnAddOffer.Click
        Dim OfferData As New List(Of Object)
        Dim ds As DataSet
        Dim validatequery As String
        validatequery = "select * from Offers where OfferName='" + TxtOfferN.Text + "'"
        ds = read(validatequery)

        If (ds.Tables(0).Rows.Count = 1) Then
            MsgBox("Offer alreday present")
        Else

            'validation
            Dim OfferNameErrorMessage = validateMandatoryField(TxtOfferN.Text, "OfferName")
            Dim valueErrorMessage = validateNumericField(NumericValuee.Value, "Value")
            Dim MinAmountErrorMessage = validateNumericField(NumericMinAmount.Value, "MinimumAmount")
            Dim MaxDiscountErrorMessage = validateNumericField(NumericMaxDiscount.Value, "MaximumDiscount")


            If OfferNameErrorMessage.Length <> 0 Then
                MsgBox(OfferNameErrorMessage)
                Return
            End If

            If MinAmountErrorMessage.length <> 0 Then
                MsgBox(MinAmountErrorMessage)
                Return
            End If

            If valueErrorMessage <> 0 Then
                MsgBox(valueErrorMessage)
                Return
            End If

            If MaxDiscountErrorMessage <> 0 Then
                MsgBox(MaxDiscountErrorMessage)
                Return
            End If


            OfferData.Add(TxtOfferN.Text)
            OfferData.Add(NumericValuee.Value)
            OfferData.Add(NumericMinAmount.Value)
            OfferData.Add(NumericMaxDiscount.Value)
            OfferData.Add(DTExpiryDate.Value.ToString("yyyy-MM-dd"))

            If (write("offers", OfferData) = 1) Then
                MsgBox("Offer added.")
                AddOffers.ActiveForm.Close()
            Else
                MsgBox("Something went wrong")
                End If
            End If
    End Sub

    Private Sub BtnCancelMed_Click(sender As Object, e As EventArgs) Handles BtnCancelMed.Click
        AddOffers.ActiveForm.Close()
    End Sub
End Class