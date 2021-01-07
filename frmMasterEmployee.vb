
Public Class frmMasterEmployee
    Dim NewStatus As Boolean = True

    Sub ClearText()
        txtEmpName.Text = ""
        RadioButton2.Checked = True
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        rbtActive.Checked = True
        btnSave.Enabled = True
        btnDelete.Visible = False
    End Sub

    Sub ShowData()
        Try
            Sql = "SELECT * FROM Employee WHERE EmployeeID='" & txtEmpID.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Emp")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Emp").Rows.Count > 0 Then
                        NewStatus = False
                        lblStatus.Text = "*** OPEN ***"
                        lblStatus.ForeColor = Color.Blue
                        txtEmpName.Text = dtResult.Tables("Emp").Rows(0)("Name").ToString.Trim
                        If dtResult.Tables("Emp").Rows(0)("Type") = 0 Then
                            RadioButton2.Checked = True
                        Else
                            RadioButton1.Checked = True
                        End If
                        TextBox2.Text = dtResult.Tables("Emp").Rows(0)("DepartmentID").ToString.Trim
                        TextBox1.Text = GetDescr("SELECT Dep_Name FROM Department WHERE Dep_Code='" & TextBox2.Text.Trim & "'")(2)
                        If TextBox1.Text.Trim = "" Then TextBox2.Text = ""
                        TextBox3.Text = dtResult.Tables("Emp").Rows(0)("Address1").ToString.Trim
                        TextBox4.Text = dtResult.Tables("Emp").Rows(0)("Address2").ToString.Trim
                        TextBox5.Text = dtResult.Tables("Emp").Rows(0)("Address3").ToString.Trim
                        TextBox6.Text = dtResult.Tables("Emp").Rows(0)("Address4").ToString.Trim
                        TextBox7.Text = dtResult.Tables("Emp").Rows(0)("Address5").ToString.Trim
                        TextBox8.Text = dtResult.Tables("Emp").Rows(0)("Mobile").ToString.Trim
                        TextBox9.Text = dtResult.Tables("Emp").Rows(0)("Tel").ToString.Trim
                        TextBox10.Text = dtResult.Tables("Emp").Rows(0)("Contact").ToString.Trim
                        If dtResult.Tables("Emp").Rows(0)("Active") = 0 Then
                            rbtActive.Checked = True
                        Else
                            rbtInactive.Checked = True
                        End If
                        btnDelete.Visible = True
                    Else
                        txtEmpID.Text = ""
                        ClearText()
                    End If
                Else
                    MessageBox.Show("เกิดข้อผิดพลาดขึ้นในการเข้าใช้งาน" & vbCrLf & vbCrLf & qResult(1), "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้...." & vbCrLf & vbCrLf & "กรุณาตั้งค่าฐานข้อมูลใหม่ หรือติดต่อเจ้าหน้าที่ที่เกี่ยวข้อง เพื่อทำการแก้ไขต่อไป", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error...!" & vbCrLf & "ไม่สามารถแสดงข้อมูลได้ในขณะนี้.. โปรดติดต่อผู้ดูแลระบบ เพื่อทำการตรวจสอบแก้ไขต่อไป", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewStatus = True
        ClearText()
        txtEmpID.Text = ""
        txtEmpID.Focus()
    End Sub

    Private Sub btnFindEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindEmp.Click
        strCaption = "ค้นหา - ข้อมูลพนักงาน"
        dataRet = 0
        dataField = ""
        strSqlSelect = "EmployeeID,Name"
        strSqlFrom = "Employee"
        strSqlWhere = ""
        strSqlOrderBy = "EmployeeID"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtEmpID.Text = ""
            ClearText()
            txtEmpID.Text = dataField
            ShowData()
        End If
        dataField = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckPermission(UserLogon.Trim, 3) Then
            frmMasterDepartment.ShowDialog()
        Else
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strCaption = "ค้นหา - ข้อมูลแผนก"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Dep_Code,Dep_Name"
        strSqlFrom = "Department"
        strSqlWhere = ""
        strSqlOrderBy = "Dep_Code"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            TextBox2.Text = dataField
            TextBox2.Focus()
        End If
        dataField = ""
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtEmpID.Text.Trim = "" Then
            MessageBox.Show("Please enter employee ID.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtEmpName.Text.Trim = "" Then
            MessageBox.Show("Please enter employee name.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TextBox2.Text.Trim = "" Then
            MessageBox.Show("Please enter department.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("คุณต้องการที่จะบันทึกข้อมูลพนักงาน '" & txtEmpID.Text.Trim & "' ใช่หรือไม่?", "บันทึกข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "INSERT INTO [Employee]"
            Sql = Sql & " VALUES"
            Sql = Sql & " ('" & txtEmpID.Text.Trim & "'"
            Sql = Sql & " ,'" & txtEmpName.Text.Trim & "'"
            Sql = Sql & " ," & IIf(RadioButton2.Checked, 0, 1)
            Sql = Sql & " ,'" & TextBox2.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox3.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox4.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox5.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox6.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox7.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox8.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox9.Text.Trim & "'"
            Sql = Sql & " ,'" & TextBox10.Text.Trim & "'"
            Sql = Sql & " ," & IIf(rbtActive.Checked, 0, 1)
            Sql = Sql & " ,'" & UserLogon & "'"
            Sql = Sql & " ,GETDATE()"
            Sql = Sql & " ,'" & UserLogon & "'"
            Sql = Sql & " ,GETDATE())"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "UPDATE [Employee]"
            Sql = Sql & " SET [Name] = '" & txtEmpName.Text.Trim & "'"
            Sql = Sql & " ,[Type] = " & IIf(RadioButton2.Checked, 0, 1)
            Sql = Sql & " ,[DepartmentID] = '" & TextBox2.Text.Trim & "'"
            Sql = Sql & " ,[Address1] = '" & TextBox3.Text.Trim & "'"
            Sql = Sql & " ,[Address2] = '" & TextBox4.Text.Trim & "'"
            Sql = Sql & " ,[Address3] = '" & TextBox5.Text.Trim & "'"
            Sql = Sql & " ,[Address4] = '" & TextBox6.Text.Trim & "'"
            Sql = Sql & " ,[Address5] = '" & TextBox7.Text.Trim & "'"
            Sql = Sql & " ,[Mobile] = '" & TextBox8.Text.Trim & "'"
            Sql = Sql & " ,[Tel] = '" & TextBox9.Text.Trim & "'"
            Sql = Sql & " ,[Contact] = '" & TextBox10.Text.Trim & "'"
            Sql = Sql & " ,[Active] = " & IIf(rbtActive.Checked, 0, 1)
            Sql = Sql & " ,[UserID] = '" & UserLogon & "'"
            Sql = Sql & " ,[UserUpdate] = GETDATE()"
            Sql = Sql & " WHERE [EmployeeID]='" & txtEmpID.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย...", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้!!!", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("คุณต้องการที่จะลบข้อมูลพนักงาน '" & txtEmpID.Text.Trim & "' ใช่หรือไม่?", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM Employee WHERE [EmployeeID]='" & txtEmpID.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("ลบข้อมูลเรียบร้อย...", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmpID.Text = ""
                ClearText()
            Else
                MessageBox.Show("ไม่สามารถลบข้อมูลได้!!!", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox1.Text = GetDescr("SELECT Dep_Name FROM Department WHERE Dep_Code='" & TextBox2.Text.Trim & "'")(2)
        If TextBox1.Text.Trim = "" Then TextBox2.Text = ""
    End Sub
End Class