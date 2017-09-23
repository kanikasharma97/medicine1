Public Class ADMIN
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(0)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(2)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(3)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)




    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnAddMedicine.Click
        AddMedicine.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        AddUser.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnAddOffer.Click
        AddOffers.Show()
    End Sub

    Private Sub BtnAddCategory_Click(sender As Object, e As EventArgs) Handles BtnAddCategory.Click
        Dim userdata As New List(Of Object)
        Dim ans As String
        Dim query As String
        ans = InputBox("Enter category name", "Category")
        userdata.Add(ans)
        If ans = "" Then
            MsgBox("Please provide a category name")
        Else
            query = "select CategoryName From Category where CategoryName ='" + ans + "'"
            Dim ds As DataSet = read(query)

            If ds.Tables(0).Rows.Count = 1 Then
                MsgBox("Category with this name already exists")
            Else
                write("Category", userdata)
                MsgBox("Category inserted")
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BtnAddOrder.Click
        Addorder.Show()
    End Sub

    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GetWellmedsdatabaseDataSet.Medicine' table. You can move, or remove it, as needed.


    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles BtnSearchMedicine.Click
        Dim val As String = TxtMedicineSearch.Text

        If val = "" Then
            MsgBox("Please enter something to search")
        Else
            Dim query As String = "select * from medicine where name Like '%" + val + "%'" + " OR Company Like '%" + val + "%'"
            Dim ds As DataSet = read(query)
            DataGridViewMedicine.DataSource = ds.Tables(0)
            DataGridViewMedicine.Columns(0).Visible = False

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicine.CellContentClick

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles BtnSearchUsers.Click
        Dim val As String = TxtUserSearch.Text

        If val = "" Then
            MsgBox("Please enter something to search")
        Else
            Dim query As String = "select * from UserIdentity where FirstName Like '%" + val + "%'"
            Dim ds As DataSet = read(query)
            DataGridViewUser.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub DataGridView1_MouseLeave(sender As Object, e As EventArgs) Handles DataGridViewMedicine.MouseLeave

    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles BtnUpdateMedicine.Click
        If (DataGridViewMedicine.SelectedRows.Count = 0) Then
            MsgBox("Please select a medicine to update")

        Else
            Dim selectedRow As DataGridViewRow = DataGridViewMedicine.SelectedRows.Item(0)
            Dim MedId As String = selectedRow.Cells.Item(0).Value

            Dim medDetails As String = "Select * from Medicine where MedId = '" + MedId + "'"
            Dim categoryDetails As String = "Select CategoryName from Med_Category where MedId = '" + MedId + "'"

            Dim medDs As DataRow = read(medDetails).Tables(0).Rows(0)
            Dim catDs As DataRowCollection = read(categoryDetails).Tables(0).Rows


            UpdateMedicine.MedId.Text = medDs.Item(0)
            UpdateMedicine.TxtName.Text = medDs.Item(1)
            UpdateMedicine.TxtCompany.Text = medDs.Item(2)
            UpdateMedicine.TxtDescription.Text = medDs.Item(3)
            UpdateMedicine.NumericMg.Value = medDs.Item(4)
            UpdateMedicine.NumericQuantity.Value = medDs.Item(5)
            UpdateMedicine.NumericUnitPrice.Value = medDs.Item(6)
            UpdateMedicine.DTManufacture.Value = medDs.Item(7)
            UpdateMedicine.DTExpiry.Value = medDs.Item(8)



            For Each Val As Object In readColumn("Category", "CategoryName")
                UpdateMedicine.ListCategory.Items.Add(Val)
            Next

            For Each category As DataRow In catDs
                UpdateMedicine.ListCategory.SelectedItem = category.Item(0)
            Next

            UpdateMedicine.Show()
        End If
    End Sub

    Private Sub BtnSearchOffers_Click(sender As Object, e As EventArgs) Handles BtnSearchOffers.Click
        Dim val As String = TextBox3.Text

        If val = "" Then
            MsgBox("Please enter something to search")
        Else
            Dim query As String = "select * from Offers where OfferName  Like '%" + val + "%'"
            Dim ds As DataSet = read(query)
            DataGridViewOffer.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub BtnDeleteMedicine_Click(sender As Object, e As EventArgs) Handles BtnDeleteMedicine.Click
        If (DataGridViewMedicine.SelectedRows.Count = 0) Then
            MsgBox("Please select a medicine to delete")
        Else
            Dim selectedRow As DataGridViewRow = DataGridViewMedicine.SelectedRows.Item(0)
            Dim MedId As String = selectedRow.Cells.Item(0).Value

            If delete("Med_Category", "MedId", MedId) = 1 Then
                If delete("Medicine", "MedId", MedId) = 1 Then
                    DataGridViewMedicine.Rows.RemoveAt(selectedRow.Index)
                    MsgBox("Medicine deleted.")

                End If
            End If
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub BtnUpdateUser_Click(sender As Object, e As EventArgs) Handles BtnUpdateUser.Click

        If (DataGridViewUser.SelectedRows.Count = 0) Then
            MsgBox("Please select a user to update")

        Else
            Dim selectedRow As DataGridViewRow = DataGridViewUser.SelectedRows.Item(0)
            Dim UserN As String = selectedRow.Cells.Item(0).Value

            Dim UserDetails As String = "Select * from UserIdentity where ContactNo = '" + UserN + "'"

            Dim UserDs As DataRow = read(UserDetails).Tables(0).Rows(0)

            UpdateUser.lblContactNo.Text = UserDs.Item(0)
            UpdateUser.TxtMaskedContactNo.Text = UserDs.Item(0)
            UpdateUser.TxtPassword.Text = UserDs.Item(1)
            UpdateUser.TxtFirstName.Text = UserDs.Item(2)
            UpdateUser.TxtLastName.Text = UserDs.Item(3)
            UpdateUser.TxtEmail.Text = UserDs.Item(4)
            UpdateUser.TxtAddress.Text = UserDs.Item(5)

            UpdateUser.Show()
        End If


    End Sub



    Private Sub BtnDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnDeleteUser.Click
        If (DataGridViewUser.SelectedRows.Count = 0) Then
            MsgBox("Please select a User to delete")
        Else
            Dim selectedRow As DataGridViewRow = DataGridViewUser.SelectedRows.Item(0)
            Dim Contactno As String = selectedRow.Cells.Item(0).Value
            If delete("UserIdentity", "ContactNo", Contactno) = 1 Then
                DataGridViewUser.Rows.RemoveAt(selectedRow.Index)
                MsgBox("User deleted.")
            End If


        End If

    End Sub

