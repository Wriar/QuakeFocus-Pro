Public Class line
    Public ReadOnly Property StartPoint As Point

    Public ReadOnly Property EndPoint As Point

    Public Sub New(startPoint As Point, endPoint As Point)
        Me.StartPoint = startPoint
        Me.EndPoint = endPoint
    End Sub
End Class
