Public Class frmProcessBarcode

    Private Sub frmProcessBarcode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not CheckPermission(UserLogon.Trim, 15) Then
            MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmProcessBarcodeADD.ShowDialog()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        fpBarcode.Visible = False
        lblWait.Visible = True
        Application.DoEvents()
        Try
            With fpBarcode_Sheet1
                .ClearRange(0, 0, .RowCount, .ColumnCount, True)
                .RowCount = 0
                If TextBox2.Text.Trim <> "" Then
                    Sql = "SELECT Barcode,Type,Name,SIZE,UNIT,RULER_SIZE,BARCODE_SCAN,BARCODE_NAME,WEIGHT_NOOSE,WEIGHT_FOOT,WEIGHT_LINE FROM vBarcode Where Name like '%" & TextBox2.Text.Trim & "%' Order by Barcode"
                Else
                    Sql = "SELECT Barcode,Type,Name,SIZE,UNIT,RULER_SIZE,BARCODE_SCAN,BARCODE_NAME,WEIGHT_NOOSE,WEIGHT_FOOT,WEIGHT_LINE FROM vBarcode Order by Barcode"
                End If
                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "Barcode")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("Barcode").Rows.Count > 0 Then
                            For i As Integer = 0 To dtResult.Tables("Barcode").Rows.Count - 1
                                .RowCount = .RowCount + 1
                                .SetActiveCell(.RowCount - 1, 0)
                                Application.DoEvents()
                                .Cells(.RowCount - 1, 0).Text = dtResult.Tables("Barcode").Rows(i)("Barcode")
                                .Cells(.RowCount - 1, 1).Text = dtResult.Tables("Barcode").Rows(i)("Name").ToString.Trim
                                .Cells(.RowCount - 1, 2).Text = dtResult.Tables("Barcode").Rows(i)("SIZE")
                                .Cells(.RowCount - 1, 3).Text = dtResult.Tables("Barcode").Rows(i)("UNIT").ToString.Trim
                                .Cells(.RowCount - 1, 4).Text = dtResult.Tables("Barcode").Rows(i)("RULER_SIZE")
                                .Cells(.RowCount - 1, 5).Text = dtResult.Tables("Barcode").Rows(i)("BARCODE_SCAN").ToString.Trim
                                .Cells(.RowCount - 1, 6).Text = dtResult.Tables("Barcode").Rows(i)("BARCODE_NAME").ToString.Trim
                                .Cells(.RowCount - 1, 7).Text = dtResult.Tables("Barcode").Rows(i)("WEIGHT_NOOSE")
                                .Cells(.RowCount - 1, 8).Text = dtResult.Tables("Barcode").Rows(i)("WEIGHT_FOOT")
                                .Cells(.RowCount - 1, 9).Text = dtResult.Tables("Barcode").Rows(i)("WEIGHT_LINE")
                                Application.DoEvents()
                            Next
                        End If
                    End If
                End If
            End With
            fpBarcode.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        Catch ex As Exception
            fpBarcode.Visible = True
            lblWait.Visible = False
            Application.DoEvents()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer1.Enabled = True
    End Sub

    Private Sub fpBarcode_ButtonClicked(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles fpBarcode.ButtonClicked
        If e.Column = 10 Or e.Column = 11 Then
            'Edit
            If Not CheckPermission(UserLogon.Trim, 15) Then
                MessageBox.Show("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้" & vbCrLf & vbCrLf & "กรุณาติดต่อผู้ดูแลระบบ เพื่อตรวจสอบสิทธิ์", "สิทธิ์การใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            With frmProcessBarcodeADD
                If e.Column = 10 Then
                    .TextBox1.Text = "EDIT"
                Else
                    .TextBox1.Text = "DELETE"
                End If
                .TextBox2.Text = fpBarcode_Sheet1.Cells(e.Row, 0).Value
                .LoadID()
                .cmbTypeName.Text = fpBarcode_Sheet1.Cells(e.Row, 1).Text
                .NumericUpDown1.Text = fpBarcode_Sheet1.Cells(e.Row, 2).Text
                .cmbUnit.Text = fpBarcode_Sheet1.Cells(e.Row, 3).Text
                .NumericUpDown2.Text = fpBarcode_Sheet1.Cells(e.Row, 4).Text
                .txtBarcode.Text = fpBarcode_Sheet1.Cells(e.Row, 5).Text
                .txtBarcodeName.Text = fpBarcode_Sheet1.Cells(e.Row, 6).Text
                .TextBox3.Text = fpBarcode_Sheet1.Cells(e.Row, 7).Text
                .TextBox4.Text = fpBarcode_Sheet1.Cells(e.Row, 8).Text
                .TextBox5.Text = fpBarcode_Sheet1.Cells(e.Row, 9).Text
                .ShowDialog()
            End With
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub fpBarcode_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpBarcode.CellClick

    End Sub
End Class