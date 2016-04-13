Public Class objCarQueryResponse
    Public Class Rootobject
        Public Property CarCount As String
        Public Property CarInfoList As Carinfolist
        Public Property ErrorMessage As String
    End Class

    Public Class Carinfolist
        Public Property CarInfo As List(Of Carinfo)
    End Class

    Public Class Carinfo
        Public Property CarMakeModel As String
        Public Property CarClass As String
        Public Property TransmissionDriveCode As String
        Public Property FuelACCode As String
        Public Property FuelInfo As String
        Public Property SupplierID As String
        Public Property SupplierName As String
        Public Property PickupInfo As Pickupinfo
        Public Property DropOffInfo As Dropoffinfo
        Public Property Capacity As Capacity
        Public Property DetailsUrl As String
        Public Property RatePeriodCode As String
        Public Property Price As Price
        Public Property PrePay As String
        Public Property Mileage As Mileage
        Public Property ThumbnailUrl As String
    End Class

    Public Class Pickupinfo
        Public Property DateTime As Date
        Public Property Location As Location
    End Class

    Public Class Location
        Public Property Code As String
        Public Property LocationID As String
        Public Property ShuttleCategory As String
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

    Public Class Dropoffinfo
        Public Property DateTime As Date
        Public Property Location As Location1
    End Class

    Public Class Location1
        Public Property Code As String
        Public Property LocationID As String
        Public Property StreetAddress As String
        Public Property City As String
        Public Property Province As String
        Public Property Country As String
        Public Property GeoLocation As Geolocation1
    End Class

    Public Class Geolocation1
        Public Property Latitude As String
        Public Property Longitude As String
    End Class

    Public Class Capacity
        Public Property AdultCount As String
        Public Property ChildCount As String
        Public Property SmallLuggageCount As String
        Public Property LargeLuggageCount As String
    End Class

    Public Class Price
        Public Property BaseRate As Baserate
        Public Property TotalRate As Totalrate
        Public Property DailyRate As Dailyrate
    End Class

    Public Class Baserate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Totalrate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Dailyrate
        Public Property Value As String
        Public Property Currency As String
    End Class

    Public Class Mileage
        Public Property FreeDistance As Freedistance
    End Class

    Public Class Freedistance
        Public Property UnitCount As String
    End Class
End Class
