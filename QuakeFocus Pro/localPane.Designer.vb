<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class localPane
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(localPane))
        Me.pgaColorGradient = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pgaLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.intGradientColor = New System.Windows.Forms.Panel()
        Me.intLbl = New System.Windows.Forms.Label()
        Me.settingsBTN = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.intGradientColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgaColorGradient
        '
        Me.pgaColorGradient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pgaColorGradient.Location = New System.Drawing.Point(29, 55)
        Me.pgaColorGradient.Name = "pgaColorGradient"
        Me.pgaColorGradient.Size = New System.Drawing.Size(160, 10)
        Me.pgaColorGradient.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.pgaLbl)
        Me.Panel2.Location = New System.Drawing.Point(119, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 43)
        Me.Panel2.TabIndex = 1
        '
        'pgaLbl
        '
        Me.pgaLbl.AutoSize = True
        Me.pgaLbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgaLbl.ForeColor = System.Drawing.Color.White
        Me.pgaLbl.Location = New System.Drawing.Point(3, 9)
        Me.pgaLbl.Name = "pgaLbl"
        Me.pgaLbl.Size = New System.Drawing.Size(65, 23)
        Me.pgaLbl.TabIndex = 3
        Me.pgaLbl.Text = "0.001"
        Me.pgaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gen Shin Gothic P Regular", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Local" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PGA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gen Shin Gothic P Regular", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(213, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Local" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Int:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'intGradientColor
        '
        Me.intGradientColor.BackColor = System.Drawing.Color.Gray
        Me.intGradientColor.Controls.Add(Me.intLbl)
        Me.intGradientColor.Location = New System.Drawing.Point(266, 13)
        Me.intGradientColor.Name = "intGradientColor"
        Me.intGradientColor.Size = New System.Drawing.Size(70, 52)
        Me.intGradientColor.TabIndex = 4
        '
        'intLbl
        '
        Me.intLbl.AutoSize = True
        Me.intLbl.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.intLbl.ForeColor = System.Drawing.Color.White
        Me.intLbl.Location = New System.Drawing.Point(1, 11)
        Me.intLbl.Name = "intLbl"
        Me.intLbl.Size = New System.Drawing.Size(69, 29)
        Me.intLbl.TabIndex = 4
        Me.intLbl.Text = "-3.0"
        Me.intLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'settingsBTN
        '
        Me.settingsBTN.BackColor = System.Drawing.Color.Transparent
        Me.settingsBTN.FlatAppearance.BorderSize = 0
        Me.settingsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBTN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBTN.ForeColor = System.Drawing.Color.White
        Me.settingsBTN.Image = CType(resources.GetObject("settingsBTN.Image"), System.Drawing.Image)
        Me.settingsBTN.Location = New System.Drawing.Point(2, 7)
        Me.settingsBTN.Name = "settingsBTN"
        Me.settingsBTN.Size = New System.Drawing.Size(30, 23)
        Me.settingsBTN.TabIndex = 23
        Me.settingsBTN.UseVisualStyleBackColor = False
        '
        'localPane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Controls.Add(Me.settingsBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.intGradientColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pgaColorGradient)
        Me.Name = "localPane"
        Me.Size = New System.Drawing.Size(352, 80)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.intGradientColor.ResumeLayout(False)
        Me.intGradientColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgaColorGradient As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pgaLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents intGradientColor As Panel
    Friend WithEvents intLbl As Label
    Friend WithEvents settingsBTN As Button
End Class
