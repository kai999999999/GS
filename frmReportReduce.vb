Public Class frmReportReduce

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lblWait.Visible = True
        fpSize.Visible = False
        Application.DoEvents()
        If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then End
        Try
            With fpSize_Sheet1
                .RowCount = 0
                Sql = "SELECT * FROM [vProcessReduce] WHERE Lot<>''"
                If TextBox1.Text.Trim <> "" Then
                    Sql = Sql & " AND Lot like '%" & TextBox1.Text.Trim & "%'"
                End If
                If TextBox2.Text.Trim <> "" Then
                    Sql = Sql & " AND BARCODETEXT like '%" & TextBox2.Text.Trim & "%'"
                End If
                If TextBox3.Text.Trim <> "" Then
                    Sql = Sql & " AND BARCODE_NAME like '%" & TextBox3.Text.Trim & "%'"
                End If
                If dtpCreateFrom.Checked Then
                    If dtpCreateTo.Checked Then
                        Sql = Sql & " and (CreateUpdate BETWEEN '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateTo.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (CreateUpdate BETWEEN '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpCreateFrom.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
                If dtpUpdateFrom.Checked Then
                    If dtpUpdateTo.Checked Then
                        Sql = Sql & " and (UserUpdate BETWEEN '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateTo.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    Else
                        Sql = Sql & " and (UserUpdate BETWEEN '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:00.000") & "' and '" & dtpUpdateFrom.Value.ToString("yyyy-MM-dd HH:mm:59.999") & "')"
                    End If
                End If
                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "Jobs")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("Jobs").Rows.Count > 0 Then
                            For i As Integer = 0 To dtResult.Tables("Jobs").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                'Application.DoEvents()
                                '.Cells(.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("UserUpdate")
                                .Cells(.RowCount - 1, 0).Text = Format(CDate(dtResult.Tables("Jobs").Rows(i)("UserUpdate")), "dd/MM/yyyy HH:mm:ss")
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Jobs").Rows(i)("UserID").ToString.Trim
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Jobs").Rows(i)("Lot").ToString.Trim
                                .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Jobs").Rows(i)("BARCODETEXT").ToString.Trim
                                .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Jobs").Rows(i)("BARCODE_NAME").ToString.Trim
                                .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Jobs").Rows(i)("StatusName").ToString.Trim
                                .Cells(.RowCount - 1, 6).Text = dtResult.Tables("Jobs").Rows(i)("���˹ѡ��Ŵ��")
                                .Cells(.RowCount - 1, 7).Text = dtResult.Tables("Jobs").Rows(i)("���˹ѡRoll")
                                .Cells(.RowCount - 1, 8).Text = dtResult.Tables("Jobs").Rows(i)("���˹ѡ���")
                                .Cells(.RowCount - 1, 9).Text = dtResult.Tables("Jobs").Rows(i)("���˹ѡRoll�Ǵ")
                                .Cells(.RowCount - 1, 10).Text = dtResult.Tables("Jobs").Rows(i)("��ػ���")
                            Next
                        End If
                    End If
                End If
            End With
            lblWait.Visible = False
            fpSize.Visible = True
            Application.DoEvents()
        Catch ex As Exception
            lblWait.Visible = False
            fpSize.Visible = True
            Application.DoEvents()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        fpSize.SaveExcel(SaveFileDialog1.FileName, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly)
    End Sub
End Class