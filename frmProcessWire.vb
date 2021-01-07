Public Class frmProcessWire

    Sub clearText()
        Button3.Enabled = False
        TextBox6.Text = "0.00"
        Sql = GetDescr("select [น้ำหนักทอง] from Jobs Where [Lot]='" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "' And [LastStatus]=1")(2)
        If IsNumeric(Sql) Then
            TextBox6.Text = Format(CDbl(Sql), "#,##0.00")
        End If
        TextBox7.Text = "0.00"
        TextBox8.Text = "0.00"
        TextBox9.Text = "0.00"
        TextBox10.Text = "0.00"
        TextBox11.Text = "0.00"
        TextBox12.Text = "0.00"
        TextBox13.Text = "0.00"
        TextBox15.Text = "0.00"
        TextBox16.Text = "0.00"
        TextBox17.Text = "0.00"
        TextBox18.Text = "0.00"
        TextBox19.Text = "0.00"
        TextBox20.Text = "0.00"
        TextBox21.Text = "0.00"
        btnSend.Enabled = False
    End Sub

    Private Sub frmProcessWire_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        clearText()
        Sql = "SELECT * FROM [ProcessWire] WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & txtBarcodeID.Text.Trim & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "ProcessWire")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("ProcessWire").Rows.Count > 0 Then
                    TextBox6.Text = dtResult.Tables("ProcessWire").Rows(0)("รวม_น้ำหนักทอง").ToString.Trim
                    TextBox7.Text = dtResult.Tables("ProcessWire").Rows(0)("รวม_น้ำหนักทองแดง").ToString.Trim
                    TextBox8.Text = dtResult.Tables("ProcessWire").Rows(0)("รวม_รวม").ToString.Trim
                    TextBox11.Text = dtResult.Tables("ProcessWire").Rows(0)("แนบ_แนบ").ToString.Trim
                    TextBox10.Text = dtResult.Tables("ProcessWire").Rows(0)("แนบ_เศษทองหาย").ToString.Trim
                    TextBox9.Text = dtResult.Tables("ProcessWire").Rows(0)("แนบ_เศษทอง").ToString.Trim
                    TextBox13.Text = dtResult.Tables("ProcessWire").Rows(0)("ชักลวด_เศษทองแดง").ToString.Trim
                    TextBox12.Text = dtResult.Tables("ProcessWire").Rows(0)("ชักลวด_ชักลวด").ToString.Trim
                    TextBox21.Text = dtResult.Tables("ProcessWire").Rows(0)("ชักเม็ด_ชักเม็ด").ToString.Trim
                    TextBox20.Text = dtResult.Tables("ProcessWire").Rows(0)("ชักเม็ด_คืน").ToString.Trim
                    TextBox19.Text = dtResult.Tables("ProcessWire").Rows(0)("ชักเม็ด_เศษทองหาย").ToString.Trim
                    TextBox18.Text = dtResult.Tables("ProcessWire").Rows(0)("รีดลาย_เศษทอง").ToString.Trim
                    TextBox17.Text = dtResult.Tables("ProcessWire").Rows(0)("รีดลาย_เศษทองแดง").ToString.Trim
                    TextBox16.Text = dtResult.Tables("ProcessWire").Rows(0)("รีดลาย_รีดลาย").ToString.Trim
                    TextBox15.Text = dtResult.Tables("ProcessWire").Rows(0)("สรุปหาย").ToString.Trim
                    If dtResult.Tables("ProcessWire").Rows(0)("LastStatus") <= 1 Then
                        btnSend.Enabled = True
                    Else
                        btnSend.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Save
        If MessageBox.Show("You want to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "INSERT INTO [ProcessWire] VALUES "
            Sql = Sql & " ('" & txtLot.Text.Trim & "'"
            Sql = Sql & ", " & CInt(txtBarcodeID.Text.Trim)
            Sql = Sql & ", '" & txtBarcode.Text.Trim & "'"
            Sql = Sql & ", " & CDbl(TextBox6.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox7.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox8.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox11.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox10.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox9.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox13.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox12.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox21.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox20.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox19.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox18.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox17.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox16.Text.Trim)
            Sql = Sql & ", " & CDbl(TextBox15.Text.Trim)
            Sql = Sql & ", 1"
            Sql = Sql & ", '" & UserLogon & "'"
            Sql = Sql & ", GETDATE()"
            Sql = Sql & ", '" & UserLogon & "'"
            Sql = Sql & ", GETDATE())"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "UPDATE [ProcessWire]"
            Sql = Sql & " SET [รวม_น้ำหนักทอง] = " & CDbl(TextBox6.Text.Trim)
            Sql = Sql & " ,[รวม_น้ำหนักทองแดง] = " & CDbl(TextBox7.Text.Trim)
            Sql = Sql & " ,[รวม_รวม] = " & CDbl(TextBox8.Text.Trim)
            Sql = Sql & " ,[แนบ_แนบ] = " & CDbl(TextBox11.Text.Trim)
            Sql = Sql & " ,[แนบ_เศษทองหาย] = " & CDbl(TextBox10.Text.Trim)
            Sql = Sql & " ,[แนบ_เศษทอง] = " & CDbl(TextBox9.Text.Trim)
            Sql = Sql & " ,[ชักลวด_เศษทองแดง] = " & CDbl(TextBox13.Text.Trim)
            Sql = Sql & " ,[ชักลวด_ชักลวด] = " & CDbl(TextBox12.Text.Trim)
            Sql = Sql & " ,[ชักเม็ด_ชักเม็ด] = " & CDbl(TextBox21.Text.Trim)
            Sql = Sql & " ,[ชักเม็ด_คืน] = " & CDbl(TextBox20.Text.Trim)
            Sql = Sql & " ,[ชักเม็ด_เศษทองหาย] = " & CDbl(TextBox19.Text.Trim)
            Sql = Sql & " ,[รีดลาย_เศษทอง] = " & CDbl(TextBox18.Text.Trim)
            Sql = Sql & " ,[รีดลาย_เศษทองแดง] = " & CDbl(TextBox17.Text.Trim)
            Sql = Sql & " ,[รีดลาย_รีดลาย] = " & CDbl(TextBox16.Text.Trim)
            Sql = Sql & " ,[สรุปหาย] = " & CDbl(TextBox15.Text.Trim)
            Sql = Sql & " ,[UserID] = '" & UserLogon & "'"
            Sql = Sql & " ,[UserUpdate] = GETDATE()"
            Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If QueryScript(Sql) Then
                UpdateJob(txtLot.Text.Trim, txtBarcodeID.Text.Trim, txtBarcode.Text.Trim)
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearText()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Application.DoEvents()
        GroupBox4.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True
        GroupBox6.Enabled = True
        GroupBox7.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim SType As Integer = 0
        If CInt(txtType.Text.Trim) = 1 Then
            SType = 2
        Else
            SType = 12
        End If
        If MessageBox.Show("You want to send data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Sql = "UPDATE [ProcessWire]"
            Sql = Sql & " SET [LastStatus] = 2"
            Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
            If QueryScript(Sql) Then
                Sql = "UPDATE [Jobs]"
                Sql = Sql & " SET [LastStatus] = " & SType
                Sql = Sql & " WHERE [Lot] = '" & txtLot.Text.Trim & "' And Barcode='" & CInt(txtBarcodeID.Text.Trim) & "' And BarcodeText='" & txtBarcode.Text.Trim & "'"
                QueryScript(Sql)
                Application.DoEvents()
                MessageBox.Show("Save data completed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error save data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Sub sumData()
        If Not IsNumeric(TextBox6.Text.Trim) Then TextBox6.Text = "0.00"
        If Not IsNumeric(TextBox7.Text.Trim) Then TextBox7.Text = "0.00"
        If Not IsNumeric(TextBox9.Text.Trim) Then TextBox9.Text = "0.00"
        If Not IsNumeric(TextBox11.Text.Trim) Then TextBox11.Text = "0.00"
        If Not IsNumeric(TextBox12.Text.Trim) Then TextBox12.Text = "0.00"
        If Not IsNumeric(TextBox13.Text.Trim) Then TextBox13.Text = "0.00"
        If Not IsNumeric(TextBox16.Text.Trim) Then TextBox16.Text = "0.00"
        If Not IsNumeric(TextBox17.Text.Trim) Then TextBox17.Text = "0.00"
        If Not IsNumeric(TextBox18.Text.Trim) Then TextBox18.Text = "0.00"
        If Not IsNumeric(TextBox20.Text.Trim) Then TextBox20.Text = "0.00"
        If Not IsNumeric(TextBox21.Text.Trim) Then TextBox21.Text = "0.00"
        TextBox8.Text = Format(CDbl(TextBox6.Text.Trim) + CDbl(TextBox7.Text.Trim), "0.00")
        TextBox10.Text = Format(CDbl(TextBox8.Text.Trim) - CDbl(TextBox11.Text.Trim), "0.00")
        'TextBox12.Text = Format(CDbl(TextBox11.Text.Trim) - CDbl(TextBox13.Text.Trim), "0.00")
        TextBox19.Text = Format(CDbl(TextBox12.Text.Trim) - (CDbl(TextBox21.Text.Trim) + CDbl(TextBox20.Text.Trim)), "0.00")
        'TextBox16.Text = Format(CDbl(TextBox21.Text) - CDbl(TextBox18.Text.Trim) - CDbl(TextBox17.Text.Trim), "0.00")
        TextBox15.Text = Format(CDbl(TextBox8.Text.Trim) - (CDbl(TextBox9.Text.Trim) + CDbl(TextBox13.Text.Trim) + CDbl(TextBox20.Text.Trim) + CDbl(TextBox18.Text.Trim) + CDbl(TextBox17.Text.Trim) + CDbl(TextBox16.Text.Trim)), "0.00")
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        sumData()
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
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        sumData()
    End Sub

    Private Sub TextBox11_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox11.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        sumData()
    End Sub

    Private Sub TextBox9_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox9.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        sumData()
    End Sub

    Private Sub TextBox13_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox13.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        sumData()
    End Sub

    Private Sub TextBox21_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox21.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox21_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox21.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox21.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox21_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox21.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        sumData()
    End Sub

    Private Sub TextBox20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox20.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox20.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        sumData()
    End Sub

    Private Sub TextBox18_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox18.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox18.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        sumData()
    End Sub

    Private Sub TextBox17_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox17_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox17.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox17.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        sumData()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtResult.Text = Format(Result, "#,##0.00")
    End Sub

    Private Sub TextBox12_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox12.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox12_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        sumData()
    End Sub

    Private Sub TextBox16_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.GotFocus
        Timer2.Start()
    End Sub

    Private Sub TextBox16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox16.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox16.Text = Format(Result, "#,##0.00")
        End If
    End Sub

    Private Sub TextBox16_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.LostFocus
        Timer2.Stop()
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        sumData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With frmPrintBarcode
            .txtBarcode.Text = txtBarcode.Text.Trim
            .txtBarcodeName.Text = txtBarcodeName.Text.Trim
            .TextBox1.ReadOnly = False
            .TextBox3.Text = ""
            .txtSubBarcode.Text = ""
            .TextBox1.Text = ""
            .dtpDate.Value = Date.Now
            .TextBox2.Text = Format(CDbl(TextBox6.Text.Trim), "#,##0.00")
            .Timer1.Start()
            .ShowDialog()
        End With
    End Sub
End Class