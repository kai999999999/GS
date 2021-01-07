<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessNewJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessNewJob))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.cmbBarcode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBarcodeName = New System.Windows.Forms.TextBox
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.txtLotDescr = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbBarcodeName = New System.Windows.Forms.ComboBox
        Me.cmbBarcodeID = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAutoNumber = New System.Windows.Forms.TextBox
        Me.txtYearMonth = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(584, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 43)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "ปิด"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("#ZF Diffx", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(2, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "สร้างงานใหม่"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(170, 350)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 66)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "บันทึก"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'cmbBarcode
        '
        Me.cmbBarcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarcode.FormattingEnabled = True
        Me.cmbBarcode.Location = New System.Drawing.Point(168, 93)
        Me.cmbBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBarcode.Name = "cmbBarcode"
        Me.cmbBarcode.Size = New System.Drawing.Size(258, 28)
        Me.cmbBarcode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "สแกนบาร์โค๊ต :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "บาร์โค๊ต :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ชื่อบาร์โค๊ต :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ล๊อต :"
        '
        'txtBarcodeName
        '
        Me.txtBarcodeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcodeName.Location = New System.Drawing.Point(168, 157)
        Me.txtBarcodeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcodeName.Name = "txtBarcodeName"
        Me.txtBarcodeName.ReadOnly = True
        Me.txtBarcodeName.Size = New System.Drawing.Size(476, 26)
        Me.txtBarcodeName.TabIndex = 0
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(168, 126)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(308, 26)
        Me.txtBarcode.TabIndex = 3
        '
        'txtLotDescr
        '
        Me.txtLotDescr.Location = New System.Drawing.Point(257, 188)
        Me.txtLotDescr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLotDescr.Name = "txtLotDescr"
        Me.txtLotDescr.ReadOnly = True
        Me.txtLotDescr.Size = New System.Drawing.Size(390, 26)
        Me.txtLotDescr.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(287, 350)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 66)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "พิมพ์"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(488, 62)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 89)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Barcode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(170, 188)
        Me.txtLot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.ReadOnly = True
        Me.txtLot.Size = New System.Drawing.Size(76, 26)
        Me.txtLot.TabIndex = 5
        Me.txtLot.TabStop = False
        Me.txtLot.Text = "0"
        Me.txtLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(436, 93)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 28)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'cmbBarcodeName
        '
        Me.cmbBarcodeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarcodeName.FormattingEnabled = True
        Me.cmbBarcodeName.Location = New System.Drawing.Point(2, 93)
        Me.cmbBarcodeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBarcodeName.Name = "cmbBarcodeName"
        Me.cmbBarcodeName.Size = New System.Drawing.Size(37, 28)
        Me.cmbBarcodeName.TabIndex = 52
        Me.cmbBarcodeName.Visible = False
        '
        'cmbBarcodeID
        '
        Me.cmbBarcodeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarcodeID.FormattingEnabled = True
        Me.cmbBarcodeID.Location = New System.Drawing.Point(2, 123)
        Me.cmbBarcodeID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBarcodeID.Name = "cmbBarcodeID"
        Me.cmbBarcodeID.Size = New System.Drawing.Size(37, 28)
        Me.cmbBarcodeID.TabIndex = 53
        Me.cmbBarcodeID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Loop :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ทรงเครื่อง", "สร้อยทอ"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 219)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 28)
        Me.ComboBox1.TabIndex = 55
        '
        'txtResult
        '
        Me.txtResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult.BackColor = System.Drawing.Color.White
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.Blue
        Me.txtResult.Location = New System.Drawing.Point(451, 5)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(125, 38)
        Me.txtResult.TabIndex = 58
        Me.txtResult.TabStop = False
        Me.txtResult.Text = "0.00"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(168, 314)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(92, 26)
        Me.TextBox6.TabIndex = 64
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "0.00"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 317)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "รวม :"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(168, 283)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(92, 26)
        Me.TextBox7.TabIndex = 62
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "0.00"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 286)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 20)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "เศษ:"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(168, 252)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(92, 26)
        Me.TextBox8.TabIndex = 60
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "0.00"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 255)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "น้ำหนักทอง :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(168, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(187, 26)
        Me.DateTimePicker1.TabIndex = 66
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(62, 67)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 20)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "วันที่สร้างงาน :"
        '
        'txtAutoNumber
        '
        Me.txtAutoNumber.BackColor = System.Drawing.Color.White
        Me.txtAutoNumber.Enabled = False
        Me.txtAutoNumber.Location = New System.Drawing.Point(423, 126)
        Me.txtAutoNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAutoNumber.Name = "txtAutoNumber"
        Me.txtAutoNumber.ReadOnly = True
        Me.txtAutoNumber.Size = New System.Drawing.Size(54, 26)
        Me.txtAutoNumber.TabIndex = 68
        Me.txtAutoNumber.TabStop = False
        Me.txtAutoNumber.Text = "0000"
        Me.txtAutoNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAutoNumber.Visible = False
        '
        'txtYearMonth
        '
        Me.txtYearMonth.BackColor = System.Drawing.Color.White
        Me.txtYearMonth.Enabled = False
        Me.txtYearMonth.Location = New System.Drawing.Point(363, 126)
        Me.txtYearMonth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtYearMonth.Name = "txtYearMonth"
        Me.txtYearMonth.ReadOnly = True
        Me.txtYearMonth.Size = New System.Drawing.Size(58, 26)
        Me.txtYearMonth.TabIndex = 67
        Me.txtYearMonth.TabStop = False
        Me.txtYearMonth.Text = "0000"
        Me.txtYearMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtYearMonth.Visible = False
        '
        'frmProcessNewJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 424)
        Me.Controls.Add(Me.txtAutoNumber)
        Me.Controls.Add(Me.txtYearMonth)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbBarcodeID)
        Me.Controls.Add(Me.cmbBarcodeName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtLot)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtLotDescr)
        Me.Controls.Add(Me.txtBarcodeName)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbBarcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmProcessNewJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สร้างงานใหม่"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmbBarcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeName As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtLotDescr As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbBarcodeName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBarcodeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAutoNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtYearMonth As System.Windows.Forms.TextBox
End Class
