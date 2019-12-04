Imports Newtonsoft.Json

Namespace SwissTransport
	Public Class StationBoardRoot
		<JsonProperty("Station")>
		Public Property Station As Station
		<JsonProperty("stationboard")>
		Public Property Entries As List(Of StationBoard)
	End Class

	Public Class StationBoard
		<JsonProperty("name")>
		Public Property Name As String
		<JsonProperty("category")>
		Public Property Category As String
		<JsonProperty("Number")>
		Public Property Number As String
		<JsonProperty("to")>
		Public Property [To] As String
		<JsonProperty("operator")>
		Public Property [Operator] As String
		<JsonProperty("stop")>
		Public Property [Stop] As [Stop]
	End Class

	Public Class [Stop]
		<JsonProperty("departure")>
		Public Property Departure As DateTime
	End Class
End Namespace
