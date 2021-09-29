<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class flowSmallEvent
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
        Me.lblMaxInt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lFix = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMaxInt
        '
        Me.lblMaxInt.AutoSize = True
        Me.lblMaxInt.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.lblMaxInt.Font = New System.Drawing.Font("Consolas", 24.0!)
        Me.lblMaxInt.ForeColor = System.Drawing.Color.White
        Me.lblMaxInt.Location = New System.Drawing.Point(7, 4)
        Me.lblMaxInt.Name = "lblMaxInt"
        Me.lblMaxInt.Size = New System.Drawing.Size(42, 47)
        Me.lblMaxInt.TabIndex = 3
        Me.lblMaxInt.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("M+ 1p", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "お待ちください / Loading..."
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Consolas", 9.2!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(65, 33)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(180, 19)
        Me.lblDateTime.TabIndex = 5
        Me.lblDateTime.Text = "XX/XX/XXXX XX:XX:XX"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblMaxInt)
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 56)
        Me.Panel1.TabIndex = 6
        '
        'flowSmallEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "flowSmallEvent"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(418, 62)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMaxInt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lFix As Timer
End Class
