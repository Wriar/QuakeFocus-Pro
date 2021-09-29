<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lmsVar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lmsVar))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prefecture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIEDx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIEDY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.alertTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.importTuples = New System.Windows.Forms.Timer(Me.components)
        Me.updateTable = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.watchdog = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.infoReporter = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatTo = New System.Windows.Forms.Label()
        Me.lblStatTu = New System.Windows.Forms.Label()
        Me.lblStatTa = New System.Windows.Forms.Label()
        Me.lblStatWd = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lblVar = New System.Windows.Forms.Label()
        Me.ingestRealTime = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ingestRealTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.location, Me.prefecture, Me.NIEDx, Me.NIEDY, Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8, Me.c9, Me.c10})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(938, 372)
        Me.DataGridView1.TabIndex = 7
        '
        'location
        '
        Me.location.HeaderText = "Location"
        Me.location.MinimumWidth = 6
        Me.location.Name = "location"
        Me.location.Width = 125
        '
        'prefecture
        '
        Me.prefecture.HeaderText = "Prefecture"
        Me.prefecture.MinimumWidth = 6
        Me.prefecture.Name = "prefecture"
        Me.prefecture.Width = 125
        '
        'NIEDx
        '
        Me.NIEDx.HeaderText = "NIED-X"
        Me.NIEDx.MinimumWidth = 6
        Me.NIEDx.Name = "NIEDx"
        Me.NIEDx.Width = 125
        '
        'NIEDY
        '
        Me.NIEDY.HeaderText = "NIED-Y"
        Me.NIEDY.MinimumWidth = 6
        Me.NIEDY.Name = "NIEDY"
        Me.NIEDY.Width = 125
        '
        'c1
        '
        Me.c1.HeaderText = "Iteration 1"
        Me.c1.MinimumWidth = 6
        Me.c1.Name = "c1"
        Me.c1.Width = 125
        '
        'c2
        '
        Me.c2.HeaderText = "Iteration 2"
        Me.c2.MinimumWidth = 6
        Me.c2.Name = "c2"
        Me.c2.Width = 125
        '
        'c3
        '
        Me.c3.HeaderText = "Iteration 3"
        Me.c3.MinimumWidth = 6
        Me.c3.Name = "c3"
        Me.c3.Width = 125
        '
        'c4
        '
        Me.c4.HeaderText = "Iteration 4"
        Me.c4.MinimumWidth = 6
        Me.c4.Name = "c4"
        Me.c4.Width = 125
        '
        'c5
        '
        Me.c5.HeaderText = "Iteration 5"
        Me.c5.MinimumWidth = 6
        Me.c5.Name = "c5"
        Me.c5.Width = 125
        '
        'c6
        '
        Me.c6.HeaderText = "Iteration 6"
        Me.c6.MinimumWidth = 6
        Me.c6.Name = "c6"
        Me.c6.Width = 125
        '
        'c7
        '
        Me.c7.HeaderText = "Iteration 7"
        Me.c7.MinimumWidth = 6
        Me.c7.Name = "c7"
        Me.c7.Width = 125
        '
        'c8
        '
        Me.c8.HeaderText = "Iteration 8"
        Me.c8.MinimumWidth = 6
        Me.c8.Name = "c8"
        Me.c8.Width = 125
        '
        'c9
        '
        Me.c9.HeaderText = "Iteration 9"
        Me.c9.MinimumWidth = 6
        Me.c9.Name = "c9"
        Me.c9.Width = 125
        '
        'c10
        '
        Me.c10.HeaderText = "Iteration 10"
        Me.c10.MinimumWidth = 6
        Me.c10.Name = "c10"
        Me.c10.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "1. Import Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(775, 597)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 44)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "4.Print out DataTable"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 722)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 29)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Load High-Intensity"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'alertTimeout
        '
        Me.alertTimeout.Interval = 1000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(775, 497)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 44)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "2. Run Average"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(775, 547)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 44)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "3. Run Table Import"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'importTuples
        '
        Me.importTuples.Interval = 1000
        '
        'updateTable
        '
        Me.updateTable.Interval = 1000
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(519, 447)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 44)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Start"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'watchdog
        '
        Me.watchdog.Interval = 1000
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(423, 687)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(160, 29)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Load LOW-Intensity"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(762, 669)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 102)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "timeout:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tuple:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "table:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "watchdog:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Var:"
        '
        'infoReporter
        '
        Me.infoReporter.Interval = 500
        '
        'lblStatTo
        '
        Me.lblStatTo.AutoSize = True
        Me.lblStatTo.BackColor = System.Drawing.Color.Blue
        Me.lblStatTo.ForeColor = System.Drawing.Color.White
        Me.lblStatTo.Location = New System.Drawing.Point(842, 666)
        Me.lblStatTo.Name = "lblStatTo"
        Me.lblStatTo.Size = New System.Drawing.Size(16, 17)
        Me.lblStatTo.TabIndex = 17
        Me.lblStatTo.Text = "e"
        '
        'lblStatTu
        '
        Me.lblStatTu.AutoSize = True
        Me.lblStatTu.BackColor = System.Drawing.Color.Blue
        Me.lblStatTu.ForeColor = System.Drawing.Color.White
        Me.lblStatTu.Location = New System.Drawing.Point(842, 687)
        Me.lblStatTu.Name = "lblStatTu"
        Me.lblStatTu.Size = New System.Drawing.Size(16, 17)
        Me.lblStatTu.TabIndex = 18
        Me.lblStatTu.Text = "e"
        '
        'lblStatTa
        '
        Me.lblStatTa.AutoSize = True
        Me.lblStatTa.BackColor = System.Drawing.Color.Blue
        Me.lblStatTa.ForeColor = System.Drawing.Color.White
        Me.lblStatTa.Location = New System.Drawing.Point(842, 708)
        Me.lblStatTa.Name = "lblStatTa"
        Me.lblStatTa.Size = New System.Drawing.Size(16, 17)
        Me.lblStatTa.TabIndex = 19
        Me.lblStatTa.Text = "e"
        '
        'lblStatWd
        '
        Me.lblStatWd.AutoSize = True
        Me.lblStatWd.BackColor = System.Drawing.Color.Blue
        Me.lblStatWd.ForeColor = System.Drawing.Color.White
        Me.lblStatWd.Location = New System.Drawing.Point(842, 729)
        Me.lblStatWd.Name = "lblStatWd"
        Me.lblStatWd.Size = New System.Drawing.Size(16, 17)
        Me.lblStatWd.TabIndex = 20
        Me.lblStatWd.Text = "e"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(589, 687)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 64)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Report Info"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lblVar
        '
        Me.lblVar.AutoSize = True
        Me.lblVar.BackColor = System.Drawing.Color.Blue
        Me.lblVar.ForeColor = System.Drawing.Color.White
        Me.lblVar.Location = New System.Drawing.Point(842, 754)
        Me.lblVar.Name = "lblVar"
        Me.lblVar.Size = New System.Drawing.Size(16, 17)
        Me.lblVar.TabIndex = 22
        Me.lblVar.Text = "e"
        '
        'ingestRealTime
        '
        Me.ingestRealTime.Image = CType(resources.GetObject("ingestRealTime.Image"), System.Drawing.Image)
        Me.ingestRealTime.Location = New System.Drawing.Point(12, 423)
        Me.ingestRealTime.Name = "ingestRealTime"
        Me.ingestRealTime.Size = New System.Drawing.Size(938, 378)
        Me.ingestRealTime.TabIndex = 8
        Me.ingestRealTime.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(964, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(411, 500)
        Me.ListBox1.TabIndex = 23
        '
        'lmsVar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 794)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblVar)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lblStatWd)
        Me.Controls.Add(Me.lblStatTa)
        Me.Controls.Add(Me.lblStatTu)
        Me.Controls.Add(Me.lblStatTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ingestRealTime)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "lmsVar"
        Me.Text = "lmsVar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ingestRealTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents location As DataGridViewTextBoxColumn
    Friend WithEvents prefecture As DataGridViewTextBoxColumn
    Friend WithEvents NIEDx As DataGridViewTextBoxColumn
    Friend WithEvents NIEDY As DataGridViewTextBoxColumn
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents c6 As DataGridViewTextBoxColumn
    Friend WithEvents c7 As DataGridViewTextBoxColumn
    Friend WithEvents c8 As DataGridViewTextBoxColumn
    Friend WithEvents c9 As DataGridViewTextBoxColumn
    Friend WithEvents c10 As DataGridViewTextBoxColumn
    Friend WithEvents ingestRealTime As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents alertTimeout As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents importTuples As Timer
    Friend WithEvents updateTable As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents watchdog As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents infoReporter As Timer
    Friend WithEvents lblStatTo As Label
    Friend WithEvents lblStatTu As Label
    Friend WithEvents lblStatTa As Label
    Friend WithEvents lblStatWd As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents lblVar As Label
    Friend WithEvents ListBox1 As ListBox
End Class
