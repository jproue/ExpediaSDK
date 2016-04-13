Public Class objActivitiesByLocationResponse

    Public Class Rootobject
        Public Property activities As List(Of Activity)
        Public Property total As Integer
        Public Property regionId As String
        Public Property destination As String
        Public Property fullName As String
        Public Property disambig As Boolean
        Public Property suggesions As List(Of Suggestion)
        Public Property startDate As String
        Public Property endDate As String
        Public Property filterCategories As Filtercategories
        Public Property currencyCode As String
    End Class

    Public Class Filtercategories
        Public Property PrivateTransfers As PrivateTransfers
        Public Property SharedTransfers As SharedTransfers
        Public Property Attractions As Attractions
        Public Property FoodDrink As FoodDrink
        Public Property WalkingBikeTours As WalkingBikeTours
    End Class

    Public Class PrivateTransfers
        Public Property count As Integer
        Public Property displayValue As String
        Public Property contextualDisplayValue As String
        Public Property contextualComboDisplayValue As String
        Public Property contextualSingularDisplayValue As String
    End Class

    Public Class SharedTransfers
        Public Property count As Integer
        Public Property displayValue As String
        Public Property contextualDisplayValue As String
        Public Property contextualComboDisplayValue As String
        Public Property contextualSingularDisplayValue As String
    End Class

    Public Class Attractions
        Public Property count As Integer
        Public Property displayValue As String
        Public Property contextualDisplayValue As String
        Public Property contextualSingularDisplayValue As String
    End Class

    Public Class FoodDrink
        Public Property count As Integer
        Public Property displayValue As String
        Public Property contextualDisplayValue As String
        Public Property contextualSingularDisplayValue As String
    End Class

    Public Class WalkingBikeTours
        Public Property count As Integer
        Public Property displayValue As String
        Public Property contextualDisplayValue As String
        Public Property contextualSingularDisplayValue As String
    End Class

    Public Class Activity
        Public Property id As String
        Public Property title As String
        Public Property imageUrl As String
        Public Property largeImageURL As String
        Public Property fromPrice As String
        Public Property fromPriceLabel As String
        Public Property fromOriginalPrice As String
        Public Property fromOriginalPriceValue As String
        Public Property duration As String
        Public Property fromPriceTicketType As String
        Public Property freeCancellation As Boolean
        Public Property discountPercentage As Object
        Public Property categories As List(Of String)
        Public Property latLng As String
        Public Property redemptionType As String
        Public Property supplierName As String
        Public Property recommendationScore As Integer
        Public Property discountType As Object
        Public Property shortDescription As Object
    End Class

    Public Class Suggestion
        Public Property region As String
        Public Property resolved As String
    End Class

End Class
