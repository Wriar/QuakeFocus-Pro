Imports System.Text
Imports System.Threading

Public Class lightDetect
    ''' <summary>
    ''' 1. IMPORT TABLE INTO THE DATAGRID (IMPORT TABLE)
    ''' 2. RUN 10 ITERATIONS OF CURRENT DATA INTO TABLE (ADDTABLEDATA1)
    ''' 3. START TIMER FOR TUPLE AVERAGE LIST (ADDTOTUPLE)
    ''' 4. START TIMER TO IMPORT PIXEL VALUES (ADDTABLEDATA)
    ''' 5. START WATCHDOG TO MONITOR FOR TRUE INSIDE TUPLE
    ''' 
    ''' WATCHDOG:
    ''' 
    ''' IF NO TRUE IS SEEN INSIDE THE TUPLE, START THE ADDTOTUPLE TIMER. FLUSH THE INCREMENTAL VALUES.
    ''' 
    ''' IN CASE OF ALERT SEEN BY WATCHDOG (TRUE)
    ''' 
    ''' STOP IMPORT TABLE DATAGRID TIMER (IMPORT TABLE)
    ''' 
    ''' BEGIN INCREMENTING VALUE FOR COOLDOWN VALUE IN SETTINGS VALUE.
    ''' 
    ''' WHEN COOLDOWN VALUE IS EXCEEDED, START THE TABLE IMPORTER.
    ''' FLUSH THE INCREMENTAL VALUES.
    ''' 
    ''' 
    ''' 
    ''' </summary>

    Private Sub lightDetect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eess.Columns.Add("location", "es")
        eess.Columns.Add("prefecture", "es")
        eess.Columns.Add("niedx", "es")
        eess.Columns.Add("niedy", "es")
        eess.Columns.Add("c1", "es")
        eess.Columns.Add("c2", "es")
        eess.Columns.Add("c3", "es")
        eess.Columns.Add("c4", "es")
        eess.Columns.Add("c5", "es")
        eess.Columns.Add("c6", "es")
        eess.Columns.Add("c7", "es")
        eess.Columns.Add("c8", "es")
        eess.Columns.Add("c9", "es")
        eess.Columns.Add("c10", "es")


    End Sub

    Dim csvLoaded As Boolean = False 'is the data csv loaded?
    Dim applicationPath As String = Application.StartupPath()
    Private dataPoints As New List(Of Tuple(Of Point, Integer)) 'Required for Custom-Alert Drawing
    Dim averagedPointDualList As New List(Of Point)
    Dim workingColValue As Integer = 3
    Dim tableFilled As Boolean = False

    Dim eewExists As Boolean = False 'Updated from seperate class.

    '\\\\\\\\\\\\\\\\\\\\\ USE THIS TUPLE VARIABLE TO PROCESS OTHER EVENTS \\\\\\\\\\\\\\\\\\
    ' Format: Average JMA as String, JMA X/Y As Point, DetectionTrue As Boolean (If area is of concern), Station Name As String, Station Prefecture As String
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Public tupleAvgRtList As New List(Of Tuple(Of String, Point, Boolean, String, String))
    'This function is used to import the intensities and average them from the table.
    Dim eess As New DataGridView



    Sub loadCSV()
        If csvLoaded = False Then 'Load Only Once
            csvLoaded = True
            Dim fName As String = applicationPath & "\assets\calibration.csv"


            Dim TextLine As String = ""
            Dim SplitLine() As String

            If System.IO.File.Exists(fName) = True Then
                Using objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        SplitLine = Split(TextLine, ",")
                        eess.Rows.Add(SplitLine)
                    Loop
                End Using
            Else
                errorHandler.HandleError("code", "Assets have been illegally modified. Could not load file of Calibration.csv", True)
            End If
        Else

        End If


    End Sub

    Sub addTableData()
        If 1 = 1 Then


            'RunONCE: Clear the List of all Previous Values



            Dim rowCount As Integer = eess.Rows.Count

            workingColValue = workingColValue + 1


            Try

                For row As ULong = 0 To rowCount - 1 Step 1

                    '  Console.WriteLine(row)

                    Dim workingPointX As Integer
                    Dim workingPointY As Integer


                    workingPointX = (eess.Rows(row).Cells(2).Value)
                    workingPointY = (eess.Rows(row).Cells(3).Value)

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


                        If workingColValue < 14 Then

                            eess(workingColValue, CInt(row)).Value = rawInterpolatedColor

                            Console.WriteLine("Working at Points of: " & CInt(row) & ", " & workingColValue)


                        Else
                            workingColValue = 4
                            eess(workingColValue, CInt(row)).Value = rawInterpolatedColor
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

                    Dim colCount As Integer = eess.Rows.Count
                    Dim averagedCount As Double

                    For Each row As DataGridViewRow In eess.Rows 'For Each Row, Add All values in specified columns

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

    End Sub

    Sub addToTuple()
        ' tupleAvgRtList.Clear()

        Try
            '   dataPoints.Clear()
            Dim rowCount As Integer = eess.Rows.Count

            For row As ULong = 0 To rowCount - 1 Step 1

                '  Console.WriteLine(row)

                Dim workingPointX As Integer
                Dim workingPointY As Integer
                Dim locationAreaName As String

                'clear


                workingPointX = (eess.Rows(row).Cells(2).Value)
                workingPointY = (eess.Rows(row).Cells(3).Value)
                locationAreaName = (eess.Rows(row).Cells(0).Value) & " Sensor in " & (eess.Rows(row).Cells(1).Value) & " Prefecture."

                Dim areaSensor As String = eess.Rows(row).Cells(0).Value
                Dim areaPrefecture As String = eess.Rows(row).Cells(1).Value

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
                        Console.WriteLine("WARNING: JMA INT 1+ SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))
                    ElseIf CDbl(rawInterpolatedColor) >= 4.0 Then
                        Console.WriteLine("WARNING: STRONG SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))

                    ElseIf CDbl(rawInterpolatedColor) > 0.5 And CDbl(rawInterpolatedColor) < 1 Then
                        Console.WriteLine("WARNING: LIGHT SHAKING DETECTED IN: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, True, areaSensor, areaPrefecture))
                    Else
                        Console.WriteLine("INFO: NO SHAKING DETECTED In: " & locationAreaName)
                        tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, False, areaSensor, areaPrefecture))
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

                    lx = eess.Rows(row).Cells(2).Value - 10
                    ly = eess.Rows(row).Cells(3).Value - 10
                    Dim location As New Point(lx, ly)

                    If insertJMAIntensity > 0 Then
                        dataPoints.Add(Tuple.Create(location, insertJMAIntensity))
                    Else

                    End If


                Else
                    'No Alerts Exist: Bypass

                    Console.WriteLine("No Alerts are Present")

                    tupleAvgRtList.Add(Tuple.Create(CStr(rawInterpolatedColor), areaPoint, False, areaSensor, areaPrefecture))
                End If



            Next

            'Delete last few items from the tuple.

            If tupleAvgRtList.Count >= 700 Then
                Dim remove As Integer = Math.Min(tupleAvgRtList.Count, 696)
                tupleAvgRtList.RemoveRange(0, remove)

            Else

            End If

        Catch ex As Exception
            errorHandler.HandleError("service", ex.Message, False)
        End Try

        'Must be run within timer.
        '  Dim thread As New Thread(AddressOf ImportTableAsync)

        '  Thread.Start()

    End Sub
    ''' <summary>
    ''' WATCHDOG:
    ''' 
    ''' IF NO TRUE IS SEEN INSIDE THE TUPLE, START THE ADDTOTUPLE TIMER. FLUSH THE INCREMENTAL VALUES.
    ''' 
    ''' IN CASE OF ALERT SEEN BY WATCHDOG (TRUE)
    ''' 
    ''' STOP IMPORT TABLE DATAGRID TIMER (IMPORT TABLE)
    ''' 
    ''' BEGIN INCREMENTING VALUE FOR COOLDOWN VALUE IN SETTINGS VALUE.
    ''' 
    ''' WHEN COOLDOWN VALUE IS EXCEEDED, START THE TABLE IMPORTER.
    ''' FLUSH THE INCREMENTAL VALUES.
    ''' 
    ''' 
    ''' </summary>

    Dim secElapsedSinceDetection As Integer = 0 'Incremental Value
    Dim reiterateTableTime As Integer = 0
    Dim currentlyReiterating As Boolean = False

    Sub watchdog() 'Run once per second.
        'Check if a "true" variable is seen within the tuple.
        Dim detectionExists As Boolean = False
        For Each tupleItem In tupleAvgRtList
            If tupleItem.Item3 = True Then
                detectionExists = True
                'Stop Table Importer Here:

                If currentlyReiterating = False Then
                    updateChart.Stop()

                End If

            End If
        Next

        If detectionExists = True Then

            If currentlyReiterating = False Then
                secElapsedSinceDetection += 1 'Increment
            End If

            If secElapsedSinceDetection >= My.Settings.alertTimeoutSec Then

                'Give 10 iterations to reaverage the table.
                currentlyReiterating = True

                reiterateTableTime += 1


                updateChart.Start()
                updateTuple.Stop()


                If reiterateTableTime >= 15 Then

                    '  MsgBox("complete")
                    reiterateTableTime = 0
                    secElapsedSinceDetection = 0
                    currentlyReiterating = False

                    'clear the tuple?
                    '  tupleAvgRtList.Clear()
                    updateTuple.Start()
                    Console.WriteLine("reiteration complete.")
                    addToTuple()

                End If


            End If
        Else
            ' reiterateTableTime = 0
            ' secElapsedSinceDetection = 0
            ' currentlyReiterating = False
            ' updateChart.Start()


        End If
    End Sub

    Private Sub btnImportTable_Click(sender As Object, e As EventArgs) Handles btnImportTable.Click
        loadCSV()
    End Sub

    Private Sub btnIterate_Click(sender As Object, e As EventArgs) Handles btnIterate.Click
        addTableData()

    End Sub

    Private Sub btnPrintTuple_Click(sender As Object, e As EventArgs) Handles btnPrintTuple.Click
        For Each item In tupleAvgRtList
            Console.WriteLine(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addToTuple()
    End Sub

    Private Sub updateTuple_Tick(sender As Object, e As EventArgs) Handles updateTuple.Tick
        Dim myThread As New Thread(AddressOf addToTuple)
        myThread.Start()
    End Sub

    Private Sub updateChart_Tick(sender As Object, e As EventArgs) Handles updateChart.Tick
        Dim myThread As New Thread(AddressOf addTableData)
        ' myThread.IsBackground = True
        myThread.Start()
    End Sub

    Private Sub runWatchdog_Tick(sender As Object, e As EventArgs) Handles runWatchdog.Tick
        Dim myThread As New Thread(AddressOf watchdog)
        myThread.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateTuple.Start()
        updateChart.Start()
        runWatchdog.Start()
    End Sub

    Private Sub updateInfo_Tick(sender As Object, e As EventArgs) Handles updateInfo.Tick
        If updateTuple.Enabled = True Then
            lblStatTu.Text = "ENABLED"
        Else
            lblStatTu.Text = "DISABLED"
        End If

        If updateChart.Enabled = True Then
            lblStatTa.Text = "ENABLED"
        Else
            lblStatTa.Text = "DISABLED"
        End If

        If runWatchdog.Enabled = True Then
            lblStatWd.Text = "ENABLED"
        Else
            lblStatWd.Text = "DISABLED"
        End If

        lblVar.Text = secElapsedSinceDetection & " / " & reiterateTableTime

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updateInfo.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ingestRealTime.Image = My.Resources.sampleimg
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ingestRealTime.Image = My.Resources.hi_demo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
