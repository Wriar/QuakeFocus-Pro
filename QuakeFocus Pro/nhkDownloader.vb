Imports System.IO

Public Class nhkDownloader
    Private Sub nhkDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Loads the Image into the image viewer.
    ''' Returns False if Error exists.
    ''' </summary>

    Public Function loadIMG(type As String, showForm As Boolean)
        Try


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
                Return False
                Exit Function
            End If

        Catch ex As Exception
            errorHandler.HandleError("service", "Could not download NHK Image. Details: " & ex.Message, False)
            Return False
            Exit Function
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.Title = "Save As (NHK Report)"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim filea = Path.GetFullPath(saveFileDialog1.FileName)
                Console.WriteLine(filea)
                Dim demo As New Bitmap(PictureBox1.Image)
            demo.Save(filea)

            MessageBox.Show("Image sucessfully saved to: " & vbCrLf & vbCrLf & filea, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

End Class