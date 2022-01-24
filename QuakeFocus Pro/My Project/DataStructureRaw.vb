Public Class DataStructureRaw
    'This class contains the raw data for each aspect. Processed data structure will call this instance.

    Public htAvg As Decimal
    Public kantoAvg As Decimal
    Public ChubuAvg As Decimal
    Public kansaiAvg As Decimal
    Public ChShAvg As Decimal
    Public KyushuAvg As Decimal

    Public Shared reportTime As String
    Public Shared requestTime As String
    Public Shared regionNameJP As String
    Public Shared longitude As String
    Public Shared latitude As Double
    Public Shared isCancel As String
    Public Shared depthOrigin As String
    Public Shared calcIntensity As String
    Public Shared isFinal As String
    Public Shared isTraining As String
    Public Shared originTime As String
    Public Shared magunitude As String
    Public Shared reportNumber As String
    Public Shared reportId As String
    Public Shared alertFlagOrigin As String

    Public Shared eqUrlTime As DateTime

    'Raw Production Timings
    Public Shared sWaveRawArrivalTime As String
    Public Shared pWaveRawArrivalTime As String

    'Total Earthquake Elapsed Time
    Public Shared eqElapsedSeconds As Integer



    'P-Wave and S-Wave Velocities. Should be in form km/seconds
    Public Shared pWaveVelocity As String
    Public Shared sWaveVelocity As String

    'P-Wave and S-Wave Radius
    Public Shared pWaveRadius As String
    Public Shared sWaveRadius As String

    'Pixels to draw (on p/swaves) PER SECOND
    Public Shared pwPixelDrawPerSec As String
    Public Shared swPixelDrawPerSec As String

    'Pixels to draw (on p/swaves) PER 1/10 SECOND
    Public Shared pwPixelDrawPerTenthSec As String
    Public Shared swPixelDrawPerTenthSec As String

    'Total Pixels used by viewPage Refreshing
    Public Shared pwTotalPixelRadius As String
    Public Shared swTotalPixelRadius As String


    'Shared URLS
    Public Shared kmoniBasePath As String = "http://www.kmoni.bosai.go.jp/webservice/hypo/eew/"
End Class
