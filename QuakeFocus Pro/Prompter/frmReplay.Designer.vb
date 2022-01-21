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
        Me.title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectionEvent = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.curRew = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tpDocker.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpDocker
        '
        Me.tpDocker.BackColor = System.Drawing.Color.White
        Me.tpDocker.Controls.Add(Me.Label1)
        Me.tpDocker.Controls.Add(Me.title)
        Me.tpDocker.Dock = System.Windows.Forms.DockStyle.Top
        Me.tpDocker.Location = New System.Drawing.Point(0, 0)
        Me.tpDocker.Name = "tpDocker"
        Me.tpDocker.Size = New System.Drawing.Size(721, 85)
        Me.tpDocker.TabIndex = 0
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(12, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(181, 23)
        Me.title.TabIndex = 0
        Me.title.Text = "Replay EEW Broadcast"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'selectionEvent
        '
        Me.selectionEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.selectionEvent.Location = New System.Drawing.Point(193, 34)
        Me.selectionEvent.Name = "selectionEvent"
        Me.selectionEvent.Size = New System.Drawing.Size(266, 22)
        Me.selectionEvent.TabIndex = 1
        Me.selectionEvent.Value = New Date(2021, 10, 6, 2, 46, 9, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Date && Time:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRewind)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.selectionEvent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnRewind
        '
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
        Me.curRew.Location = New System.Drawing.Point(413, 239)
        Me.curRew.Name = "curRew"
        Me.curRew.Size = New System.Drawing.Size(276, 18)
        Me.curRew.TabIndex = 4
        Me.curRew.Text = "Currently Rewinding To: XX/XX/XXXX XX:XX:XX"
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
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(283, 68)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(58, 32)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'frmReplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 265)
        Me.Controls.Add(Me.curRew)
        Me.Controls.Add(Me.tpDocker)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReplay"
        Me.ShowIcon = False
        Me.Text = "Replay"
        Me.tpDocker.ResumeLayout(False)
        Me.tpDocker.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tpDocker As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents title As Label
    Friend WithEvents selectionEvent As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRewind As Button
    Friend WithEvents curRew As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnStop As Button
End Class
