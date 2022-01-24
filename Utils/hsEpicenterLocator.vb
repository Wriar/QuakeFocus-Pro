Imports System.IO
Public Class hsEpicenterLocator




    Public Shared Function locateEpicenter(psImg As Image)

    End Function

    Public Shared Function getSWTravelTime(depth As String)
        Dim csvPath As String = Application.StartupPath & "/assets/vjma2001.csv"
        Dim sr As New IO.StreamReader(csvPath, True)
        Dim rowNum As Integer = getRow(sr, depth, 3)
        sr.Close()

        Return GetValue(rowNum - 1, 1)

    End Function

    Public Shared Function getPWTravelTime(depth As String)
        Try
            Dim csvPath As String = Application.StartupPath & "/assets/vjma2001.csv"
            Dim sr As New IO.StreamReader(csvPath, True)
            Dim rowNum As Integer = getRow(sr, depth, 3)
            sr.Close()

            Return GetValue(rowNum - 1, 0)

        Catch ex As Exception
            errorHandler.HandleError("code", "Could not interpolate P-W Time. Please check to be sure that assets are not illegally modified. ERR CONTENT: " & ex.Message, True)
        End Try

    End Function


    Public Shared Function getRow(csv As StreamReader, v1 As Integer, Col1 As Integer) As Long
        Dim r As Long = 1

        Do While csv.EndOfStream = False
            Dim s As String() = Split(csv.ReadLine(), ","c)
            If s.Contains(v1.ToString) Then
                If s.Count >= Col1 Then
                    If s(Col1 - 1) = v1.ToString Then Return r
                End If
            End If
            r += 1
        Loop
        Return 0 'not found
    End Function

    Public Shared Function GetValue(row As Integer, col As Integer) As String

        Dim csvPath As String = Application.StartupPath & "/assets/vjma2001.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function
#Region "TimeTravel Dependencies"
    Private Function deg2rad(ByVal deg As Double) As Double 'these are function that help withthe conversion
        Try
            Return (deg * Math.PI / 180.0)
        Catch ex As Exception
            '  ThrowCalcError("LONGLATCONV", ("Deg2Rad Conversion Failed: " & ex.Message))
        End Try
        Return True

    End Function

    Private Function rad2deg(ByVal rad As Double) As Double
        Try
            Return rad / Math.PI * 180.0
        Catch ex As Exception
            ' ThrowCalcError("LONGLATCONV", ("rad2deg Conversion Failed: " & ex.Message))
        End Try

        Return True

    End Function

    Public Enum RoundingDirection 'everything here is just conversion functions
        Nearest
        Up
        Down
    End Enum

    Public Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double 'we have a function here when giving a value returns another value
        Try
            If lat1 = lat2 And lon1 = lon2 Then '
                Return 0 'this entire function converts a longitude/latitude into a distance (km)
            Else 'first we convert your location to the epicenter and display the answer in KM
                Dim theta As Double = lon1 - lon2
                Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
                dist = Math.Acos(dist)
                dist = rad2deg(dist)
                dist = dist * 60 * 1.1515
                If unit = "K" Then
                    dist = dist * 1.609344
                ElseIf unit = "N" Then
                    dist = dist * 0.8684
                End If
                Return dist
            End If
        Catch ex As Exception
            '  ThrowCalcError("LONGLATCONVR", ("Distance Conversion Failed: " + ex.Message))

        End Try
        Return True

    End Function

    Public Shared Function GetRoundedNumber(ByVal number As Decimal, ByVal multiplier As Decimal, ByVal direction As RoundingDirection) As Decimal
        Try
            Dim nearestValue As Decimal = (CInt(number / multiplier) * multiplier)
            Select Case direction
                Case RoundingDirection.Nearest
                    Return nearestValue
                Case RoundingDirection.Up
                    If nearestValue >= number Then
                        Return nearestValue
                    Else
                        Return nearestValue + multiplier
                    End If
                Case RoundingDirection.Down
                    If nearestValue <= number Then
                        Return nearestValue
                    Else
                        Return nearestValue - multiplier
                    End If
            End Select
            ' Return True
        Catch ex As Exception


        End Try
        Return True
    End Function

#End Region
    Dim appPath As String = Application.StartupPath()

    Public Function GetArrivalTime(UserLat As String, UserLong As String, EventLat As String, EventLong As String, HypocenterDepth As Integer) As String
        Try
            Dim csvPath As String
            Dim unround_coord As String = distance(UserLat, UserLong, EventLat, EventLong, "K") 'Set Variables of the raw coordinates
            Dim decTotal As Decimal = GetRoundedNumber(CDec(unround_coord), CDec(10), RoundingDirection.Nearest) 'Setup Rounding Function

            'Start to row on tjma2001 table now
            If decTotal > "2001" Then 'Since distances larger then 2000 are displayed on the TJMA2001 timetravel table, make sure that the userlocation is not too far from the epicenter
                MessageBox.Show("Sucessfully Calculated Distance: " & decTotal & "." & " Could not find any timed forecast due to distance greater then 2000km from epicenter", "Distance Found - No Calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Not too long? Keep Calculating 'and we actually calculate here
                csvPath = appPath & "/assets/tjma2001.csv"

                Dim sr As New IO.StreamReader(csvPath, True)
                '     MessageBox.Show("Found positive match on row: " & getRow(sr, 0, 320), "Found Match", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '   MessageBox.Show("Sucessfully Calculated Distance and Arrival Time. Time is displayed on tjma2001 line: " & getRow(sr, 10, decTotal), "Sucesfully Calculated Distance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim FinalRowNum As String = getRow(sr, HypocenterDepth, decTotal) 'The row finally found containing the correct long/lat


                '===========

                Dim SimplifyRowNumber As String = FinalRowNum - 1
                ' Columns are the same, dont do math because we already know what columns we need //

                'Lets check for the column which contains the Arrival time for the ->P-WAVE FIR (since it is the first column)
                'Format of CSV Columns: {Arrival time of P-WAVE} {Arrival time for S-WAVE} {Hypocenter Depth} {Distance from Epicenter}

                Dim result As String = String.Empty
                Dim lines = File.ReadAllLines(csvPath)
                If SimplifyRowNumber < lines.Length Then
                    Dim cols = lines(SimplifyRowNumber).Split(","c)
                    If 0 < cols.Length Then
                        result = cols(0)
                    End If
                End If

                ' r1.Text = result

                Dim rawPWTime As String = result


                Dim resultb As String = String.Empty
                Dim linesb = File.ReadAllLines(csvPath)
                If SimplifyRowNumber < linesb.Length Then
                    Dim colsb = linesb(SimplifyRowNumber).Split(","c)
                    If 1 < colsb.Length Then
                        resultb = colsb(1)
                    End If
                End If

                '  r2.Text = resultb

                '  MessageBox.Show("Arrival time of P-WAVE Sucessfully Found: " & result & " Seconds" & vbCrLf & "Arrival time of S-WAVE Sucessfully Found: " & resultb & " Seconds", "FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) 'FINAL RESULT


                '   PrepareAndRoundResults(result, resultb)

                Dim rawSWTime As String = resultb
                Dim returnUnsplit As String = rawPWTime & "-" & rawSWTime

                Return returnUnsplit



            End If
        Catch ex As Exception
            Console.WriteLine("CALC ERROR", "Main Function Failed" + ex.Message)
            Return False

        End Try

        Return True

    End Function
End Class
