Public Class frmProcessTimer

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If txtCode.Text.Trim <> "" Then
            If MessageBox.Show("You want to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Sql = "INSERT INTO [ProcessTimer] VALUES "
                Sql = Sql & " ("
                Sql = Sql & " '" & txtCode.Text.Trim & "'"
                Sql = Sql & " ,'" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'"
                Sql = Sql & " ," & NumericUpDown1.Value
                Sql = Sql & " ," & NumericUpDown2.Value
                Sql = Sql & " ," & NumericUpDown3.Value
                Sql = Sql & " ,0"
                Sql = Sql & " ,'" & UserLogon.Trim & "'"
                Sql = Sql & " ,GETDATE())"
                If QueryScript(Sql) Then
                    MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Timer1.Start()
                Else
                    MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Application.DoEvents()
            End If
        Else
            MessageBox.Show("Please enter name", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        txtCode.Text = ""
        DateTimePicker1.Value = Date.Now
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        With fpTimer_Sheet1
            .RowCount = 0
            Sql = "SELECT * FROM [ProcessTimer] WHERE LastStatus=0 Order by [Date]"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "ProcessTimer")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("ProcessTimer").Rows.Count > 0 Then
                        For i As Integer = 0 To dtResult.Tables("ProcessTimer").Rows.Count - 1
                            .RowCount = .RowCount + 1
                            .Cells(.RowCount - 1, 0).Text = dtResult.Tables("ProcessTimer").Rows(i)("Name").ToString.Trim
                            .Cells(.RowCount - 1, 1).Value = CDate(dtResult.Tables("ProcessTimer").Rows(i)("Date"))
                            .Cells(.RowCount - 1, 2).Text = dtResult.Tables("ProcessTimer").Rows(i)("HH")
                            .Cells(.RowCount - 1, 3).Text = dtResult.Tables("ProcessTimer").Rows(i)("MM")
                            .Cells(.RowCount - 1, 4).Text = dtResult.Tables("ProcessTimer").Rows(i)("SS")
                            Application.DoEvents()
                        Next
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value > 23 Then NumericUpDown1.Value = 0
        If NumericUpDown2.Value > 59 Then NumericUpDown2.Value = 0
        If NumericUpDown3.Value > 59 Then NumericUpDown3.Value = 0
    End Sub

    Private Sub fpTimer_ButtonClicked(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles fpTimer.ButtonClicked
        If e.Row >= 0 Then
            If e.Column = 5 Then
                Dim TemNo As String = fpTimer_Sheet1.Cells(e.Row, 0).Text.Trim
                If MessageBox.Show("You want to delete data... No. " & TemNo & "?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Sql = "UPDATE ProcessTimer set LastStatus=1 WHERE Name='" & TemNo & "'"
                    QueryScript(Sql)
                    Timer1.Start()
                    Application.DoEvents()
                End If
            End If
        End If
    End Sub

    Private Sub fpTimer_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpTimer.CellClick

    End Sub
End Class