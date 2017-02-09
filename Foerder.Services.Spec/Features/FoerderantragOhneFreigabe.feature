Funktionalität: FoerderantragOhneFreigabe
	Um bei einem Antrag ohne Freigabe den aktiv Status zu prüfen
	Möchte ich als Sachbearbeiter
	Dass Die Befristung und die Datenquelle herangezogen wird

Szenario: Antrag ohne Bewilligung 
	Angenommen es existiert ein Antrag ohne Bewilligung
	Wenn ich den aktiv Status prüfe
	Dann ist der Status 'inaktiv'

Szenariogrundriss: Antrag mit Bewilligung
	Angenommen es existiert ein Antrag mit Bewilligung und Befristung bis '<Befristung>'
	Und heute ist der '<heute>'
	Dann ist der Status '<Status>'
	
Beispiele: 
	| Beschreibung                        | Befristung | heute      | Status  |
	| Befristung endete gestern - inaktiv | 01.01.2017 | 02.01.2017 | inaktiv |
	| Befristung endet morgen - aktiv     | 03.01.2017 | 02.01.2017 | aktiv   |
	| KEINE AHNUNG                        | 02.01.2017 | 02.01.2017 | inaktiv |

 Szenario: Antrag mit Bewilligung aus LgkPlus
