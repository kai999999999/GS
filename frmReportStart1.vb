Public Class frmReportStart1

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lblWait.Visible = True
        fpSize.Visible = False
        fpMelt.Visible = False
        Application.DoEvents()
        Dim LotTemp As String
        Try
            With fpSize_Sheet1
                .RowCount = 0
                fpMelt_Sheet1.RowCount = 0
                Sql = "SELECT * FROM vMelt WHERE Lot<>''"
                If TextBox1.Text.Trim <> "" Then
                    Sql = Sql & " AND Lot like '%" & TextBox1.Text.Trim & "%'"
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
                            LotTemp = ""
                            For i As Integer = 0 To dtResult.Tables("Jobs").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                'Application.DoEvents()
                                '.Cells(.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("UserUpdate")
                                .Cells(.RowCount - 1, 0).Text = Format(CDate(dtResult.Tables("Jobs").Rows(i)("UserUpdate")), "dd/MM/yyyy HH:mm:ss")
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Jobs").Rows(i)("UserID")
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Jobs").Rows(i)("Lot")
                                .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Jobs").Rows(i)("Melt")
                                .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Jobs").Rows(i)("น้ำหนักหลอม")
                                .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Jobs").Rows(i)("น้ำหนักลงทอง")
                                .Cells(.RowCount - 1, 6).Text = dtResult.Tables("Jobs").Rows(i)("เศษ")
                                'ช่องหายตัดออก 20191108'.Cells(.RowCount - 1, 6).Text = (dtResult.Tables("Jobs").Rows(i)("น้ำหนักหลอม") - (dtResult.Tables("Jobs").Rows(i)("น้ำหนักลงทอง") + dtResult.Tables("Jobs").Rows(i)("เศษ")))
                                If dtResult.Tables("Jobs").Rows(i)("Lot").ToString.Trim = LotTemp.Trim And i > 0 Then
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 1).Value = fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 1).Value + dtResult.Tables("Jobs").Rows(i)("น้ำหนักหลอม")
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 2).Value = dtResult.Tables("Jobs").Rows(i)("น้ำหนักทอง")
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 3).Value = fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 3).Value + (dtResult.Tables("Jobs").Rows(i)("เศษ") + dtResult.Tables("Jobs").Rows(i)("เศษ1"))
                                Else
                                    LotTemp = dtResult.Tables("Jobs").Rows(i)("Lot").ToString.Trim
                                    fpMelt_Sheet1.RowCount = fpMelt_Sheet1.RowCount + 1
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("Lot")
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 1).Value = dtResult.Tables("Jobs").Rows(i)("น้ำหนักหลอม")
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 2).Value = dtResult.Tables("Jobs").Rows(i)("น้ำหนักทอง")
                                    fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 3).Value = dtResult.Tables("Jobs").Rows(i)("เศษ") + dtResult.Tables("Jobs").Rows(i)("เศษ1")
                                End If
                                fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 4).Value = fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 1).Value - (fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 2).Value + fpMelt_Sheet1.Cells(fpMelt_Sheet1.RowCount - 1, 3).Value)
                            Next
                        End If
                    End If
                End If
            End With
            lblWait.Visible = False
            fpSize.Visible = True
            fpMelt.Visible = True
            Application.DoEvents()
        Catch ex As Exception
            lblWait.Visible = False
            fpSize.Visible = True
            fpMelt.Visible = True
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
        If TabControl1.SelectedIndex = 1 Then
            fpMelt.SaveExcel(SaveFileDialog1.FileName, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly)
        Else
            fpSize.SaveExcel(SaveFileDialog1.FileName, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly)
        End If
    End Sub
End Class