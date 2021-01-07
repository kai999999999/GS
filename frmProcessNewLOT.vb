Public Class frmProcessNewLOT
    Dim NewData As Boolean
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Sql = GetDescr("select Max(Lot) From Lot Where Lot Like '" & Format(Date.Now, "yy") & "%'")(2)
        If IsNumeric(Sql) Then
            txtLot.Text = CInt(Sql) + 1
        Else
            txtLot.Text = Format(Date.Now, "yy") & "0001"
        End If
        txtLotName.Text = ""
        NewData = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        txtLot.Text = ""
        txtLotName.Text = ""
        NewData = True
        Sql = "SELECT * FROM Lot Where Lot<>''"
        If ComboBox1.SelectedIndex > 0 Then
            Sql = Sql & " AND LastStatus=" & ComboBox1.SelectedIndex
        End If
        If TextBox2.Text.Trim <> "" Then
            Sql = Sql & " AND Descr Like '%" & TextBox2.Text.Trim & "%'"
        End If
        With fpLot_Sheet1
            .ClearRange(0, 0, .RowCount, .ColumnCount, True)
            .RowCount = 0
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "Lot")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("Lot").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("Lot").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .SetActiveCell(.RowCount - 1, 0)
                            Application.DoEvents()
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Lot").Rows(i)("Lot").ToString.Trim
                            .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Lot").Rows(i)("Descr")
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Lot").Rows(i)("CreateUpdate").ToString.Trim
                            Select Case dtResult.Tables("Lot").Rows(i)("LastStatus")
                                Case 1
                                    .Cells(.RowCount - 1, 3).Text = "New"
                                Case 2
                                    .Cells(.RowCount - 1, 3).Text = "Processing"
                                Case 3
                                    .Cells(.RowCount - 1, 3).Text = "Completed"
                                Case Else
                                    .Cells(.RowCount - 1, 3).Text = ""
                            End Select
                            Application.DoEvents()
                        Next
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtLotName.Text.Trim <> "" Then
            If NewData Then
                Sql = GetDescr("select Max(Lot) From Lot Where Lot Like '" & Format(Date.Now, "yy") & "%'")(2)
                If IsNumeric(Sql) Then
                    txtLot.Text = CInt(Sql) + 1
                Else
                    txtLot.Text = Format(Date.Now, "yy") & "0001"
                End If
            End If
            If MessageBox.Show("�س��ͧ��÷��кѹ�֡������ Lot �Ţ��� " & txtLot.Text.Trim & " ���������?", "�ѹ�֡������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If SaveData() Then
                    MessageBox.Show("�ѹ�֡���������º����...", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NewData = False
                    Timer1.Start()
                Else
                    MessageBox.Show("�������ö�ѹ�֡��������!!!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("�������ö�ѹ�֡��������!!!" & vbCrLf & "��س������������ú��ǹ..!", "�ѹ�֡������", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function SaveData() As Boolean
        SaveData = False
        Try
            Sql = "INSERT INTO Lot([Lot],[Descr],[LastStatus],[CreateUser],[CreateUpdate],[UserID],[UserUpdate])"
            Sql = Sql & " VALUES('" & txtLot.Text.Trim & "','" & txtLotName.Text.Trim & "',0,'" & UserLogon.Trim & "',GETDATE(),'" & UserLogon.Trim & "',GETDATE())"
            QueryScript(Sql)
            Sql = "UPDATE [Lot] SET [Descr]='" & txtLotName.Text.Trim & "',[UserID]='" & UserLogon & "',[UserUpdate]=GETDATE() WHERE [Lot]='" & txtLot.Text.Trim & "'"
            If QueryScript(Sql) Then
                SaveData = True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub frmProcessNewLOT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub fpLot_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpLot.CellClick

    End Sub

    Private Sub fpLot_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles fpLot.LeaveCell
        txtLot.Text = fpLot_Sheet1.Cells(e.NewRow, 0).Text.Trim
        txtLotName.Text = fpLot_Sheet1.Cells(e.NewRow, 1).Text.Trim
        NewData = False
    End Sub
End Class