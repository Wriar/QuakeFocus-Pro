Imports System.IO

Public Class translationSource

    Public Shared Function DecodeEpicenterToEnglish(epicenterJP As String)
        Dim translationAppPath As String = Application.StartupPath & "/assets/epicenterTranslations.csv"
        Dim sr As New IO.StreamReader(translationAppPath, True)
        Dim rowNum As Integer = getRow(sr, epicenterJP, 2)
        '  Console.WriteLine(rowNum)
        If rowNum <> 9999 Then
            'proceed
            '     Console.WriteLine("English Translation Is: " & GetValueOfEpicenterTranslation(rowNum - 1, 2)) 'CAUTION: COLUMN STARTS AT ZERO.
            Return GetValueOfEpicenterTranslation(rowNum - 1, 2)

        Else
            Return "Unknown Location"

            '  MsgBox("Attempted to translate " & epicenterJP & " but no translation was found.")
        End If





    End Function

    Public Shared Function GetValueOfEpicenterTranslation(row As Integer, col As Integer) As String
        Try
            Dim csvPath = Application.StartupPath & "/assets/epicenterTranslations.csv"
            Dim result As String = String.Empty
            Dim lines = File.ReadAllLines(csvPath)
            If row < lines.Length Then
                Dim cols = lines(row).Split(","c)
                If col < cols.Length Then
                    result = cols(col)
                End If
            End If
            Return result
        Catch ex As Exception
            errorHandler.HandleError("code", "no", True)
        End Try

    End Function

    Public Shared Function getRow(csv As StreamReader, v1 As String, Col1 As Integer) As Long

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

        Return 9999 'not found
    End Function

End Class
