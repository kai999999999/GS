Public Class frmMasterDepartment
    Dim NewStatus As Boolean = True

    Sub ClearData()
        NewStatus = True
        btnDelete.Visible = False
        txtDepName.Text = ""
        rbtActive.Checked = True
        lblStatus.Text = "*** NEW ***"
        lblStatus.ForeColor = Color.Red
    End Sub

    Sub ShowData()
        Try
            Sql = "SELECT * FROM Department WHERE Dep_Code='" & txtDepCode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Dep")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Dep").Rows.Count > 0 Then
                        NewStatus = False
                        lblStatus.Text = "*** OPEN ***"
                        lblStatus.ForeColor = Color.Blue
                        txtDepName.Text = dtResult.Tables("Dep").Rows(0)("Dep_Name").ToString.Trim
                        If dtResult.Tables("Dep").Rows(0)("Inactive") = 0 Then
                            rbtActive.Checked = True
                        Else
                            rbtInactive.Checked = True
                        End If
                        btnDelete.Visible = True
                    Else
                        txtDepCode.Text = ""
                        ClearData()
                    End If
                Else
                    MessageBox.Show("�Դ��ͼԴ��Ҵ���㹡�������ҹ" & vbCrLf & vbCrLf & qResult(1), "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("�������ö�Դ��Ͱҹ��������...." & vbCrLf & vbCrLf & "��سҵ�駤�Ұҹ���������� ���͵Դ������˹�ҷ��������Ǣ�ͧ ���ͷӡ����䢵���", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error...!" & vbCrLf & "�������ö�ʴ���������㹢�й��.. �ô�Դ��ͼ������к� ���ͷӡ�õ�Ǩ�ͺ��䢵���", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function SaveData() As Boolean
        Try
            If NewStatus Then
                Sql = "INSERT INTO Department([Dep_Code],[Dep_Name],[Inactive],[UserID],[UserUpdate]) VALUES('" & txtDepCode.Text.Trim & "','" & txtDepName.Text.Trim & "'," & IIf(rbtActive.Checked, 0, 1) & ",'" & UserLogon & "',GETDATE())"
            Else
                Sql = "UPDATE Department SET "
                Sql = Sql & "[Dep_Name]='" & txtDepName.Text.Trim & "'"
                Sql = Sql & ",[Inactive]='" & IIf(rbtActive.Checked, 0, 1) & "'"
                Sql = Sql & ",[UserID]='" & UserLogon.Trim & "'"
                Sql = Sql & ",[UserUpdate]=GETDATE()"
                Sql = Sql & " WHERE [Dep_Code]='" & txtDepCode.Text.Trim & "'"
            End If
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
        txtDepCode.Text = ""
        ClearData()
    End Sub

    Private Sub txtEmpID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepCode.LostFocus
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtDepCode.Text.Trim <> "" Then
            'If UserLevel <> 0 Then
            '    MessageBox.Show("�������ö�ѹ�֡��������..." & vbCrLf & "��س��� User ADMIN 㹡�úѹ�֡��ҹ��", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If MessageBox.Show("�س��ͧ��÷��кѹ�֡�����ž�ѡ�ҹ '" & txtDepCode.Text.Trim & "' ���������?", "�ѹ�֡������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If SaveData() Then
                    MessageBox.Show("�ѹ�֡���������º����...", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDepCode.Text = ""
                    ClearData()
                Else
                    MessageBox.Show("�������ö�ѹ�֡��������!!!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("��� UserID ��͹��...!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepCode.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFindEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindEmp.Click
        strCaption = "���� - ������Ἱ�"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Dep_Code,Dep_Name"
        strSqlFrom = "Department"
        strSqlWhere = ""
        strSqlOrderBy = "Dep_Code"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtDepCode.Text = ""
            ClearData()
            txtDepCode.Text = dataField
            ShowData()
        End If
        dataField = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("�س��ͧ��÷���ź������Ἱ� '" & txtDepCode.Text.Trim & "' ���������?", "ź������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM Department WHERE [Dep_Code]='" & txtDepCode.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("ź���������º����...", "ź������", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDepCode.Text = ""
                ClearData()
            Else
                MessageBox.Show("�������öź��������!!!", "ź������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class