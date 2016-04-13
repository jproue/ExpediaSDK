Public Class objUnrealDealRequest
    Public Class Rootobject
        Public Sub New(originAirportCode As String, destinationAirportCode As String, startDate As String, endDate As String, lengthOfStay As String, numResults As String)
            Me.OriginAirportCode = originAirportCode
            Me.DestinationAirportCode = destinationAirportCode
            Me.StartDate = startDate
            Me.EndDate = endDate
            Me.LengthOfStay = lengthOfStay
            Me.NumResults = numResults
        End Sub

        Public Property OriginAirportCode As String
        Public Property DestinationAirportCode As String
        Public Property StartDate As String
        Public Property EndDate As String
        Public Property LengthOfStay As String
        Public Property NumResults As String

    End Class
End Class
