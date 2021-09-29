Public Class errorHandler

    'Allowed Error Types: 'code'-> Fatal Error with Code (e.x Convert letter to Integer)
    '                     'service' -> Non-Fatal Errors (error contacting API, internet connection not available)
    '                     'info' -> Informational Only (Checked for updates..)



    ''' <summary>
    ''' Use Custom Error Handling.
    ''' errtype: (code, service, info)
    ''' errorContent: (use any string)
    ''' e (boolean), true-> require app shutdown.
    ''' </summary>
    ''' 
    Public Shared Sub HandleError(errType As String, errContent As String, e As Boolean)


        Dim applicationPath As String = Application.StartupPath()
        Dim errorLogPath As String = applicationPath & "\logs"


        If errType = "code" Then
            'Log Fatal Error.
            Console.WriteLine("A Fatal Exception Was Thrown. The Error Content IS: " & errContent)

            Dim filepath As String = errorLogPath & "\errors.log"

            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
            End If

            'Append Error

            Dim objWriter As New System.IO.StreamWriter(filepath, IO.FileMode.Append)
            Dim dT As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")



            objWriter.WriteLine("[" & dT & "] " & "A FATAL ERROR HAS OCCURED. Please view content:: " & errContent)

            objWriter.Close()

            MessageBox.Show("A Fatal Error has occurred within QuakeFocus Pro. Please restart your application. If you continue yo see this Error, please create an issue on the project's GitHub and upload your logfile in logs\errors.log. " & vbCrLf & vbCrLf & "QuakeFocus Proで致命的なエラーが発生しました。アプリケーションを再起動してください。引き続きこのエラーが表示される場合は、このプロジェクトのGitHubに新しい問題を作成してください。ログファイルがGitHubの課題に添付されていることを確認してください (logs\error.log)" & vbCrLf & vbCrLf & "View ""logs\errors.log"" for more information." & vbCrLf & vbCrLf & "詳細は「logs\errors.log」をご覧ください。", "Critical Error / エラー @ " & "[" & dT & "] ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If e = True Then
                Application.Exit()
            Else

            End If

        End If
    End Sub
End Class
