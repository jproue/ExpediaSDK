Imports Newtonsoft.Json
Imports System.Net
Imports System.IO

'the merchant does all exchanges beteen the requests and responses
Public Class ExMerchant

    Public access_token As String


    'returns the information of a car requeast query in json format
    Public Function GET_CarSearch(In_Query As objCarQueryRequest.Rootobject) As objCarQueryResponse.Rootobject

        Dim strResults As String = String.Empty
        Dim strURI As String = "http://terminal2.expedia.com/x/cars/search"
        Dim objResults As New objCarQueryResponse.Rootobject

        'build the query string based on entries received
        Dim strQuery As String = "?"

        If In_Query.PickUpDate <> "" Then
            strQuery &= "pickupdate=" & In_Query.PickUpDate & "&"
        Else
            objResults.ErrorMessage = "No pick up date set"
            Return objResults
        End If
        If In_Query.DropOffDate <> "" Then
            strQuery &= "dropoffdate=" & In_Query.DropOffDate & "&"
        Else
            objResults.ErrorMessage = "No drop off date was set"
            Return objResults
        End If
        If In_Query.PickUpAirportCode <> "" Then
            strQuery &= "pickuplocation=" & In_Query.PickUpAirportCode & "&"
        Else
            objResults.ErrorMessage = "No pick up location was set"
            Return objResults
        End If
        If In_Query.DropOffAirportCode <> "" Then
            strQuery &= "dropofflocation=" & In_Query.DropOffAirportCode & "&"
        End If
        If In_Query.SortBy <> "" Then
            strQuery &= "sort=" & In_Query.SortBy & "&"
        End If
        If In_Query.NumResults <> "" Then
            strQuery &= "limit=" & In_Query.NumResults & "&"
        End If
        If In_Query.CarClasses <> "" Then
            strQuery &= "classes=" & In_Query.CarClasses & "&"
        End If

        strQuery &= "apikey=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI & strQuery)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()
        objResults = JsonConvert.DeserializeObject(Of objCarQueryResponse.Rootobject)(strResults)

        Return objResults

    End Function

    Public Function GET_FlightSearch(In_Query As objFlightQueryRequest.Rootobject) As objFlightQueryResponse.Rootobject
        Dim strURI As String = "http://terminal2.expedia.com/x/mflights/search"
        Dim strResults As String = String.Empty
        Dim objResults As New objFlightQueryResponse.Rootobject


        'build the query string based on entries received
        Dim strQuery As String = "?"

        If In_Query.DepartDate <> "" Then
            strQuery &= "departureDate=" & In_Query.DepartDate & "&"
        Else
            objResults.ErrorMessage = "No departure date set"
            Return objResults
        End If
        If In_Query.ReturnDate <> "" Then
            strQuery &= "returnDate=" & In_Query.ReturnDate & "&"
        End If
        If In_Query.DepartFromAirportCode <> "" Then
            strQuery &= "departureAirport=" & In_Query.DepartFromAirportCode & "&"
        Else
            objResults.ErrorMessage = "No depart from airport set"
            Return objResults
        End If
        If In_Query.ArrivalToAirport <> "" Then
            strQuery &= "arrivalAirport=" & In_Query.ArrivalToAirport & "&"
        Else
            objResults.ErrorMessage = "No arrive to airport set"
            Return objResults
        End If
        If In_Query.NumAdultPassengers <> "" Then
            strQuery &= "numOfAdultTravelers=" & In_Query.NumAdultPassengers & "&"
        End If
        If In_Query.NumResults <> "" Then
            strQuery &= "numOfferCount=" & In_Query.NumResults & "&"
        End If

        strQuery &= "apikey=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI & strQuery)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objFlightQueryResponse.Rootobject)(strResults)

        Return objResults
    End Function

    Public Function POST_FlightOverview(In_Request As objFlightOverviewRequest.Rootobject) As String

        'post to request information on itenerary flights
        Dim request_uri As String = "http://terminal2.expedia.com/x/flights/overview/get"
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token
        Dim data As String = JsonConvert.SerializeObject(In_Request)
        Dim results As String = String.Empty
        Dim req As HttpWebRequest = CType(WebRequest.Create(request_uri), HttpWebRequest)
        req.Method = WebRequestMethods.Http.Post
        req.Headers.Add(strHeader)
        Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
        req.ContentType = "application/json"
        req.ContentLength = byteArray.Length
        req.ServicePoint.Expect100Continue = False 'this prevents the server from choking on this request
        Dim dataStream As Stream = req.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim res As WebResponse = req.GetResponse()
        dataStream = res.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        results = reader.ReadToEnd()

        Return results

    End Function

    Public Function GET_PriceRanges(In_FromAirport As String, In_ToAirport As String, In_DepartDate As String) As objPriceRangeResponse.Rootobject

        Dim strURI As String = "http://terminal2.expedia.com/x/flights/search/1/" &
                                                                      In_FromAirport &
                                                                      "/" & In_ToAirport &
                                                                      "/" & In_DepartDate
        Dim strResults As String = String.Empty
        Dim objResults As New objPriceRangeResponse.Rootobject
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objPriceRangeResponse.Rootobject)(strResults)

        Return objResults


    End Function

    Public Function GET_PriceTrends(In_FromAirport As String, In_ToAirport As String, In_DepartDate As String) As objTrendResponse.Rootobject

        Dim strURI As String = "http://terminal2.expedia.com/x/flights/v3/search/1/" &
                                                                      In_FromAirport &
                                                                      "/" & In_ToAirport &
                                                                      "/" & In_DepartDate
        Dim strResults As String = String.Empty
        Dim objResults As New objTrendResponse.Rootobject
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objTrendResponse.Rootobject)(strResults)

        Return objResults

    End Function

    Public Function GET_HotelInformation(In_Query As objHotelInfoRequest.Rootobject) As objHotelInfoResponse.Rootobject

        Dim strURI As String = "http://terminal2.expedia.com/x/hotels"
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token
        Dim strResults As String = String.Empty
        Dim objResults As New objHotelInfoResponse.Rootobject

        Dim strQuery As String = "?"

        If In_Query.RegionID <> "" Then
            strQuery &= "regionid=" & In_Query.RegionID & "&"
        End If
        If In_Query.LongLatLocation <> "" Then
            strQuery &= "location=" & In_Query.LongLatLocation & "&"
        Else
            objResults.ErrorMessage = "No location was set"
            Return objResults
        End If
        If In_Query.Radius <> "" Then
            strQuery &= "radius=" & In_Query.Radius & "&"
        Else
            objResults.ErrorMessage = "Not radius was set"
            Return objResults
        End If
        If In_Query.CheckInDate <> "" Then
            strQuery &= "checkInDate=" & In_Query.CheckInDate & "&"
        End If
        If In_Query.CheckOutDate <> "" Then
            strQuery &= "checkOutDate=" & In_Query.CheckOutDate & "&"
        End If
        If In_Query.SortBy <> "" Then
            strQuery &= "sort=" & In_Query.SortBy & "&"
        End If
        If In_Query.NumResults <> "" Then
            strQuery &= "maxHotels=" & In_Query.NumResults & "&"
        End If

        strQuery &= "apikey=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI & strQuery)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objHotelInfoResponse.Rootobject)(strResults)

        Return objResults
    End Function


    Public Function GET_Packages(In_Query As objPackageRequest.Rootobject) As objPackageResponse.Rootobject

        Dim strURI As String = "http://terminal2.expedia.com/x/packages"
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim strResults As String = String.Empty
        Dim objResults As New objPackageResponse.Rootobject

        Dim strQuery As String = "?"

        If In_Query.OriginAirportCode <> "" Then
            strQuery &= "originAirport=" & In_Query.OriginAirportCode & "&"
        Else
            objResults.ErrorMessage = "No origin airport was set"
            Return objResults
        End If
        If In_Query.DestinationAirportCode <> "" Then
            strQuery &= "destinationAirport=" & In_Query.DestinationAirportCode & "&"
        Else
            objResults.ErrorMessage = "No destination airport was set"
            Return objResults
        End If
        If In_Query.DepartDate <> "" Then
            strQuery &= "departureDate=" & In_Query.DepartDate & "&"
        Else
            objResults.ErrorMessage = "No departure date was set"
            Return objResults
        End If
        If In_Query.ReturnDate <> "" Then
            strQuery &= "returnDate=" & In_Query.ReturnDate & "&"
        Else
            objResults.ErrorMessage = "Not return Date was set"
            Return objResults
        End If
        If In_Query.RegionID <> "" Then
            strQuery &= "regionid=" & In_Query.RegionID & "&"
        Else
            objResults.ErrorMessage = "Specify either Hotel ID or Region ID" 'Region id is the only one coded TODO code for hotel id
        End If
        If In_Query.NumResults <> "" Then
            strQuery &= "limit=" & In_Query.NumResults & "&"
        End If
        If In_Query.SeatClass <> "" Then
            strQuery &= "class=" & In_Query.SeatClass & "&"
        End If

        strQuery &= "apikey=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI & strQuery)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objPackageResponse.Rootobject)(strResults)

        Return objResults
    End Function

    Public Function GET_ActivitiesByLocation(In_Location As String, In_StartDate As String, In_EndDate As String) As objActivitiesByLocationResponse.Rootobject
        Dim strURI As String = "http://terminal2.expedia.com/x/activities/search?" &
                                                                      "location=" & In_Location

        If In_StartDate <> "" Then
            strURI &= "&startDate=" & In_StartDate
        End If
        If In_EndDate <> "" Then
            strURI &= "endDate=" & In_EndDate
        End If

        Dim strResults As String = String.Empty
        Dim objResults As New objActivitiesByLocationResponse.Rootobject
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objActivitiesByLocationResponse.Rootobject)(strResults)

        Return objResults
    End Function

    Public Function GET_ActivitiesByCode(In_ActivityCode As String, In_StartDate As String, In_EndDate As String) As objActivitiesByCodeResponse.Rootobject
        Dim strURI As String = "http://terminal2.expedia.com/x/activities/details?" &
                                                                      "activityId=" & In_ActivityCode

        If In_StartDate <> "" Then
            strURI &= "&startDate=" & In_StartDate
        End If
        If In_EndDate <> "" Then
            strURI &= "&endDate=" & In_EndDate
        End If

        Dim strResults As String = String.Empty
        Dim objResults As New objActivitiesByCodeResponse.Rootobject
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objActivitiesByCodeResponse.Rootobject)(strResults)

        Return objResults
    End Function

    Public Function GET_UnrealDeals(In_Query As objUnrealDealRequest.Rootobject) As objUnrealDealResponse.Rootobject

        Dim strURI As String = "http://terminal2.expedia.com/x/deals/packages"
        Dim strHeader As String = "Authorization: expedia-apikey key=" & access_token

        Dim strResults As String = String.Empty
        Dim objResults As New objUnrealDealResponse.Rootobject

        Dim strQuery As String = "?"

        If In_Query.OriginAirportCode <> "" Then
            strQuery &= "originTLA=" & In_Query.OriginAirportCode & "&"
        Else
            objResults.ErrorMessage = "No origin airport was set"
            Return objResults
        End If
        If In_Query.DestinationAirportCode <> "" Then
            strQuery &= "destinationTLA=" & In_Query.DestinationAirportCode & "&"
        Else
            objResults.ErrorMessage = "No destination airport was set"
            Return objResults
        End If
        If In_Query.StartDate <> "" Then
            strQuery &= "startDate=" & In_Query.StartDate & "&"
        Else
            objResults.ErrorMessage = "No start date was set"
            Return objResults
        End If
        If In_Query.EndDate <> "" Then
            strQuery &= "endDate=" & In_Query.EndDate & "&"
        Else
            objResults.ErrorMessage = "Not end date was set"
            Return objResults
        End If
        If In_Query.LengthOfStay <> "" Then
            strQuery &= "lengthOfStay=" & In_Query.LengthOfStay & "&"
        Else
            objResults.ErrorMessage = "No length of stay was set"
            Return objResults
        End If
        If In_Query.NumResults <> "" Then
            strQuery &= "limit=" & In_Query.NumResults & "&"
        End If

        strQuery &= "apikey=" & access_token

        Dim results As String = String.Empty
        Dim queryRequest As WebRequest = WebRequest.Create(strURI & strQuery)
        queryRequest.Headers.Add(strHeader)
        Dim objStream As Stream = queryRequest.GetResponse.GetResponseStream() 'get the response of the GEt request
        Dim reader As New StreamReader(objStream)
        strResults = reader.ReadToEnd()

        objResults = JsonConvert.DeserializeObject(Of objUnrealDealResponse.Rootobject)(strResults)

        Return objResults
    End Function

End Class
