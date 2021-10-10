Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   colorProcessing.ProcessColor(Color.FromArgb(12, 12, 12), "uyes")
        'Form 1 actually has no point in existing. This will be deleted in the future if needed.
        'This will be used for production purposes only. 
        colorProcessing.RoundValue(12, True)
    End Sub
End Class
