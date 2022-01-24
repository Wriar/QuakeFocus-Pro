Public Class viewPageLocalMonitor
    Private lines As New List(Of line)

    Dim xint As Integer = 1

    Public penColor As Color

    Private Sub viewPageLocalMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        penColor = Color.White

        Dim lstColors As New List(Of Color)
        lstColors.Add(Color.FromArgb(0, 0, 255))
        lstColors.Add(Color.FromArgb(56, 254, 64))
        lstColors.Add(Color.FromArgb(176, 254, 16))
        lstColors.Add(Color.FromArgb(253, 252, 0))
        lstColors.Add(Color.FromArgb(255, 214, 0))
        lstColors.Add(Color.FromArgb(255, 237, 0))
        lstColors.Add(Color.FromArgb(254, 61, 0))
        lstColors.Add(Color.FromArgb(247, 5, 0))
        lstColors.Add(Color.FromArgb(185, 0, 0))
        ColorBar1.ColorList = lstColors
        demoLineAdd.Start()
    End Sub

    Private Sub AddNewLine(startPoint As Point, endPoint As Point)
        lines.Add(New line(startPoint, endPoint))
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim newPen As New Pen(penColor)
        For Each line In lines
            e.Graphics.DrawLine(newPen, line.StartPoint, line.EndPoint)
        Next
    End Sub

    Private Sub demoLineAdd_Tick(sender As Object, e As EventArgs) Handles demoLineAdd.Tick
        '  Dim r As Random = New Random
        xint = xint + 2
        Dim Point1 As New Point(xint, PictureBox1.Height)

        Dim rawPGA As String = viewPage.localPga.pgaLbl.Text
        Dim multPGA As String = rawPGA * 100
        Dim trimPGA As Integer = CInt(multPGA)


        Dim point2 As New Point(xint, PictureBox1.Height - trimPGA) 'Invert


        AddNewLine(Point1, point2)
        PictureBox1.Left -= 1 'Move the PictureBox Left

        PictureBox1.Size = New Size(PictureBox1.Size.Width + 1, PictureBox1.Height) 'Change its size to allow for continuous line drawing 

        'Set hINT Lbl:

        Dim intSetRealtime As Integer = viewPage.localPga.intLbl.Text 'Import Decimal Long to Int
        Dim intSetfix As String 'Prepare to trim Negatives

        If intSetRealtime < 1 Then
            intSetfix = 0
            hIntLbl.Text = intSetfix

        Else
            intSetfix = colorProcessing.ReturnPlusMinusJma(intSetRealtime)
            hIntLbl.Text = intSetfix

        End If

        'Fix Color
        pbIntColor.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intSetfix)


    End Sub
End Class
