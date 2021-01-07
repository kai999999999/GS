Public Class frmReportUser

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lblWait.Visible = True
        fpSize.Visible = False
        Application.DoEvents()
        Try
            With fpSize_Sheet1
                .RowCount = 0
                Sql = "SELECT * FROM [vUserLogon] WHERE User<>''"
                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "Jobs")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("Jobs").Rows.Count > 0 Then
                            For i As Integer = 0 To dtResult.Tables("Jobs").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                'Application.DoEvents()
                                .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Jobs").Rows(i)("UserID").ToString.Trim
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Jobs").Rows(i)("Name").ToString.Trim
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Jobs").Rows(i)("Dep_Name").ToString.Trim
                                If dtResult.Tables("Jobs").Rows(i)("Wip11") = 1 Then
                                    .Cells(.RowCount - 1, 3).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 3).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip10") = 1 Then
                                    .Cells(.RowCount - 1, 4).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 4).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip1") = 1 Then
                                    .Cells(.RowCount - 1, 5).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 5).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip2") = 1 Then
                                    .Cells(.RowCount - 1, 6).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 6).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip3") = 1 Then
                                    .Cells(.RowCount - 1, 7).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 7).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip4") = 1 Then
                                    .Cells(.RowCount - 1, 8).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 8).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip5") = 1 Then
                                    .Cells(.RowCount - 1, 9).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 9).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip6") = 1 Then
                                    .Cells(.RowCount - 1, 10).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 10).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip7") = 1 Then
                                    .Cells(.RowCount - 1, 11).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 11).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip8") = 1 Then
                                    .Cells(.RowCount - 1, 12).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 12).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip9") = 1 Then
                                    .Cells(.RowCount - 1, 13).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 13).Text = "-"
                                End If
                                If dtResult.Tables("Jobs").Rows(i)("Wip12") = 1 Then
                                    .Cells(.RowCount - 1, 14).Text = "Yes"
                                Else
                                    .Cells(.RowCount - 1, 14).Text = "-"
                                End If
                                .Cells(.RowCount - 1, 15).Text = ""
                                If dtResult.Tables("Jobs").Rows(i)("Systems4") = 1 Then
                                    If dtResult.Tables("Jobs").Rows(i)("UserPassword").ToString.Trim <> "" Then
                                        .Cells(.RowCount - 1, 15).Text = SiRiDev.Decrypt(dtResult.Tables("Jobs").Rows(i)("UserPassword").ToString.Trim, "Www.SiRiDev.Com")
                                    End If
                                End If
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