<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCancelUser = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMaskedContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtMaskedContactNo)
        Me.Panel1.Controls.Add(Me.CmbType)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BtnCancelUser)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtlname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, -19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 904)
        Me.Panel1.TabIndex = 0
        '
        'CmbType
        '
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"Normal", "Admin"})
        Me.CmbType.Location = New System.Drawing.Point(367, 534)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(225, 24)
        Me.CmbType.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(137, 534)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 26)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(226, 482)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(213, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(252, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 24)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(240, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(309, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 24)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "*"
        '
        'BtnCancelUser
        '
        Me.BtnCancelUser.BackColor = System.Drawing.Color.DimGray
        Me.BtnCancelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCancelUser.FlatAppearance.BorderSize = 3
        Me.BtnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelUser.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelUser.ForeColor = System.Drawing.Color.White
        Me.BtnCancelUser.Location = New System.Drawing.Point(471, 597)
        Me.BtnCancelUser.Name = "BtnCancelUser"
        Me.BtnCancelUser.Size = New System.Drawing.Size(121, 41)
        Me.BtnCancelUser.TabIndex = 20
        Me.BtnCancelUser.Text = "CANCEL"
        Me.BtnCancelUser.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Aqua
        Me.Label7.Location = New System.Drawing.Point(138, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(359, 75)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ADD USER"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.White
        Me.txtlname.Location = New System.Drawing.Point(367, 364)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(225, 22)
        Me.txtlname.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Last Name"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(367, 425)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(225, 22)
        Me.txtemail.TabIndex = 16
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Location = New System.Drawing.Point(367, 249)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(225, 22)
        Me.txtpassword.TabIndex = 15
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Location = New System.Drawing.Point(367, 482)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(225, 22)
        Me.txtaddress.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(313, 597)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 41)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.White
        Me.txtfname.Location = New System.Drawing.Point(367, 305)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(225, 22)
        Me.txtfname.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'TxtMaskedContactNo
        '
        Me.TxtMaskedContactNo.AllowPromptAsInput = False
        Me.TxtMaskedContactNo.BeepOnError = True
        Me.TxtMaskedContactNo.Location = New System.Drawing.Point(367, 190)
        Me.TxtMaskedContactNo.Mask = "0000000000"
        Me.TxtMaskedContactNo.Name = "TxtMaskedContactNo"
        Me.TxtMaskedContactNo.ResetOnSpace = False
        Me.TxtMaskedContactNo.Size = New System.Drawing.Size(225, 22)
        Me.TxtMaskedContactNo.TabIndex = 28
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 656)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "AddUser"
        Me.Text = "AddUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelUser As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtMaskedContactNo As MaskedTextBox
End Class
