Public Class objPackageResponse

    Public Class Rootobject
        Public Property PackageSearchResultList As Packagesearchresultlist
        Public Property FlightList As Flightlist
        Public Property HotelList As Hotellist
        Public Property ErrorMessage As String
    End Class

    Public Class Packagesearchresultlist
        Public Property PackageSearchResult As List(Of Packagesearchresult)
    End Class

    Public Class Packagesearchresult
        Public Property FlightReferenceIndex As String
        Public Property HotelReferenceIndex As String
        Public Property PackagePrice As Packageprice
        Public Property BrandedDealsMarker As Brandeddealsmarker
        Public Property DetailsUrl As String
    End Class

    Public Class Packageprice
        Public Property TotalPrice As Totalprice
        Public Property TotalSavings As Totalsavings
    End Class

    Public Class Totalprice
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalsavings
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Brandeddealsmarker
        Public Property BrandedDealsType As Object
    End Class

    Public Class Flightlist
        Public Property Flight As Flight
    End Class

    Public Class Flight
        Public Property FlightIndex As String
        Public Property FlightItinerary As Flightitinerary
        Public Property FlightPrice As Flightprice
        Public Property TicketsRemaining As String
    End Class

    Public Class Flightitinerary
        Public Property FlightLeg As List(Of Flightleg)
    End Class

    Public Class Flightleg
        Public Property FlightLegIndex As String
        Public Property FlightDuration As String
        Public Property FlightSegment As List(Of Flightsegment)
    End Class

    Public Class Flightsegment
        Public Property FlightSegmentIndex As String
        Public Property DepartureAirportCode As String
        Public Property ArrivalAirportCode As String
        Public Property DepartureDateTime As Date
        Public Property ArrivalDateTime As Date
        Public Property CarrierCode As String
        Public Property FlightNumber As String
        Public Property FlightDuration As String
    End Class

    Public Class Flightprice
        Public Property BaseRate As Baserate
        Public Property TaxesAndFees As Taxesandfees
        Public Property TotalRate As Totalrate
    End Class

    Public Class Baserate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Taxesandfees
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalrate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Hotellist
        Public Property CheckInDate As String
        Public Property CheckOutDate As String
        Public Property Hotel As List(Of Hotel)
    End Class

    Public Class Hotel
        Public Property HotelIndex As String
        Public Property HotelID As String
        Public Property Name As String
        Public Property Location As Location
        Public Property Description As String
        Public Property StarRating As String
        Public Property TravelerReviewRating As String
        Public Property TravelerReviewCount As String
        Public Property OverviewThumbnail As String
        Public Property RoomRatePlanDescription As String
        Public Property RoomAmenityList As Roomamenitylist
        Public Property HotelPrice As Hotelprice
        Public Property Promotion As Promotion
        Public Property RoomsRemaining As String
    End Class

    Public Class Location
        Public Property StreetAddress As String
        Public Property City As String
        Public Property Province As String
        Public Property Country As String
        Public Property GeoLocation As Geolocation
    End Class

    Public Class Geolocation
        Public Property Latitude As String
        Public Property Longitude As String
    End Class

    Public Class Roomamenitylist
        Public Property RoomAmenity As Object
    End Class

    Public Class Hotelprice
        Public Property BaseRate As Baserate1
        Public Property TaxRcAndFees As Taxrcandfees
        Public Property TotalRate As Totalrate1
    End Class

    Public Class Baserate1
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Taxrcandfees
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalrate1
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Promotion
        Public Property Amount As Amount
        Public Property Description As String
    End Class

    Public Class Amount
        Public Property Value As String
        Public Property Currency As String
    End Class

End Class
