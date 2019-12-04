Imports Newtonsoft.Json

Namespace SwissTransport
	Public Class Coordinate
		<JsonProperty("type")>
		Public Property Type As String
		<JsonProperty("x")>
		Public Property XCoordinate As Double
		<JsonProperty("y")>
		Public Property YCoordinate As Double
	End Class

	Public Class Station
		<JsonProperty("id")>
		Public Property Id As String
		<JsonProperty("name")>
		Public Property Name As String
		<JsonProperty("score")>
		Public Property Score As Integer?
		<JsonProperty("coordinate")>
		Public Property Coordinate As Coordinate
		<JsonProperty("distance")>
		Public Property Distance As Double?
	End Class

	Public Class Stations
		<JsonProperty("stations")>
		Public Property StationList As List(Of Station)
	End Class
End Namespace
