Public Class objFlightQueryResponse


    Public Class Rootobject
        Public Property legs As List(Of Leg)
        Public Property offers As List(Of Offer)
        Public Property searchCities As List(Of Searchcity)
        Public Property obFeesDetails As String
        Public Property activityId As String
        Public Property deepLinkUrl As String
        Public Property ErrorMessage As String
    End Class

    Public Class Leg
        Public Property legId As String
        Public Property baggageFeesUrl As String
        Public Property segments As List(Of Segment)
        Public Property freeCancellationBy As Freecancellationby
    End Class

    Public Class Freecancellationby
        Public Property raw As Date
        Public Property localized As String
        Public Property epochSeconds As Integer
        Public Property timeZoneOffsetSeconds As Integer
        Public Property localizedShortDate As String
    End Class

    Public Class Segment
        Public Property departureTime As String
        Public Property departureTimeEpochSeconds As Integer
        Public Property departureTimeRaw As Date
        Public Property departureTimeZoneOffsetSeconds As Integer
        Public Property arrivalTime As String
        Public Property arrivalTimeEpochSeconds As Integer
        Public Property arrivalTimeRaw As Date
        Public Property arrivalTimeZoneOffsetSeconds As Integer
        Public Property arrivalAirportCode As String
        Public Property arrivalAirportLocation As String
        Public Property departureAirportCode As String
        Public Property departureAirportLocation As String
        Public Property airlineName As String
        Public Property airlineCode As String
        Public Property flightNumber As String
        Public Property onTimePercentage As String
        Public Property equipmentCode As String
        Public Property equipmentDescription As String
        Public Property duration As String
        Public Property distance As Integer
        Public Property distanceUnits As String
        Public Property stops As Integer
        Public Property meal As String
        Public Property operatingAirlineName As String
        Public Property operatingAirlineCode As String
    End Class

    Public Class Offer
        Public Property legIds As List(Of String)
        Public Property currency As String
        Public Property baseFare As String
        Public Property baseFarePrice As Basefareprice
        Public Property totalFare As String
        Public Property totalFarePrice As Totalfareprice
        Public Property pricePerPassengerCategory As List(Of Priceperpassengercategory)
        Public Property averageTotalPricePerTicket As Averagetotalpriceperticket
        Public Property numberOfTickets As Integer
        Public Property taxes As String
        Public Property taxesPrice As Taxesprice
        Public Property fees As String
        Public Property feesPrice As Feesprice
        Public Property showFees As Boolean
        Public Property productKey As String
        Public Property mobileShoppingKey As String
        Public Property seatsRemaining As Integer
        Public Property segmentAttributes As List(Of List(Of Segmentattribute))
        Public Property baggageFeesUrl As String
        Public Property fareType As String
        Public Property isInternational As Boolean
        Public Property isPassportNeeded As Boolean
        Public Property mayChargeOBFees As Boolean
        Public Property hasBagFee As Boolean
        Public Property hasNoBagFee As Boolean
        Public Property isSplitTicket As Boolean
        Public Property detailsUrl As String
    End Class

    Public Class Basefareprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Totalfareprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Averagetotalpriceperticket
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Taxesprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Feesprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Priceperpassengercategory
        Public Property passengerCategory As String
        Public Property totalPrice As Totalprice
        Public Property basePrice As Baseprice
        Public Property taxesPrice As Taxesprice1
    End Class

    Public Class Totalprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Baseprice
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Taxesprice1
        Public Property amount As String
        Public Property formattedPrice As String
        Public Property formattedWholePrice As String
        Public Property currencyCode As String
    End Class

    Public Class Segmentattribute
        Public Property bookingCode As String
        Public Property cabinCode As String
    End Class

    Public Class Searchcity
        Public Property code As String
        Public Property city As String
        Public Property province As String
        Public Property country As String
        Public Property searchType As String
    End Class
End Class
