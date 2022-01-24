<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flowTsunami
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TsCoastLine3 = New QuakeFocus_Pro.tsCoastLine()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TsCoastLine2 = New QuakeFocus_Pro.tsCoastLine()
        Me.TsCoastLine1 = New QuakeFocus_Pro.tsCoastLine()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TsCoastLine3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TsCoastLine2)
        Me.Panel1.Controls.Add(Me.TsCoastLine1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(415, 87)
        Me.Panel1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Panel1, "Click Here to View more Information Online")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(126, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Severe Tsunami Warning"
        '
        'TsCoastLine3
        '
        Me.TsCoastLine3.BackColor = System.Drawing.Color.Purple
        Me.TsCoastLine3.Location = New System.Drawing.Point(26, 61)
        Me.TsCoastLine3.Name = "TsCoastLine3"
        Me.TsCoastLine3.Size = New System.Drawing.Size(82, 10)
        Me.TsCoastLine3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(126, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tsunami Warning"
        '
        'TsCoastLine2
        '
        Me.TsCoastLine2.BackColor = System.Drawing.Color.Red
        Me.TsCoastLine2.Location = New System.Drawing.Point(26, 40)
        Me.TsCoastLine2.Name = "TsCoastLine2"
        Me.TsCoastLine2.Size = New System.Drawing.Size(82, 10)
        Me.TsCoastLine2.TabIndex = 2
        '
        'TsCoastLine1
        '
        Me.TsCoastLine1.BackColor = System.Drawing.Color.Yellow
        Me.TsCoastLine1.Location = New System.Drawing.Point(26, 17)
        Me.TsCoastLine1.Name = "TsCoastLine1"
        Me.TsCoastLine1.Size = New System.Drawing.Size(82, 10)
        Me.TsCoastLine1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(126, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tsunami Advisory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A Tsunami Warning has been Issued"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "More Information"
        '
        'flowTsunami
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "flowTsunami"
        Me.Size = New System.Drawing.Size(421, 124)
        Me.ToolTip1.SetToolTip(Me, "Click Here to View more Information Online")
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TsCoastLine3 As tsCoastLine
    Friend WithEvents Label3 As Label
    Friend WithEvents TsCoastLine2 As tsCoastLine
    Friend WithEvents TsCoastLine1 As tsCoastLine
    Friend WithEvents ToolTip1 As ToolTip
End Class
