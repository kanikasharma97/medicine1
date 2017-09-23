Public Class UpdateOffer
    Private Sub UpdateOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BtnUpdateOffer_Click(sender As Object, e As EventArgs) Handles BtnUpdateOffer.Click

        Dim OfferN As String = lblOfferName.Text
        Dim Offerdata As New List(Of Object)

        Offerdata.Add(OfferN)
        Offerdata.Add(TxtOfferName.Text)
        Offerdata.Add(NumericMin.Value)
        Offerdata.Add(NumericMax.Value)
        Offerdata.Add(DTExpiry.Value)
        delete("Offers", "OfferName", OfferN)
        updateTable("Offers", "OfferName", OfferN, Offerdata)
        MsgBox("Medcine updated successfully")
        UpdateMedicine.ActiveForm.Close()
    End Sub
End Class