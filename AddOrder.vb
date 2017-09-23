Public Class Addorder
    Dim offerInfo As DataTable
    Private Sub Addorder_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim offerQuery As String = "select * from offers where ExpiryDate >= CONVERT(date,  GETDATE())"

        offerInfo = read(offerQuery).Tables(0)


        Dim ItemList As New List(Of Item)
        Dim search As String = CmbItems.Text
        Dim query As String = "Select MedId, Name , Company, MG, PricePerUnit from Medicine where Quantity > 0"

        For Each Row As DataRow In read(query).Tables(0).Rows
            ItemList.Add(New Item With {.MedId = Row("MedId"), .DisplayValue = Row("Name") + " ( " + Row("Company") + " ) ( " + Row("MG").ToString() + " mg )", .Price = Row("PricePerUnit")})
        Next

        CmbItems.DataSource = ItemList
        CmbItems.DisplayMember = "DisplayValue"
        CmbItems.ValueMember = "MedId"
    End Sub



    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        Dim selectedItem As String = CType(CmbItems.SelectedItem, Item).DisplayValue
        Dim selectedId As String = CType(CmbItems.SelectedItem, Item).MedId
        Dim selectedItemPrice As Double = CType(CmbItems.SelectedItem, Item).Price
        Dim quantity As Integer = NumericQuantity.Value
        CmbOfferName.Items.Clear()
        DataGridViewItems.ColumnCount = 4

        DataGridViewItems.Columns(0).Name = "Medicine Id"
        DataGridViewItems.Columns(1).Name = "Medicine"
        DataGridViewItems.Columns(2).Name = "Quanity"
        DataGridViewItems.Columns(3).Name = "Price Per Unit"


        DataGridViewItems.Rows.Add(selectedId, selectedItem, quantity, selectedItemPrice)
        Dim orderTotal As Decimal = CalculateTotalOrderPrice()
        TxtTotalAmount.Text = orderTotal


        For Each Row As DataRow In offerInfo.Rows
            If isOfferApplicable(orderTotal, Row("MinimumAmount")) Then
                CmbOfferName.Items.Add(Row("OfferName"))
            End If
        Next

    End Sub

    Private Function CalculateTotalOrderPrice()
        Dim totalPrice As Decimal

        For Each Row As DataGridViewRow In DataGridViewItems.Rows
            totalPrice += Row.Cells(2).Value * Row.Cells(3).Value
        Next
        Return totalPrice
    End Function


    Private Sub CmbOfferName_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbOfferName.SelectedValueChanged
        Dim appliedOfferName As String = CmbOfferName.Text
        Dim totalPrice As Decimal = CalculateTotalOrderPrice()

        For Each Row In offerInfo.Rows
            If appliedOfferName = Row("OfferName") Then
                Apply_offer(totalPrice, Row("Value"), Row("MaximumDiscount"))
            End If
        Next

    End Sub

    Private Function isOfferApplicable(orderTotal As Decimal, minimumAmount As Int32)
        Return orderTotal >= minimumAmount
    End Function

    Private Sub Apply_offer(totalPrice As Decimal, value As Int32, maximumDiscount As Int32)
        Dim Discount As Decimal = (totalPrice * value) / 100

        If (Discount > maximumDiscount) Then
            Discount = maximumDiscount
        End If
        TxtTotalAmount.Text = totalPrice - Discount
    End Sub



    Private Sub BtnAddOrder_Click(sender As Object, e As EventArgs) Handles BtnAddOrder.Click

        'Validator
        Dim ContactNoErrorMessage = validateContacField(TxtMaskedContactNo.Text)
        Dim FirstNameErrorMessage = validateMandatoryField(TxtFirstName.Text, "FirstName")
        Dim AddressErrorMessage = validateMandatoryField(TxtAddress.Text, "Address")
        Dim orderTypeErrorMessage As String = validateSelectionField(CmbOrderType.SelectedItem, "OrderType")
        Dim StatusErrorMessage As String = validateSelectionField(ListBoxStatus.SelectedItem, "Status")


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

        Dim CustomerData As New List(Of Object)
        Dim OrderData As New List(Of Object)
        Dim ds As New DataSet
        Dim ContactN As String = TxtMaskedContactNo.Text
        Dim validatequery As String = "Select * from Customer where ContactNo= '" + TxtMaskedContactNo.Text + "'"
        ds = read(validatequery)

        CustomerData.Add(TxtMaskedContactNo.Text)
        CustomerData.Add(TxtFirstName.Text)
        CustomerData.Add(TxtLastName.Text)
        CustomerData.Add(TxtEmail.Text)
        CustomerData.Add(TxtAddress.Text)


        If (ds.Tables(0).Rows.Count = 0) Then
            write("Customer", CustomerData)
        Else
            Dim query As String = "update Customer set FirstName='" + TxtFirstName.Text + "',LastName='" + TxtLastName.Text + "',Email='" + TxtEmail.Text + "',Address='" + TxtAddress.Text + "' where ContactNo= '" + TxtMaskedContactNo.Text + "'"
            executeUpdateQuery(query)
        End If



        Dim OrderId As String
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 1000000000)
        OrderId = number.ToString("000000000")

        OrderData.Add(OrderId)
        OrderData.Add(Convert.ToDecimal(TxtTotalAmount.Text))
        OrderData.Add(DTOrderDate.Value.ToString("yyyy-MM-dd"))
        OrderData.Add(CmbOrderType.SelectedItem)
        OrderData.Add(DTExpectedDeliveryDate.Value.ToString("yyyy-MM-dd"))
        OrderData.Add(CmbOfferName.SelectedItem)
        OrderData.Add(TxtMaskedContactNo.Text)
        OrderData.Add(ListBoxStatus.SelectedItem)
        write("Orders", OrderData)

        Dim OrderItem As List(Of Object)
        Dim updateQuery
        For Each Row As DataGridViewRow In DataGridViewItems.Rows
            OrderItem = New List(Of Object)
            OrderItem.Add(OrderId)
            If (IsNothing(Row.Cells(0).Value) = False) Then
                OrderItem.Add(Row.Cells(0).Value)
                OrderItem.Add(Row.Cells(2).Value)
                updateQuery = "Update Medicine set Quantity = Quantity - " + Row.Cells(2).Value.ToString() + "where MedId='" + Row.Cells(0).Value + "'"
                executeUpdateQuery(updateQuery)
                write("Order_Item", OrderItem)
            End If
        Next
        MsgBox("Order placed successfully")
    End Sub




    Private Sub BtnDeleteItem_Click(sender As Object, e As EventArgs) Handles BtnDeleteItem.Click
        If (DataGridViewItems.SelectedRows.Count = 0) Then
            MsgBox("Please select a medicine to delete")
        Else
            Dim selectedRow As DataGridViewRow = DataGridViewItems.SelectedRows.Item(0)
            DataGridViewItems.Rows.RemoveAt(selectedRow.Index)


        End If
    End Sub



    Private Sub TxtMaskedContactNo_LostFocus(sender As Object, e As EventArgs) Handles TxtMaskedContactNo.LostFocus
        Dim ds As New DataSet
        Dim fetchquery As String = "Select * from Customer where ContactNo= '" + TxtMaskedContactNo.Text + "'"
        ds = read(fetchquery)
        If (ds.Tables(0).Rows.Count = 1) Then
            Dim details As DataRow = ds.Tables(0).Rows(0)
            TxtFirstName.Text = details.Item(1)
            TxtLastName.Text = details.Item(2)
            TxtEmail.Text = details.Item(3)
            TxtAddress.Text = details.Item(4)
        End If
    End Sub
End Class
Class Item
    Property MedId As String
    Property DisplayValue As String
    Property Price As Double
End Class