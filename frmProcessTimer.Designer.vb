<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessTimer
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
        Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessTimer))
        Dim NumberCellType1 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType2 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim NumberCellType3 As FarPoint.Win.Spread.CellType.NumberCellType = New FarPoint.Win.Spread.CellType.NumberCellType
        Dim ButtonCellType1 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.fpTimer = New FarPoint.Win.Spread.FpSpread
        Me.fpTimer_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.fpTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpTimer_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("#ZF Diffx", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 40)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ตั้งเวลา"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "ชื่อเตา :"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(57, 49)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(160, 24)
        Me.txtCode.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "dd MMMM yyyy "
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(278, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 24)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "วันที่ :"
        '
        'Button7
        '
        Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Blue
        Me.Button7.Location = New System.Drawing.Point(9, 138)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(467, 38)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "เพิ่ม"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'fpTimer
        '
        Me.fpTimer.AccessibleDescription = "fpTimer, Sheet1, Row 0, Column 0, "
        Me.fpTimer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpTimer.BackColor = System.Drawing.SystemColors.Control
        Me.fpTimer.EditModeReplace = True
        Me.fpTimer.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpTimer.Location = New System.Drawing.Point(9, 180)
        Me.fpTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.fpTimer.Name = "fpTimer"
        Me.fpTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpTimer.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpTimer_Sheet1})
        Me.fpTimer.Size = New System.Drawing.Size(467, 141)
        Me.fpTimer.TabIndex = 6
        Me.fpTimer.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpTimer_Sheet1
        '
        Me.fpTimer_Sheet1.Reset()
        Me.fpTimer_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpTimer_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpTimer_Sheet1.ColumnCount = 6
        Me.fpTimer_Sheet1.RowCount = 1
        Me.fpTimer_Sheet1.Cells.Get(0, 0).Value = "AAA"
        Me.fpTimer_Sheet1.Cells.Get(0, 1).Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        Me.fpTimer_Sheet1.Cells.Get(0, 2).Value = 2
        Me.fpTimer_Sheet1.Cells.Get(0, 3).Value = 5
        Me.fpTimer_Sheet1.Cells.Get(0, 4).Value = 25
        Me.fpTimer_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
        Me.fpTimer_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "ชื่อเตา"
        Me.fpTimer_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "วันที่"
        Me.fpTimer_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ชั่วโมง"
        Me.fpTimer_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "นาที"
        Me.fpTimer_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "วินาที"
        Me.fpTimer_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpTimer_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpTimer_Sheet1.Columns.Get(0).Label = "ชื่อเตา"
        Me.fpTimer_Sheet1.Columns.Get(0).Locked = True
        Me.fpTimer_Sheet1.Columns.Get(0).Width = 89.0!
        DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
        DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
        DateTimeCellType1.DateDefault = New Date(2018, 12, 21, 23, 58, 41, 0)
        DateTimeCellType1.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
        DateTimeCellType1.TimeDefault = New Date(2018, 12, 21, 23, 58, 41, 0)
        Me.fpTimer_Sheet1.Columns.Get(1).CellType = DateTimeCellType1
        Me.fpTimer_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(1).Label = "วันที่"
        Me.fpTimer_Sheet1.Columns.Get(1).Locked = True
        Me.fpTimer_Sheet1.Columns.Get(1).Width = 79.0!
        NumberCellType1.DecimalPlaces = 0
        NumberCellType1.MaximumValue = 10000000
        NumberCellType1.MinimumValue = -10000000
        Me.fpTimer_Sheet1.Columns.Get(2).CellType = NumberCellType1
        Me.fpTimer_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(2).Label = "ชั่วโมง"
        Me.fpTimer_Sheet1.Columns.Get(2).Locked = True
        NumberCellType2.DecimalPlaces = 0
        NumberCellType2.MaximumValue = 10000000
        NumberCellType2.MinimumValue = -10000000
        Me.fpTimer_Sheet1.Columns.Get(3).CellType = NumberCellType2
        Me.fpTimer_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(3).Label = "นาที"
        Me.fpTimer_Sheet1.Columns.Get(3).Locked = True
        NumberCellType3.DecimalPlaces = 0
        NumberCellType3.MaximumValue = 10000000
        NumberCellType3.MinimumValue = -10000000
        Me.fpTimer_Sheet1.Columns.Get(4).CellType = NumberCellType3
        Me.fpTimer_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpTimer_Sheet1.Columns.Get(4).Label = "วินาที"
        Me.fpTimer_Sheet1.Columns.Get(4).Locked = True
        ButtonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        ButtonCellType1.Text = "ลบ"
        Me.fpTimer_Sheet1.Columns.Get(5).CellType = ButtonCellType1
        Me.fpTimer_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpTimer_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpTimer_Sheet1.RowHeader.Columns.Get(0).Width = 50.0!
        Me.fpTimer_Sheet1.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpTimer_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "ชั่วโมง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "นาที"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "วินาที"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(57, 103)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 24)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(114, 103)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(46, 24)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(171, 103)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(46, 24)
        Me.NumericUpDown3.TabIndex = 4
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'frmProcessTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 326)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fpTimer)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(500, 350)
        Me.Name = "frmProcessTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งเวลา"
        CType(Me.fpTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpTimer_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents fpTimer As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpTimer_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
