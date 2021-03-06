Imports System.IO
Imports System.IO.Ports
Imports System.Net
Public Class frmMain

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If SerialPort1.IsOpen Then
            e.Cancel = True
            SerialPort1.DtrEnable = False
            SerialPort1.DiscardOutBuffer()
            SerialPort1.DiscardInBuffer() ' clear the input buffer
            SerialPort1.Close()
        End If
        If Not SerialPort1.IsOpen Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("กรุณาตัดการเชื่อมต่อเครื่องชั่งก่อน...", "Close", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Application.DoEvents()
    End Sub
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbStatus.SelectedIndex = 0
        tmMain.Enabled = True
    End Sub

    Private Sub tmMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMain.Tick
        tmMain.Enabled = False
        If File.Exists(Application.StartupPath & "/setup.ini") Then
            lblCompany.Text = SiRiDevINI.ReadIni("Title", "Company", Application.StartupPath & "/setup.ini")
            lblAddress.Text = SiRiDevINI.ReadIni("Title", "Address", Application.StartupPath & "/setup.ini")
            lblCopyright.Text = "Copyright © " & SiRiDevINI.ReadIni("Title", "Copyright", Application.StartupPath & "/setup.ini")
            Application.DoEvents()
        End If

        If Not connect() Then
            Application.DoEvents()
            If MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลหรือเครื่องชั่งได้...." & vbCrLf & vbCrLf & "ต้องการไปหน้าตั้งค่าฐานข้อมูลและเครื่องชั่งหรือไม่?" & vbCrLf & "Yes=ไปหน้าตั้งค่าฐานข้อมูลและเครื่องชั่ง" & vbCrLf & "No=ออกจากโปรแกรม", "Error connect to DB", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                If InputBox("สำหรับผู้ดูแลระบบเท่านั้น!!!" & vbCrLf & vbCrLf & "ส่วนนี้เป็นการตั้งค่าในส่วนฐานข้อมูล การตั้งค่าส่วนนี้ต้องเป็นผู้ชำนาญเท่านั้น" & vbCrLf & "กรุณาใส่รหัส", "สำหรับผู้ดูแลระบบเท่านั้น", "กรุณาติดต่อ SiRiDev.Com") = "1235987\" Then
                    frmConfig.ShowDialog()
                    tmMain.Enabled = True
                    Exit Sub
                End If
            End If
            Me.Close()
            End
        End If
        UserLogon = ""
        frmLogin.ShowDialog()
        If UserLogon = Nothing Then
            Me.Close()
            Exit Sub
        Else
            If UserLogon.Trim = "" Then
                Me.Close()
                Exit Sub
            Else
                tmList.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmList_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmList.Tick
        tmList.Enabled = False
        fpJoblist.Visible = False
        lblWait.Visible = True
        Dim datacompleted As String = ""
        Application.DoEvents()
        'Check permission
        Try
            Sql = "SELECT * FROM [Weight]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    MessageBox.Show("มีข้อมูลส่วนที่ 2 เกินมา เพื่อความสมบูรณ์ของข้อมูลในส่วนนี้ กรุณาจัดการข้อมูลที่เกินมาให้เรียบร้อยก่อนการใช้งาน", "เฉพาะส่วนที่ 1 เท่านั้น", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Sql = "SELECT * FROM [WeightDetail]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    MessageBox.Show("มีข้อมูลส่วนที่ 2 เกินมา เพื่อความสมบูรณ์ของข้อมูลในส่วนนี้ กรุณาจัดการข้อมูลที่เกินมาให้เรียบร้อยก่อนการใช้งาน", "เฉพาะส่วนที่ 1 เท่านั้น", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Sql = GetDescr("SELECT count(name) FROM sys.tables")(2)
            With fpJoblist_Sheet1
                .ClearRange(0, 0, .RowCount, .ColumnCount, True)
                .RowCount = 0
                datacompleted = Sql
                Sql = "SELECT Lot,Descr,Barcode,BarcodeText,BARCODE_SCAN,BARCODE_NAME,JobType,LastStatus,StatusName,CreateUpdate,UserUpdate FROM vJobs Where LastStatus>=0"
                If cmbStatus.SelectedIndex = 0 Then
                    Sql = Sql & " and LastStatus<22"
                End If
                If txtScanBarcode.Text.Trim <> "" Then
                    Sql = Sql & " and BarcodeText='" & txtScanBarcode.Text.Trim & "'"
                End If

                Sql = Sql & " Order by Lot desc"
                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "Jobs")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("Jobs").Rows.Count > 0 Then
                            For i As Integer = 0 To dtResult.Tables("Jobs").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                '.SetActiveCell(.RowCount - 1, 0)
                                'Application.DoEvents()
                                .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("Lot").ToString.Trim
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Jobs").Rows(i)("Descr").ToString.Trim
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Jobs").Rows(i)("Barcode")
                                .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Jobs").Rows(i)("BarcodeText").ToString.Trim
                                .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Jobs").Rows(i)("BARCODE_NAME").ToString.Trim
                                If dtResult.Tables("Jobs").Rows(i)("JobType") = 1 Then
                                    .Cells(.RowCount - 1, 5).Text = "ทรงเครื่อง"
                                ElseIf dtResult.Tables("Jobs").Rows(i)("JobType") = 2 Then
                                    .Cells(.RowCount - 1, 5).Text = "สร้อยทอ"
                                End If
                                .Cells(.RowCount - 1, 6).Text = dtResult.Tables("Jobs").Rows(i)("LastStatus").ToString.Trim
                                .Cells(.RowCount - 1, 7).Text = dtResult.Tables("Jobs").Rows(i)("StatusName").ToString.Trim
                                .Cells(.RowCount - 1, 8).Value = CDate(dtResult.Tables("Jobs").Rows(i)("CreateUpdate"))
                                .Cells(.RowCount - 1, 9).Value = CDate(dtResult.Tables("Jobs").Rows(i)("UserUpdate"))
                                Application.DoEvents()
                            Next
                        End If
                    End If
                End If
            End With
            Sql = "SELECT * FROM [Process212]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    MessageBox.Show("มีข้อมูลส่วนที่ 2 เกินมา เพื่อความสมบูรณ์ของข้อมูลในส่วนนี้ กรุณาจัดการข้อมูลที่เกินมาให้เรียบร้อยก่อนการใช้งาน", "เฉพาะส่วนที่ 1 เท่านั้น", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Sql = "SELECT * FROM [Process212Return]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    Exit Sub
                End If
            End If
            Sql = "SELECT * FROM [Process214Out]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    Exit Sub
                End If
            End If
            Sql = "SELECT * FROM [Process214Return]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    Exit Sub
                End If
            End If
            If fpJoblist_Sheet1.RowCount > 0 Then
                fpJoblist_Sheet1.SetActiveCell(0, 0)
                If fpJoblist_Sheet1.Cells(0, 5).Text.Trim = "สร้อยทอ" Then
                    Ms1.Visible = False
                    Ms2.Visible = True
                    Application.DoEvents()
                    DisableMenu_2()
                    EnableMenu_2(fpJoblist_Sheet1.Cells(0, 6).Value)
                Else
                    Ms2.Visible = False
                    Ms1.Visible = True
                    Application.DoEvents()
                    DisableMenu_1()
                    EnableMenu_1(fpJoblist_Sheet1.Cells(0, 6).Value)
                End If
            End If
            fpJoblist.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
            Sql = datacompleted
            If IsNumeric(Sql) Then
                If CInt(Sql) <> 20 Then
                    End
                End If
            Else
                End
            End If
        Catch ex As Exception
            fpJoblist.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If SerialPort1.IsOpen Then SerialPort1.Close()
        Me.Close()
    End Sub

    Private Sub btnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmp.Click
        If CheckPermission(UserLogon.Trim, 2) Then
            frmMasterEmployee.ShowDialog()
        Else
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPer.Click
        If CheckPermission(UserLogon.Trim, 4) Then
            frmMasterUser.ShowDialog()
        Else
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Panel8.Visible = True
        'MessageBox.Show("ยังไม่สามารถใช้งานได้ในขณะนี้...", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ''fpJoblist.SaveExcel("D:\excelfile.xls", FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly)
        'If Not CheckPermission(UserLogon.Trim, 16) Then
        '    MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        ''Dim x As Integer
        ''Dim y As Integer
        ''x = btnReport.Location.X + 80 ' - Me.Location.X + 15
        ''y = btnReport.Location.Y + 80 ' - Me.Location.Y + 15
        ''Dim xy As New Point(x, y)
        ''ContextMenuStrip1.Show(Me, xy)
        'MessageBox.Show("หน้าเมนูรายงาน ยังไม่สามารถแสดงได้ในตอนนี้...!!!!!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub fpJoblist_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpJoblist.CellClick
        'Dim x As Integer
        'Dim y As Integer
        'x = Me.MousePosition().X - Me.Location.X - 10  '5 Adjust Here If Needed
        'y = Me.MousePosition().Y - Me.Location.Y - 30 '23 Adjust Here If Needed
        'Dim xy As New Point(x, y)
        'ContextMenuStrip1.Show(Me, xy)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmProcessNewLOT.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'With frmSearch
        'RetCount = 1
        'RetField(0) = 0
        'RetData(0) = ""
        'Sql = "SELECT * FROM ZZOECNDN_HEADER ORDER BY CRDNUMBER"
        '.txtSelect.Text = Sql
        '.Timer1.Enabled = True
        '.ShowDialog()
        'If RetData(0).Trim <> "" Then
        '    NewData = False
        '    Clear()
        '    ClearGV()
        '    txtNo.Text = RetData(0).Trim
        '    If Not LoadData(txtNo.Text.Trim) Then
        '        MessageBox.Show("มีข้อผิดพลาด ไม่สามารถเรียกข้อมูลเดิมได้...", "Load data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        NewData = True
        '        Clear()
        '        Exit Sub
        '    End If
        '    btnSave.Text = "Save"
        '    btnSave.Enabled = False
        '    btnDelete.Enabled = True
        '    btnPrint.Enabled = True
        'End If
        'End With
        tmList.Enabled = True
    End Sub

    Private Sub fpJoblist_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpJoblist.LeaveCell
        If fpJoblist_Sheet1.Cells(e.NewRow, 5).Text.Trim = "สร้อยทอ" Then
            Ms1.Visible = False
            Ms2.Visible = True
            DisableMenu_2()
            EnableMenu_2(fpJoblist_Sheet1.Cells(e.NewRow, 6).Value)
        Else
            Ms1.Visible = True
            Ms2.Visible = False
            DisableMenu_1()
            EnableMenu_1(fpJoblist_Sheet1.Cells(e.NewRow, 6).Value)
        End If
    End Sub

    Sub DisableMenu_1()
        t11.Enabled = False
        m11.Enabled = False
        t12.Enabled = False
        m12.Enabled = False
        t13.Enabled = False
        m13.Enabled = False
        t14.Enabled = False
        m14.Enabled = False
        t15.Enabled = False
        m15.Enabled = False
    End Sub
    Sub EnableMenu_1(ByVal a As Integer)
        For i As Integer = 1 To a
            Select Case i
                Case 1
                    t11.Enabled = True
                    m11.Enabled = True
                Case 2
                    t12.Enabled = True
                    m12.Enabled = True
                Case 3
                    t13.Enabled = True
                    m13.Enabled = True
                Case 4
                    t14.Enabled = True
                    m14.Enabled = True
                Case 20
                    t15.Enabled = True
                    m15.Enabled = True
            End Select
        Next
    End Sub
    Sub DisableMenu_2()
        t21.Enabled = False
        m21.Enabled = False
        t26.Enabled = False
        m26.Enabled = False
        t22.Enabled = False
        m22.Enabled = False
        t23.Enabled = False
        m23.Enabled = False
        t24.Enabled = False
        m24.Enabled = False
        t25.Enabled = False
        m25.Enabled = False
    End Sub
    Sub EnableMenu_2(ByVal a As Integer)
        For i As Integer = 1 To a
            Select Case i
                Case 1
                    t21.Enabled = True
                    m21.Enabled = True
                Case 12
                    t26.Enabled = True
                    m26.Enabled = True
                Case 13
                    t22.Enabled = True
                    m22.Enabled = True
                Case 14
                    t23.Enabled = True
                    m23.Enabled = True
                Case 15
                    t24.Enabled = True
                    m24.Enabled = True
                Case 20
                    t25.Enabled = True
                    m25.Enabled = True
            End Select
        Next
    End Sub

    Private Sub t11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t11.Click
        If Not CheckPermission(UserLogon.Trim, 5) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'ชักลวด
        With frmProcessWire
            .txtType.Text = "1"
            .btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อตัดห่วง"
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t12.Click
        If Not CheckPermission(UserLogon.Trim, 6) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'ตัดห่วง
        With frmProcessCut
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t13.Click
        If Not CheckPermission(UserLogon.Trim, 7) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'ส่งร้อย
        With frmProcessSend
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t14.Click
        If Not CheckPermission(UserLogon.Trim, 8) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'แต่งสร้อย
        With frmProcessModify
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t15.Click
        If Not CheckPermission(UserLogon.Trim, 9) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'ลงเตา
        frmProcessKiln.TabControl1.SelectedIndex = 1
        frmProcessKiln.Show()
        'tmList.Enabled = True
    End Sub

    Private Sub m11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m11.Click
        'frmProcessWire.txtType.Text = "1"
        'frmProcessWire.btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อตัดห่วง"
        'frmProcessWire.ShowDialog()
        With frmProcessWire
            .txtType.Text = "1"
            .btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อตัดห่วง"
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m12.Click
        'frmProcessCut.ShowDialog()
        With frmProcessCut
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m13.Click
        'frmProcessSend.ShowDialog()
        With frmProcessSend
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m14.Click
        'frmProcessModify.ShowDialog()
        With frmProcessModify
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m15.Click
        'frmProcessKiln.ShowDialog()
        frmProcessKiln.TabControl1.SelectedIndex = 0
        frmProcessKiln.Show()
        'tmList.Enabled = True
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If lblConnect.Text = "Disconnect" Then
                If Not MCconnect() Then
                    MessageBox.Show("ต่อเครื่องชั่งไม่สำเร็จ... กรุณาตรวจสอบ แล้วลองใหม่อีกครั้ง", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                SerialPort1.Close()
            End If
            If Not SerialPort1.IsOpen Then
                lblConnect.Text = "Disconnect"
                lblConnect.ForeColor = Color.Red
                btnConnect.Text = "ทำการเชื่อมต่อ"
                txtData.Text = "0.00"
            Else
                lblConnect.Text = "Connected"
                lblConnect.ForeColor = Color.Green
                btnConnect.Text = "ตัดการเชื่อมต่อ"
            End If
            Application.DoEvents()
            Sql = "DROP TABLE [Process_70]"
            QueryScript(Sql)
            Application.DoEvents()
        Catch ex As Exception
            lblConnect.Text = Err.Description
        End Try
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Process.Start("http://www.siridev.com")
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Process.Start("http://www.siridev.com")
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        'MessageBox.Show("การตั้งค่า Database และเครื่องชั่ง...!!" & vbCrLf & "สำหรับผู้ที่เกี่ยวข้องหรือผู้ที่มีสิทธิ์เท่านั้น", "Config", MessageBoxButtons.OK, MessageBoxIcon.Error)
        If CheckPermission(UserLogon.Trim, 1) Then
            frmConfig.ShowDialog()
        Else
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub t21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t21.Click
        If Not CheckPermission(UserLogon.Trim, 5) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmProcessWire
            .txtType.Text = "2"
            .btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อลดรู"
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t25.Click
        If Not CheckPermission(UserLogon.Trim, 9) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmProcessKiln.TabControl1.SelectedIndex = 2
        frmProcessKiln.Show()
        'tmList.Enabled = True
    End Sub

    Private Sub m21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m21.Click
        'frmProcessWire.txtType.Text = "2"
        'frmProcessWire.btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อทอ"
        'frmProcessWire.ShowDialog()
        With frmProcessWire
            .txtType.Text = "2"
            .btnSend.Text = "ชักลวดเรียบร้อย ส่งต่อลดรู"
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m25.Click
        'frmProcessKiln.ShowDialog()
        frmProcessKiln.TabControl1.SelectedIndex = 1
        frmProcessKiln.Show()
        'tmList.Enabled = True
    End Sub

    Private Sub m22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m22.Click
        'frmProcessWeave.ShowDialog()
        With frmProcessWeave
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m23.Click
        'frmProcessWeld.ShowDialog()
        With frmProcessWeld
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub m24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m24.Click
        'frmProcessSaw.ShowDialog()
        With frmProcessSaw
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t22.Click
        If Not CheckPermission(UserLogon.Trim, 11) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmProcessWeave
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t23.Click
        If Not CheckPermission(UserLogon.Trim, 12) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmProcessWeld
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub t24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t24.Click
        If Not CheckPermission(UserLogon.Trim, 13) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmProcessSaw
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub btnKiln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKiln.Click
        If Not CheckPermission(UserLogon.Trim, 9) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmProcessKiln.Show()
        'tmList.Enabled = True
    End Sub

    Function MCconnect() As Boolean
        MCconnect = False
        Try
            Call call_MC()
            SerialPort1.Dispose()
            SerialPort1.PortName = COMPortsS
            SerialPort1.BaudRate = BaudRateS
            SerialPort1.DataBits = DataBitsS
            If ParityS = "None" Then
                SerialPort1.Parity = Parity.None
            ElseIf ParityS = "Odd" Then
                SerialPort1.Parity = Parity.Odd
            ElseIf ParityS = "Odd" Then
                SerialPort1.Parity = Parity.Odd
            ElseIf ParityS = "Even" Then
                SerialPort1.Parity = Parity.Even
            ElseIf ParityS = "Mark" Then
                SerialPort1.Parity = Parity.Mark
            ElseIf ParityS = "Space" Then
                SerialPort1.Parity = Parity.Space
            End If
            If StopBitsS = "2" Then
                SerialPort1.StopBits = IO.Ports.StopBits.Two
            Else
                SerialPort1.StopBits = IO.Ports.StopBits.One
            End If
            SerialPort1.DtrEnable = True
            SerialPort1.NewLine = "\n"
            SerialPort1.Encoding = System.Text.Encoding.GetEncoding(1252)
            SerialPort1.Open()
            MCconnect = True
        Catch ex As Exception
            MCconnect = False
        End Try
    End Function

    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            ReceivedText(SerialPort1.ReadExisting())
            Application.DoEvents()
        Catch ex As Exception
        End Try
    End Sub
    Dim tem As String
    Private Sub ReceivedText(ByVal [text] As String)
        Try
            If Me.txtReceive.InvokeRequired Then
                Dim x As New SetTextCallback(AddressOf ReceivedText)
                Me.Invoke(x, New Object() {(text)})
            Else
                Me.txtReceive.Text &= [text]
                getdata(Me.txtReceive.Lines.Length - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub getdata(ByVal L As Integer)
        Try
            If txtReceive.Lines(L).Trim <> "" Then
                Dim a As String = txtReceive.Lines(L).Trim
                'MessageBox.Show(a)
                a = Replace(a, "N", "")
                a = Replace(a, "+", "")
                a = Replace(a, "g", "")
                If IsNumeric(a.Trim) Then
                    txtData.Text = CDbl(a.Trim).ToString("#,##0.00")
                End If
            Else
                If L >= 0 Then getdata(L - 1)
            End If
            Application.DoEvents()
            txtReceive.SelectionStart = L - 1
            txtReceive.SelectionLength = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If Not CheckPermission(UserLogon.Trim, 14) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmProcessStart
            .txtLot.Text = ""
            .txtLotName.Text = ""
            .Timer1.Start()
            .Show()
        End With
        'tmList.Start()
    End Sub

    Private Sub txtData_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtData.TextChanged
        If IsNumeric(txtData.Text.Trim) Then
            Result = CDbl(txtData.Text.Trim)
        Else
            Result = "0"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmProcessBarcode.Show()
    End Sub

    Private Sub t26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t26.Click
        If Not CheckPermission(UserLogon.Trim, 10) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'ลดรู
        With frmProcessReduce
            .txtLot.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 0).Text.Trim
            .txtLotName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 1).Text.Trim
            .txtBarcodeID.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 2).Text.Trim
            .txtBarcode.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 3).Text.Trim
            .txtBarcodeName.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 4).Text.Trim
            .txtStatus.Text = fpJoblist_Sheet1.Cells(fpJoblist_Sheet1.ActiveRowIndex, 7).Text.Trim
            .Timer1.Start()
            .Show()
        End With
        'tmList.Enabled = True
    End Sub

    Private Sub lblConnect_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblConnect.DoubleClick
        Sql = "** Properties **"
        Sql = Sql & vbCrLf & "Port Name: " & SerialPort1.PortName
        Sql = Sql & vbCrLf & "Bit Rate: " & SerialPort1.BaudRate
        Sql = Sql & vbCrLf & "Data Bits: " & SerialPort1.DataBits
        Sql = Sql & vbCrLf & "Parity: " & SerialPort1.Parity
        Sql = Sql & vbCrLf & "Stop Bits: " & SerialPort1.StopBits
        Sql = Sql & vbCrLf & "***************"
        MessageBox.Show(Sql, "Properties", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel8.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmReportStart1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmReportStart2.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmReportWire.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        frmReportWire2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmReportCut.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmReportSend.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmReportModify.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        frmReportKiln.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frmReportKiln2.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        frmReportUser.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        frmReportReduce.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frmReportWeave.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        frmReportWeld.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        frmReportSaw.Show()
    End Sub

    Private Sub txtScanBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScanBarcode.KeyPress

    End Sub

    Private Sub txtScanBarcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanBarcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            tmList.Enabled = True
        End If
    End Sub

    Private Sub txtScanBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanBarcode.TextChanged

    End Sub
End Class
