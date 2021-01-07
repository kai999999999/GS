Public Class frmProcess214
    Dim NewAdd As Boolean
    Private Sub frmProcess214_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Sql = "select * from Weight Order by DepID"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "Weight")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("Weight").Rows.Count > 0 Then
                    For i As Integer = 0 To dtResult.Tables("Weight").Rows.Count - 1
                        ComboBox3.Items.Add(dtResult.Tables("Weight").Rows(i)("DepName").ToString.Trim)
                        ComboBox2.Items.Add(dtResult.Tables("Weight").Rows(i)("DepID").ToString.Trim)
                        ComboBox1.Items.Add(dtResult.Tables("Weight").Rows(i)("DepName").ToString.Trim)
                        ComboBox4.Items.Add(dtResult.Tables("Weight").Rows(i)("DepID").ToString.Trim)
                        ComboBox5.Items.Add(dtResult.Tables("Weight").Rows(i)("DepName").ToString.Trim)
                    Next
                End If
            End If
        End If
        Timer1.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Start()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        txtID.Text = "0"
        'Out
        ClearOut()
        Button9.Enabled = False
        With fpOut_Sheet1
            .RowCount = 0
            Sql = "select * from Process214Out where LastStatus=0 Order by [IDAdminOut] Desc"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Process214")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Process214").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("Process214").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Process214").Rows(i)("IDAdminOut").ToString.Trim
                            .Cells(.RowCount - 1, 1).Value = CDate(dtResult.Tables("Process214").Rows(i)("DateOut"))
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Process214").Rows(i)("Detail").ToString.Trim
                            .Cells(.RowCount - 1, 3).Value = dtResult.Tables("Process214").Rows(i)("Weight") 'เบิก
                            .Cells(.RowCount - 1, 4).Value = 0 'คืน
                            .Cells(.RowCount - 1, 5).Value = 0 'คงเหลือ
                            .Cells(.RowCount - 1, 6).Value = 0 'ใช้
                            Application.DoEvents()
                        Next
                    End If
                End If
            End If
        End With
        'Return
        ClearReturn()
        Button8.Enabled = False
        With fpReturn_Sheet1
            .RowCount = 0
            Sql = "select * from Process214Return where LastStatus=0 Order by [IDAdminReturn] Desc"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Process214Re")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Process214Re").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("Process214Re").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Process214Re").Rows(i)("IDAdminReturn").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Process214Re").Rows(i)("IDAdminOut").ToString.Trim
                            .Cells(.RowCount - 1, 2).Value = CDate(dtResult.Tables("Process214Re").Rows(i)("DateReturn"))
                            .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Process214Re").Rows(i)("Detail").ToString.Trim
                            .Cells(.RowCount - 1, 4).Value = dtResult.Tables("Process214Re").Rows(i)("Weight")
                            .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Process214Re").Rows(i)("Remark").ToString.Trim
                            Application.DoEvents()
                        Next
                    End If
                End If
            End If
        End With
    End Sub

    Sub ClearOut()
        NewAdd = False
        Button9.Enabled = False
        Button3.Enabled = False
        ComboBox3.SelectedIndex = -1
        ComboBox3.Text = ""
        DateTimePicker1.Value = Date.Now
        TextBox4.Text = ""
        TextBox1.Text = "0.00"
        ComboBox1.SelectedIndex = -1
        ComboBox1.Text = ""
    End Sub

    Sub ClearReturn()
        Button8.Enabled = False
        Button2.Enabled = False
        ComboBox4.SelectedIndex = -1
        ComboBox4.Text = ""
        DateTimePicker2.Value = Date.Now
        TextBox5.Text = ""
        TextBox2.Text = "0.00"
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ClearOut()
        If fpOut_Sheet1.RowCount > 0 And fpOut_Sheet1.ActiveRowIndex >= 0 Then
            Sql = "SELECT * FROM [Process214Out] WHERE IDAdminOut='" & txtID.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Process214Out")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Process214Out").Rows.Count > 0 Then
                        ComboBox3.Text = dtResult.Tables("Process214Out").Rows(0)("Detail").ToString.Trim
                        DateTimePicker1.Value = CDate(dtResult.Tables("Process214Out").Rows(0)("DateOut"))
                        TextBox4.Text = dtResult.Tables("Process214Out").Rows(0)("Printform").ToString.Trim
                        TextBox1.Text = dtResult.Tables("Process214Out").Rows(0)("Weight").ToString.Trim
                        ComboBox1.Text = dtResult.Tables("Process214Out").Rows(0)("Department").ToString.Trim
                    End If
                End If
            End If
            Button9.Enabled = True
        Else
            MessageBox.Show("ไม่มีรายการที่เลือก", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            If ComboBox3.SelectedIndex < 0 Or ComboBox3.Text.Trim = "" Then
                MessageBox.Show("กรุณาระบุรายการเบิกด้วย", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ComboBox1.SelectedIndex < 0 Or ComboBox1.Text.Trim = "" Then
                MessageBox.Show("กรุณาระบุแผนกด้วย", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsNumeric(TextBox1.Text.Trim) Then
                MessageBox.Show("กรุณาระบุน้ำหนักที่จะจ่ายด้วย", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CDbl(TextBox1.Text.Trim) = 0 Then
                MessageBox.Show("กรุณาระบุน้ำหนักที่จะจ่ายด้วย", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("ต้องการ บันทึกการจ่ายงานไปยังแผนก '" & ComboBox1.Text.Trim & "' ใช่หรือไม่?" & vbCrLf & vbCrLf & "น้ำหนักที่จ่าย = " & Format(CDbl(TextBox1.Text.Trim), "#,##0.00"), "จ่ายงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If NewAdd Then
                    Sql = "INSERT INTO [Process214Out] VALUES "
                    Sql = Sql & " ("
                    Sql = Sql & "'" & CDate(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                    Sql = Sql & ", '" & ComboBox3.Text.Trim & "'"
                    Sql = Sql & ", '" & TextBox4.Text.Trim & "'"
                    Sql = Sql & ", '" & CDbl(TextBox1.Text.Trim) & "'"
                    Sql = Sql & ", '" & ComboBox1.Text.Trim & "'"
                    Sql = Sql & ", 0"
                    Sql = Sql & ", '" & UserLogon & "'"
                    Sql = Sql & ", GETDATE())"
                Else
                    Sql = "UPDATE [Process214Out] SET "
                    Sql = Sql & "DateOut='" & CDate(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                    Sql = Sql & ",Detail='" & ComboBox3.Text.Trim & "'"
                    Sql = Sql & ",Printform='" & TextBox4.Text.Trim & "'"
                    Sql = Sql & ",Weight='" & CDbl(TextBox1.Text.Trim) & "'"
                    Sql = Sql & ",Department='" & ComboBox1.Text.Trim & "'"
                    Sql = Sql & ",UserID='" & UserLogon & "'"
                    Sql = Sql & ",UserUpdate=GETDATE()"
                    Sql = Sql & " WHERE IDAdminOut='" & txtID.Text.Trim & "'"
                End If
                If QueryScript(Sql) Then
                    Application.DoEvents()
                    UpdatedataDep(ComboBox2.Text.Trim, ComboBox1.Text.Trim)
                    If ComboBox2.Text.Trim = "D07" Then
                        Dim inSql As String = GetDescr("SELECT MAX(IDAdminOut) FROM [Process214Out]")(2)
                        If IsNumeric(inSql) Then
                            Sql = "INSERT INTO [Process212] VALUES "
                            Sql = Sql & " ("
                            Sql = Sql & "'" & inSql & "'"
                            Sql = Sql & ",0,'" & UserLogon & "'"
                            Sql = Sql & ",'" & CDate(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                            Sql = Sql & ",'" & CDbl(TextBox1.Text.Trim) & "'"
                            Sql = Sql & ",0,'',0,0,0"
                            Sql = Sql & ",'" & UserLogon & "'"
                            Sql = Sql & ", GETDATE())"
                            If Not QueryScript(Sql) Then MessageBox.Show("Error send data to โอ่ง ปล้อง จี้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Application.DoEvents()
                        End If
                    ElseIf ComboBox2.Text.Trim = "D01" Then
                        Dim inSql As String = GetDescr("SELECT MAX(IDAdminOut) FROM [Process214Out]")(2)
                        If IsNumeric(inSql) Then
                            Sql = "INSERT INTO [Process211] VALUES "
                            Sql = Sql & " ("
                            Sql = Sql & "'" & inSql & "'"
                            Sql = Sql & ",0,'" & UserLogon & "','','1900-01-01',0"
                            Sql = Sql & ",'" & CDbl(TextBox1.Text.Trim) & "'"
                            Sql = Sql & ",'" & CDate(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                            Sql = Sql & ",0,0,0,0,0,0,0,0"
                            Sql = Sql & ",'" & UserLogon & "'"
                            Sql = Sql & ", GETDATE())"
                            If Not QueryScript(Sql) Then MessageBox.Show("Error send data to 300", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Application.DoEvents()
                        End If
                    End If
                    MessageBox.Show("บันทึกการจ่ายงาน เรียบร้อย", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Timer1.Start()
                Else
                    MessageBox.Show("Error!!! ไม่สามารถจ่ายงานได้", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error!!! ไม่สามารถจ่ายงานได้", "จ่ายงาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ClearReturn()
        If fpOut_Sheet1.RowCount > 0 And fpOut_Sheet1.ActiveRowIndex >= 0 Then
            ComboBox4.Text = fpOut_Sheet1.Cells(fpOut_Sheet1.ActiveRowIndex, 2).Text.Trim
        Else
            MessageBox.Show("ไม่มีรายการที่เลือก", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Button8.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If ComboBox4.Text.Trim = "" Then
                MessageBox.Show("กรุณาระบุรายการรับคืนด้วย", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsNumeric(TextBox2.Text.Trim) Then
                MessageBox.Show("กรุณาระบุน้ำหนักที่รับคืนด้วย", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CDbl(TextBox2.Text.Trim) = 0 Then
                MessageBox.Show("กรุณาระบุน้ำหนักที่รับคืนด้วย", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("ต้องการ รับคืน '" & ComboBox4.Text.Trim & "' ใช่หรือไม่?" & vbCrLf & vbCrLf & "น้ำหนักที่รับคืน = " & Format(CDbl(TextBox2.Text.Trim), "#,##0.00"), "รับคืน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "INSERT INTO [Process214Return] VALUES "
                Sql = Sql & " ("
                Sql = Sql & "'" & CDbl(txtID.Text.Trim) & "'"
                Sql = Sql & ", '" & CDate(DateTimePicker2.Value).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                Sql = Sql & ", '" & ComboBox4.Text.Trim & "'"
                Sql = Sql & ", '" & TextBox5.Text.Trim & "'"
                Sql = Sql & ", '" & CDbl(TextBox2.Text.Trim) & "'"
                Sql = Sql & ", '" & TextBox3.Text.Trim & "'"
                Sql = Sql & ", 0"
                Sql = Sql & ", '" & UserLogon & "'"
                Sql = Sql & ", GETDATE())"
                If QueryScript(Sql) Then
                    Application.DoEvents()
                    UpdatedataDep(ComboBox5.Text.Trim, ComboBox4.Text.Trim)
                    MessageBox.Show("รับคืน เรียบร้อย", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Timer1.Start()
                Else
                    MessageBox.Show("Error!!! ไม่สามารถรับคืนได้", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error!!! ไม่สามารถรับคืนได้", "รับคืน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fpOut_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpOut.CellClick

    End Sub

    Private Sub fpOut_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpOut.LeaveCell
        ClearOut()
        ClearReturn()
        If fpOut_Sheet1.RowCount > 0 Then
            If e.NewRow >= 0 Then
                txtID.Text = fpOut_Sheet1.Cells(e.NewRow, 0).Value
            End If
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ClearOut()
        NewAdd = True
        Button9.Enabled = True
    End Sub

    Sub UpdatedataDep(ByVal DepID As String, ByVal DepName As String)
        Dim sql1 As Double = 0
        Dim sql2 As Double = 0
        Sql = GetDescr("select SUM(Weight) FROM Process214Out WHERE Department='" & DepName & "'")(2)
        If IsNumeric(Sql) Then
            sql1 = CDbl(Sql)
        End If

        Sql = GetDescr("select SUM(Weight) FROM Process214Return WHERE Detail='" & DepName & "'")(2)
        If IsNumeric(Sql) Then
            sql2 = CDbl(Sql)
        End If

        Sql = "UPDATE Weight SET [น้ำหนัก]=" & sql1 - sql2 & " WHERE DepID='" & DepID & "'"
        QueryScript(Sql)
        Application.DoEvents()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox1.SelectedIndex = ComboBox3.SelectedIndex
        ComboBox2.SelectedIndex = ComboBox3.SelectedIndex
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox5.SelectedIndex = ComboBox4.SelectedIndex
    End Sub
End Class