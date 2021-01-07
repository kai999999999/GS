<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.fpSearch = New FarPoint.Win.Spread.FpSpread
        Me.fpSearch_Search = New FarPoint.Win.Spread.SheetView
        Me.palCriteria = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbFill = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cmbBy = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bsSearch = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.fpSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpSearch_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palCriteria.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fpSearch
        '
        Me.fpSearch.AccessibleDescription = "fpSearch, Sheet1, Row 0, Column 0, "
        Me.fpSearch.BackColor = System.Drawing.SystemColors.Control
        Me.fpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpSearch.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Me.fpSearch.Location = New System.Drawing.Point(0, 75)
        Me.fpSearch.Name = "fpSearch"
        Me.fpSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fpSearch.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpSearch_Search})
        Me.fpSearch.Size = New System.Drawing.Size(694, 257)
        Me.fpSearch.TabIndex = 5
        Me.fpSearch.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        '
        'fpSearch_Search
        '
        Me.fpSearch_Search.Reset()
        Me.fpSearch_Search.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpSearch_Search.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpSearch_Search.ColumnCount = 100
        Me.fpSearch_Search.RowCount = 1
        Me.fpSearch_Search.AllowNoteEdit = False
        Me.fpSearch_Search.Columns.Get(0).Locked = True
        Me.fpSearch_Search.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(1).Locked = True
        Me.fpSearch_Search.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(2).Locked = True
        Me.fpSearch_Search.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(3).Locked = True
        Me.fpSearch_Search.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(4).Locked = True
        Me.fpSearch_Search.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(5).Locked = True
        Me.fpSearch_Search.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(6).Locked = True
        Me.fpSearch_Search.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(7).Locked = True
        Me.fpSearch_Search.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(8).Locked = True
        Me.fpSearch_Search.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(9).Locked = True
        Me.fpSearch_Search.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(10).Locked = True
        Me.fpSearch_Search.Columns.Get(10).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(11).Locked = True
        Me.fpSearch_Search.Columns.Get(11).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(12).Locked = True
        Me.fpSearch_Search.Columns.Get(12).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(13).Locked = True
        Me.fpSearch_Search.Columns.Get(13).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(14).Locked = True
        Me.fpSearch_Search.Columns.Get(14).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(15).Locked = True
        Me.fpSearch_Search.Columns.Get(15).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(16).Locked = True
        Me.fpSearch_Search.Columns.Get(16).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(17).Locked = True
        Me.fpSearch_Search.Columns.Get(17).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(18).Locked = True
        Me.fpSearch_Search.Columns.Get(18).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(19).Locked = True
        Me.fpSearch_Search.Columns.Get(19).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(20).Locked = True
        Me.fpSearch_Search.Columns.Get(20).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(21).Locked = True
        Me.fpSearch_Search.Columns.Get(21).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(22).Locked = True
        Me.fpSearch_Search.Columns.Get(22).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(23).Locked = True
        Me.fpSearch_Search.Columns.Get(23).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(24).Locked = True
        Me.fpSearch_Search.Columns.Get(24).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(25).Locked = True
        Me.fpSearch_Search.Columns.Get(25).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(26).Locked = True
        Me.fpSearch_Search.Columns.Get(26).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(27).Locked = True
        Me.fpSearch_Search.Columns.Get(27).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(28).Locked = True
        Me.fpSearch_Search.Columns.Get(28).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(29).Locked = True
        Me.fpSearch_Search.Columns.Get(29).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(30).Locked = True
        Me.fpSearch_Search.Columns.Get(30).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(31).Locked = True
        Me.fpSearch_Search.Columns.Get(31).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(32).Locked = True
        Me.fpSearch_Search.Columns.Get(32).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(33).Locked = True
        Me.fpSearch_Search.Columns.Get(33).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(34).Locked = True
        Me.fpSearch_Search.Columns.Get(34).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(35).Locked = True
        Me.fpSearch_Search.Columns.Get(35).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(36).Locked = True
        Me.fpSearch_Search.Columns.Get(36).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(37).Locked = True
        Me.fpSearch_Search.Columns.Get(37).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(38).Locked = True
        Me.fpSearch_Search.Columns.Get(38).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(39).Locked = True
        Me.fpSearch_Search.Columns.Get(39).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(40).Locked = True
        Me.fpSearch_Search.Columns.Get(40).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(41).Locked = True
        Me.fpSearch_Search.Columns.Get(41).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(42).Locked = True
        Me.fpSearch_Search.Columns.Get(42).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(43).Locked = True
        Me.fpSearch_Search.Columns.Get(43).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(44).Locked = True
        Me.fpSearch_Search.Columns.Get(44).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(45).Locked = True
        Me.fpSearch_Search.Columns.Get(45).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(46).Locked = True
        Me.fpSearch_Search.Columns.Get(46).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(47).Locked = True
        Me.fpSearch_Search.Columns.Get(47).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(48).Locked = True
        Me.fpSearch_Search.Columns.Get(48).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(49).Locked = True
        Me.fpSearch_Search.Columns.Get(49).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(50).Locked = True
        Me.fpSearch_Search.Columns.Get(50).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(51).Locked = True
        Me.fpSearch_Search.Columns.Get(51).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(52).Locked = True
        Me.fpSearch_Search.Columns.Get(52).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(53).Locked = True
        Me.fpSearch_Search.Columns.Get(53).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(54).Locked = True
        Me.fpSearch_Search.Columns.Get(54).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(55).Locked = True
        Me.fpSearch_Search.Columns.Get(55).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(56).Locked = True
        Me.fpSearch_Search.Columns.Get(56).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(57).Locked = True
        Me.fpSearch_Search.Columns.Get(57).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(58).Locked = True
        Me.fpSearch_Search.Columns.Get(58).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(59).Locked = True
        Me.fpSearch_Search.Columns.Get(59).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(60).Locked = True
        Me.fpSearch_Search.Columns.Get(60).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(61).Locked = True
        Me.fpSearch_Search.Columns.Get(61).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(62).Locked = True
        Me.fpSearch_Search.Columns.Get(62).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(63).Locked = True
        Me.fpSearch_Search.Columns.Get(63).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(64).Locked = True
        Me.fpSearch_Search.Columns.Get(64).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(65).Locked = True
        Me.fpSearch_Search.Columns.Get(65).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(66).Locked = True
        Me.fpSearch_Search.Columns.Get(66).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(67).Locked = True
        Me.fpSearch_Search.Columns.Get(67).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(68).Locked = True
        Me.fpSearch_Search.Columns.Get(68).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(69).Locked = True
        Me.fpSearch_Search.Columns.Get(69).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(70).Locked = True
        Me.fpSearch_Search.Columns.Get(70).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(71).Locked = True
        Me.fpSearch_Search.Columns.Get(71).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(72).Locked = True
        Me.fpSearch_Search.Columns.Get(72).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(73).Locked = True
        Me.fpSearch_Search.Columns.Get(73).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(74).Locked = True
        Me.fpSearch_Search.Columns.Get(74).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(75).Locked = True
        Me.fpSearch_Search.Columns.Get(75).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(76).Locked = True
        Me.fpSearch_Search.Columns.Get(76).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(77).Locked = True
        Me.fpSearch_Search.Columns.Get(77).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(78).Locked = True
        Me.fpSearch_Search.Columns.Get(78).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(79).Locked = True
        Me.fpSearch_Search.Columns.Get(79).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(80).Locked = True
        Me.fpSearch_Search.Columns.Get(80).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(81).Locked = True
        Me.fpSearch_Search.Columns.Get(81).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(82).Locked = True
        Me.fpSearch_Search.Columns.Get(82).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(83).Locked = True
        Me.fpSearch_Search.Columns.Get(83).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(84).Locked = True
        Me.fpSearch_Search.Columns.Get(84).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(85).Locked = True
        Me.fpSearch_Search.Columns.Get(85).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(86).Locked = True
        Me.fpSearch_Search.Columns.Get(86).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(87).Locked = True
        Me.fpSearch_Search.Columns.Get(87).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(88).Locked = True
        Me.fpSearch_Search.Columns.Get(88).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(89).Locked = True
        Me.fpSearch_Search.Columns.Get(89).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(90).Locked = True
        Me.fpSearch_Search.Columns.Get(90).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(91).Locked = True
        Me.fpSearch_Search.Columns.Get(91).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(92).Locked = True
        Me.fpSearch_Search.Columns.Get(92).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(93).Locked = True
        Me.fpSearch_Search.Columns.Get(93).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(94).Locked = True
        Me.fpSearch_Search.Columns.Get(94).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(95).Locked = True
        Me.fpSearch_Search.Columns.Get(95).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(96).Locked = True
        Me.fpSearch_Search.Columns.Get(96).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(97).Locked = True
        Me.fpSearch_Search.Columns.Get(97).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(98).Locked = True
        Me.fpSearch_Search.Columns.Get(98).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.Columns.Get(99).Locked = True
        Me.fpSearch_Search.Columns.Get(99).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.fpSearch_Search.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.fpSearch_Search.RowHeader.Columns.Default.Resizable = False
        Me.fpSearch_Search.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.fpSearch_Search.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.Both
        Me.fpSearch_Search.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.fpSearch_Search.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'palCriteria
        '
        Me.palCriteria.Controls.Add(Me.txtSearch)
        Me.palCriteria.Controls.Add(Me.cmbFill)
        Me.palCriteria.Controls.Add(Me.Label3)
        Me.palCriteria.Controls.Add(Me.Label2)
        Me.palCriteria.Location = New System.Drawing.Point(3, 28)
        Me.palCriteria.Name = "palCriteria"
        Me.palCriteria.Size = New System.Drawing.Size(414, 47)
        Me.palCriteria.TabIndex = 7
        Me.palCriteria.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(102, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 20)
        Me.txtSearch.TabIndex = 9
        '
        'cmbFill
        '
        Me.cmbFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFill.FormattingEnabled = True
        Me.cmbFill.Location = New System.Drawing.Point(102, 2)
        Me.cmbFill.Name = "cmbFill"
        Me.cmbFill.Size = New System.Drawing.Size(106, 21)
        Me.cmbFill.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filter : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search with : "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.palCriteria)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.cmbBy)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 75)
        Me.Panel3.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(423, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 65)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Find..."
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbBy
        '
        Me.cmbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBy.FormattingEnabled = True
        Me.cmbBy.Location = New System.Drawing.Point(105, 6)
        Me.cmbBy.Name = "cmbBy"
        Me.cmbBy.Size = New System.Drawing.Size(149, 21)
        Me.cmbBy.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by  : "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 58)
        Me.Panel1.TabIndex = 6
        '
        'btnSelect
        '
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(37, 14)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 35)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "Select"
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(600, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(94, 58)
        Me.Panel2.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(7, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 35)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 390)
        Me.Controls.Add(Me.fpSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.fpSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpSearch_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palCriteria.ResumeLayout(False)
        Me.palCriteria.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fpSearch As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpSearch_Search As FarPoint.Win.Spread.SheetView
    Friend WithEvents palCriteria As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbFill As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bsSearch As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
