Public Class frmProcessSend
    Dim Edit As Boolean

    Sub clearText()
        Button3.Enabled = False
        Button9.Enabled = False
        Button8.Enabled = False
        Sql = GetDescr("select Max(Send) From ProcessSend Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
        If IsNumeric(Sql) Then
            txtCode1.Text = CInt(Sql) + 1
        Else
            txtCode1.Text = "1"
        End If
        TextBox1.Text = "0.00"
        txtUser.Text = ""
        TextBox7.Text = "0.00"
        TextBox2.Text = ""
        txtEmpID.Text = ""
        txtEmpName.Text = ""
        DateTimePicker1.Value = Date.Now
        TextBox11.Text = "0.00"
        TextBox6.Text = ""
        DateTimePicker2.Value = Date.Now
        TextBox10.Text = "0.00"
        TextBox9.Text = "0.00"
        TextBox20.Text = "0.00"
        TextBox19.Text = "0.00"
        Button4.Enabled = True
        Button5.Enabled = True
        fpCut.Enabled = True
        fpSend.Enabled = True
    End Sub

    Sub CheckSum()
        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        If IsNumeric(TextBox7.Text.Trim) Then
            a = CDbl(TextBox7.Text.Trim)
        End If
        If IsNumeric(TextBox11.Text.Trim) Then
            b = CDbl(TextBox11.Text.Trim)
        End If
        If IsNumeric(TextBox10.Text.Trim) Then
            c = CDbl(TextBox10.Text.Trim)
        End If
        TextBox9.Text = Format((a - (b + c)), "#,##0.00")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtCode.Text.Trim <> "" Then
            clearText()
            'GroupBox5.Enabled = True
            Button3.Enabled = True
            Button9.Enabled = True
            fpCut.Enabled = False
            fpSend.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Sql = GetDescr("select Max(Send) From ProcessSend Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                txtCode1.Text = CInt(Sql) + 1
            Else
                txtCode1.Text = "1"
            End If
            Sql = GetDescr("select [น้ำหนักห่วง] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                TextBox1.Text = Format(CDbl(Sql), "#,##0.00")
                CheckSum()
            End If
            txtUser.Text = GetDescr("select [CreateUser] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
            Edit = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'GroupBox5.Enabled = False
        Button3.Enabled = False
        Button9.Enabled = False
        fpCut_Sheet1.RowCount = 0
        fpSend_Sheet1.RowCount = 0
        With fpTotal_Sheet1
            .Cells(0, 0).Value = 0
            .Cells(0, 1).Value = 0
            .Cells(0, 2).Value = 0
            .Cells(0, 3).Value = 0
            .Cells(0, 4).Value = 0
        End With
        With fpCut_Sheet1
            .RowCount = 0
            Sql = "select * from ProcessCut where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessCut")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessCut").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessCut").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessCut").Rows(i)("Cut").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessCut").Rows(i)("LastStatus").ToString.Trim
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessCut").Rows(i)("CreateUser").ToString.Trim
                            .Cells(.RowCount - 1, 3).Value = CDate(dtResult.Tables("ProcessCut").Rows(i)("CreateUpdate"))
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("ProcessCut").Rows(i)("ส่งกล้า")
                            .Cells(.RowCount - 1, 5).Value = dtResult.Tables("ProcessCut").Rows(i)("น้ำหนักตัด")
                            .Cells(.RowCount - 1, 6).Value = dtResult.Tables("ProcessCut").Rows(i)("น้ำหนักห่วง")
                            .Cells(.RowCount - 1, 7).Value = dtResult.Tables("ProcessCut").Rows(i)("น้ำหนักเศษห่วง")
                            .Cells(.RowCount - 1, 8).Value = dtResult.Tables("ProcessCut").Rows(i)("สรุปหาย")
                            fpTotal_Sheet1.Cells(0, 0).Value = fpTotal_Sheet1.Cells(0, 0).Value + dtResult.Tables("ProcessCut").Rows(i)("น้ำหนักห่วง")
                        Next
                    End If
                End If
            End If
        End With
        With fpSend_Sheet1
            .RowCount = 0
            Sql = "select * from ProcessSend where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessSend")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessSend").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessSend").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessSend").Rows(i)("Send").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessSend").Rows(i)("Cut").ToString.Trim
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessSend").Rows(i)("ชื่อส่งร้อย").ToString.Trim
                            .Cells(.RowCount - 1, 3).Value = CDate(dtResult.Tables("ProcessSend").Rows(i)("UserUpdate"))
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("ProcessSend").Rows(i)("น้ำหนักส่ง")
                            .Cells(.RowCount - 1, 5).Value = dtResult.Tables("ProcessSend").Rows(i)("น้ำหนักเก็บ")
                            .Cells(.RowCount - 1, 6).Value = dtResult.Tables("ProcessSend").Rows(i)("เศษห่วง")
                            .Cells(.RowCount - 1, 7).Value = dtResult.Tables("ProcessSend").Rows(i)("สรุปหาย")
                            .Cells(.RowCount - 1, 8).Value = dtResult.Tables("ProcessSend").Rows(i)("ฟุต")
                            .Cells(.RowCount - 1, 9).Value = dtResult.Tables("ProcessSend").Rows(i)("ห่วง")
                            'fpTotal_Sheet1.Cells(0, 0).Value = 0
                            fpTotal_Sheet1.Cells(0, 1).Value = fpTotal_Sheet1.Cells(0, 1).Value + dtResult.Tables("ProcessSend").Rows(i)("น้ำหนักส่ง")
                            fpTotal_Sheet1.Cells(0, 2).Value = fpTotal_Sheet1.Cells(0, 2).Value + dtResult.Tables("ProcessSend").Rows(i)("น้ำหนักเก็บ")
                            fpTotal_Sheet1.Cells(0, 3).Value = fpTotal_Sheet1.Cells(0, 3).Value + dtResult.Tables("ProcessSend").Rows(i)("เศษห่วง")
                            fpTotal_Sheet1.Cells(0, 4).Value = fpTotal_Sheet1.Cells(0, 4).Value + dtResult.Tables("ProcessSend").Rows(i)("สรุปหาย")
                        Next
                    End If
                End If
            End If
            Button2.Enabled = False
            Button5.Enabled = True
            fpCut.Enabled = True
            Button10.Enabled = False
            If .RowCount > 0 Then
                If dtResult.Tables("ProcessSend").Rows(0)("LastStatus") <= 1 Then
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

    Private Sub fpCut_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpCut.CellClick

    End Sub

    Private Sub fpCut_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpCut.LeaveCell
        If fpCut_Sheet1.RowCount > 0 Then
            If e.NewRow >= 0 Then
                txtCode.Text = fpCut_Sheet1.Cells(e.NewRow, 0).Text.Trim
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("You want to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Not Edit Then
                Sql = GetDescr("select Max(Send) From ProcessSend Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
                If IsNumeric(Sql) Then
                    txtCode1.Text = CInt(Sql) + 1
                Else
                    txtCode1.Text = "1"
                End If
                Sql = "INSERT INTO [ProcessSend] VALUES "
                Sql = Sql & " ('" & txtLot.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcodeID.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcode.Text.Trim & "'"
                Sql = Sql & ", '" & txtCode.Text.Trim & "'"
                Sql = Sql & ", '" & txtCode1.Text.Trim & "'"
                Sql = Sql & ", '" & UserLogon & "'"
                Sql = Sql & ", GETDATE()"
                Sql = Sql & ", '" & txtEmpName.Text.Trim & "'"
                Sql = Sql & ", '" & TextBox6.Text.Trim & "'"
                Sql = Sql & ", " & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox11.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox20.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox19.Text.Trim)
                Sql = Sql & ", 0"
                Sql = Sql & ", '" & TextBox2.Text.Trim & "'"
                Sql = Sql & ", '" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ", '" & TextBox6.Text.Trim & "'"
                Sql = Sql & ", '" & DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ", '" & UserLogon & "'"
                Sql = Sql & ", GETDATE())"
            Else
                Sql = "UPDATE [ProcessSend]"
                Sql = Sql & "SET "
                Sql = Sql & "[ชื่อส่งร้อย] = '" & txtEmpName.Text.Trim & "'"
                Sql = Sql & ",[ชื่อรับคืน] = '" & TextBox6.Text.Trim & "'"
                Sql = Sql & ",[น้ำหนักส่ง] = " & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ",[น้ำหนักเก็บ] = " & CDbl(TextBox11.Text.Trim)
                Sql = Sql & ",[เศษห่วง] = " & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ",[สรุปหาย] = " & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ",[ฟุต] = " & CDbl(TextBox20.Text.Trim)
                Sql = Sql & ",[ห่วง] = " & CDbl(TextBox19.Text.Trim)
                Sql = Sql & ",[SendUser] = '" & TextBox2.Text.Trim & "'"
                Sql = Sql & ",[SendDate] = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",[ReceiveUser] = '" & TextBox6.Text.Trim & "'"
                Sql = Sql & ",[ReceiveDate] = '" & DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",[UserID] = '" & UserLogon & "'"
                Sql = Sql & ",[UserUpdate] = GETDATE()"
                Sql = Sql & "WHERE [Lot] = '" & txtLot.Text.Trim & "' AND [Barcode] = '" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' AND [Cut] = '" & txtCode.Text.Trim & "' AND [Send] = '" & txtCode1.Text.Trim & "'"
            End If
            If QueryScript(Sql) Then
                UpdateJob(txtLot.Text.Trim, txtBarcodeID.Text.Trim, txtBarcode.Text.Trim)
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCode.Text = ""
                If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then End
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
        txtCode.Text = ""
        clearText()
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SType As Integer = 4
        If MessageBox.Show("You want to send data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessSend]"
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

    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        CheckSum()
    End Sub

    Private Sub TextBox11_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox11.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        CheckSum()
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
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        CheckSum()
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

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
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
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub TextBox19_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox19_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox19.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox19.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox19_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TextBox19.Layout
        Timer2.Stop()
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With fpSend_Sheet1
            If .RowCount > 0 Then
                If .ActiveRowIndex >= 0 Then
                    If .Cells(.ActiveRowIndex, 0).Text.Trim <> "" Then
                        clearText()
                        'GroupBox5.Enabled = True
                        Button3.Enabled = True
                        Button9.Enabled = True
                        fpCut.Enabled = False
                        fpSend.Enabled = False
                        Button4.Enabled = False
                        Button5.Enabled = False
                        txtCode1.Text = .Cells(.ActiveRowIndex, 0).Text.Trim
                        txtCode.Text = .Cells(.ActiveRowIndex, 1).Text.Trim
                        Sql = GetDescr("select [น้ำหนักห่วง] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
                        If IsNumeric(Sql) Then
                            TextBox1.Text = Format(CDbl(Sql), "#,##0.00")
                        End If
                        txtUser.Text = GetDescr("select [CreateUser] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
                        txtEmpName.Text = .Cells(.ActiveRowIndex, 2).Text.Trim
                        TextBox2.Text = GetDescr("select [SendUser] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
                        DateTimePicker1.Value = CDate(.Cells(.ActiveRowIndex, 3).Text.Trim)
                        TextBox7.Text = .Cells(.ActiveRowIndex, 4).Text.Trim
                        TextBox11.Text = .Cells(.ActiveRowIndex, 5).Text.Trim
                        TextBox10.Text = .Cells(.ActiveRowIndex, 6).Text.Trim
                        TextBox9.Text = .Cells(.ActiveRowIndex, 7).Text.Trim
                        TextBox20.Text = .Cells(.ActiveRowIndex, 8).Text.Trim
                        TextBox19.Text = .Cells(.ActiveRowIndex, 9).Text.Trim
                        TextBox6.Text = GetDescr("select [ReceiveUser] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
                        DateTimePicker2.Value = GetDescr("select [ReceiveDate] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
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
        Dim SType As Integer = 2
        If MessageBox.Show("You want to back data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessCut]"
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
        strCaption = "Finder - ข้อมูลส่งร้อย"
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
        strSqlWhere = "JobType=1 and LastStatus>=3"
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
                    .TextBox3.Text = "ชื่อคนร้อย"
                    .TextBox1.Text = txtEmpName.Text.Trim
                    .txtSubBarcode.Text = txtBarcode.Text.Trim & "C" & Format(CInt(txtCode.Text.Trim), "0#") & "S" & Format(CInt(txtCode1.Text.Trim), "0#")
                    .dtpDate.Value = Date.Now
                    .TextBox2.Text = Format(CDbl(TextBox7.Text.Trim), "#,##0.00")
                    .Timer1.Start()
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub fpSend_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpSend.CellClick

    End Sub

    Private Sub fpSend_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpSend.LeaveCell
        With fpSend_Sheet1
            If .RowCount > 0 Then
                If e.NewRow >= 0 Then
                    If .Cells(e.NewRow, 0).Text.Trim <> "" Then
                        'clearText()
                        ''GroupBox5.Enabled = True
                        'Button3.Enabled = True
                        'Button9.Enabled = True
                        'fpCut.Enabled = False
                        'fpSend.Enabled = False
                        'Button4.Enabled = False
                        'Button5.Enabled = False
                        txtCode1.Text = .Cells(e.NewRow, 0).Text.Trim
                        txtCode.Text = .Cells(e.NewRow, 1).Text.Trim
                        Sql = GetDescr("select [น้ำหนักห่วง] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
                        If IsNumeric(Sql) Then
                            TextBox1.Text = Format(CDbl(Sql), "#,##0.00")
                        End If
                        txtUser.Text = GetDescr("select [CreateUser] from ProcessCut Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "'")(2)
                        txtEmpName.Text = .Cells(e.NewRow, 2).Text.Trim
                        TextBox2.Text = GetDescr("select [SendUser] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
                        DateTimePicker1.Value = CDate(.Cells(e.NewRow, 3).Text.Trim)
                        TextBox7.Text = .Cells(e.NewRow, 4).Text.Trim
                        TextBox11.Text = .Cells(e.NewRow, 5).Text.Trim
                        TextBox10.Text = .Cells(e.NewRow, 6).Text.Trim
                        TextBox9.Text = .Cells(e.NewRow, 7).Text.Trim
                        TextBox20.Text = .Cells(e.NewRow, 8).Text.Trim
                        TextBox19.Text = .Cells(e.NewRow, 9).Text.Trim
                        TextBox6.Text = GetDescr("select [ReceiveUser] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
                        DateTimePicker2.Value = GetDescr("select [ReceiveDate] from ProcessSend Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And Cut='" & txtCode.Text.Trim & "' And Send='" & txtCode1.Text.Trim & "'")(2)
                        CheckSum()
                        Button8.Enabled = True
                        'Edit = True
                    End If
                End If
            End If
        End With
    End Sub
End Class