
Imports ExpediaSDK

Public Class objFlightOverviewRequest


    Public Class Rootobject
        Public Sub New()
            Me.MessageHeader = New Messageheader
            Me.tpid = 0
            Me.eapid = 0
            Me.PointOfSaleKey = New Pointofsalekey
            Me.OriginAirportCodeList = New Originairportcodelist
            Me.DestinationAirportCodeList = New Destinationairportcodelist
            Me.FlightListings = New Flightlistings
        End Sub

        Public Property MessageHeader As New Messageheader
        Public Property tpid As Integer
        Public Property eapid As Integer
        Public Property PointOfSaleKey As New Pointofsalekey
        Public Property OriginAirportCodeList As New Originairportcodelist
        Public Property DestinationAirportCodeList As New Destinationairportcodelist
        Public Property FlightListings As New Flightlistings
    End Class

    Public Class Messageheader
        Public Sub New()
            Me.ClientInfo = New Clientinfo
            Me.TransactionGUID = ""
        End Sub

        Public Property ClientInfo As New Clientinfo
        Public Property TransactionGUID As String
    End Class

    Public Class Clientinfo
        Public Sub New()
            Me.DirectClientName = ""
        End Sub
        Public Property DirectClientName As String
    End Class

    Public Class Pointofsalekey
        Public Sub New()
            Me.JurisdictionCountryCode = ""
            Me.CompanyCode = ""
            Me.ManagementUnitCode = ""
        End Sub

        Public Property JurisdictionCountryCode As String
        Public Property CompanyCode As String
        Public Property ManagementUnitCode As String
    End Class

    Public Class Originairportcodelist
        Public Property AirportCode As New List(Of String)
    End Class

    Public Class Destinationairportcodelist
        Public Property AirportCode As New List(Of String)
    End Class

    Public Class Flightlistings
    End Class

End Class
