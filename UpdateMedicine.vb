Public Class UpdateMedicine
    Private Sub UpdateMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnUpdateMedicine_Click(sender As Object, e As EventArgs) Handles BtnUpdateMedicine.Click

        Dim medicineId As String = MedId.Text
        Dim Meddata As New List(Of Object)

        'validator
        Dim MedNameErrorMessage = validateMandatoryField(TxtName.Text, "Name")
        Dim CompanyNameErrorMessage = validateMandatoryField(TxtCompany.Text, "Company")
        Dim MgErrorMessage = validateNumericField(NumericMg.Value, "MG")
        Dim QuantityErrorMessage = validateNumericField(NumericQuantity.Value, "Quantity")
        Dim PriceErrorMessage = validateNumericField(NumericUnitPrice.Value, "PricePerUnit")

        If MedNameErrorMessage.Length <> 0 Then
            MsgBox(MedNameErrorMessage)
            Return
        End If

        If CompanyNameErrorMessage.length <> 0 Then
            MsgBox(CompanyNameErrorMessage)
            Return
        End If

        If MgErrorMessage.Length <> 0 Then
            MsgBox(MgErrorMessage)
            Return
        End If

        If QuantityErrorMessage.length <> 0 Then
            MsgBox(QuantityErrorMessage)
            Return
        End If

        If PriceErrorMessage <> 0 Then
            MsgBox(PriceErrorMessage)
            Return
        End If


        Meddata.Add(medicineId)
        Meddata.Add(TxtName.Text)
        Meddata.Add(TxtCompany.Text)
        Meddata.Add(TxtDescription.Text)
        Meddata.Add(NumericMg.Value)
        Meddata.Add(NumericQuantity.Value)
        Meddata.Add(NumericUnitPrice.Value)
        Meddata.Add(DTManufacture.Value.ToString("yyyy-MM-dd"))
        Meddata.Add(DTExpiry.Value.ToString("yyyy-MM-dd"))
        delete("Med_Category", "MedId", medicineId)
        updateTable("Medicine", "MedId", medicineId, Meddata)

        For Each Val As Object In ListCategory.SelectedItems
            Dim MediCategoryList As New List(Of Object)
            MediCategoryList.Add(medicineId)
            MediCategoryList.Add(Val.ToString)

            write("Med_Category", MediCategoryList)
        Next

        MsgBox("Medcine updated successfully")
        UpdateMedicine.ActiveForm.Close()


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles MedId.Click

    End Sub
End Class