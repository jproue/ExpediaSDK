Public Class objHotelInfoResponse

    Public Class Rootobject
        Public Property MatchingHotelCount As String
        Public Property HotelCount As String
        Public Property HotelInfoList As Hotelinfolist
        Public Property ErrorMessage As String
    End Class

    Public Class Hotelinfolist
        Public Property HotelInfo As List(Of Hotelinfo)
    End Class

    Public Class Hotelinfo
        Public Property HotelID As String
        Public Property Name As String
        Public Property Location As Location
        Public Property Description As String
        Public Property DetailsUrl As String
        Public Property StarRating As String
        Public Property ThumbnailUrl As String
        Public Property GuestRating As String
        Public Property GuestReviewCount As String
        Public Property AmenityList As Amenitylist
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

    Public Class Amenitylist
        Public Property Amenity As Object
    End Class

End Class
