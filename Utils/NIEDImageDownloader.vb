Imports System.IO
Imports System.Net
Imports System.Threading

Public Class NIEDImageDownloader
    Private tokyoClient As WebClient
    Private cts As CancellationTokenSource = Nothing

    Public Sub StartDownload(canvas As PictureBox, intervalSeconds As Integer, serverTimeDelaySeconds As Integer)
        cts = New CancellationTokenSource()
        tokyoClient = New WebClient()
        Task.Run(Function() DownloadAsync(canvas, intervalSeconds, serverTimeDelaySeconds))

    End Sub

    Private Async Function DownloadAsync(canvas As PictureBox, intervalSeconds As Integer, serverTimeDelaySeconds As Integer) As Task
        Dim downloadTimeWatch As Stopwatch = New Stopwatch()
        downloadTimeWatch.Start()
        Do
            If cts.IsCancellationRequested Then Return
            Dim TokyoOffset = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.Now, TimeZoneInfo.Local.Id, "Tokyo Standard Time")
            ' Dim currentImage As String = TokyoOffset.AddSeconds(-serverTimeDelaySeconds).ToString("yyyyMMdd/yyyyMMddHHmmss")
            Dim currentImage As String = My.Settings.privateImgDate & "/" & My.Settings.privateImgDateTime



            '      Console.WriteLine("CURRENT IMAGE IS " & currentImage)

            Dim url = New Uri(My.Settings.dataChannel & "/RealTimeImg/jma_s/" & currentImage & ".jma_s.gif")

            Console.WriteLine("Attempting to Download RealtimeData: " + url.ToString())

            Try
                Dim data = Await tokyoClient.DownloadDataTaskAsync(url)
                canvas.BeginInvoke(New MethodInvoker(
                    Sub()
                        canvas.Image?.Dispose()
                        canvas.Image = Image.FromStream(New MemoryStream(data))
                    End Sub))
                'TEST

                Await Task.Delay((intervalSeconds * 1000) - CInt(downloadTimeWatch.ElapsedMilliseconds))
                downloadTimeWatch.Restart()
            Catch wEx As WebException
                Console.WriteLine(wEx.Message)
                '  Process.RetryDownloadNIEDingest() 'attempt to restart download

                Console.WriteLine("DOWNLOAD FAILED: REASON: " & wEx.Message)

            End Try
        Loop
    End Function

    Public Sub StopDownload()
        cts.Cancel()
        tokyoClient?.CancelAsync()
        tokyoClient?.Dispose()
        cts?.Dispose()
    End Sub
End Class
