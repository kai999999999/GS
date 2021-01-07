Imports FarPoint
Imports FarPoint.Win.Spread.FpSpread
Public Class frmPrintBarcode

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim printset As New FarPoint.Win.Spread.PrintInfo()
            Application.DoEvents()
            Dim rptSize As String = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Size")
            Dim rptSizeW As String = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "SizeW")
            Dim rptSizeH As String = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "SizeH")
            Dim rptPrinter As String = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Name")
            Dim rptPreview As String = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Preview")

            printset.JobName = "Barcode"
            printset.PageOrder = FarPoint.Win.Spread.PrintPageOrder.Auto
            printset.PaperSize = New System.Drawing.Printing.PaperSize(rptSize, rptSizeW, rptSizeH)

            printset.Printer = rptPrinter
            printset.PrintType = FarPoint.Win.Spread.PrintType.CellRange
            printset.ColStart = 0
            printset.ColEnd = fpTimer_Sheet1.Columns.Count - 1
            printset.RowStart = 0
            printset.RowEnd = fpTimer_Sheet1.Rows.Count - 1
            printset.Preview = False
            If rptPreview.ToUpper = "TRUE" Then
                printset.Preview = True
            End If
            printset.Margin.Top = 0
            printset.Margin.Bottom = 0
            printset.Margin.Left = 0
            printset.Margin.Right = 0
            printset.HeaderHeight = 0
            printset.FooterHeight = 0
            printset.ShowGrid = False
            printset.ShowBorder = False
            'printset.ShowPrintDialog = True
            printset.ShowRowHeader = Win.Spread.PrintHeader.Hide
            printset.ShowShadows = False
            printset.ShowColumnHeader = Win.Spread.PrintHeader.Hide
            printset.Orientation = Win.Spread.PrintOrientation.Portrait
            fpTimer.Sheets(0).PrintInfo = printset
            fpTimer.PrintSheet(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        With fpTimer_Sheet1
            .Cells(0, 1).Text = ""
            '.Cells(0, 3).Text = ""
            .Cells(1, 1).Text = txtBarcode.Text.Trim
            '.Cells(1, 3).Text = txtBarcode.Text.Trim
            .Cells(2, 1).Text = "ชื่อ : " & txtBarcodeName.Text.Trim
            If TextBox1.Text.Trim <> "" Then
                If TextBox3.Text.Trim <> "" Then
                    .Cells(2, 1).Text = .Cells(2, 1).Text & "     " & TextBox3.Text.Trim & " : " & TextBox1.Text.Trim
                Else
                    .Cells(2, 1).Text = .Cells(2, 1).Text & "     " & TextBox1.Text.Trim
                End If
            End If
            '.Cells(2, 3).Text = "ชื่อ : " & txtBarcodeName.Text.Trim
            .Cells(3, 1).Text = txtSubBarcode.Text.Trim
            '.Cells(3, 3).Text = txtSubBarcode.Text.Trim
            .Cells(4, 1).Text = "วันที่ : " & Format(dtpDate.Value, "dd/MM/yyyy")
            If TextBox2.Text.Trim <> "" Then
                .Cells(4, 1).Text = .Cells(4, 1).Text & "     น้ำหนัก : " & TextBox2.Text.Trim
            End If
            '.Cells(4, 3).Text = "วันที่ : " & Format(dtpDate.Value, "dd/MM/yyyy")
            .Cells(5, 1).Text = ""
            '.Cells(5, 3).Text = ""
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub
End Class