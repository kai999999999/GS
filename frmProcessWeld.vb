Public Class frmProcessWeld
    Dim Edit As Boolean
    Sub clearText()
        Button3.Enabled = False
        Button9.Enabled = False
        Button8.Enabled = False
        Sql = GetDescr("select Max(Weld) From ProcessWeld Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
        If IsNumeric(Sql) Then
            txtCode1.Text = CInt(Sql) + 1
        Else
            txtCode1.Text = "1"
        End If
        txtEmpID.Text = ""
        txtEmpName.Text = ""
        DateTimePicker1.Value = Date.Now
        TextBox10.Text = "0.00"
        TextBox1.Text = "0.00"
        TextBox2.Text = "0.00"
        TextBox3.Text = "0.00"
        TextBox9.Text = "0.00"
        TextBox6.Text = "0.00"
        TextBox7.Text = "0.00"
        TextBox20.Text = "0.00"
        TextBox19.Text = "0.00"
        Button4.Enabled = True
        Button5.Enabled = True
        fpWeave.Enabled = True
        fpWeld.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtCode.Text.Trim <> "" Then
            clearText()
            fpWeave.Enabled = False
            'GroupBox5.Enabled = True
            Button3.Enabled = True
            Button9.Enabled = True
            fpWeave.Enabled = False
            fpWeld.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then End
            'TextBox10.Text = fpWeave_Sheet1.Cells(fpWeave_Sheet1.ActiveRowIndex, 4).Value
            Edit = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'GroupBox5.Enabled = False
        Button3.Enabled = False
        Button9.Enabled = False
        fpWeave_Sheet1.RowCount = 0
        fpWeld_Sheet1.RowCount = 0
        With fpTotal_Sheet1
            .Cells(0, 0).Value = 0
            .Cells(0, 1).Value = 0
            .Cells(0, 2).Value = 0
            .Cells(0, 3).Value = 0
            .Cells(0, 4).Value = 0
            .Cells(0, 5).Value = 0
            .Cells(0, 6).Value = 0
            .Cells(0, 7).Value = 0
            .Cells(0, 8).Value = 0
        End With
        With fpWeave_Sheet1
            .RowCount = 0
            Sql = "select * from ProcessWeave where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessWeave")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessWeave").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessWeave").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessWeave").Rows(i)("Weave").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessWeave").Rows(i)("CreateUser").ToString.Trim
                            .Cells(.RowCount - 1, 2).Value = CDate(dtResult.Tables("ProcessWeave").Rows(i)("CreateUpdate"))
                            .Cells(.RowCount - 1, 3).Value = dtResult.Tables("ProcessWeave").Rows(i)("น้ำหนักส่งทอ")
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("ProcessWeave").Rows(i)("ทอเสร็จ")
                            .Cells(.RowCount - 1, 5).Value = dtResult.Tables("ProcessWeave").Rows(i)("เศษ")
                            .Cells(.RowCount - 1, 6).Value = dtResult.Tables("ProcessWeave").Rows(i)("หาย")
                        Next
                    End If
                End If
            End If
        End With
        With fpWeld_Sheet1
            .RowCount = 0
            Sql = "select * from ProcessWeld where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessWeld")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessWeld").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessWeld").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessWeld").Rows(i)("Weld").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessWeld").Rows(i)("Weave").ToString.Trim
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessWeld").Rows(i)("CreateUser").ToString.Trim
                            .Cells(.RowCount - 1, 3).Value = CDate(dtResult.Tables("ProcessWeld").Rows(i)("CreateUpdate"))
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("ProcessWeld").Rows(i)("น้ำหนักก่อนต้ม")
                            .Cells(.RowCount - 1, 5).Value = dtResult.Tables("ProcessWeld").Rows(i)("น้ำหนักหลังต้ม")
                            .Cells(.RowCount - 1, 6).Value = dtResult.Tables("ProcessWeld").Rows(i)("หายต้ม")
                            .Cells(.RowCount - 1, 7).Value = dtResult.Tables("ProcessWeld").Rows(i)("ก่อนเชื่อม")
                            .Cells(.RowCount - 1, 8).Value = dtResult.Tables("ProcessWeld").Rows(i)("น้ำประสาน")
                            .Cells(.RowCount - 1, 9).Value = dtResult.Tables("ProcessWeld").Rows(i)("หลังเชื่อม")
                            .Cells(.RowCount - 1, 10).Value = dtResult.Tables("ProcessWeld").Rows(i)("น้ำประสานเกิน")
                            .Cells(.RowCount - 1, 11).Value = dtResult.Tables("ProcessWeld").Rows(i)("เศษ")
                            .Cells(.RowCount - 1, 12).Value = dtResult.Tables("ProcessWeld").Rows(i)("หาย")
                            fpTotal_Sheet1.Cells(0, 0).Value = dtResult.Tables("ProcessWeld").Rows(i)("น้ำหนักก่อนต้ม")
                            fpTotal_Sheet1.Cells(0, 1).Value = fpTotal_Sheet1.Cells(0, 1).Value + dtResult.Tables("ProcessWeld").Rows(i)("น้ำหนักหลังต้ม")
                            fpTotal_Sheet1.Cells(0, 2).Value = fpTotal_Sheet1.Cells(0, 2).Value + dtResult.Tables("ProcessWeld").Rows(i)("หายต้ม")
                            fpTotal_Sheet1.Cells(0, 3).Value = fpTotal_Sheet1.Cells(0, 3).Value + dtResult.Tables("ProcessWeld").Rows(i)("ก่อนเชื่อม")
                            fpTotal_Sheet1.Cells(0, 4).Value = fpTotal_Sheet1.Cells(0, 4).Value + dtResult.Tables("ProcessWeld").Rows(i)("น้ำประสาน")
                            fpTotal_Sheet1.Cells(0, 5).Value = fpTotal_Sheet1.Cells(0, 5).Value + dtResult.Tables("ProcessWeld").Rows(i)("หลังเชื่อม")
                            fpTotal_Sheet1.Cells(0, 6).Value = fpTotal_Sheet1.Cells(0, 6).Value + dtResult.Tables("ProcessWeld").Rows(i)("น้ำประสานเกิน")
                            fpTotal_Sheet1.Cells(0, 7).Value = fpTotal_Sheet1.Cells(0, 7).Value + dtResult.Tables("ProcessWeld").Rows(i)("เศษ")
                            fpTotal_Sheet1.Cells(0, 8).Value = fpTotal_Sheet1.Cells(0, 8).Value + dtResult.Tables("ProcessWeld").Rows(i)("หาย")
                        Next
                    End If
                End If
            End If
            Button2.Enabled = False
            Button5.Enabled = True
            fpWeave.Enabled = True
            Button10.Enabled = False
            If .RowCount > 0 Then
                If dtResult.Tables("ProcessWeld").Rows(0)("LastStatus") <= 1 Then
                    Button2.Enabled = True
                Else
                    Button4.Enabled = False
                    Button5.Enabled = False
                End If
            Else
                Button10.Enabled = True
            End If
        End With
    End Sub

    Sub CheckSum()
        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim e As Double = 0
        Dim f As Double = 0
        If IsNumeric(TextBox10.Text.Trim) Then
            a = CDbl(TextBox10.Text.Trim)
        End If
        If IsNumeric(TextBox1.Text.Trim) Then
            b = CDbl(TextBox1.Text.Trim)
        End If
        If IsNumeric(TextBox6.Text.Trim) Then
            c = CDbl(TextBox6.Text.Trim)
        End If
        If IsNumeric(TextBox3.Text.Trim) Then
            d = CDbl(TextBox3.Text.Trim)
        End If
        If IsNumeric(TextBox7.Text.Trim) Then
            e = CDbl(TextBox7.Text.Trim)
        End If
        If IsNumeric(TextBox20.Text.Trim) Then
            f = CDbl(TextBox20.Text.Trim)
        End If
        'TextBox3.Text = Format(b, "#,##0.00")
        TextBox2.Text = Format((a - b), "#,##0.00")
        TextBox7.Text = Format((c - d + f), "#,##0.00")
        TextBox19.Text = Format(d - (c + f), "#,##0.00")
        If Not IsNumeric(TextBox1.Text.Trim) Then TextBox1.Text = "0.00"
    End Sub

    Private Sub fpWeave_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpWeave.CellClick

    End Sub

    Private Sub fpWeave_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpWeave.LeaveCell
        If fpWeave_Sheet1.RowCount > 0 Then
            If e.NewRow >= 0 Then
                txtCode.Text = fpWeave_Sheet1.Cells(e.NewRow, 0).Text.Trim
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("You want to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Not Edit Then
                Sql = GetDescr("select Max(Weld) From ProcessWeld Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
                If IsNumeric(Sql) Then
                    txtCode1.Text = CInt(Sql) + 1
                Else
                    txtCode1.Text = "1"
                End If
                Sql = "INSERT INTO [ProcessWeld] VALUES "
                Sql = Sql & " ('" & txtLot.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcodeID.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcode.Text.Trim & "'"
                Sql = Sql & ", '" & txtCode.Text.Trim & "'"
                Sql = Sql & ", '" & txtCode1.Text.Trim & "'"
                Sql = Sql & ", '" & txtEmpName.Text.Trim & "'"
                Sql = Sql & ", '" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ", " & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox1.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox2.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox3.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox6.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox20.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox19.Text.Trim)
                Sql = Sql & ", 0"
                Sql = Sql & ", '" & UserLogon & "'"
                Sql = Sql & ", GETDATE())"
            Else
                Sql = "UPDATE [ProcessWeld]"
                Sql = Sql & "SET "
                Sql = Sql & "[CreateUpdate] = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",[น้ำหนักก่อนต้ม] = " & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ",[น้ำหนักหลังต้ม] = " & CDbl(TextBox1.Text.Trim)
                Sql = Sql & ",[หายต้ม] = " & CDbl(TextBox2.Text.Trim)
                Sql = Sql & ",[ก่อนเชื่อม] = " & CDbl(TextBox3.Text.Trim)
                Sql = Sql & ",[น้ำประสาน] = " & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ",[หลังเชื่อม] = " & CDbl(TextBox6.Text.Trim)
                Sql = Sql & ",[น้ำประสานเกิน] = " & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ",[เศษ] = " & CDbl(TextBox20.Text.Trim)
                Sql = Sql & ",[หาย] = " & CDbl(TextBox19.Text.Trim)
                Sql = Sql & ",[UserID] = '" & UserLogon & "'"
                Sql = Sql & ",[UserUpdate] = GETDATE()"
                Sql = Sql & "WHERE [Lot] = '" & txtLot.Text.Trim & "' AND [Barcode] = '" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' AND [Weave] = '" & txtCode.Text.Trim & "' AND [Weld] = '" & txtCode1.Text.Trim & "'"
            End If
            If QueryScript(Sql) Then
                UpdateJob(txtLot.Text.Trim, txtBarcodeID.Text.Trim, txtBarcode.Text.Trim)
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCode.Text = ""
                clearText()
                Timer1.Start()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Application.DoEvents()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        clearText()
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SType As Integer = 15
        If MessageBox.Show("You want to send data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessWeld]"
            Sql = Sql & " SET [LastStatus] = 2"
            Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If QueryScript(Sql) Then
                Sql = "UPDATE [Jobs]"
                Sql = Sql & " SET [LastStatus] = " & SType
                Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                QueryScript(Sql)
                Application.DoEvents()
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnFindEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindEmp.Click
        strCaption = "Finder - ข้อมูลพนักงาน"
        dataRet = 0
        dataField = ""
        strSqlSelect = "EmployeeID,Name,Active"
        strSqlFrom = "Employee"
        strSqlWhere = "Active=0"
        strSqlOrderBy = "EmployeeID"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtEmpID.Text = dataField
            txtEmpName.Text = GetDescr("SELECT Name FROM Employee WHERE EmployeeID='" & txtEmpID.Text.Trim & "'")(2)
        End If
        dataField = ""
    End Sub

    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox10.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub TextBox9_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox9.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox20.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox20.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With fpWeld_Sheet1
            If .RowCount > 0 Then
                If .ActiveRowIndex >= 0 Then
                    If .Cells(.ActiveRowIndex, 0).Text.Trim <> "" Then
                        clearText()
                        'GroupBox5.Enabled = True
                        Button3.Enabled = True
                        Button9.Enabled = True
                        fpWeave.Enabled = False
                        fpWeld.Enabled = False
                        Button4.Enabled = False
                        Button5.Enabled = False
                        txtCode1.Text = .Cells(.ActiveRowIndex, 0).Text.Trim
                        txtCode.Text = .Cells(.ActiveRowIndex, 1).Text.Trim
                        txtEmpName.Text = .Cells(.ActiveRowIndex, 2).Text.Trim
                        DateTimePicker1.Value = CDate(.Cells(.ActiveRowIndex, 3).Text.Trim)
                        TextBox10.Text = .Cells(.ActiveRowIndex, 4).Text.Trim
                        TextBox1.Text = .Cells(.ActiveRowIndex, 5).Text.Trim
                        TextBox2.Text = .Cells(.ActiveRowIndex, 6).Text.Trim
                        TextBox3.Text = .Cells(.ActiveRowIndex, 7).Text.Trim
                        TextBox9.Text = .Cells(.ActiveRowIndex, 8).Text.Trim
                        TextBox6.Text = .Cells(.ActiveRowIndex, 9).Text.Trim
                        TextBox7.Text = .Cells(.ActiveRowIndex, 10).Text.Trim
                        TextBox20.Text = .Cells(.ActiveRowIndex, 11).Text.Trim
                        TextBox19.Text = .Cells(.ActiveRowIndex, 12).Text.Trim
                        CheckSum()
                        Edit = True
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If UserLogon.Trim.ToUpper <> "ADMIN" Then
            MessageBox.Show("ส่วนนี้สำหรับ Admin เท่านั้น", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim SType As Integer = 13
        If MessageBox.Show("You want to back data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessWeave]"
            Sql = Sql & " SET [LastStatus] = 1"
            Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If QueryScript(Sql) Then
                Sql = "UPDATE [Jobs]"
                Sql = Sql & " SET [LastStatus] = " & SType
                Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                QueryScript(Sql)
                Application.DoEvents()
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        strCaption = "Finder - ข้อมูลเชื่อม"
        RetCount = 5
        RetField(0) = 0
        RetField(1) = 1
        RetField(2) = 2
        RetField(3) = 3
        RetField(4) = 4
        RetField(5) = 5
        For Sx As Integer = 0 To 5
            RetData(Sx) = ""
        Next
        dataRet = 0
        dataField = ""
        strSqlSelect = "Lot,Descr,Barcode,BarcodeText,BARCODE_NAME,StatusName"
        strSqlFrom = "vJobs"
        strSqlWhere = "JobType=2 and LastStatus>=14"
        strSqlOrderBy = "Lot,Barcode"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            With Me
                .txtLot.Text = RetData(0)
                .txtLotName.Text = RetData(1)
                .txtBarcodeID.Text = RetData(2)
                .txtBarcode.Text = RetData(3)
                .txtBarcodeName.Text = RetData(4)
                .txtStatus.Text = RetData(5)
                .Timer1.Start()
            End With
        End If
        dataField = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If IsNumeric(txtCode1.Text.Trim) Then
            If IsNumeric(txtCode.Text.Trim) Then
                With frmPrintBarcode
                    .txtBarcode.Text = txtBarcode.Text.Trim
                    .txtBarcodeName.Text = txtBarcodeName.Text.Trim
                    .TextBox1.ReadOnly = True
                    .TextBox3.Text = "ชื่อผู้เชื่อม"
                    .TextBox1.Text = txtEmpName.Text.Trim
                    .txtSubBarcode.Text = txtBarcode.Text.Trim & "W" & Format(CInt(txtCode.Text.Trim), "0#") & "W" & Format(CInt(txtCode1.Text.Trim), "0#")
                    .dtpDate.Value = Date.Now
                    .TextBox2.Text = Format(CDbl(TextBox6.Text.Trim), "#,##0.00")
                    .Timer1.Start()
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub fpWeld_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpWeld.CellClick

    End Sub

    Private Sub fpWeld_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpWeld.LeaveCell
        With fpWeld_Sheet1
            If .RowCount > 0 Then
                If e.NewRow >= 0 Then
                    If .Cells(e.NewRow, 0).Text.Trim <> "" Then
                        'clearText()
                        'GroupBox5.Enabled = True
                        'Button3.Enabled = True
                        'Button9.Enabled = True
                        'fpWeave.Enabled = False
                        'fpWeld.Enabled = False
                        'Button4.Enabled = False
                        'Button5.Enabled = False
                        txtCode1.Text = .Cells(e.NewRow, 0).Text.Trim
                        txtCode.Text = .Cells(e.NewRow, 1).Text.Trim
                        txtEmpName.Text = .Cells(e.NewRow, 2).Text.Trim
                        DateTimePicker1.Value = CDate(.Cells(e.NewRow, 3).Text.Trim)
                        TextBox10.Text = .Cells(e.NewRow, 4).Text.Trim
                        TextBox1.Text = .Cells(e.NewRow, 5).Text.Trim
                        TextBox2.Text = .Cells(e.NewRow, 6).Text.Trim
                        TextBox3.Text = .Cells(e.NewRow, 7).Text.Trim
                        TextBox9.Text = .Cells(e.NewRow, 8).Text.Trim
                        TextBox6.Text = .Cells(e.NewRow, 9).Text.Trim
                        TextBox7.Text = .Cells(e.NewRow, 10).Text.Trim
                        TextBox20.Text = .Cells(e.NewRow, 11).Text.Trim
                        TextBox19.Text = .Cells(e.NewRow, 12).Text.Trim
                        CheckSum()
                        Button8.Enabled = True
                        'Edit = True
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        Timer2.Stop()
        CheckSum()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class