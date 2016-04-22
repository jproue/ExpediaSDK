Public Class objHotelInfoResponse

    Public Class Rootobject
        Public Property MatchingHotelCount As String
        Public Property HotelCount As String
        Public Property StayDates As Staydates
        Public Property HotelInfoList As Hotelinfolist
        Public Property ErrorMessage As String
    End Class

    Public Class Staydates
        Public Property CheckInDate As String
        Public Property CheckOutDate As String
    End Class

    Public Class Hotelinfolist
        Public Property HotelInfo As List(Of Hotelinfo)
    End Class

    Public Class Hotelinfo
        Public Property HotelID As String
        Public Property Name As String
        Public Property Location As Location
        Public Property Description As String
        Public Property StatusCode As String
        Public Property Price As Price
        Public Property DetailsUrl As String
        Public Property StarRating As String
        Public Property ThumbnailUrl As String
        Public Property GuestRating As String
        Public Property GuestReviewCount As String
        Public Property RoomTypeList As Roomtypelist
        Public Property AmenityList As Amenitylist
        Public Property StatusDescription As String
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

    Public Class Price
        Public Property BaseRate As Baserate
        Public Property TaxRcAndFees As Taxrcandfees
        Public Property TotalRate As Totalrate
    End Class

    Public Class Baserate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Taxrcandfees
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalrate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Roomtypelist
        Public Property RoomType As Roomtype
    End Class

    Public Class Roomtype
        Public Property Description As String
        Public Property Price As Price1
        Public Property RoomAmenityList As Roomamenitylist
        Public Property Refundable As String
        Public Property FreeCancellation As String
        Public Property FreeCancellationEndDateTime As Date
        Public Property FreeInternet As String
        Public Property FreeInternetAmenityDetails As Freeinternetamenitydetails
        Public Property FreeParking As String
        Public Property FreeBreakfast As String
        Public Property PaymentMethod As String
        Public Property SmokingAvailable As Smokingavailable
        Public Property RemainingCount As String
    End Class

    Public Class Price1
        Public Property BaseRate As Baserate1
        Public Property TaxRcAndFees As Taxrcandfees1
        Public Property TotalRate As Totalrate1
    End Class

    Public Class Baserate1
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Taxrcandfees1
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalrate1
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Roomamenitylist
        Public Property RoomAmenity As Object
    End Class

    Public Class Freeinternetamenitydetails
        Public Property Amenity As Object
    End Class

    Public Class Smokingavailable
        Public Property HasNonSmoking As String
        Public Property HasSmoking As String
    End Class

    Public Class Amenitylist
        Public Property Amenity As Object
    End Class



End Class
