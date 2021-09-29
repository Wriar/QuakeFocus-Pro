Public Class v1GISmap
    Dim startupDIR As String = Application.StartupPath()
    Dim resourcePath As String = startupDIR & "/assets/boundry.shp"
    Private Sub v1GISmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SfMap1.ClearShapeFiles()
        SfMap1.AddShapeFile("C:\Users\natha\source\repos\QuakeFocus Pro\QuakeFocus Pro\bin\Debug\assets\boundry.shp", "ShapeFile", "")
    End Sub
End Class
