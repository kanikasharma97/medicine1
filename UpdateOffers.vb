Public Class UpdateOffers
    Private Sub BtnUpdateOffer_Click(sender As Object, e As EventArgs) Handles BtnUpdateOffer.Click
        Dim OfferN As String = lblOfferName.Text
        Dim OfferData As New List(Of Object)

        'validator

        'validation
        Dim OfferNameErrorMessage = validateMandatoryField(TxtOfferName.Text, "OfferName")
        Dim valueErrorMessage = validateNumericField(NumericValue.Value, "Value")
        Dim MinAmountErrorMessage = validateNumericField(NumericMin.Value, "MinimumAmount")
        Dim MaxDiscountErrorMessage = validateNumericField(NumericMax.Value, "MaximumDiscount")


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


        OfferData.Add(TxtOfferName.Text)
        OfferData.Add(NumericValue.Value)
        OfferData.Add(NumericMin.Value)
        OfferData.Add(NumericMax.Value)
        OfferData.Add(DTExpiry.Value.ToString("yyyy-MM-dd"))
        updateTable("Offers", " OfferName", OfferN, OfferData)

        MsgBox("Offer updated successfully")
        UpdateMedicine.ActiveForm.Close()


    End Sub

    Private Sub BtnCancelUpdateOffer_Click(sender As Object, e As EventArgs) Handles BtnCancelUpdateOffer.Click
        UpdateOffers.ActiveForm.Close()
    End Sub
End Class