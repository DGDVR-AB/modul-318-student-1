Imports ClassLibrary1.SwissTransport

Public Class Form1
	Public connections As Connections
	Public stations As Stations
	Public stationBoard As StationBoardRoot
	Private Sub cmdVerbindungenSuchen_Click(sender As Object, e As EventArgs) Handles cmdVerbindungenSuchen.Click
		Try
			Dim i As String
			If Not My.Computer.Network.IsAvailable Then
				MessageBox.Show("Du bist nichtk mit dem Internet verbunden. Bitte verbinde dich mit dem Internet")
			Else
				Dim strAbfahrtsortFrage As String = txtAbfahrtsortFrage.Text
				Dim strAnkunftsortFrage As String = txtAnkunftsortFrage.Text
				Dim transport = New Transport()
				connections = transport.ITransport_GetConnections(strAbfahrtsortFrage, strAnkunftsortFrage)
				For Each connection As Object In connections.ConnectionList
					Dim text As String = connection.From.Station.Name + " --> " + connection.To.Station.Name + " von " + Convert.ToDateTime(connection.From.Departure).ToString("HH:mm:ss") + " bis " + Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm:ss")
					lbErgebnis.Items.Add(text)
					i = connection.To.Station.Id.ToString()
				Next
				lbErgebnis.SelectedIndex = 0
				stationBoard = transport.ITransport_GetStationBoard(txtAnkunftsortFrage.Text, i)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub lbErgebnis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbErgebnis.SelectedIndexChanged
		Try
			Dim aktuellerIndex As Integer = lbErgebnis.SelectedIndex
			txtAbfahrtsortAntwort.Text = connections.ConnectionList(aktuellerIndex).From.Station.Name
			txtAnkunftsortAntwort.Text = connections.ConnectionList(aktuellerIndex).To.Station.Name
			txtAbfahrtszeitAntwort.Text = Convert.ToDateTime(connections.ConnectionList(aktuellerIndex).From.Departure).ToString("HH:mm:ss") 'Noch kontrollieren
			txtAnkunftszeitAntwort.Text = Convert.ToDateTime(connections.ConnectionList(aktuellerIndex).To.Arrival).ToString("HH:mm:ss") 'Noch kontrollieren
			txtGleisAntwort.Text = connections.ConnectionList(aktuellerIndex).From.Platform

			Dim StationId As String = stationBoard.Station.Id
			Dim transport = New Transport()
			Dim stationInfos = transport.ITransport_GetStationBoard(txtAnkunftsortFrage.Text, StationId)
			For Each stationInfo As Object In stationInfos.Entries
				Dim text As String = stationInfo.Operator + ", " + stationInfo.Name + ", Abfahrtszeit: " + Convert.ToDateTime(stationInfo.Stop.Departure).ToString("HH:mm:ss") + ", Ziel: " + stationInfo.To
				lbWeiterverbindungen.Items.Add(text)
			Next

		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtAbfahrtsortFrage_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAbfahrtsortFrage.KeyUp
		Try
			Dim stations As AutoCompleteStringCollection = New AutoCompleteStringCollection()
			txtAbfahrtsortFrage.AutoCompleteCustomSource.Clear()
			Dim transport = New Transport()
			Dim textVervollstaendigung = transport.ITransport_GetStations(txtAbfahrtsortFrage.Text)
			For Each station As Object In textVervollstaendigung.StationList
				stations.Add(station.Name)
			Next
			txtAbfahrtsortFrage.AutoCompleteCustomSource = stations
			txtAbfahrtsortFrage.AutoCompleteMode = AutoCompleteMode.Suggest
			txtAbfahrtsortFrage.AutoCompleteSource = AutoCompleteSource.CustomSource
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtAnkunftsortFrage_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAnkunftsortFrage.KeyUp
		Try
			Dim stations As AutoCompleteStringCollection = New AutoCompleteStringCollection()
			txtAnkunftsortFrage.AutoCompleteCustomSource.Clear()
			Dim transport = New Transport()
			Dim textVervollstaendigung = transport.ITransport_GetStations(txtAnkunftsortFrage.Text)
			For Each station As Object In textVervollstaendigung.StationList
				stations.Add(station.Name)
			Next
			txtAnkunftsortFrage.AutoCompleteCustomSource = stations
			txtAnkunftsortFrage.AutoCompleteMode = AutoCompleteMode.Suggest
			txtAnkunftsortFrage.AutoCompleteSource = AutoCompleteSource.CustomSource
		Catch ex As Exception
		End Try
	End Sub
End Class
