Public Class objTrendResponse

    Public Class Rootobject
        Public Property recommended As Recommended
    End Class

    Public Class Recommended
        Public Property aggType As String
        Public Property departDate As String
        Public Property origin As String
        Public Property destination As String
        Public Property tpid As Integer
        Public Property travelClass As String
        Public Property tripType As String
        Public Property priceMovement As Pricemovement
        Public Property trends As List(Of Trend)
        Public Property predictionNextWeek As Predictionnextweek
    End Class

    Public Class Pricemovement
        Public Property deltaMRLR As Deltamrlr
        Public Property mostDecrease As Mostdecrease
    End Class

    Public Class Deltamrlr
        Public Property fromSearchDate As String
        Public Property toSearchDate As String
        Public Property numDays As Integer
        Public Property delta As String
        Public Property deltaPercent As String
    End Class

    Public Class Mostdecrease
        Public Property fromSearchDate As String
        Public Property toSearchDate As String
        Public Property numDays As Integer
        Public Property delta As String
        Public Property deltaPercent As String
    End Class

    Public Class Predictionnextweek
        Public Property prediction As Single
        Public Property confidence As Single
        Public Property departWeek As String
        Public Property apWeek As Integer
    End Class

    Public Class Trend
        Public Property searchDate As String
        Public Property min As String
        Public Property median As String
        Public Property max As String
        Public Property normalizedMin As String
        Public Property normalizedMedian As String
        Public Property normalizedMax As String
        Public Property sampleCount As Integer
        Public Property searchCount As Integer
    End Class

End Class
