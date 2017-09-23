Public Class AddMedicine

    Private Sub AddMedicine_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each Val As Object In readColumn("Category", "CategoryName")
            ListCategory.Items.Add(Val)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddMedicine.Click
        Dim Meddata As New List(Of Object)
        Dim Medid As String
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 1000000000)
        Medid = number.ToString("000000000")

        Dim ds As DataSet
        Dim validateQuery As String
        validateQuery = "select * from medicine where Name='" + TxtName.Text + "' and Company = '" + TxtCompany.Text + "' and MG=" + NumericMg.Value.ToString

        ds = read(validateQuery)
        If (ds.Tables(0).Rows.Count = 1) Then
            MsgBox("Medicine alreday present")
        Else

            'validation
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

            Meddata.Add(Medid)
            Meddata.Add(TxtName.Text)
            Meddata.Add(TxtCompany.Text)
            Meddata.Add(TxtDescription.Text)
            Meddata.Add(NumericMg.Value)
            Meddata.Add(NumericQuantity.Value)
            Meddata.Add(NumericUnitPrice.Value)
            Meddata.Add(DTManufacture.Value.ToString("yyyy-MM-dd"))
            Meddata.Add(DTExpiry.Value.ToString("yyyy-MM-dd"))
                If (write("Medicine", Meddata) = 1) Then
                    For Each Val As Object In ListCategory.SelectedItems
                        Dim MediCategoryList As New List(Of Object)
                        MediCategoryList.Add(Medid)
                        MediCategoryList.Add(Val.ToString)

                        write("Med_Category", MediCategoryList)
                    Next
                    MsgBox("Medicine added")
                    AddMedicine.ActiveForm.Close()

                Else
                    MsgBox("Something went wrong")
                End If
            End If
    End Sub



    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancelMedicine.Click
        AddMedicine.ActiveForm.Close()
    End Sub

    Private Sub ListCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCategory.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class