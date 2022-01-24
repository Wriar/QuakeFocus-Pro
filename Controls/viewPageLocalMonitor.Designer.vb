<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewPageLocalMonitor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorBar1 = New ColorBar.ColorBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbIntColor = New System.Windows.Forms.Panel()
        Me.hIntLbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.demoLineAdd = New System.Windows.Forms.Timer(Me.components)
        Me.pbIntColor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gen Shin Gothic Normal", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(181, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tokyo, Japan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorBar1
        '
        Me.ColorBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBar1.ColorList = Nothing
        Me.ColorBar1.HeightThickness = 0.2!
        Me.ColorBar1.Location = New System.Drawing.Point(16, 23)
        Me.ColorBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ColorBar1.Maximum = 100
        Me.ColorBar1.Minimum = 0
        Me.ColorBar1.Name = "ColorBar1"
        Me.ColorBar1.Orientation = ColorBar.ColorBar.enumOrientation.Vertical
        Me.ColorBar1.Reversed = False
        Me.ColorBar1.Size = New System.Drawing.Size(23, 100)
        Me.ColorBar1.Smoothness = 7
        Me.ColorBar1.Style = ColorBar.ColorBar.BarStyle.Flow
        Me.ColorBar1.TabIndex = 1
        Me.ColorBar1.Value = 67
        Me.ColorBar1.WidthThickness = 0.2!
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gen Shin Gothic Regular", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INT: -3"
        Me.ToolTip1.SetToolTip(Me.Label2, "Current INT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "現在のINT")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gen Shin Gothic Regular", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "D: +1.0"
        Me.ToolTip1.SetToolTip(Me.Label5, "Alert Threshold" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "アラートしきい値")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(190, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 77)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PGA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PGV:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INT(P):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label3, "(Peak Ground Acceleration) [gal]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Peak Ground Velocity) [cm/s]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prefecture INT A" &
        "verage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(最大地動加速度) [gal]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(最大地動速度) [cm/s]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "平均県「INT」平均" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(270, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 77)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0.01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbIntColor
        '
        Me.pbIntColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pbIntColor.Controls.Add(Me.hIntLbl)
        Me.pbIntColor.Location = New System.Drawing.Point(315, 60)
        Me.pbIntColor.Name = "pbIntColor"
        Me.pbIntColor.Padding = New System.Windows.Forms.Padding(8)
        Me.pbIntColor.Size = New System.Drawing.Size(86, 77)
        Me.pbIntColor.TabIndex = 8
        '
        'hIntLbl
        '
        Me.hIntLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.hIntLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hIntLbl.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hIntLbl.ForeColor = System.Drawing.Color.White
        Me.hIntLbl.Location = New System.Drawing.Point(8, 8)
        Me.hIntLbl.Name = "hIntLbl"
        Me.hIntLbl.Size = New System.Drawing.Size(70, 61)
        Me.hIntLbl.TabIndex = 0
        Me.hIntLbl.Text = "0"
        Me.hIntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.hIntLbl, "現在の「INT」値" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current INT Value.")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(63, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 100)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(118, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'demoLineAdd
        '
        Me.demoLineAdd.Interval = 1000
        '
        'viewPageLocalMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbIntColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColorBar1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewPageLocalMonitor"
        Me.Size = New System.Drawing.Size(418, 150)
        Me.pbIntColor.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ColorBar1 As ColorBar.ColorBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbIntColor As Panel
    Friend WithEvents hIntLbl As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents demoLineAdd As Timer
End Class
