Public Class frmProcessReduce
    Dim Edit As Boolean
    Sub clearText()
        Button3.Enabled = False
        Button9.Enabled = False
        Sql = GetDescr("select Max(Cut) From ProcessReduce Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
        If IsNumeric(Sql) Then
            txtCode.Text = CInt(Sql) + 1
        Else
            txtCode.Text = "1"
        End If
        txtUser.Text = UserLogon
        DateTimePicker1.Value = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
        TextBox8.Text = "0.00"
        TextBox7.Text = "0.00"
        TextBox6.Text = "0.00"
        TextBox10.Text = "0.00"
        TextBox9.Text = "0.00"
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        clearText()
        'GroupBox5.Enabled = True
        Button3.Enabled = True
        Button9.Enabled = True
        fpReduce.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        'Sql = GetDescr("select [ชักลวด_ชักลวด] from ProcessWire Where [Lot]='" & txtLot.Text.Trim & "' And [LastStatus]=2 And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
        Sql = GetDescr("select [รีดลาย_รีดลาย] from ProcessWire Where [Lot]='" & txtLot.Text.Trim & "' And [LastStatus]=2 And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
        'เปลี่ยนเป็นน้ำหนักรีดลายแทน 20190916 Line 10/09/2019
        If IsNumeric(Sql) Then
            TextBox8.Text = Format(CDbl(Sql), "#,##0.00")
        End If
        Edit = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'GroupBox5.Enabled = False
        Button3.Enabled = False
        Button9.Enabled = False
        fpReduce.Enabled = True
        With fpTotal_Sheet1
            .Cells(0, 0).Value = 0
            .Cells(0, 1).Value = 0
            .Cells(0, 2).Value = 0
        End With
        With fpReduce_Sheet1
            .RowCount = 0
            Sql = "select * from ProcessReduce where Lot='" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessReduce")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessReduce").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessReduce").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessReduce").Rows(i)("Reduce").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("ProcessReduce").Rows(i)("CreateUser").ToString.Trim
                            .Cells(.RowCount - 1, 2).Value = CDate(dtResult.Tables("ProcessReduce").Rows(i)("CreateUpdate"))
                            .Cells(.RowCount - 1, 3).Value = dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักส่งลดรู")
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักRoll")
                            .Cells(.RowCount - 1, 5).Value = dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักรวม")
                            .Cells(.RowCount - 1, 6).Value = dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักRollลวด")
                            .Cells(.RowCount - 1, 7).Value = dtResult.Tables("ProcessReduce").Rows(i)("สรุปหาย")
                            fpTotal_Sheet1.Cells(0, 0).Value = dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักส่งลดรู")
                            fpTotal_Sheet1.Cells(0, 1).Value = fpTotal_Sheet1.Cells(0, 1).Value + (dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักRollลวด") - dtResult.Tables("ProcessReduce").Rows(i)("น้ำหนักRoll"))
                            fpTotal_Sheet1.Cells(0, 2).Value = fpTotal_Sheet1.Cells(0, 2).Value + dtResult.Tables("ProcessReduce").Rows(i)("สรุปหาย")
                        Next
                    End If
                End If
            End If
            Button2.Enabled = False
            Button5.Enabled = True
            Button10.Enabled = False
            If .RowCount > 0 Then
                If dtResult.Tables("ProcessReduce").Rows(0)("LastStatus") <= 1 Then
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
        If IsNumeric(TextBox8.Text.Trim) Then
            a = CDbl(TextBox8.Text.Trim)
        End If
        If IsNumeric(TextBox7.Text.Trim) Then
            b = CDbl(TextBox7.Text.Trim)
        End If
        If IsNumeric(TextBox10.Text.Trim) Then
            c = CDbl(TextBox10.Text.Trim)
        End If
        TextBox6.Text = Format((a + b), "#,##0.00")
        TextBox9.Text = Format(((a + b) - c), "#,##0.00")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("You want to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Not Edit Then
                Sql = GetDescr("select Max(Cut) From ProcessReduce Where Lot='" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'")(2)
                If IsNumeric(Sql) Then
                    txtCode.Text = CInt(Sql) + 1
                Else
                    txtCode.Text = "1"
                End If
                Sql = "INSERT INTO [ProcessReduce] VALUES "
                Sql = Sql & " ('" & txtLot.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcodeID.Text.Trim & "'"
                Sql = Sql & ", '" & txtBarcode.Text.Trim & "'"
                Sql = Sql & ", '" & txtCode.Text.Trim & "'"
                Sql = Sql & ", '" & txtUser.Text.Trim & "'"
                Sql = Sql & ", '" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ", " & CDbl(TextBox8.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox6.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ", " & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ", 0"
                Sql = Sql & ", '" & UserLogon & "'"
                Sql = Sql & ", GETDATE())"
            Else
                Sql = "UPDATE [ProcessReduce] SET [น้ำหนักส่งลดรู]=" & CDbl(TextBox8.Text.Trim)
                Sql = Sql & ",[น้ำหนักRoll]=" & CDbl(TextBox7.Text.Trim)
                Sql = Sql & ",[น้ำหนักรวม]=" & CDbl(TextBox6.Text.Trim)
                Sql = Sql & ",[น้ำหนักRollลวด]=" & CDbl(TextBox10.Text.Trim)
                Sql = Sql & ",[สรุปหาย]=" & CDbl(TextBox9.Text.Trim)
                Sql = Sql & ",[UserID]='" & UserLogon & "'"
                Sql = Sql & ",[UserUpdate]=GETDATE()"
                Sql = Sql & " WHERE [Lot]='" & txtLot.Text.Trim & "' AND [Barcode]='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "' AND [Reduce]='" & txtCode.Text.Trim & "'"
            End If
            If QueryScript(Sql) Then
                UpdateJob(txtLot.Text.Trim, txtBarcodeID.Text.Trim, txtBarcode.Text.Trim)
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearText()
                Timer1.Start()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Application.DoEvents()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        CheckSum()
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SType As Integer = 13
        If MessageBox.Show("You want to send data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessReduce]"
            Sql = Sql & " SET [LastStatus] = 2"
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        clearText()
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With fpReduce_Sheet1
            If .RowCount > 0 Then
                If .ActiveRowIndex >= 0 Then
                    If .Cells(.ActiveRowIndex, 0).Text.Trim <> "" Then
                        clearText()
                        'GroupBox5.Enabled = True
                        Button3.Enabled = True
                        Button9.Enabled = True
                        fpReduce.Enabled = False
                        Button4.Enabled = False
                        Button5.Enabled = False
                        txtCode.Text = .Cells(.ActiveRowIndex, 0).Text.Trim
                        txtUser.Text = .Cells(.ActiveRowIndex, 1).Text.Trim
                        DateTimePicker1.Value = CDate(.Cells(.ActiveRowIndex, 2).Text.Trim)
                        TextBox8.Text = .Cells(.ActiveRowIndex, 3).Text.Trim
                        TextBox7.Text = .Cells(.ActiveRowIndex, 4).Text.Trim
                        TextBox6.Text = .Cells(.ActiveRowIndex, 5).Text.Trim
                        TextBox10.Text = .Cells(.ActiveRowIndex, 6).Text.Trim
                        TextBox9.Text = .Cells(.ActiveRowIndex, 7).Text.Trim
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
        Dim SType As Integer = 1
        If MessageBox.Show("You want to back data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessWire]"
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
        strCaption = "Finder - ข้อมูลลดรู"
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
        strSqlWhere = "JobType=2 and LastStatus>=12"
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

    Private Sub fpCut_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpReduce.CellClick

    End Sub

    Private Sub fpReduce_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpReduce.LeaveCell
        With fpReduce_Sheet1
            If .RowCount > 0 Then
                If e.NewRow >= 0 Then
                    If .Cells(e.NewRow, 0).Text.Trim <> "" Then
                        'clearText()
                        'GroupBox5.Enabled = True
                        'Button3.Enabled = True
                        'Button9.Enabled = True
                        'fpCut.Enabled = False
                        'Button4.Enabled = False
                        'Button5.Enabled = False
                        txtCode.Text = .Cells(e.NewRow, 0).Text.Trim
                        txtUser.Text = .Cells(e.NewRow, 1).Text.Trim
                        DateTimePicker1.Value = CDate(.Cells(e.NewRow, 2).Text.Trim)
                        TextBox8.Text = .Cells(e.NewRow, 3).Text.Trim
                        TextBox7.Text = .Cells(e.NewRow, 4).Text.Trim
                        TextBox6.Text = .Cells(e.NewRow, 5).Text.Trim
                        TextBox10.Text = .Cells(e.NewRow, 6).Text.Trim
                        TextBox9.Text = .Cells(e.NewRow, 7).Text.Trim
                        CheckSum()
                        'Edit = True
                    End If
                End If
            End If
        End With
    End Sub
End Class