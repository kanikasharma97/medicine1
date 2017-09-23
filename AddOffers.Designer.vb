<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOffers
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtOfferN = New System.Windows.Forms.TextBox()
        Me.NumericValuee = New System.Windows.Forms.NumericUpDown()
        Me.NumericMinAmount = New System.Windows.Forms.NumericUpDown()
        Me.NumericMaxDiscount = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAddOffer = New System.Windows.Forms.Button()
        Me.BtnCancelMed = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.NumericValuee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericMinAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericMaxDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(138, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "OFFER NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(138, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "VALUE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(138, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 24)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "MINIMUM AMOUNT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(138, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 24)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "MAXIMUM DISCOUNT"
        '
        'TxtOfferN
        '
        Me.TxtOfferN.Location = New System.Drawing.Point(391, 246)
        Me.TxtOfferN.Name = "TxtOfferN"
        Me.TxtOfferN.Size = New System.Drawing.Size(172, 20)
        Me.TxtOfferN.TabIndex = 4
        '
        'NumericValuee
        '
        Me.NumericValuee.Location = New System.Drawing.Point(391, 313)
        Me.NumericValuee.Name = "NumericValuee"
        Me.NumericValuee.Size = New System.Drawing.Size(172, 20)
        Me.NumericValuee.TabIndex = 5
        Me.NumericValuee.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericMinAmount
        '
        Me.NumericMinAmount.Location = New System.Drawing.Point(391, 382)
        Me.NumericMinAmount.Name = "NumericMinAmount"
        Me.NumericMinAmount.Size = New System.Drawing.Size(172, 20)
        Me.NumericMinAmount.TabIndex = 6
        '
        'NumericMaxDiscount
        '
        Me.NumericMaxDiscount.Location = New System.Drawing.Point(391, 442)
        Me.NumericMaxDiscount.Name = "NumericMaxDiscount"
        Me.NumericMaxDiscount.Size = New System.Drawing.Size(172, 20)
        Me.NumericMaxDiscount.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Aqua
        Me.Label12.Location = New System.Drawing.Point(147, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(405, 73)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "ADD OFFER"
        '
        'BtnAddOffer
        '
        Me.BtnAddOffer.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddOffer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddOffer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAddOffer.FlatAppearance.BorderSize = 3
        Me.BtnAddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOffer.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOffer.ForeColor = System.Drawing.Color.White
        Me.BtnAddOffer.Location = New System.Drawing.Point(315, 614)
        Me.BtnAddOffer.Name = "BtnAddOffer"
        Me.BtnAddOffer.Size = New System.Drawing.Size(120, 42)
        Me.BtnAddOffer.TabIndex = 9
        Me.BtnAddOffer.Text = "ADD"
        Me.BtnAddOffer.UseVisualStyleBackColor = False
        '
        'BtnCancelMed
        '
        Me.BtnCancelMed.BackColor = System.Drawing.Color.DimGray
        Me.BtnCancelMed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelMed.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCancelMed.FlatAppearance.BorderSize = 3
        Me.BtnCancelMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelMed.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelMed.ForeColor = System.Drawing.Color.White
        Me.BtnCancelMed.Location = New System.Drawing.Point(443, 614)
        Me.BtnCancelMed.Name = "BtnCancelMed"
        Me.BtnCancelMed.Size = New System.Drawing.Size(120, 41)
        Me.BtnCancelMed.TabIndex = 10
        Me.BtnCancelMed.Text = "CANCEL"
        Me.BtnCancelMed.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(138, 516)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 24)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "EXPIRY DATE"
        '
        'DTExpiryDate
        '
        Me.DTExpiryDate.Location = New System.Drawing.Point(391, 516)
        Me.DTExpiryDate.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.DTExpiryDate.Name = "DTExpiryDate"
        Me.DTExpiryDate.Size = New System.Drawing.Size(172, 20)
        Me.DTExpiryDate.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(286, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 24)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(213, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(340, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(364, 443)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(286, 516)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "*"
        '
        'AddOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DTExpiryDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnCancelMed)
        Me.Controls.Add(Me.BtnAddOffer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NumericMaxDiscount)
        Me.Controls.Add(Me.NumericMinAmount)
        Me.Controls.Add(Me.NumericValuee)
        Me.Controls.Add(Me.TxtOfferN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Name = "AddOffers"
        CType(Me.NumericValuee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericMinAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericMaxDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddOffers As Button
    Friend WithEvents DTexpiry As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericMin As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericValue As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtOfferName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericMax As NumericUpDown
    Friend WithEvents BtnCancelOffer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtOfferN As TextBox
    Friend WithEvents NumericValuee As NumericUpDown
    Friend WithEvents NumericMinAmount As NumericUpDown
    Friend WithEvents NumericMaxDiscount As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnAddOffer As Button
    Friend WithEvents BtnCancelMed As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DTExpiryDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
