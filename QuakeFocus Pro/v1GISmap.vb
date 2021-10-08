Public Class v1GISmap
    'The custom GIS map renderer custom control cannot be used, as it often attempts to reference the dlls in designer mode, which will cause issues with the application's startup position and crash the designer pane.
    Dim startupDIR As String = Application.StartupPath()
    Dim resourcePath As String = startupDIR & "/assets/boundry.shp"
    Private Sub v1GISmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SfMap1.ClearShapeFiles()
        SfMap1.AddShapeFile("C:\Users\admin\source\repos\QuakeFocus Pro\QuakeFocus Pro\bin\Debug\assets\boundry.shp", "ShapeFile", "")
    End Sub
End Class
