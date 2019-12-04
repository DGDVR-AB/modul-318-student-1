Imports System.Collections.Generic
Imports Newtonsoft.Json

Namespace SwissTransport
	Public Class Connections
		<JsonProperty("connections")>
		Public Property ConnectionList As List(Of Connection)
	End Class

	Public Class Connection
		<JsonProperty("from")>
		Public Property From As ConnectionPoint
		<JsonProperty("to")>
		Public Property [To] As ConnectionPoint
		<JsonProperty("duration")>
		Public Property Duration As String
	End Class

	Public Class ConnectionPoint
		<JsonProperty("station")>
		Public Property Station As Station
		Public Property Arrival As String
		Public Property ArrivalTimestamp As String
		Public Property Departure As String
		Public Property DepartureTimestamp As String
		Public Property Delay As Integer?
		Public Property Platform As String
		Public Property RealtimeAvailability As String
	End Class
End Namespace
