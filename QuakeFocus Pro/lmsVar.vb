Imports System.Text
Imports System.Threading

Public Class lmsVar
    ''' <summary>
    ''' REALTIME LIGHT SHAKING DETECTION SYSTEM
    ''' </summary>
    Dim applicationPath As String = Application.StartupPath

    Public loadedDT As DataTable

    Public lmsCSVLoaded As Boolean = False

    Public Shared Function loadList()

    End Function

    Private Function LoadCSV()
        If lmsCSVLoaded = False Then 'Load Only Once
            lmsCSVLoaded = True
            Dim fName As String = applicationPath & "\assets\calibration.csv"


            Dim TextLine As String = ""
            Dim SplitLine() As String

            If System.IO.File.Exists(fName) = True Then
                Using objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        SplitLine = Split(TextLine, ",")
                        DataGridView1.Rows.Add(SplitLine)
                    Loop
                End Using
            Else
                errorHandler.HandleError("code", "Assets have been illegally modified. Could not load file of Calibration.csv", True)
            End If
        Else
            directTableImport()
        End If

        Return True

    End Function
    Dim lineCountrow As Integer = 1
    Dim averagedPointDualList As New List(Of Point)
    Private WorkingColValue As Integer = 3
    Dim alertThrown As Boolean
    Dim tableFilled As Boolean



    Dim alertElapsedTimeSec As Integer = 0
    Dim alertCooldownTimeSec As Integer = 0

    ''' <summary>
    ''' This is old analysis algorithm from another old project that relies heavily on a UI component.
    ''' 
    ''' A Alternative will be released in a new release.
    ''' 
    ''' 
    ''' process: analyze points. Real usable components are featured within a tuple list.
    ''' </summary>

    Private dataPoints As New List(Of Tuple(Of Point, Integer)) 'Required for Custom-Alert Drawing

    ' Dim eewExists As Boolean = False

    '\\\\\\\\\\\\\\\\\\\\\ USE THIS TUPLE VARIABLE TO PROCESS OTHER EVENTS \\\\\\\\\\\\\\\\\\
    ' Format: Average JMA as String, JMA X/Y As Point, DetectionTrue As Boolean (If area is of concern), Station Name As String, Station Prefecture As String
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Public tupleAvgRtList As New List(Of Tuple(Of String, Point, Boolean, String, String))
    'This function is used to import the intensities and average them from the table.
    Sub directTableImport()
        Dim ee As New Point(12, 12)






        Try
            '   dataPoints.Clear()
            Dim rowCount As Integer = DataGridView1.Rows.Count

            For row As ULong = 0 To rowCount - 1 Step 1

                '  Console.WriteLine(row)

                Dim workingPointX As Integer
                Dim workingPointY As Integer
                Dim locationAreaName As String

                'clear

                tupleAvgRtList.Clear()
                workingPointX = (DataGridView1.Rows(row).Cells(2).Value)
                workingPointY = (DataGridView1.Rows(row).Cells(3).Value)
                locationAreaName = (DataGridView1.Rows(row).Cells(0).Value) & " Sensor in " & (DataGridView1.Rows(row).Cells(1).Value) & " Prefecture."

                Dim areaSensor As String = DataGridView1.Rows(row).Cells(0).Value
                Dim areaPrefecture As String = DataGridView1.Rows(row).Cells(1).Value

                Dim testPoint As New Point(workingPointX, workingPointY)

                'Check Station Averages

                Dim stationAVG As String = -3

                For Each listPoint As Point In averagedPointDualList
                    If listPoint.X = row Then
                        stationAVG = listPoint.Y

                    End If
                Next
                Dim bmp1 As Bitmap = ingestRealTime.Image

                Dim pointPixelColor As Color = bmp1.GetPixel(testPoint.X, testPoint.Y)

                Dim rawInterpolatedColor As String = colorProcessing.ProcessColor(pointPixelColor, "jma", False)
                Dim areaPoint As New Point(testPoint.X, testPoint.Y)

                If stationAVG + My.Settings.lmsAutoAlertThreshold < rawInterpolatedColor Then



                    'get relative JMA color of each point. Add variable to retrivable list.

                    If CDbl(rawInterpolatedColor) >= 1.0 And CDbl(rawInterpolatedColor) < 4 Then
                        '  Console.WriteLine("WARNING: JMA INT 1+ SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))
                        alertThrown = True
                        alertTimeout.Start()


                    ElseIf CDbl(rawInterpolatedColor) >= 4.0 Then
                        '  Console.WriteLine("WARNING: STRONG SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))

                        alertThrown = True
                        alertTimeout.Start()

                    ElseIf CDbl(rawInterpolatedColor) > 0.5 And CDbl(rawInterpolatedColor) < 1 Then
                        '  Console.WriteLine("WARNING: LIGHT SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))

                        alertThrown = True

                        'Start timeout timer

                        alertTimeout.Start()
                    Else
                        '  Console.WriteLine("INFO: NO SHAKING DETECTED In: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, False, areaSensor, areaPrefecture))

                        alertTimeout.Start()
                    End If

                    Dim insertJMAIntensity As Integer

                    If rawInterpolatedColor >= 1 And rawInterpolatedColor < 2 Then
                        insertJMAIntensity = 1

                    ElseIf rawInterpolatedColor >= 2 And rawInterpolatedColor < 3 Then
                        insertJMAIntensity = 2

                    ElseIf rawInterpolatedColor >= 3 And rawInterpolatedColor < 4 Then
                        insertJMAIntensity = 3

                    ElseIf rawInterpolatedColor >= 4 And rawInterpolatedColor < 5 Then
                        insertJMAIntensity = 4

                    ElseIf rawInterpolatedColor >= 5 And rawInterpolatedColor < 5.5 Then
                        insertJMAIntensity = 5

                    ElseIf rawInterpolatedColor >= 5.5 And rawInterpolatedColor < 6 Then
                        insertJMAIntensity = 6

                    ElseIf rawInterpolatedColor >= 6 And rawInterpolatedColor < 6.5 Then
                        insertJMAIntensity = 7

                    ElseIf rawInterpolatedColor >= 6.5 And rawInterpolatedColor < 7 Then
                        insertJMAIntensity = 8

                    ElseIf rawInterpolatedColor >= 7 Then
                        insertJMAIntensity = 9

                    Else
                        'do nothing
                        insertJMAIntensity = 0

                    End If


                    'Push Images
                    'Draw Alerts

                    Dim lx As Integer
                    Dim ly As Integer

                    lx = DataGridView1.Rows(row).Cells(2).Value - 10
                    ly = DataGridView1.Rows(row).Cells(3).Value - 10
                    Dim location As New Point(lx, ly)

                    If insertJMAIntensity > 0 Then
                        dataPoints.Add(Tuple.Create(location, insertJMAIntensity))
                    Else

                    End If


                Else
                    'No Alerts Exist: Bypass

                    ' Console.WriteLine("No Alerts are Present")

                    tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, False, areaSensor, areaPrefecture))
                End If



            Next



        Catch ex As Exception
            errorHandler.HandleError("service", ex.Message, False)
        End Try

        'Must be run within timer.
        '  Dim thread As New Thread(AddressOf ImportTableAsync)

        '  Thread.Start()

    End Sub
    'This region updates the table. Run only if there are no alerts.

    Public eewExists As Boolean = False
    Public detectionExists As Boolean = False

#Region "Import Table Async"
    Sub ImportTableAsync()

        'Master IF function

        ' If eewExists = False And detectionExists = False Then
        If 1 = 1 Then


            'RunONCE: Clear the List of all Previous Values



            Dim rowCount As Integer = DataGridView1.Rows.Count

            WorkingColValue = WorkingColValue + 1


            Try

                For row As ULong = 0 To rowCount - 1 Step 1

                    '  Console.WriteLine(row)

                    Dim workingPointX As Integer
                    Dim workingPointY As Integer


                    workingPointX = (DataGridView1.Rows(row).Cells(2).Value)
                    workingPointY = (DataGridView1.Rows(row).Cells(3).Value)

                    Dim testPoint As New Point(workingPointX, workingPointY)

                    Console.WriteLine(testPoint.ToString())

                    'get relative JMA color of each point

                    Dim bmp1 As Bitmap = ingestRealTime.Image

                    Dim pointPixelColor As Color = bmp1.GetPixel(testPoint.X, testPoint.Y)

                    Dim rawInterpolatedColor As String = colorProcessing.ProcessColor(pointPixelColor, "jma", False)



                    Console.WriteLine(rawInterpolatedColor)




                    'Set the rawInterpolatedColor As our Working Value


                    If eewExists = False Then
                        'Add rawInterpolatedValue


                        If WorkingColValue < 14 Then

                            DataGridView1(WorkingColValue, CInt(row)).Value = rawInterpolatedColor

                            Console.WriteLine("Working at Points of: " & CInt(row) & ", " & WorkingColValue)


                        Else
                            WorkingColValue = 4
                            DataGridView1(WorkingColValue, CInt(row)).Value = rawInterpolatedColor
                            tableFilled = True

                            Console.WriteLine("Overriding Values")

                        End If




                    End If

                    'Add a integer-type value for each station's interpolated intensity
                    Dim InterpolatedColorIntegerJMA As Integer = rawInterpolatedColor

                    Console.WriteLine("Integer Form Color Interpolated IS: " & InterpolatedColorIntegerJMA)










                    'Simplify the Collection



                Next



                If tableFilled = True Then
                    'Table is full to allow for a more accurate average

                    Dim colCount As Integer = DataGridView1.Rows.Count
                    Dim averagedCount As Double

                    For Each row As DataGridViewRow In DataGridView1.Rows 'For Each Row, Add All values in specified columns

                        '\\ Note: col is mislabeled. It is supposed to be row. \\

                        'Declare Individual Samples
                        Dim sample1 As Double
                        Dim sample2 As Double
                        Dim sample3 As Double
                        Dim sample4 As Double
                        Dim sample5 As Double
                        Dim sample6 As Double
                        Dim sample7 As Double
                        Dim sample8 As Double
                        Dim sample9 As Double
                        Dim sample10 As Double

                        ' Console.WriteLine(CStr(row.Cells(1).FormattedValue))   '| These are INDIVIDUAL SAMPLES for EACH station |
                        sample1 = (CStr(row.Cells(4).FormattedValue))
                        sample2 = (CStr(row.Cells(5).FormattedValue))
                        sample3 = (CStr(row.Cells(6).FormattedValue))
                        sample4 = (CStr(row.Cells(7).FormattedValue))
                        sample5 = (CStr(row.Cells(8).FormattedValue))
                        sample6 = (CStr(row.Cells(9).FormattedValue))
                        sample7 = (CStr(row.Cells(10).FormattedValue))
                        sample8 = (CStr(row.Cells(11).FormattedValue))
                        sample9 = (CStr(row.Cells(12).FormattedValue))
                        sample10 = (CStr(row.Cells(13).FormattedValue))

                        Dim totalSample As Double = sample1 + sample2 + sample3 + sample4 + sample5 + sample6 + sample7 + sample8 + sample9 + sample10
                        ' Console.WriteLine("The SUM for the station on row " & row.Index & " is: " & totalSample)

                        averagedCount = totalSample / 10

                        Console.WriteLine("The AVERAGE for the station on row " & row.Index & " is: " & averagedCount)    '<==== AVG OUTPUTTED HERE!!

                        'Create a "point" for new data

                        Dim listPointToAdd As New Point(row.Index, averagedCount)


                        averagedPointDualList.Add(listPointToAdd)

                    Next


                Else
                    'Wait for table to fully populate

                End If


            Catch ex As Exception
                errorHandler.HandleError("service", ex.Message, False)
            End Try
        Else
            'An eew Exists, don't do anything.
        End If

        Console.WriteLine("Final List: " & averagedPointDualList.ToString())
    End Sub
#End Region
    'Watchdog Function for Enabling averaging.

    Sub runWatchdog()
        'Check for an EEW.
        Dim aExist As Boolean


        For Each tp As Tuple(Of String, Point, Boolean, String, String) In tupleAvgRtList
            Dim e As Boolean = tp.Item3

            If e = True Then
                'An alert exists
                aExist = True

            End If
        Next

        'Stop Counting if Needed

        'Info: eewExists is updated in seperate class.

        If aExist = True Then
            'Stop the Counting, begin the timer.
            alertTimeout.Start()
            detectionExists = True

            updateTable.Stop()

        Else
            detectionExists = False
            alertTimeout.Stop()

            secElapsedTimeout = 0 'Reset
            catchupTime = 0

            updateTable.Start()

        End If

    End Sub

    Dim secElapsedTimeout As Integer
    Dim catchupTime As Integer = 0
    Dim watchdogTime As Integer = 0



    Private Sub alertTimeout_Tick(sender As Object, e As EventArgs) Handles alertTimeout.Tick
        secElapsedTimeout += 1 'add second using compound assignment

        'Allow allocated time in settings for timeout.

        Dim maxTime As Integer = My.Settings.alertTimeoutSec

        If secElapsedTimeout >= maxTime Then
            'Even though shaking was still detected, allow algorithm to catch up.
            updateTable.Start()
            detectionExists = False

            'Wait for watchdog

            watchdogTime += 1

            If watchdogTime >= 15 Then
                watchdogTime = 0
                detectionExists = False

                secElapsedTimeout = 0
                watchdog.Start()
                updateTable.Start()
                alertTimeout.Stop()


            End If

        Else
            watchdog.Stop()

        End If






    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadCSV()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ingestRealTime.Image = My.Resources.hi_demo

    End Sub

    Private Sub lmsVar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim estr As String
        For Each item In tupleAvgRtList
            ListBox1.Items.Add(item)


        Next


    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        directTableImport()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ImportTableAsync()

    End Sub

    Private Sub updateTable_Tick(sender As Object, e As EventArgs) Handles updateTable.Tick
        ImportTableAsync()

    End Sub

    Private Sub importTuples_Tick(sender As Object, e As EventArgs) Handles importTuples.Tick

        directTableImport()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        updateTable.Start()
        importTuples.Start()
        watchdog.Start()

    End Sub

    Private Sub allFunctions_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub watchdog_Tick(sender As Object, e As EventArgs) Handles watchdog.Tick
        runWatchdog()
    End Sub

    Private Sub infoReporter_Tick(sender As Object, e As EventArgs) Handles infoReporter.Tick
        If alertTimeout.Enabled = True Then
            lblStatTo.Text = "STARTED"
            lblStatTo.BackColor = Color.Green

        Else
            lblStatTo.Text = "STOPPED"
            lblStatTo.BackColor = Color.Red

        End If

        If importTuples.Enabled = True Then
            lblStatTu.Text = "STARTED"
            lblStatTu.BackColor = Color.Green
        Else
            lblStatTu.Text = "STOPPED"
            lblStatTu.BackColor = Color.Red
        End If

        If updateTable.Enabled = True Then
            lblStatTa.Text = "STARTED"
            lblStatTu.BackColor = Color.Green
        Else
            lblStatTa.Text = "STOPPED"
            lblStatTa.BackColor = Color.Red
        End If

        If watchdog.Enabled = True Then
            lblStatWd.Text = "STARTED"
            lblStatWd.BackColor = Color.Green
        Else
            lblStatWd.Text = "STOPPED"
            lblStatWd.BackColor = Color.Red
        End If

        lblVar.Text = secElapsedTimeout


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        infoReporter.Start()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ingestRealTime.Image = My.Resources.sampleimg

    End Sub
End Class