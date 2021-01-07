<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStart2
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
        Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportStart2))
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim NumberCellType1 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Me.fpSize = New FarPoint.Win.Spread.FpSpread
        Me.fpSize_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpUpdateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpUpdateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpCreateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpCreateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblWait = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.fpSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpSize_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fpSize
        '
        Me.fpSize.AccessibleDescription = "fpSize, Sheet1, Row 0, Column 0, "
        Me.fpSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpSize.BackColor = System.Drawing.SystemColors.Control
        Me.fpSize.EditModeReplace = True
        Me.fpSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fpSize.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpSize.Location = New System.Drawing.Point(9, 125)
        Me.fpSize.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.fpSize.Name = "fpSize"
        Me.fpSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpSize.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpSize_Sheet1})
        Me.fpSize.Size = New System.Drawing.Size(849, 270)
        Me.fpSize.TabIndex = 20
        Me.fpSize.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpSize_Sheet1
        '
        Me.fpSize_Sheet1.Reset()
        Me.fpSize_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpSize_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpSize_Sheet1.ColumnCount = 6
        Me.fpSize_Sheet1.RowCount = 0
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "วันเวลา บันทึกล่าสุด"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "User"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Lot"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "บาร์โค๊ต"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "ชื่อบาร์โต๊ต"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "น้ำหนักทอง"
        Me.fpSize_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpSize_Sheet1.Columns.Get(0).AllowAutoSort = True
        DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
        DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
        DateTimeCellType1.DateDefault = New Date(2019, 10, 8, 21, 8, 31, 0)
        DateTimeCellType1.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
        DateTimeCellType1.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
        DateTimeCellType1.TimeDefault = New Date(2019, 10, 8, 21, 8, 31, 0)
        DateTimeCellType1.UserDefinedFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fpSize_Sheet1.Columns.Get(0).CellType = DateTimeCellType1
        Me.fpSize_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(0).Label = "วันเวลา บันทึกล่าสุด"
        Me.fpSize_Sheet1.Columns.Get(0).Locked = True
        Me.fpSize_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(0).Width = 156.0!
        Me.fpSize_Sheet1.Columns.Get(1).CellType = TextCellType1
        Me.fpSize_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(1).Label = "User"
        Me.fpSize_Sheet1.Columns.Get(1).Locked = True
        Me.fpSize_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(1).Width = 83.0!
        Me.fpSize_Sheet1.Columns.Get(2).AllowAutoSort = True
        Me.fpSize_Sheet1.Columns.Get(2).CellType = TextCellType2
        Me.fpSize_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(2).Label = "Lot"
        Me.fpSize_Sheet1.Columns.Get(2).Locked = True
        Me.fpSize_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(2).Width = 100.0!
        Me.fpSize_Sheet1.Columns.Get(3).AllowAutoSort = True
        Me.fpSize_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(3).Label = "บาร์โค๊ต"
        Me.fpSize_Sheet1.Columns.Get(3).Locked = True
        Me.fpSize_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(3).Width = 150.0!
        Me.fpSize_Sheet1.Columns.Get(4).CellType = TextCellType3
        Me.fpSize_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(4).Label = "ชื่อบาร์โต๊ต"
        Me.fpSize_Sheet1.Columns.Get(4).Locked = True
        Me.fpSize_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(4).Width = 150.0!
        NumberCellType1.DecimalPlaces = 2
        NumberCellType1.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType1.NegativeRed = True
        NumberCellType1.ShowSeparator = True
        Me.fpSize_Sheet1.Columns.Get(5).CellType = NumberCellType1
        Me.fpSize_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
        Me.fpSize_Sheet1.Columns.Get(5).Label = "น้ำหนักทอง"
        Me.fpSize_Sheet1.Columns.Get(5).Locked = True
        Me.fpSize_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(5).Width = 100.0!
        Me.fpSize_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpSize_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpSize_Sheet1.RowHeader.Columns.Get(0).AllowAutoSort = True
        Me.fpSize_Sheet1.RowHeader.Columns.Get(0).Width = 75.0!
        Me.fpSize_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        Me.fpSize.SetActiveViewport(0, 1, 0)
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("เคนดีมหาศาล", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(751, 398)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 60)
        Me.btnClose.TabIndex = 39
        Me.btnClose.Text = "ปิด"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("เคนดีมหาศาล", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(9, 398)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(214, 60)
        Me.btnExport.TabIndex = 40
        Me.btnExport.Text = "Export to excel"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 114)
        Me.Panel1.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(520, 7)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 24)
        Me.TextBox3.TabIndex = 50
        Me.TextBox3.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("เคนดีจริง", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Blue
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(520, 46)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 61)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "ค้นหา"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpUpdateTo)
        Me.GroupBox2.Controls.Add(Me.dtpUpdateFrom)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 36)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(227, 75)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "วันที่แก้ไข"
        '
        'dtpUpdateTo
        '
        Me.dtpUpdateTo.Checked = False
        Me.dtpUpdateTo.CustomFormat = "dd/MM/yyyy  HH:mm"
        Me.dtpUpdateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUpdateTo.Location = New System.Drawing.Point(43, 46)
        Me.dtpUpdateTo.Name = "dtpUpdateTo"
        Me.dtpUpdateTo.ShowCheckBox = True
        Me.dtpUpdateTo.Size = New System.Drawing.Size(176, 24)
        Me.dtpUpdateTo.TabIndex = 28
        '
        'dtpUpdateFrom
        '
        Me.dtpUpdateFrom.Checked = False
        Me.dtpUpdateFrom.CustomFormat = "dd/MM/yyyy  HH:mm"
        Me.dtpUpdateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUpdateFrom.Location = New System.Drawing.Point(43, 19)
        Me.dtpUpdateFrom.Name = "dtpUpdateFrom"
        Me.dtpUpdateFrom.ShowCheckBox = True
        Me.dtpUpdateFrom.Size = New System.Drawing.Size(176, 24)
        Me.dtpUpdateFrom.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ถึง :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "จาก :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpCreateTo)
        Me.GroupBox1.Controls.Add(Me.dtpCreateFrom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(228, 75)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "วันที่สร้าง"
        '
        'dtpCreateTo
        '
        Me.dtpCreateTo.Checked = False
        Me.dtpCreateTo.CustomFormat = "dd/MM/yyyy  HH:mm"
        Me.dtpCreateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCreateTo.Location = New System.Drawing.Point(42, 46)
        Me.dtpCreateTo.Name = "dtpCreateTo"
        Me.dtpCreateTo.ShowCheckBox = True
        Me.dtpCreateTo.Size = New System.Drawing.Size(176, 24)
        Me.dtpCreateTo.TabIndex = 28
        '
        'dtpCreateFrom
        '
        Me.dtpCreateFrom.Checked = False
        Me.dtpCreateFrom.CustomFormat = "dd/MM/yyyy  HH:mm"
        Me.dtpCreateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCreateFrom.Location = New System.Drawing.Point(42, 19)
        Me.dtpCreateFrom.Name = "dtpCreateFrom"
        Me.dtpCreateFrom.ShowCheckBox = True
        Me.dtpCreateFrom.Size = New System.Drawing.Size(176, 24)
        Me.dtpCreateFrom.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ถึง :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "จาก :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ไซส์ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "บาร์โค๊ต :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(310, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 24)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(112, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 24)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "หมายเลขล๊อต :"
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Gold
        Me.lblWait.Font = New System.Drawing.Font("เคนดีจริง", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(121, 185)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(692, 93)
        Me.lblWait.TabIndex = 53
        Me.lblWait.Text = "กำลังโหลดข้อมูล กรุณารอสักครู่...."
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWait.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
        Me.SaveFileDialog1.FilterIndex = 2
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'frmReportStart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 462)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.fpSize)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "frmReportStart2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงาน - ลงไซส์"
        CType(Me.fpSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpSize_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fpSize As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpSize_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpUpdateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpUpdateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpCreateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCreateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
