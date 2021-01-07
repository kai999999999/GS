<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessBarcode))
        Dim NumberCellType1 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim NumberCellType2 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim NumberCellType3 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Dim NumberCellType4 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType5 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType6 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim ButtonCellType1 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType
        Dim ButtonCellType2 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.fpBarcode = New FarPoint.Win.Spread.FpSpread
        Me.fpBarcode_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblWait = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.fpBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpBarcode_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 47)
        Me.Panel1.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(363, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 30)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "ค้นหา"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(894, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "รายงาน"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ค้นหาแบบ :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(90, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(267, 24)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
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
        Me.Label1.Size = New System.Drawing.Size(890, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "บาร์โค๊ต"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(897, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 43)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "เพิ่มบาร์โค๊ต"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'fpBarcode
        '
        Me.fpBarcode.AccessibleDescription = "fpBarcode, Sheet1, Row 0, Column 0, "
        Me.fpBarcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpBarcode.BackColor = System.Drawing.SystemColors.Control
        Me.fpBarcode.EditModeReplace = True
        Me.fpBarcode.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpBarcode.Location = New System.Drawing.Point(3, 101)
        Me.fpBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.fpBarcode.Name = "fpBarcode"
        Me.fpBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpBarcode.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpBarcode_Sheet1})
        Me.fpBarcode.Size = New System.Drawing.Size(1044, 313)
        Me.fpBarcode.TabIndex = 20
        Me.fpBarcode.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpBarcode.Visible = False
        '
        'fpBarcode_Sheet1
        '
        Me.fpBarcode_Sheet1.Reset()
        Me.fpBarcode_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpBarcode_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpBarcode_Sheet1.ColumnCount = 12
        Me.fpBarcode_Sheet1.RowCount = 1
        Me.fpBarcode_Sheet1.Cells.Get(0, 2).Value = 0
        Me.fpBarcode_Sheet1.Cells.Get(0, 4).Value = 0
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "ID"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "แบบ"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ขนาด"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "หน่วย"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "นิ้ว ไม้บันทัดจีน"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "รหัสบาร์โค็ต"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "ชื่อบาร์โค๊ต"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "น้ำหนักห่วง"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "น้ำหนักฟุต"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "น้ำหนักเส้น"
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = " "
        Me.fpBarcode_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = " "
        Me.fpBarcode_Sheet1.ColumnHeader.Rows.Get(0).Height = 34.0!
        NumberCellType1.DecimalPlaces = 0
        NumberCellType1.MaximumValue = 99999999999999
        NumberCellType1.MinimumValue = -10000000
        Me.fpBarcode_Sheet1.Columns.Get(0).CellType = NumberCellType1
        Me.fpBarcode_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(0).Label = "ID"
        Me.fpBarcode_Sheet1.Columns.Get(0).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(1).CellType = TextCellType1
        Me.fpBarcode_Sheet1.Columns.Get(1).Label = "แบบ"
        Me.fpBarcode_Sheet1.Columns.Get(1).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(1).Width = 127.0!
        NumberCellType2.DecimalPlaces = 0
        NumberCellType2.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType2.MaximumValue = 10000000
        NumberCellType2.MinimumValue = -10000000
        NumberCellType2.NegativeRed = True
        NumberCellType2.ShowSeparator = True
        Me.fpBarcode_Sheet1.Columns.Get(2).CellType = NumberCellType2
        Me.fpBarcode_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(2).Label = "ขนาด"
        Me.fpBarcode_Sheet1.Columns.Get(2).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(2).Width = 59.0!
        Me.fpBarcode_Sheet1.Columns.Get(3).CellType = TextCellType2
        Me.fpBarcode_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(3).Label = "หน่วย"
        Me.fpBarcode_Sheet1.Columns.Get(3).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(3).Width = 59.0!
        NumberCellType3.DecimalPlaces = 0
        NumberCellType3.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes
        NumberCellType3.MaximumValue = 10000000
        NumberCellType3.MinimumValue = -10000000
        NumberCellType3.NegativeRed = True
        NumberCellType3.ShowSeparator = True
        Me.fpBarcode_Sheet1.Columns.Get(4).CellType = NumberCellType3
        Me.fpBarcode_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(4).Label = "นิ้ว ไม้บันทัดจีน"
        Me.fpBarcode_Sheet1.Columns.Get(4).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(4).Width = 54.0!
        Me.fpBarcode_Sheet1.Columns.Get(5).CellType = TextCellType3
        Me.fpBarcode_Sheet1.Columns.Get(5).Label = "รหัสบาร์โค็ต"
        Me.fpBarcode_Sheet1.Columns.Get(5).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(5).Width = 73.0!
        Me.fpBarcode_Sheet1.Columns.Get(6).CellType = TextCellType4
        Me.fpBarcode_Sheet1.Columns.Get(6).Label = "ชื่อบาร์โค๊ต"
        Me.fpBarcode_Sheet1.Columns.Get(6).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(6).Width = 227.0!
        NumberCellType4.MaximumValue = 99999999999999
        NumberCellType4.MinimumValue = -99999999999999
        Me.fpBarcode_Sheet1.Columns.Get(7).CellType = NumberCellType4
        Me.fpBarcode_Sheet1.Columns.Get(7).Label = "น้ำหนักห่วง"
        Me.fpBarcode_Sheet1.Columns.Get(7).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NumberCellType5.MaximumValue = 99999999999999
        NumberCellType5.MinimumValue = -99999999999999
        Me.fpBarcode_Sheet1.Columns.Get(8).CellType = NumberCellType5
        Me.fpBarcode_Sheet1.Columns.Get(8).Label = "น้ำหนักฟุต"
        Me.fpBarcode_Sheet1.Columns.Get(8).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NumberCellType6.MaximumValue = 99999999999999
        NumberCellType6.MinimumValue = -99999999999999
        Me.fpBarcode_Sheet1.Columns.Get(9).CellType = NumberCellType6
        Me.fpBarcode_Sheet1.Columns.Get(9).Label = "น้ำหนักเส้น"
        Me.fpBarcode_Sheet1.Columns.Get(9).Locked = True
        Me.fpBarcode_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        ButtonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType1.Text = "Edit"
        Me.fpBarcode_Sheet1.Columns.Get(10).CellType = ButtonCellType1
        Me.fpBarcode_Sheet1.Columns.Get(10).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(10).Label = " "
        Me.fpBarcode_Sheet1.Columns.Get(10).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        ButtonCellType2.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType2.Text = "Delete"
        Me.fpBarcode_Sheet1.Columns.Get(11).CellType = ButtonCellType2
        Me.fpBarcode_Sheet1.Columns.Get(11).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpBarcode_Sheet1.Columns.Get(11).Label = " "
        Me.fpBarcode_Sheet1.Columns.Get(11).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpBarcode_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpBarcode_Sheet1.RowHeader.Columns.Get(0).Width = 38.0!
        Me.fpBarcode_Sheet1.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpBarcode_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(975, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 43)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "ปิด"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Gold
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(45, 147)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(361, 39)
        Me.lblWait.TabIndex = 26
        Me.lblWait.Text = "กำลังโหลดข้อมูล กรุณารอสักครู่...."
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWait.Visible = False
        '
        'frmProcessBarcode
        '
        Me.AcceptButton = Me.Button7
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 417)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fpBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "frmProcessBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fpBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpBarcode_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents fpBarcode As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpBarcode_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblWait As System.Windows.Forms.Label
End Class
