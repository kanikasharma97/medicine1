<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListStatus = New System.Windows.Forms.ListBox()
        Me.CmbOfferName = New System.Windows.Forms.ComboBox()
        Me.DTExpectedDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.CmbOrderType = New System.Windows.Forms.ComboBox()
        Me.DTOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewItem = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnUpdateOrder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblOrderId = New System.Windows.Forms.Label()
        Me.TxtMaskedContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(230, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UPDATE ORDER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtMaskedContactNo)
        Me.Panel1.Controls.Add(Me.TxtAddress)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.TxtLastName)
        Me.Panel1.Controls.Add(Me.TxtFirstName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 344)
        Me.Panel1.TabIndex = 1
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(217, 277)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(130, 20)
        Me.TxtAddress.TabIndex = 10
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(221, 226)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(126, 20)
        Me.TxtEmail.TabIndex = 9
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(221, 170)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(126, 20)
        Me.TxtLastName.TabIndex = 8
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(221, 128)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(126, 20)
        Me.TxtFirstName.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 22)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(84, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CUSTOMER DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ListStatus)
        Me.Panel2.Controls.Add(Me.CmbOfferName)
        Me.Panel2.Controls.Add(Me.DTExpectedDeliveryDate)
        Me.Panel2.Controls.Add(Me.CmbOrderType)
        Me.Panel2.Controls.Add(Me.DTOrderDate)
        Me.Panel2.Controls.Add(Me.TxtTotalAmount)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(463, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 344)
        Me.Panel2.TabIndex = 2
        '
        'ListStatus
        '
        Me.ListStatus.FormattingEnabled = True
        Me.ListStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.ListStatus.Location = New System.Drawing.Point(246, 293)
        Me.ListStatus.Name = "ListStatus"
        Me.ListStatus.Size = New System.Drawing.Size(138, 17)
        Me.ListStatus.TabIndex = 12
        '
        'CmbOfferName
        '
        Me.CmbOfferName.Enabled = False
        Me.CmbOfferName.FormattingEnabled = True
        Me.CmbOfferName.Location = New System.Drawing.Point(245, 240)
        Me.CmbOfferName.Name = "CmbOfferName"
        Me.CmbOfferName.Size = New System.Drawing.Size(139, 21)
        Me.CmbOfferName.TabIndex = 11
        '
        'DTExpectedDeliveryDate
        '
        Me.DTExpectedDeliveryDate.Location = New System.Drawing.Point(246, 198)
        Me.DTExpectedDeliveryDate.Name = "DTExpectedDeliveryDate"
        Me.DTExpectedDeliveryDate.Size = New System.Drawing.Size(138, 20)
        Me.DTExpectedDeliveryDate.TabIndex = 10
        '
        'CmbOrderType
        '
        Me.CmbOrderType.FormattingEnabled = True
        Me.CmbOrderType.Items.AddRange(New Object() {"PICKUP", "DELIVERY"})
        Me.CmbOrderType.Location = New System.Drawing.Point(245, 157)
        Me.CmbOrderType.Name = "CmbOrderType"
        Me.CmbOrderType.Size = New System.Drawing.Size(139, 21)
        Me.CmbOrderType.TabIndex = 9
        '
        'DTOrderDate
        '
        Me.DTOrderDate.Location = New System.Drawing.Point(240, 118)
        Me.DTOrderDate.Name = "DTOrderDate"
        Me.DTOrderDate.Size = New System.Drawing.Size(144, 20)
        Me.DTOrderDate.TabIndex = 8
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Enabled = False
        Me.TxtTotalAmount.Location = New System.Drawing.Point(240, 77)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.Size = New System.Drawing.Size(139, 20)
        Me.TxtTotalAmount.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(38, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 22)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Status"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(38, 240)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 22)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Offer Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(202, 22)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Expected Delivery Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 22)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Order Type"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 22)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Order Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 22)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "TotalOrder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(161, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ORDER DETAILS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.DataGridViewItem)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 529)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 263)
        Me.Panel3.TabIndex = 3
        '
        'DataGridViewItem
        '
        Me.DataGridViewItem.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItem.Location = New System.Drawing.Point(104, 27)
        Me.DataGridViewItem.Name = "DataGridViewItem"
        Me.DataGridViewItem.Size = New System.Drawing.Size(881, 207)
        Me.DataGridViewItem.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 0
        '
        'BtnUpdateOrder
        '
        Me.BtnUpdateOrder.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdateOrder.FlatAppearance.BorderSize = 3
        Me.BtnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateOrder.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateOrder.Location = New System.Drawing.Point(277, 814)
        Me.BtnUpdateOrder.Name = "BtnUpdateOrder"
        Me.BtnUpdateOrder.Size = New System.Drawing.Size(119, 39)
        Me.BtnUpdateOrder.TabIndex = 4
        Me.BtnUpdateOrder.Text = "UPDATE"
        Me.BtnUpdateOrder.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(425, 814)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LblOrderId
        '
        Me.LblOrderId.AutoSize = True
        Me.LblOrderId.Location = New System.Drawing.Point(22, 60)
        Me.LblOrderId.Name = "LblOrderId"
        Me.LblOrderId.Size = New System.Drawing.Size(45, 13)
        Me.LblOrderId.TabIndex = 6
        Me.LblOrderId.Text = "Label19"
        Me.LblOrderId.Visible = False
        '
        'TxtMaskedContactNo
        '
        Me.TxtMaskedContactNo.AllowPromptAsInput = False
        Me.TxtMaskedContactNo.BeepOnError = True
        Me.TxtMaskedContactNo.Location = New System.Drawing.Point(221, 77)
        Me.TxtMaskedContactNo.Mask = "0000000000"
        Me.TxtMaskedContactNo.Name = "TxtMaskedContactNo"
        Me.TxtMaskedContactNo.ResetOnSpace = False
        Me.TxtMaskedContactNo.Size = New System.Drawing.Size(126, 20)
        Me.TxtMaskedContactNo.TabIndex = 11
        '
        'UpdateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.LblOrderId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnUpdateOrder)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateOrder"
        Me.Text = "UpdateOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DTOrderDate As DateTimePicker
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents DTExpectedDeliveryDate As DateTimePicker
    Friend WithEvents CmbOrderType As ComboBox
    Friend WithEvents CmbOfferName As ComboBox
    Friend WithEvents ListStatus As ListBox
    Friend WithEvents BtnUpdateOrder As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblOrderId As Label
    Friend WithEvents DataGridViewItem As DataGridView
    Friend WithEvents TxtMaskedContactNo As MaskedTextBox
End Class
