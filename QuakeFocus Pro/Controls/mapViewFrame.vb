Imports System.Runtime.InteropServices 'Import Interop Services
Public Class mapViewFrame
#Region "Import IViewObject With InteropService"
    <ComImport()>
    <Guid("0000010d-0000-0000-C000-000000000046")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Public Interface IViewObject
        <PreserveSig>
        Function Draw(dwDrawAspect As UInteger, lindex As Integer, pvAspect As IntPtr, ptd As IntPtr, hdcTargetDev As IntPtr, hdcDraw As IntPtr, lprcBounds As Rectangle,
                       lprcWBounds As IntPtr, pfnContinue As IntPtr, dwContinue As Integer) As Integer
        Function GetColorSet(dwDrawAspect As UInteger, lindex As Integer, pvAspect As IntPtr, ptd As IntPtr, hicTargetDev As IntPtr, <Out> ppColorSet As IntPtr) As Integer
        Function Freeze(dwDrawAspect As UInteger, lindex As Integer, pvAspect As IntPtr, <Out> pdwFreeze As UInteger) As Integer
        Function Unfreeze(dwFreeze As UInteger) As Integer
        Function SetAdvise(aspects As UInteger, advf As UInteger, pAdvSink As IntPtr) As Integer
        Function GetAdvise(<Out> pAspects As UInteger, <Out> pAdvf As UInteger, <Out> ppAdvSink As IntPtr) As Integer
    End Interface

    Public Enum DVASPECT
        DVASPECT_CONTENT = 1
        DVASPECT_THUMBNAIL = 2
        DVASPECT_ICON = 4
        DVASPECT_DOCPRINT = 8
    End Enum
#End Region
#Region "Dragging Options"
    Dim IsDragging As Boolean
    Private StartPoint As Point

    Private Sub ViewPoint_MouseMove(sender As Object, e As MouseEventArgs) Handles ViewPoint.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = ViewPoint.PointToScreen(New Point(e.X, e.Y))
            ViewPoint.Left += (EndPoint.X - StartPoint.X)
            ViewPoint.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
        End If
    End Sub

    Private Sub ViewPoint_MouseDown(sender As Object, e As MouseEventArgs) Handles ViewPoint.MouseDown
        StartPoint = ViewPoint.PointToScreen(New Point(e.X, e.Y))
        IsDragging = True

        ViewPoint.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub ViewPoint_MouseUp(sender As Object, e As MouseEventArgs) Handles ViewPoint.MouseUp
        IsDragging = False
        ViewPoint.Cursor = Cursors.Default
    End Sub

#End Region

    Private Sub mapViewFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScrollBarsEnabled = False

    End Sub

    Private Sub ViewPoint_Click(sender As Object, e As EventArgs) Handles ViewPoint.Click

    End Sub

    Private Sub ViewPoint_Paint(sender As Object, e As PaintEventArgs) Handles ViewPoint.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawEllipse(New Pen(Color.Red, 10.0F), 50, 50, ViewPoint.Size.Width - 100, ViewPoint.Size.Height - 100)

    End Sub
    Dim zFactor As Integer = 100
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Dim browser = TryCast(WebBrowser1.ActiveXInstance, SHDocVw.InternetExplorer)
        browser.ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, zFactor, IntPtr.Zero)

        AddHandler WebBrowser1.Document.MouseDown, AddressOf WebBrowser1_MouseDown




    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

    End Sub

    Private Sub WebBrowser1_Resize(sender As Object, e As EventArgs) Handles WebBrowser1.Resize



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nWidth = 1000
        Dim nHeight = 1000
        Dim bmp = New Bitmap(nWidth, nHeight)
        Dim gr As Graphics = Graphics.FromImage(bmp)
        Dim hDC = gr.GetHdc()
        Dim rc = New Rectangle(0, 0, nWidth, nHeight)
        Dim viewObject = CType(WebBrowser1.Document.DomDocument, IViewObject)
        viewObject.Draw(DVASPECT.DVASPECT_CONTENT, -1, CType(0, IntPtr), CType(0, IntPtr), CType(0, IntPtr), hDC, rc, CType(0, IntPtr), CType(0, IntPtr), 0)
        gr.ReleaseHdc(hDC)
        ViewPoint.Image = bmp
    End Sub


    Private Sub WebBrowser1_MouseDown(sender As Object, e As HtmlElementEventArgs)
        Dim nWidth = 1000
        Dim nHeight = 1000
        Dim bmp = New Bitmap(nWidth, nHeight)
        Dim gr As Graphics = Graphics.FromImage(bmp)
        Dim hDC = gr.GetHdc()
        Dim rc = New Rectangle(0, 0, nWidth, nHeight)
        Dim viewObject = CType(WebBrowser1.Document.DomDocument, IViewObject)
        viewObject.Draw(DVASPECT.DVASPECT_CONTENT, -1, CType(0, IntPtr), CType(0, IntPtr), CType(0, IntPtr), hDC, rc, CType(0, IntPtr), CType(0, IntPtr), 0)
        gr.ReleaseHdc(hDC)
        ViewPoint.Image = bmp
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        zFactor = 200
        WebBrowser1.Refresh()
    End Sub
End Class
