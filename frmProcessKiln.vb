Public Class frmProcessKiln
    Dim Tab As Integer = 0
    Dim spW As New System.Media.SoundPlayer("Ding.wav")
    Dim spE As New System.Media.SoundPlayer("tada.wav")
    Sub CleatData()
        'GroupBox5.Enabled = False
        Button3.Enabled = False
        Button9.Enabled = False
        Button5.Text = "จบรายการ"
        Button5.Enabled = False
        DateTimePicker9.Value = Date.Now
        txtLotCode.Text = ""
        txtBarcodeID.Text = ""
        txtLotname.Text = ""
        txtBarcode.Text = ""
        txtBarcodeName.Text = ""
        txtKiln.Text = ""
        Process1.Text = "0.00"
        Process2.Text = "0.00"
        Process3.Text = "0.00"
        Process4.Text = "0.00"
        Process5.Text = "0.00"
        Process6.Text = "0.00"
        Process7.Text = "0"
        Process8.Text = "0.00"
        '---
        GroupBox6.Enabled = False
        Button4.Text = "จบรายการ"
        Button4.Enabled = False
        DateTimePicker10.Value = Date.Now
        txtLotCodeT.Text = ""
        txtBarcodeID1.Text = ""
        txtLotnameT.Text = ""
        txtBarcodeT.Text = ""
        txtBarcodeNameT.Text = ""
        txtKilnT.Text = ""
        Process1T.Text = "0.00"
        Process2T.Text = "0.00"
        Process3T.Text = "0.00"
        Process4T.Text = "0.00"
        Process5T.Text = "0.00"
        Process6T.Text = "0.00"
        Process7T.Text = "0.00"
        Process8T.Text = "0.00"
        Process9T.Text = "0.00"
        Process10T.Text = "0.00"
        Process11T.Text = "0.00"
    End Sub

    Sub CheckSum1()
        Dim a As Double = 0
        Dim b As Double = 0
        If IsNumeric(Process2.Text.Trim) Then
            a = CDbl(Process2.Text.Trim)
        End If
        If IsNumeric(Process3.Text.Trim) Then
            b = CDbl(Process3.Text.Trim)
        End If
        Process4.Text = Format((a + b), "#,##0.00")
        Process5.Text = Format((CDbl(Process1.Text) - (a + b)), "#,##0.00")
        Process6.Text = Format((CDbl(Process1.Text) - (a + b)), "#,##0.00")
    End Sub

    Sub CheckSum2()
        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim e As Double = 0
        Dim f As Double = 0
        If IsNumeric(Process1T.Text.Trim) Then
            a = CDbl(Process1T.Text.Trim)
        End If
        If IsNumeric(Process2T.Text.Trim) Then
            b = CDbl(Process2T.Text.Trim)
        End If
        If IsNumeric(Process4T.Text.Trim) Then
            c = CDbl(Process4T.Text.Trim)
        End If
        If IsNumeric(Process5T.Text.Trim) Then
            d = CDbl(Process5T.Text.Trim)
        End If
        If IsNumeric(Process6T.Text.Trim) Then
            e = CDbl(Process6T.Text.Trim)
        End If
        If IsNumeric(Process7T.Text.Trim) Then
            f = CDbl(Process7T.Text.Trim)
        End If
        Process3T.Text = Format((a + b), "#,##0.00")
        Process8T.Text = Format((c + d + e + f), "#,##0.00")
        Process9T.Text = Format((CDbl(Process3T.Text) - (c + d + e + f)), "#,##0.00")
        'Process10T.Text = Format((CDbl(Process3T.Text) - (CDbl(Process8T.Text) + CDbl(Process9T.Text))), "#,##0.00")
        Process10T.Text = Format((CDbl(Process3T.Text) - (CDbl(Process8T.Text) + CDbl(Process9T.Text))), "#,##0.00")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmProcessTimer.Timer1.Start()
        frmProcessTimer.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Tab = 1
        CleatData()
        Timer1.Start()
        Sql = "DROP TABLE [Weight]"
        QueryScript(Sql)
        Application.DoEvents()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Tab = 2
        CleatData()
        Timer1.Start()
        Sql = "DROP TABLE [WeightDetail]"
        QueryScript(Sql)
        Application.DoEvents()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            fpKiln1.Visible = False
            fpKiln2.Visible = False
            lblWait.Visible = True
            Application.DoEvents()
            fpKiln1_Sheet1.RowCount = 0
            fpKiln2_Sheet1.RowCount = 0
            If Tab = 1 Then
                If ComboBox1.SelectedIndex > 0 Then
                    Sql = "select * from vProcessKiln where JobType=1 and LastStatus='" & ComboBox1.Text.Trim & "'"
                Else
                    Sql = "select * from vProcessKiln where JobType=1"
                End If
                If TextBox1.Text.Trim <> "" Then
                    Sql = Sql & " and Lot='" & TextBox1.Text.Trim & "'"
                End If
                If TextBox2.Text.Trim <> "" Then
                    Sql = Sql & " and (BARCODE_SCAN Like '%" & TextBox2.Text.Trim & "%' OR BARCODE_NAME Like '%" & TextBox2.Text.Trim & "%')"
                End If
                If dtpCreateFrom.Checked Then
                    If dtpCreateTo.Checked Then
                        Sql = Sql & " and (JobCreateUpdate BETWEEN '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateTo.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (JobCreateUpdate BETWEEN '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
                If dtpUpdateFrom.Checked Then
                    If dtpUpdateTo.Checked Then
                        Sql = Sql & " and (JobUserUpdate BETWEEN '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateTo.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (JobUserUpdate BETWEEN '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
            ElseIf Tab = 2 Then
                If ComboBox2.SelectedIndex > 0 Then
                    Sql = "select * from vProcessKiln where JobType=2 and LastStatus='" & ComboBox2.Text.Trim & "'"
                Else
                    Sql = "select * from vProcessKiln where JobType=2"
                End If
                If TextBox4.Text.Trim <> "" Then
                    Sql = Sql & " and Lot='" & TextBox4.Text.Trim & "'"
                End If
                If TextBox3.Text.Trim <> "" Then
                    Sql = Sql & " and (BARCODE_SCAN Like '%" & TextBox3.Text.Trim & "%' OR BARCODE_NAME Like '%" & TextBox3.Text.Trim & "%')"
                End If
                If dtpCreateFrom1.Checked Then
                    If dtpCreateTo1.Checked Then
                        Sql = Sql & " and (JobCreateUpdate BETWEEN '" & dtpCreateFrom1.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateTo1.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (JobCreateUpdate BETWEEN '" & dtpCreateFrom1.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateFrom1.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
                If dtpUpdateFrom1.Checked Then
                    If dtpUpdateTo1.Checked Then
                        Sql = Sql & " and (JobUserUpdate BETWEEN '" & dtpUpdateFrom1.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateTo1.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (JobUserUpdate BETWEEN '" & dtpUpdateFrom1.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateFrom1.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
            Else
                Exit Sub
            End If
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessKiln")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessKiln").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessKiln").Rows.Count - 1
                            Select Case Tab
                                Case 1
                                    With fpKiln1_Sheet1
                                        .RowCount = .RowCount + 1
                                        .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessKiln").Rows(i)("Lot").ToString.Trim
                                        .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessKiln").Rows(i)("LotName").ToString.Trim
                                        .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessKiln").Rows(i)("Barcode").ToString.Trim
                                        .Cells(.RowCount - 1, 3).Text = dtResult.Tables("ProcessKiln").Rows(i)("BarcodeText").ToString.Trim
                                        .Cells(.RowCount - 1, 4).Text = dtResult.Tables("ProcessKiln").Rows(i)("BARCODE_NAME").ToString.Trim
                                        .Cells(.RowCount - 1, 5).Text = dtResult.Tables("ProcessKiln").Rows(i)("Timer").ToString.Trim
                                        .Cells(.RowCount - 1, 6).Text = dtResult.Tables("ProcessKiln").Rows(i)("LastStatus").ToString
                                        .Cells(.RowCount - 1, 7).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process1")
                                        .Cells(.RowCount - 1, 8).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process2")
                                        .Cells(.RowCount - 1, 9).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process3")
                                        .Cells(.RowCount - 1, 10).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process4")
                                        .Cells(.RowCount - 1, 11).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process5")
                                        .Cells(.RowCount - 1, 12).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process6")
                                        .Cells(.RowCount - 1, 13).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process7").ToString.Trim
                                        .Cells(.RowCount - 1, 14).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process8")
                                        Application.DoEvents()
                                    End With
                                Case 2
                                    With fpKiln2_Sheet1
                                        .RowCount = .RowCount + 1
                                        .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessKiln").Rows(i)("Lot").ToString.Trim
                                        .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessKiln").Rows(i)("LotName").ToString.Trim
                                        .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessKiln").Rows(i)("Barcode").ToString.Trim
                                        .Cells(.RowCount - 1, 3).Text = dtResult.Tables("ProcessKiln").Rows(i)("BarcodeText").ToString.Trim
                                        .Cells(.RowCount - 1, 4).Text = dtResult.Tables("ProcessKiln").Rows(i)("BARCODE_NAME").ToString.Trim
                                        .Cells(.RowCount - 1, 5).Text = dtResult.Tables("ProcessKiln").Rows(i)("Timer").ToString.Trim
                                        .Cells(.RowCount - 1, 6).Text = dtResult.Tables("ProcessKiln").Rows(i)("LastStatus").ToString
                                        .Cells(.RowCount - 1, 7).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process1")
                                        .Cells(.RowCount - 1, 8).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process2")
                                        .Cells(.RowCount - 1, 9).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process3")
                                        .Cells(.RowCount - 1, 10).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process4")
                                        .Cells(.RowCount - 1, 11).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process5")
                                        .Cells(.RowCount - 1, 12).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process6")
                                        If Not IsNumeric(dtResult.Tables("ProcessKiln").Rows(i)("Process7").ToString.Trim) Then
                                            .Cells(.RowCount - 1, 13).Text = "0.00"
                                        Else
                                            .Cells(.RowCount - 1, 13).Text = Format(CDbl(dtResult.Tables("ProcessKiln").Rows(i)("Process7")), "#,##0.00")
                                        End If
                                        .Cells(.RowCount - 1, 14).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process8")
                                        .Cells(.RowCount - 1, 15).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process9")
                                        .Cells(.RowCount - 1, 16).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process10")
                                        .Cells(.RowCount - 1, 17).Text = dtResult.Tables("ProcessKiln").Rows(i)("Process11")
                                        Application.DoEvents()
                                    End With
                                Case Else
                                    Application.DoEvents()
                            End Select
                        Next
                    End If
                End If
            End If
            fpKiln1.Visible = True
            fpKiln2.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        Catch ex As Exception
            fpKiln1.Visible = True
            fpKiln2.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        End Try
    End Sub

    Private Sub fpKiln1_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpKiln1.CellClick

    End Sub

    Private Sub fpKiln1_EnterCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EnterCellEventArgs) Handles fpKiln1.EnterCell
        CleatData()
        With fpKiln1_Sheet1
            txtLotCode.Text = .Cells(.ActiveRowIndex, 0).Text.Trim
            txtLotname.Text = .Cells(.ActiveRowIndex, 1).Text.Trim
            txtBarcodeID.Text = .Cells(.ActiveRowIndex, 2).Text.Trim
            txtBarcode.Text = .Cells(.ActiveRowIndex, 3).Text.Trim
            txtBarcodeName.Text = .Cells(.ActiveRowIndex, 4).Text.Trim
            txtKiln.Text = .Cells(.ActiveRowIndex, 5).Text.Trim
            Process1.Text = .Cells(.ActiveRowIndex, 7).Text.Trim
            Process2.Text = .Cells(.ActiveRowIndex, 8).Text.Trim
            Process3.Text = .Cells(.ActiveRowIndex, 9).Text.Trim
            Process4.Text = .Cells(.ActiveRowIndex, 10).Text.Trim
            Process5.Text = .Cells(.ActiveRowIndex, 11).Text.Trim
            Process6.Text = .Cells(.ActiveRowIndex, 12).Text.Trim
            Process7.Text = .Cells(.ActiveRowIndex, 13).Text.Trim
            Process8.Text = .Cells(.ActiveRowIndex, 14).Text.Trim
            If .Cells(e.Row, 6).Text = "ใหม่" Then
                Button5.Text = "เพิ่มข้อมูลลงเตา"
                Button5.Enabled = True
            ElseIf .Cells(e.Row, 6).Text = "ตั้งเวลา" Then
                Button5.Text = "แก้ไขข้อมูลลงเตา"
                Button5.Enabled = True
            End If
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'GroupBox5.Enabled = True
        Button5.Enabled = False
        If Button5.Text = "เพิ่มข้อมูลลงเตา" Then
            Button3.Enabled = True
            Button9.Enabled = False
            Dim a0 As Double = 0
            Dim a1 As Double = 0
            Dim a2 As Double = 0
            Dim a3 As Double = 0
            Sql = GetDescr("select top 1 [ส่งกล้า] from ProcessCut Where [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a0 = CDbl(Sql)
                Process1.Text = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([สรุปหาย]) from ProcessCut Where [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a1 = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([สรุปหาย]) from ProcessSend Where [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a2 = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([สรุปหาย]) from ProcessModify Where [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a3 = Format(CDbl(Sql), "#,##0.00")
            End If
            'Process5.Text = Format(CDbl((a0 - (a2 + a3))), "#,##0.00")
            CheckSum1()
        Else
            Button3.Enabled = True
            Button9.Enabled = True
            'Sql = GetDescr("select SUM([ส่งกล้า]) from ProcessCut Where [Lot]='" & TextBox7.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "'")(2)
            'If IsNumeric(Sql) Then
            '    TextBox11.Text = Format(CDbl(Sql), "#,##0.00")
            '    CheckSum1()
            'End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtLotCode.Text.Trim <> "" And txtBarcode.Text.Trim <> "" And txtKiln.Text.Trim <> "" Then
            Dim SType As Integer = 21
            If MessageBox.Show("You want to save data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKiln.Text.Trim & "'"
                Sql = Sql & ",CreateUser='" & UserLogon & "'"
                Sql = Sql & ",CreateUpdate='" & DateTimePicker9.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",LastStatus=1 WHERE [Timer]='' AND [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                QueryScript(Sql)
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKiln.Text.Trim & "'"
                'Sql = Sql & ",CreateUser='" & UserLogon & "'"
                'Sql = Sql & ",CreateUpdate='" & DateTimePicker9.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",Process1=" & CDbl(Process1.Text.Trim)
                Sql = Sql & ",Process2=" & CDbl(Process2.Text.Trim)
                Sql = Sql & ",Process3=" & CDbl(Process3.Text.Trim)
                Sql = Sql & ",Process4=" & CDbl(Process4.Text.Trim)
                Sql = Sql & ",Process5=" & CDbl(Process5.Text.Trim)
                Sql = Sql & ",Process6=" & CDbl(Process6.Text.Trim)
                Sql = Sql & ",Process7='" & Process7.Text.Trim & "'"
                Sql = Sql & ",Process8=" & CDbl(Process8.Text.Trim)
                Sql = Sql & ",UserID='" & UserLogon & "'"
                Sql = Sql & ",UserUpdate=GETDATE()"
                Sql = Sql & ",LastStatus=1 WHERE [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    UpdateJob(txtLotCode.Text.Trim, txtBarcodeID.Text.Trim, txtBarcode.Text.Trim)
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleatData()
                    Timer1.Start()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ใส่ข้อมูลให้ครบถ้วยก่อนการบันทึก", "save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If txtLotCode.Text.Trim <> "" And txtBarcode.Text.Trim <> "" And txtKiln.Text.Trim <> "" Then
            Dim SType As Integer = 22
            If MessageBox.Show("You want to save data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKiln.Text.Trim & "'"
                Sql = Sql & ",Process1=" & CDbl(Process1.Text.Trim)
                Sql = Sql & ",Process2=" & CDbl(Process2.Text.Trim)
                Sql = Sql & ",Process3=" & CDbl(Process3.Text.Trim)
                Sql = Sql & ",Process4=" & CDbl(Process4.Text.Trim)
                Sql = Sql & ",Process5=" & CDbl(Process5.Text.Trim)
                Sql = Sql & ",Process6=" & CDbl(Process6.Text.Trim)
                Sql = Sql & ",Process7=" & CDbl(Process7.Text.Trim)
                Sql = Sql & ",Process8=" & CDbl(Process8.Text.Trim)
                Sql = Sql & ",UserID='" & UserLogon & "'"
                Sql = Sql & ",UserUpdate=GETDATE()"
                Sql = Sql & ",LastStatus=2 WHERE [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE ProcessTimer set LastStatus=2,UserID='" & UserLogon & "',UserUpdate=GETDATE() WHERE Name='" & txtKiln.Text.Trim & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "'"
                    QueryScript(Sql)
                    'Sql = "UPDATE [Lot] SET [LastStatus]=3 WHERE [Lot]='" & TextBox7.Text.Trim & "'"
                    'QueryScript(Sql)
                    Application.DoEvents()
                    DDataUpdate()
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleatData()
                    Timer1.Start()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ใส่ข้อมูลให้ครบถ้วยก่อนการบันทึก", "save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        strCaption = "Finder - ข้อมูลเตา"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Name, Date,HH, MM, SS"
        strSqlFrom = "ProcessTimer"
        strSqlWhere = "LastStatus=0"
        strSqlOrderBy = "Name"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtKiln.Text = dataField
        End If
        dataField = ""
    End Sub

    Private Sub frmProcessKiln_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If UserLogon.Trim.ToUpper = "ADMIN" Then
            Button14.Visible = True
            Button15.Visible = True
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.SelectedIndex = 0
        dtpCreateFrom.Checked = False
        dtpCreateTo.Checked = False
        dtpUpdateTo.Checked = False
        dtpUpdateFrom.Checked = False
        fpKiln1_Sheet1.RowCount = 0
        TextBox4.Text = ""
        TextBox3.Text = ""
        ComboBox2.SelectedIndex = 0
        dtpCreateFrom1.Checked = False
        dtpCreateTo1.Checked = False
        dtpUpdateFrom1.Checked = False
        dtpUpdateTo1.Checked = False
        fpKiln2_Sheet1.RowCount = 0
        CleatData()
    End Sub

    Private Sub fpKiln2_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpKiln2.CellClick

    End Sub

    Private Sub fpKiln2_EnterCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EnterCellEventArgs) Handles fpKiln2.EnterCell
        CleatData()
        With fpKiln2_Sheet1
            txtLotCodeT.Text = .Cells(.ActiveRowIndex, 0).Text.Trim
            txtLotnameT.Text = .Cells(.ActiveRowIndex, 1).Text.Trim
            txtBarcodeID1.Text = .Cells(.ActiveRowIndex, 2).Text.Trim
            txtBarcodeT.Text = .Cells(.ActiveRowIndex, 3).Text.Trim
            txtBarcodeNameT.Text = .Cells(.ActiveRowIndex, 4).Text.Trim
            txtKilnT.Text = .Cells(.ActiveRowIndex, 5).Text.Trim
            Process1T.Text = .Cells(.ActiveRowIndex, 7).Text.Trim
            Process2T.Text = .Cells(.ActiveRowIndex, 8).Text.Trim
            Process3T.Text = .Cells(.ActiveRowIndex, 9).Text.Trim
            Process4T.Text = .Cells(.ActiveRowIndex, 10).Text.Trim
            Process5T.Text = .Cells(.ActiveRowIndex, 11).Text.Trim
            Process6T.Text = .Cells(.ActiveRowIndex, 12).Text.Trim
            Process7T.Text = .Cells(.ActiveRowIndex, 13).Text.Trim
            Process8T.Text = .Cells(.ActiveRowIndex, 14).Text.Trim
            Process9T.Text = .Cells(.ActiveRowIndex, 15).Text.Trim
            Process10T.Text = .Cells(.ActiveRowIndex, 16).Text.Trim
            Process11T.Text = .Cells(.ActiveRowIndex, 17).Text.Trim
            If .Cells(e.Row, 6).Text = "ใหม่" Then
                Button4.Text = "เพิ่มข้อมูลลงเตา"
                Button4.Enabled = True
            ElseIf .Cells(e.Row, 6).Text = "ตั้งเวลา" Then
                Button4.Text = "แก้ไขข้อมูลลงเตา"
                Button4.Enabled = True
            End If
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox6.Enabled = True
        Button4.Enabled = False
        If Button4.Text = "เพิ่มข้อมูลลงเตา" Then
            Button11.Enabled = True
            Button10.Enabled = False
            'Sql = GetDescr("select SUM([ทอเสร็จ]) from ProcessWeave Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "'")(2)
            'If IsNumeric(Sql) Then
            '    Process2T.Text = Format(CDbl(Sql), "#,##0.00")
            '    CheckSum1()
            'End If
            Sql = GetDescr("select SUM([น้ำหนักส่งลดรู]) from ProcessReduce Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                Process1T.Text = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([น้ำประสานเกิน]) from ProcessWeld Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                Process2T.Text = Format(CDbl(Sql), "#,##0.00")
            End If
            Dim a1 As Double = 0
            Dim a2 As Double = 0
            Dim a3 As Double = 0
            Dim a4 As Double = 0
            Sql = GetDescr("select SUM([หาย]) from ProcessWeave Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a1 = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([หาย]) from ProcessWeld Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a2 = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([หาย]) from ProcessWeld Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a3 = Format(CDbl(Sql), "#,##0.00")
            End If
            Sql = GetDescr("select SUM([สรุปหาย]) from ProcessReduce Where [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'")(2)
            If IsNumeric(Sql) Then
                a4 = Format(CDbl(Sql), "#,##0.00")
            End If
            'Process9T.Text = Format((a1 + a2 + a3 + a4), "#,##0.00")
            CheckSum2()
        Else
            Button11.Enabled = True
            Button10.Enabled = True
            'Sql = GetDescr("select SUM([ทอเสร็จ]) from ProcessWeave Where [Lot]='" & TextBox17.Text.Trim & "' And Barcode='" & txtBarcodeID1.Text.Trim & "'")(2)
            'If IsNumeric(Sql) Then
            '    TextBox23.Text = Format(CDbl(Sql), "#,##0.00")
            '    CheckSum1()
            'End If
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If txtLotCodeT.Text.Trim <> "" And txtBarcodeT.Text.Trim <> "" And txtKilnT.Text.Trim <> "" Then
            Dim SType As Integer = 21
            If MessageBox.Show("You want to save data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKilnT.Text.Trim & "'"
                Sql = Sql & ",CreateUser='" & UserLogon & "'"
                Sql = Sql & ",CreateUpdate='" & DateTimePicker10.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",LastStatus=1 WHERE [Timer]='' AND [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                QueryScript(Sql)
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKilnT.Text.Trim & "'"
                'Sql = Sql & ",CreateUser='" & UserLogon & "'"
                'Sql = Sql & ",CreateUpdate='" & DateTimePicker10.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ",Process1=" & CDbl(Process1T.Text.Trim)
                Sql = Sql & ",Process2=" & CDbl(Process2T.Text.Trim)
                Sql = Sql & ",Process3=" & CDbl(Process3T.Text.Trim)
                Sql = Sql & ",Process4=" & CDbl(Process4T.Text.Trim)
                Sql = Sql & ",Process5=" & CDbl(Process5T.Text.Trim)
                Sql = Sql & ",Process6=" & CDbl(Process6T.Text.Trim)
                Sql = Sql & ",Process7=" & Format(CDbl(Process7T.Text.Trim), "#,##0.00")
                Sql = Sql & ",Process8=" & CDbl(Process8T.Text.Trim)
                Sql = Sql & ",Process9=" & CDbl(Process9T.Text.Trim)
                Sql = Sql & ",Process10=" & CDbl(Process10T.Text.Trim)
                Sql = Sql & ",Process11=" & CDbl(Process11T.Text.Trim)
                Sql = Sql & ",UserID='" & UserLogon & "'"
                Sql = Sql & ",UserUpdate=GETDATE()"
                Sql = Sql & ",LastStatus=1 WHERE [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    UpdateJob(txtLotCodeT.Text.Trim, txtBarcodeID1.Text.Trim, txtBarcodeT.Text.Trim)
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleatData()
                    Timer1.Start()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ใส่ข้อมูลให้ครบถ้วยก่อนการบันทึก", "save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If txtLotCodeT.Text.Trim <> "" And txtBarcodeT.Text.Trim <> "" And txtKilnT.Text.Trim <> "" Then
            Dim SType As Integer = 22
            If MessageBox.Show("You want to save data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE ProcessKiln SET [Timer]='" & txtKilnT.Text.Trim & "'"
                Sql = Sql & ",Process1=" & CDbl(Process1T.Text.Trim)
                Sql = Sql & ",Process2=" & CDbl(Process2T.Text.Trim)
                Sql = Sql & ",Process3=" & CDbl(Process3T.Text.Trim)
                Sql = Sql & ",Process4=" & CDbl(Process4T.Text.Trim)
                Sql = Sql & ",Process5=" & CDbl(Process5T.Text.Trim)
                Sql = Sql & ",Process6=" & CDbl(Process6T.Text.Trim)
                Sql = Sql & ",Process7=" & CDbl(Process7T.Text.Trim)
                Sql = Sql & ",Process8=" & CDbl(Process8T.Text.Trim)
                Sql = Sql & ",Process9=" & CDbl(Process9T.Text.Trim)
                Sql = Sql & ",Process10=" & CDbl(Process10T.Text.Trim)
                Sql = Sql & ",Process11=" & CDbl(Process11T.Text.Trim)
                Sql = Sql & ",UserID='" & UserLogon & "'"
                Sql = Sql & ",UserUpdate=GETDATE()"
                Sql = Sql & ",LastStatus=2 WHERE [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE ProcessTimer set LastStatus=2,UserID='" & UserLogon & "',UserUpdate=GETDATE() WHERE Name='" & txtKilnT.Text.Trim & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    DDataUpdate()
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleatData()
                    Timer1.Start()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ใส่ข้อมูลให้ครบถ้วยก่อนการบันทึก", "save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        strCaption = "Finder - ข้อมูลเตา"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Name, Date,HH, MM, SS"
        strSqlFrom = "ProcessTimer"
        strSqlWhere = "LastStatus=0"
        strSqlOrderBy = "Name"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtKilnT.Text = dataField
        End If
        dataField = ""
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        txtTime.Text = Date.Now().ToString("dd/MM/yyyy HH:mm:ss")
        With fpTimer_Sheet1
            If .RowCount > 0 Then
                For i As Integer = 0 To .RowCount - 1
                    If .Cells(i, 0).Text.Trim <> "" Then
                        If IsDate(.Cells(i, 4).Value) Then
                            If Format(CDate(.Cells(i, 4).Value), "yyyy-MM-dd HH:mm:ss") <= Format(DateAdd(DateInterval.Second, 5, Date.Now), "yyyy-MM-dd HH:mm:ss") And Format(CDate(.Cells(i, 4).Value), "yyyy-MM-dd HH:mm:ss") > Format(DateAdd(DateInterval.Second, 0, Date.Now), "yyyy-MM-dd HH:mm:ss") Then
                                .Rows(i).BackColor = Color.Yellow
                                If .Cells(i, 5).Value Then
                                    spW.Play()
                                    Exit For
                                End If
                            ElseIf Format(CDate(.Cells(i, 4).Value), "yyyy-MM-dd HH:mm:ss") <= Format(DateAdd(DateInterval.Second, 0, Date.Now), "yyyy-MM-dd HH:mm:ss") Then
                                .Rows(i).BackColor = Color.Red
                                If .Cells(i, 5).Value Then
                                    spE.Play()
                                    .Cells(i, 5).Value = False
                                    Exit For
                                End If
                            End If
                            Application.DoEvents()
                        End If
                    End If
                Next
            End If
        End With
    End Sub

    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process2.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process2.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process2.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process2.Text.Trim) Then Process2.Text = "0.00"
        CheckSum1()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process2.TextChanged

    End Sub

    Private Sub TextBox9_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process3.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process3.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process3.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process3.Text.Trim) Then Process3.Text = "0.00"
        CheckSum1()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process3.TextChanged

    End Sub

    'Private Sub TextBox19_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process7.LostFocus
    '    If Not IsNumeric(Process7.Text.Trim) Then Process7.Text = "0.00"
    'End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process7.TextChanged

    End Sub

    Private Sub Process8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process8.GotFocus
        Timer2.Start()
    End Sub

    Private Sub Process8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process8.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process8.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process8.Text.Trim) Then Process8.Text = "0.00"
        CheckSum1()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process8.TextChanged

    End Sub

    Private Sub TextBox28_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process4T.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox28_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process4T.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process4T.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox28_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process4T.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process4T.Text.Trim) Then Process4T.Text = "0.00"
        CheckSum2()
    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process4T.TextChanged

    End Sub

    Private Sub TextBox26_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process5T.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox26_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process5T.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process5T.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox26_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process5T.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process5T.Text.Trim) Then Process5T.Text = "0.00"
        CheckSum2()
    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process5T.TextChanged

    End Sub

    Private Sub TextBox25_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process6T.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox25_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process6T.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process6T.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox25_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process6T.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process6T.Text.Trim) Then Process6T.Text = "0.00"
        CheckSum2()
    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process6T.TextChanged

    End Sub

    Private Sub TextBox24_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process7T.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox24_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process7T.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process7T.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox24_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process7T.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process7T.Text.Trim) Then Process7T.Text = "0.00"
        CheckSum2()
    End Sub

    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process7T.TextChanged

    End Sub

    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process10T.LostFocus
        If Not IsNumeric(Process10T.Text.Trim) Then Process10T.Text = "0.00"
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process10T.TextChanged

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            fpTimer.Visible = False
            lblWait.Visible = True
            Application.DoEvents()
            If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then End
            With fpTimer_Sheet1
                .RowCount = 0
                Sql = "select * from vProcessKiln where (JobType=1 or JobType=2) and LastStatus='ตั้งเวลา'"
                'Sql = "SELECT Lot,Descr,Barcode,BARCODE_SCAN,BARCODE_NAME,JobType,LastStatus,StatusName,CreateUpdate,UserUpdate FROM vJobs Where LastStatus=21 Order by Lot desc"

                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "Timer")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("Timer").Rows.Count > 0 Then
                            For i As Integer = 0 To dtResult.Tables("Timer").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Timer").Rows(i)("Timer").ToString.Trim
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Timer").Rows(i)("BarcodeText").ToString.Trim
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Timer").Rows(i)("BARCODE_NAME").ToString.Trim
                                If dtResult.Tables("Timer").Rows(i)("JobType") = 1 Then
                                    .Cells(.RowCount - 1, 3).Text = "ทรงเครื่อง"
                                Else
                                    .Cells(.RowCount - 1, 3).Text = "สร้อยทอ"
                                End If
                                .Cells(.RowCount - 1, 4).Text = ""
                                If dtResult.Tables("Timer").Rows(i)("Date").ToString <> "" Then
                                    Sql = Format(dtResult.Tables("Timer").Rows(i)("Date"), "yyyy-MM-dd") & " " & dtResult.Tables("Timer").Rows(i)("HH").ToString.Trim & ":" & dtResult.Tables("Timer").Rows(i)("MM").ToString.Trim & ":" & dtResult.Tables("Timer").Rows(i)("SS").ToString.Trim
                                    If IsDate(Sql) Then
                                        .Cells(.RowCount - 1, 4).Value = CDate(Sql)
                                    End If
                                End If
                                .Cells(.RowCount - 1, 5).Value = True
                                Application.DoEvents()
                            Next
                        End If
                    End If
                End If
            End With
            fpTimer.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
            Sql = "DROP TABLE [Weight]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [WeightDetail]"
            QueryScript(Sql)
            Application.DoEvents()
        Catch ex As Exception
            fpTimer.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub Process11T_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process11T.GotFocus
        Timer2.Start()
    End Sub

    Private Sub Process11T_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Process11T.KeyDown
        If e.KeyCode = Keys.Enter Then
            Process11T.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub Process11T_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Process11T.LostFocus
        Timer2.Stop()
        If Not IsNumeric(Process11T.Text.Trim) Then Process11T.Text = "0.00"
        CheckSum2()
    End Sub

    Private Sub Process11T_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process11T.TextChanged

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim SType As Integer = 15
        If UserLogon.Trim.ToUpper = "ADMIN" Then
            If MessageBox.Show("You want to back data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE [ProcessSaw]"
                Sql = Sql & " SET [LastStatus] = 1"
                Sql = Sql & " WHERE [Lot] = '" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                    If QueryScript(Sql) Then
                        If Button4.Text.Trim = "แก้ไขข้อมูลลงเตา" Then
                            Sql = "DELETE FROM ProcessKiln WHERE [Lot]='" & txtLotCodeT.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID1.Text.Trim) & "' And BarcodeText='" & txtBarcodeT.Text.Trim & "'"
                            QueryScript(Sql)
                        End If
                    End If
                    Application.DoEvents()
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim SType As Integer = 4
        If UserLogon.Trim.ToUpper = "ADMIN" Then
            If MessageBox.Show("You want to back data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE [ProcessModify]"
                Sql = Sql & " SET [LastStatus] = 1"
                Sql = Sql & " WHERE [Lot] = '" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE [Jobs]"
                    Sql = Sql & " SET [LastStatus] = " & SType
                    Sql = Sql & " WHERE [Lot] = '" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                    If QueryScript(Sql) Then
                        If Button4.Text.Trim = "แก้ไขข้อมูลลงเตา" Then
                            Sql = "DELETE FROM ProcessKiln WHERE [Lot]='" & txtLotCode.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                            QueryScript(Sql)
                        End If
                    End If
                    Application.DoEvents()
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class