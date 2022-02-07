<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewPage))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.topEvent = New QuakeFocus_Pro.flowIntensityLbl()
        Me.FlowSmallEvent1 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent2 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent3 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent4 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent5 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent6 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent7 = New QuakeFocus_Pro.flowSmallEvent()
        Me.FlowSmallEvent9 = New QuakeFocus_Pro.flowSmallEvent()
        Me.ViewPageLocalMonitor1 = New QuakeFocus_Pro.viewPageLocalMonitor()
        Me.infoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExtendedPanel1 = New QuakeFocus_Pro.ExtendedPanel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnGlobalMap = New System.Windows.Forms.Button()
        Me.btnLocalMap = New System.Windows.Forms.Button()
        Me.btnDetailMap = New System.Windows.Forms.Button()
        Me.SfMap1 = New EGIS.Controls.SFMap()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.topDocker = New System.Windows.Forms.Panel()
        Me.EewBanner1 = New QuakeFocus_Pro.eewBanner()
        Me.FlowLightShaking1 = New QuakeFocus_Pro.flowLightShaking()
        Me.FlowNoAlertPane1 = New QuakeFocus_Pro.flowNoAlertPane()
        Me.FlowTsunami1 = New QuakeFocus_Pro.flowTsunami()
        Me.mapDocker = New System.Windows.Forms.Panel()
        Me.epiShow = New System.Windows.Forms.Label()
        Me.elpsDebug = New System.Windows.Forms.Label()
        Me.mapZoomLevel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.mapInvalidate = New System.Windows.Forms.Timer(Me.components)
        Me.localPga = New QuakeFocus_Pro.localPane()
        Me.tpTimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.detectLightShaking = New System.Windows.Forms.Timer(Me.components)
        Me.tpTotalItems = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ExtendedPanel1.SuspendLayout()
        Me.topDocker.SuspendLayout()
        Me.mapDocker.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.topEvent)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent2)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent3)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent4)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent5)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent6)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent7)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowSmallEvent9)
        Me.FlowLayoutPanel1.Controls.Add(Me.ViewPageLocalMonitor1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 154)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(425, 829)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'topEvent
        '
        Me.topEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.topEvent.Location = New System.Drawing.Point(3, 3)
        Me.topEvent.Name = "topEvent"
        Me.topEvent.Size = New System.Drawing.Size(418, 119)
        Me.topEvent.TabIndex = 0
        Me.infoToolTip.SetToolTip(Me.topEvent, "Click for more info")
        '
        'FlowSmallEvent1
        '
        Me.FlowSmallEvent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent1.Location = New System.Drawing.Point(3, 128)
        Me.FlowSmallEvent1.Name = "FlowSmallEvent1"
        Me.FlowSmallEvent1.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent1.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent1.TabIndex = 1
        '
        'FlowSmallEvent2
        '
        Me.FlowSmallEvent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent2.Location = New System.Drawing.Point(3, 196)
        Me.FlowSmallEvent2.Name = "FlowSmallEvent2"
        Me.FlowSmallEvent2.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent2.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent2.TabIndex = 2
        '
        'FlowSmallEvent3
        '
        Me.FlowSmallEvent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent3.Location = New System.Drawing.Point(3, 264)
        Me.FlowSmallEvent3.Name = "FlowSmallEvent3"
        Me.FlowSmallEvent3.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent3.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent3.TabIndex = 3
        '
        'FlowSmallEvent4
        '
        Me.FlowSmallEvent4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent4.Location = New System.Drawing.Point(3, 332)
        Me.FlowSmallEvent4.Name = "FlowSmallEvent4"
        Me.FlowSmallEvent4.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent4.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent4.TabIndex = 4
        '
        'FlowSmallEvent5
        '
        Me.FlowSmallEvent5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent5.Location = New System.Drawing.Point(3, 400)
        Me.FlowSmallEvent5.Name = "FlowSmallEvent5"
        Me.FlowSmallEvent5.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent5.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent5.TabIndex = 5
        '
        'FlowSmallEvent6
        '
        Me.FlowSmallEvent6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent6.Location = New System.Drawing.Point(3, 468)
        Me.FlowSmallEvent6.Name = "FlowSmallEvent6"
        Me.FlowSmallEvent6.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent6.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent6.TabIndex = 6
        '
        'FlowSmallEvent7
        '
        Me.FlowSmallEvent7.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent7.Location = New System.Drawing.Point(3, 536)
        Me.FlowSmallEvent7.Name = "FlowSmallEvent7"
        Me.FlowSmallEvent7.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent7.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent7.TabIndex = 7
        '
        'FlowSmallEvent9
        '
        Me.FlowSmallEvent9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.FlowSmallEvent9.Location = New System.Drawing.Point(3, 604)
        Me.FlowSmallEvent9.Name = "FlowSmallEvent9"
        Me.FlowSmallEvent9.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowSmallEvent9.Size = New System.Drawing.Size(418, 62)
        Me.FlowSmallEvent9.TabIndex = 9
        '
        'ViewPageLocalMonitor1
        '
        Me.ViewPageLocalMonitor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ViewPageLocalMonitor1.Location = New System.Drawing.Point(3, 672)
        Me.ViewPageLocalMonitor1.Name = "ViewPageLocalMonitor1"
        Me.ViewPageLocalMonitor1.Size = New System.Drawing.Size(418, 150)
        Me.ViewPageLocalMonitor1.TabIndex = 10
        '
        'ExtendedPanel1
        '
        Me.ExtendedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExtendedPanel1.Controls.Add(Me.btnHide)
        Me.ExtendedPanel1.Controls.Add(Me.btnGlobalMap)
        Me.ExtendedPanel1.Controls.Add(Me.btnLocalMap)
        Me.ExtendedPanel1.Controls.Add(Me.btnDetailMap)
        Me.ExtendedPanel1.Location = New System.Drawing.Point(15, 154)
        Me.ExtendedPanel1.Name = "ExtendedPanel1"
        Me.ExtendedPanel1.OpacitySet = 80
        Me.ExtendedPanel1.Size = New System.Drawing.Size(418, 119)
        Me.ExtendedPanel1.TabIndex = 13
        Me.infoToolTip.SetToolTip(Me.ExtendedPanel1, "Click to Close")
        Me.ExtendedPanel1.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 2
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(324, 41)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(36, 32)
        Me.btnHide.TabIndex = 17
        Me.btnHide.Text = "X"
        Me.infoToolTip.SetToolTip(Me.btnHide, "Close this Dialog")
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnGlobalMap
        '
        Me.btnGlobalMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnGlobalMap.FlatAppearance.BorderSize = 2
        Me.btnGlobalMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGlobalMap.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlobalMap.ForeColor = System.Drawing.Color.White
        Me.btnGlobalMap.Location = New System.Drawing.Point(144, 41)
        Me.btnGlobalMap.Name = "btnGlobalMap"
        Me.btnGlobalMap.Size = New System.Drawing.Size(34, 32)
        Me.btnGlobalMap.TabIndex = 14
        Me.btnGlobalMap.Text = "G"
        Me.btnGlobalMap.UseVisualStyleBackColor = False
        '
        'btnLocalMap
        '
        Me.btnLocalMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnLocalMap.FlatAppearance.BorderSize = 2
        Me.btnLocalMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalMap.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalMap.ForeColor = System.Drawing.Color.White
        Me.btnLocalMap.Location = New System.Drawing.Point(105, 41)
        Me.btnLocalMap.Name = "btnLocalMap"
        Me.btnLocalMap.Size = New System.Drawing.Size(34, 32)
        Me.btnLocalMap.TabIndex = 13
        Me.btnLocalMap.Text = "L"
        Me.btnLocalMap.UseVisualStyleBackColor = False
        '
        'btnDetailMap
        '
        Me.btnDetailMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnDetailMap.FlatAppearance.BorderSize = 2
        Me.btnDetailMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetailMap.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetailMap.ForeColor = System.Drawing.Color.White
        Me.btnDetailMap.Location = New System.Drawing.Point(65, 41)
        Me.btnDetailMap.Name = "btnDetailMap"
        Me.btnDetailMap.Size = New System.Drawing.Size(34, 32)
        Me.btnDetailMap.TabIndex = 12
        Me.btnDetailMap.Text = "D"
        Me.btnDetailMap.UseVisualStyleBackColor = False
        '
        'SfMap1
        '
        Me.SfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SfMap1.CentrePoint2D = CType(resources.GetObject("SfMap1.CentrePoint2D"), EGIS.ShapeFileLib.PointD)
        Me.SfMap1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SfMap1.DefaultMapCursor = System.Windows.Forms.Cursors.Default
        Me.SfMap1.DefaultSelectionCursor = System.Windows.Forms.Cursors.Hand
        Me.SfMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfMap1.Location = New System.Drawing.Point(0, 0)
        Me.SfMap1.MapBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SfMap1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SfMap1.Name = "SfMap1"
        Me.SfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan
        Me.SfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.[Auto]
        Me.SfMap1.Size = New System.Drawing.Size(1112, 680)
        Me.SfMap1.TabIndex = 18
        Me.SfMap1.UseMemoryStreams = False
        Me.SfMap1.UseMercatorProjection = True
        Me.SfMap1.ZoomLevel = 1.0016611295681064R
        Me.SfMap1.ZoomToSelectedExtentWhenCtrlKeydown = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(784, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'topDocker
        '
        Me.topDocker.Controls.Add(Me.EewBanner1)
        Me.topDocker.Controls.Add(Me.FlowLightShaking1)
        Me.topDocker.Controls.Add(Me.FlowNoAlertPane1)
        Me.topDocker.Controls.Add(Me.FlowTsunami1)
        Me.topDocker.Dock = System.Windows.Forms.DockStyle.Top
        Me.topDocker.Location = New System.Drawing.Point(15, 15)
        Me.topDocker.Name = "topDocker"
        Me.topDocker.Size = New System.Drawing.Size(1543, 130)
        Me.topDocker.TabIndex = 20
        '
        'EewBanner1
        '
        Me.EewBanner1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.EewBanner1.Dock = System.Windows.Forms.DockStyle.Left
        Me.EewBanner1.Location = New System.Drawing.Point(1263, 0)
        Me.EewBanner1.Name = "EewBanner1"
        Me.EewBanner1.Size = New System.Drawing.Size(2254, 130)
        Me.EewBanner1.TabIndex = 21
        Me.EewBanner1.Visible = False
        '
        'FlowLightShaking1
        '
        Me.FlowLightShaking1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLightShaking1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLightShaking1.Location = New System.Drawing.Point(842, 0)
        Me.FlowLightShaking1.Name = "FlowLightShaking1"
        Me.FlowLightShaking1.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLightShaking1.Size = New System.Drawing.Size(421, 130)
        Me.FlowLightShaking1.TabIndex = 20
        Me.FlowLightShaking1.Visible = False
        '
        'FlowNoAlertPane1
        '
        Me.FlowNoAlertPane1.BackColor = System.Drawing.Color.Gray
        Me.FlowNoAlertPane1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowNoAlertPane1.Location = New System.Drawing.Point(421, 0)
        Me.FlowNoAlertPane1.Name = "FlowNoAlertPane1"
        Me.FlowNoAlertPane1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowNoAlertPane1.Size = New System.Drawing.Size(421, 130)
        Me.FlowNoAlertPane1.TabIndex = 0
        '
        'FlowTsunami1
        '
        Me.FlowTsunami1.BackColor = System.Drawing.Color.Purple
        Me.FlowTsunami1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowTsunami1.Location = New System.Drawing.Point(0, 0)
        Me.FlowTsunami1.Name = "FlowTsunami1"
        Me.FlowTsunami1.Size = New System.Drawing.Size(421, 130)
        Me.FlowTsunami1.TabIndex = 14
        Me.FlowTsunami1.Visible = False
        '
        'mapDocker
        '
        Me.mapDocker.Controls.Add(Me.tpTotalItems)
        Me.mapDocker.Controls.Add(Me.epiShow)
        Me.mapDocker.Controls.Add(Me.elpsDebug)
        Me.mapDocker.Controls.Add(Me.mapZoomLevel)
        Me.mapDocker.Controls.Add(Me.Label1)
        Me.mapDocker.Controls.Add(Me.Button1)
        Me.mapDocker.Controls.Add(Me.SfMap1)
        Me.mapDocker.Location = New System.Drawing.Point(443, 154)
        Me.mapDocker.Name = "mapDocker"
        Me.mapDocker.Size = New System.Drawing.Size(1112, 680)
        Me.mapDocker.TabIndex = 21
        '
        'epiShow
        '
        Me.epiShow.AutoSize = True
        Me.epiShow.BackColor = System.Drawing.Color.Maroon
        Me.epiShow.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epiShow.ForeColor = System.Drawing.Color.White
        Me.epiShow.Location = New System.Drawing.Point(15, 77)
        Me.epiShow.Name = "epiShow"
        Me.epiShow.Size = New System.Drawing.Size(61, 17)
        Me.epiShow.TabIndex = 23
        Me.epiShow.Text = "ELPSSEC:"
        Me.epiShow.Visible = False
        '
        'elpsDebug
        '
        Me.elpsDebug.AutoSize = True
        Me.elpsDebug.BackColor = System.Drawing.Color.Maroon
        Me.elpsDebug.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elpsDebug.ForeColor = System.Drawing.Color.White
        Me.elpsDebug.Location = New System.Drawing.Point(15, 48)
        Me.elpsDebug.Name = "elpsDebug"
        Me.elpsDebug.Size = New System.Drawing.Size(61, 17)
        Me.elpsDebug.TabIndex = 22
        Me.elpsDebug.Text = "ELPSSEC:"
        Me.elpsDebug.Visible = False
        '
        'mapZoomLevel
        '
        Me.mapZoomLevel.AutoSize = True
        Me.mapZoomLevel.ForeColor = System.Drawing.Color.White
        Me.mapZoomLevel.Location = New System.Drawing.Point(144, 18)
        Me.mapZoomLevel.Name = "mapZoomLevel"
        Me.mapZoomLevel.Size = New System.Drawing.Size(14, 16)
        Me.mapZoomLevel.TabIndex = 21
        Me.mapZoomLevel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CURRENT ZOOM:"
        '
        'btnWebsite
        '
        Me.btnWebsite.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnWebsite.FlatAppearance.BorderSize = 2
        Me.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebsite.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWebsite.ForeColor = System.Drawing.Color.White
        Me.btnWebsite.Image = CType(resources.GetObject("btnWebsite.Image"), System.Drawing.Image)
        Me.btnWebsite.Location = New System.Drawing.Point(284, 41)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(34, 32)
        Me.btnWebsite.TabIndex = 16
        Me.btnWebsite.UseVisualStyleBackColor = False
        '
        'btnReplay
        '
        Me.btnReplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnReplay.FlatAppearance.BorderSize = 2
        Me.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplay.ForeColor = System.Drawing.Color.White
        Me.btnReplay.Image = Global.QuakeFocus_Pro.My.Resources.Resources.replay
        Me.btnReplay.Location = New System.Drawing.Point(244, 41)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(34, 32)
        Me.btnReplay.TabIndex = 15
        Me.btnReplay.UseVisualStyleBackColor = False
        '
        'mapInvalidate
        '
        '
        'localPga
        '
        Me.localPga.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.localPga.Location = New System.Drawing.Point(1182, 738)
        Me.localPga.Name = "localPga"
        Me.localPga.Size = New System.Drawing.Size(335, 80)
        Me.localPga.TabIndex = 16
        '
        'tpTimeOut
        '
        Me.tpTimeOut.Interval = 1000
        '
        'detectLightShaking
        '
        Me.detectLightShaking.Interval = 1000
        '
        'tpTotalItems
        '
        Me.tpTotalItems.AutoSize = True
        Me.tpTotalItems.BackColor = System.Drawing.Color.Orange
        Me.tpTotalItems.Location = New System.Drawing.Point(18, 115)
        Me.tpTotalItems.Name = "tpTotalItems"
        Me.tpTotalItems.Size = New System.Drawing.Size(98, 16)
        Me.tpTotalItems.TabIndex = 24
        Me.tpTotalItems.Text = "TOTAL ITEMS:"
        '
        'viewPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1573, 1001)
        Me.Controls.Add(Me.localPga)
        Me.Controls.Add(Me.mapDocker)
        Me.Controls.Add(Me.topDocker)
        Me.Controls.Add(Me.ExtendedPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "viewPage"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "QuakeFocus Pro || INDEV BETA-BETA V1.5"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ExtendedPanel1.ResumeLayout(False)
        Me.topDocker.ResumeLayout(False)
        Me.mapDocker.ResumeLayout(False)
        Me.mapDocker.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents topEvent As flowIntensityLbl
    Friend WithEvents FlowSmallEvent1 As flowSmallEvent
    Friend WithEvents FlowSmallEvent2 As flowSmallEvent
    Friend WithEvents FlowSmallEvent3 As flowSmallEvent
    Friend WithEvents FlowSmallEvent4 As flowSmallEvent
    Friend WithEvents FlowSmallEvent5 As flowSmallEvent
    Friend WithEvents FlowSmallEvent6 As flowSmallEvent
    Friend WithEvents FlowSmallEvent7 As flowSmallEvent
    Friend WithEvents FlowNoAlertPane1 As flowNoAlertPane
    Friend WithEvents ExtendedPanel1 As ExtendedPanel
    Friend WithEvents btnWebsite As Button
    Friend WithEvents btnReplay As Button
    Friend WithEvents btnGlobalMap As Button
    Friend WithEvents btnLocalMap As Button
    Friend WithEvents btnDetailMap As Button
    Friend WithEvents infoToolTip As ToolTip
    Friend WithEvents btnHide As Button
    Friend WithEvents FlowTsunami1 As flowTsunami
    Friend WithEvents FlowSmallEvent9 As flowSmallEvent
    Friend WithEvents localPga As localPane
    Friend WithEvents SfMap1 As EGIS.Controls.SFMap
    Friend WithEvents Button1 As Button
    Friend WithEvents topDocker As Panel
    Friend WithEvents mapDocker As Panel
    Friend WithEvents FlowLightShaking1 As flowLightShaking
    Friend WithEvents EewBanner1 As eewBanner
    Friend WithEvents mapZoomLevel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ViewPageLocalMonitor1 As viewPageLocalMonitor
    Friend WithEvents elpsDebug As Label
    Friend WithEvents mapInvalidate As Timer
    Friend WithEvents epiShow As Label
    Friend WithEvents tpTimeOut As Timer
    Friend WithEvents detectLightShaking As Timer
    Friend WithEvents tpTotalItems As Label
End Class
