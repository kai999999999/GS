Public Class frmProcessNewJob

    Private Sub frmProcessNewJob_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmProcessBarcode.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        cmbBarcodeID.Items.Clear()
        cmbBarcode.Items.Clear()
        cmbBarcodeName.Items.Clear()
        txtBarcode.Text = ""
        txtBarcodeName.Text = ""
        ComboBox1.SelectedIndex = 0
        TextBox8.Text = "0.00"
        TextBox7.Text = "0.00"
        TextBox6.Text = "0.00"
        Sql = "SELECT Barcode,Type,Name,SIZE,UNIT,RULER_SIZE,BARCODE_SCAN,BARCODE_NAME,WEIGHT_NOOSE,WEIGHT_FOOT,WEIGHT_LINE FROM vBarcode Order by Barcode"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "Barcode")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("Barcode").Rows.Count > 0 Then
                    For i As Integer = 0 To dtResult.Tables("Barcode").Rows.Count - 1
                        cmbBarcodeID.Items.Add(dtResult.Tables("Barcode").Rows(i)("Barcode").ToString.Trim)
                        cmbBarcode.Items.Add(dtResult.Tables("Barcode").Rows(i)("BARCODE_SCAN").ToString.Trim)
                        cmbBarcodeName.Items.Add(dtResult.Tables("Barcode").Rows(i)("BARCODE_NAME").ToString.Trim)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub cmbBarcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBarcode.SelectedIndexChanged
        txtBarcode.Text = cmbBarcode.Text
        cmbBarcodeName.SelectedIndex = cmbBarcode.SelectedIndex
        txtBarcodeName.Text = cmbBarcodeName.Text
        cmbBarcodeID.SelectedIndex = cmbBarcode.SelectedIndex
        Sql = GetDescr("select max(BarcodeNo) from Jobs where Barcode='" & cmbBarcode.SelectedIndex + 1 & "' and BarcodeYM='" & Format(Date.Now, "yyMM") & "'")(2)
        If Not IsNumeric(Sql) Then
            Sql = "0"
        End If
        txtYearMonth.Text = Format(Date.Now, "yyMM")
        txtAutoNumber.Text = Format(CInt(Sql) + 1, "00#")
        txtBarcode.Text = cmbBarcode.Text & Format(Date.Now, "yyMM") & Format(CInt(Sql) + 1, "00#")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtBarcode.Text.Trim <> "" And txtBarcodeName.Text.Trim <> "" And txtLotDescr.Text.Trim <> "" Then
            If Not IsNumeric(TextBox8.Text.Trim) Then TextBox8.Text = "0"
            If Not IsNumeric(TextBox7.Text.Trim) Then TextBox7.Text = "0"
            If MessageBox.Show("คุณต้องการที่จะบันทึกข้อมูล Lot เลขที่ " & txtLot.Text.Trim & " ใช่หรือไม่?", "บันทึกข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If SaveData() Then
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย...", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้!!!", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้!!!" & vbCrLf & "กรุณาใส่ข้อมูลให้ครบถ้วน..!", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function SaveData() As Boolean
        SaveData = False
        Try
            Sql = GetDescr("select max(BarcodeNo) from Jobs where Barcode='" & cmbBarcode.SelectedIndex + 1 & "' and BarcodeYM='" & Format(Date.Now, "yyMM") & "'")(2)
            If Not IsNumeric(Sql) Then
                Sql = "0"
            End If
            txtYearMonth.Text = Format(Date.Now, "yyMM")
            txtAutoNumber.Text = Format(CInt(Sql) + 1, "00#")
            txtBarcode.Text = cmbBarcode.Text & Format(Date.Now, "yyMM") & Format(CInt(Sql) + 1, "00#")

            Sql = "INSERT INTO Jobs([Lot],[JobType],[น้ำหนักทอง],[เศษ],[Barcode],[LastStatus],[CreateUser],[CreateUpdate],[UserID],[UserUpdate],[BarcodeText],[BarcodeYM],[BarcodeNo])"
            Sql = Sql & " VALUES('" & txtLot.Text.Trim & "'," & ComboBox1.SelectedIndex + 1 & "," & CDbl(TextBox8.Text.Trim) & "," & CDbl(TextBox7.Text.Trim) & ",'" & cmbBarcodeID.Text.Trim & "',0,'" & UserLogon.Trim & "',GETDATE(),'" & UserLogon & "',GETDATE(),'" & txtBarcode.Text.Trim & "','" & txtYearMonth.Text.Trim & "','" & txtAutoNumber.Text.Trim & "')"
            If QueryScript(Sql) Then
                SaveData = True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With frmPrintBarcode
            .txtBarcode.Text = txtBarcode.Text.Trim
            .txtBarcodeName.Text = txtBarcodeName.Text.Trim
            .TextBox1.ReadOnly = False
            .TextBox3.Text = ""
            .txtSubBarcode.Text = ""
            .TextBox1.Text = ""
            .dtpDate.Value = Date.Now
            .TextBox2.Text = Format(CDbl(TextBox8.Text.Trim), "#,##0.00")
            .Timer1.Start()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox8.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        Timer2.Stop()
        If Not IsNumeric(TextBox8.Text.Trim) Then TextBox8.Text = "0.00"
        TextBox6.Text = Format(CDbl(TextBox8.Text.Trim) + CDbl(TextBox7.Text.Trim), "#,##0.00")
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

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
        If Not IsNumeric(TextBox7.Text.Trim) Then TextBox7.Text = "0.00"
        TextBox6.Text = Format(CDbl(TextBox8.Text.Trim) + CDbl(TextBox7.Text.Trim), "#,##0.00")
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        strCaption = "Finder - Barcode"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Barcode,Name,SIZE,UNIT,RULER_SIZE,BARCODE_SCAN,BARCODE_NAME,WEIGHT_NOOSE,WEIGHT_FOOT,WEIGHT_LINE"
        strSqlFrom = "vBarcode"
        strSqlWhere = ""
        strSqlOrderBy = "Barcode"
        frmSearch.ShowDialog()
        If IsNumeric(dataField.Trim) Then
            cmbBarcode.SelectedIndex = CInt(dataField) - 1
        End If
        dataField = ""
    End Sub
End Class