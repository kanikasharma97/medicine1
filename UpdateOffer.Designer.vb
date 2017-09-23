<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOffer
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnUpdateOffer = New System.Windows.Forms.Button()
        Me.lblOfferName = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(260, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.Label2.Location = New System.Drawing.Point(260, 389)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.Label3.Location = New System.Drawing.Point(260, 477)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MINIMUM AMOUNT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(260, 578)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MAXIMUM AMOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(263, 672)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXPIRY DATE"
        '
        'TxtOfferName
        '
        Me.TxtOfferName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOfferName.Location = New System.Drawing.Point(503, 291)
        Me.TxtOfferName.Name = "TxtOfferName"
        Me.TxtOfferName.Size = New System.Drawing.Size(200, 29)
        Me.TxtOfferName.TabIndex = 5
        '
        'NumericValue
        '
        Me.NumericValue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericValue.Location = New System.Drawing.Point(503, 381)
        Me.NumericValue.Name = "NumericValue"
        Me.NumericValue.Size = New System.Drawing.Size(200, 29)
        Me.NumericValue.TabIndex = 6
        '
        'NumericMin
        '
        Me.NumericMin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericMin.Location = New System.Drawing.Point(503, 469)
        Me.NumericMin.Name = "NumericMin"
        Me.NumericMin.Size = New System.Drawing.Size(200, 29)
        Me.NumericMin.TabIndex = 7
        '
        'NumericMax
        '
        Me.NumericMax.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericMax.Location = New System.Drawing.Point(503, 576)
        Me.NumericMax.Name = "NumericMax"
        Me.NumericMax.Size = New System.Drawing.Size(200, 29)
        Me.NumericMax.TabIndex = 8
        '
        'DTExpiry
        '
        Me.DTExpiry.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTExpiry.Location = New System.Drawing.Point(503, 666)
        Me.DTExpiry.Name = "DTExpiry"
        Me.DTExpiry.Size = New System.Drawing.Size(200, 29)
        Me.DTExpiry.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aqua
        Me.Label6.Location = New System.Drawing.Point(223, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(526, 73)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "UPDATE OFFER"
        '
        'BtnUpdateOffer
        '
        Me.BtnUpdateOffer.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnUpdateOffer.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateOffer.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateOffer.Location = New System.Drawing.Point(370, 771)
        Me.BtnUpdateOffer.Name = "BtnUpdateOffer"
        Me.BtnUpdateOffer.Size = New System.Drawing.Size(156, 53)
        Me.BtnUpdateOffer.TabIndex = 11
        Me.BtnUpdateOffer.Text = "UPDATE"
        Me.BtnUpdateOffer.UseVisualStyleBackColor = False
        '
        'lblOfferName
        '
        Me.lblOfferName.AutoSize = True
        Me.lblOfferName.Location = New System.Drawing.Point(109, 329)
        Me.lblOfferName.Name = "lblOfferName"
        Me.lblOfferName.Size = New System.Drawing.Size(72, 24)
        Me.lblOfferName.TabIndex = 12
        Me.lblOfferName.Text = "Label7"
        Me.lblOfferName.Visible = False
        '
        'UpdateOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.lblOfferName)
        Me.Controls.Add(Me.BtnUpdateOffer)
        Me.Controls.Add(Me.Label6)
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
        Me.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UpdateOffer"
        Me.Text = "UpdateOffer"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnUpdateOffer As Button
    Friend WithEvents lblOfferName As Label
End Class
