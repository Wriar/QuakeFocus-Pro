<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lightDetect
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
        Me.ingestRealTime = New System.Windows.Forms.PictureBox()
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
        Me.btnImportTable = New System.Windows.Forms.Button()
        Me.btnIterate = New System.Windows.Forms.Button()
        Me.btnPrintTuple = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.updateTuple = New System.Windows.Forms.Timer(Me.components)
        Me.updateChart = New System.Windows.Forms.Timer(Me.components)
        Me.runWatchdog = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVar = New System.Windows.Forms.Label()
        Me.lblStatWd = New System.Windows.Forms.Label()
        Me.lblStatTa = New System.Windows.Forms.Label()
        Me.lblStatTu = New System.Windows.Forms.Label()
        Me.updateInfo = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.ingestRealTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ingestRealTime
        '
        Me.ingestRealTime.Image = Global.QuakeFocus_Pro.My.Resources.Resources.hi_demo
        Me.ingestRealTime.Location = New System.Drawing.Point(12, 12)
        Me.ingestRealTime.Name = "ingestRealTime"
        Me.ingestRealTime.Size = New System.Drawing.Size(340, 391)
        Me.ingestRealTime.TabIndex = 0
        Me.ingestRealTime.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.location, Me.prefecture, Me.NIEDx, Me.NIEDY, Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8, Me.c9, Me.c10})
        Me.DataGridView1.Location = New System.Drawing.Point(368, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(860, 372)
        Me.DataGridView1.TabIndex = 8
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
        'btnImportTable
        '
        Me.btnImportTable.Location = New System.Drawing.Point(12, 433)
        Me.btnImportTable.Name = "btnImportTable"
        Me.btnImportTable.Size = New System.Drawing.Size(117, 49)
        Me.btnImportTable.TabIndex = 9
        Me.btnImportTable.Text = "1. Import Table"
        Me.btnImportTable.UseVisualStyleBackColor = True
        '
        'btnIterate
        '
        Me.btnIterate.Location = New System.Drawing.Point(135, 433)
        Me.btnIterate.Name = "btnIterate"
        Me.btnIterate.Size = New System.Drawing.Size(117, 49)
        Me.btnIterate.TabIndex = 10
        Me.btnIterate.Text = "2. Iterations"
        Me.btnIterate.UseVisualStyleBackColor = True
        '
        'btnPrintTuple
        '
        Me.btnPrintTuple.Location = New System.Drawing.Point(12, 488)
        Me.btnPrintTuple.Name = "btnPrintTuple"
        Me.btnPrintTuple.Size = New System.Drawing.Size(117, 28)
        Me.btnPrintTuple.TabIndex = 11
        Me.btnPrintTuple.Text = "2.5 Print Tuple"
        Me.btnPrintTuple.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 49)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "3. Add to Tuple"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'updateTuple
        '
        Me.updateTuple.Interval = 1000
        '
        'updateChart
        '
        Me.updateChart.Interval = 1000
        '
        'runWatchdog
        '
        Me.runWatchdog.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "4 Start Timers"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 490)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 26)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "5. Import info"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVar)
        Me.GroupBox1.Controls.Add(Me.lblStatWd)
        Me.GroupBox1.Controls.Add(Me.lblStatTa)
        Me.GroupBox1.Controls.Add(Me.lblStatTu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(931, 390)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 126)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debug Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuple:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chart:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Watchdog:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Var:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVar
        '
        Me.lblVar.AutoSize = True
        Me.lblVar.BackColor = System.Drawing.Color.Blue
        Me.lblVar.ForeColor = System.Drawing.Color.White
        Me.lblVar.Location = New System.Drawing.Point(95, 99)
        Me.lblVar.Name = "lblVar"
        Me.lblVar.Size = New System.Drawing.Size(81, 17)
        Me.lblVar.TabIndex = 27
        Me.lblVar.Text = "UNKNOWN"
        '
        'lblStatWd
        '
        Me.lblStatWd.AutoSize = True
        Me.lblStatWd.BackColor = System.Drawing.Color.Blue
        Me.lblStatWd.ForeColor = System.Drawing.Color.White
        Me.lblStatWd.Location = New System.Drawing.Point(95, 70)
        Me.lblStatWd.Name = "lblStatWd"
        Me.lblStatWd.Size = New System.Drawing.Size(81, 17)
        Me.lblStatWd.TabIndex = 26
        Me.lblStatWd.Text = "UNKNOWN"
        '
        'lblStatTa
        '
        Me.lblStatTa.AutoSize = True
        Me.lblStatTa.BackColor = System.Drawing.Color.Blue
        Me.lblStatTa.ForeColor = System.Drawing.Color.White
        Me.lblStatTa.Location = New System.Drawing.Point(95, 49)
        Me.lblStatTa.Name = "lblStatTa"
        Me.lblStatTa.Size = New System.Drawing.Size(81, 17)
        Me.lblStatTa.TabIndex = 25
        Me.lblStatTa.Text = "UNKNOWN"
        '
        'lblStatTu
        '
        Me.lblStatTu.AutoSize = True
        Me.lblStatTu.BackColor = System.Drawing.Color.Blue
        Me.lblStatTu.ForeColor = System.Drawing.Color.White
        Me.lblStatTu.Location = New System.Drawing.Point(95, 28)
        Me.lblStatTu.Name = "lblStatTu"
        Me.lblStatTu.Size = New System.Drawing.Size(81, 17)
        Me.lblStatTu.TabIndex = 24
        Me.lblStatTu.Text = "UNKNOWN"
        '
        'updateInfo
        '
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Low Int."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(20, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "High Int."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(430, 444)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 49)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "3. Add to Tuple"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lightDetect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 528)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPrintTuple)
        Me.Controls.Add(Me.btnIterate)
        Me.Controls.Add(Me.btnImportTable)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ingestRealTime)
        Me.Name = "lightDetect"
        Me.Text = "lightDetect"
        CType(Me.ingestRealTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ingestRealTime As PictureBox
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
    Friend WithEvents btnImportTable As Button
    Friend WithEvents btnIterate As Button
    Friend WithEvents btnPrintTuple As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents updateTuple As Timer
    Friend WithEvents updateChart As Timer
    Friend WithEvents runWatchdog As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVar As Label
    Friend WithEvents lblStatWd As Label
    Friend WithEvents lblStatTa As Label
    Friend WithEvents lblStatTu As Label
    Friend WithEvents updateInfo As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
