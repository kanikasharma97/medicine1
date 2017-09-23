<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMedicine
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
        Me.DTExpiry = New System.Windows.Forms.DateTimePicker()
        Me.DTManufacture = New System.Windows.Forms.DateTimePicker()
        Me.NumericUnitPrice = New System.Windows.Forms.NumericUpDown()
        Me.NumericQuantity = New System.Windows.Forms.NumericUpDown()
        Me.NumericMg = New System.Windows.Forms.NumericUpDown()
        Me.TxtDescription = New System.Windows.Forms.RichTextBox()
        Me.ListCategory = New System.Windows.Forms.ListBox()
        Me.TxtCompany = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddMedicine = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnCancelMedicine = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.NumericUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericMg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTExpiry
        '
        Me.DTExpiry.CustomFormat = "yyyy-MM-dd"
        Me.DTExpiry.Location = New System.Drawing.Point(403, 633)
        Me.DTExpiry.Name = "DTExpiry"
        Me.DTExpiry.Size = New System.Drawing.Size(157, 20)
        Me.DTExpiry.TabIndex = 20
        '
        'DTManufacture
        '
        Me.DTManufacture.CalendarMonthBackground = System.Drawing.Color.Silver
        Me.DTManufacture.CustomFormat = "yyyy-MM-dd"
        Me.DTManufacture.Location = New System.Drawing.Point(403, 566)
        Me.DTManufacture.Name = "DTManufacture"
        Me.DTManufacture.Size = New System.Drawing.Size(157, 20)
        Me.DTManufacture.TabIndex = 19
        '
        'NumericUnitPrice
        '
        Me.NumericUnitPrice.BackColor = System.Drawing.Color.White
        Me.NumericUnitPrice.Location = New System.Drawing.Point(403, 698)
        Me.NumericUnitPrice.Name = "NumericUnitPrice"
        Me.NumericUnitPrice.Size = New System.Drawing.Size(157, 20)
        Me.NumericUnitPrice.TabIndex = 18
        '
        'NumericQuantity
        '
        Me.NumericQuantity.BackColor = System.Drawing.Color.White
        Me.NumericQuantity.Location = New System.Drawing.Point(403, 503)
        Me.NumericQuantity.Name = "NumericQuantity"
        Me.NumericQuantity.Size = New System.Drawing.Size(157, 20)
        Me.NumericQuantity.TabIndex = 17
        '
        'NumericMg
        '
        Me.NumericMg.BackColor = System.Drawing.Color.White
        Me.NumericMg.Location = New System.Drawing.Point(403, 438)
        Me.NumericMg.Name = "NumericMg"
        Me.NumericMg.Size = New System.Drawing.Size(157, 20)
        Me.NumericMg.TabIndex = 16
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.White
        Me.TxtDescription.Location = New System.Drawing.Point(403, 354)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(157, 39)
        Me.TxtDescription.TabIndex = 15
        Me.TxtDescription.Text = ""
        '
        'ListCategory
        '
        Me.ListCategory.BackColor = System.Drawing.Color.White
        Me.ListCategory.FormattingEnabled = True
        Me.ListCategory.Location = New System.Drawing.Point(403, 279)
        Me.ListCategory.Name = "ListCategory"
        Me.ListCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListCategory.Size = New System.Drawing.Size(157, 30)
        Me.ListCategory.TabIndex = 14
        '
        'TxtCompany
        '
        Me.TxtCompany.BackColor = System.Drawing.Color.White
        Me.TxtCompany.Location = New System.Drawing.Point(403, 214)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(157, 20)
        Me.TxtCompany.TabIndex = 13
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(403, 146)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(157, 20)
        Me.TxtName.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(153, 628)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "EXPIRY DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(148, 562)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "MANUFACTURE DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(153, 699)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PRICE PER UNIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(153, 499)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "QUANTITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(153, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "MG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(148, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DESCRIPTION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(148, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(153, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "COMPANY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(155, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NAME"
        '
        'BtnAddMedicine
        '
        Me.BtnAddMedicine.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAddMedicine.FlatAppearance.BorderSize = 3
        Me.BtnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMedicine.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMedicine.Location = New System.Drawing.Point(282, 759)
        Me.BtnAddMedicine.Name = "BtnAddMedicine"
        Me.BtnAddMedicine.Size = New System.Drawing.Size(127, 45)
        Me.BtnAddMedicine.TabIndex = 21
        Me.BtnAddMedicine.Text = "ADD"
        Me.BtnAddMedicine.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Aqua
        Me.Label9.Location = New System.Drawing.Point(152, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(523, 75)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ADD MEDICINE"
        '
        'BtnCancelMedicine
        '
        Me.BtnCancelMedicine.BackColor = System.Drawing.Color.DimGray
        Me.BtnCancelMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCancelMedicine.FlatAppearance.BorderSize = 3
        Me.BtnCancelMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelMedicine.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelMedicine.Location = New System.Drawing.Point(421, 759)
        Me.BtnCancelMedicine.Name = "BtnCancelMedicine"
        Me.BtnCancelMedicine.Size = New System.Drawing.Size(135, 45)
        Me.BtnCancelMedicine.TabIndex = 23
        Me.BtnCancelMedicine.Text = "CANCEL"
        Me.BtnCancelMedicine.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(234, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(268, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(204, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(297, 628)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(331, 699)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(376, 566)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(268, 499)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "*"
        '
        'AddMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnCancelMedicine)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnAddMedicine)
        Me.Controls.Add(Me.DTExpiry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DTManufacture)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.NumericUnitPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericQuantity)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.NumericMg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.ListCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "AddMedicine"
        Me.Text = "AddMedicine"
        CType(Me.NumericUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericMg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListCategory As ListBox
    Friend WithEvents TxtCompany As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DTExpiry As DateTimePicker
    Friend WithEvents DTManufacture As DateTimePicker
    Friend WithEvents NumericUnitPrice As NumericUpDown
    Friend WithEvents NumericQuantity As NumericUpDown
    Friend WithEvents NumericMg As NumericUpDown
    Friend WithEvents TxtDescription As RichTextBox
    Friend WithEvents BtnAddMedicine As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnCancelMedicine As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
