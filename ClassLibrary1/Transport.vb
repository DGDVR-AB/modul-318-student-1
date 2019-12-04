Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Namespace SwissTransport
	Public Class Transport
		Implements ITransport

		Public Shared Function CreateWebRequest(ByVal url As String) As WebRequest
			Dim request = WebRequest.Create(url)
			Dim webProxy = WebRequest.DefaultWebProxy
			webProxy.Credentials = CredentialCache.DefaultNetworkCredentials
			request.Proxy = webProxy
			Return request
		End Function

		Public Function ITransport_GetStations(query As String) As Stations Implements ITransport.GetStations
			query = System.Uri.EscapeDataString(query)
			Dim request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" & query)
			Dim response = request.GetResponse()
			Dim responseStream = response.GetResponseStream()

			If responseStream IsNot Nothing Then
				Dim message = New StreamReader(responseStream).ReadToEnd()
				Dim stations = JsonConvert.DeserializeObject(Of Stations)(message, New JsonSerializerSettings With {
																																	 .NullValueHandling = NullValueHandling.Ignore
																																	 })
				Return stations
			End If

			Return Nothing
		End Function

		Public Function ITransport_GetStationBoard(station As String, id As String) As StationBoardRoot Implements ITransport.GetStationBoard
			station = System.Uri.EscapeDataString(station)
			id = System.Uri.EscapeDataString(id)
			Dim request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" & station & "&id=" & id)
			Dim response = request.GetResponse()
			Dim responseStream = response.GetResponseStream()

			If responseStream IsNot Nothing Then
				Dim readToEnd = New StreamReader(responseStream).ReadToEnd()
				Dim stationboard = JsonConvert.DeserializeObject(Of StationBoardRoot)(readToEnd)
				Return stationboard
			End If

			Return Nothing
		End Function

		Public Function ITransport_GetConnections(fromStation As String, toStattion As String) As Connections Implements ITransport.GetConnections
			fromStation = System.Uri.EscapeDataString(fromStation)
			toStattion = System.Uri.EscapeDataString(toStattion)
			Dim request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" & fromStation & "&to=" & toStattion)
			Dim response = request.GetResponse()
			Dim responseStream = response.GetResponseStream()

			If responseStream IsNot Nothing Then
				Dim readToEnd = New StreamReader(responseStream).ReadToEnd()
				Dim connections = JsonConvert.DeserializeObject(Of Connections)(readToEnd)
				Return connections
			End If

			Return Nothing
		End Function
	End Class
End Namespace
