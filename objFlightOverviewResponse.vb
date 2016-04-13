Public Class objFlightOverviewResponse

    Public Class Rootobject
        Public Property MessageHeader As Messageheader
        Public Property FlightListings As Flightlistings
        Public Property FareCalendar As Object
    End Class

    Public Class Messageheader
        Public Property ClientInfo As Clientinfo
        Public Property MessageVersion As Object
        Public Property CreateDateTime As Object
        Public Property MessageGUID As Object
        Public Property TransactionGUID As String
    End Class

    Public Class Clientinfo
        Public Property DirectClientIP As Object
        Public Property DirectClientHostname As Object
        Public Property DirectClientName As String
        Public Property OriginalClientIP As Object
        Public Property OriginalClientHostname As Object
        Public Property OriginalClientName As Object
    End Class

    Public Class Flightlistings
        Public Property AirOfferSummary() As Airoffersummary
    End Class

    Public Class Airoffersummary
        Public Property FlightPriceSummary As Flightpricesummary
        Public Property FlightItinerarySummary As Flightitinerarysummary
        Public Property Timestamp As Date
        Public Property AirProductToken() As String
    End Class

    Public Class Flightpricesummary
        Public Property CurrencyCode As String
        Public Property TotalPrice As Single
    End Class

    Public Class Flightitinerarysummary
        Public Property OutboundDepartureAirlineCode As String
        Public Property OutboundDepartureAirportCode As String
        Public Property OutboundDepartureTime As Date
        Public Property OutboundStopCount As Integer
        Public Property InboundDepartureAirlineCode As String
        Public Property InboundDepartureAirportCode As String
        Public Property InboundDepartureTime As Date
        Public Property InboundStopCount As Integer
    End Class

End Class
