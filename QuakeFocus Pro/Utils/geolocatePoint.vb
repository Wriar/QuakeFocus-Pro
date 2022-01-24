Public Class geolocatePoint

    ''' <summary>
    ''' Provides a function for Geolocating a Point on SFMAP. QuakeFOCUS Pro uses EASYGIS utilities which does not account for distance drawing.
    ''' </summary>
    ''' <param name="startPoint">Initial Point (e.x Epicenter)</param>
    ''' <param name="initialBearingRadians">Give any Point. Straighter points allow for better calculation</param>
    ''' <param name="distanceKilometres">Distance (e.x total distance calculated from velocity table)</param>
    ''' <returns></returns>
    Public Shared Function FindPointAtDistanceFrom(ByVal startPoint As GeoLocation, ByVal initialBearingRadians As Double, ByVal distanceKilometres As Double) As GeoLocation
        Const radiusEarthKilometres As Double = 6371.01
        Dim distRatio = distanceKilometres / radiusEarthKilometres
        Dim distRatioSine = Math.Sin(distRatio)
        Dim distRatioCosine = Math.Cos(distRatio)
        Dim startLatRad = DegreesToRadians(startPoint.Latitude)
        Dim startLonRad = DegreesToRadians(startPoint.Longitude)
        Dim startLatCos = Math.Cos(startLatRad)
        Dim startLatSin = Math.Sin(startLatRad)
        Dim endLatRads = Math.Asin((startLatSin * distRatioCosine) + (startLatCos * distRatioSine * Math.Cos(initialBearingRadians)))
        Dim endLonRads = startLonRad + Math.Atan2(Math.Sin(initialBearingRadians) * distRatioSine * startLatCos, distRatioCosine - startLatSin * Math.Sin(endLatRads))
        Return New GeoLocation With {
            .Latitude = RadiansToDegrees(endLatRads),
            .Longitude = RadiansToDegrees(endLonRads)
        }
    End Function

    Public Structure GeoLocation
        Public Property Latitude As Double
        Public Property Longitude As Double
    End Structure

    Public Shared Function DegreesToRadians(ByVal degrees As Double) As Double
        Const degToRadFactor As Double = Math.PI / 180
        Return degrees * degToRadFactor
    End Function

    Public Shared Function RadiansToDegrees(ByVal radians As Double) As Double
        Const radToDegFactor As Double = 180 / Math.PI
        Return radians * radToDegFactor
    End Function

    Public Shared Function convertPointsToSfMapPixels(ByVal firstPoint As GeoLocation, ByVal secondPoint As GeoLocation)
        Dim sfPt1 As Point = viewPage.SfMap1.GisPointToPixelCoord(firstPoint.Longitude, firstPoint.Latitude)
        Dim sfPt2 As Point = viewPage.SfMap1.GisPointToPixelCoord(secondPoint.Longitude, secondPoint.Latitude)
        'Pixel Points Total
        Dim retDist As Double = distanceFormula(sfPt1, sfPt2)
        Return retDist

    End Function

    Public Shared Function distanceFormula(ByVal startPoint As Point, ByVal endPoint As Point) As Integer
        Return Math.Sqrt((Math.Abs(endPoint.X - startPoint.X) ^ 2) +
                   (Math.Abs(endPoint.Y - startPoint.Y) ^ 2))
    End Function

    'Main Function

    ''' <summary>
    ''' Convert a Longitude/Latitude Point and a Length (in Kilometers) to Pixel Points.
    ''' Returns Pixel Points of the Radius (if needed can use any point in place for CenterPoint Variable.
    ''' </summary>
    ''' <param name="centerPoint">Initial Point</param>
    ''' <param name="circleRadius">Distance in KM</param>
    ''' <returns></returns>
    Public Shared Function pixelPointFromDistance(centerPoint As GeoLocation, circleRadius As Double)
        'First get a relative point (can be any bearing)
        Dim relGeolocation As GeoLocation
        relGeolocation = FindPointAtDistanceFrom(centerPoint, 50, circleRadius) 'Computed Second Point

        'Convert both points to pixel coordinates
        Dim retDistance As Double = convertPointsToSfMapPixels(centerPoint, relGeolocation)
        Return retDistance
    End Function
End Class
