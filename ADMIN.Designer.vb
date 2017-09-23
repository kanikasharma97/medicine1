<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMIN))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnDeleteMedicine = New System.Windows.Forms.Button()
        Me.BtnAddCategory = New System.Windows.Forms.Button()
        Me.BtnUpdateMedicine = New System.Windows.Forms.Button()
        Me.BtnAddMedicine = New System.Windows.Forms.Button()
        Me.DataGridViewMedicine = New System.Windows.Forms.DataGridView()
        Me.TxtMedicineSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchMedicine = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewOrder = New System.Windows.Forms.DataGridView()
        Me.BtnUpdateOrder = New System.Windows.Forms.Button()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSearchOrders = New System.Windows.Forms.Button()
        Me.TxtOrderSearch = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnDeleteUser = New System.Windows.Forms.Button()
        Me.BtnUpdateUser = New System.Windows.Forms.Button()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSearchUsers = New System.Windows.Forms.Button()
        Me.TxtUserSearch = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BtnDeleteOffers = New System.Windows.Forms.Button()
        Me.BtnUpdateOffers = New System.Windows.Forms.Button()
        Me.DataGridViewOffer = New System.Windows.Forms.DataGridView()
        Me.BtnAddOffer = New System.Windows.Forms.Button()
        Me.BtnSearchOffers = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GetWellmedsdatabaseDataSet1 = New GetwellMedsMain.GetWellmedsdatabaseDataSet()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetWellmedsdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 1000)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 1000)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.BtnDeleteMedicine)
        Me.TabPage1.Controls.Add(Me.BtnAddCategory)
        Me.TabPage1.Controls.Add(Me.BtnUpdateMedicine)
        Me.TabPage1.Controls.Add(Me.BtnAddMedicine)
        Me.TabPage1.Controls.Add(Me.DataGridViewMedicine)
        Me.TabPage1.Controls.Add(Me.TxtMedicineSearch)
        Me.TabPage1.Controls.Add(Me.BtnSearchMedicine)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Transparent
        Me.TabPage1.Location = New System.Drawing.Point(4, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(992, 961)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MEDICINE"
        '
        'BtnDeleteMedicine
        '
        Me.BtnDeleteMedicine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteMedicine.FlatAppearance.BorderSize = 3
        Me.BtnDeleteMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDeleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteMedicine.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteMedicine.Location = New System.Drawing.Point(0, 589)
        Me.BtnDeleteMedicine.Name = "BtnDeleteMedicine"
        Me.BtnDeleteMedicine.Size = New System.Drawing.Size(219, 54)
        Me.BtnDeleteMedicine.TabIndex = 10
        Me.BtnDeleteMedicine.Text = "DELETE MEDICINE"
        Me.BtnDeleteMedicine.UseVisualStyleBackColor = False
        '
        'BtnAddCategory
        '
        Me.BtnAddCategory.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCategory.FlatAppearance.BorderSize = 3
        Me.BtnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCategory.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCategory.ForeColor = System.Drawing.Color.White
        Me.BtnAddCategory.Location = New System.Drawing.Point(0, 389)
        Me.BtnAddCategory.Name = "BtnAddCategory"
        Me.BtnAddCategory.Size = New System.Drawing.Size(219, 50)
        Me.BtnAddCategory.TabIndex = 6
        Me.BtnAddCategory.Text = "ADD CATEGORY"
        Me.BtnAddCategory.UseVisualStyleBackColor = False
        '
        'BtnUpdateMedicine
        '
        Me.BtnUpdateMedicine.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateMedicine.FlatAppearance.BorderSize = 3
        Me.BtnUpdateMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateMedicine.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateMedicine.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateMedicine.Location = New System.Drawing.Point(0, 485)
        Me.BtnUpdateMedicine.Name = "BtnUpdateMedicine"
        Me.BtnUpdateMedicine.Size = New System.Drawing.Size(219, 55)
        Me.BtnUpdateMedicine.TabIndex = 9
        Me.BtnUpdateMedicine.Text = "UPDATE MEDICINE"
        Me.BtnUpdateMedicine.UseVisualStyleBackColor = False
        '
        'BtnAddMedicine
        '
        Me.BtnAddMedicine.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddMedicine.FlatAppearance.BorderSize = 3
        Me.BtnAddMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMedicine.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMedicine.ForeColor = System.Drawing.Color.White
        Me.BtnAddMedicine.Location = New System.Drawing.Point(3, 284)
        Me.BtnAddMedicine.Name = "BtnAddMedicine"
        Me.BtnAddMedicine.Size = New System.Drawing.Size(215, 61)
        Me.BtnAddMedicine.TabIndex = 2
        Me.BtnAddMedicine.Text = "ADD MEDICINE"
        Me.BtnAddMedicine.UseVisualStyleBackColor = False
        '
        'DataGridViewMedicine
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewMedicine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewMedicine.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicine.Location = New System.Drawing.Point(219, 228)
        Me.DataGridViewMedicine.Name = "DataGridViewMedicine"
        Me.DataGridViewMedicine.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMedicine.Size = New System.Drawing.Size(694, 602)
        Me.DataGridViewMedicine.TabIndex = 8
        '
        'TxtMedicineSearch
        '
        Me.TxtMedicineSearch.Location = New System.Drawing.Point(219, 170)
        Me.TxtMedicineSearch.Name = "TxtMedicineSearch"
        Me.TxtMedicineSearch.Size = New System.Drawing.Size(656, 35)
        Me.TxtMedicineSearch.TabIndex = 1
        '
        'BtnSearchMedicine
        '
        Me.BtnSearchMedicine.BackColor = System.Drawing.Color.DimGray
        Me.BtnSearchMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearchMedicine.FlatAppearance.BorderSize = 3
        Me.BtnSearchMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchMedicine.Location = New System.Drawing.Point(881, 169)
        Me.BtnSearchMedicine.Name = "BtnSearchMedicine"
        Me.BtnSearchMedicine.Size = New System.Drawing.Size(100, 35)
        Me.BtnSearchMedicine.TabIndex = 7
        Me.BtnSearchMedicine.Text = "Search"
        Me.BtnSearchMedicine.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(206, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(662, 75)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MEDICINE DETAILS"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DimGray
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.DataGridViewOrder)
        Me.TabPage2.Controls.Add(Me.BtnUpdateOrder)
        Me.TabPage2.Controls.Add(Me.BtnAddOrder)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.BtnSearchOrders)
        Me.TabPage2.Controls.Add(Me.TxtOrderSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(992, 961)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ORDERS"
        '
        'DataGridViewOrder
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOrder.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrder.Location = New System.Drawing.Point(242, 255)
        Me.DataGridViewOrder.Name = "DataGridViewOrder"
        Me.DataGridViewOrder.Size = New System.Drawing.Size(628, 493)
        Me.DataGridViewOrder.TabIndex = 7
        '
        'BtnUpdateOrder
        '
        Me.BtnUpdateOrder.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateOrder.FlatAppearance.BorderSize = 3
        Me.BtnUpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateOrder.Location = New System.Drawing.Point(7, 496)
        Me.BtnUpdateOrder.Name = "BtnUpdateOrder"
        Me.BtnUpdateOrder.Size = New System.Drawing.Size(213, 53)
        Me.BtnUpdateOrder.TabIndex = 5
        Me.BtnUpdateOrder.Text = "UPDATE ORDER"
        Me.BtnUpdateOrder.UseVisualStyleBackColor = False
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddOrder.FlatAppearance.BorderSize = 3
        Me.BtnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOrder.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOrder.ForeColor = System.Drawing.Color.White
        Me.BtnAddOrder.Location = New System.Drawing.Point(7, 364)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(213, 57)
        Me.BtnAddOrder.TabIndex = 0
        Me.BtnAddOrder.Text = "ADD ORDER"
        Me.BtnAddOrder.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(260, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(558, 75)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ORDER DETAILS"
        '
        'BtnSearchOrders
        '
        Me.BtnSearchOrders.BackColor = System.Drawing.Color.DimGray
        Me.BtnSearchOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearchOrders.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSearchOrders.Location = New System.Drawing.Point(876, 198)
        Me.BtnSearchOrders.Name = "BtnSearchOrders"
        Me.BtnSearchOrders.Size = New System.Drawing.Size(91, 35)
        Me.BtnSearchOrders.TabIndex = 3
        Me.BtnSearchOrders.Text = "Search"
        Me.BtnSearchOrders.UseVisualStyleBackColor = False
        '
        'TxtOrderSearch
        '
        Me.TxtOrderSearch.Location = New System.Drawing.Point(242, 197)
        Me.TxtOrderSearch.Name = "TxtOrderSearch"
        Me.TxtOrderSearch.Size = New System.Drawing.Size(628, 35)
        Me.TxtOrderSearch.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DimGray
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.BtnDeleteUser)
        Me.TabPage3.Controls.Add(Me.BtnUpdateUser)
        Me.TabPage3.Controls.Add(Me.DataGridViewUser)
        Me.TabPage3.Controls.Add(Me.BtnAddUser)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.BtnSearchUsers)
        Me.TabPage3.Controls.Add(Me.TxtUserSearch)
        Me.TabPage3.Location = New System.Drawing.Point(4, 35)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(992, 961)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "USERS"
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteUser.FlatAppearance.BorderSize = 3
        Me.BtnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteUser.Location = New System.Drawing.Point(31, 569)
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.Size = New System.Drawing.Size(197, 51)
        Me.BtnDeleteUser.TabIndex = 2
        Me.BtnDeleteUser.Text = "DELETE USER"
        Me.BtnDeleteUser.UseVisualStyleBackColor = False
        '
        'BtnUpdateUser
        '
        Me.BtnUpdateUser.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateUser.FlatAppearance.BorderSize = 3
        Me.BtnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateUser.Location = New System.Drawing.Point(31, 456)
        Me.BtnUpdateUser.Name = "BtnUpdateUser"
        Me.BtnUpdateUser.Size = New System.Drawing.Size(197, 57)
        Me.BtnUpdateUser.TabIndex = 1
        Me.BtnUpdateUser.Text = "UPDATE USER"
        Me.BtnUpdateUser.UseVisualStyleBackColor = False
        '
        'DataGridViewUser
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Location = New System.Drawing.Point(250, 293)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.Size = New System.Drawing.Size(520, 468)
        Me.DataGridViewUser.TabIndex = 7
        '
        'BtnAddUser
        '
        Me.BtnAddUser.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddUser.FlatAppearance.BorderSize = 3
        Me.BtnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddUser.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddUser.ForeColor = System.Drawing.Color.White
        Me.BtnAddUser.Location = New System.Drawing.Point(31, 334)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(197, 55)
        Me.BtnAddUser.TabIndex = 0
        Me.BtnAddUser.Text = "ADD USER"
        Me.BtnAddUser.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(247, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(498, 75)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "USER DETAILS"
        '
        'BtnSearchUsers
        '
        Me.BtnSearchUsers.BackColor = System.Drawing.Color.DimGray
        Me.BtnSearchUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSearchUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearchUsers.FlatAppearance.BorderSize = 3
        Me.BtnSearchUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchUsers.Location = New System.Drawing.Point(796, 190)
        Me.BtnSearchUsers.Name = "BtnSearchUsers"
        Me.BtnSearchUsers.Size = New System.Drawing.Size(114, 35)
        Me.BtnSearchUsers.TabIndex = 3
        Me.BtnSearchUsers.Text = "Search"
        Me.BtnSearchUsers.UseVisualStyleBackColor = False
        '
        'TxtUserSearch
        '
        Me.TxtUserSearch.Location = New System.Drawing.Point(250, 191)
        Me.TxtUserSearch.Name = "TxtUserSearch"
        Me.TxtUserSearch.Size = New System.Drawing.Size(520, 35)
        Me.TxtUserSearch.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DimGray
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.BtnDeleteOffers)
        Me.TabPage4.Controls.Add(Me.BtnUpdateOffers)
        Me.TabPage4.Controls.Add(Me.DataGridViewOffer)
        Me.TabPage4.Controls.Add(Me.BtnAddOffer)
        Me.TabPage4.Controls.Add(Me.BtnSearchOffers)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage4.Location = New System.Drawing.Point(4, 35)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(992, 961)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "OFFERS"
        '
        'BtnDeleteOffers
        '
        Me.BtnDeleteOffers.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeleteOffers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteOffers.FlatAppearance.BorderSize = 3
        Me.BtnDeleteOffers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDeleteOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteOffers.Location = New System.Drawing.Point(18, 614)
        Me.BtnDeleteOffers.Name = "BtnDeleteOffers"
        Me.BtnDeleteOffers.Size = New System.Drawing.Size(237, 52)
        Me.BtnDeleteOffers.TabIndex = 3
        Me.BtnDeleteOffers.Text = "DELETE OFFERS"
        Me.BtnDeleteOffers.UseVisualStyleBackColor = False
        '
        'BtnUpdateOffers
        '
        Me.BtnUpdateOffers.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdateOffers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateOffers.FlatAppearance.BorderSize = 3
        Me.BtnUpdateOffers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateOffers.Location = New System.Drawing.Point(18, 494)
        Me.BtnUpdateOffers.Name = "BtnUpdateOffers"
        Me.BtnUpdateOffers.Size = New System.Drawing.Size(237, 51)
        Me.BtnUpdateOffers.TabIndex = 2
        Me.BtnUpdateOffers.Text = "UPDATE OFFERS"
        Me.BtnUpdateOffers.UseVisualStyleBackColor = False
        '
        'DataGridViewOffer
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewOffer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewOffer.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewOffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOffer.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewOffer.Location = New System.Drawing.Point(275, 293)
        Me.DataGridViewOffer.Name = "DataGridViewOffer"
        Me.DataGridViewOffer.Size = New System.Drawing.Size(541, 536)
        Me.DataGridViewOffer.TabIndex = 5
        '
        'BtnAddOffer
        '
        Me.BtnAddOffer.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddOffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddOffer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddOffer.FlatAppearance.BorderSize = 3
        Me.BtnAddOffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOffer.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOffer.ForeColor = System.Drawing.Color.White
        Me.BtnAddOffer.Location = New System.Drawing.Point(18, 374)
        Me.BtnAddOffer.Name = "BtnAddOffer"
        Me.BtnAddOffer.Size = New System.Drawing.Size(237, 57)
        Me.BtnAddOffer.TabIndex = 1
        Me.BtnAddOffer.Text = "ADD OFFERS"
        Me.BtnAddOffer.UseVisualStyleBackColor = False
        '
        'BtnSearchOffers
        '
        Me.BtnSearchOffers.BackColor = System.Drawing.Color.DimGray
        Me.BtnSearchOffers.FlatAppearance.BorderSize = 3
        Me.BtnSearchOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchOffers.Location = New System.Drawing.Point(829, 220)
        Me.BtnSearchOffers.Name = "BtnSearchOffers"
        Me.BtnSearchOffers.Size = New System.Drawing.Size(128, 35)
        Me.BtnSearchOffers.TabIndex = 4
        Me.BtnSearchOffers.Text = "Search"
        Me.BtnSearchOffers.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(276, 221)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(540, 35)
        Me.TextBox3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(261, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(546, 75)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OFFER DETAILS"
        '
        'GetWellmedsdatabaseDataSet1
        '
        Me.GetWellmedsdatabaseDataSet1.DataSetName = "GetWellmedsdatabaseDataSet"
        Me.GetWellmedsdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 865)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "ADMIN"
        Me.Text = "ADMIN"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewOffer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetWellmedsdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents BtnAddMedicine As Button
    Friend WithEvents TxtMedicineSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents BtnSearchOrders As Button
    Friend WithEvents TxtOrderSearch As TextBox
    Friend WithEvents BtnSearchUsers As Button
    Friend WithEvents TxtUserSearch As TextBox
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddOffer As Button
    Friend WithEvents BtnAddCategory As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSearchMedicine As Button
    Friend WithEvents DataGridViewMedicine As DataGridView
    Friend WithEvents GetWellmedsdatabaseDataSet1 As GetWellmedsdatabaseDataSet
    Friend WithEvents DataGridViewUser As DataGridView
    Friend WithEvents BtnUpdateMedicine As Button
    Friend WithEvents BtnSearchOffers As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridViewOffer As DataGridView
    Friend WithEvents BtnUpdateOrder As Button
    Friend WithEvents BtnDeleteMedicine As Button
    Friend WithEvents BtnDeleteUser As Button
    Friend WithEvents BtnUpdateUser As Button
    Friend WithEvents BtnDeleteOffers As Button
    Friend WithEvents BtnUpdateOffers As Button
    Friend WithEvents DataGridViewOrder As DataGridView
End Class
