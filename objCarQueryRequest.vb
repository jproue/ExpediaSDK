Public Class objCarQueryRequest

    Public Class Rootobject
        Public Sub New(pickUpDate As String, dropOffDate As String, pickUpAirportCode As String, dropOffAirportCode As String, sortBy As String, numResults As String, carClasses As String)
            Me.PickUpDate = pickUpDate
            Me.DropOffDate = dropOffDate
            Me.PickUpAirportCode = pickUpAirportCode
            Me.DropOffAirportCode = dropOffAirportCode
            Me.SortBy = sortBy
            Me.NumResults = numResults
            Me.CarClasses = carClasses
        End Sub

        Public Property PickUpDate As String
        Public Property DropOffDate As String
        Public Property PickUpAirportCode As String
        Public Property DropOffAirportCode As String
        Public Property SortBy As String
        Public Property NumResults As String
        Public Property CarClasses As String
        Public Property ErrorMessage As String

    End Class

End Class
