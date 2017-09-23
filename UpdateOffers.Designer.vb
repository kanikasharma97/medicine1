<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOffers
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
        Me.TxtOfferName = New System.Windows.Forms.TextBox()
        Me.NumericValue = New System.Windows.Forms.NumericUpDown()
        Me.NumericMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericMax = New System.Windows.Forms.NumericUpDown()
        Me.DTExpiry = New System.Windows.Forms.DateTimePicker()
        Me.BtnUpdateOffer = New System.Windows.Forms.Button()
        Me.lblOfferName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCancelUpdateOffer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.NumericValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OFFER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VALUE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MINIMUM AMOUNT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MAXIMUM DISCOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 554)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXPIRY DATE"
        '
        'TxtOfferName
        '
        Me.TxtOfferName.Location = New System.Drawing.Point(399, 226)
        Me.TxtOfferName.Name = "TxtOfferName"
        Me.TxtOfferName.Size = New System.Drawing.Size(181, 20)
        Me.TxtOfferName.TabIndex = 5
        '
        'NumericValue
        '
        Me.NumericValue.Location = New System.Drawing.Point(399, 308)
        Me.NumericValue.Name = "NumericValue"
        Me.NumericValue.Size = New System.Drawing.Size(181, 20)
        Me.NumericValue.TabIndex = 6
        '
        'NumericMin
        '
        Me.NumericMin.Location = New System.Drawing.Point(404, 390)
        Me.NumericMin.Name = "NumericMin"
        Me.NumericMin.Size = New System.Drawing.Size(181, 20)
        Me.NumericMin.TabIndex = 7
        '
        'NumericMax
        '
        Me.NumericMax.Location = New System.Drawing.Point(399, 472)
        Me.NumericMax.Name = "NumericMax"
        Me.NumericMax.Size = New System.Drawing.Size(181, 20)
        Me.NumericMax.TabIndex = 8
        '
        'DTExpiry
        '
        Me.DTExpiry.Location = New System.Drawing.Point(404, 556)
        Me.DTExpiry.Name = "DTExpiry"
        Me.DTExpiry.Size = New System.Drawing.Size(181, 20)
        Me.DTExpiry.TabIndex = 9
        '
        'BtnUpdateOffer
        '
        Me.BtnUpdateOffer.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnUpdateOffer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateOffer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdateOffer.FlatAppearance.BorderSize = 3
        Me.BtnUpdateOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateOffer.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateOffer.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateOffer.Location = New System.Drawing.Point(290, 646)
        Me.BtnUpdateOffer.Name = "BtnUpdateOffer"
        Me.BtnUpdateOffer.Size = New System.Drawing.Size(155, 42)
        Me.BtnUpdateOffer.TabIndex = 10
        Me.BtnUpdateOffer.Text = "UPDATE"
        Me.BtnUpdateOffer.UseVisualStyleBackColor = False
        '
        'lblOfferName
        '
        Me.lblOfferName.AutoSize = True
        Me.lblOfferName.Location = New System.Drawing.Point(771, 90)
        Me.lblOfferName.Name = "lblOfferName"
        Me.lblOfferName.Size = New System.Drawing.Size(39, 13)
        Me.lblOfferName.TabIndex = 11
        Me.lblOfferName.Text = "Label6"
        Me.lblOfferName.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aqua
        Me.Label6.Location = New System.Drawing.Point(147, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(562, 73)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "UPDATE OFFERS"
        '
        'BtnCancelUpdateOffer
        '
        Me.BtnCancelUpdateOffer.BackColor = System.Drawing.Color.DimGray
        Me.BtnCancelUpdateOffer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelUpdateOffer.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCancelUpdateOffer.FlatAppearance.BorderSize = 3
        Me.BtnCancelUpdateOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelUpdateOffer.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelUpdateOffer.ForeColor = System.Drawing.Color.White
        Me.BtnCancelUpdateOffer.Location = New System.Drawing.Point(451, 646)
        Me.BtnCancelUpdateOffer.Name = "BtnCancelUpdateOffer"
        Me.BtnCancelUpdateOffer.Size = New System.Drawing.Size(134, 42)
        Me.BtnCancelUpdateOffer.TabIndex = 13
        Me.BtnCancelUpdateOffer.Text = "CANCEL"
        Me.BtnCancelUpdateOffer.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(286, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(228, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(344, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(372, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(296, 556)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "*"
        '
        'UpdateOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelUpdateOffer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblOfferName)
        Me.Controls.Add(Me.BtnUpdateOffer)
        Me.Controls.Add(Me.DTExpiry)
        Me.Controls.Add(Me.NumericMax)
        Me.Controls.Add(Me.NumericMin)
        Me.Controls.Add(Me.NumericValue)
        Me.Controls.Add(Me.TxtOfferName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateOffers"
        Me.Text = "UpdateForm"
        CType(Me.NumericValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtOfferName As TextBox
    Friend WithEvents NumericValue As NumericUpDown
    Friend WithEvents NumericMin As NumericUpDown
    Friend WithEvents NumericMax As NumericUpDown
    Friend WithEvents DTExpiry As DateTimePicker
    Friend WithEvents BtnUpdateOffer As Button
    Friend WithEvents lblOfferName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCancelUpdateOffer As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
