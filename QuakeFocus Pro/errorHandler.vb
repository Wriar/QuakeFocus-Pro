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
        'Message boxes are not required to be shown when the fail error level is either an informational report or a service. 
        'Message boxes and detailed error reports are shown when the application encounters a critical error, often marked by the CODE attribute. 
        

        Dim applicationPath As String = Application.StartupPath()
        Dim errorLogPath As String = applicationPath & "\logs"
        'Set the initial path to save the log file. It should be saved in the application path / logs folder. 

        If errType = "code" Then
            'Log Fatal Error.
            Console.WriteLine("A Fatal Exception Was Thrown. The Error Content IS: " & errContent)
            'A code error is a fatal error often having to do with the code within the application. 
            'Errors that look like these often have code based errors, such as "Index out of Range" or NullReferenceException type errors. 
            'Memory errors and StackOverflow based errors may not throw a code exception, but rather use default .NET handling instead. 
            Dim filepath As String = errorLogPath & "\errors.log"

            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
                
            End If

            'Append Error

            Dim objWriter As New System.IO.StreamWriter(filepath, IO.FileMode.Append)
            Dim dT As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

            'The date and OBJ writer time muts be prepared in order to create the correct date and time log. 

            objWriter.WriteLine("[" & dT & "] " & "A FATAL ERROR HAS OCCURED. Please view content:: " & errContent)
            'Write some contents to the file. This is the heading information, including the error content. Fatal errors should be reported in GitHub.
            
            objWriter.Close()
            'Close the file writer. It is not required, but it is good practice.
            'Inform applicaiton user that a fatal error has occured. 
            MessageBox.Show("A Fatal Error has occurred within QuakeFocus Pro. Please restart your application. If you continue to see this Error, please create an issue on the project's GitHub and upload your logfile in logs\errors.log. " & vbCrLf & vbCrLf & "QuakeFocus Proで致命的なエラーが発生しました。アプリケーションを再起動してください。引き続きこのエラーが表示される場合は、このプロジェクトのGitHubに新しい問題を作成してください。ログファイルがGitHubの課題に添付されていることを確認してください (logs\error.log)" & vbCrLf & vbCrLf & "View ""logs\errors.log"" for more information." & vbCrLf & vbCrLf & "詳細は「logs\errors.log」をご覧ください。", "Critical Error / エラー @ " & "[" & dT & "] ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If e = True Then
                'The third argument is called to force the application to exit, often because a huge consequence may be encountered if the aplication is not closed. 
                Application.Exit()
            Else
                'The application will not close. 
            End If

        End If
    End Sub
End Class
