Public Class frmMasterBarcodeType
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
            Sql = "SELECT * FROM BarcodeType WHERE Type='" & txtTypeCode.Text.Trim & "'"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Dep")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Dep").Rows.Count > 0 Then
                        NewStatus = False
                        lblStatus.Text = "*** OPEN ***"
                        lblStatus.ForeColor = Color.Blue
                        txtDepName.Text = dtResult.Tables("Dep").Rows(0)("Name").ToString.Trim
                        btnDelete.Visible = True
                    Else
                        txtTypeCode.Text = "0"
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
                'Sql = "INSERT INTO BarcodeType([Name],[Inactive],[UserID],[UserUpdate]) VALUES('" & txtDepName.Text.Trim & "'," & IIf(rbtActive.Checked, 0, 1) & ",'" & UserLogon & "',GETDATE())"
                Sql = "INSERT INTO BarcodeType([Name]) VALUES('" & txtDepName.Text.Trim & "')"
            Else
                Sql = "UPDATE BarcodeType SET "
                Sql = Sql & "[Name]='" & txtDepName.Text.Trim & "'"
                'Sql = Sql & ",[Inactive]='" & IIf(rbtActive.Checked, 0, 1) & "'"
                'Sql = Sql & ",[UserID]='" & UserLogon.Trim & "'"
                'Sql = Sql & ",[UserUpdate]=GETDATE()"
                Sql = Sql & " WHERE [Type]='" & txtTypeCode.Text.Trim & "'"
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
        txtTypeCode.Text = "0"
        ClearData()
    End Sub

    Private Sub txtEmpID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTypeCode.LostFocus
        ShowData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtTypeCode.Text.Trim <> "" Then
            'If UserLevel <> 0 Then
            '    MessageBox.Show("�������ö�ѹ�֡��������..." & vbCrLf & "��س��� User ADMIN 㹡�úѹ�֡��ҹ��", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If MessageBox.Show("�س��ͧ��÷��кѹ�֡�����ž�ѡ�ҹ '" & txtTypeCode.Text.Trim & "' ���������?", "�ѹ�֡������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If SaveData() Then
                    MessageBox.Show("�ѹ�֡���������º����...", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTypeCode.Text = "0"
                    ClearData()
                Else
                    MessageBox.Show("�������ö�ѹ�֡��������!!!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("��� UserID ��͹��...!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTypeCode.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFindEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindEmp.Click
        strCaption = "���� - ������Ẻ"
        dataRet = 0
        dataField = ""
        strSqlSelect = "Type,Name"
        strSqlFrom = "BarcodeType"
        strSqlWhere = ""
        strSqlOrderBy = "Type"
        frmSearch.ShowDialog()
        If dataField.Trim <> "" Then
            txtTypeCode.Text = "0"
            ClearData()
            txtTypeCode.Text = dataField
            ShowData()
        End If
        dataField = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("�س��ͧ��÷���ź������Ẻ '" & txtTypeCode.Text.Trim & "' ���������?", "ź������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "DELETE FROM BarcodeType WHERE [Type]='" & txtTypeCode.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("ź���������º����...", "ź������", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtTypeCode.Text = "0"
                ClearData()
            Else
                MessageBox.Show("�������öź��������!!!", "ź������", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class