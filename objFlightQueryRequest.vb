Public Class objFlightQueryRequest

    Public Class Rootobject
        Public Sub New(departDate As String, departFromAirportCode As String, arrivalToAirport As String, returnDate As String, numAdultPassengers As String, numResults As String)
            Me.DepartDate = departDate
            Me.DepartFromAirportCode = departFromAirportCode
            Me.ArrivalToAirport = arrivalToAirport
            Me.ReturnDate = returnDate
            Me.NumAdultPassengers = numAdultPassengers
            Me.NumResults = numResults
        End Sub

        Public Property DepartDate As String
        Public Property DepartFromAirportCode As String
        Public Property ArrivalToAirport As String
        Public Property ReturnDate As String
        Public Property NumAdultPassengers As String
        Public Property NumResults As String

    End Class

End Class
