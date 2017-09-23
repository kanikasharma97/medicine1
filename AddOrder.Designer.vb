<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addorder
    Inherits MasterForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtAdress = New System.Windows.Forms.Panel()
        Me.TxtMaskedContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ListBoxStatus = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CmbOfferName = New System.Windows.Forms.ComboBox()
        Me.DTExpectedDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.CmbOrderType = New System.Windows.Forms.ComboBox()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.DTOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.NumericQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbItems = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDeleteItem = New System.Windows.Forms.Button()
        Me.TxtAdress.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Turquoise
        Me.Label5.Location = New System.Drawing.Point(271, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(419, 75)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ADD ORDER"
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAddOrder.FlatAppearance.BorderSize = 3
        Me.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOrder.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOrder.ForeColor = System.Drawing.Color.White
        Me.BtnAddOrder.Location = New System.Drawing.Point(653, 799)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(145, 46)
        Me.BtnAddOrder.TabIndex = 10
        Me.BtnAddOrder.Text = "ADD"
        Me.BtnAddOrder.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(832, 799)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 46)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtAdress
        '
        Me.TxtAdress.BackColor = System.Drawing.Color.Transparent
        Me.TxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdress.Controls.Add(Me.TxtMaskedContactNo)
        Me.TxtAdress.Controls.Add(Me.Label21)
        Me.TxtAdress.Controls.Add(Me.Label19)
        Me.TxtAdress.Controls.Add(Me.Label18)
        Me.TxtAdress.Controls.Add(Me.TxtAddress)
        Me.TxtAdress.Controls.Add(Me.TxtEmail)
        Me.TxtAdress.Controls.Add(Me.TxtLastName)
        Me.TxtAdress.Controls.Add(Me.TxtFirstName)
        Me.TxtAdress.Controls.Add(Me.Label7)
        Me.TxtAdress.Controls.Add(Me.Label6)
        Me.TxtAdress.Controls.Add(Me.Label4)
        Me.TxtAdress.Controls.Add(Me.Label3)
        Me.TxtAdress.Controls.Add(Me.Label2)
        Me.TxtAdress.Controls.Add(Me.Label1)
        Me.TxtAdress.Location = New System.Drawing.Point(12, 115)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(345, 388)
        Me.TxtAdress.TabIndex = 12
        '
        'TxtMaskedContactNo
        '
        Me.TxtMaskedContactNo.AllowPromptAsInput = False
        Me.TxtMaskedContactNo.BeepOnError = True
        Me.TxtMaskedContactNo.Location = New System.Drawing.Point(193, 102)
        Me.TxtMaskedContactNo.Mask = "0000000000"
        Me.TxtMaskedContactNo.Name = "TxtMaskedContactNo"
        Me.TxtMaskedContactNo.ResetOnSpace = False
        Me.TxtMaskedContactNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtMaskedContactNo.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(104, 326)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 24)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(122, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 23)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(159, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 23)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "*"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(193, 326)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(100, 20)
        Me.TxtAddress.TabIndex = 10
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(193, 278)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmail.TabIndex = 9
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(193, 218)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(100, 20)
        Me.TxtLastName.TabIndex = 8
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(193, 157)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(63, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.ListBoxStatus)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.CmbOfferName)
        Me.Panel2.Controls.Add(Me.DTExpectedDeliveryDate)
        Me.Panel2.Controls.Add(Me.CmbOrderType)
        Me.Panel2.Controls.Add(Me.TxtTotalAmount)
        Me.Panel2.Controls.Add(Me.DTOrderDate)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(378, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 388)
        Me.Panel2.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(78, 339)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 24)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(218, 243)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(21, 24)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(121, 191)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 24)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(121, 142)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 24)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "*"
        '
        'ListBoxStatus
        '
        Me.ListBoxStatus.FormattingEnabled = True
        Me.ListBoxStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.ListBoxStatus.Location = New System.Drawing.Point(245, 344)
        Me.ListBoxStatus.Name = "ListBoxStatus"
        Me.ListBoxStatus.Size = New System.Drawing.Size(120, 17)
        Me.ListBoxStatus.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 339)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 22)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Status"
        '
        'CmbOfferName
        '
        Me.CmbOfferName.FormattingEnabled = True
        Me.CmbOfferName.Location = New System.Drawing.Point(245, 298)
        Me.CmbOfferName.Name = "CmbOfferName"
        Me.CmbOfferName.Size = New System.Drawing.Size(129, 21)
        Me.CmbOfferName.TabIndex = 13
        '
        'DTExpectedDeliveryDate
        '
        Me.DTExpectedDeliveryDate.Location = New System.Drawing.Point(245, 245)
        Me.DTExpectedDeliveryDate.Name = "DTExpectedDeliveryDate"
        Me.DTExpectedDeliveryDate.Size = New System.Drawing.Size(131, 20)
        Me.DTExpectedDeliveryDate.TabIndex = 10
        Me.DTExpectedDeliveryDate.Value = New Date(2017, 9, 17, 13, 18, 32, 0)
        '
        'CmbOrderType
        '
        Me.CmbOrderType.FormattingEnabled = True
        Me.CmbOrderType.Items.AddRange(New Object() {"PICKUP", "DELIVERY"})
        Me.CmbOrderType.Location = New System.Drawing.Point(245, 191)
        Me.CmbOrderType.Name = "CmbOrderType"
        Me.CmbOrderType.Size = New System.Drawing.Size(129, 21)
        Me.CmbOrderType.TabIndex = 9
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Location = New System.Drawing.Point(245, 102)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.ReadOnly = True
        Me.TxtTotalAmount.Size = New System.Drawing.Size(129, 20)
        Me.TxtTotalAmount.TabIndex = 8
        Me.TxtTotalAmount.Text = "0"
        '
        'DTOrderDate
        '
        Me.DTOrderDate.Location = New System.Drawing.Point(245, 142)
        Me.DTOrderDate.Name = "DTOrderDate"
        Me.DTOrderDate.ShowUpDown = True
        Me.DTOrderDate.Size = New System.Drawing.Size(129, 20)
        Me.DTOrderDate.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 22)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Offer Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Expected Delivery Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Order Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Order Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Aqua
        Me.Label8.Location = New System.Drawing.Point(148, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ORDER DETAILS"
        '
        'DataGridViewItems
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        Me.DataGridViewItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewItems.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.GridColor = System.Drawing.Color.White
        Me.DataGridViewItems.Location = New System.Drawing.Point(346, 8)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.Size = New System.Drawing.Size(440, 186)
        Me.DataGridViewItems.TabIndex = 19
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.White
        Me.BtnAddItem.Location = New System.Drawing.Point(164, 160)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(86, 34)
        Me.BtnAddItem.TabIndex = 18
        Me.BtnAddItem.Text = "ADD ITEM"
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'NumericQuantity
        '
        Me.NumericQuantity.Location = New System.Drawing.Point(127, 115)
        Me.NumericQuantity.Name = "NumericQuantity"
        Me.NumericQuantity.Size = New System.Drawing.Size(193, 20)
        Me.NumericQuantity.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 19)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "QUANTITY"
        '
        'CmbItems
        '
        Me.CmbItems.FormattingEnabled = True
        Me.CmbItems.Items.AddRange(New Object() {"KANIKA", "SHREYA", "ABHINAV", "ASHOK"})
        Me.CmbItems.Location = New System.Drawing.Point(127, 74)
        Me.CmbItems.Name = "CmbItems"
        Me.CmbItems.Size = New System.Drawing.Size(193, 21)
        Me.CmbItems.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 19)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "ITEM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DimGray
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Aqua
        Me.Label14.Location = New System.Drawing.Point(68, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 26)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "ITEM DETAILS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnDeleteItem)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.CmbItems)
        Me.Panel1.Controls.Add(Me.BtnAddItem)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.DataGridViewItems)
        Me.Panel1.Controls.Add(Me.NumericQuantity)
        Me.Panel1.Location = New System.Drawing.Point(12, 525)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 259)
        Me.Panel1.TabIndex = 20
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteItem.Location = New System.Drawing.Point(674, 200)
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.Size = New System.Drawing.Size(112, 34)
        Me.BtnDeleteItem.TabIndex = 20
        Me.BtnDeleteItem.Text = "DELETE ITEM"
        Me.BtnDeleteItem.UseVisualStyleBackColor = False
        '
        'Addorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtAdress)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Addorder"
        Me.TxtAdress.ResumeLayout(False)
        Me.TxtAdress.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtAdress As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DTExpectedDeliveryDate As DateTimePicker
    Friend WithEvents CmbOrderType As ComboBox
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents DTOrderDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericQuantity As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents CmbItems As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CmbOfferName As ComboBox
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents DataGridViewItems As DataGridView
    Friend WithEvents ListBoxStatus As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDeleteItem As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtMaskedContactNo As MaskedTextBox
End Class
