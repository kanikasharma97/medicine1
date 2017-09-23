<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pwdtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMaskedContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(297, 600)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(105, 50)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(313, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(367, 109)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CONTACT NUMBER"
        '
        'Pwdtxt
        '
        Me.Pwdtxt.Location = New System.Drawing.Point(519, 528)
        Me.Pwdtxt.Name = "Pwdtxt"
        Me.Pwdtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pwdtxt.Size = New System.Drawing.Size(172, 20)
        Me.Pwdtxt.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(331, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 103)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(443, 600)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(106, 50)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(495, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(413, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "*"
        '
        'TxtMaskedContactNo
        '
        Me.TxtMaskedContactNo.AllowPromptAsInput = False
        Me.TxtMaskedContactNo.AsciiOnly = True
        Me.TxtMaskedContactNo.BeepOnError = True
        Me.TxtMaskedContactNo.Location = New System.Drawing.Point(521, 461)
        Me.TxtMaskedContactNo.Mask = "0000000000"
        Me.TxtMaskedContactNo.Name = "TxtMaskedContactNo"
        Me.TxtMaskedContactNo.ResetOnSpace = False
        Me.TxtMaskedContactNo.Size = New System.Drawing.Size(172, 20)
        Me.TxtMaskedContactNo.TabIndex = 12
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.TxtMaskedContactNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pwdtxt)
        Me.MinimumSize = New System.Drawing.Size(1000, 858)
        Me.Name = "Login"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Pwdtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMaskedContactNo As MaskedTextBox
End Class
