<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMedicine
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtCompany = New System.Windows.Forms.TextBox()
        Me.ListCategory = New System.Windows.Forms.ListBox()
        Me.TxtDescription = New System.Windows.Forms.RichTextBox()
        Me.NumericMg = New System.Windows.Forms.NumericUpDown()
        Me.NumericQuantity = New System.Windows.Forms.NumericUpDown()
        Me.DTManufacture = New System.Windows.Forms.DateTimePicker()
        Me.DTExpiry = New System.Windows.Forms.DateTimePicker()
        Me.NumericUnitPrice = New System.Windows.Forms.NumericUpDown()
        Me.BtnUpdateMedicine = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MedId = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.NumericMg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COMPANY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CATEGORY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DESCRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "QUANTITY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 592)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "MANUFACTURE DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 660)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "EXPIRY DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(148, 732)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PRICE PER UNIT"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(409, 156)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(206, 20)
        Me.TxtName.TabIndex = 9
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(409, 224)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(206, 20)
        Me.TxtCompany.TabIndex = 10
        '
        'ListCategory
        '
        Me.ListCategory.FormattingEnabled = True
        Me.ListCategory.Location = New System.Drawing.Point(409, 292)
        Me.ListCategory.Name = "ListCategory"
        Me.ListCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListCategory.Size = New System.Drawing.Size(206, 30)
        Me.ListCategory.TabIndex = 11
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(403, 370)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(212, 42)
        Me.TxtDescription.TabIndex = 12
        Me.TxtDescription.Text = ""
        '
        'NumericMg
        '
        Me.NumericMg.Location = New System.Drawing.Point(403, 460)
        Me.NumericMg.Name = "NumericMg"
        Me.NumericMg.Size = New System.Drawing.Size(212, 20)
        Me.NumericMg.TabIndex = 13
        '
        'NumericQuantity
        '
        Me.NumericQuantity.Location = New System.Drawing.Point(403, 528)
        Me.NumericQuantity.Name = "NumericQuantity"
        Me.NumericQuantity.Size = New System.Drawing.Size(212, 20)
        Me.NumericQuantity.TabIndex = 14
        '
        'DTManufacture
        '
        Me.DTManufacture.Location = New System.Drawing.Point(409, 596)
        Me.DTManufacture.Name = "DTManufacture"
        Me.DTManufacture.Size = New System.Drawing.Size(206, 20)
        Me.DTManufacture.TabIndex = 15
        '
        'DTExpiry
        '
        Me.DTExpiry.Location = New System.Drawing.Point(409, 664)
        Me.DTExpiry.Name = "DTExpiry"
        Me.DTExpiry.Size = New System.Drawing.Size(206, 20)
        Me.DTExpiry.TabIndex = 16
        '
        'NumericUnitPrice
        '
        Me.NumericUnitPrice.Location = New System.Drawing.Point(409, 732)
        Me.NumericUnitPrice.Name = "NumericUnitPrice"
        Me.NumericUnitPrice.Size = New System.Drawing.Size(206, 20)
        Me.NumericUnitPrice.TabIndex = 17
        '
        'BtnUpdateMedicine
        '
        Me.BtnUpdateMedicine.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnUpdateMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdateMedicine.FlatAppearance.BorderSize = 3
        Me.BtnUpdateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateMedicine.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateMedicine.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateMedicine.Location = New System.Drawing.Point(338, 809)
        Me.BtnUpdateMedicine.Name = "BtnUpdateMedicine"
        Me.BtnUpdateMedicine.Size = New System.Drawing.Size(139, 44)
        Me.BtnUpdateMedicine.TabIndex = 18
        Me.BtnUpdateMedicine.Text = "UPDATE"
        Me.BtnUpdateMedicine.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DimGray
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Aqua
        Me.Label10.Location = New System.Drawing.Point(157, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(642, 73)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "UPDATE MEDICINE"
        '
        'MedId
        '
        Me.MedId.AutoSize = True
        Me.MedId.Location = New System.Drawing.Point(784, 389)
        Me.MedId.Name = "MedId"
        Me.MedId.Size = New System.Drawing.Size(45, 13)
        Me.MedId.TabIndex = 20
        Me.MedId.Text = "Label11"
        Me.MedId.Visible = False
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
        Me.Button1.Location = New System.Drawing.Point(492, 809)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(214, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(262, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(275, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(186, 456)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 24)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(262, 516)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(374, 592)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(293, 662)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(321, 732)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "*"
        '
        'UpdateMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MedId)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnUpdateMedicine)
        Me.Controls.Add(Me.NumericUnitPrice)
        Me.Controls.Add(Me.DTExpiry)
        Me.Controls.Add(Me.DTManufacture)
        Me.Controls.Add(Me.NumericQuantity)
        Me.Controls.Add(Me.NumericMg)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.ListCategory)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "UpdateMedicine"
        Me.Text = "UpdateMedicine"
        CType(Me.NumericMg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtCompany As TextBox
    Friend WithEvents ListCategory As ListBox
    Friend WithEvents TxtDescription As RichTextBox
    Friend WithEvents NumericMg As NumericUpDown
    Friend WithEvents NumericQuantity As NumericUpDown
    Friend WithEvents DTManufacture As DateTimePicker
    Friend WithEvents DTExpiry As DateTimePicker
    Friend WithEvents NumericUnitPrice As NumericUpDown
    Friend WithEvents BtnUpdateMedicine As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents MedId As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
