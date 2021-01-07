Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module basPermission
    Function chkPer(ByVal save As Boolean, ByVal MenuOne As Integer, ByVal MenuTwo As Integer) As Boolean
        chkPer = False
        Try
            Dim dsP As New DataSet
            Dim daP As New SqlDataAdapter
            Dim tSql As String = ""
            Sql = "SELECT * FROM [Menu] ORDER BY [Menu],[LineMenu]"
            daP = New SqlDataAdapter(Sql, Conn)
            daP.Fill(dsP, "Menu")
            daP.Dispose()
            If dsP.Tables("Menu").Rows.Count > 0 Then
                For i As Integer = 0 To dsP.Tables("Menu").Rows.Count - 1
                    If save Then
                        Sql = "SELECT MenuPermission.[Save]"
                    Else
                        Sql = "SELECT MenuPermission.[Delete]"
                    End If
                    Sql = Sql & " FROM UserPermission INNER JOIN"
                    Sql = Sql & " MenuPermission ON UserPermission.PerCode" & MenuOne & " = MenuPermission.PerCode"
                    Sql = Sql & " WHERE (UserID='" & UserLogon.Trim.Trim.ToUpper & "' AND Menu=" & MenuOne & " AND LineMenu=" & MenuTwo & ")"
                    tSql = getDescr(Sql)
                    If IsNumeric(tSql) Then
                        If CInt(tSql) = 1 Then
                            chkPer = True
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            chkPer = False
        End Try
    End Function

    Function chkPerEmp(ByVal EmpCode As String) As Boolean
        chkPerEmp = False
        Try
            Dim t As String = getDescr("SELECT EmployeeID FROM UserLogin WHERE UserID='" & UserLogon.Trim & "'")
            If t.Trim <> "" Then
                If t.Trim.ToUpper = EmpCode.Trim.ToUpper Then
                    chkPerEmp = True
                End If
            End If
        Catch ex As Exception
            chkPerEmp = False
        End Try
    End Function
End Module
