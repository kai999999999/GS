Public Class frmProcessNewJob1

    Private Sub frmProcessNewJob_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        DateTimePicker1.Value = Date.Now
        txtType.Text = ""
        TextBox8.Text = "0.00"
        TextBox7.Text = "0.00"
        TextBox6.Text = "0.00"
        Sql = "SELECT * FROM Melt Where Lot='" & txtLot.Text.Trim & "' And Melt=" & CInt(txtMelt.Text.Trim) & " Order by Melt"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "Melt")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("Melt").Rows.Count > 0 Then
                    DateTimePicker1.Value = dtResult.Tables("Melt").Rows(0)("CreateUpdate")
                    txtType.Text = dtResult.Tables("Melt").Rows(0)("MeltType").ToString.Trim
                    TextBox8.Text = dtResult.Tables("Melt").Rows(0)("น้ำหนักหลอม").ToString.Trim
                    TextBox7.Text = dtResult.Tables("Melt").Rows(0)("น้ำหนักลงทอง").ToString.Trim
                    TextBox6.Text = dtResult.Tables("Melt").Rows(0)("เศษ").ToString.Trim
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtType.Text.Trim = "" Then
            txtType.Text = Date.Now()
        End If
        If CInt(GetDescr("SELECT count(name) FROM sys.tables")(2)) <> 20 Then End
        If txtType.Text.Trim <> "" And txtLotDescr.Text.Trim <> "" Then
            If Not IsNumeric(TextBox8.Text.Trim) Then TextBox8.Text = "0"
            If Not IsNumeric(TextBox7.Text.Trim) Then TextBox7.Text = "0"
            If MessageBox.Show("คุณต้องการที่จะบันทึกข้อมูล Lot เลขที่ " & txtLot.Text.Trim & " ใช่หรือไม่?", "บันทึกข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If SaveData() Then
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย...", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้!!!", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้!!!" & vbCrLf & "กรุณาใส่ข้อมูลให้ครบถ้วน..!", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function SaveData() As Boolean
        SaveData = False
        Try
            If CInt(txtMelt.Text.Trim) = 0 Then
                Sql = GetDescr("select Max(melt) From melt Where Lot='" & txtLot.Text.Trim & "'")(2)
                If IsNumeric(Sql) Then
                    txtMelt.Text = CInt(Sql) + 1
                Else
                    txtMelt.Text = "1"
                End If
            End If
            Sql = "INSERT INTO Melt([Lot],[melt],[MeltType],[น้ำหนักหลอม],[น้ำหนักลงทอง],[เศษ],[LastStatus],[CreateUser],[CreateUpdate],[UserID],[UserUpdate])"
            Sql = Sql & " VALUES('" & txtLot.Text.Trim & "'," & CInt(txtMelt.Text.Trim) & ",'" & txtType.Text.Trim & "'," & CDbl(TextBox8.Text.Trim) & "," & CDbl(TextBox7.Text.Trim) & "," & CDbl(TextBox6.Text.Trim) & ",0,'" & UserLogon.Trim & "',GETDATE(),'" & UserLogon & "',GETDATE())"
            QueryScript(Sql)
            Sql = "UPDATE Melt SET [MeltType]='" & txtType.Text.Trim & "',[น้ำหนักหลอม]=" & CDbl(TextBox8.Text.Trim) & ",[น้ำหนักลงทอง]=" & CDbl(TextBox7.Text.Trim) & ",[เศษ]=" & CDbl(TextBox6.Text.Trim) & ",[UserID]='" & UserLogon & "',[UserUpdate]=GETDATE()"
            Sql = Sql & " WHERE [Lot]='" & txtLot.Text.Trim & "' AND [melt]=" & CInt(txtMelt.Text.Trim)
            If QueryScript(Sql) Then
                SaveData = True
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Print barcode...")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox8.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        Timer2.Stop()
        If Not IsNumeric(TextBox8.Text.Trim) Then TextBox8.Text = "0.00"
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        Timer2.Stop()
        If Not IsNumeric(TextBox7.Text.Trim) Then TextBox7.Text = "0.00"
    End Sub

    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        Timer2.Stop()
        If Not IsNumeric(TextBox6.Text.Trim) Then TextBox6.Text = "0.00"
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class