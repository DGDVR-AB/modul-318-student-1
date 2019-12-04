<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.laAbfahrtsortFrage = New System.Windows.Forms.Label()
		Me.laAnkunftsortFrage = New System.Windows.Forms.Label()
		Me.txtAbfahrtsortFrage = New System.Windows.Forms.TextBox()
		Me.txtAnkunftsortFrage = New System.Windows.Forms.TextBox()
		Me.cmdVerbindungenSuchen = New System.Windows.Forms.Button()
		Me.lbErgebnis = New System.Windows.Forms.ListBox()
		Me.txtAnkunftsortAntwort = New System.Windows.Forms.TextBox()
		Me.txtAbfahrtsortAntwort = New System.Windows.Forms.TextBox()
		Me.laAnkunftsortAntwort = New System.Windows.Forms.Label()
		Me.laAbfahrtsortAntwort = New System.Windows.Forms.Label()
		Me.laAbgahrtszeitAntwort = New System.Windows.Forms.Label()
		Me.laAnkunftszeitAntwort = New System.Windows.Forms.Label()
		Me.laGleisAntwort = New System.Windows.Forms.Label()
		Me.txtAbfahrtszeitAntwort = New System.Windows.Forms.TextBox()
		Me.txtAnkunftszeitAntwort = New System.Windows.Forms.TextBox()
		Me.txtGleisAntwort = New System.Windows.Forms.TextBox()
		Me.lbWeiterverbindungen = New System.Windows.Forms.ListBox()
		Me.SuspendLayout
		'
		'laAbfahrtsortFrage
		'
		Me.laAbfahrtsortFrage.AutoSize = true
		Me.laAbfahrtsortFrage.Location = New System.Drawing.Point(26, 28)
		Me.laAbfahrtsortFrage.Name = "laAbfahrtsortFrage"
		Me.laAbfahrtsortFrage.Size = New System.Drawing.Size(82, 17)
		Me.laAbfahrtsortFrage.TabIndex = 0
		Me.laAbfahrtsortFrage.Text = "Abfahrtsort:"
		'
		'laAnkunftsortFrage
		'
		Me.laAnkunftsortFrage.AutoSize = true
		Me.laAnkunftsortFrage.Location = New System.Drawing.Point(26, 75)
		Me.laAnkunftsortFrage.Name = "laAnkunftsortFrage"
		Me.laAnkunftsortFrage.Size = New System.Drawing.Size(84, 17)
		Me.laAnkunftsortFrage.TabIndex = 1
		Me.laAnkunftsortFrage.Text = "Ankunftsort:"
		'
		'txtAbfahrtsortFrage
		'
		Me.txtAbfahrtsortFrage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.txtAbfahrtsortFrage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.txtAbfahrtsortFrage.Location = New System.Drawing.Point(125, 25)
		Me.txtAbfahrtsortFrage.Multiline = true
		Me.txtAbfahrtsortFrage.Name = "txtAbfahrtsortFrage"
		Me.txtAbfahrtsortFrage.Size = New System.Drawing.Size(204, 24)
		Me.txtAbfahrtsortFrage.TabIndex = 2
		'
		'txtAnkunftsortFrage
		'
		Me.txtAnkunftsortFrage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.txtAnkunftsortFrage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.txtAnkunftsortFrage.Location = New System.Drawing.Point(125, 72)
		Me.txtAnkunftsortFrage.Multiline = true
		Me.txtAnkunftsortFrage.Name = "txtAnkunftsortFrage"
		Me.txtAnkunftsortFrage.Size = New System.Drawing.Size(204, 24)
		Me.txtAnkunftsortFrage.TabIndex = 3
		'
		'cmdVerbindungenSuchen
		'
		Me.cmdVerbindungenSuchen.Location = New System.Drawing.Point(158, 121)
		Me.cmdVerbindungenSuchen.Name = "cmdVerbindungenSuchen"
		Me.cmdVerbindungenSuchen.Size = New System.Drawing.Size(171, 34)
		Me.cmdVerbindungenSuchen.TabIndex = 4
		Me.cmdVerbindungenSuchen.Text = "Verbindungen Suchen"
		Me.cmdVerbindungenSuchen.UseVisualStyleBackColor = true
		'
		'lbErgebnis
		'
		Me.lbErgebnis.FormattingEnabled = true
		Me.lbErgebnis.ItemHeight = 16
		Me.lbErgebnis.Location = New System.Drawing.Point(21, 179)
		Me.lbErgebnis.Name = "lbErgebnis"
		Me.lbErgebnis.Size = New System.Drawing.Size(499, 244)
		Me.lbErgebnis.TabIndex = 5
		'
		'txtAnkunftsortAntwort
		'
		Me.txtAnkunftsortAntwort.Location = New System.Drawing.Point(643, 226)
		Me.txtAnkunftsortAntwort.Multiline = true
		Me.txtAnkunftsortAntwort.Name = "txtAnkunftsortAntwort"
		Me.txtAnkunftsortAntwort.Size = New System.Drawing.Size(204, 24)
		Me.txtAnkunftsortAntwort.TabIndex = 9
		'
		'txtAbfahrtsortAntwort
		'
		Me.txtAbfahrtsortAntwort.Location = New System.Drawing.Point(643, 179)
		Me.txtAbfahrtsortAntwort.Multiline = true
		Me.txtAbfahrtsortAntwort.Name = "txtAbfahrtsortAntwort"
		Me.txtAbfahrtsortAntwort.Size = New System.Drawing.Size(204, 24)
		Me.txtAbfahrtsortAntwort.TabIndex = 8
		'
		'laAnkunftsortAntwort
		'
		Me.laAnkunftsortAntwort.AutoSize = true
		Me.laAnkunftsortAntwort.Location = New System.Drawing.Point(544, 229)
		Me.laAnkunftsortAntwort.Name = "laAnkunftsortAntwort"
		Me.laAnkunftsortAntwort.Size = New System.Drawing.Size(84, 17)
		Me.laAnkunftsortAntwort.TabIndex = 7
		Me.laAnkunftsortAntwort.Text = "Ankunftsort:"
		'
		'laAbfahrtsortAntwort
		'
		Me.laAbfahrtsortAntwort.AutoSize = true
		Me.laAbfahrtsortAntwort.Location = New System.Drawing.Point(544, 182)
		Me.laAbfahrtsortAntwort.Name = "laAbfahrtsortAntwort"
		Me.laAbfahrtsortAntwort.Size = New System.Drawing.Size(82, 17)
		Me.laAbfahrtsortAntwort.TabIndex = 6
		Me.laAbfahrtsortAntwort.Text = "Abfahrtsort:"
		'
		'laAbgahrtszeitAntwort
		'
		Me.laAbgahrtszeitAntwort.AutoSize = true
		Me.laAbgahrtszeitAntwort.Location = New System.Drawing.Point(544, 278)
		Me.laAbgahrtszeitAntwort.Name = "laAbgahrtszeitAntwort"
		Me.laAbgahrtszeitAntwort.Size = New System.Drawing.Size(87, 17)
		Me.laAbgahrtszeitAntwort.TabIndex = 10
		Me.laAbgahrtszeitAntwort.Text = "Abfahrtszeit:"
		'
		'laAnkunftszeitAntwort
		'
		Me.laAnkunftszeitAntwort.AutoSize = true
		Me.laAnkunftszeitAntwort.Location = New System.Drawing.Point(544, 330)
		Me.laAnkunftszeitAntwort.Name = "laAnkunftszeitAntwort"
		Me.laAnkunftszeitAntwort.Size = New System.Drawing.Size(89, 17)
		Me.laAnkunftszeitAntwort.TabIndex = 11
		Me.laAnkunftszeitAntwort.Text = "Ankunftszeit:"
		'
		'laGleisAntwort
		'
		Me.laGleisAntwort.AutoSize = true
		Me.laGleisAntwort.Location = New System.Drawing.Point(544, 376)
		Me.laGleisAntwort.Name = "laGleisAntwort"
		Me.laGleisAntwort.Size = New System.Drawing.Size(44, 17)
		Me.laGleisAntwort.TabIndex = 12
		Me.laGleisAntwort.Text = "Gleis:"
		'
		'txtAbfahrtszeitAntwort
		'
		Me.txtAbfahrtszeitAntwort.Location = New System.Drawing.Point(643, 275)
		Me.txtAbfahrtszeitAntwort.Multiline = true
		Me.txtAbfahrtszeitAntwort.Name = "txtAbfahrtszeitAntwort"
		Me.txtAbfahrtszeitAntwort.Size = New System.Drawing.Size(204, 24)
		Me.txtAbfahrtszeitAntwort.TabIndex = 13
		'
		'txtAnkunftszeitAntwort
		'
		Me.txtAnkunftszeitAntwort.Location = New System.Drawing.Point(643, 327)
		Me.txtAnkunftszeitAntwort.Multiline = true
		Me.txtAnkunftszeitAntwort.Name = "txtAnkunftszeitAntwort"
		Me.txtAnkunftszeitAntwort.Size = New System.Drawing.Size(204, 24)
		Me.txtAnkunftszeitAntwort.TabIndex = 14
		'
		'txtGleisAntwort
		'
		Me.txtGleisAntwort.Location = New System.Drawing.Point(643, 373)
		Me.txtGleisAntwort.Multiline = true
		Me.txtGleisAntwort.Name = "txtGleisAntwort"
		Me.txtGleisAntwort.Size = New System.Drawing.Size(204, 24)
		Me.txtGleisAntwort.TabIndex = 15
		'
		'lbWeiterverbindungen
		'
		Me.lbWeiterverbindungen.FormattingEnabled = true
		Me.lbWeiterverbindungen.ItemHeight = 16
		Me.lbWeiterverbindungen.Location = New System.Drawing.Point(23, 433)
		Me.lbWeiterverbindungen.Name = "lbWeiterverbindungen"
		Me.lbWeiterverbindungen.Size = New System.Drawing.Size(824, 228)
		Me.lbWeiterverbindungen.TabIndex = 16
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(876, 693)
		Me.Controls.Add(Me.lbWeiterverbindungen)
		Me.Controls.Add(Me.txtGleisAntwort)
		Me.Controls.Add(Me.txtAnkunftszeitAntwort)
		Me.Controls.Add(Me.txtAbfahrtszeitAntwort)
		Me.Controls.Add(Me.laGleisAntwort)
		Me.Controls.Add(Me.laAnkunftszeitAntwort)
		Me.Controls.Add(Me.laAbgahrtszeitAntwort)
		Me.Controls.Add(Me.txtAnkunftsortAntwort)
		Me.Controls.Add(Me.txtAbfahrtsortAntwort)
		Me.Controls.Add(Me.laAnkunftsortAntwort)
		Me.Controls.Add(Me.laAbfahrtsortAntwort)
		Me.Controls.Add(Me.lbErgebnis)
		Me.Controls.Add(Me.cmdVerbindungenSuchen)
		Me.Controls.Add(Me.txtAnkunftsortFrage)
		Me.Controls.Add(Me.txtAbfahrtsortFrage)
		Me.Controls.Add(Me.laAnkunftsortFrage)
		Me.Controls.Add(Me.laAbfahrtsortFrage)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents laAbfahrtsortFrage As Label
	Friend WithEvents laAnkunftsortFrage As Label
	Friend WithEvents txtAbfahrtsortFrage As TextBox
	Friend WithEvents txtAnkunftsortFrage As TextBox
	Friend WithEvents cmdVerbindungenSuchen As Button
	Friend WithEvents lbErgebnis As ListBox
	Friend WithEvents txtAnkunftsortAntwort As TextBox
	Friend WithEvents txtAbfahrtsortAntwort As TextBox
	Friend WithEvents laAnkunftsortAntwort As Label
	Friend WithEvents laAbfahrtsortAntwort As Label
	Friend WithEvents laAbgahrtszeitAntwort As Label
	Friend WithEvents laAnkunftszeitAntwort As Label
	Friend WithEvents laGleisAntwort As Label
	Friend WithEvents txtAbfahrtszeitAntwort As TextBox
	Friend WithEvents txtAnkunftszeitAntwort As TextBox
	Friend WithEvents txtGleisAntwort As TextBox
	Friend WithEvents lbWeiterverbindungen As ListBox
End Class
