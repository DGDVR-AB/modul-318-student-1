Namespace SwissTransport
	Interface ITransport
		Function GetStations(ByVal query As String) As Stations
		Function GetStationBoard(ByVal station As String, ByVal id As String) As StationBoardRoot
		Function GetConnections(ByVal fromStation As String, ByVal toStattion As String) As Connections
	End Interface
End Namespace

