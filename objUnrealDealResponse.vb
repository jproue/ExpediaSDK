Public Class objUnrealDealResponse

    Public Class Rootobject
        Public Property deals As Deals
        Public Property ErrorMessage As String
    End Class

    Public Class Deals
        Public Property packages As List(Of Package)
    End Class

    Public Class Package
        Public Property hotelId As Integer
        Public Property originTLA As String
        Public Property destinationTLA As String
        Public Property expiryDate As Date
        Public Property marker As List(Of Marker)
        Public Property product As Product
        Public Property comparableProduct As Comparableproduct
        Public Property currencyCode As String
        Public Property totalPackagePrice As Single
        Public Property totalPackageSavings As Single
        Public Property totalPackageSavingsPct As Single
        Public Property packageStartDate As Date
        Public Property packageEndDate As Date
        Public Property checkInDate As Date
        Public Property checkOutDate As Date
        Public Property saLodgingBase As Integer
        Public Property saLodgingTaxesAndFees As Single
        Public Property saAirBase As Single
        Public Property saAirTaxesAndFees As Single
        Public Property tpid As Integer
        Public Property nature As String
        Public Property deeplink As String
    End Class

    Public Class Product
        Public Property ratePlanCode As String
        Public Property roomTypeCode As String
    End Class

    Public Class Comparableproduct
        Public Property ratePlanCode As String
        Public Property roomTypeCode As String
    End Class

    Public Class Marker
        Public Property sticker As String
        Public Property token As String
        Public Property magnitude As String
    End Class

End Class
