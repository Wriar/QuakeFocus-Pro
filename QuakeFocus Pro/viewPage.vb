'ViewPage Settings
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Svg

Public Class viewPage
    Private image As System.Drawing.Imaging.Metafile

    Function MakeNewImage(ByVal i1 As Bitmap, ByVal i2 As Bitmap) As Bitmap
        Dim g As Graphics = Graphics.FromImage(i1)
        g.DrawImage(i2, New Point(0, 0))
        Return i1
    End Function

    Private pfc As PrivateFontCollection

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



    End Function

    Public Shared Function Truncate(ByVal value As String, ByVal maxLength As Integer) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
    End Function

    Private Sub SfMap1_Paint(sender As Object, e As PaintEventArgs) Handles SfMap1.Paint


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

        'Demo Demo P/S Circle



    End Sub

    Dim rectH As Integer = 3
    Dim rectW As Integer = 3
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
End Class