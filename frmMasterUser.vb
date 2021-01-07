Imports System.Data.Oledb
Public Class frmMasterUser
    Dim NewStatus As Boolean = True

    Sub ClearData()
        NewStatus = True
        'txtUserID.Text = ""
        txtPassword.Text = ""
        txtPasswordAgain.Text = ""
        txtEmpID.Text = ""
        txtEmpName.Text = ""
        chkSys1.Checked = False
        chkSys2.Checked = False
        chkSys3.Checked = False
        chkSys4.Checked = False
        chkWip1.Checked = False
        chkWip2.Checked = False
        chkWip3.Checked = False
        chkWip4.Checked = False
        chkWip5.Checked = False
        chkWip6.Checked = False
        chkWip7.Checked = False
        chkWip8.Checked = False
        chkWip9.Checked = False
        chkWip10.Checked = False
        chkWip11.Checked = False
        chkWip12.Checked = False
        chkWip13.Checked = False
        chkWip14.Checked = False
        chkWip15.Checked = False
        rbtActive.Checked = True
        lblStatus.Text = "*** NEW ***"
        lblStatus.ForeColor = Color.Red
        txtUserID.Focus()
    End Sub

    Sub ShowData()
        Try
            Sql = "SELECT * FROM UserLogon WHERE UserID='" & txtUserID.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "User")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("User").Rows.Count > 0 Then
                        NewStatus = False
                        Dim Pwd As String = SiRiDev.Decrypt(dtResult.Tables("User").Rows(0)("UserPassword").ToString.Trim, "Www.SiRiDev.Com")
                        lblStatus.Text = "*** OPEN ***"
                        lblStatus.ForeColor = Color.Blue
                        txtPassword.Text = Pwd
                        txtEmpID.Text = dtResult.Tables("User").Rows(0)("EmployeeID").ToString.Trim
                        txtEmpName.Text = GetDescr("SELECT Name FROM Employee WHERE EmployeeID='" & txtEmpID.Text.Trim & "'")(2)
                        chkSys1.Checked = IIf(dtResult.Tables("User").Rows(0)("Systems1") = 1, True, False)
                        chkSys2.Checked = IIf(dtResult.Tables("User").Rows(0)("Systems2") = 1, True, False)
                        chkSys3.Checked = IIf(dtResult.Tables("User").Rows(0)("Systems3") = 1, True, False)
                        chkSys4.Checked = IIf(dtResult.Tables("User").Rows(0)("Systems4") = 1, True, False)
                        chkWip1.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip1") = 1, True, False)
                        chkWip2.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip2") = 1, True, False)
                        chkWip3.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip3") = 1, True, False)
                        chkWip4.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip4") = 1, True, False)
                        chkWip5.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip5") = 1, True, False)
                        chkWip6.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip6") = 1, True, False)
                        chkWip7.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip7") = 1, True, False)
                        chkWip8.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip8") = 1, True, False)
                        chkWip9.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip9") = 1, True, False)
                        chkWip10.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip10") = 1, True, False)
                        chkWip11.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip11") = 1, True, False)
                        chkWip12.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip12") = 1, True, False)
                        chkWip13.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip13") = 1, True, False)
                        chkWip14.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip14") = 1, True, False)
                        chkWip15.Checked = IIf(dtResult.Tables("User").Rows(0)("Wip15") = 1, True, False)
                        If dtResult.Tables("User").Rows(0)("Active") = 0 Then
                            rbtActive.Checked = True
                        Else
                            rbtInactive.Checked = True
                        End If
                    Else
                        NewStatus = True
                        lblStatus.Text = "*** NEW ***"
                        lblStatus.ForeColor = Color.Red
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

    Function SaveData() As Boolean
        Try
            Dim Pwd As String = SiRiDev.Encrypt(txtPassword.Text.Trim, "Www.SiRiDev.Com")
            Sql = "INSERT INTO UserLogon ([UserID],[CreateUser],[CreateUpdate])"
            Sql = Sql & " VALUES('" & txtUserID.Text.Trim & "','" & UserLogon & "',GETDATE())"
            QueryScript(Sql)
            Sql = "UPDATE UserLogon SET "
            Sql = Sql & "[UserPassword] = '" & SiRiDev.Encrypt(txtPassword.Text.Trim, "Www.SiRiDev.Com") & "'"
            Sql = Sql & ",[EmployeeID] = '" & txtEmpID.Text.Trim & "'"
            Sql = Sql & ",[Systems1] = " & IIf(chkSys1.Checked, 1, 0)
            Sql = Sql & ",[Systems2] = " & IIf(chkSys2.Checked, 1, 0)
            Sql = Sql & ",[Systems3] = " & IIf(chkSys3.Checked, 1, 0)
            Sql = Sql & ",[Systems4] = " & IIf(chkSys4.Checked, 1, 0)
            Sql = Sql & ",[Wip1] = " & IIf(chkWip1.Checked, 1, 0)
            Sql = Sql & ",[Wip2] = " & IIf(chkWip2.Checked, 1, 0)
            Sql = Sql & ",[Wip3] = " & IIf(chkWip3.Checked, 1, 0)
            Sql = Sql & ",[Wip4] = " & IIf(chkWip4.Checked, 1, 0)
            Sql = Sql & ",[Wip5] = " & IIf(chkWip5.Checked, 1, 0)
            Sql = Sql & ",[Wip6] = " & IIf(chkWip6.Checked, 1, 0)
            Sql = Sql & ",[Wip7] = " & IIf(chkWip7.Checked, 1, 0)
            Sql = Sql & ",[Wip8] = " & IIf(chkWip8.Checked, 1, 0)
            Sql = Sql & ",[Wip9] = " & IIf(chkWip9.Checked, 1, 0)
            Sql = Sql & ",[Wip10] = " & IIf(chkWip10.Checked, 1, 0)
            Sql = Sql & ",[Wip11] = " & IIf(chkWip11.Checked, 1, 0)
            Sql = Sql & ",[Wip12] = " & IIf(chkWip12.Checked, 1, 0)
            Sql = Sql & ",[Wip13] = " & IIf(chkWip13.Checked, 1, 0)
            Sql = Sql & ",[Wip14] = " & IIf(chkWip14.Checked, 1, 0)
            Sql = Sql & ",[Wip15] = " & IIf(chkWip15.Checked, 1, 0)
            Sql = Sql & ",[Active] = " & IIf(rbtActive.Checked, 0, 1)
            Sql = Sql & ",[UpdateUser] = '" & UserLogon & "'"
            Sql = Sql & ",[UpdateDate] = GETDATE()"
            Sql = Sql & " WHERE [UserID]='" & txtUserID.Text.Trim & "'"
            If QueryScript(Sql) Then
                SaveData = True
            Else
                SaveData = False
            End If
        Catch ex As Exception
            SaveData = False
        End Try
    End Function

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearData()
        txtUserID.Text = ""
    End Sub

    Private Sub txtUserID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserID.LostFocus
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUserID.Text.Trim <> "" Then
            If txtUserID.Text.Trim.ToUpper = "ADMIN" And UserLogon.Trim.ToUpper <> "ADMIN" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้..." & vbCrLf & "กรุณาใช้ User ADMIN ในการบันทึกเท่านั้น", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If UserLogon.Trim.ToUpper <> "ADMIN" And txtUserID.Text.Trim.ToUpper <> UserLogon.Trim.ToUpper Then
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้..." & vbCrLf & "กรุณาใช้ User ADMIN ในการบันทึกเท่านั้น", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If txtPassword.Text.Trim = txtPasswordAgain.Text.Trim And Len(txtPassword.Text.Trim) >= 3 Then
                If MessageBox.Show("คุณต้องการที่จะบันทึก User '" & txtUserID.Text.Trim & "' ใช่หรือไม่?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then
                        End
                    End If
                    If SaveData() Then
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'ClearData()
                        'txtUserID.Focus()
                    Else
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("ตรวจสอบ Password ให้ตรงกันด้วยนะ...! และ Password ต้องไม่ใช่ช่องว่าง", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
            End If
        Else
            MessageBox.Show("ใส่ UserID ก่อนนะ...!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserID.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFindUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindUser.Click
        strCaption = "Finder - UserID"
        dataRet = 0
        dataField = ""
        strSqlSelect = "UserID,EmployeeID,Active"
        strSqlFrom = "UserLogon"
        strSqlWhere = ""
        strSqlOrderBy = "UserID"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            ClearData()
            txtUserID.Text = dataField
        End If
        dataField = ""
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

    Private Sub txtEmpID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpID.LostFocus
        txtEmpName.Text = GetDescr("SELECT EmpName FROM Employee WHERE EmpCode='" & txtEmpID.Text.Trim & "'")(2)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("คุณต้องการที่จะลบกข้อมูล User '" & txtUserID.Text.Trim & "' ใช่หรือไม่?", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM UserLogon WHERE [UserID]='" & txtUserID.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("ลบข้อมูลเรียบร้อย...", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearData()
            Else
                MessageBox.Show("ไม่สามารถลบข้อมูลได้!!!", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtEmpID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpID.TextChanged

    End Sub
End Class