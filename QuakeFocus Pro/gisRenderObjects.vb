Public Class gisRenderObjects
    Public pColorList As List(Of Tuple(Of String, String, String, Color, String, String))
    'F1: Alert Type (realTime, measured, measuredCombo, expected)
    'F2: Value (For Measured Intensity)
    'F3: Value (For Expected Intensity)
    'F4: Color Value (For Realtime)
    'F5-6: Longitude/Latitude

    Public Function addValueToIList(alertType As String, measuredIntensity As String, expectedIntensity As String, measuredColor As String, longitude As String, latitude As String)
        If alertType = "realTime" Then
            '  pColorList.Add(Tuple.Create("realtime", "0", "0", "0", "0"))


        End If
    End Function

End Class
