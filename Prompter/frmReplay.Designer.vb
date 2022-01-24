<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReplay))
        Me.tpDocker = New System.Windows.Forms.Panel()
        Me.capText = New System.Windows.Forms.Label()
        Me.titleText = New System.Windows.Forms.Label()
        Me.selectionEvent = New System.Windows.Forms.DateTimePicker()
        Me.selectPrompt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.curRew = New System.Windows.Forms.Label()
        Me.cusJsonServerCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.jsonServerPrompt = New System.Windows.Forms.Label()
        Me.cusJsonserver = New System.Windows.Forms.TextBox()
        Me.cusRealtimeServer = New System.Windows.Forms.TextBox()
        Me.realtimeServerPrompt = New System.Windows.Forms.Label()
        Me.cusRealtimeServerCheck = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tpDocker.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpDocker
        '
        Me.tpDocker.BackColor = System.Drawing.Color.White
        Me.tpDocker.Controls.Add(Me.capText)
        Me.tpDocker.Controls.Add(Me.titleText)
        Me.tpDocker.Dock = System.Windows.Forms.DockStyle.Top
        Me.tpDocker.Location = New System.Drawing.Point(0, 0)
        Me.tpDocker.Name = "tpDocker"
        Me.tpDocker.Size = New System.Drawing.Size(721, 85)
        Me.tpDocker.TabIndex = 0
        '
        'capText
        '
        Me.capText.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capText.Location = New System.Drawing.Point(12, 35)
        Me.capText.Name = "capText"
        Me.capText.Size = New System.Drawing.Size(697, 35)
        Me.capText.TabIndex = 1
        Me.capText.Text = resources.GetString("capText.Text")
        '
        'titleText
        '
        Me.titleText.AutoSize = True
        Me.titleText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleText.Location = New System.Drawing.Point(12, 9)
        Me.titleText.Name = "titleText"
        Me.titleText.Size = New System.Drawing.Size(181, 23)
        Me.titleText.TabIndex = 0
        Me.titleText.Text = "Replay EEW Broadcast"
        '
        'selectionEvent
        '
        Me.selectionEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.selectionEvent.Location = New System.Drawing.Point(193, 34)
        Me.selectionEvent.Name = "selectionEvent"
        Me.selectionEvent.Size = New System.Drawing.Size(266, 22)
        Me.selectionEvent.TabIndex = 1
        Me.selectionEvent.Value = New Date(2021, 9, 16, 18, 42, 33, 0)
        '
        'selectPrompt
        '
        Me.selectPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectPrompt.Location = New System.Drawing.Point(17, 34)
        Me.selectPrompt.Name = "selectPrompt"
        Me.selectPrompt.Size = New System.Drawing.Size(164, 23)
        Me.selectPrompt.TabIndex = 2
        Me.selectPrompt.Text = "Select Date && Time:"
        Me.selectPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRewind)
        Me.GroupBox1.Controls.Add(Me.selectPrompt)
        Me.GroupBox1.Controls.Add(Me.selectionEvent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Location = New System.Drawing.Point(283, 68)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(58, 32)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(465, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "JST"
        '
        'btnRewind
        '
        Me.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRewind.Location = New System.Drawing.Point(347, 68)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(112, 32)
        Me.btnRewind.TabIndex = 3
        Me.btnRewind.Text = "Rewind"
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'curRew
        '
        Me.curRew.AutoSize = True
        Me.curRew.Font = New System.Drawing.Font("Gen Shin Gothic Regular", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curRew.ForeColor = System.Drawing.Color.Orange
        Me.curRew.Location = New System.Drawing.Point(547, 346)
        Me.curRew.Name = "curRew"
        Me.curRew.Size = New System.Drawing.Size(146, 18)
        Me.curRew.TabIndex = 4
        Me.curRew.Text = "Rewinding in Progress."
        '
        'cusJsonServerCheck
        '
        Me.cusJsonServerCheck.AutoSize = True
        Me.cusJsonServerCheck.Font = New System.Drawing.Font("Gen Shin Gothic Regular", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusJsonServerCheck.Location = New System.Drawing.Point(468, 22)
        Me.cusJsonServerCheck.Name = "cusJsonServerCheck"
        Me.cusJsonServerCheck.Size = New System.Drawing.Size(181, 22)
        Me.cusJsonServerCheck.TabIndex = 5
        Me.cusJsonServerCheck.Text = "Use Custom &JSON Server"
        Me.cusJsonServerCheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cusRealtimeServerCheck)
        Me.GroupBox2.Controls.Add(Me.realtimeServerPrompt)
        Me.GroupBox2.Controls.Add(Me.cusRealtimeServer)
        Me.GroupBox2.Controls.Add(Me.cusJsonserver)
        Me.GroupBox2.Controls.Add(Me.jsonServerPrompt)
        Me.GroupBox2.Controls.Add(Me.cusJsonServerCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 90)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'jsonServerPrompt
        '
        Me.jsonServerPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonServerPrompt.Location = New System.Drawing.Point(5, 21)
        Me.jsonServerPrompt.Name = "jsonServerPrompt"
        Me.jsonServerPrompt.Size = New System.Drawing.Size(164, 23)
        Me.jsonServerPrompt.TabIndex = 2
        Me.jsonServerPrompt.Text = "JSON Server:"
        Me.jsonServerPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cusJsonserver
        '
        Me.cusJsonserver.Enabled = False
        Me.cusJsonserver.Location = New System.Drawing.Point(181, 21)
        Me.cusJsonserver.Name = "cusJsonserver"
        Me.cusJsonserver.Size = New System.Drawing.Size(266, 22)
        Me.cusJsonserver.TabIndex = 6
        Me.cusJsonserver.Text = "www.kmoni.bosai.go.jp"
        '
        'cusRealtimeServer
        '
        Me.cusRealtimeServer.Enabled = False
        Me.cusRealtimeServer.Location = New System.Drawing.Point(181, 58)
        Me.cusRealtimeServer.Name = "cusRealtimeServer"
        Me.cusRealtimeServer.Size = New System.Drawing.Size(266, 22)
        Me.cusRealtimeServer.TabIndex = 7
        Me.cusRealtimeServer.Text = "http://www.kmoni.bosai.go.jp/"
        '
        'realtimeServerPrompt
        '
        Me.realtimeServerPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realtimeServerPrompt.Location = New System.Drawing.Point(5, 57)
        Me.realtimeServerPrompt.Name = "realtimeServerPrompt"
        Me.realtimeServerPrompt.Size = New System.Drawing.Size(164, 23)
        Me.realtimeServerPrompt.TabIndex = 8
        Me.realtimeServerPrompt.Text = "RealTime Server:"
        Me.realtimeServerPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cusRealtimeServerCheck
        '
        Me.cusRealtimeServerCheck.AutoSize = True
        Me.cusRealtimeServerCheck.Font = New System.Drawing.Font("Gen Shin Gothic Regular", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusRealtimeServerCheck.Location = New System.Drawing.Point(468, 58)
        Me.cusRealtimeServerCheck.Name = "cusRealtimeServerCheck"
        Me.cusRealtimeServerCheck.Size = New System.Drawing.Size(201, 22)
        Me.cusRealtimeServerCheck.TabIndex = 9
        Me.cusRealtimeServerCheck.Text = "Use Custom &Realtime Server"
        Me.cusRealtimeServerCheck.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Dev"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmReplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.curRew)
        Me.Controls.Add(Me.tpDocker)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReplay"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Replay"
        Me.tpDocker.ResumeLayout(False)
        Me.tpDocker.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tpDocker As Panel
    Friend WithEvents capText As Label
    Friend WithEvents titleText As Label
    Friend WithEvents selectionEvent As DateTimePicker
    Friend WithEvents selectPrompt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRewind As Button
    Friend WithEvents curRew As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents cusJsonServerCheck As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents realtimeServerPrompt As Label
    Friend WithEvents cusRealtimeServer As TextBox
    Friend WithEvents cusJsonserver As TextBox
    Friend WithEvents jsonServerPrompt As Label
    Friend WithEvents cusRealtimeServerCheck As CheckBox
    Friend WithEvents Button1 As Button
End Class
