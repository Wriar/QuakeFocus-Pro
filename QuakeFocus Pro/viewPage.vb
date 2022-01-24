'ViewPage Settings Here
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports EGIS.Projections
Imports EGIS.ShapeFileLib
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Svg

Public Class viewPage
    Private image As System.Drawing.Imaging.Metafile




    Function MakeNewImage(ByVal i1 As Bitmap, ByVal i2 As Bitmap) As Bitmap
        Dim g As Graphics = Graphics.FromImage(i1)
        g.DrawImage(i2, New Point(0, 0))
        Return i1
    End Function
    Private Function DistanceBetweenPoints2(ByVal p0 As PointD, ByVal p1 As PointD) As Double
        Dim distance As Double = Double.NaN

        If (TryCast(Me.SfMap1.MapCoordinateReferenceSystem, IGeographicCRS)) IsNot Nothing Then
            distance = EGIS.ShapeFileLib.ConversionFunctions.DistanceBetweenLatLongPointsHaversine(ConversionFunctions.Wgs84RefEllipse, p0.Y, p0.X, p1.Y, p1.X)
        ElseIf (TryCast(Me.SfMap1.MapCoordinateReferenceSystem, IProjectedCRS)) IsNot Nothing Then
            distance = Math.Sqrt((p1.X - p0.X) * (p1.X - p0.X) + (p1.Y - p0.Y) * (p1.Y - p0.Y))
        End If

        Return distance


    End Function
    Private pfc As PrivateFontCollection
    Private Function DistanceBetweenPoints(ByVal p0 As PointD, ByVal p1 As PointD) As Double
        Dim distance As Double = Double.NaN

        If (TryCast(Me.SfMap1.MapCoordinateReferenceSystem, IGeographicCRS)) IsNot Nothing Then
            distance = EGIS.ShapeFileLib.ConversionFunctions.DistanceBetweenLatLongPointsHaversine(ConversionFunctions.Wgs84RefEllipse, p0.Y, p0.X, p1.Y, p1.X)
        ElseIf (TryCast(Me.SfMap1.MapCoordinateReferenceSystem, IProjectedCRS)) IsNot Nothing Then
            distance = Math.Sqrt((p1.X - p0.X) * (p1.X - p0.X) + (p1.Y - p0.Y) * (p1.Y - p0.Y))
        End If

        Return distance
    End Function
    Private Sub viewPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Font Localization"
        'Apply FontFix

        ' Dim pfc As New PrivateFontCollection()
        pfc = New PrivateFontCollection()

        Dim fontCollectionBaseDIR As String = Application.StartupPath & "\assets\fonts\"
        Console.WriteLine(fontCollectionBaseDIR & "mplus-1p-regular.ttf")

        pfc.AddFontFile(fontCollectionBaseDIR & "mplus-1p-bold.ttf")
        FlowNoAlertPane1.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Bold)

        '   topEvent.lblEpicenter.Font = New Font(pfc.Families(0), 12, FontStyle.Bold)
        FlowSmallEvent1.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent2.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent3.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent4.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent5.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent6.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent7.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
        FlowSmallEvent9.Label1.Font = New Font(pfc.Families(0), 10.8, FontStyle.Regular)
#End Region
        My.Settings.rewindTime = 0
        My.Settings.serverDelay = 0
        mapInvalidate.Start()

