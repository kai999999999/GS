Imports System.IO
Imports System.Net
Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        UserLogon = ""
        UserLevel = 0
        If txtUserID.Text.Trim <> "" And txtPassword.Text.Trim <> "" Then
            Dim IPHEntry As IPHostEntry
            Dim IPAdd() As IPAddress
            Dim LocalHost As String = Dns.GetHostName
            IPHEntry = Dns.GetHostByName(LocalHost)
            IPAdd = IPHEntry.AddressList
            If txtUserID.Text.Trim <> "" Then
                If txtPassword.Text.Trim <> "" Then
                    Dim Pwd As String = SiRiDev.Encrypt(txtPassword.Text.Trim, "Www.SiRiDev.Com")
                    Sql = "SELECT * FROM UserLogon WHERE UserID='" & txtUserID.Text.Trim & "' AND UserPassword='" & Pwd & "' AND Active=0"
                    If OpenDB() Then
                        qResult = Nothing
                        qResult = QueryDB(Sql, "UserLog")
                        CloseDB()
                        If qResult(0) = "SUCCESS" Then
                            If dtResult.Tables("UserLog").Rows.Count > 0 Then
                                UserLogon = txtUserID.Text.Trim
                                UserLevel = 9
                                Application.DoEvents()
                                Sql = "INSERT INTO UserHistory([UserID],[IPAddress]) VALUES('" & txtUserID.Text.Trim & "','" & IPAdd(0).ToString.Trim & "')"
                                QueryScript(Sql)
                                SiRiDevINI.WriteIni(Application.StartupPath & "/logon.ini", "Logon", "USERID", UserLogon.Trim)
                                Me.Close()
                            Else
                                MessageBox.Show("UserID หรือ Password ไม่ถูกต้อง" & vbCrLf & vbCrLf & "กรุณาตรวจสอบ แล้วลองใหม่อีกครั้ง หรือติดต่อขอรหัสใหม่จากผู้ดูแลระบบ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("เกิดข้อผิดพลาดขึ้นในการเข้าใช้งาน" & vbCrLf & vbCrLf & qResult(1), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้...." & vbCrLf & vbCrLf & "กรุณาตั้งค่าฐานข้อมูลใหม่ หรือติดต่อเจ้าหน้าที่ที่เกี่ยวข้อง เพื่อทำการแก้ไขต่อไป", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("กรุณาใส่ Password ของท่าน...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Focus()
                End If
            Else
                MessageBox.Show("กรุณาใส่ UserID ของท่าน...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserID.Focus()
            End If
        Else
            MessageBox.Show("Please enter Username and Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserID.Focus()
            txtUserID.SelectAll()
            Exit Sub
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If File.Exists(Application.StartupPath & "/logon.ini") Then
            Dim UserINI As String = SiRiDevINI.ReadIni(Application.StartupPath & "/logon.ini", "Logon", "USERID")
            Dim DateINI As String = SiRiDevINI.ReadIni(Application.StartupPath & "/logon.ini", "Logon", "DATE")
            Application.DoEvents()
            txtUserID.Text = UserINI
        End If
        Application.DoEvents()
        If Conn.State = ConnectionState.Closed Then
            connect()
        End If
        If Conn.State = ConnectionState.Closed Then
            MessageBox.Show("Error!!! ไม่สามารถติดต่อฐานข้อมูลได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If UserLogon = Nothing Then
            Timer1.Enabled = True
        Else
            If UserLogon.Trim = "" Then
                Timer1.Enabled = True
            Else
                txtUserID.Text = UserLogon
                txtUserID.Focus()
            End If
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        frmChangePassword.ShowDialog()
    End Sub
End Class