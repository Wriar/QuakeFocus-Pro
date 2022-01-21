<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apiTimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apiTimer))
        Me.xmlFetchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.imageImportTimer = New System.Windows.Forms.Timer(Me.components)
        Me.localPGAIdentifier = New System.Windows.Forms.Timer(Me.components)
        Me.jsonImporter = New System.Windows.Forms.Timer(Me.components)
        Me.pushJson = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.viewPageFlowAdjust = New System.Windows.Forms.Timer(Me.components)
        Me.circlePlotter = New System.Windows.Forms.Timer(Me.components)
        Me.niedPointImporter = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.localNIEDAvg = New System.Windows.Forms.Timer(Me.components)
        Me.prefAvg = New System.Windows.Forms.Timer(Me.components)
        Me.alertTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cxCounter = New System.Windows.Forms.Label()
        Me.workingPrefAvg = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pgaImg = New System.Windows.Forms.PictureBox()
        Me.pcImg = New System.Windows.Forms.PictureBox()
        Me.PStimeCalculator = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.eewGraphicDrawer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pgaImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xmlFetchTimer
        '
        Me.xmlFetchTimer.Interval = 5000
        '
        'imageImportTimer
        '
        Me.imageImportTimer.Interval = 1000
        '
        'localPGAIdentifier
        '
        Me.localPGAIdentifier.Interval = 1000
        '
        'jsonImporter
        '
        Me.jsonImporter.Interval = 1000
        '
        'pushJson
        '
        Me.pushJson.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(126, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(126, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(126, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(126, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Label15"
        '
        'viewPageFlowAdjust
        '
        Me.viewPageFlowAdjust.Interval = 10
        '
        'circlePlotter
        '
        '
        'niedPointImporter
        '
        Me.niedPointImporter.Interval = 1000
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(326, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 86)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'localNIEDAvg
        '
        Me.localNIEDAvg.Interval = 1000
        '
        'prefAvg
        '
        Me.prefAvg.Interval = 1000
        '
        'alertTimeout
        '
        Me.alertTimeout.Interval = 1000
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(581, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(581, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "1"
        '
        'cxCounter
        '
        Me.cxCounter.AutoSize = True
        Me.cxCounter.Location = New System.Drawing.Point(245, 90)
        Me.cxCounter.Name = "cxCounter"
        Me.cxCounter.Size = New System.Drawing.Size(14, 16)
        Me.cxCounter.TabIndex = 19
        Me.cxCounter.Text = "1"
        '
        'workingPrefAvg
        '
        Me.workingPrefAvg.Interval = 1000
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(473, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 86)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Show Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(365, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pgaImg
        '
        Me.pgaImg.Image = CType(resources.GetObject("pgaImg.Image"), System.Drawing.Image)
        Me.pgaImg.Location = New System.Drawing.Point(129, 12)
        Me.pgaImg.Name = "pgaImg"
        Me.pgaImg.Size = New System.Drawing.Size(304, 40)
        Me.pgaImg.TabIndex = 1
        Me.pgaImg.TabStop = False
        '
        'pcImg
        '
        Me.pcImg.Image = Global.QuakeFocus_Pro.My.Resources.Resources.hi_demo
        Me.pcImg.Location = New System.Drawing.Point(12, 12)
        Me.pcImg.Name = "pcImg"
        Me.pcImg.Size = New System.Drawing.Size(100, 50)
        Me.pcImg.TabIndex = 0
        Me.pcImg.TabStop = False
        '
        'PStimeCalculator
        '
        Me.PStimeCalculator.Interval = 1000
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(313, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(186, 84)
        Me.ListBox1.TabIndex = 22
        '
        'apiTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 431)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cxCounter)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgaImg)
        Me.Controls.Add(Me.pcImg)
        Me.Name = "apiTimer"
        Me.Opacity = 0.8R
        Me.Text = "apiTimer"
        CType(Me.pgaImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xmlFetchTimer As Timer
    Friend WithEvents imageImportTimer As Timer
    Friend WithEvents localPGAIdentifier As Timer
    Friend WithEvents pcImg As PictureBox
    Friend WithEvents pgaImg As PictureBox
    Friend WithEvents jsonImporter As Timer
    Friend WithEvents pushJson As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents viewPageFlowAdjust As Timer
    Friend WithEvents circlePlotter As Timer
    Friend WithEvents niedPointImporter As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents localNIEDAvg As Timer
    Friend WithEvents prefAvg As Timer
    Friend WithEvents alertTimeout As Timer
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cxCounter As Label
    Friend WithEvents workingPrefAvg As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PStimeCalculator As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents eewGraphicDrawer As Timer
End Class
