' MAIN PROCESSES OF APP CODE CONDENSED ON THIS PAGE
Imports System.IO
Imports System.Net
Imports System.Threading
Imports Newtonsoft.Json
Imports Dangl.Calculator 'This is deprecated no need but I'll still leave it in here.
Imports KyoshinMonitorLib.Images
Imports System.Text

Public Class apiTimer

    Dim realtimeNIED As PictureBox

    Public initialLocationDB As New List(Of Tuple(Of String, String, Point, String, String, String, Tuple(Of String, String))) 'Initilize location set of Sensor Area, Prefecture, NX, NY, lat, long
    Public epicenterContainer As Tuple(Of String, String, String, String, Boolean, Boolean) 'Epicenter Long, Epicenter Lat, Depth


    Private Sub xmlFetchTimer_Tick(sender As Object, e As EventArgs) Handles xmlFetchTimer.Tick
        XMLViewParse.importIntolist()

    End Sub

    Private Sub imageImportTimer_Tick(sender As Object, e As EventArgs) Handles imageImportTimer.Tick
        'Create Request to Check for Most Recent Image
        importImgTime()

    End Sub
    Dim currentIMGtimedate As String
    Dim niedDownloadStarted As Boolean = False
    Dim pgaDownloadStarted As Boolean = False

    Private eewPresent As Boolean


    Sub importImgTime()
        Dim TimeSync As String
        Dim rawJSON1 As String = ""

        Try


            Dim serviceURL1 As String = "http://www.kmoni.bosai.go.jp/webservice/server/pros/latest.json"
            Dim client1 As WebClient = New WebClient()
            Dim reader1 As StreamReader = New StreamReader(client1.OpenRead(serviceURL1))
            'In case of error:
            rawJSON1 = "{""security"": {""realm"": ""/webservice/server/pros/latest/"", ""hash"": ""0""}, ""latest_time"": ""2021/07/24 08:43:52"", ""request_time"": ""2021/07/24 08:43:53"", ""result"": {""status"": ""success"", ""message"": """"}}"
            rawJSON1 = reader1.ReadToEnd
            '   Console.WriteLine("ServiceTime URL Is: " & rawJSON1)

        Catch ex As Exception
            errorHandler.HandleError("service", "The remote timeserver cannot be contacted.", False)

        End Try

        If rawJSON1 <> "" Then
            Dim jsonResulttodict1




            Try

                jsonResulttodict1 = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawJSON1)

            Catch ex As Exception

            End Try

            Try
                TimeSync = "2021/07/22 07:23:46"
                TimeSync = jsonResulttodict1.Item("latest_time")
            Catch ex As Exception

            End Try
        Else

        End If
        'Parse Raw into Datetime
        Dim oDate As DateTime
        Try
            oDate = DateTime.ParseExact(TimeSync, "yyyy/MM/dd HH:mm:ss", Nothing)
        Catch ex As Exception

        End Try

        '  Console.WriteLine("OUDATE IS " & oDate)

        'Get Usable DateTime

        Dim serverTimeDelaySeconds As Integer = My.Settings.serverDelay + My.Settings.rewindTime

        '   Console.WriteLine("SD IS " & My.Settings.serverDelay)
        '   Console.WriteLine("RW IS " & My.Settings.rewindTime)


        '   Console.WriteLine("Server Delay IS " & serverTimeDelaySeconds)


        Dim rawJSON As String






        'Generate the URL
        '   Dim TokyoOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")
        Dim currentImage As String = oDate.AddSeconds(-serverTimeDelaySeconds).ToString("yyyyMMddHHmmss")
        '   fRPT.Text = currentImage

        currentIMGtimedate = currentImage

        My.Settings.privateImgDateTime = currentImage

        Dim currentImageDate As String = oDate.AddSeconds(-serverTimeDelaySeconds).ToString("yyyyMMdd")
        '   FLDTT.Text = currentImageDate

        '    currentIMGdate = currentImageDate
        My.Settings.privateImgDate = currentImageDate

        ' Console.WriteLine(currentImage)



        'Download the current Image(s)


        If niedDownloadStarted = False Then
            Dim imageDonwloder As NIEDImageDownloader = Nothing

            imageDonwloder = New NIEDImageDownloader()

            'Toggle this on/off for Testing Mode Only TSTFLAG1

            ' pcImg.Image = My.Resources.smp1
            imageDonwloder.StartDownload(Me.pcImg, 1, My.Settings.serverDelay)


            '   methodDownloadNIED()

            niedDownloadStarted = True
        Else


        End If

        If pgaDownloadStarted = False Then
            '   Dim imageDonwloder2 As pgaImgDownloader = Nothing

            '  imageDonwloder2 = New pgaImgDownloader()
            '  imageDonwloder2.StartDownload(Me.pgaImg, 1, My.Settings.serverDelay)


            methodDownloadPGA()
            pgaDownloadStarted = True
        Else


        End If
        Dim jsonPartURLDate As DateTime
        Try
            'For JSON Functions
            jsonPartURLDate = DateTime.ParseExact(TimeSync, "yyyy/MM/dd HH:mm:ss", Nothing)


            Dim jsonFullTime As String = jsonPartURLDate.ToString("yyyyMMddHHmmss")
            jsonPartURL = jsonFullTime

        Catch Ex As Exception

        End Try
    End Sub
    Private tokyoTimer As System.Timers.Timer = Nothing
    Private tokyoClient As WebClient
    Private Sub methodDownloadNIED()

        tokyoTimer = New System.Timers.Timer() With {.Interval = 1000}
        tokyoClient = New WebClient()

        AddHandler tokyoTimer.Elapsed,
        Sub()
            Dim TokyoOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")
            Dim currentImage As String



            Try
                Dim data As Byte()
                If My.Settings.currentMode = "live" Then
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/jma_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".jma_s.gif"))
                Else
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/jma_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".gif"))
                End If

                BeginInvoke(New MethodInvoker(
                    Sub()
                        pcImg.Image?.Dispose()
                        pcImg.Image = Image.FromStream(New MemoryStream(data))
                    End Sub))
            Catch ex As Exception
                ' The exception hadling can be quite extensive here, since many factor can cause it: 
                ' No server response, no Internet connection, internal server (500+) faults etc.
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        tokyoTimer.Enabled = True


    End Sub
    Private pgaTimer As Timers.Timer = Nothing
    Private pgaClient As WebClient
    Private Sub methodDownloadPGA()

        tokyoTimer = New System.Timers.Timer() With {.Interval = 1000}
        tokyoClient = New WebClient()

        AddHandler tokyoTimer.Elapsed,
        Sub()
            Dim TokyoOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")
            Dim currentImage As String



            Try
                Dim data As Byte()
                If My.Settings.currentMode = "live" Then
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/acmap_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".acmap_s.gif"))
                Else
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/acmap_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".gif"))
                End If

                BeginInvoke(New MethodInvoker(
                    Sub()
                        pgaImg.Image?.Dispose()
                        pgaImg.Image = Image.FromStream(New MemoryStream(data))
                    End Sub))
            Catch ex As Exception
                ' The exception hadling can be quite extensive here, since many factor can cause it: 
                ' No server response, no Internet connection, internal server (500+) faults etc.
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        tokyoTimer.Enabled = True
    End Sub
    Private Sub methodDownloadPGA1()
        pgaTimer = New System.Timers.Timer() With {.Interval = 1000}
        pgaClient = New WebClient()

        AddHandler tokyoTimer.Elapsed,
        Sub()
            Console.WriteLine("1START")
            Dim TokyoOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")
            '    Dim currentImage As String = TokyoOffset.AddSeconds(-4).ToString("yyyyMMdd/yyyyMMddHHmmss") & ".jma_s.gif"
            Try
                Console.WriteLine("2START")
                Dim data As Byte()
                If My.Settings.currentMode = "live" Then
                    Console.WriteLine("3START")
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/acmap_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".acmap_s.gif"))
                    Console.WriteLine("4START")
                Else
                    data = tokyoClient.DownloadData(New Uri(My.Settings.dataImgChannel & "data/map_img/RealTimeImg/acmap_s/" & My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime & ".gif"))
                    Console.WriteLine("5START")
                End If

                BeginInvoke(New MethodInvoker(
                    Sub()
                        pgaImg.Image?.Dispose()
                        pgaImg.Image = Image.FromStream(New MemoryStream(data))
                    End Sub))
            Catch ex As Exception
                ' The exception hadling can be quite extensive here, since many factor can cause it: 
                ' No server response, no Internet connection, internal server (500+) faults etc.
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        tokyoTimer.Enabled = True
    End Sub

    Private Sub localPGAIdentifier_Tick(sender As Object, e As EventArgs) Handles localPGAIdentifier.Tick
        ' Both are combined into one timer.


        '======
        'IGNORE BAD NAMING- WILL BE FIXED LATER
        '======


        'Use Color Picker
        Dim imgToBitmap As Bitmap = pgaImg.Image

            Dim localPGAColor = imgToBitmap.GetPixel(My.Settings.userLocalPointX, My.Settings.userLocalPointY)

            Dim pgaR As Integer = localPGAColor.R
            Dim pgaG As Integer = localPGAColor.G
            Dim pgaB As Integer = localPGAColor.B

            viewPage.localPga.pgaColorGradient.BackColor = Color.FromArgb(pgaR, pgaG, pgaB)


        Dim longstr As String = colorProcessing.ProcessColor(localPGAColor, "pga", False) & "00000"

        Console.WriteLine(longstr)


        If longstr < 900 Then
            If longstr < -3 Then longstr = "-3.000000"
            '* First 5 Chars
            Dim first4Chars = If(longstr.Length > 5, longstr.Substring(0, 5), longstr.Substring(0, Text.Length))
            viewPage.localPga.pgaLbl.Text = first4Chars

        Else

                viewPage.localPga.pgaLbl.Text = ">900"
            End If






        Dim imgToBitmap2 As Bitmap = pcImg.Image
        Dim localPGAColor2 = imgToBitmap2.GetPixel(My.Settings.userLocalPointX, My.Settings.userLocalPointY)

        Dim pgaR1 As Integer = localPGAColor2.R
        Dim pgaG1 As Integer = localPGAColor2.G
        Dim pgaB1 As Integer = localPGAColor2.B

        viewPage.localPga.intGradientColor.BackColor = Color.FromArgb(pgaR1, pgaG1, pgaB1)

        Dim longstr1 As String = colorProcessing.ProcessColor(localPGAColor2, "jma", False) & "00000"
        '  Console.WriteLine(longstr1)

        If longstr < 900 Then

            If longstr1 < -3 Then longstr1 = "-3.000000"


            '    Dim first5Digits = longstr.Substring(0, 4)

            Dim first4Chars = If(longstr1.Length > 4, longstr1.Substring(0, 4), longstr1.Substring(0, Text.Length))
            viewPage.localPga.intLbl.Text = first4Chars


        Else

                viewPage.localPga.intLbl.Text = ">900"
            End If


    End Sub



    'Private Data Required for JSON implementation
    Private jsonPartURL As String
    Private jsonResult As String
    Public jsonStatus As Boolean 'Displays if JSON is successful.

    'Public Variables for Using API

    Public reportTime As String
    Public requestTime As String
    Public regionNameJP As String
    Public longitude As String
    Public latitude As String
    Public isCancel As String
    Public depthOrigin As String
    Public calcIntensity As String
    Public isFinal As String
    Public isTraining As String
    Public originTime As String
    Public magunitude As String
    Public reportNumber As String
    Public reportId As String
    Public alertFlagOrigin As String

    'Important
    Public eewExists As Boolean



    Sub eewJsonImport()
        Try
            'The Current URL for JSON is the same format for realtime data


            '============
            'For LIVE USE
            Dim constructedURL As String = "http://www.kmoni.bosai.go.jp/webservice/hypo/eew/" & jsonPartURL & ".json"

            'FOR DEBUGGING TSTFLAG1

            '  Dim constructedURL As String = "http://www.kmoni.bosai.go.jp/webservice/hypo/eew/20210320181258.json"
            '==============

            'Create Webclient for JSON Request

            Dim webClient As New WebClient
            Dim result As String = webClient.DownloadString(constructedURL)

            '   MsgBox(result)
            jsonResult = result 'Allow to be accessed via function.

            jsonStatus = True
        Catch Ex As Exception
            jsonStatus = False

        End Try


        'Begin to Process the JSON with Newtonsoft

        Try
            Dim jsonResulttodict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResult)
            Dim AlertStatus As String = jsonResulttodict.Item("security")("realm")

            If AlertStatus = "/kyoshin_monitor/static/jsondata/eew_est/" Then
                'If this exists, this means that an EEW exists

                reportTime = jsonResulttodict.Item("report_time")
                requestTime = jsonResulttodict.Item("request_time")
                regionNameJP = jsonResulttodict.Item("region_name")
                longitude = jsonResulttodict.Item("longitude")
                isCancel = jsonResulttodict.Item("is_cancel")
                depthOrigin = jsonResulttodict.Item("depth")
                calcIntensity = jsonResulttodict.Item("calcintensity")
                isFinal = jsonResulttodict.Item("is_final")
                isTraining = jsonResulttodict.Item("is_training")
                latitude = jsonResulttodict.Item("latitude")
                originTime = jsonResulttodict.Item("origin_time")
                magunitude = jsonResulttodict.Item("magunitude")
                reportNumber = jsonResulttodict.Item("report_num")
                alertFlagOrigin = jsonResulttodict.Item("alertflg")
                reportId = jsonResulttodict.Item("report_id")
                eewExists = True

                'IF MULTITHREADING IS USED THIS WON'T WORK.
                Label1.Text = reportTime
                Label2.Text = requestTime
                Label3.Text = regionNameJP
                Label4.Text = longitude
                Label5.Text = latitude
                Label6.Text = isCancel
                Label7.Text = depthOrigin
                Label8.Text = calcIntensity
                Label9.Text = isFinal
                Label10.Text = isTraining
                Label11.Text = originTime
                Label12.Text = magunitude
                Label13.Text = reportNumber
                Label15.Text = alertFlagOrigin
                Label14.Text = reportId

                eewExists = True

            Else
                eewExists = False

            End If

        Catch ex As Exception

        End Try



    End Sub

    Public Sub drawPSCircles()

    End Sub

    Private Sub jsonImporter_Tick(sender As Object, e As EventArgs) Handles jsonImporter.Tick
        Dim eThread As New Thread(AddressOf eewJsonImport)
        eThread.Start()

        ' MsgBox(magunitude)
    End Sub

    Private Sub pushJson_Tick(sender As Object, e As EventArgs) Handles pushJson.Tick
        If eewExists = True Then
            'Show the Banners

            Console.WriteLine("EEW Exists")
            viewPage.FlowTsunami1.Visible = False
            viewPage.FlowNoAlertPane1.Visible = False
            viewPage.FlowLightShaking1.Visible = False
            viewPage.EewBanner1.Visible = True


            'Get language to use
            Try
                If My.Settings.prefixLang = "jp" Then
                    'Do not require translations
                    viewPage.EewBanner1.locationLbl.Text = regionNameJP
                Else
                    'Language is english; attempt translation
                    viewPage.EewBanner1.locationLbl.Text = translationSource.DecodeEpicenterToEnglish(regionNameJP)
                End If

            Catch ex As Exception
                errorHandler.HandleError("service", "Could not translate EEW String", False)
            End Try



        Else
            'There is no worry about EEW.
            viewPage.EewBanner1.Visible = False
            viewPage.FlowNoAlertPane1.Visible = True


        End If
    End Sub

    Private Sub viewPageFlowAdjust_Tick(sender As Object, e As EventArgs) Handles viewPageFlowAdjust.Tick
        If viewPage.FlowTsunami1.Visible = True And viewPage.FlowNoAlertPane1.Visible = False And viewPage.EewBanner1.Visible = False And viewPage.FlowLightShaking1.Visible = False Then
            'one pane is visible. 
            If viewPage.mapDocker.Location.X <> 421 And viewPage.mapDocker.Location.Y <> 15 Then
                viewPage.mapDocker.Location = New Point(443, 15)
            End If
            '421, 15
        End If
        If viewPage.FlowTsunami1.Visible = False And viewPage.FlowNoAlertPane1.Visible = True And viewPage.EewBanner1.Visible = False And viewPage.FlowLightShaking1.Visible = False Then
            If viewPage.mapDocker.Location.X <> 421 And viewPage.mapDocker.Location.Y <> 15 Then
                viewPage.mapDocker.Location = New Point(443, 15)
            End If
        End If

        If viewPage.FlowTsunami1.Visible = False And viewPage.FlowNoAlertPane1.Visible = False And viewPage.EewBanner1.Visible = False And viewPage.FlowLightShaking1.Visible = True Then
            If viewPage.mapDocker.Location.X <> 421 And viewPage.mapDocker.Location.Y <> 15 Then
                viewPage.mapDocker.Location = New Point(443, 15)
            End If
        End If

        If viewPage.EewBanner1.Visible = True Then
            If viewPage.mapDocker.Location.X <> 421 And viewPage.mapDocker.Location.Y <> 154 Then
                viewPage.mapDocker.Location = New Point(443, 154)
            End If

        End If

        'Adjust Map Pane
        Dim mdW = viewPage.Width - viewPage.mapDocker.Location.X - 50
        Dim mdH = viewPage.Height - viewPage.mapDocker.Location.Y - 50
        viewPage.mapDocker.Size = New Size(mdW, mdH)

        'Adjust Location of Local Label

        Dim llX As Integer = viewPage.mapDocker.Location.X + viewPage.mapDocker.Width - 350
        Dim llY As Integer = viewPage.mapDocker.Location.Y + viewPage.mapDocker.Height - 100
        viewPage.localPga.Location = New Point(llX, llY)
        viewPage.localPga.BringToFront()

    End Sub

    Private Sub circlePlotter_Tick(sender As Object, e As EventArgs) Handles circlePlotter.Tick

    End Sub

    Private Sub niedPointImporter_Tick(sender As Object, e As EventArgs) Handles niedPointImporter.Tick
        'Use the Picture Box

        If 1 = 1 Then 'For Demonstration

            viewPage.SfMap1.Refresh()

        End If

    End Sub

    Sub importCsv()
        '  Dim fName As String = applicationPath & "\calibration\point10.csv"


        ''   Dim TextLine As String = ""
        ''   Dim SplitLine() As String

        '   If System.IO.File.Exists(fName) = True Then
        ' Using objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
        ' Do While objReader.Peek() <> -1
        ' TextLine = objReader.ReadLine()
        ' SplitLine = Split(TextLine, ",")
        '    Me.DataGridView1.Rows.Add(SplitLine)
        '  Loop
        '   End Using
        '   Else
        '   MsgBox("File Does Not Exist")
        '   End If
    End Sub

    Private Sub apiTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    prefAvg.Start()
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/pt-master-tr.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                initialLocationDB.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), Tuple.Create(splits(7), splits(8))))

            Next

            For Each item In initialLocationDB
                '    Debug.Print($"{item.Item1} {item.Item2} - {item.Item3.X}, {item.Item3.Y} {item.Item4}")
            Next

        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/pt-master.csv) DT: " & ex.Message, "true")
        End Try

        'Test
        MsgBox(hsEpicenterLocator.getPWTravelTime(10.0) & vbCrLf & hsEpicenterLocator.getSWTravelTime(10.0))


        '   niedPointImporter.Start()
        localNIEDAvg.Start()

        '  prefAvg.Start()
        workingPrefAvg.Start()
        '  lightDetectDB.Add(Tuple.Create("test", "test", "test", "test", "test", "test", "light"))
    End Sub
    Dim localAverageRaw As String
    Dim localAverage As String

    Function Truncate(ByVal value As String, ByVal maxLength As Integer) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return If(value.Length <= maxLength, value, value.Substring(0, maxLength))
    End Function

    Private Sub localNIEDAvg_Tick(sender As Object, e As EventArgs) Handles localNIEDAvg.Tick
        'Get the Local Point

        'Bitmap must be locked to provide consistent average and to avoid memory errors
        Dim bitmapLock As Bitmap = pcImg.Image


        Dim commonPref As String
        Dim userPointX As Integer = My.Settings.userLocalPointX
        Dim userPointY As Integer = My.Settings.userLocalPointY

        Dim userPointVar As New Point(userPointX, userPointY)

        Dim listIndex As Integer = 0
        Dim listIndex2 As Integer = 0

        Dim prefCount As Integer
        Dim prefTotal As Decimal = 0



        For Each item In initialLocationDB

            If userPointVar.X = item.Item3.X And userPointVar.Y = item.Item3.Y Then
                ' Console.WriteLine("Combo Found on line: " & listIndex & " COMP: " & initialLocationDB(listIndex).Item3.ToString())

                'Found List Index, get prefecture
                commonPref = initialLocationDB(listIndex).Item7.Item1
            End If

            listIndex += 1
        Next

        'After Prefecture name is found, search for the prefecture.
        Dim jmaVal As Decimal

        Dim localVal As Decimal = viewPage.localPga.intLbl.Text

        For Each item In initialLocationDB

            If item.Item7.Item1 = commonPref Then
                prefCount += 1

                'Import the Bitmap and get value. 
                Dim pointColor As Color = bitmapLock.GetPixel(item.Item3.X, item.Item3.Y)

                'Get JMA Value of Point

                jmaVal = colorProcessing.ProcessColor(pointColor, "jma", False, False)

                prefTotal = prefTotal + jmaVal
            Else


            End If

            listIndex2 += 1
        Next

        'Once sum has been completed, find average

        localAverageRaw = prefTotal / prefCount
        localAverage = Truncate(localAverageRaw, 6)
        '   Console.WriteLine("AVERAGE IS: " & localAverage)


        'Push the value to Local Monitor

        'Get the ceiling
        Dim maxvalue As String = localAverage + CInt(My.Settings.lmsAutoAlertThreshold)

        'Get the minimum: 
        Dim minimumVal As String = localAverage

        'get the height

        Dim height As String = maxvalue - minimumVal

        'DESCRIPTION:

        'If current value is between floor and celing, check the percent there by dividing current value by ceiling height. (Floor + Cval) / height
        'If current value is less then ceiling, final val is 0/100
        'If current value is above ceiling, final val is 100/100.
        'Check if currrrent measurement is between the local average at all. 
        'If so, display % there.

        Dim finalProgressValue As Integer
        Console.WriteLine("FLOOR: " & minimumVal & " CEILING: " & maxvalue & " HEIGHT: " & height & " CURRENT VALUE: " & localVal)
        If localVal <= minimumVal Then
            finalProgressValue = 0
            'Under floor. 
            Console.WriteLine("Percent1 is: 0")
        ElseIf localVal >= maxvalue Then
            'Above Floor
            finalProgressValue = 100
            Console.WriteLine("Percent2 is: 100")
        Else
            'Between Floor

            'EX FLOOR IS -2
            'MEASURED IS -1.5
            'CEILING is -1
            'HEIGHT is 1

            'EX Floor is 3
            'CEILING IS 5
            'MEASURED IS 3.5
            'HEIGHT is 2

            'Measured - Floor = 0.5 / 2

            '0.5/ 2 (HEIGHT)


            Dim quo As Decimal = (localVal - minimumVal) / height
            Dim quoFinal As Decimal = quo * 100

            'ABS(FLOOR) 

            '    Dim quo As Decimal = (minimumVal + ) / height 'Zero-Based
            '   Dim intquo = CInt(quo)

            finalProgressValue = quoFinal

            '  Console.WriteLine("QUO IS: " & quo)
            Console.WriteLine("Percent3 is: " & quoFinal)
        End If

        viewPage.ViewPageLocalMonitor1.ColorBar1.Value = finalProgressValue
        viewPage.ViewPageLocalMonitor1.Label5.Text = "DT: +" & CInt(My.Settings.lmsAutoAlertThreshold)
        viewPage.ViewPageLocalMonitor1.Label2.Text = "INT: " & CInt(viewPage.localPga.intLbl.Text)
        '  viewPage.ViewPageLocalMonitor1.ColorBar1.Value = 1
    End Sub
    Public avgR As Double

    Private createAverage As Boolean

    Private htAvg As Decimal
    Private kantoAvg As Decimal
    Private ChubuAvg As Decimal
    Private kansaiAvg As Decimal
    Private ChShAvg As Decimal
    Private KyushuAvg As Decimal

    Private lightDetectDB As New List(Of Tuple(Of String, String, String, String, String, String, String)) 'JP Location, JP Pref, EN Location, EN Pref, Long, Lat, Alert Type

    '  Private doAvgPref As Boolean = True

    'Does an light-shaking warning exist?
    Private algWarningExist As Boolean = False

    'Does a JMA-Based Warning Exist?
    Private jmaWarningExist As Boolean = False
#Region "OLD Light Detect"

    Private Sub prefAvg_Tick(sender As Object, e As EventArgs) Handles prefAvg.Tick

        'DEPRECATED. USE REAL PREFAVG TIMER.


        'List:

        'Zone 1: Hokkaido/Tohoku
        'Zone 2: Kanto
        'Zone 3: Chubu
        'Zone 4: Kansai
        'Zone 5: Chugoku/Shikoku
        'Zone 6: Kyushu

        'd

        Label16.Text = Label16.Text + 1

        'Step 1: Create Averages:
        'Clear DB

        If Not IsNothing(lightDetectDB) AndAlso lightDetectDB.Count > 0 Then
            lightDetectDB.Clear()
        Else
            '    Response.Write("Nothing")
        End If


        Dim z1Sum As Decimal
        Dim z2Sum As Decimal
        Dim z3Sum As Decimal
        Dim z4Sum As Decimal
        Dim z5Sum As Decimal
        Dim z6Sum As Decimal

        Dim z1Count As Integer = 1
        Dim z2Count As Integer = 1
        Dim z3Count As Integer = 1
        Dim z4Count As Integer = 1
        Dim z5Count As Integer = 1
        Dim z6Count As Integer = 1

        'Lock Bitmap
        Dim bitLock As Bitmap = pcImg.Image
        If 1 = 1 Then
            For Each item In initialLocationDB
                'Get The Color
                Dim pixelColor As Color

                pixelColor = bitLock.GetPixel(item.Item3.X, item.Item3.Y)

                'Get Int
                Dim decimalInt As Decimal = colorProcessing.ProcessColor(pixelColor, "jma", False)

                'Add the value to respected decimal

                'Get Type
                Dim zone As Integer = item.Item7.Item2

                If zone = 1 Then
                    z1Sum += decimalInt
                    z1Count += 1

                ElseIf zone = 2 Then
                    z2Sum += decimalInt
                    z2Count += 1

                ElseIf zone = 3 Then
                    z3Sum += decimalInt
                    z3Count += 1

                ElseIf zone = 4 Then
                    z4Sum += decimalInt
                    z4Count += 1

                ElseIf zone = 5 Then
                    z5Sum += decimalInt
                    z5Count += 1

                Else 'Six
                    z6Sum += decimalInt
                    z6Count += 1

                End If
            Next
        End If

        'Create the Average

        htAvg = z1Sum / z1Count
        kantoAvg = z2Sum / z2Count
        ChubuAvg = z3Sum / z3Count
        kansaiAvg = z4Sum / z4Count
        ChShAvg = z5Sum / z5Count
        KyushuAvg = z6Sum / z6Count

        Console.WriteLine("HTAVG IS: " & htAvg & " Sum: " & z1Sum & " Count: " & z1Count)

        'Create Check

        'Loop thru all points

        Dim autoThres As Decimal = My.Settings.lmsAutoAlertThreshold

        For Each Item In Me.initialLocationDB
            Dim pixelColor As Color = bitLock.GetPixel(Item.Item3.X, Item.Item3.Y)
            Dim jmaVal As Decimal = colorProcessing.ProcessColor(pixelColor, "jma", False)

            'Get Zone
            Dim zoneNum As Integer = Item.Item7.Item2
            Dim alertPossible As Boolean = False
            Dim totalThresholdAuto As Decimal = My.Settings.lmsPrefAutoAlertThreshold

            If zoneNum = 1 Then

                If jmaVal > htAvg + autoThres Then
                    'Alert can be added. Enable to add this alert.
                    alertPossible = True
                Else
                    'In case of after-earthquake, some prefecture may expirence long-term shaking. Cross check with an opposite region to be sure.

                    If htAvg + totalThresholdAuto > KyushuAvg Then
                        alertPossible = True
                    End If


                End If

            ElseIf zoneNum = 2 Then
                If jmaVal > kantoAvg + autoThres Then
                    'Alert can be added.
                    alertPossible = True
                Else
                    If kantoAvg + totalThresholdAuto > ChShAvg Then
                        alertPossible = True
                    End If
                End If
            ElseIf zoneNum = 3 Then
                If jmaVal > ChubuAvg + autoThres Then
                    'Alert can be added.
                    alertPossible = True
                Else
                    If ChubuAvg + totalThresholdAuto > kantoAvg Then
                        alertPossible = True
                    End If
                End If
            ElseIf zoneNum = 4 Then
                If jmaVal > kansaiAvg + autoThres Then
                    'Alert can be added.
                    alertPossible = True
                Else
                    If kansaiAvg + totalThresholdAuto > htAvg Then
                        alertPossible = True
                    End If
                End If
            ElseIf zoneNum = 5 Then
                If jmaVal > ChShAvg + autoThres Then
                    'Alert can be added.
                    alertPossible = True
                Else
                    If ChShAvg + totalThresholdAuto > kantoAvg Then
                        alertPossible = True
                    End If
                End If
            Else
                If jmaVal > KyushuAvg + autoThres Then
                    'Alert can be added.
                    alertPossible = True
                Else
                    If KyushuAvg + totalThresholdAuto > htAvg Then
                        alertPossible = True
                    End If
                End If
            End If

            'If threshold is exceeded, add the alert

            If alertPossible = True Then
                '1. Get Type

                Dim alertType As String

                If jmaVal >= 0.5 And jmaVal < 1 Then
                    alertType = "light"
                ElseIf jmaVal >= 1 And jmaVal < 4 Then
                    alertType = "moderate"
                ElseIf jmaVal >= 4 Then
                    alertType = "strong"
                Else
                    alertType = "bugged"
                End If

                If alertType = "light" Then
                    lightDetectDB.Add(Tuple.Create(Item.Item1, Item.Item2, Item.Item6, Item.Item7.Item1, Item.Item4, Item.Item5, "light")) ''JP Location, JP Pref, EN Location, EN Pref, Long, Lat, Alert Type
                    algWarningExist = True
                    '   alertTimeout.Start()
                ElseIf alertType = "moderate" Then
                    lightDetectDB.Add(Tuple.Create(Item.Item1, Item.Item2, Item.Item6, Item.Item7.Item1, Item.Item4, Item.Item5, "moderate"))
                    algWarningExist = True
                    ' alertTimeout.Start()
                ElseIf alertType = "strong" Then
                    lightDetectDB.Add(Tuple.Create(Item.Item1, Item.Item2, Item.Item6, Item.Item7.Item1, Item.Item4, Item.Item5, "strong"))
                    algWarningExist = True
                    '  alertTimeout.Start()
                Else
                    'Don't do anything, there is an error.
                    errorHandler.HandleError("service", "Tuple Error Creation in light-shaking detection alg. Check integrity of resource files", False)
                End If

            End If

        Next
        Console.WriteLine("PREFAVG Run")

        Console.WriteLine(lightDetectDB.ToString)
    End Sub
    Private alertTimeOutprefix As Integer = My.Settings.alertTimeoutSec
    Private alertTimeOutCount As Integer = 0

    Private Sub alertTimeout_Tick(sender As Object, e As EventArgs) Handles alertTimeout.Tick
        Console.WriteLine("ATT Run")


        If algWarningExist = False Then
            'Attempt
            Console.WriteLine("Attempted to start timeout but no warning was in progress..")
            alertTimeout.Stop()
            prefAvg.Start()
        Else

            If cxCounter.Text >= My.Settings.lmsPrefAutoAlertThreshold Then

                alertTimeout.Stop()
                cxCounter.Text = 0
                prefAvg.Start()

            Else
                prefAvg.Stop()

                cxCounter.Text = cxCounter.Text + 1
                Console.WriteLine("Counting 1")
            End If



        End If



    End Sub
#End Region
    Private lightTuplesLoaded As Boolean = False
#Region "Light Detector Updaated"
    Private Sub workingPrefAvg_Tick(sender As Object, e As EventArgs) Handles workingPrefAvg.Tick
        avgMainFunction()
    End Sub
    'Tuples are directly imported via the CSV in form. These asre static and contain no observations.
    'Of Area JP, Prefecture JP, NIED X, NIED Y, Longitude, Latitude, Area ENG, Prefecture ENG
    Public zone1Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Public zone2Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Public zone3Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Public zone4Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Public zone5Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Public zone6Tuple As New List(Of Tuple(Of String, String, Point, String, String, String, String))
    Function avgMainFunction()
        If lightTuplesLoaded = False Then
            'Load the Tuples (raw) to be processed to average.
            loadLightTuple()
            lightTuplesLoaded = True
        Else
            Dim realtimeBitmapLock As Bitmap
            Try
                realtimeBitmapLock = pgaImg.Image
                'Lock picturebox changes in a bitmap

                Dim avg1 As Double
                Dim avg2 As Double
                Dim avg3 As Double
                Dim avg4 As Double
                Dim avg5 As Double
                Dim avg6 As Double


                Dim count1 As Integer
                Dim count2 As Integer
                Dim count3 As Integer
                Dim count4 As Integer
                Dim count5 As Integer
                Dim count6 As Integer

                'Totals are required to average
                Dim total1 As Double
                Dim total2 As Double
                Dim total3 As Double
                Dim total4 As Double
                Dim total5 As Double
                Dim total6 As Double

                'Attempt to calculate average for zone 1
#Region "Average for Region 1"
                Try
                    'Loop
                    For Each item In zone1Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        ' Console.WriteLine("INTP VAL 1: " & interpolatedVal)

                        total1 += interpolatedVal
                        count1 += 1

                    Next

                    avg1 = total1 / count1
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try

#End Region
#Region "Average for Region 2"
                Try
                    'Loop
                    For Each item In zone2Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        '     Console.WriteLine("INTP VAL 2: " & interpolatedVal)

                        total2 += interpolatedVal
                        count2 += 1

                    Next

                    avg2 = total2 / count2
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try
                Console.WriteLine("AVG 1 IS: " & avg1)
                Console.WriteLine("AVG 2 IS: " & avg2)
#End Region
#Region "Average for Region 3"
                Try
                    'Loop
                    For Each item In zone3Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        '     Console.WriteLine("INTP VAL 2: " & interpolatedVal)

                        total3 += interpolatedVal
                        count3 += 1

                    Next

                    avg3 = total3 / count3
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try
                Console.WriteLine("AVG 1 IS: " & avg1)
                Console.WriteLine("AVG 2 IS: " & avg2)
#End Region
#Region "Average for Region 4"
                Try
                    'Loop
                    For Each item In zone4Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        '     Console.WriteLine("INTP VAL 2: " & interpolatedVal)

                        total4 += interpolatedVal
                        count4 += 1

                    Next

                    avg4 = total4 / count4
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try
                Console.WriteLine("AVG 1 IS: " & avg1)
                Console.WriteLine("AVG 2 IS: " & avg2)
#End Region
#Region "Average for Region 5"
                Try
                    'Loop
                    For Each item In zone5Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        '     Console.WriteLine("INTP VAL 2: " & interpolatedVal)

                        total5 += interpolatedVal
                        count5 += 1

                    Next

                    avg5 = total5 / count5
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try
                Console.WriteLine("AVG 1 IS: " & avg1)
                Console.WriteLine("AVG 2 IS: " & avg2)
#End Region
#Region "Average for Region 6"
                Try
                    'Loop
                    For Each item In zone6Tuple
                        Dim niedX As Integer = item.Item3.X
                        Dim niedY As Integer = item.Item3.Y

                        Dim selectColor As Color = realtimeBitmapLock.GetPixel(niedX, niedY)

                        Dim interpolatedVal As Double = colorProcessing.ProcessColor(selectColor, "jma", False, False)

                        '     Console.WriteLine("INTP VAL 2: " & interpolatedVal)

                        total6 += interpolatedVal
                        count6 += 1

                    Next

                    avg6 = total6 / count6
                    ' Console.WriteLine("AVERAGE FOR TOTAL 1 IS " & avg1)
                Catch ex As Exception

                End Try
                Console.WriteLine("AVG 1 IS: " & avg1)
                Console.WriteLine("AVG 2 IS: " & avg2)
#End Region

            Catch ex As Exception
                errorHandler.HandleError("info", "Bitmap AVG Not Loaded F2. Do not report this issue.", False)

                Return False
            End Try


        End If
    End Function

    Sub loadLightTuple()
        'Load all tuple elements.

        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone1.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone1Tuple.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone2.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone2Tuple.Add(Tuple.Create(splits(0), splits(1), (New Point(CInt(splits(2)), CInt(splits(3)))), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone3.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone3Tuple.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone4.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone4Tuple.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone5.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone5Tuple.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try
        Try
            Dim cDir As String = Application.StartupPath()


            'Attempt to initilize the tuple

            Dim lines = File.ReadAllLines(cDir & "/assets/average/zone6.csv")

            For Each line In lines
                Dim splits = line.Split(","c)
                zone6Tuple.Add(Tuple.Create(splits(0), splits(1), New Point(splits(2), splits(3)), splits(4), splits(5), splits(6), splits(7)))

            Next
        Catch ex As Exception
            errorHandler.HandleError("code", "Assets were either moved, renamed or deleted: master location table (/assets/average) DT: " & ex.Message, "true")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        globalSettings.Show()
    End Sub
#End Region

End Class
