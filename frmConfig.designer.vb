<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.StopBox = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.FlowControlBox = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ParityBox = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BitsBox = New System.Windows.Forms.ComboBox
        Me.BaudRateLabel = New System.Windows.Forms.Label
        Me.BaudRateBox = New System.Windows.Forms.ComboBox
        Me.ComPortLabel = New System.Windows.Forms.Label
        Me.COMPortsBox = New System.Windows.Forms.ComboBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.txtRxConvert = New System.Windows.Forms.TextBox
        Me.txtReceived = New System.Windows.Forms.TextBox
        Me.btmSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSql = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.StopBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.FlowControlBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ParityBox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.BitsBox)
        Me.Panel1.Controls.Add(Me.BaudRateLabel)
        Me.Panel1.Controls.Add(Me.BaudRateBox)
        Me.Panel1.Controls.Add(Me.ComPortLabel)
        Me.Panel1.Controls.Add(Me.COMPortsBox)
        Me.Panel1.Controls.Add(Me.txtData)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.txtRxConvert)
        Me.Panel1.Controls.Add(Me.txtReceived)
        Me.Panel1.Location = New System.Drawing.Point(5, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 272)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(171, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 40)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Green
        Me.btnStart.Location = New System.Drawing.Point(171, 164)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 61)
        Me.btnStart.TabIndex = 32
        Me.btnStart.Text = "Test receive"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(277, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(441, 253)
        Me.TextBox1.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Stop Bits"
        '
        'StopBox
        '
        Me.StopBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StopBox.FormattingEnabled = True
        Me.StopBox.Location = New System.Drawing.Point(171, 111)
        Me.StopBox.Name = "StopBox"
        Me.StopBox.Size = New System.Drawing.Size(50, 26)
        Me.StopBox.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(104, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 18)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Software Flow Control "
        Me.Label7.Visible = False
        '
        'FlowControlBox
        '
        Me.FlowControlBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlowControlBox.FormattingEnabled = True
        Me.FlowControlBox.Location = New System.Drawing.Point(171, 138)
        Me.FlowControlBox.Name = "FlowControlBox"
        Me.FlowControlBox.Size = New System.Drawing.Size(100, 26)
        Me.FlowControlBox.TabIndex = 45
        Me.FlowControlBox.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Parity"
        '
        'ParityBox
        '
        Me.ParityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParityBox.FormattingEnabled = True
        Me.ParityBox.Location = New System.Drawing.Point(171, 84)
        Me.ParityBox.Name = "ParityBox"
        Me.ParityBox.Size = New System.Drawing.Size(65, 26)
        Me.ParityBox.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(99, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Data Bits"
        '
        'BitsBox
        '
        Me.BitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitsBox.FormattingEnabled = True
        Me.BitsBox.Location = New System.Drawing.Point(171, 57)
        Me.BitsBox.Name = "BitsBox"
        Me.BitsBox.Size = New System.Drawing.Size(50, 26)
        Me.BitsBox.TabIndex = 41
        '
        'BaudRateLabel
        '
        Me.BaudRateLabel.AutoSize = True
        Me.BaudRateLabel.Location = New System.Drawing.Point(66, 33)
        Me.BaudRateLabel.Name = "BaudRateLabel"
        Me.BaudRateLabel.Size = New System.Drawing.Size(101, 18)
        Me.BaudRateLabel.TabIndex = 40
        Me.BaudRateLabel.Text = "Bit Rate (bit/s)"
        '
        'BaudRateBox
        '
        Me.BaudRateBox.FormattingEnabled = True
        Me.BaudRateBox.Location = New System.Drawing.Point(171, 30)
        Me.BaudRateBox.Name = "BaudRateBox"
        Me.BaudRateBox.Size = New System.Drawing.Size(83, 26)
        Me.BaudRateBox.TabIndex = 39
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = True
        Me.ComPortLabel.Location = New System.Drawing.Point(91, 6)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(76, 18)
        Me.ComPortLabel.TabIndex = 38
        Me.ComPortLabel.Text = "COM Port"
        '
        'COMPortsBox
        '
        Me.COMPortsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPortsBox.FormattingEnabled = True
        Me.COMPortsBox.Location = New System.Drawing.Point(171, 3)
        Me.COMPortsBox.Name = "COMPortsBox"
        Me.COMPortsBox.Size = New System.Drawing.Size(73, 26)
        Me.COMPortsBox.TabIndex = 37
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Blue
        Me.txtData.Location = New System.Drawing.Point(171, 227)
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtData.Size = New System.Drawing.Size(100, 31)
        Me.txtData.TabIndex = 34
        Me.txtData.Text = "0.00"
        Me.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(277, 230)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(69, 29)
        Me.btnStop.TabIndex = 33
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'txtRxConvert
        '
        Me.txtRxConvert.Location = New System.Drawing.Point(210, 207)
        Me.txtRxConvert.Multiline = True
        Me.txtRxConvert.Name = "txtRxConvert"
        Me.txtRxConvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRxConvert.Size = New System.Drawing.Size(10, 10)
        Me.txtRxConvert.TabIndex = 36
        Me.txtRxConvert.Visible = False
        '
        'txtReceived
        '
        Me.txtReceived.Location = New System.Drawing.Point(226, 205)
        Me.txtReceived.Multiline = True
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceived.Size = New System.Drawing.Size(10, 12)
        Me.txtReceived.TabIndex = 31
        Me.txtReceived.Visible = False
        '
        'btmSave
        '
        Me.btmSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btmSave.BackColor = System.Drawing.Color.Lime
        Me.btmSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btmSave.ForeColor = System.Drawing.Color.Blue
        Me.btmSave.Location = New System.Drawing.Point(5, 485)
        Me.btmSave.Name = "btmSave"
        Me.btmSave.Size = New System.Drawing.Size(85, 58)
        Me.btmSave.TabIndex = 2
        Me.btmSave.Text = "Save"
        Me.btmSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(646, 485)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 58)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckFileExists = False
        Me.OpenFileDialog1.CheckPathExists = False
        Me.OpenFileDialog1.FileName = "att2000"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.CheckFileExists = False
        Me.OpenFileDialog2.CheckPathExists = False
        Me.OpenFileDialog2.FileName = "data"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtPort)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtIP)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtPath)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnSql)
        Me.Panel4.Controls.Add(Me.txtPassword)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtUser)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txtDatabase)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.txtServer)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(433, 196)
        Me.Panel4.TabIndex = 0
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(310, 40)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(62, 24)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "1433"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = ":"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(171, 40)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(120, 24)
        Me.txtIP.TabIndex = 1
        Me.txtIP.Text = "192.168.1.1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "IP Address"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(171, 160)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(254, 24)
        Me.txtPath.TabIndex = 5
        Me.txtPath.Text = "C:\SSPayroll"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Path"
        '
        'btnSql
        '
        Me.btnSql.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSql.Location = New System.Drawing.Point(295, 100)
        Me.btnSql.Name = "btnSql"
        Me.btnSql.Size = New System.Drawing.Size(77, 54)
        Me.btnSql.TabIndex = 0
        Me.btnSql.Text = "Test connect"
        Me.btnSql.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(171, 130)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(118, 24)
        Me.txtPassword.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(58, 133)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "SQL Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(171, 100)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(118, 24)
        Me.txtUser.TabIndex = 3
        Me.txtUser.Text = "sa"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(93, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 18)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "SQL User"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(171, 70)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(201, 24)
        Me.txtDatabase.TabIndex = 2
        Me.txtDatabase.Text = "Payroll2018"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(96, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 18)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Database"
        '
        'txtServer
        '
        Me.txtServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServer.Location = New System.Drawing.Point(171, 10)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(202, 24)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "SERVER"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(82, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "SQL Server"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Panel2.Location = New System.Drawing.Point(177, 164)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 92)
        Me.Panel2.TabIndex = 50
        Me.Panel2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(38, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please wait..."
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1500
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(442, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 194)
        Me.Panel3.TabIndex = 51
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(113, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 24)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "TSC TTP-244 Pro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Printer Name"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(113, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(168, 24)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "Goldsmith"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Size Name"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(113, 69)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(75, 24)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "340"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 18)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "กว้าง"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(194, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Pixels"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(194, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Pixels"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(113, 99)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(75, 24)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "189"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(85, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 18)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "สูง"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(47, 132)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 18)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Preview"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBox1.Location = New System.Drawing.Point(113, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 26)
        Me.ComboBox1.TabIndex = 15
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btmSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 545)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btmSave)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config..."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btmSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSql As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StopBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FlowControlBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ParityBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BitsBox As System.Windows.Forms.ComboBox
    Friend WithEvents BaudRateLabel As System.Windows.Forms.Label
    Friend WithEvents BaudRateBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortLabel As System.Windows.Forms.Label
    Friend WithEvents COMPortsBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtRxConvert As System.Windows.Forms.TextBox
    Friend WithEvents txtReceived As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
