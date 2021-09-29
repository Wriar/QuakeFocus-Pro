Imports KyoshinMonitorLib.Images
Public Class colorProcessing


    Public Shared Function ProcessColor(colorIN As Color, dataType As String, roundType As Boolean, Optional ByVal addPlusMinus As Boolean = True)

        '////////////// INFO //////////
        ' SIXTH-ORDER POLYNOMIAL INTERPOLATION OF H,S,V GRIDS IS CREDITED TO Francois L.N. via KyoshinMonitorLib
        ' KyoshinMonitorLib is Licensed under the MIT license.

        ' View More Information from @NoneType1
        '///////////////////////////////


        '********* POSSIBLE VALUES *********
        ' jma -> REALTIME INTENSITY
        ' pga -> PEAK GROUND ACCELERATION
        ' pgd -> MAXIMUM DISPLACEMENT
        ' pgv -> MAXIMUM SPEED
        '
        '   --> HZ RESPONSE GRIDS USES SAME INTERPOLATION AS PGV (MAX SPEED) <-
        '
        ' MASTER: hz -> Any HZ Response Grids
        '
        ' 0.125hz -> 0.125 Hertz Response Grid 
        ' 0.25hz -> 0.125 Hertz Response Grid
        ' 0.5hz -> 0.5 Hertz Response Grid
        ' 1hz -> 1.0 Hertz Response Grid
        ' 2hz -> 2.0 Hertz Response Grid
        ' 4hz -> 4.0 Hertz Response Grid
        '
        '*************************************
        Try
            'Only Using PGA and JMA values when adding to list

            Dim seed As Double 'Create Seed. Seed is not useful for anything except to begin interpolation.

            seed = ColorConverter.ConvertToScaleAtPolynomialInterpolation(colorIN) 'Create Seed
            If roundType = False Then
                If dataType = "jma" Then
                    Return ColorConverter.ConvertToIntensityFromScale(seed)

                ElseIf dataType = "pga" Then
                    Return ColorConverter.ConvertToPgaFromScale(seed)
                ElseIf dataType = "pgd" Then
                    Return ColorConverter.ConvertToPgdFromScale(seed)
                ElseIf dataType = "pgv" Then
                    Return ColorConverter.ConvertToPgvFromScale(seed)
                ElseIf dataType = "hz" Then
                    Return ColorConverter.ConvertToPgvFromScale(seed)
                Else
                    Return False

                End If

            Else

            End If

        Catch errInfo As Exception
            errorHandler.HandleError("code", errInfo.Message(), False)
        End Try



    End Function

    Public Shared Function ReturnTileColorJMAplusMinus(colorIn As String)
        'Return the JMA tile Color relative to the Plus/Minus Form of the Color

        Dim rawOut As Color
        If colorIn = "0-" Or colorIn = "0+" Or colorIn = "0" Or colorIn = "1+" Or colorIn = "1-" Or colorIn = "1" Or colorIn = "-1" Or colorIn = "-2" Or colorIn = "-3" Then
            rawOut = Color.FromArgb(107, 120, 121) 'Gray
            Return rawOut

        ElseIf colorIn = "2-" Or colorIn = "2+" Or colorIn = "2" Then
            rawOut = Color.FromArgb(21, 108, 166)
            Return rawOut

        ElseIf colorIn = "3-" Or colorIn = "3+" Or colorIn = "3" Then
            rawOut = Color.FromArgb(20, 154, 76)
            Return rawOut

        ElseIf colorIn = "4-" Or colorIn = "4+" Or colorIn = "4" Then
            rawOut = Color.FromArgb(200, 156, 0)
            Return rawOut

        ElseIf colorIn = "5-" Then
            rawOut = Color.FromArgb(230, 138, 46)
            Return rawOut

        ElseIf colorIn = "5+" Then
            rawOut = Color.FromArgb(200, 106, 14)
            Return rawOut

        ElseIf colorIn = "6-" Then
            rawOut = Color.FromArgb(236, 26, 0)
            Return rawOut

        ElseIf colorIn = "6+" Then
            rawOut = Color.FromArgb(166, 2, 7)
            Return rawOut

        ElseIf colorIn = "7-" Or colorIn = "7+" Then
            rawOut = Color.FromArgb(150, 0, 151)
            Console.WriteLine("COLORIN RETURNED 7")
            Return rawOut
        Else
            rawOut = Color.FromArgb(107, 120, 121) 'Gray
            Console.WriteLine("else because ColorIn Was" & colorIn)
            Return rawOut
        End If

        Return False
    End Function

    Public Shared Function ReturnPlusMinusJma(intIn As String)
        If intIn < 1 Then
            Return "0"
        ElseIf intIn >= 1 And intIn < 2 Then
            Return "1"
        ElseIf intIn >= 2 And intIn < 3 Then
            Return "2"
        ElseIf intIn >= 3 And intIn < 4 Then
            Return "3"
        ElseIf intIn >= 4 And intIn < 5 Then
            Return "4"
        ElseIf intIn >= 5 And intIn < 5.5 Then
            Return "5-"
        ElseIf intIn >= 5.5 And intIn < 6 Then
            Return "5+"
        ElseIf intIn >= 6 And intIn < 6.5 Then
            Return "6-"
        ElseIf intIn >= 6.5 And intIn < 7 Then
            Return "6+"
        ElseIf intIn >= 7 Then
            Return 7

        Else
            Return 0
        End If

    End Function

    Public Shared Function RoundValue(rawVal As Double, appendPlusMinus As Boolean)
        errorHandler.HandleError("code", "test", False)
    End Function


End Class
