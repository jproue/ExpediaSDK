Public Class objActivitiesByCodeResponse


    Public Class Rootobject
        Public Property id As String
        Public Property title As String
        Public Property description As String
        Public Property images As List(Of Image)
        Public Property highlights As List(Of String)
        Public Property termsAndConditions As String
        Public Property fromPrice As String
        Public Property fromPriceLabel As String
        Public Property currencyCode As String
        Public Property fromOriginalPrice As String
        Public Property fromOriginalPriceValue As String
        Public Property fromPriceTicketType As String
        Public Property startDate As String
        Public Property endDate As String
        Public Property duration As String
        Public Property inclusions As List(Of String)
        Public Property exclusions As List(Of Object)
        Public Property cancellationPolicyText As String
        Public Property knowBeforeYouBook As List(Of String)
        Public Property freeCancellation As Boolean
        Public Property discountPercentage As Integer
        Public Property address As String
        Public Property location As String
        Public Property latLng As String
        Public Property regionId As String
        Public Property destination As String
        Public Property fullName As String
        Public Property offersDetail As Offersdetail
        Public Property dateAdjusted As Boolean
        Public Property metaDescription As String
        Public Property metaKeywords As String
        Public Property pageTitle As String
        Public Property category As String
        Public Property status As String
        Public Property freeCancellationMinHours As Integer
        Public Property supplierName As String
        Public Property redemptionType As String
        Public Property redemptionLocation As List(Of Redemptionlocation)
        Public Property eventLocation As Eventlocation
        Public Property recommendationScore As Integer
        Public Property staticMapUrl As String
    End Class

    Public Class Offersdetail
        Public Property offers As List(Of Offer)
        Public Property priceFootnote As String
        Public Property sameDateSearch As Boolean
    End Class

    Public Class Offer
        Public Property id As String
        Public Property title As String
        Public Property description As String
        Public Property freeCancellation As Boolean
        Public Property duration As String
        Public Property discountPercentage As String
        Public Property defaultTicketCountPrice As String
        Public Property withinRange As Boolean
        Public Property discountType As Object
        Public Property availabilityInfo As List(Of Availabilityinfo)
    End Class

    Public Class Availabilityinfo
        Public Property availabilities As Availabilities
        Public Property tickets As List(Of Ticket)
    End Class

    Public Class Availabilities
        Public Property displayDate As String
        Public Property valueDate As String
        Public Property allDayActivity As Boolean
    End Class

    Public Class Ticket
        Public Property code As String
        Public Property ticketId As String
        Public Property name As String
        Public Property restrictionText As String
        Public Property restriction As Restriction
        Public Property price As String
        Public Property originalPrice As String
        Public Property originalAmount As String
    End Class

    Public Class Restriction
        Public Property type As String
        Public Property max As Integer
        Public Property min As Integer
    End Class

    Public Class Eventlocation
        Public Property addressName As String
        Public Property street As String
        Public Property city As String
        Public Property province As String
        Public Property postalCode As String
        Public Property latLng As String
    End Class

    Public Class Image
        Public Property url As String
        Public Property large As String
        Public Property thumbnail As String
        Public Property caption As String
        Public Property creditString As String
        Public Property isImage As Boolean
    End Class

    Public Class Redemptionlocation
        Public Property addressName As String
        Public Property street As String
        Public Property city As String
        Public Property province As String
        Public Property postalCode As String
        Public Property latLng As String
    End Class


End Class
