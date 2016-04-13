Public Class objPackageRequest
    Public Class Rootobject
        Public Sub New(originAirportCode As String, destinationAirportCode As String, departDate As String, returnDate As String, regionID As String, numResults As String, seatClass As String)
            Me.OriginAirportCode = originAirportCode
            Me.DestinationAirportCode = destinationAirportCode
            Me.DepartDate = departDate
            Me.ReturnDate = returnDate
            Me.RegionID = regionID
            Me.NumResults = numResults
            Me.SeatClass = seatClass
        End Sub

        Public Property OriginAirportCode As String
        Public Property DestinationAirportCode As String
        Public Property DepartDate As String
        Public Property ReturnDate As String
        Public Property RegionID As String
        Public Property NumResults As String
        Public Property SeatClass As String
        'Public Property Hotels As List(Of String)
    End Class
End Class
