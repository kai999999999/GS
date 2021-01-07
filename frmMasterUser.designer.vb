<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterUser))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtEmpID = New System.Windows.Forms.TextBox
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.btnFindEmp = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnFindUser = New System.Windows.Forms.Button
        Me.rbtInactive = New System.Windows.Forms.RadioButton
        Me.rbtActive = New System.Windows.Forms.RadioButton
        Me.txtPasswordAgain = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkSys1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkSys4 = New System.Windows.Forms.CheckBox
        Me.chkSys3 = New System.Windows.Forms.CheckBox
        Me.chkSys2 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkWip15 = New System.Windows.Forms.CheckBox
        Me.chkWip14 = New System.Windows.Forms.CheckBox
        Me.chkWip13 = New System.Windows.Forms.CheckBox
        Me.chkWip12 = New System.Windows.Forms.CheckBox
        Me.chkWip11 = New System.Windows.Forms.CheckBox
        Me.chkWip10 = New System.Windows.Forms.CheckBox
        Me.chkWip9 = New System.Windows.Forms.CheckBox
        Me.chkWip8 = New System.Windows.Forms.CheckBox
        Me.chkWip7 = New System.Windows.Forms.CheckBox
        Me.chkWip6 = New System.Windows.Forms.CheckBox
        Me.chkWip5 = New System.Windows.Forms.CheckBox
        Me.chkWip4 = New System.Windows.Forms.CheckBox
        Me.chkWip3 = New System.Windows.Forms.CheckBox
        Me.chkWip2 = New System.Windows.Forms.CheckBox
        Me.chkWip1 = New System.Windows.Forms.CheckBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee"
        '
        'txtUserID
        '
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(91, 8)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(122, 22)
        Me.txtUserID.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(91, 38)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(122, 22)
        Me.txtPassword.TabIndex = 3
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(91, 66)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(122, 22)
        Me.txtEmpID.TabIndex = 5
        '
        'txtEmpName
        '
        Me.txtEmpName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(250, 66)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(301, 22)
        Me.txtEmpName.TabIndex = 7
        '
        'btnFindEmp
        '
        Me.btnFindEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindEmp.Image = CType(resources.GetObject("btnFindEmp.Image"), System.Drawing.Image)
        Me.btnFindEmp.Location = New System.Drawing.Point(215, 63)
        Me.btnFindEmp.Name = "btnFindEmp"
        Me.btnFindEmp.Size = New System.Drawing.Size(29, 29)
        Me.btnFindEmp.TabIndex = 6
        Me.btnFindEmp.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(250, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(62, 29)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "เพิ่ม"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(329, 8)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(101, 20)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "*** NEW ***"
        '
        'btnFindUser
        '
        Me.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindUser.Image = CType(resources.GetObject("btnFindUser.Image"), System.Drawing.Image)
        Me.btnFindUser.Location = New System.Drawing.Point(215, 5)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(29, 29)
        Me.btnFindUser.TabIndex = 1
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'rbtInactive
        '
        Me.rbtInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbtInactive.AutoSize = True
        Me.rbtInactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbtInactive.ForeColor = System.Drawing.Color.Red
        Me.rbtInactive.Location = New System.Drawing.Point(158, 272)
        Me.rbtInactive.Name = "rbtInactive"
        Me.rbtInactive.Size = New System.Drawing.Size(76, 17)
        Me.rbtInactive.TabIndex = 8
        Me.rbtInactive.Text = "ไม่ใช้งาน"
        Me.rbtInactive.UseVisualStyleBackColor = True
        '
        'rbtActive
        '
        Me.rbtActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbtActive.AutoSize = True
        Me.rbtActive.Checked = True
        Me.rbtActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbtActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbtActive.Location = New System.Drawing.Point(91, 272)
        Me.rbtActive.Name = "rbtActive"
        Me.rbtActive.Size = New System.Drawing.Size(61, 17)
        Me.rbtActive.TabIndex = 7
        Me.rbtActive.TabStop = True
        Me.rbtActive.Text = "ใช้งาน"
        Me.rbtActive.UseVisualStyleBackColor = True
        '
        'txtPasswordAgain
        '
        Me.txtPasswordAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPasswordAgain.Location = New System.Drawing.Point(323, 38)
        Me.txtPasswordAgain.Name = "txtPasswordAgain"
        Me.txtPasswordAgain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAgain.Size = New System.Drawing.Size(135, 22)
        Me.txtPasswordAgain.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password again"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Permission"
        '
        'chkSys1
        '
        Me.chkSys1.AutoSize = True
        Me.chkSys1.Location = New System.Drawing.Point(6, 21)
        Me.chkSys1.Name = "chkSys1"
        Me.chkSys1.Size = New System.Drawing.Size(105, 20)
        Me.chkSys1.TabIndex = 13
        Me.chkSys1.Text = "Configuration"
        Me.chkSys1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkSys4)
        Me.GroupBox1.Controls.Add(Me.chkSys3)
        Me.GroupBox1.Controls.Add(Me.chkSys2)
        Me.GroupBox1.Controls.Add(Me.chkSys1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(87, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 163)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Systems"
        '
        'chkSys4
        '
        Me.chkSys4.AutoSize = True
        Me.chkSys4.Location = New System.Drawing.Point(6, 99)
        Me.chkSys4.Name = "chkSys4"
        Me.chkSys4.Size = New System.Drawing.Size(127, 20)
        Me.chkSys4.TabIndex = 16
        Me.chkSys4.Text = "User/Permission"
        Me.chkSys4.UseVisualStyleBackColor = True
        '
        'chkSys3
        '
        Me.chkSys3.AutoSize = True
        Me.chkSys3.Location = New System.Drawing.Point(6, 73)
        Me.chkSys3.Name = "chkSys3"
        Me.chkSys3.Size = New System.Drawing.Size(79, 20)
        Me.chkSys3.TabIndex = 15
        Me.chkSys3.Text = "ข้อมูลแผนก"
        Me.chkSys3.UseVisualStyleBackColor = True
        '
        'chkSys2
        '
        Me.chkSys2.AutoSize = True
        Me.chkSys2.Location = New System.Drawing.Point(6, 47)
        Me.chkSys2.Name = "chkSys2"
        Me.chkSys2.Size = New System.Drawing.Size(92, 20)
        Me.chkSys2.TabIndex = 14
        Me.chkSys2.Text = "ข้อมูลพนักงาน"
        Me.chkSys2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.chkWip15)
        Me.GroupBox2.Controls.Add(Me.chkWip14)
        Me.GroupBox2.Controls.Add(Me.chkWip13)
        Me.GroupBox2.Controls.Add(Me.chkWip12)
        Me.GroupBox2.Controls.Add(Me.chkWip11)
        Me.GroupBox2.Controls.Add(Me.chkWip10)
        Me.GroupBox2.Controls.Add(Me.chkWip9)
        Me.GroupBox2.Controls.Add(Me.chkWip8)
        Me.GroupBox2.Controls.Add(Me.chkWip7)
        Me.GroupBox2.Controls.Add(Me.chkWip6)
        Me.GroupBox2.Controls.Add(Me.chkWip5)
        Me.GroupBox2.Controls.Add(Me.chkWip4)
        Me.GroupBox2.Controls.Add(Me.chkWip3)
        Me.GroupBox2.Controls.Add(Me.chkWip2)
        Me.GroupBox2.Controls.Add(Me.chkWip1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(275, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 163)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Work in process"
        '
        'chkWip15
        '
        Me.chkWip15.AutoSize = True
        Me.chkWip15.Location = New System.Drawing.Point(183, 125)
        Me.chkWip15.Name = "chkWip15"
        Me.chkWip15.Size = New System.Drawing.Size(36, 20)
        Me.chkWip15.TabIndex = 27
        Me.chkWip15.Text = "..."
        Me.chkWip15.UseVisualStyleBackColor = True
        Me.chkWip15.Visible = False
        '
        'chkWip14
        '
        Me.chkWip14.AutoSize = True
        Me.chkWip14.Location = New System.Drawing.Point(183, 99)
        Me.chkWip14.Name = "chkWip14"
        Me.chkWip14.Size = New System.Drawing.Size(36, 20)
        Me.chkWip14.TabIndex = 26
        Me.chkWip14.Text = "..."
        Me.chkWip14.UseVisualStyleBackColor = True
        Me.chkWip14.Visible = False
        '
        'chkWip13
        '
        Me.chkWip13.AutoSize = True
        Me.chkWip13.Location = New System.Drawing.Point(183, 73)
        Me.chkWip13.Name = "chkWip13"
        Me.chkWip13.Size = New System.Drawing.Size(36, 20)
        Me.chkWip13.TabIndex = 25
        Me.chkWip13.Text = "..."
        Me.chkWip13.UseVisualStyleBackColor = True
        Me.chkWip13.Visible = False
        '
        'chkWip12
        '
        Me.chkWip12.AutoSize = True
        Me.chkWip12.Location = New System.Drawing.Point(183, 47)
        Me.chkWip12.Name = "chkWip12"
        Me.chkWip12.Size = New System.Drawing.Size(62, 20)
        Me.chkWip12.TabIndex = 24
        Me.chkWip12.Text = "รายงาน"
        Me.chkWip12.UseVisualStyleBackColor = True
        '
        'chkWip11
        '
        Me.chkWip11.AutoSize = True
        Me.chkWip11.Location = New System.Drawing.Point(183, 21)
        Me.chkWip11.Name = "chkWip11"
        Me.chkWip11.Size = New System.Drawing.Size(79, 20)
        Me.chkWip11.TabIndex = 23
        Me.chkWip11.Text = "Barcode"
        Me.chkWip11.UseVisualStyleBackColor = True
        '
        'chkWip10
        '
        Me.chkWip10.AutoSize = True
        Me.chkWip10.Location = New System.Drawing.Point(96, 125)
        Me.chkWip10.Name = "chkWip10"
        Me.chkWip10.Size = New System.Drawing.Size(59, 20)
        Me.chkWip10.TabIndex = 22
        Me.chkWip10.Text = "ลงทอง"
        Me.chkWip10.UseVisualStyleBackColor = True
        '
        'chkWip9
        '
        Me.chkWip9.AutoSize = True
        Me.chkWip9.Location = New System.Drawing.Point(96, 99)
        Me.chkWip9.Name = "chkWip9"
        Me.chkWip9.Size = New System.Drawing.Size(48, 20)
        Me.chkWip9.TabIndex = 21
        Me.chkWip9.Text = "เลื่อย"
        Me.chkWip9.UseVisualStyleBackColor = True
        '
        'chkWip8
        '
        Me.chkWip8.AutoSize = True
        Me.chkWip8.Location = New System.Drawing.Point(96, 73)
        Me.chkWip8.Name = "chkWip8"
        Me.chkWip8.Size = New System.Drawing.Size(50, 20)
        Me.chkWip8.TabIndex = 20
        Me.chkWip8.Text = "เชื่อม"
        Me.chkWip8.UseVisualStyleBackColor = True
        '
        'chkWip7
        '
        Me.chkWip7.AutoSize = True
        Me.chkWip7.Location = New System.Drawing.Point(96, 47)
        Me.chkWip7.Name = "chkWip7"
        Me.chkWip7.Size = New System.Drawing.Size(41, 20)
        Me.chkWip7.TabIndex = 19
        Me.chkWip7.Text = "ทอ"
        Me.chkWip7.UseVisualStyleBackColor = True
        '
        'chkWip6
        '
        Me.chkWip6.AutoSize = True
        Me.chkWip6.Location = New System.Drawing.Point(96, 21)
        Me.chkWip6.Name = "chkWip6"
        Me.chkWip6.Size = New System.Drawing.Size(46, 20)
        Me.chkWip6.TabIndex = 18
        Me.chkWip6.Text = "ลดรู"
        Me.chkWip6.UseVisualStyleBackColor = True
        '
        'chkWip5
        '
        Me.chkWip5.AutoSize = True
        Me.chkWip5.Location = New System.Drawing.Point(6, 125)
        Me.chkWip5.Name = "chkWip5"
        Me.chkWip5.Size = New System.Drawing.Size(54, 20)
        Me.chkWip5.TabIndex = 17
        Me.chkWip5.Text = "ลงเตา"
        Me.chkWip5.UseVisualStyleBackColor = True
        '
        'chkWip4
        '
        Me.chkWip4.AutoSize = True
        Me.chkWip4.Location = New System.Drawing.Point(6, 99)
        Me.chkWip4.Name = "chkWip4"
        Me.chkWip4.Size = New System.Drawing.Size(71, 20)
        Me.chkWip4.TabIndex = 16
        Me.chkWip4.Text = "แต่งสร้อย"
        Me.chkWip4.UseVisualStyleBackColor = True
        '
        'chkWip3
        '
        Me.chkWip3.AutoSize = True
        Me.chkWip3.Location = New System.Drawing.Point(6, 73)
        Me.chkWip3.Name = "chkWip3"
        Me.chkWip3.Size = New System.Drawing.Size(58, 20)
        Me.chkWip3.TabIndex = 15
        Me.chkWip3.Text = "ส่งร้อย"
        Me.chkWip3.UseVisualStyleBackColor = True
        '
        'chkWip2
        '
        Me.chkWip2.AutoSize = True
        Me.chkWip2.Location = New System.Drawing.Point(6, 47)
        Me.chkWip2.Name = "chkWip2"
        Me.chkWip2.Size = New System.Drawing.Size(61, 20)
        Me.chkWip2.TabIndex = 14
        Me.chkWip2.Text = "ตัดห่วง"
        Me.chkWip2.UseVisualStyleBackColor = True
        '
        'chkWip1
        '
        Me.chkWip1.AutoSize = True
        Me.chkWip1.Location = New System.Drawing.Point(6, 21)
        Me.chkWip1.Name = "chkWip1"
        Me.chkWip1.Size = New System.Drawing.Size(59, 20)
        Me.chkWip1.TabIndex = 13
        Me.chkWip1.Text = "ชักลวด"
        Me.chkWip1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelete)
        Me.Panel7.Controls.Add(Me.btnClose)
        Me.Panel7.Controls.Add(Me.btnSave)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 298)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(554, 39)
        Me.Panel7.TabIndex = 27
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(88, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 33)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.Color.Blue
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(484, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "ปิด"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmMasterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 337)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPasswordAgain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbtInactive)
        Me.Controls.Add(Me.rbtActive)
        Me.Controls.Add(Me.btnFindUser)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnFindEmp)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(560, 365)
        Me.Name = "frmMasterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents btnFindEmp As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnFindUser As System.Windows.Forms.Button
    Friend WithEvents rbtInactive As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActive As System.Windows.Forms.RadioButton
    Friend WithEvents txtPasswordAgain As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkSys1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSys4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSys3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSys2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkWip4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip12 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkWip5 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
