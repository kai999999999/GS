Public Class frmProcessBarcodeADD

    Private Sub frmProcessBarcodeADD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If TextBox1.Text.Trim.ToUpper <> "EDIT" And TextBox1.Text.Trim.ToUpper <> "DELETE" Then
            Button2.Visible = False
            LoadID()
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
            txtBarcode.Text = ""
            txtBarcodeName.Text = ""
            TextBox3.Text = "0.00"
            TextBox4.Text = "0.00"
            TextBox5.Text = "0.00"
        ElseIf TextBox1.Text.Trim.ToUpper = "DELETE" Then
            Button2.Visible = True
        End If
    End Sub
    Sub LoadID()
        cmbTypeName.Items.Clear()
        cmbTypeID.Items.Clear()
        Sql = "SELECT Type,Name FROM BarcodeType Order by Type"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "BarcodeType")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("BarcodeType").Rows.Count > 0 Then
                    For i As Integer = 0 To dtResult.Tables("BarcodeType").Rows.Count - 1
                        cmbTypeID.Items.Add(dtResult.Tables("BarcodeType").Rows(i)("Type").ToString.Trim)
                        cmbTypeName.Items.Add(dtResult.Tables("BarcodeType").Rows(i)("Name").ToString.Trim)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If cmbTypeName.SelectedIndex >= 0 And txtBarcode.Text.Trim <> "" And txtBarcodeName.Text.Trim <> "" Then
            If MessageBox.Show("คุณต้องการที่จะบันทึกข้อมูลใช่หรือไม่?", "บันทึกข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
            If TextBox1.Text.Trim = "EDIT" And IsNumeric(TextBox2.Text.Trim) Then
                Sql = "UPDATE Barcode SET [Type]='" & cmbTypeID.Text.Trim & "',[SIZE]='" & NumericUpDown1.Value & "',[UNIT]='" & cmbUnit.Text.Trim & "',[RULER_SIZE]='" & NumericUpDown2.Value & "',[BARCODE_SCAN]='" & txtBarcode.Text.Trim & "',[BARCODE_NAME]='" & txtBarcodeName.Text.Trim & "',[WEIGHT_NOOSE]='" & CDbl(TextBox3.Text.Trim) & "',[WEIGHT_FOOT]='" & CDbl(TextBox4.Text.Trim) & "',[WEIGHT_LINE]='" & CDbl(TextBox5.Text.Trim) & "'"
                Sql = Sql & " WHERE [Barcode]='" & CInt(TextBox2.Text.Trim) & "'"
            Else
                Sql = "INSERT INTO Barcode([Type],[SIZE],[UNIT],[RULER_SIZE],[BARCODE_SCAN],[BARCODE_NAME],[WEIGHT_NOOSE],[WEIGHT_FOOT],[WEIGHT_LINE])"
                Sql = Sql & " VALUES('" & cmbTypeID.Text.Trim & "','" & NumericUpDown1.Value & "','" & cmbUnit.Text.Trim & "','" & NumericUpDown2.Value & "','" & txtBarcode.Text.Trim & "','" & txtBarcodeName.Text.Trim & "','" & CDbl(TextBox3.Text.Trim) & "','" & CDbl(TextBox4.Text.Trim) & "','" & CDbl(TextBox5.Text.Trim) & "')"
            End If
            If QueryScript(Sql) Then
                SaveData = True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmbTypeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTypeName.SelectedIndexChanged
        cmbTypeID.SelectedIndex = cmbTypeName.SelectedIndex
    End Sub

    Private Sub btnAddType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddType.Click
        frmMasterBarcodeType.ShowDialog()
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("คุณต้องการที่จะลบข้อมูลใช่หรือไม่?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Sql = "INSERT INTO BarcodeDelete SELECT *,'" & UserLogon & "',GETDATE() FROM Barcode WHERE Barcode='" & TextBox2.Text.Trim & "'"
        If QueryScript(Sql) Then
            Sql = "DELETE FROM Barcode WHERE Barcode='" & TextBox2.Text.Trim & "'"
            If QueryScript(Sql) Then
                MessageBox.Show("Delete comlaeted....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("ไม่สามารถลบได้", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("ไม่สามารถลบได้", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class