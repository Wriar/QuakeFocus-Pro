Public Class pointDecoder
    Public currentPointValList As List(Of Tuple(Of String, String, String, String, Point, String, String))
    'List Of Point Variables:
    'Station Name ENG Area Name, Station Prefecture ENG Name, Station Name JP Area Name, Station Name JP Prefecture, Station Point in Relation to NIED XY, Raw INT Val, Raw PGA Val.

    'Note: PGA and REALTIME Raw Values must be saved as string variables to prevent accidental trimming




    'DEPRECATED NO ONE USES THIS EVER
    Public Shared Function getPointVal(simplify As Boolean, type As String)

    End Function


    Private Sub ImportTable()

    End Sub

    'Function to draw a point


End Class
