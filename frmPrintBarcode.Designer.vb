<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBarcode
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
        Dim BarCodeCellType3 As FarPoint.Win.Spread.CellType.BarCodeCellType = New FarPoint.Win.Spread.CellType.BarCodeCellType
        Dim BarCodeCellType4 As FarPoint.Win.Spread.CellType.BarCodeCellType = New FarPoint.Win.Spread.CellType.BarCodeCellType
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
        Me.fpTimer = New FarPoint.Win.Spread.FpSpread
        Me.fpTimer_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBarcodeName = New System.Windows.Forms.TextBox
        Me.txtSubBarcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        CType(Me.fpTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpTimer_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fpTimer
        '
        Me.fpTimer.AccessibleDescription = "fpTimer, Sheet1, Row 0, Column 0, "
        Me.fpTimer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpTimer.BackColor = System.Drawing.SystemColors.Control
        Me.fpTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fpTimer.EditModeReplace = True
        Me.fpTimer.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.fpTimer.Location = New System.Drawing.Point(8, 147)
        Me.fpTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.fpTimer.Name = "fpTimer"
        Me.fpTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpTimer.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpTimer_Sheet1})
        Me.fpTimer.Size = New System.Drawing.Size(344, 183)
        Me.fpTimer.TabIndex = 7
        Me.fpTimer.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        '
        'fpTimer_Sheet1
        '
        Me.fpTimer_Sheet1.Reset()
        Me.fpTimer_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpTimer_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpTimer_Sheet1.ColumnCount = 3
        Me.fpTimer_Sheet1.RowCount = 6
        BarCodeCellType3.BarCodePadding = New FarPoint.Win.Spread.CellType.BarCode.Quiet("", "")
        BarCodeCellType3.BarSize = New FarPoint.Win.Spread.CellType.BarCode.BarSize("84.666mm", "14.552mm")
        BarCodeCellType3.MessagePosition = FarPoint.Win.Spread.CellType.BarCode.MessagePosition.Even
        BarCodeCellType3.Type = New FarPoint.Win.Spread.CellType.BarCode.Code93
        Me.fpTimer_Sheet1.Cells.Get(1, 1).CellType = BarCodeCellType3
        Me.fpTimer_Sheet1.Cells.Get(1, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.fpTimer_Sheet1.Cells.Get(1, 1).Value = "021B17"
        Me.fpTimer_Sheet1.Cells.Get(2, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.fpTimer_Sheet1.Cells.Get(2, 1).Value = "ชื่อ : "
        BarCodeCellType4.BarCodePadding = New FarPoint.Win.Spread.CellType.BarCode.Quiet("", "")
        BarCodeCellType4.BarSize = New FarPoint.Win.Spread.CellType.BarCode.BarSize("84.666mm", "14.552mm")
        BarCodeCellType4.MessagePosition = FarPoint.Win.Spread.CellType.BarCode.MessagePosition.Even
        BarCodeCellType4.Type = New FarPoint.Win.Spread.CellType.BarCode.Code93
        Me.fpTimer_Sheet1.Cells.Get(3, 1).CellType = BarCodeCellType4
        Me.fpTimer_Sheet1.Cells.Get(3, 1).Value = "021B17"
        Me.fpTimer_Sheet1.Cells.Get(4, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpTimer_Sheet1.Cells.Get(4, 1).Value = "วันที่ :"
        Me.fpTimer_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
        Me.fpTimer_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpTimer_Sheet1.ColumnHeader.Visible = False
        Me.fpTimer_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(0).Locked = True
        Me.fpTimer_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(0).Width = 15.0!
        Me.fpTimer_Sheet1.Columns.Get(1).CellType = TextCellType2
        Me.fpTimer_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fpTimer_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpTimer_Sheet1.Columns.Get(1).Locked = True
        Me.fpTimer_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(1).Width = 320.0!
        Me.fpTimer_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(2).Locked = True
        Me.fpTimer_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(2).Width = 5.0!
        Me.fpTimer_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.fpTimer_Sheet1.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        Me.fpTimer_Sheet1.LockBackColor = System.Drawing.Color.White
        Me.fpTimer_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.[ReadOnly]
        Me.fpTimer_Sheet1.PrintInfo.Footer = ""
        Me.fpTimer_Sheet1.PrintInfo.Header = ""
        Me.fpTimer_Sheet1.PrintInfo.JobName = ""
        Me.fpTimer_Sheet1.PrintInfo.Printer = ""
        Me.fpTimer_Sheet1.PrintInfo.ShowBorder = False
        Me.fpTimer_Sheet1.PrintInfo.ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Hide
        Me.fpTimer_Sheet1.PrintInfo.ShowGrid = False
        Me.fpTimer_Sheet1.PrintInfo.ShowPrintDialog = True
        Me.fpTimer_Sheet1.PrintInfo.ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Hide
        Me.fpTimer_Sheet1.PrintInfo.ShowShadows = False
        Me.fpTimer_Sheet1.RangeGroupBackgroundColor = System.Drawing.Color.White
        Me.fpTimer_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpTimer_Sheet1.RowHeader.Columns.Get(0).Width = 50.0!
        Me.fpTimer_Sheet1.RowHeader.Visible = False
        Me.fpTimer_Sheet1.Rows.Get(0).Height = 15.0!
        Me.fpTimer_Sheet1.Rows.Get(1).Height = 55.0!
        Me.fpTimer_Sheet1.Rows.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Top
        Me.fpTimer_Sheet1.Rows.Get(2).Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fpTimer_Sheet1.Rows.Get(2).Height = 25.0!
        Me.fpTimer_Sheet1.Rows.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Top
        Me.fpTimer_Sheet1.Rows.Get(3).Height = 55.0!
        Me.fpTimer_Sheet1.Rows.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
        Me.fpTimer_Sheet1.Rows.Get(4).Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fpTimer_Sheet1.Rows.Get(4).Height = 25.0!
        Me.fpTimer_Sheet1.Rows.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Top
        Me.fpTimer_Sheet1.Rows.Get(5).Height = 5.0!
        Me.fpTimer_Sheet1.SelectionBackColor = System.Drawing.Color.White
        Me.fpTimer_Sheet1.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        Me.fpTimer_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Location = New System.Drawing.Point(82, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(270, 20)
        Me.txtBarcode.TabIndex = 0
        Me.txtBarcode.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(345, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'txtBarcodeName
        '
        Me.txtBarcodeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBarcodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcodeName.Location = New System.Drawing.Point(82, 28)
        Me.txtBarcodeName.Name = "txtBarcodeName"
        Me.txtBarcodeName.ReadOnly = True
        Me.txtBarcodeName.Size = New System.Drawing.Size(270, 20)
        Me.txtBarcodeName.TabIndex = 9
        Me.txtBarcodeName.TabStop = False
        '
        'txtSubBarcode
        '
        Me.txtSubBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSubBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubBarcode.Location = New System.Drawing.Point(82, 74)
        Me.txtSubBarcode.Name = "txtSubBarcode"
        Me.txtSubBarcode.ReadOnly = True
        Me.txtSubBarcode.Size = New System.Drawing.Size(270, 20)
        Me.txtSubBarcode.TabIndex = 10
        Me.txtSubBarcode.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "บาร์โค๊ต"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ชื่อบาร์โค๊ต"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "บาร์โค๊ตย่อย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "วันที่"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(82, 121)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(97, 20)
        Me.dtpDate.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(185, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 44)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(82, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(270, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "น้ำหนัก"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(82, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(97, 20)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(7, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(69, 20)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.TabStop = False
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPrintBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 389)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubBarcode)
        Me.Controls.Add(Me.txtBarcodeName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.fpTimer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Barcode"
        CType(Me.fpTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpTimer_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fpTimer As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpTimer_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtBarcodeName As System.Windows.Forms.TextBox
    Friend WithEvents txtSubBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
