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
    Public Shared latitude As String
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

    'Raw Production Timings
    Public Shared sWaveRawArrivalTime As String
    Public Shared pWaveRawArrivalTime As String

    'P-Wave and S-Wave Velocities
    Public Shared pWaveVelocity As Double
    Public Shared sWaveVelocity As Double

    'P-Wave and S-Wave Radius
    Public Shared pWaveRadius As Double
    Public Shared sWaveRadius As Double

End Class
