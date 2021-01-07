<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportUser))
        Me.Button7 = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.fpSize = New FarPoint.Win.Spread.FpSpread
        Me.fpSize_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.lblWait = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.fpSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpSize_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("เคนดีจริง", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Blue
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(12, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 61)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "ค้นหา"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("เคนดีมหาศาล", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(12, 389)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(214, 60)
        Me.btnExport.TabIndex = 51
        Me.btnExport.Text = "Export to excel"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("เคนดีมหาศาล", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(744, 389)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 60)
        Me.btnClose.TabIndex = 52
        Me.btnClose.Text = "ปิด"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClose.UseVisualStyleBackColor = False
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
        Me.fpSize.Location = New System.Drawing.Point(12, 84)
        Me.fpSize.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.fpSize.Name = "fpSize"
        Me.fpSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpSize.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpSize_Sheet1})
        Me.fpSize.Size = New System.Drawing.Size(839, 293)
        Me.fpSize.TabIndex = 53
        Me.fpSize.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpSize_Sheet1
        '
        Me.fpSize_Sheet1.Reset()
        Me.fpSize_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpSize_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpSize_Sheet1.ColumnCount = 16
        Me.fpSize_Sheet1.RowCount = 0
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "User"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "Name"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Department"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "Barcode"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "ลงทอง"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "ชักลวด"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "ตัดห่วง"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "ส่งร้อย"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "แต่งสร้อย"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "ลงเตา"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "ลดรู"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "ทอ"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 12).Value = "เชื่อม"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 13).Value = "เลื่อย"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 14).Value = "รายงาน"
        Me.fpSize_Sheet1.ColumnHeader.Cells.Get(0, 15).Value = "Password"
        Me.fpSize_Sheet1.ColumnHeader.Rows.Get(0).Height = 29.0!
        Me.fpSize_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(0).Label = "User"
        Me.fpSize_Sheet1.Columns.Get(0).Locked = True
        Me.fpSize_Sheet1.Columns.Get(0).Width = 150.0!
        Me.fpSize_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(1).Label = "Name"
        Me.fpSize_Sheet1.Columns.Get(1).Locked = True
        Me.fpSize_Sheet1.Columns.Get(1).Width = 200.0!
        Me.fpSize_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(2).Label = "Department"
        Me.fpSize_Sheet1.Columns.Get(2).Locked = True
        Me.fpSize_Sheet1.Columns.Get(2).Width = 200.0!
        Me.fpSize_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(3).Label = "Barcode"
        Me.fpSize_Sheet1.Columns.Get(3).Locked = True
        Me.fpSize_Sheet1.Columns.Get(3).Width = 88.0!
        Me.fpSize_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(4).Label = "ลงทอง"
        Me.fpSize_Sheet1.Columns.Get(4).Locked = True
        Me.fpSize_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(5).Label = "ชักลวด"
        Me.fpSize_Sheet1.Columns.Get(5).Locked = True
        Me.fpSize_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(6).Label = "ตัดห่วง"
        Me.fpSize_Sheet1.Columns.Get(6).Locked = True
        Me.fpSize_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(7).Label = "ส่งร้อย"
        Me.fpSize_Sheet1.Columns.Get(7).Locked = True
        Me.fpSize_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(8).Label = "แต่งสร้อย"
        Me.fpSize_Sheet1.Columns.Get(8).Locked = True
        Me.fpSize_Sheet1.Columns.Get(8).Width = 74.0!
        Me.fpSize_Sheet1.Columns.Get(9).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(9).Label = "ลงเตา"
        Me.fpSize_Sheet1.Columns.Get(9).Locked = True
        Me.fpSize_Sheet1.Columns.Get(10).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(10).Label = "ลดรู"
        Me.fpSize_Sheet1.Columns.Get(10).Locked = True
        Me.fpSize_Sheet1.Columns.Get(11).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(11).Label = "ทอ"
        Me.fpSize_Sheet1.Columns.Get(11).Locked = True
        Me.fpSize_Sheet1.Columns.Get(12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(12).Label = "เชื่อม"
        Me.fpSize_Sheet1.Columns.Get(12).Locked = True
        Me.fpSize_Sheet1.Columns.Get(13).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(13).Label = "เลื่อย"
        Me.fpSize_Sheet1.Columns.Get(13).Locked = True
        Me.fpSize_Sheet1.Columns.Get(14).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.fpSize_Sheet1.Columns.Get(14).Label = "รายงาน"
        Me.fpSize_Sheet1.Columns.Get(14).Locked = True
        Me.fpSize_Sheet1.Columns.Get(15).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.fpSize_Sheet1.Columns.Get(15).Label = "Password"
        Me.fpSize_Sheet1.Columns.Get(15).Locked = True
        Me.fpSize_Sheet1.Columns.Get(15).Width = 85.0!
        Me.fpSize_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.fpSize_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.fpSize_Sheet1.RowHeader.Columns.Get(0).Width = 75.0!
        Me.fpSize_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        Me.fpSize.SetActiveViewport(0, 1, 0)
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Gold
        Me.lblWait.Font = New System.Drawing.Font("เคนดีจริง", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(93, 167)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(692, 93)
        Me.lblWait.TabIndex = 54
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
        'frmReportUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 462)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.fpSize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Button7)
        Me.Name = "frmReportUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงาน - ข้อมูล user"
        CType(Me.fpSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpSize_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents fpSize As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpSize_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
