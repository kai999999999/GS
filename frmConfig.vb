Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Public Class frmConfig
    Dim StopConn As Boolean
    Dim q As Queue(Of Byte) = New Queue(Of Byte)

    Private Sub frmConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btmSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmSave.Click
        If MessageBox.Show("กรุณา Backup Database ก่อนทำการตั้งค่านี้" & vbCrLf & vbCrLf & "ได้ทำการ Backup database แล้ว กด No" & vbCrLf & "ถ้ายังไม่ได้ทำการ Backup กรุณากด Yes เพื่อกลับไป Backup ให้เรียบร้อยก่อน", "Backup Database หรือยัง????", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
            End
        End If
        If txtServer.Text.Trim <> "" And txtServer.Text.Trim <> "" And txtUser.Text.Trim <> "" Then
            If Not Directory.Exists(txtPath.Text.Trim) Then
                MessageBox.Show("Error path direstory...", "Error data path", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Sql = "DROP TABLE [Process_08_IN]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process_08_Main]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process_08_OUT]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process_08_OUTShop]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process_70]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process200]"
            QueryScript(Sql)
            Sql = "DROP TABLE [Process201]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process202Receipt]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process211]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process211-1]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process211Return]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process211Return-1]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process212]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process212Return]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process213]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process214Out]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Process214Return]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [Weight]"
            QueryScript(Sql)
            Application.DoEvents()
            Sql = "DROP TABLE [WeightDetail]"
            QueryScript(Sql)
            Application.DoEvents()
            If MessageBox.Show("Are you sure you want to SAVE config....!", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Server", SiRiDev.Encrypt(txtServer.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "IP", SiRiDev.Encrypt(txtIP.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Port", SiRiDev.Encrypt(txtPort.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Database", SiRiDev.Encrypt(txtDatabase.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Username", SiRiDev.Encrypt(txtUser.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Password", SiRiDev.Encrypt(txtPassword.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Database", "Path", SiRiDev.Encrypt(txtPath.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Machine", "COMPorts", SiRiDev.Encrypt(COMPortsBox.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Machine", "BaudRate", SiRiDev.Encrypt(BaudRateBox.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Machine", "DataBits", SiRiDev.Encrypt(BitsBox.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Machine", "Parity", SiRiDev.Encrypt(ParityBox.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Machine", "StopBits", SiRiDev.Encrypt(StopBox.Text.Trim, "www.SiRiDev.com"))
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Printer", "Name", TextBox2.Text.Trim)
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Printer", "Size", TextBox3.Text.Trim)
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Printer", "SizeW", TextBox4.Text.Trim)
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Printer", "SizeH", TextBox5.Text.Trim)
                SiRiDevINI.WriteIni(Application.StartupPath & "\setup.ini", "Printer", "Preview", ComboBox1.Text.Trim)
                If Not connect() Then
                    MessageBox.Show("ออกจากโปรแกรม.... เพื่อโหลดข้อมูลใหม่", "ปิดโปรแกรม", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End
                End If
                Me.Close()
            End If
        Else
            MessageBox.Show("Please select file data access.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        txtServer.Text = server
        txtIP.Text = IP
        txtPort.Text = Port
        txtDatabase.Text = database
        txtUser.Text = username
        txtPassword.Text = password
        txtPath.Text = path
        TextBox2.Text = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Name")
        TextBox3.Text = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Size")
        TextBox4.Text = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "SizeW")
        TextBox5.Text = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "SizeH")
        ComboBox1.Text = SiRiDevINI.ReadIni(Application.StartupPath & "/setup.ini", "Printer", "Preview")

        For Each COMString As String In My.Computer.Ports.SerialPortNames ' Load all available COM ports.
            COMPortsBox.Items.Add(COMString)
        Next
        COMPortsBox.Sorted = True
        BaudRateBox.Items.Add("110")
        BaudRateBox.Items.Add("300")
        BaudRateBox.Items.Add("600")
        BaudRateBox.Items.Add("1200")
        BaudRateBox.Items.Add("1800")
        BaudRateBox.Items.Add("2400")
        BaudRateBox.Items.Add("4800")
        BaudRateBox.Items.Add("7200")
        BaudRateBox.Items.Add("9600")
        BaudRateBox.Items.Add("14400")
        BaudRateBox.Items.Add("19200")      ' Min. FIFO size 3 Bytes (8030 or 8530)
        BaudRateBox.Items.Add("38400")
        BaudRateBox.Items.Add("57600")      ' Min. FIFO size 8 bytes
        BaudRateBox.Items.Add("115200")     ' Min. FIFO size 16 bytes (16C550)
        BaudRateBox.Items.Add("230400")     ' Min. FIFO size 32 bytes (16C650)
        BaudRateBox.Items.Add("460800")     ' Min. FIFO size 64 bytes (16C750)
        BaudRateBox.Items.Add("921600")     ' Min. FIFO size 128 bytes (16C850 or 16C950)
        BitsBox.Items.Add("5")
        BitsBox.Items.Add("6")
        BitsBox.Items.Add("7")
        BitsBox.Items.Add("8")
        ParityBox.Items.Add("None")
        ParityBox.Items.Add("Odd")
        ParityBox.Items.Add("Even")
        ParityBox.Items.Add("Mark")         ' Leaves the parity bit set to 1
        ParityBox.Items.Add("Space")        ' Leaves the parity bit set to 0
        StopBox.Items.Add("1")
        StopBox.Items.Add("2")
        FlowControlBox.Items.Add("None")
        FlowControlBox.Items.Add("RequestToSend")
        FlowControlBox.Items.Add("RequestToSendXOnXOff")
        FlowControlBox.Items.Add("XOnXOff")

        If COMPortsBox.Items.Count > 0 Then
            COMPortsBox.SelectedIndex = 0
        End If
        BaudRateBox.Text = "1200"
        BitsBox.Text = "7"
        ParityBox.Text = "Odd"
        StopBox.Text = "1"
        FlowControlBox.Text = "None"
    End Sub

    Private Sub btnSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSql.Click
        Dim Sql As String = ""
        Dim ConnSql As New SqlConnection
        Dim cmdSql As New SqlCommand
        Dim temSql As String
        Cursor = Cursors.WaitCursor
        Try
            temSql = txtServer.Text.Trim
            If txtIP.Text.Trim <> "0" And txtPort.Text.Trim <> "0" And txtIP.Text.Trim <> "" And txtPort.Text.Trim <> "" Then
                temSql = txtIP.Text.Trim & "," & txtPort.Text.Trim & ";Network Library=DBMSSOCN"
            End If
            If txtPassword.Text.Trim() = "" Then
                Sql = "Data Source=" & temSql & ";Initial Catalog=" & txtDatabase.Text.Trim & ";Integrated Security=True;Connect Timeout=60;"
            Else
                Sql = "Data Source=" & temSql & ";Initial Catalog=" & txtDatabase.Text.Trim & "; User ID=" & txtUser.Text.Trim & ";Password=" & txtPassword.Text.Trim & ";Connect Timeout=60;"
            End If
            If ConnSql.State = ConnectionState.Closed Then
                ConnSql = New SqlConnection(Sql)
                ConnSql.Open()
                Application.DoEvents()
                If Directory.Exists(txtPath.Text.Trim) Then
                    MessageBox.Show("Test connect sql successfully.", "Test connect sql", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error path direstory...", "Error data path", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Application.DoEvents()
            End If
        Catch ex As Exception
            MessageBox.Show("Error cannot caonnect sql..." & vbCrLf & "Error #: " & Err.Number & vbCrLf & Err.Description, "Test connect sql", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.DoEvents()
        End Try
        If ConnSql.State = ConnectionState.Open Then ConnSql.Close()
        Cursor = Cursors.Default
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        txtData.Text = ""
        openM()
    End Sub
    Sub openM()
        Try
            'Panel2.Visible = True
            txtReceived.Text = ""
            txtRxConvert.Text = ""
            btnStart.Enabled = False
            q = New Queue(Of Byte)
            q.Clear()
            If COMPortsBox.SelectedIndex = -1 Or BaudRateBox.Text.Trim = "" Or BitsBox.Text.Trim = "" Then
                'Panel2.Visible = False
                btnStart.Enabled = True
                MsgBox("Please select a port")
                Exit Sub
            Else
                SerialPort1.Dispose()
                SerialPort1.PortName = COMPortsBox.SelectedItem.ToString
                SerialPort1.BaudRate = BaudRateBox.Text.Trim
                SerialPort1.DataBits = BitsBox.Text.Trim
                If ParityBox.Text.Trim = "None" Then
                    SerialPort1.Parity = Parity.None
                ElseIf ParityBox.Text.Trim = "Odd" Then
                    SerialPort1.Parity = Parity.Odd
                ElseIf ParityBox.Text.Trim = "Odd" Then
                    SerialPort1.Parity = Parity.Odd
                ElseIf ParityBox.Text.Trim = "Even" Then
                    SerialPort1.Parity = Parity.Even
                ElseIf ParityBox.Text.Trim = "Mark" Then
                    SerialPort1.Parity = Parity.Mark
                ElseIf ParityBox.Text.Trim = "Space" Then
                    SerialPort1.Parity = Parity.Space
                End If
                If StopBox.Text.Trim = "2" Then
                    SerialPort1.StopBits = IO.Ports.StopBits.Two
                Else
                    SerialPort1.StopBits = IO.Ports.StopBits.One
                End If
                SerialPort1.DtrEnable = True
                'SerialPort1.Encoding = System.Text.Encoding.GetEncoding(1252)
                SerialPort1.Open()
            End If
            If SerialPort1.IsOpen Then
                btnStart.Enabled = False
                btnStop.Enabled = True
                SerialPort1.DiscardOutBuffer()
                SerialPort1.DiscardInBuffer() ' clear the input buffer
                Timer2.Start()
            Else
                btnStart.Enabled = True
            End If
        Catch ex As Exception
            'Panel2.Visible = False
            MessageBox.Show("Error!! get data. Please enter try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiving of data
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'Try
        '    While SerialPort1.BytesToRead > 0
        '        q.Enqueue(SerialPort1.ReadByte)
        '    End While
        '    Application.DoEvents()
        'Catch ex As Exception
        'End Try
        ReceivedText(SerialPort1.ReadExisting())
        Application.DoEvents()
        If StopConn Then
            CloseConn()
        End If
    End Sub
    Dim tem As String
    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        Try
            If Me.TextBox1.InvokeRequired Then
                Dim x As New SetTextCallback(AddressOf ReceivedText)
                Me.Invoke(x, New Object() {(text)})
            Else
                Me.TextBox1.Text &= [text] 'append text
                getdata(Me.TextBox1.Lines.Length - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub getdata(ByVal L As Integer)
        Try
            If TextBox1.Lines(L).Trim <> "" Then
                Dim a As String = TextBox1.Lines(L).Trim
                'MessageBox.Show(a)
                a = Replace(a, "N", "")
                a = Replace(a, "+", "")
                a = Replace(a, "g", "")
                If IsNumeric(a.Trim) Then
                    txtData.Text = CDbl(a.Trim).ToString("#,##0.00")
                End If
            Else
                If L >= 0 Then getdata(L - 1)
            End If
            Application.DoEvents()
            TextBox1.SelectionStart = L - 1
            TextBox1.SelectionLength = 0
        Catch ex As Exception

        End Try
    End Sub

    Sub ShowSum()
        Dim st As String = txtReceived.Text.Trim
        Dim com As String = ""
        Dim temp1 As String = ""
        Dim temp2 As String = ""
        Dim cData As String = ""
        Dim temData As String = "0"
        Dim dataOK As Double = 0
        Dim checkPoint As Boolean = False
        Try
            For x As Integer = 0 To st.Length - 1 Step 2
                Dim k As String = st.Substring(x, 2)
                com &= System.Convert.ToChar(System.Convert.ToUInt32(k, 16)).ToString()
                temp2 = temp1
                temp1 = k
                If (temp2.Trim & temp1.Trim).Trim.ToUpper = "DA4E" Then 'ÚN
                    Exit For
                End If
            Next
            txtRxConvert.Text = com.Trim
            If txtRxConvert.Text.Trim <> "" Then
                For x As Integer = 0 To txtRxConvert.Text.Trim.Length - 1 Step 1
                    cData = txtRxConvert.Text.Trim.Substring(x, 1)
                    If IsNumeric(cData) Or cData.Trim = "." Then
                        If IsNumeric(temData & cData) Then
                            temData = temData & cData
                            checkPoint = True
                        Else
                            Exit For
                        End If
                    Else
                        If checkPoint Then
                            Exit For
                        End If
                        temData = ""
                    End If
                Next
            End If
            If IsNumeric(temData) Then
                dataOK = CDbl(temData)
            Else
                dataOK = 0
            End If
            txtData.Text = dataOK.ToString
            'Panel2.Visible = False
        Catch ex As Exception
            'Panel2.Visible = False
            MessageBox.Show("Error!! get data. Please enter try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Application.DoEvents()
        txtData.SelectAll()
        Application.DoEvents()
        openM()
        'MessageBox.Show("Data is.....  " & txtData.Text.Trim, "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub ShowData()
        Try
            txtReceived.Text = ""
            txtData.Text = ""
            SyncLock q
                While q.Count > 0
                    Dim B As Byte = q.Dequeue
                    '**Displayed data is displayed as hex in textbox
                    txtReceived.Text &= Hex(B) & ""
                    Application.DoEvents()
                End While
            End SyncLock
            ShowSum()
        Catch ex As Exception
            Label1.Visible = False
            MessageBox.Show("Error!! get data. Please enter try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Application.DoEvents()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Timer2.Stop()
            If SerialPort1.IsOpen Then
                SerialPort1.DtrEnable = False
                SerialPort1.DiscardOutBuffer()
                SerialPort1.DiscardInBuffer() ' clear the input buffer
                SerialPort1.Close()
            End If
            If Not SerialPort1.IsOpen Then
                btnStart.Enabled = True
                btnStop.Enabled = False
            End If
            Application.DoEvents()
            ShowData()
        Catch ex As Exception
            Label1.Visible = False
            MessageBox.Show("Error!! get data. Please enter try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        If SerialPort1.IsOpen Then
            SerialPort1.DtrEnable = False
            SerialPort1.DiscardOutBuffer()
            SerialPort1.DiscardInBuffer() ' clear the input buffer
            SerialPort1.Close()
            Timer2.Stop()
        End If
        If Not SerialPort1.IsOpen Then
            btnStart.Enabled = True
            btnStop.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        txtData.Text = "0.00"
        Try
            'If Not frmMain.SerialPort1.IsOpen Then
            Button1.Enabled = False
            StopConn = False
            SerialPort1.PortName = COMPortsBox.SelectedItem.ToString
            SerialPort1.BaudRate = BaudRateBox.Text.Trim
            SerialPort1.DataBits = BitsBox.Text.Trim
            If ParityBox.Text.Trim = "None" Then
                SerialPort1.Parity = Parity.None
            ElseIf ParityBox.Text.Trim = "Odd" Then
                SerialPort1.Parity = Parity.Odd
            ElseIf ParityBox.Text.Trim = "Odd" Then
                SerialPort1.Parity = Parity.Odd
            ElseIf ParityBox.Text.Trim = "Even" Then
                SerialPort1.Parity = Parity.Even
            ElseIf ParityBox.Text.Trim = "Mark" Then
                SerialPort1.Parity = Parity.Mark
            ElseIf ParityBox.Text.Trim = "Space" Then
                SerialPort1.Parity = Parity.Space
            End If
            If StopBox.Text.Trim = "2" Then
                SerialPort1.StopBits = IO.Ports.StopBits.Two
            Else
                SerialPort1.StopBits = IO.Ports.StopBits.One
            End If
            TextBox1.Text = "** Properties **"
            TextBox1.Text = TextBox1.Text & vbCrLf & "Port Name: " & SerialPort1.PortName
            TextBox1.Text = TextBox1.Text & vbCrLf & "Bit Rate: " & SerialPort1.BaudRate
            TextBox1.Text = TextBox1.Text & vbCrLf & "Data Bits: " & SerialPort1.DataBits
            TextBox1.Text = TextBox1.Text & vbCrLf & "Parity: " & SerialPort1.Parity
            TextBox1.Text = TextBox1.Text & vbCrLf & "Stop Bits: " & SerialPort1.StopBits
            TextBox1.Text = TextBox1.Text & vbCrLf & "***************" & vbCrLf

            SerialPort1.DtrEnable = True
            SerialPort1.NewLine = "\n"
            SerialPort1.Encoding = System.Text.Encoding.GetEncoding(1252)
            SerialPort1.Open()
            Button2.Enabled = True
            'End If
            'If SerialPort1.IsOpen Then
            '    Button1.Enabled = False
            'Else
            '    Button1.Enabled = True
            'End If
        Catch ex As Exception
            TextBox1.Text = "** ERROR!!! **" & vbCrLf & Err.Description
            Button1.Enabled = True
            Button2.Enabled = False
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'CloseConn()
            If SerialPort1.IsOpen Then
                SerialPort1.DtrEnable = False
                StopConn = True
                SerialPort1.Close()
            End If
            Button1.Enabled = True
            Button2.Enabled = False
        Catch ex As Exception
            TextBox1.Text = "** ERROR!!! **" & vbCrLf & Err.Description
            Button1.Enabled = True
            Button2.Enabled = False
        End Try
    End Sub
    Sub CloseConn()
        If SerialPort1.IsOpen Then
            SerialPort1.DtrEnable = False
            SerialPort1.DiscardOutBuffer()
            SerialPort1.DiscardInBuffer() ' clear the input buffer
            SerialPort1.Close()
        End If
        'If Not SerialPort1.IsOpen Then
        '    Button1.Enabled = True
        'End If
    End Sub
End Class