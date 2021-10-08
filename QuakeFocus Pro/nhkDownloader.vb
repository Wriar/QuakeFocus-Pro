Imports System.IO

Public Class nhkDownloader
    Private Sub nhkDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Don't do anyting here because no action is required in the load event. 
    End Sub

    ''' <summary>
    ''' Loads the Image into the image viewer.
    ''' Returns False if Error exists.
    ''' </summary>

    Public Function loadIMG(type As String, showForm As Boolean)
        Try
            'this function is called from the other form. 

            If type = "l" Then 'Type Local
                PictureBox1.Load(My.Settings.nhkL)
                If showForm = True Then
                    Me.Show()
                End If
                Return True
                Exit Function
            ElseIf type = "d" Then
                PictureBox1.Load(My.Settings.nhkD)
                If showForm = True Then
                    Me.Show()
                End If
                Return True
                Exit Function
            ElseIf type = "g" Then
                PictureBox1.Load(My.Settings.nhkG)
                If showForm = True Then
                    Me.Show()
                End If
                Return True
                Exit Function

            Else
                errorHandler.HandleError("service", "NHK Image Incorrect Argument Supplied. Expected l/d/g, got " & type, False)
                            'Detail referrer should supply a Local/Detail/Global argument. If it is not supplied, there is a serious issue with the modified source code.
                Return False
                Exit Function
            End If

        Catch ex As Exception
                            MessageBox.show("Cannot download image. Please check your internet connection./画像をダウンロードできません。インターネットの接続状況を確認してください", "ERROR", MessageBoxButtons.OK, messageBoxIcon.Asterisk) 
            errorHandler.HandleError("service", "Could not download NHK Image. Details: " & ex.Message, False)
                            'Likley an internet issue.
            Return False
            Exit Function
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
                            ' Button to save the NHK Report to a local file. 
                            
                            'Create file stream to save the dialog information 
        Dim myStream As Stream
                            'Create the new Save File Dialog instance 
        Dim saveFileDialog1 As New SaveFileDialog()
                            'Set SFD Filters
        saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.Title = "Save As (NHK Report)/名前を付けて保存(NHKレポート)"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim filea = Path.GetFullPath(saveFileDialog1.FileName)
                Console.WriteLine(filea)
                Dim demo As New Bitmap(PictureBox1.Image)
            demo.Save(filea)
                                'An else loop is not required here as nothing should be done here. 
            MessageBox.Show("Image sucessfully saved to/画像の保存先: " & vbCrLf & vbCrLf & filea, "Report Saved/保存", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

End Class
