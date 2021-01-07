<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessReduce
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessReduce))
        Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
        Dim NumberCellType1 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType2 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType3 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType4 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType5 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType6 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType7 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType8 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.fpReduce = New FarPoint.Win.Spread.FpSpread
        Me.fpReduce_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.fpTotal = New FarPoint.Win.Spread.FpSpread
        Me.fpTotal_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBarcodeName = New System.Windows.Forms.TextBox
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtLotName = New System.Windows.Forms.TextBox
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBarcodeID = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fpReduce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpReduce_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fpTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpTotal_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(635, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "ตั้งค่าเครื่องชั่งเป็นศูนย์"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(10, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 41)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "เพิ่มรายการ"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(173, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 41)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "แก้ไข"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(64, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 39)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "บันทึก"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.GreenYellow
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(179, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(370, 38)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "น้ำหนักเก็บครบ ส่งต่อทอทั้งหมด"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel2.Text = "TAROTE"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel5.Text = "M123"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(64, 17)
        Me.ToolStripStatusLabel1.Text = "ชื่อผู้ใช้งาน :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Enabled = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(834, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel4.Text = "เครื่องชั่ง :"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(766, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(63, 43)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "ปิด"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(560, 1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(72, 43)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "ค้นหา"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("#ZF Diffx", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ลดรู"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.fpReduce)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 333)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายการลดรู"
        '
        'fpReduce
        '
        Me.fpReduce.AccessibleDescription = "fpReduce, Sheet1, Row 0, Column 0, "
        Me.fpReduce.BackColor = System.Drawing.SystemColors.Control
        Me.fpReduce.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpReduce.EditModeReplace = True
        Me.fpReduce.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpReduce.Location = New System.Drawing.Point(3, 16)
        Me.fpReduce.Margin = New System.Windows.Forms.Padding(4)
        Me.fpReduce.Name = "fpReduce"
        Me.fpReduce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpReduce.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpReduce_Sheet1})
        Me.fpReduce.Size = New System.Drawing.Size(552, 194)
        Me.fpReduce.TabIndex = 19
        Me.fpReduce.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpReduce_Sheet1
        '
        Me.fpReduce_Sheet1.Reset()
        Me.fpReduce_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpReduce_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpReduce_Sheet1.ColumnCount = 8
        Me.fpReduce_Sheet1.RowCount = 1
        Me.fpReduce_Sheet1.Cells.Get(0, 3).Value = 0
        Me.fpReduce_Sheet1.Cells.Get(0, 4).Value = 0
        Me.fpReduce_Sheet1.Cells.Get(0, 5).Value = 0
        Me.fpReduce_Sheet1.Cells.Get(0, 6).Value = 0
        Me.fpReduce_Sheet1.Cells.Get(0, 7).Value = 0
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "รหัสงานย่อย"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "ชื่อคนชัก"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "วันที่"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "น้ำหนักส่งลดรู"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "น้ำหนัก Roll"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "น้ำหนักรวม"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "น้ำหนัก Roll+ลวด"
        Me.fpReduce_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "สรุปหาย"
        Me.fpReduce_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpReduce_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(0).Label = "รหัสงานย่อย"
        Me.fpReduce_Sheet1.Columns.Get(0).Locked = True
        Me.fpReduce_Sheet1.Columns.Get(0).Width = 57.0!
        Me.fpReduce_Sheet1.Columns.Get(1).Label = "ชื่อคนชัก"
        Me.fpReduce_Sheet1.Columns.Get(1).Locked = True
        DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
        DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
        DateTimeCellType1.DateDefault = New Date(2019, 9, 26, 22, 20, 50, 0)
        DateTimeCellType1.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
        DateTimeCellType1.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
        DateTimeCellType1.TimeDefault = New Date(2019, 9, 26, 22, 20, 50, 0)
        DateTimeCellType1.UserDefinedFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fpReduce_Sheet1.Columns.Get(2).CellType = DateTimeCellType1
        Me.fpReduce_Sheet1.Columns.Get(2).Label = "วันที่"
        Me.fpReduce_Sheet1.Columns.Get(2).Locked = True
        NumberCellType1.DecimalPlaces = 2
        NumberCellType1.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType1.NegativeRed = True
        NumberCellType1.ShowSeparator = True
        Me.fpReduce_Sheet1.Columns.Get(3).CellType = NumberCellType1
        Me.fpReduce_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(3).Label = "น้ำหนักส่งลดรู"
        Me.fpReduce_Sheet1.Columns.Get(3).Locked = True
        NumberCellType2.DecimalPlaces = 2
        NumberCellType2.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType2.NegativeRed = True
        NumberCellType2.ShowSeparator = True
        Me.fpReduce_Sheet1.Columns.Get(4).CellType = NumberCellType2
        Me.fpReduce_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(4).Label = "น้ำหนัก Roll"
        Me.fpReduce_Sheet1.Columns.Get(4).Locked = True
        NumberCellType3.DecimalPlaces = 2
        NumberCellType3.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType3.NegativeRed = True
        NumberCellType3.ShowSeparator = True
        Me.fpReduce_Sheet1.Columns.Get(5).CellType = NumberCellType3
        Me.fpReduce_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(5).Label = "น้ำหนักรวม"
        Me.fpReduce_Sheet1.Columns.Get(5).Locked = True
        NumberCellType4.DecimalPlaces = 2
        NumberCellType4.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType4.NegativeRed = True
        NumberCellType4.ShowSeparator = True
        Me.fpReduce_Sheet1.Columns.Get(6).CellType = NumberCellType4
        Me.fpReduce_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(6).Label = "น้ำหนัก Roll+ลวด"
        Me.fpReduce_Sheet1.Columns.Get(6).Locked = True
        NumberCellType5.DecimalPlaces = 2
        NumberCellType5.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType5.NegativeRed = True
        NumberCellType5.ShowSeparator = True
        Me.fpReduce_Sheet1.Columns.Get(7).CellType = NumberCellType5
        Me.fpReduce_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReduce_Sheet1.Columns.Get(7).Label = "สรุปหาย"
        Me.fpReduce_Sheet1.Columns.Get(7).Locked = True
        Me.fpReduce_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpReduce_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpReduce_Sheet1.RowHeader.Columns.Get(0).Width = 38.0!
        Me.fpReduce_Sheet1.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReduce_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.fpTotal)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 120)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รวม"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.Enabled = False
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(3, 79)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(170, 37)
        Me.Button10.TabIndex = 37
        Me.Button10.Text = "ส่งกลับชักลวด"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = False
        '
        'fpTotal
        '
        Me.fpTotal.AccessibleDescription = "fpTotal, Sheet1, Row 0, Column 0, 0.00"
        Me.fpTotal.BackColor = System.Drawing.SystemColors.Control
        Me.fpTotal.EditModeReplace = True
        Me.fpTotal.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpTotal.Location = New System.Drawing.Point(3, 16)
        Me.fpTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.fpTotal.Name = "fpTotal"
        Me.fpTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpTotal.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpTotal_Sheet1})
        Me.fpTotal.Size = New System.Drawing.Size(546, 62)
        Me.fpTotal.TabIndex = 20
        Me.fpTotal.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpTotal_Sheet1
        '
        Me.fpTotal_Sheet1.Reset()
        Me.fpTotal_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpTotal_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpTotal_Sheet1.ColumnCount = 3
        Me.fpTotal_Sheet1.RowCount = 1
        Me.fpTotal_Sheet1.Cells.Get(0, 0).Value = 0
        Me.fpTotal_Sheet1.Cells.Get(0, 1).Value = 0
        Me.fpTotal_Sheet1.Cells.Get(0, 2).Formula = "RC[-2]-RC[-1]"
        Me.fpTotal_Sheet1.Cells.Get(0, 2).Value = 0
        Me.fpTotal_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "น้ำหนักส่งลดรู"
        Me.fpTotal_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "น้ำหนักลดรูแล้ว"
        Me.fpTotal_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "สรุปหาย"
        Me.fpTotal_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        NumberCellType6.DecimalPlaces = 2
        NumberCellType6.MaximumValue = 99999999999999
        NumberCellType6.NegativeRed = True
        NumberCellType6.ShowSeparator = True
        Me.fpTotal_Sheet1.Columns.Get(0).CellType = NumberCellType6
        Me.fpTotal_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTotal_Sheet1.Columns.Get(0).Label = "น้ำหนักส่งลดรู"
        Me.fpTotal_Sheet1.Columns.Get(0).Locked = True
        Me.fpTotal_Sheet1.Columns.Get(0).Width = 86.0!
        NumberCellType7.DecimalPlaces = 2
        NumberCellType7.MaximumValue = 99999999999999
        NumberCellType7.NegativeRed = True
        NumberCellType7.ShowSeparator = True
        Me.fpTotal_Sheet1.Columns.Get(1).CellType = NumberCellType7
        Me.fpTotal_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTotal_Sheet1.Columns.Get(1).Label = "น้ำหนักลดรูแล้ว"
        Me.fpTotal_Sheet1.Columns.Get(1).Locked = True
        Me.fpTotal_Sheet1.Columns.Get(1).Width = 86.0!
        NumberCellType8.DecimalPlaces = 2
        NumberCellType8.MaximumValue = 99999999999999
        NumberCellType8.NegativeRed = True
        NumberCellType8.ShowSeparator = True
        Me.fpTotal_Sheet1.Columns.Get(2).CellType = NumberCellType8
        Me.fpTotal_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTotal_Sheet1.Columns.Get(2).Label = "สรุปหาย"
        Me.fpTotal_Sheet1.Columns.Get(2).Locked = True
        Me.fpTotal_Sheet1.Columns.Get(2).Width = 86.0!
        Me.fpTotal_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.[ReadOnly]
        Me.fpTotal_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpTotal_Sheet1.RowHeader.Columns.Get(0).Width = 38.0!
        Me.fpTotal_Sheet1.RowHeader.Visible = False
        Me.fpTotal_Sheet1.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpTotal_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(575, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 337)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายการชั่ง"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.txtUser)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.txtCode)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 57)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(234, 96)
        Me.GroupBox7.TabIndex = 23
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "รายการตัดห่วง"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(89, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "วันที่สร้างงาน :"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(89, 45)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(109, 20)
        Me.txtUser.TabIndex = 5
        Me.txtUser.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "ชื่อคนชัก :"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(89, 19)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(109, 20)
        Me.txtCode.TabIndex = 3
        Me.txtCode.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "รหัสงานย่อย :"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.TextBox9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.TextBox10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 147)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(234, 184)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.Enabled = False
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(149, 139)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(79, 39)
        Me.Button9.TabIndex = 35
        Me.Button9.Text = "ยกเลิก"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(106, 116)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(109, 20)
        Me.TextBox9.TabIndex = 11
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "0.00"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "สรุปหาย :"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(106, 90)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(109, 20)
        Me.TextBox10.TabIndex = 9
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "0.00"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "น้ำหนัก Roll+ลวด :"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(106, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 20)
        Me.TextBox6.TabIndex = 7
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "0.00"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "น้ำหนักรวม :"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(106, 38)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(109, 20)
        Me.TextBox7.TabIndex = 5
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "0.00"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "น้ำหนัก Roll:"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(106, 12)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(109, 20)
        Me.TextBox8.TabIndex = 3
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "0.00"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "น้ำหนักส่งลดรู :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.txtBarcodeName)
        Me.GroupBox6.Controls.Add(Me.txtBarcode)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txtLotName)
        Me.GroupBox6.Controls.Add(Me.txtLot)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txtBarcodeID)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 50)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(558, 81)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "กำลังทำ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtStatus)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(414, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 58)
        Me.Panel1.TabIndex = 8
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Location = New System.Drawing.Point(8, 29)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(120, 22)
        Me.txtStatus.TabIndex = 7
        Me.txtStatus.TabStop = False
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "สถานะ"
        '
        'txtBarcodeName
        '
        Me.txtBarcodeName.BackColor = System.Drawing.Color.White
        Me.txtBarcodeName.Location = New System.Drawing.Point(198, 47)
        Me.txtBarcodeName.Name = "txtBarcodeName"
        Me.txtBarcodeName.ReadOnly = True
        Me.txtBarcodeName.Size = New System.Drawing.Size(210, 22)
        Me.txtBarcodeName.TabIndex = 5
        Me.txtBarcodeName.TabStop = False
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.Location = New System.Drawing.Point(72, 47)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(120, 22)
        Me.txtBarcode.TabIndex = 4
        Me.txtBarcode.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "บาร์โค๊ต :"
        '
        'txtLotName
        '
        Me.txtLotName.BackColor = System.Drawing.Color.White
        Me.txtLotName.Location = New System.Drawing.Point(158, 19)
        Me.txtLotName.Name = "txtLotName"
        Me.txtLotName.ReadOnly = True
        Me.txtLotName.Size = New System.Drawing.Size(250, 22)
        Me.txtLotName.TabIndex = 2
        Me.txtLotName.TabStop = False
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.Color.White
        Me.txtLot.Location = New System.Drawing.Point(72, 19)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.ReadOnly = True
        Me.txtLot.Size = New System.Drawing.Size(80, 22)
        Me.txtLot.TabIndex = 1
        Me.txtLot.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ล๊อต :"
        '
        'txtBarcodeID
        '
        Me.txtBarcodeID.BackColor = System.Drawing.Color.White
        Me.txtBarcodeID.Location = New System.Drawing.Point(72, 47)
        Me.txtBarcodeID.Name = "txtBarcodeID"
        Me.txtBarcodeID.ReadOnly = True
        Me.txtBarcodeID.Size = New System.Drawing.Size(80, 22)
        Me.txtBarcodeID.TabIndex = 9
        Me.txtBarcodeID.TabStop = False
        Me.txtBarcodeID.Visible = False
        '
        'Timer1
        '
        '
        'txtResult
        '
        Me.txtResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult.BackColor = System.Drawing.Color.White
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.Blue
        Me.txtResult.Location = New System.Drawing.Point(637, 3)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(125, 38)
        Me.txtResult.TabIndex = 35
        Me.txtResult.TabStop = False
        Me.txtResult.Text = "0.00"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        '
        'frmProcessReduce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 496)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "frmProcessReduce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ลดรู"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fpReduce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpReduce_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fpTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpTotal_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fpReduce As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpReduce_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents fpTotal As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpTotal_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeName As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLotName As System.Windows.Forms.TextBox
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtBarcodeID As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
