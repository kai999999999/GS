Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSearch
    Dim daSearch As New SqlDataAdapter
    Dim dsSearch As New DataSet
    Dim sqlSearch As String

    Private Sub frmSerach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = strCaption
        Timer1.Enabled = True
    End Sub

    Private Function LoadData() As Boolean
        LoadData = False
        On Error GoTo Err_Load
        If Not OpenDB() Then
            Exit Function
        End If
        daSearch = New SqlDataAdapter(sqlSearch, Conn)
        dsSearch = New DataSet
        daSearch.Fill(dsSearch)
        daSearch.Dispose()
        bsSearch.DataMember = dsSearch.Tables(0).TableName
        bsSearch.DataSource = dsSearch
        LoadData = True
Err_Load:
        On Error GoTo 0
    End Function

    Private Sub ShowData()
        fpSearch.DataSource = bsSearch
        fpSearch_Search.SetActiveCell(0, 0)
    End Sub

    Private Sub ListField()
        Dim i As Integer
        cmbBy.Items.Clear()
        cmbBy.Items.Add("All")
        For i = 0 To dsSearch.Tables(0).Columns.Count - 1
            cmbBy.Items.Add(dsSearch.Tables(0).Columns(i).ColumnName)
        Next
        cmbBy.SelectedIndex = 0
    End Sub

    Private Sub ListFill()
        cmbFill.Items.Clear()
        cmbFill.Items.Add("Start with")
        cmbFill.Items.Add("Contains")
        cmbFill.SelectedIndex = 1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        dataField = ""
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        SendClick()
    End Sub
    Sub SendClick()
        dataField = fpSearch_Search.Cells(fpSearch_Search.ActiveRow.Index, dataRet).Text.Trim
        For Xs As Integer = 0 To RetCount
            RetData(Xs) = fpSearch_Search.Cells(fpSearch_Search.ActiveRow.Index, RetField(Xs)).Text.Trim
        Next
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If strSqlWhere.Trim <> "" Then
            sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " WHERE (" & strSqlWhere & ") ORDER BY " & strSqlOrderBy
        Else
            sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " ORDER BY " & strSqlOrderBy
        End If
        If LoadData() Then
            ShowData()
            palCriteria.Visible = False
            ListField()
            ListFill()
            txtSearch.Text = ""
        End If
    End Sub

    Private Sub fpSearch_CellDoubleClick(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpSearch.CellDoubleClick
        SendClick
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim strFind As String
        If cmbBy.SelectedIndex = 0 Then
            If strSqlWhere.Trim <> "" Then
                sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " WHERE (" & strSqlWhere & ") ORDER BY " & strSqlOrderBy
            Else
                sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " ORDER BY " & strSqlOrderBy
            End If
        Else
            If cmbFill.SelectedIndex = 0 Then
                strFind = "(" & cmbBy.SelectedItem.ToString.Trim & " LIKE '" & txtSearch.Text.Trim & "%')"
            Else
                strFind = "(" & cmbBy.SelectedItem.ToString.Trim & " LIKE '%" & txtSearch.Text.Trim & "%')"
            End If
            If strSqlWhere.Trim <> "" Then
                sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " WHERE (" & strSqlWhere & ") AND " & strFind & " ORDER BY " & strSqlOrderBy
            Else
                sqlSearch = "SELECT " & strSqlSelect & " FROM " & strSqlFrom & " WHERE " & strFind & " ORDER BY " & strSqlOrderBy
            End If
        End If
        If LoadData() Then
            ShowData()
        End If
    End Sub

    Private Sub cmbBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBy.SelectedIndexChanged
        If cmbBy.SelectedIndex <> 0 Then
            palCriteria.Visible = True
        Else
            palCriteria.Visible = False
        End If
    End Sub

    Private Sub fpSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fpSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            dataField = fpSearch_Search.Cells(fpSearch_Search.ActiveRow.Index, dataRet).Text.Trim
            Me.Close()
        End If
    End Sub

    Private Sub fpSearch_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles fpSearch.CellClick

    End Sub
End Class