<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcess214
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcess214))
        Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim NumberCellType1 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim cultureInfo As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US", False)
        Dim DateTimeCellType2 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
        Dim NumberCellType2 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType3 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType4 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType5 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.fpReturn = New FarPoint.Win.Spread.FpSpread
        Me.fpReturn_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.fpOut_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.fpOut = New FarPoint.Win.Spread.FpSpread
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label26 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.fpReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpReturn_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpOut_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.fpOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult.BackColor = System.Drawing.Color.White
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.Blue
        Me.txtResult.Location = New System.Drawing.Point(639, 3)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(125, 38)
        Me.txtResult.TabIndex = 102
        Me.txtResult.TabStop = False
        Me.txtResult.Text = "0.00"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel2.Text = "TAROTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.fpReturn)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 210)
        Me.GroupBox2.TabIndex = 104
        Me.GroupBox2.TabStop = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"300", "จรวด", "น้ำประสาน", "น้ำประสานทอ", "ต้มสี", "ตัดลาย", "โอ่ง+ปล้อง", "L.S.", "ร้อยตะขอ", "ชักลวด", "ตัดห่วง", "ส่งร้อย", "แต่งสร้อย", "ลงเตา", "70", "ทอ", "เชื่อม", "เลื่อย"})
        Me.ComboBox5.Location = New System.Drawing.Point(697, 21)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox5.TabIndex = 278
        Me.ComboBox5.Visible = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(549, 15)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(142, 30)
        Me.Button10.TabIndex = 277
        Me.Button10.Text = "ต้องการรับคืน"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(591, 81)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(226, 20)
        Me.TextBox5.TabIndex = 276
        Me.TextBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(553, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 275
        Me.Label7.Text = "พิมพ์ :"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(591, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(226, 20)
        Me.TextBox3.TabIndex = 272
        Me.TextBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 271
        Me.Label3.Text = "หมายเหตุ :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 269
        Me.Label4.Text = "รายการคืน :"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"300", "จรวด", "น้ำประสาน", "น้ำประสานทอ", "ต้มสี", "ตัดลาย", "โอ่ง+ปล้อง", "L.S.", "ร้อยตะขอ", "ชักลวด", "ตัดห่วง", "ส่งร้อย", "แต่งสร้อย", "ลงเตา", "70", "ทอ", "เชื่อม", "เลื่อย"})
        Me.ComboBox4.Location = New System.Drawing.Point(591, 55)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox4.TabIndex = 268
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(591, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 267
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(513, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 266
        Me.Label5.Text = "น้ำหนักรับคืน :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(692, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(125, 20)
        Me.DateTimePicker2.TabIndex = 265
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(686, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 39)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "ยกเลิก"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Enabled = False
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(591, 162)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 39)
        Me.Button8.TabIndex = 98
        Me.Button8.Text = "บันทึก"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'fpReturn
        '
        Me.fpReturn.AccessibleDescription = "fpReturn, Sheet1, Row 0, Column 0, "
        Me.fpReturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpReturn.BackColor = System.Drawing.SystemColors.Control
        Me.fpReturn.EditModeReplace = True
        Me.fpReturn.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpReturn.Location = New System.Drawing.Point(5, 15)
        Me.fpReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.fpReturn.Name = "fpReturn"
        Me.fpReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpReturn.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpReturn_Sheet1})
        Me.fpReturn.Size = New System.Drawing.Size(495, 185)
        Me.fpReturn.TabIndex = 66
        Me.fpReturn.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpReturn_Sheet1
        '
        Me.fpReturn_Sheet1.Reset()
        Me.fpReturn_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpReturn_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpReturn_Sheet1.ColumnCount = 6
        Me.fpReturn_Sheet1.RowCount = 1
        Me.fpReturn_Sheet1.Cells.Get(0, 2).Value = New Date(2019, 1, 1, 10, 12, 56, 0)
        Me.fpReturn_Sheet1.Cells.Get(0, 4).Value = 0
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "ID"
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "IDOut"
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "วันที่รับคืน"
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "รายการคืน"
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "น้ำหนัก"
        Me.fpReturn_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "หมายเหตุ"
        Me.fpReturn_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpReturn_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(0).Label = "ID"
        Me.fpReturn_Sheet1.Columns.Get(0).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(0).Visible = False
        Me.fpReturn_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(1).Label = "IDOut"
        Me.fpReturn_Sheet1.Columns.Get(1).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(1).Visible = False
        DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
        DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
        DateTimeCellType1.DateDefault = New Date(2019, 9, 5, 10, 12, 56, 0)
        DateTimeCellType1.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
        DateTimeCellType1.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
        DateTimeCellType1.TimeDefault = New Date(2019, 9, 5, 10, 12, 56, 0)
        DateTimeCellType1.UserDefinedFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fpReturn_Sheet1.Columns.Get(2).CellType = DateTimeCellType1
        Me.fpReturn_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpReturn_Sheet1.Columns.Get(2).Label = "วันที่รับคืน"
        Me.fpReturn_Sheet1.Columns.Get(2).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(2).Width = 113.0!
        Me.fpReturn_Sheet1.Columns.Get(3).CellType = TextCellType1
        Me.fpReturn_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpReturn_Sheet1.Columns.Get(3).Label = "รายการคืน"
        Me.fpReturn_Sheet1.Columns.Get(3).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(3).Width = 100.0!
        NumberCellType1.DecimalPlaces = 2
        NumberCellType1.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType1.NegativeRed = True
        NumberCellType1.ShowSeparator = True
        Me.fpReturn_Sheet1.Columns.Get(4).CellType = NumberCellType1
        Me.fpReturn_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(4).Label = "น้ำหนัก"
        Me.fpReturn_Sheet1.Columns.Get(4).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(4).Width = 61.0!
        Me.fpReturn_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpReturn_Sheet1.Columns.Get(5).Label = "หมายเหตุ"
        Me.fpReturn_Sheet1.Columns.Get(5).Locked = True
        Me.fpReturn_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpReturn_Sheet1.Columns.Get(5).Width = 146.0!
        Me.fpReturn_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpReturn_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpReturn_Sheet1.RowHeader.Columns.Get(0).Width = 38.0!
        Me.fpReturn_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Timer1
        '
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(64, 17)
        Me.ToolStripStatusLabel1.Text = "ชื่อผู้ใช้งาน :"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(637, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "ตั้งค่าเครื่องชั่งเป็นศูนย์"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel5.Text = "M123"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("#ZF Diffx", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(139, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 40)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel4.Text = "เครื่องชั่ง :"
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(561, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(72, 43)
        Me.Button7.TabIndex = 101
        Me.Button7.Text = "ค้นหา"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(770, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 43)
        Me.Button6.TabIndex = 100
        Me.Button6.Text = "ปิด"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'fpOut_Sheet1
        '
        Me.fpOut_Sheet1.Reset()
        Me.fpOut_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpOut_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpOut_Sheet1.ColumnCount = 7
        Me.fpOut_Sheet1.RowCount = 1
        Me.fpOut_Sheet1.Cells.Get(0, 1).ParseFormatInfo = CType(cultureInfo.DateTimeFormat.Clone, System.Globalization.DateTimeFormatInfo)
        CType(Me.fpOut_Sheet1.Cells.Get(0, 1).ParseFormatInfo, System.Globalization.DateTimeFormatInfo).FullDateTimePattern = "dddd, MMMM dd, yyyy HH:mm:ss"
        CType(Me.fpOut_Sheet1.Cells.Get(0, 1).ParseFormatInfo, System.Globalization.DateTimeFormatInfo).LongTimePattern = "HH:mm:ss"
        CType(Me.fpOut_Sheet1.Cells.Get(0, 1).ParseFormatInfo, System.Globalization.DateTimeFormatInfo).ShortDatePattern = "dd/MM/yyyy"
        Me.fpOut_Sheet1.Cells.Get(0, 1).ParseFormatString = "dd/MM/yyyy H:mm:ss"
        Me.fpOut_Sheet1.Cells.Get(0, 1).Value = New Date(2019, 8, 1, 8, 35, 20, 0)
        Me.fpOut_Sheet1.Cells.Get(0, 3).Value = 0
        Me.fpOut_Sheet1.Cells.Get(0, 4).Value = 0
        Me.fpOut_Sheet1.Cells.Get(0, 5).Value = 0
        Me.fpOut_Sheet1.Cells.Get(0, 6).Value = 0
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "ID"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "วันที่จ่ายงาน"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "รายการ"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "เบิก"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "คืน"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "คงเหลือ"
        Me.fpOut_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "รวมใช้"
        Me.fpOut_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpOut_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(0).Label = "ID"
        Me.fpOut_Sheet1.Columns.Get(0).Locked = True
        Me.fpOut_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(0).Visible = False
        Me.fpOut_Sheet1.Columns.Get(0).Width = 29.0!
        DateTimeCellType2.Calendar = CType(resources.GetObject("DateTimeCellType2.Calendar"), System.Globalization.Calendar)
        DateTimeCellType2.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
        DateTimeCellType2.DateDefault = New Date(2019, 9, 5, 10, 12, 56, 0)
        DateTimeCellType2.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
        DateTimeCellType2.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
        DateTimeCellType2.TimeDefault = New Date(2019, 9, 5, 10, 12, 56, 0)
        DateTimeCellType2.UserDefinedFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fpOut_Sheet1.Columns.Get(1).CellType = DateTimeCellType2
        Me.fpOut_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpOut_Sheet1.Columns.Get(1).Label = "วันที่จ่ายงาน"
        Me.fpOut_Sheet1.Columns.Get(1).Locked = True
        Me.fpOut_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(1).Width = 113.0!
        Me.fpOut_Sheet1.Columns.Get(2).AllowAutoFilter = True
        Me.fpOut_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(2).Label = "รายการ"
        Me.fpOut_Sheet1.Columns.Get(2).Locked = True
        Me.fpOut_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NumberCellType2.DecimalPlaces = 2
        NumberCellType2.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType2.NegativeRed = True
        NumberCellType2.ShowSeparator = True
        Me.fpOut_Sheet1.Columns.Get(3).CellType = NumberCellType2
        Me.fpOut_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(3).Label = "เบิก"
        Me.fpOut_Sheet1.Columns.Get(3).Locked = True
        Me.fpOut_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(3).Width = 61.0!
        NumberCellType3.DecimalPlaces = 2
        NumberCellType3.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType3.NegativeRed = True
        NumberCellType3.ShowSeparator = True
        Me.fpOut_Sheet1.Columns.Get(4).CellType = NumberCellType3
        Me.fpOut_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(4).Label = "คืน"
        Me.fpOut_Sheet1.Columns.Get(4).Locked = True
        Me.fpOut_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(4).Width = 61.0!
        NumberCellType4.DecimalPlaces = 2
        NumberCellType4.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType4.NegativeRed = True
        NumberCellType4.ShowSeparator = True
        Me.fpOut_Sheet1.Columns.Get(5).CellType = NumberCellType4
        Me.fpOut_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(5).Label = "คงเหลือ"
        Me.fpOut_Sheet1.Columns.Get(5).Locked = True
        Me.fpOut_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(5).Width = 61.0!
        NumberCellType5.DecimalPlaces = 2
        NumberCellType5.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType5.NegativeRed = True
        NumberCellType5.ShowSeparator = True
        Me.fpOut_Sheet1.Columns.Get(6).CellType = NumberCellType5
        Me.fpOut_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(6).Label = "รวมใช้"
        Me.fpOut_Sheet1.Columns.Get(6).Locked = True
        Me.fpOut_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.Columns.Get(6).Width = 61.0!
        Me.fpOut_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpOut_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpOut_Sheet1.RowHeader.Columns.Get(0).Width = 38.0!
        Me.fpOut_Sheet1.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpOut_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Enabled = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 498)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(839, 22)
        Me.StatusStrip1.TabIndex = 97
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'fpOut
        '
        Me.fpOut.AccessibleDescription = "fpOut, Sheet1, Row 0, Column 0, "
        Me.fpOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpOut.BackColor = System.Drawing.SystemColors.Control
        Me.fpOut.EditModeReplace = True
        Me.fpOut.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpOut.Location = New System.Drawing.Point(5, 15)
        Me.fpOut.Margin = New System.Windows.Forms.Padding(4)
        Me.fpOut.Name = "fpOut"
        Me.fpOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpOut.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpOut_Sheet1})
        Me.fpOut.Size = New System.Drawing.Size(497, 210)
        Me.fpOut.TabIndex = 66
        Me.fpOut.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(692, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 20)
        Me.DateTimePicker1.TabIndex = 70
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(521, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 262
        Me.Label26.Text = "รายการเบิก :"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"300", "จรวด", "น้ำประสาน", "น้ำประสานทอ", "ต้มสี", "ตัดลาย", "โอ่ง", "ปล้อง", "L.S.", "ร้อยตะขอ", "ชักลวด", "ตัดห่วง", "ส่งร้อย", "แต่งสร้อย", "ลงเตา", "70", "ทอ", "เชื่อม", "เลื่อย"})
        Me.ComboBox3.Location = New System.Drawing.Point(591, 50)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.TabIndex = 261
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.fpOut)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 230)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"300", "จรวด", "น้ำประสาน", "น้ำประสานทอ", "ต้มสี", "ตัดลาย", "โอ่ง+ปล้อง", "L.S.", "ร้อยตะขอ", "ชักลวด", "ตัดห่วง", "ส่งร้อย", "แต่งสร้อย", "ลงเตา", "70", "ทอ", "เชื่อม", "เลื่อย"})
        Me.ComboBox2.Location = New System.Drawing.Point(697, 127)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 277
        Me.ComboBox2.Visible = False
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(549, 15)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(142, 30)
        Me.Button11.TabIndex = 276
        Me.Button11.Text = "เพิ่มจ่ายงาน (เบิก)"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(591, 202)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(80, 20)
        Me.txtID.TabIndex = 275
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(591, 76)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(226, 20)
        Me.TextBox4.TabIndex = 274
        Me.TextBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(553, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "พิมพ์ :"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(686, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 39)
        Me.Button3.TabIndex = 266
        Me.Button3.Text = "ยกเลิก"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.Enabled = False
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(591, 157)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 39)
        Me.Button9.TabIndex = 265
        Me.Button9.Text = "บันทึก"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(546, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 264
        Me.Label10.Text = "แผนก :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"300", "จรวด", "น้ำประสาน", "น้ำประสานทอ", "ต้มสี", "ตัดลาย", "โอ่ง+ปล้อง", "L.S.", "ร้อยตะขอ", "ชักลวด", "ตัดห่วง", "ส่งร้อย", "แต่งสร้อย", "ลงเตา", "70", "ทอ", "เชื่อม", "เลื่อย"})
        Me.ComboBox1.Location = New System.Drawing.Point(591, 127)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 263
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(692, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 30)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "แก้ไขเพิ่มเติม"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(591, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 72
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(541, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "น้ำหนัก :"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(5, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 43)
        Me.Button5.TabIndex = 105
        Me.Button5.Text = " แสดงรายการ"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'frmProcess214
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 520)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmProcess214"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fpReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpReturn_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpOut_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.fpOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents fpReturn As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpReturn_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents fpOut_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents fpOut As FarPoint.Win.Spread.FpSpread
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
End Class
