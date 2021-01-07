Public Class frmProcessStart

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        TextBox1.Text = "0"
        With fpMelt_Sheet1
            fpMeltSum_Sheet1.Cells(0, 1).Value = 0
            fpMeltSum_Sheet1.Cells(0, 2).Value = 0
            fpMeltSum_Sheet1.Cells(0, 3).Value = 0
            .RowCount = 0
            Sql = "SELECT * FROM Melt WHERE Lot='" & txtLot.Text.Trim & "' Order by Melt"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Melt")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Melt").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("Melt").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Melt").Rows(i)("Melt")
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Melt").Rows(i)("UserUpdate")
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Melt").Rows(i)("MeltType").ToString.Trim
                            .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Melt").Rows(i)("น้ำหนักหลอม")
                            .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Melt").Rows(i)("น้ำหนักลงทอง")
                            .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Melt").Rows(i)("เศษ")
                            fpMeltSum_Sheet1.Cells(0, 1).Value = fpMeltSum_Sheet1.Cells(0, 1).Value + dtResult.Tables("Melt").Rows(i)("น้ำหนักหลอม")
                            fpMeltSum_Sheet1.Cells(0, 2).Value = fpMeltSum_Sheet1.Cells(0, 2).Value + dtResult.Tables("Melt").Rows(i)("น้ำหนักลงทอง")
                            fpMeltSum_Sheet1.Cells(0, 3).Value = fpMeltSum_Sheet1.Cells(0, 3).Value + dtResult.Tables("Melt").Rows(i)("เศษ")
                        Next
                    End If
                End If
            End If
        End With
        With fpSize_Sheet1
            fpSizeSum_Sheet1.Cells(0, 2).Value = 0
            fpSizeSum_Sheet1.Cells(0, 3).Value = 0
            .RowCount = 0
            Sql = "SELECT * FROM vJobs WHERE Lot='" & txtLot.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Jobs")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Jobs").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("Jobs").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("UserUpdate")
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Jobs").Rows(i)("BARCODETEXT")
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Jobs").Rows(i)("BARCODE_NAME")
                            .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Jobs").Rows(i)("น้ำหนักทอง")
                            .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Jobs").Rows(i)("เศษ")
                            .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Jobs").Rows(i)("น้ำหนักทอง") + dtResult.Tables("Jobs").Rows(i)("เศษ")
                            fpSizeSum_Sheet1.Cells(0, 2).Value = fpSizeSum_Sheet1.Cells(0, 2).Value + dtResult.Tables("Jobs").Rows(i)("น้ำหนักทอง")
                            fpSizeSum_Sheet1.Cells(0, 3).Value = fpSizeSum_Sheet1.Cells(0, 3).Value + dtResult.Tables("Jobs").Rows(i)("เศษ")
                        Next
                    End If
                End If
            End If
        End With
        fpSizeSum_Sheet1.Cells(0, 1).Value = fpMeltSum_Sheet1.Cells(0, 2).Value
        With fpTotal_Sheet1
            .Cells(0, 0).Value = 0
            .Cells(0, 1).Value = 0
            .Cells(0, 2).Value = 0
            .Cells(0, 0).Value = fpMeltSum_Sheet1.Cells(0, 1).Value
            .Cells(0, 1).Value = fpSizeSum_Sheet1.Cells(0, 2).Value
            .Cells(0, 2).Value = fpMeltSum_Sheet1.Cells(0, 3).Value + fpSizeSum_Sheet1.Cells(0, 3).Value
        End With
        Sql = GetDescr("SELECT [LastStatus] FROM [Lot] WHERE [Lot]='" & txtLot.Text.Trim & "'")(2)
        If IsNumeric(Sql) Then
            If CInt(Sql) = 0 Then
                Button2.Enabled = True
                Button3.Enabled = True
                Button5.Enabled = True
                Button7.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtLot.Text.Trim <> "" Then
            With frmProcessNewJob
                .txtLot.Text = txtLot.Text.Trim
                .txtLotDescr.Text = txtLotName.Text.Trim
                .ShowDialog()
            End With
            Timer1.Start()
        Else
            MessageBox.Show("กรุณาระบุล๊อตที่ต้องการก่อน...", "Lot", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        strCaption = "ค้นหา - ข้อมูลล๊อต"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Lot,descr"
        strSqlFrom = "Lot"
        strSqlWhere = ""
        strSqlOrderBy = "Lot desc"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtLot.Text = dataField
            txtLotName.Text = GetDescr("SELECT Descr FROM Lot WHERE Lot='" & txtLot.Text.Trim & "'")(2)
            Timer1.Start()
        End If
        dataField = ""
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'frmProcessNewLOT.ShowDialog()
        If MessageBox.Show("ต้องการเพิ่มล๊อตใหม่. ใช่หรือไม่?" & vbCrLf & vbCrLf & "Yes =  เพิ่มล๊อตใหม่" & vbCrLf & "No = ไม่เพิ่ม", "เพิ่มล๊อต", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = GetDescr("select Max(Lot) From Lot Where Lot Like '" & Format(Date.Now, "yy") & "%'")(2)
            If IsNumeric(Sql) Then
                txtLot.Text = CInt(Sql) + 1
            Else
                txtLot.Text = Format(Date.Now, "yy") & "0001"
            End If
            txtLotName.Text = Date.Now.ToString("yyyyMMddHHmmss") & UserLogon.Trim
            If SaveDataLot() Then
                Timer1.Start()
            Else
                MessageBox.Show("Errro lot...", "Lot", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Function SaveDataLot() As Boolean
        SaveDataLot = False
        Try
            Sql = "INSERT INTO Lot([Lot],[Descr],[LastStatus],[CreateUser],[CreateUpdate],[UserID],[UserUpdate])"
            Sql = Sql & " VALUES('" & txtLot.Text.Trim & "','" & txtLotName.Text.Trim & "',0,'" & UserLogon.Trim & "',GETDATE(),'" & UserLogon.Trim & "',GETDATE())"
            QueryScript(Sql)
            Sql = "UPDATE [Lot] SET [Descr]='" & txtLotName.Text.Trim & "',[UserID]='" & UserLogon & "',[UserUpdate]=GETDATE() WHERE [Lot]='" & txtLot.Text.Trim & "'"
            If QueryScript(Sql) Then
                SaveDataLot = True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtLot.Text.Trim <> "" Then
            With frmProcessNewJob1
                .txtMelt.Text = "0"
                .txtLot.Text = txtLot.Text.Trim
                .txtLotDescr.Text = txtLotName.Text.Trim
                .TextBox8.Enabled = True
                .TextBox8.Focus()
                .ShowDialog()
            End With
            Timer1.Start()
        Else
            MessageBox.Show("กรุณาระบุล๊อตที่ต้องการก่อน...", "Lot", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsNumeric(txtLot.Text.Trim) Then
            Dim SType As Integer = 1
            If MessageBox.Show("You want to send data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "UPDATE [Melt] SET [LastStatus]=" & SType & " WHERE [Lot]='" & CInt(txtLot.Text.Trim) & "'"
                If QueryScript(Sql) Then
                    Sql = "UPDATE [Lot] SET [LastStatus]=2 WHERE [Lot]='" & CInt(txtLot.Text.Trim) & "'"
                    QueryScript(Sql)
                    Sql = "UPDATE [Jobs] SET [LastStatus]=" & SType & " WHERE [Lot]='" & CInt(txtLot.Text.Trim) & "'"
                    QueryScript(Sql)
                    Application.DoEvents()
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If IsNumeric(TextBox1.Text.Trim) Then
            If CInt(TextBox1.Text.Trim) > 0 Then
                With frmProcessNewJob1
                    .txtMelt.Text = TextBox1.Text.Trim
                    .txtLot.Text = txtLot.Text.Trim
                    .txtLotDescr.Text = txtLotName.Text.Trim
                    .TextBox8.Enabled = False
                    .TextBox7.Focus()
                    .Timer1.Start()
                    .ShowDialog()
                End With
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub fpMelt_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpMelt.CellClick

    End Sub

    Private Sub fpMelt_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpMelt.LeaveCell
        If fpMelt_Sheet1.Cells(e.NewRow, 0).Text.Trim <> "" Then TextBox1.Text = fpMelt_Sheet1.Cells(e.NewRow, 0).Text.Trim
    End Sub

    Private Sub fpSize_ButtonClicked(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles fpSize.ButtonClicked
        If e.Column = 6 And e.Row >= 0 Then
            With fpSize_Sheet1
                If .Cells(e.Row, 1).Text.Trim <> "" Then
                    frmPrintBarcode.txtBarcode.Text = .Cells(e.Row, 1).Text.Trim
                    frmPrintBarcode.txtBarcodeName.Text = .Cells(e.Row, 2).Text.Trim
                    frmPrintBarcode.TextBox1.ReadOnly = False
                    frmPrintBarcode.TextBox3().Text = ""
                    frmPrintBarcode.txtSubBarcode.Text = ""
                    frmPrintBarcode.dtpDate.Value = Date.Now
                    frmPrintBarcode.TextBox2.Text = Format(CDbl(.Cells(e.Row, 3).Value), "#,##0.00")
                    frmPrintBarcode.Timer1.Start()
                    frmPrintBarcode.ShowDialog()
                End If
            End With
        End If
    End Sub

    Private Sub fpSize_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpSize.CellClick

    End Sub
End Class