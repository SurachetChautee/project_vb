<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
    Inherits System.Windows.Forms.Form

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
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_showpassword = New System.Windows.Forms.TextBox()
        Me.txt_showusername = New System.Windows.Forms.TextBox()
        Me.txt_showtel = New System.Windows.Forms.TextBox()
        Me.txt_showlastname = New System.Windows.Forms.TextBox()
        Me.txt_showname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_add_password = New System.Windows.Forms.TextBox()
        Me.txt_add_username = New System.Windows.Forms.TextBox()
        Me.txt_add_tel = New System.Windows.Forms.TextBox()
        Me.txt_add_lastname = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_username = New System.Windows.Forms.TextBox()
        Me.txt_edit_tel = New System.Windows.Forms.TextBox()
        Me.txt_edit_lastname = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datagrid_search)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 490)
        Me.Panel1.TabIndex = 0
        '
        'datagrid_search
        '
        Me.datagrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_search.Location = New System.Drawing.Point(0, 83)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.RowHeadersVisible = False
        Me.datagrid_search.RowTemplate.Height = 24
        Me.datagrid_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_search.Size = New System.Drawing.Size(269, 407)
        Me.datagrid_search.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 83)
        Me.Panel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(269, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(503, 490)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_showpassword)
        Me.TabPage1.Controls.Add(Me.txt_showusername)
        Me.TabPage1.Controls.Add(Me.txt_showtel)
        Me.TabPage1.Controls.Add(Me.txt_showlastname)
        Me.TabPage1.Controls.Add(Me.txt_showname)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(495, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "แสดงข้อมูล"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_showpassword
        '
        Me.txt_showpassword.Enabled = False
        Me.txt_showpassword.Location = New System.Drawing.Point(135, 271)
        Me.txt_showpassword.Name = "txt_showpassword"
        Me.txt_showpassword.Size = New System.Drawing.Size(196, 30)
        Me.txt_showpassword.TabIndex = 9
        '
        'txt_showusername
        '
        Me.txt_showusername.Enabled = False
        Me.txt_showusername.Location = New System.Drawing.Point(135, 217)
        Me.txt_showusername.Name = "txt_showusername"
        Me.txt_showusername.Size = New System.Drawing.Size(196, 30)
        Me.txt_showusername.TabIndex = 8
        '
        'txt_showtel
        '
        Me.txt_showtel.Enabled = False
        Me.txt_showtel.Location = New System.Drawing.Point(135, 161)
        Me.txt_showtel.Name = "txt_showtel"
        Me.txt_showtel.Size = New System.Drawing.Size(196, 30)
        Me.txt_showtel.TabIndex = 7
        '
        'txt_showlastname
        '
        Me.txt_showlastname.Enabled = False
        Me.txt_showlastname.Location = New System.Drawing.Point(135, 104)
        Me.txt_showlastname.Name = "txt_showlastname"
        Me.txt_showlastname.Size = New System.Drawing.Size(196, 30)
        Me.txt_showlastname.TabIndex = 6
        '
        'txt_showname
        '
        Me.txt_showname.Enabled = False
        Me.txt_showname.Location = New System.Drawing.Point(135, 50)
        Me.txt_showname.Name = "txt_showname"
        Me.txt_showname.Size = New System.Drawing.Size(196, 30)
        Me.txt_showname.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "เบอร์โทรศัพท์"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txt_add_password)
        Me.TabPage2.Controls.Add(Me.txt_add_username)
        Me.TabPage2.Controls.Add(Me.txt_add_tel)
        Me.TabPage2.Controls.Add(Me.txt_add_lastname)
        Me.TabPage2.Controls.Add(Me.txt_add_name)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Font = New System.Drawing.Font("FC Active", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(495, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่ม"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("FC Active", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(250, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 30)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("FC Active", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(138, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 30)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_add_password
        '
        Me.txt_add_password.Location = New System.Drawing.Point(138, 268)
        Me.txt_add_password.Name = "txt_add_password"
        Me.txt_add_password.Size = New System.Drawing.Size(196, 24)
        Me.txt_add_password.TabIndex = 19
        '
        'txt_add_username
        '
        Me.txt_add_username.Location = New System.Drawing.Point(138, 214)
        Me.txt_add_username.Name = "txt_add_username"
        Me.txt_add_username.Size = New System.Drawing.Size(196, 24)
        Me.txt_add_username.TabIndex = 18
        '
        'txt_add_tel
        '
        Me.txt_add_tel.Location = New System.Drawing.Point(138, 158)
        Me.txt_add_tel.Name = "txt_add_tel"
        Me.txt_add_tel.Size = New System.Drawing.Size(196, 24)
        Me.txt_add_tel.TabIndex = 17
        '
        'txt_add_lastname
        '
        Me.txt_add_lastname.Location = New System.Drawing.Point(138, 101)
        Me.txt_add_lastname.Name = "txt_add_lastname"
        Me.txt_add_lastname.Size = New System.Drawing.Size(196, 24)
        Me.txt_add_lastname.TabIndex = 16
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(138, 47)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(196, 24)
        Me.txt_add_name.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "เบอร์โทรศัพท์"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 24)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "นามสกุล"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ชื่อ"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Font = New System.Drawing.Font("FC Active", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(495, 453)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(107, 120)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 29)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.btn_edit)
        Me.TabPage4.Controls.Add(Me.txt_edit_password)
        Me.TabPage4.Controls.Add(Me.txt_edit_username)
        Me.TabPage4.Controls.Add(Me.txt_edit_tel)
        Me.TabPage4.Controls.Add(Me.txt_edit_lastname)
        Me.TabPage4.Controls.Add(Me.txt_edit_name)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Font = New System.Drawing.Font("FC Active", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(495, 453)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "แก้ไข"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("FC Active", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(250, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 30)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "เคลียร์"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("FC Active", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(138, 323)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(84, 30)
        Me.btn_edit.TabIndex = 32
        Me.btn_edit.Text = "เพิ่ม"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(138, 258)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(196, 24)
        Me.txt_edit_password.TabIndex = 31
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Location = New System.Drawing.Point(138, 204)
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(196, 24)
        Me.txt_edit_username.TabIndex = 30
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Location = New System.Drawing.Point(138, 148)
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(196, 24)
        Me.txt_edit_tel.TabIndex = 29
        '
        'txt_edit_lastname
        '
        Me.txt_edit_lastname.Location = New System.Drawing.Point(138, 91)
        Me.txt_edit_lastname.Name = "txt_edit_lastname"
        Me.txt_edit_lastname.Size = New System.Drawing.Size(196, 24)
        Me.txt_edit_lastname.TabIndex = 28
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(138, 37)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(196, 24)
        Me.txt_edit_name.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 24)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "เบอร์โทรศัพท์"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 24)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 24)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Username"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 24)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "นามสกุล"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 24)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "ชื่อ"
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 490)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "employee"
        Me.Text = "employee"
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagrid_search As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txt_showpassword As TextBox
    Friend WithEvents txt_showusername As TextBox
    Friend WithEvents txt_showtel As TextBox
    Friend WithEvents txt_showlastname As TextBox
    Friend WithEvents txt_showname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_add_password As TextBox
    Friend WithEvents txt_add_username As TextBox
    Friend WithEvents txt_add_tel As TextBox
    Friend WithEvents txt_add_lastname As TextBox
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_username As TextBox
    Friend WithEvents txt_edit_tel As TextBox
    Friend WithEvents txt_edit_lastname As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
