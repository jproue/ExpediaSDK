Public Class objPriceRangeResponse


    Public Class Rootobject
        Public Property sampleWindow As Integer
        Public Property [From] As FlyFrom
        Public Property [To] As FlyTo
        Public Property apWindow As Apwindow
        Public Property trendData As Trenddata
    End Class

    Public Class FlyFrom
        Public Property name As String
        Public Property type As String
    End Class

    Public Class FlyTo
        Public Property name As String
        Public Property type As String
    End Class

    Public Class Apwindow
        Public Property begin As Integer
        Public Property _end As Integer
    End Class

    Public Class Trenddata
        Public Property min As Single
        Public Property max As Single
        Public Property median As Single
        Public Property sampleSize As Integer
    End Class
End Class
