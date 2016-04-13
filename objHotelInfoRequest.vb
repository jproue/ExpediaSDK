Public Class objHotelInfoRequest
    Public Class Rootobject
        Public Sub New(regionID As String, longLatLocation As String, radius As String, checkInDate As String, checkOutDate As String, sortBy As String, numresults As String)
            Me.RegionID = regionID
            Me.LongLatLocation = longLatLocation
            Me.Radius = radius
            Me.CheckInDate = checkInDate
            Me.CheckOutDate = checkOutDate
            Me.SortBy = sortBy
            Me.NumResults = numresults
        End Sub

        Public Property RegionID As String
        Public Property LongLatLocation As String
        Public Property Radius As String
        Public Property CheckInDate As String
        Public Property CheckOutDate As String
        Public Property SortBy As String
        Public Property NumResults As String
    End Class
End Class
