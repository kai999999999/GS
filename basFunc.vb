Imports System.IO
Imports System.IO.Ports
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Text
Imports SiRiDev
Module basFunc
    Public Result As Double

    Public Conn As New SqlConnection
    Public cmd As New SqlCommand
    Public qResult As String()
    Public dtResult As New DataSet
    Public dtResult1 As New DataSet
    Public strConn As String
    Public server, IP, Port, username, password, database, path As String
    Public COMPortsS, BaudRateS, DataBitsS, ParityS, StopBitsS As String
    Public SerialCn As New SerialData
    Public SiRiDev As New EncryptDecrypt
    Public SiRiDevINI As New INI

    Public Sql As String
    Public UserLogon As String
    Public UserLevel As Integer
    'Search
    Public strCaption As String
    Public strSql As String
    Public strSqlSelect As String
    Public strSqlFrom As String
    Public strSqlWhere As String
    Public strSqlOrderBy As String
    Public strField As String
    Public dataRet As Integer
    Public dataField As String
    Public RetCount As Integer
    Public RetField(10) As Integer
    Public RetData(10) As String
    'Report
    Public rptReport As Integer
    Public rptCommand As String
    Public rptTable As String
    Public rptFile As String
    Public rptCount As Integer
    Public rptValue(15) As String
    Public tr As OleDb.OleDbTransaction
    Public ReportPath As String = "D:\Goldsmith"

    Public Function connect() As Boolean
        Dim ci As CultureInfo = New CultureInfo("en-US")
        Dim myDateTimePatterns() As String = {"dd/MM/yyyy", "yyyy-MM-dd"}
        Try
            ci.DateTimeFormat.SetAllDateTimePatterns(myDateTimePatterns, "d"c)
            Thread.CurrentThread.CurrentCulture = ci
            Thread.CurrentThread.CurrentUICulture = ci
            call_DB()
            If password.Trim() = "" Then
                'strConn = "Data Source=" & server & ";Initial Catalog=" & database & ";Integrated Security=True"
                'strConn = "Data Source=" & server & ";Initial Catalog=" & database & "; User ID=" & username
                strConn = "Data Source=" & server & ";Initial Catalog=" & database & ";Integrated Security=True;Connect Timeout=60;"
            Else
                'strConn = "Data Source=" & server & ";Initial Catalog=" & database & "; User ID=" & username & "; Password=" & password & ";"
                strConn = "Data Source=" & server & ";Initial Catalog=" & database & "; User ID=" & username & ";Password=" & password & ";Connect Timeout=60;"
            End If
            If Conn.State = ConnectionState.Closed Then
                Conn = New SqlConnection(strConn)
                Conn.Open()
                connect = True
            End If
        Catch ex As Exception
            connect = False
        End Try
    End Function
    Public Sub call_DB()
        Dim filepathINI As String = Application.StartupPath & ("\setup.ini")
        server = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Server"), "www.SiRiDev.com")
        IP = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "IP"), "www.SiRiDev.com")
        Port = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Port"), "www.SiRiDev.com")
        username = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Username"), "www.SiRiDev.com")
        password = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Password"), "www.SiRiDev.com")
        database = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Database"), "www.SiRiDev.com")
        path = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Database", "Path"), "www.SiRiDev.com")
        If IP <> "0" And Port <> "0" And IP <> "" And Port <> "" Then
            server = IP & "," & Port & ";Network Library=DBMSSOCN"
        End If
    End Sub

    Public Sub call_MC()
        Dim filepathINI As String = Application.StartupPath & ("\setup.ini")
        COMPortsS = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Machine", "COMPorts"), "www.SiRiDev.com")
        BaudRateS = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Machine", "BaudRate"), "www.SiRiDev.com")
        DataBitsS = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Machine", "DataBits"), "www.SiRiDev.com")
        ParityS = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Machine", "Parity"), "www.SiRiDev.com")
        StopBitsS = SiRiDev.Decrypt(SiRiDevINI.ReadIni(filepathINI, "Machine", "StopBits"), "www.SiRiDev.com")
    End Sub

    Public Function OpenDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                cmd.Connection = Conn
            End If
            OpenDB = True
            Application.DoEvents()
        Catch ex As Exception
            OpenDB = False
        End Try
    End Function
    Public Function CloseDB() As Boolean
        Try
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
            CloseDB = True
            Application.DoEvents()
        Catch ex As Exception
            CloseDB = False
        End Try
    End Function

    Public Function QueryDB(ByVal SqlQuery As String, ByVal NameDs As String) As String()
        Dim astr As String()
        Try
            dtResult = Nothing
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(SqlQuery, Conn)
            da.Fill(ds, NameDs)
            dtResult = ds
            astr = New String() {"SUCCESS", dtResult.Tables(NameDs).Rows.Count.ToString}
            ds = Nothing
        Catch ex As Exception
            astr = New String() {"ERROR", "Error # : " & Err.Number & vbCrLf & "Description : " & Err.Description}
        End Try
        Application.DoEvents()
        Return astr
    End Function

    Public Function GetDescr(ByVal SqlQuery As String) As String()
        Dim astr As String()
        Try
            Dim dsDescr As New DataSet
            Dim daDescr As New SqlDataAdapter(SqlQuery, Conn)
            daDescr.Fill(dsDescr)
            If dsDescr.Tables(0).Rows.Count > 0 Then
                astr = New String() {"SUCCESS", dsDescr.Tables(0).Rows.Count.ToString, dsDescr.Tables(0).Rows(0)(0).ToString.Trim}
            Else
                astr = New String() {"SUCCESS", "0", ""}
            End If
            dsDescr = Nothing
        Catch ex As Exception
            astr = New String() {"ERROR", "Error # : " & Err.Number & vbCrLf & "Description : " & Err.Description, ""}
        End Try
        Application.DoEvents()
        Return astr
    End Function

    Function QueryScript(ByVal Script As String) As Boolean
        Try
            If OpenDB() Then
                cmd.CommandText = Script
                cmd.ExecuteNonQuery()
                Application.DoEvents()
                CloseDB()
                QueryScript = True
            End If
        Catch ex As Exception
            CloseDB()
            QueryScript = False
        End Try
        Application.DoEvents()
    End Function

    Function NextNumber(ByVal FieldCom As String, ByVal FieldData As String, ByVal FromData As String) As String
        Dim a As String = GetNext(FieldCom, FieldData, FromData)
        NextNumber = a.Trim
        Sql = "SELECT [" & FieldData & "] FROM " & FromData & " WHERE " & FieldData & "='" & a.Trim & "'"
        If OpenDB() Then
            qResult = Nothing
            qResult = QueryDB(Sql, "GetCom")
            CloseDB()
            If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                If dtResult.Tables("GetCom").Rows.Count > 0 Then
                    NextNumber = "***Error***"
                    MessageBox.Show("Error number!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Function

    Function DDataUpdate() As Boolean
        Try
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
        Catch ex As Exception

        End Try
    End Function

    Public Function GetNext(ByVal FieldCom As String, ByVal FieldData As String, ByVal FromData As String) As String
        Try
            Dim LastNum As String = ""
            Sql = "SELECT [" & FieldCom.Trim & "] FROM Company"
            If OpenDB() Then
                qResult = Nothing
                qResult = QueryDB(Sql, "GetCom")
                CloseDB()
                If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                    If dtResult.Tables("GetCom").Rows.Count > 0 Then
                        LastNum = dtResult.Tables("GetCom").Rows(0)(0).ToString.Trim
                    Else
                        LastNum = ""
                    End If
                End If
            End If
            Application.DoEvents()
            If LastNum.Trim = "" Then
                Sql = "SELECT MAX(" & FieldData & ") FROM " & FromData
                If OpenDB() Then
                    qResult = Nothing
                    qResult = QueryDB(Sql, "GetCom")
                    CloseDB()
                    If qResult(0).ToString.Trim.ToUpper = "SUCCESS" Then
                        If dtResult.Tables("GetCom").Rows.Count > 0 Then
                            LastNum = dtResult.Tables("GetCom").Rows(0)(0).ToString.Trim
                        Else
                            LastNum = ""
                        End If
                    End If
                End If
                Dim str2num As String
                Dim strtmp As String = ""
                Dim numtmp As Long = 0
                Dim digittmp As Integer = 0
                Dim zerotmp As String = ""
                If LastNum.Trim <> "" Then
                    For x As Integer = 1 To LastNum.Length
                        str2num = Mid(LastNum, x, LastNum.Length)
                        If IsNumeric(str2num) Then
                            numtmp = CLng(str2num) + 1
                            digittmp = LastNum.Length - strtmp.Trim.Length
                            For x1 As Integer = 1 To digittmp
                                zerotmp = zerotmp.Trim & "0"
                            Next
                            GetNext = strtmp.Trim & Format(numtmp, zerotmp)
                            Exit Function
                        Else
                            strtmp = strtmp.Trim & Mid(LastNum, x, 1)
                        End If
                    Next
                End If
            End If
            GetNext = LastNum
        Catch ex As Exception
            GetNext = ""
        End Try
    End Function

    Function CheckPermission(ByVal cUser As String, ByVal cMenu As Integer) As Boolean
        CheckPermission = False
        Try
            Sql = "SELECT top 1 * FROM UserLogon WHERE UserID='" & cUser.Trim & "' AND Active=0"
            Select Case cMenu
                Case 1
                    Sql = Sql & " AND Systems1=1"
                Case 2
                    Sql = Sql & " AND Systems2=1"
                Case 3
                    Sql = Sql & " AND Systems3=1"
                Case 4
                    Sql = Sql & " AND Systems4=1"
                Case 5
                    Sql = Sql & " AND Wip1=1"
                Case 6
                    Sql = Sql & " AND Wip2=1"
                Case 7
                    Sql = Sql & " AND Wip3=1"
                Case 8
                    Sql = Sql & " AND Wip4=1"
                Case 9
                    Sql = Sql & " AND Wip5=1"
                Case 10
                    Sql = Sql & " AND Wip6=1"
                Case 11
                    Sql = Sql & " AND Wip7=1"
                Case 12
                    Sql = Sql & " AND Wip8=1"
                Case 13
                    Sql = Sql & " AND Wip9=1"
                Case 14
                    Sql = Sql & " AND Wip10=1"
                Case 15
                    Sql = Sql & " AND Wip11=1"
                Case 16
                    Sql = Sql & " AND Wip12=1"
                Case Else
                    Sql = Sql & " OR UserID='TAROTE'"
            End Select
            If CInt(GetDescr(Sql)(1)) >= 1 Then
                CheckPermission = True
            End If
            'If OpenDB() Then
            '    qResult = Nothing
            '    qResult = QueryDB(Sql, "UserCheck")
            '    CloseDB()
            '    If qResult(0) = "SUCCESS" Then
            '        If dtResult.Tables("UserCheck").Rows.Count > 0 Then
            '            CheckPermission = True
            '        End If
            '    End If
            'End If
        Catch ex As Exception

        End Try
    End Function

    Function UpdateJob(ByVal uLot As String, ByVal uBarcode As String, ByVal uBarcodeText As String) As Boolean
        Sql = "UPDATE [Jobs]"
        Sql = Sql & " SET [UserID] = '" & UserLogon.Trim & "',UserUpdate=GETDATE()"
        Sql = Sql & " WHERE [Lot] = '" & uLot.Trim & "' And Barcode='" & CInt(uBarcode.Trim) & "' And BarcodeText='" & uBarcodeText.Trim & "'"
        UpdateJob = QueryScript(Sql)
        Application.DoEvents()
    End Function
End Module