#Region "First Run"
        '   If My.Settings.prefixLang = "nothing" Then
        'Prompt User

        ' Dim promptDialog As New TaskDialog
        '   promptDialog.Caption = "言語 / Language"
        '  promptDialog.InstructionText = "言語設定 / Set Language"
        '   promptDialog.FooterText = "これらの設定は、「設定」ページでいつでも変更することができます。
        ' These settings may be changed at any time in the ""settings"" window."
        '  Dim cmd_setEN As TaskDialogCommandLink = New TaskDialogCommandLink("buttonEnglish", "English / 英語")
        '  Dim cmd_setJP As TaskDialogCommandLink = New TaskDialogCommandLink("buttonJapanese", "Japanese / 日本語")
        '  promptDialog.Icon = TaskDialogStandardIcon.Information

        '  promptDialog.Controls.Add(cmd_setEN)
        '  promptDialog.Controls.Add(cmd_setJP)
        '    Dim tskRes As Integer = promptDialog.Show()

        '  MsgBox(tskRes)
        '

        Dim customMsgbox = New updateAvailable("アプリケーションの言語を日本語にする場合は、「はい」を選択します。
アプリケーションの言語を英語にするには、「no」を選択します。
To set the default application language to Japanese, click YES. 
To set the default application language to English, click NO.")
        If customMsgbox.ShowDialog() = DialogResult.Yes Then
            ' do something
            My.Settings.prefixLang = "jp"
            My.Settings.soundLang = "jp" 'Sound Language

            MessageBox.Show("Indev V0.15ビルドをご利用いただきありがとうございます。アプリケーションを開いた後、毎回、言語設定のプロンプトが表示されます。
Thank you for using the Japan Translation of Indev V0.15. You can reset the language by restarting the application", "インフォメーション", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            'TEMP SET OTHER elEMEnts, FUTURE METHOD WILL BE IMPLEMENTED LATER

            FlowNoAlertPane1.Label1.Text = "緊急地震速報は発表されていません。"
            ViewPageLocalMonitor1.Label1.Text = "東京、日本"
        Else
            ' do nothing (its DialogResult.no)
            My.Settings.prefixLang = "en"
            My.Settings.soundLang = "en"
            MessageBox.Show("The application language has been set to ENGLISH. To change the language, restart the application (does not have to be redownloaded)
Indev V0.2ビルドをご利用いただきありがとうございます。アプリケーションを開いた後、毎回、言語設定のプロンプトが表示されます。", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        '  Else
        '  MsgBox("SET TO: " & My.Settings.prefixLang)
        ' End If
        Dim lfr = New localPane()
        lfr.requestLocalizeRefresh()


#End Region
        loadShapeFile()
        ConstructSVG()
        apiTimer.xmlFetchTimer.Start()
        apiTimer.pushJson.Start()
        topEvent.infoTip.SetToolTip(Me.btnDetailMap, "Open the NHK Detailed Map Viewer/Downloader.")
        topEvent.infoTip.SetToolTip(Me.btnLocalMap, "Open the NHK Local Map Viewer/Downloader")
        topEvent.infoTip.SetToolTip(Me.btnGlobalMap, "Open the NHK Global Map Viewer/Downloader")
        topEvent.infoTip.SetToolTip(Me.btnReplay, "Start/Stop a Replay for this Event." & vbCrLf & vbCrLf & "Realtime Replays can be viewed up to 3 hours." & vbCrLf & "API Replays can be viewed up to 6 months.")
        topEvent.infoTip.SetToolTip(Me.btnWebsite, "View more detailed information on NHK's website.")


        XMLViewParse.importIntolist()

        apiTimer.imageImportTimer.Start()
        apiTimer.localPGAIdentifier.Start()
        apiTimer.jsonImporter.Start()
        apiTimer.viewPageFlowAdjust.Start()

        'Fix Custom Colors on ColorBar

        isdDialog.Show()

        ' MsgBox(extrapolate(34.052235, -118.243683, 0, 100))
        '  MsgBox("")
    End Sub



    Private Sub outputMapView_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub outputMapView_Paint(sender As Object, e As PaintEventArgs)
        ' e.Graphics.DrawImage(image, New Rectangle(Point.Empty, sz))
        '  Dim metafile As New Metafile("SampleMetafile.emf")
        '  e.Graphics.DrawImage(metafile, 60, 10)
    End Sub

    ' Private Sub outputMapView_MouseDown(sender As Object, e As MouseEventArgs)
    '     StartPoint = outputMapView.PointToScreen(New Point(e.X, e.Y))
    '     IsDragging = True
    ' End Sub

    ' Private Sub outputMapView_MouseMove(sender As Object, e As MouseEventArgs)
    '    If IsDragging Then
    '        Dim EndPoint As Point = outputMapView.PointToScreen(New Point(e.X, e.Y))
    '   outputMapView.Left += (EndPoint.X - StartPoint.X)
    '       outputMapView.Top += (EndPoint.Y - StartPoint.Y)
    '       StartPoint = EndPoint
    'End If
    'End Sub

    Private Sub outputMapView_MouseUp(sender As Object, e As MouseEventArgs)
        IsDragging = False
    End Sub

    Private IsDragging As Boolean = False
    Private StartPoint As Point


    Private Sub MapViewFrame1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub MapViewFrame1_Paint(sender As Object, e As PaintEventArgs)
        '  e.Graphics.DrawEllipse(New Pen(Color.Red, 2.0F), 50, 50, MapViewFrame1.Size.Width - 100, MapViewFrame1.Size.Height - 100)
    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub topEvent_Load(sender As Object, e As EventArgs) Handles topEvent.Load

    End Sub



    Private Sub topEvent_MouseLeave(sender As Object, e As EventArgs) Handles topEvent.MouseLeave


    End Sub

    Private Sub topEvent_Click(sender As Object, e As EventArgs) Handles topEvent.Click
        showExtendedPanel()


    End Sub

    Private Sub ExtendedPanel1_Click(sender As Object, e As EventArgs) Handles ExtendedPanel1.Click
        hideExtendedPanel()
    End Sub

    Private Sub ExtendedPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub showExtendedPanel()
        ExtendedPanel1.Visible = True
        topEvent.lblDateTime.Visible = False
        topEvent.lblDepth.Visible = False
        topEvent.lblEpicenter.Visible = False
        topEvent.lblMag.Visible = False
        topEvent.lblMaxInt.Visible = False
        topEvent.pIntensity.Visible = False
        topEvent.Pb1.Visible = False
    End Sub
    Private Sub hideExtendedPanel()
        ExtendedPanel1.Visible = False
        topEvent.lblDateTime.Visible = True
        topEvent.lblDepth.Visible = True
        topEvent.lblEpicenter.Visible = True
        topEvent.lblMag.Visible = True
        topEvent.lblMaxInt.Visible = True
        topEvent.pIntensity.Visible = True
        topEvent.Pb1.Visible = True
    End Sub

    Private Sub ExtendedPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles ExtendedPanel1.Paint

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        hideExtendedPanel()
    End Sub

    Private Sub btnDetailMap_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDetailMap_Click_1(sender As Object, e As EventArgs) Handles btnDetailMap.Click
        nhkDownloader.loadIMG("d", True)
    End Sub

    Private Sub btnLocalMap_Click(sender As Object, e As EventArgs) Handles btnLocalMap.Click
        nhkDownloader.loadIMG("l", True)
    End Sub

    Private Sub btnGlobalMap_Click(sender As Object, e As EventArgs) Handles btnGlobalMap.Click
        nhkDownloader.loadIMG("g", True)
    End Sub

    Private Sub localPga_Load(sender As Object, e As EventArgs) Handles localPga.Load
        apiTimer.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(apiTimer.eh)
        'Test coords: 35.65860085964554, 139.7454446749598
        Dim k As New geolocatePoint.GeoLocation

        k.Latitude = 35.658600859645539
        k.Longitude = 139.7454446749598

        Dim r As geolocatePoint.GeoLocation = geolocatePoint.FindPointAtDistanceFrom(k, 90, 3)
        MsgBox(r.Longitude & vbCrLf & r.Latitude)

        MsgBox(geolocatePoint.pixelPointFromDistance(k, 2))
        Console.WriteLine("LONG LAT:: " & r.Longitude & "  " & r.Latitude)
    End Sub
    Private shapeFileAdded As Boolean = False

    Private Sub loadShapeFile()
        If shapeFileAdded = False Then
            Dim colors As Dictionary(Of String, Color) = New Dictionary(Of String, Color)()
            Dim shapeFilePath As String = Application.StartupPath & "\assets\gisdata\Pop_density.shp"
            SfMap1.AddShapeFile(shapeFilePath, "ShapeFile", "")
            SfMap1(0).RenderSettings.FillColor = Color.FromArgb(42, 44, 47)
            SfMap1(0).RenderSettings.LineDashStyle = Drawing2D.DashStyle.Solid
            SfMap1(0).RenderSettings.MaxZoomLevel = 10000000
            SfMap1(0).RenderSettings.OutlineColor = Color.DimGray
            SfMap1(0).RenderSettings.MinZoomLevel = 1
            shapeFileAdded = True
        Else

        End If

    End Sub



    Private Sub SfMap1_Load(sender As Object, e As EventArgs) Handles SfMap1.Load

    End Sub
    Public Function drawMarkers(ByVal e As PaintEventArgs)

        For Each str As Tuple(Of String, String, Point, String, String, String, Tuple(Of String, String)) In apiTimer.initialLocationDB
            'Get Color of Point


            Dim realtimeTemp As Bitmap = apiTimer.pcImg.Image
            Dim realtimeColor As Color = realtimeTemp.GetPixel(str.Item3.X, str.Item3.Y)
            Dim realtimeInterpolated As String = colorProcessing.ProcessColor(realtimeColor, "jma", False, False)


            Dim pt As Point = Me.SfMap1.GisPointToPixelCoord(str.Item4, str.Item5)
            '  Console.WriteLine(pt)
            DrawMarker(e.Graphics, pt.X, pt.Y, "realtime", Color.FromArgb(255, 0, 0), Color.FromArgb(255, 0, 0), realtimeColor, realtimeInterpolated)







            'Draw Text @ zoom lvl 3000

            If SfMap1.ZoomLevel > 3000 Then
                'Draw Region Name
                Dim areaName As String
                If My.Settings.prefixLang = "jp" Then
                    areaName = str.Item1
                Else
                    areaName = str.Item6
                End If

                Dim textFont As New Font("Arial", 10)
                Dim drawBrush As New SolidBrush(Color.White)

                Dim drawAreaX As Integer = pt.X + 10
                Dim drawAreaY As Integer = pt.Y - 5

                e.Graphics.DrawString(areaName, textFont, drawBrush, drawAreaX, drawAreaY)

                'Draw INT Level

                Dim intLevel As String = Truncate(realtimeInterpolated, 5)
                Dim textFont2 As New Font("Segoe UI Semibold", 8)
                Dim drawBrush2 As New SolidBrush(Color.White)

                Dim drawAreaX2 As Integer = pt.X + 10
                Dim drawAreaY2 As Integer = pt.Y + 13

                e.Graphics.DrawString("INT: " & intLevel, textFont2, drawBrush2, drawAreaX2, drawAreaY2)


            End If

        Next
        '    drawCircle(e.Graphics, SfMap1.GisPointToPixelCoord(139.839478, 35.652832).X, SfMap1.GisPointToPixelCoord(139.839478, 35.652832).Y, 1)
        '  SfMap1.Refresh()
        Dim pt2 As Point = Me.SfMap1.GisPointToPixelCoord(DataStructureRaw.longitude, DataStructureRaw.latitude)

        drawCircle(e.Graphics, e, pt2.X, pt2.Y, 1)

        If showEpicenter = True Then
            drawEpicenter(e, e.Graphics, pt2.X, pt2.Y, "epicenter")
        End If

        apiTimer.txtLong.Text = DataStructureRaw.longitude
        apiTimer.txtLat.Text = DataStructureRaw.latitude


    End Function

    Public Shared Function Truncate(ByVal value As String, ByVal maxLength As Integer) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
    End Function
    Dim rectH As Integer = 3
    Dim rectW As Integer = 3

    Public epicenterPointer As Integer = 0
    Public showEpicenter As Boolean = True

    Private Sub mapInvalidate_Tick(sender As Object, e As EventArgs) Handles mapInvalidate.Tick
        SfMap1.Invalidate()

        epicenterPointer += 1

        If epicenterPointer < 20 Then
            '     epicenterPointer = 0
            showEpicenter = True
            epiShow.Text = "True " & epicenterPointer
        ElseIf epicenterPointer > 20 And epicenterPointer < 30 Then
            showEpicenter = False
            epiShow.Text = "False " & epicenterPointer
        ElseIf epicenterPointer > 30 Then
            epicenterPointer = 0

        End If
    End Sub

    Private Sub SfMap1_Paint(sender As Object, e As PaintEventArgs) Handles SfMap1.Paint

        'Refresh timer runs on 10 ms, 10x per second





        drawMarkers(e)

        ' DrawMarker(e.Graphics, 127.679153, 26.212313, "realtime", Color.FromArgb(255, 0, 0), Color.FromArgb(255, 0, 0), Color.FromArgb(255, 0, 0), "1")

        If SfMap1.ZoomLevel > 800 Then
            rectH = 17
            rectW = 17
        ElseIf SfMap1.ZoomLevel > 200 And SfMap1.ZoomLevel < 800 Then
            rectH = 10
            rectW = 10
        Else
            rectH = 7
            rectW = 7
        End If

        mapZoomLevel.Text = SfMap1.ZoomLevel

        'Fix Zooming Max: 860,000 Min: 1

        'FIX Zoom Issue L322-B-301

        If SfMap1.ZoomLevel < 1 Then 'Reported that map can be zoomed out into infinity
            SfMap1.ZoomLevel = 1
        End If
        If SfMap1.ZoomLevel > 200000 Then 'Reported that map can be zoomed into infinity
            SfMap1.ZoomLevel = 190000
        End If

        drawHome(e, e.Graphics, SfMap1.GisPointToPixelCoord(My.Settings.usrLong, My.Settings.usrLat).X, SfMap1.GisPointToPixelCoord(My.Settings.usrLong, My.Settings.usrLat).Y)
        'Demo Demo P/S Circle



    End Sub

    ''' <summary>
    ''' Dray an Epicenter Icon
    ''' </summary>
    ''' <param name="e">Paint Event Arguments</param>
    ''' <param name="g">Graphics Object</param>
    ''' <param name="locX">Pixel Epicenter X</param>
    ''' <param name="locY">Pixel Epicenter Y</param>
    ''' <param name="epiType">Type to Draw: epicenter,</param>
    ''' <param name="evCode">In event of multiple EEW, alert number</param>
    Public Sub drawEpicenter(ByVal e As PaintEventArgs, ByVal g As Graphics, locX As String, locY As String, epiType As String, Optional evCode As Integer = 0)
        If locX IsNot Nothing And locY IsNot Nothing And locX <> 0 And locY <> 0 And locX > 0 And locY > 0 Then
            Dim epImg As Image = My.Resources.epicenter

            Dim resourceHeight As Integer = epImg.Height / 2
            Dim resourceWidth = epImg.Width / 2

            Dim topLeftX As Integer = locX - resourceWidth / 2 'Scale Factor
            Dim topLeftY As Integer = locY - resourceHeight / 2

            Dim np As New PointF(topLeftX, topLeftY)

            Dim epResize As Image = ResizeImage(epImg)
            '  Dim ptD As New PointF(locX, locY)

            g.DrawImage(epResize, np)
        End If

    End Sub


    Public Sub drawHome(ByVal e As PaintEventArgs, ByVal g As Graphics, locX As String, locY As String)
        If locX IsNot Nothing And locY IsNot Nothing And locX <> 0 And locY <> 0 And locX > 0 And locY > 0 Then
            Dim epImg As Image = My.Resources.homeico

            Dim resourceHeight As Integer = epImg.Height / 2
            Dim resourceWidth = epImg.Width / 2

            Dim topLeftX As Integer = locX - resourceWidth / 2 'Scale Factor
            Dim topLeftY As Integer = locY - resourceHeight / 2

            Dim np As New PointF(topLeftX, topLeftY)

            Dim epResize As Image = ResizeImageHome(epImg)
            '  Dim ptD As New PointF(locX, locY)

            g.DrawImage(epResize, np)
        End If

    End Sub

    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(32, 32))
    End Function

    Public Shared Function ResizeImageHome(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(25, 25))
    End Function

    Public Shared Sub DrawOutlineCircle(ByVal g As Graphics, ByVal pen As Pen, ByVal centerX As Single, ByVal centerY As Single, ByVal radius As Single)
        g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius)
    End Sub


    Public Sub drawCircle(ByVal g As Graphics, ByVal e As PaintEventArgs, ByVal locX As String, ByVal locY As String, ByVal cDistance As Double)
        If apiTimer.eewExists = True And locX > -999999 And locY > -999999 Then

            Dim pWavePen As New Pen(Brushes.DeepSkyBlue)

            ' Set the pen's width.
            pWavePen.Width = 1.0F

            DrawOutlineCircle(g, pWavePen, locX, locY, DataStructureRaw.swTotalPixelRadius * 2)




            Dim rectH2 As Integer = DataStructureRaw.swTotalPixelRadius * 2
            Dim rectW2 As Integer = DataStructureRaw.swTotalPixelRadius * 2

            ' Dim blueBrush As New System.Drawing.SolidBrush(Color.FromArgb(255, 0, 0))
            ' Dim myRectangle As New Rectangle
            Dim rectHeightHalf As Integer = rectH2 / 2
            Dim rectWidthHalf As Integer = rectW2 / 2
            ' Dim pt As Point = Me.SfMap1.GisPointToPixelCoord(locX, locY)
            ' g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            '  myRectangle.X = locX - rectWidthHalf
            ' myRectangle.Y = locY - rectHeightHalf

            '  myRectangle.X = locX
            '  myRectangle.Y = locY

            ' myRectangle.Width = rectW2
            ' myRectangle.Height = rectH2

            '  g.FillEllipse(blueBrush, myRectangle)

            If rectWidthHalf <> 0 Then ' GDI+ Will throw outofmemoryexception


                Dim centreX As String = locX
                Dim centreY As String = locY

                Dim radius = DataStructureRaw.swTotalPixelRadius
                Dim diameter = radius * 2


                Dim bounds = New RectangleF(centreX - radius,
                                        centreY - radius,
                                        diameter,
                                        diameter)
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                Using path As New GraphicsPath
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    path.AddEllipse(bounds)
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    Using brush As New PathGradientBrush(path)
                        brush.CenterPoint = New PointF(centreX, centreY)
                        If DataStructureRaw.alertFlagOrigin = "警報" Then
                            brush.CenterColor = Color.FromArgb(0, Color.Red)
                            brush.SurroundColors = {Color.FromArgb(120, 255, 0, 0)}
                        ElseIf DataStructureRaw.alertFlagOrigin = "予報" Then
                            brush.SurroundColors = {Color.FromArgb(120, 255, 174, 0)}
                            brush.CenterColor = Color.FromArgb(0, Color.Gold)
                        Else
                            brush.SurroundColors = {Color.FromArgb(120, 255, 174, 0)}
                            brush.CenterColor = Color.FromArgb(0, Color.Gold)
                        End If

                        brush.FocusScales = PointF.Empty
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                        e.Graphics.FillRectangle(brush, bounds)

                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

                        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias


                        If DataStructureRaw.alertFlagOrigin = "警報" Then
                            e.Graphics.DrawEllipse(New Pen(Color.Maroon, 1.0F), bounds)
                        ElseIf DataStructureRaw.alertFlagOrigin = "予報" Then
                            e.Graphics.DrawEllipse(New Pen(Color.Orange, 1.0F), bounds)
                        Else
                            e.Graphics.DrawEllipse(New Pen(Color.Orange, 1.0F), bounds)
                        End If
                    End Using
                End Using

            End If
        End If
    End Sub

    Private Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * Math.PI / 180
    End Function

    Private Function RadiansToDegrees(ByVal radians As Double) As Double
        Return radians * 180 / Math.PI
    End Function

    Function extrapolate(ByVal startPointLat As Double, ByVal startPointLon As Double, ByVal course As Double, ByVal distance As Double) As Point

        Dim DEGREE_DISTANCE_AT_EQUATOR As Integer = 111329
        Dim EARTH_RADIUS As Double = 6378137
        Dim MINUTES_TO_METERS As Double
        Dim DEGREE_TO_MINUTES As Double
        '
        'lat =asin(sin(lat1)*cos(d)+cos(lat1)*sin(d)*cos(tc))
        'dlon=atan2(sin(tc)*sin(d)*cos(lat1),cos(d)-sin(lat1)*sin(lat))
        'lon=mod( lon1+dlon +pi,2*pi )-pi
        '
        ' where:
        ' lat1,lon1  -start pointi n radians
        ' d          - distance in radians Deg2Rad(nm/60)
        ' tc         - course in radians
        Dim crs As Double = DegreesToRadians(course)
        Dim d12 As Double = DegreesToRadians((distance _
                        / (MINUTES_TO_METERS / DEGREE_TO_MINUTES)))
        Dim lat1 As Double = DegreesToRadians(startPointLat)
        Dim lon1 As Double = DegreesToRadians(startPointLon)
        Dim lat As Double = Math.Asin(((Math.Sin(lat1) * Math.Cos(d12)) _
                        + (Math.Cos(lat1) _
                        * (Math.Sin(d12) * Math.Cos(crs)))))
        Dim dlon As Double = Math.Atan2((Math.Sin(crs) _
                        * (Math.Sin(d12) * Math.Cos(lat1))), (Math.Cos(d12) _
                        - (Math.Sin(lat1) * Math.Sin(lat))))
        Dim lon As Double = (((lon1 _
                    + (dlon + Math.PI)) Mod (2 * Math.PI)) _
                    - Math.PI)
        Return New Point(RadiansToDegrees(lat), RadiansToDegrees(lon))
    End Function

    Function longitudeDistanceAtLatitude2(ByVal latitude As Double) As Double
        Dim DEGREE_DISTANCE_AT_EQUATOR As Integer = 111329
        Dim EARTH_RADIUS As Double = 6378137
        Dim MINUTES_TO_METERS As Double
        Dim DEGREE_TO_MINUTES As Double

        Dim longitudeDistanceScaleForCurrentLatitude As Double = Math.Cos(DegreesToRadians(latitude))
        Return (DEGREE_DISTANCE_AT_EQUATOR * longitudeDistanceScaleForCurrentLatitude)
    End Function

    ''' <summary>
    ''' Plot graphics object on map. Marker types are:
    ''' Normal/Not-Measured/ -> realtime
    ''' Inner/Outer Circle Combo -> multi
    ''' Hybrid Expected Intensity -> hyex
    ''' Measured Intensity -> measured
    ''' 
    ''' </summary>
    ''' <param name="g">Graphics Type</param>
    ''' <param name="locX">Latitude of Point</param>
    ''' <param name="locY">Longitude of Point</param>
    ''' <param name="markerType">Marker Type (see summary)</param>
    ''' <param name="innerCircle">Color of Measured (For Multi)</param>
    ''' <param name="outerCircle">Color of expected (For Multi)</param>
    ''' <param name="defaultColor">Color of Realtime (For Single)/Hybrid Expec</param>
    ''' <param name="intensity">Measurement of Measured Intensity (use +/-)</param>
    ''' 
    Public Sub DrawMarker(ByVal g As Graphics, ByVal locX As Double, ByVal locY As Double, markerType As String, innerCircle As Color, outerCircle As Color, defaultColor As Color, intensity As String)
        Dim blueBrush As New System.Drawing.SolidBrush(defaultColor)
        Try
            If markerType = "realtime" Then
                'Find the Color

                Dim colorOut As Color = colorProcessing.ReturnTileColorJMAplusMinus(colorProcessing.ReturnPlusMinusJma(intensity))


                'Draw the Circle
                Dim myRectangle As New Rectangle
                Dim rectHeightHalf As Integer = rectH / 2
                Dim rectWidthHalf As Integer = rectW / 2
                '    Dim pt As Point = Me.SfMap1.GisPointToPixelCoord(locX, locY)
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                myRectangle.X = locX - rectWidthHalf
                myRectangle.Y = locY - rectHeightHalf
                myRectangle.Width = rectW
                myRectangle.Height = rectH

                g.FillEllipse(blueBrush, myRectangle)


            End If

        Catch ex As Exception
            errorHandler.HandleError("info", "Zoom Exceeded resulting in Overflow error. This is not a critical error and should not be reported.", False)
        End Try

        'In case of measured intensity, draw a circled ellipse.

        If markerType = "multi" Then
            'Draw Initial Circle

            Dim myRectangle As New Rectangle
            Dim rectHeightHalf As Integer = rectH / 2
            Dim rectWidthHalf As Integer = rectW / 2
            Dim pt As Point = Me.SfMap1.GisPointToPixelCoord(locX, locY)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            myRectangle.X = pt.X - rectWidthHalf
            myRectangle.Y = pt.Y - rectHeightHalf
            myRectangle.Width = rectW
            myRectangle.Height = rectH

            g.FillEllipse(blueBrush, myRectangle)

        End If


        'Longitude goes first, latitude goes second.






        '  Dim bluePen As New Pen(Color.Blue)

        '  Dim blueBrush As New System.Drawing.SolidBrush(System.Drawing.Color.White)
        ' Create rectangle.
        '   Dim rect As New Rectangle(pt.X - rectWidthHalf, pt.Y - rectHeightHalf, rectW, rectH)
        '  Dim myGraphics As Graphics = Me.CreateGraphics
        '  myGraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias



        ' Fill rectangle to screen.
        '   g.FillRectangle(blueBrush, rect)

        'g.FillEllipse(blueBrush, myRectangle)
    End Sub

    Private Sub viewPage_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub FlowNoAlertPane1_Load(sender As Object, e As EventArgs) Handles FlowNoAlertPane1.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs)
        drawMarkers(e)
    End Sub



    Private Sub SfMap1_MouseUp(sender As Object, e As MouseEventArgs) Handles SfMap1.MouseUp
        SfMap1.Invalidate()
    End Sub

    Private Sub SfMap1_SizeChanged(sender As Object, e As EventArgs) Handles SfMap1.SizeChanged
        SfMap1.Invalidate()
    End Sub
End Class