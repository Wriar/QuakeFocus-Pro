<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class flowIntensityLbl
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
        Me.Pb1 = New System.Windows.Forms.Panel()
        Me.pIntensity = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMaxInt = New System.Windows.Forms.Label()
        Me.lblEpicenter = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblMag = New System.Windows.Forms.Label()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.infoTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pb1.SuspendLayout()
        Me.pIntensity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pb1
        '
        Me.Pb1.BackColor = System.Drawing.Color.White
        Me.Pb1.Controls.Add(Me.pIntensity)
        Me.Pb1.Location = New System.Drawing.Point(4, 6)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Padding = New System.Windows.Forms.Padding(2)
        Me.Pb1.Size = New System.Drawing.Size(103, 100)
        Me.Pb1.TabIndex = 1
        '
        'pIntensity
        '
        Me.pIntensity.BackColor = System.Drawing.Color.Gray
        Me.pIntensity.Controls.Add(Me.Label1)
        Me.pIntensity.Controls.Add(Me.lblMaxInt)
        Me.pIntensity.Location = New System.Drawing.Point(2, 2)
        Me.pIntensity.Name = "pIntensity"
        Me.pIntensity.Size = New System.Drawing.Size(99, 96)
        Me.pIntensity.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Max. Int"
        '
        'lblMaxInt
        '
        Me.lblMaxInt.AutoSize = True
        Me.lblMaxInt.Font = New System.Drawing.Font("M+ 1p", 36.0!)
        Me.lblMaxInt.ForeColor = System.Drawing.Color.White
        Me.lblMaxInt.Location = New System.Drawing.Point(-3, 7)
        Me.lblMaxInt.Name = "lblMaxInt"
        Me.lblMaxInt.Size = New System.Drawing.Size(89, 83)
        Me.lblMaxInt.TabIndex = 2
        Me.lblMaxInt.Text = " 0"
        '
        'lblEpicenter
        '
        Me.lblEpicenter.AutoSize = True
        Me.lblEpicenter.Font = New System.Drawing.Font("M+ 1p", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpicenter.ForeColor = System.Drawing.Color.White
        Me.lblEpicenter.Location = New System.Drawing.Point(112, 8)
        Me.lblEpicenter.Name = "lblEpicenter"
        Me.lblEpicenter.Size = New System.Drawing.Size(266, 28)
        Me.lblEpicenter.TabIndex = 3
        Me.lblEpicenter.Text = "お待ちください / Loading..."
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Consolas", 9.2!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(113, 35)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(180, 19)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Text = "XX/XX/XXXX XX:XX:XX"
        '
        'lblMag
        '
        Me.lblMag.AutoSize = True
        Me.lblMag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMag.ForeColor = System.Drawing.Color.White
        Me.lblMag.Location = New System.Drawing.Point(113, 72)
        Me.lblMag.Name = "lblMag"
        Me.lblMag.Size = New System.Drawing.Size(67, 23)
        Me.lblMag.TabIndex = 5
        Me.lblMag.Text = "M: 0.0"
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepth.ForeColor = System.Drawing.Color.White
        Me.lblDepth.Location = New System.Drawing.Point(186, 72)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(94, 23)
        Me.lblDepth.TabIndex = 6
        Me.lblDepth.Text = "D: 00 KM"
        '
        'flowIntensityLbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblDepth)
        Me.Controls.Add(Me.lblMag)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblEpicenter)
        Me.Controls.Add(Me.Pb1)
        Me.Name = "flowIntensityLbl"
        Me.Size = New System.Drawing.Size(418, 115)
        Me.Pb1.ResumeLayout(False)
        Me.pIntensity.ResumeLayout(False)
        Me.pIntensity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pb1 As Panel
    Friend WithEvents pIntensity As Panel
    Friend WithEvents lblMaxInt As Label
    Friend WithEvents lblEpicenter As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblMag As Label
    Friend WithEvents lblDepth As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents infoTip As ToolTip
End Class