Private Sub BtnDeleteOffers_Click(sender As Object, e As EventArgs) Handles BtnDeleteOffers.Click
    If (DataGridViewOffer.SelectedRows.Count = 0) Then
        MsgBox("Please select a offer to delete")
    Else
        Dim selectedRow As DataGridViewRow = DataGridViewOffer.SelectedRows.Item(0)
        Dim Offername As String = selectedRow.Cells.Item(0).Value
        If delete("Offers", "OfferName", Offername) = 1 Then
            DataGridViewOffer.Rows.RemoveAt(selectedRow.Index)
            MsgBox("Offer deleted.")
        End If


    End If

End Sub


Private Sub BtnUpdateOffers_Click(sender As Object, e As EventArgs) Handles BtnUpdateOffers.Click
        If (DataGridViewOffer.SelectedRows.Count = 0) Then
            MsgBox("Please select a offers to update")

        Else
            Dim selectedRow As DataGridViewRow = DataGridViewOffer.SelectedRows.Item(0)
            Dim OfferN As String = selectedRow.Cells.Item(0).Value

            Dim OfferDetails As String = "Select * from Offers where OfferName = '" + OfferN + "'"

            Dim OfferDs As DataRow = read(OfferDetails).Tables(0).Rows(0)

            UpdateOffers.lblOfferName.Text = OfferDs.Item(0)
            UpdateOffers.TxtOfferName.Text = OfferDs.Item(0)
            UpdateOffers.NumericValue.Value = OfferDs.Item(1)
            UpdateOffers.NumericMin.Value = OfferDs.Item(2)
            UpdateOffers.NumericMax.Value = OfferDs.Item(3)
            UpdateOffers.DTExpiry.Value = OfferDs.Item(4)

            UpdateOffers.Show()
        End If


    End Sub

    Private Sub BtnSearchOrders_Click(sender As Object, e As EventArgs) Handles BtnSearchOrders.Click
        Dim val As String = TxtOrderSearch.Text

        If val = " " Then
            MsgBox("Please enter something to search")
        Else
            Dim query As String = "select * from Orders where ContactNo  Like '%" + val + "%'"
            Dim ds As DataSet = read(query)
            DataGridViewOrder.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub BtnUpdateOrder_Click(sender As Object, e As EventArgs) Handles BtnUpdateOrder.Click
        If (DataGridViewOrder.SelectedRows.Count = 0) Then
            MsgBox("Please select a order to update")

        Else
            Dim selectedRow As DataGridViewRow = DataGridViewOrder.SelectedRows.Item(0)
            Dim OrderN As String = selectedRow.Cells.Item(0).Value


            Dim OrderDetails As String = "Select * from Orders where OrderId = '" + OrderN + "'"

            Dim OrderDs As DataRow = read(OrderDetails).Tables(0).Rows(0)


            UpdateOrder.LblOrderId.Text = OrderN

            UpdateOrder.CmbOfferName.Items.Add(OrderDs.Item(5))

            UpdateOrder.TxtTotalAmount.Text = OrderDs.Item(1)
            UpdateOrder.DTOrderDate.Value = OrderDs.Item(2)
            UpdateOrder.CmbOrderType.SelectedItem = OrderDs.Item(3)
            UpdateOrder.DTExpectedDeliveryDate.Value = OrderDs.Item(4)
            UpdateOrder.CmbOfferName.SelectedItem = OrderDs.Item(5)
            UpdateOrder.ListStatus.SelectedItem = OrderDs.Item(7)

            Dim CustomerN As String = OrderDs.Item(6)
            Dim CustomerDetails As String = " Select * from Customer where ContactNo ='" + CustomerN + "'"
            Dim CustomerDs As DataRow = read(CustomerDetails).tables(0).rows(0)

            UpdateOrder.TxtMaskedContactNo.Text = CustomerDs.Item(0)
            UpdateOrder.TxtFirstName.Text = CustomerDs.Item(1)
            UpdateOrder.TxtLastName.Text = CustomerDs.Item(2)
            UpdateOrder.TxtEmail.Text = CustomerDs.Item(3)
            UpdateOrder.TxtAddress.Text = CustomerDs.Item(4)

            Dim medicineIdQuery = "Select MedId, Quantity from order_item where orderId='" + OrderN + "'"
            Dim medDetailsQuery
            Dim medDetails

            UpdateOrder.DataGridViewItem.ColumnCount = 4

            UpdateOrder.DataGridViewItem.Columns(0).Name = "Medicine Id"
            UpdateOrder.DataGridViewItem.Columns(1).Name = "Medicine"
            UpdateOrder.DataGridViewItem.Columns(2).Name = "Quanity"
            UpdateOrder.DataGridViewItem.Columns(3).Name = "Price Per Unit"

            For Each Row As DataRow In read(medicineIdQuery).Tables(0).Rows
                medDetailsQuery = "select * from medicine where MedId = '" + Row.Item(0) + "'"
                medDetails = read(medDetailsQuery).Tables(0).Rows(0)
                UpdateOrder.DataGridViewItem.Rows.Add(medDetails.Item(0), medDetails.Item(1), Row.Item(1), medDetails.Item(6))
            Next

            UpdateOrder.Show()
        End If


    End Sub

End Class



