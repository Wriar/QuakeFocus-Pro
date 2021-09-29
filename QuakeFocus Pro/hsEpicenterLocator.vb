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
        Dim csvPath As String = Application.StartupPath & "/assets/vjma2001.csv"
        Dim sr As New IO.StreamReader(csvPath, True)
        Dim rowNum As Integer = getRow(sr, depth, 3)
        sr.Close()

        Return GetValue(rowNum - 1, 0)
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
End Class
