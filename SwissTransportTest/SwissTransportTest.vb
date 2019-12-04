Imports ClassLibrary1.SwissTransport
Imports Microsoft.VisualStudio.TestTools.UnitTesting


Namespace SwissTransport
	<TestClass>
	Public Class TransportTest
		Private testee As Transport

		<TestMethod>
		Public Sub Locations()
			testee = New Transport()
			Dim stations = testee.ITransport_GetStations("Sursee,")
			Assert.AreEqual(10, stations.StationList.Count)
		End Sub

		<TestMethod>
		Public Sub StationBoard()
			testee = New Transport()
			Dim stationBoard = testee.ITransport_GetStationBoard("Sursee", "8502007")
			Assert.IsNotNull(stationBoard)
		End Sub

		<TestMethod>
		Public Sub Connections()
			testee = New Transport()
			Dim connections = testee.ITransport_GetConnections("Sursee", "Luzern")
			Assert.IsNotNull(connections)
		End Sub
	End Class
End Namespace
