# CarModel Klasse

Die `CarModel` Klasse ist Teil eines Programms im Zusammenhang mit der Verwaltung von Auto-Leasing und repräsentiert ein Datenmodell für Autos. Sie definiert verschiedene Eigenschaften, die die Merkmale eines Autos beschreiben.

## Eigenschaften

- `Id`: Eine Ganzzahl, die den eindeutigen Bezeichner des Autos darstellt.
- `Name`: Ein Zeichenfolge, die den Namen des Autos darstellt.
- `Marke`: Eine Zeichenfolge, die die Marke des Autos darstellt.
- `Modell`: Eine Zeichenfolge, die das Modell des Autos darstellt.
- `Jahr`: Eine Ganzzahl, die das Herstellungsjahr des Autos darstellt.
- `Preis`: Eine Gleitkommazahl, die den Preis des Autos darstellt.
- `AnzahlDerTüren`: Eine Ganzzahl, die die Anzahl der Türen im Auto darstellt.
- `AnzahlDerSitze`: Eine Ganzzahl, die die Anzahl der Sitze im Auto darstellt.
- `AutoTyp`: Eine Aufzählung, die den Typ des Autos darstellt (z.B. Limousine, SUV usw.).
- `AutoSpur`: Eine Aufzählung, die die Fahrzeugspur darstellt (z.B. Standard, Offroad usw.).

## Zweck

Die `CarModel` Klasse dient als Datenstruktur zur Speicherung von Informationen über Autos, wie deren Merkmale und Eigenschaften. Sie wird im Programm verwendet, um Auto-Objekte darzustellen und die Datenmanipulation zu erleichtern.

## Verwendung

Diese Klasse wird in der Regel in Verbindung mit anderen Klassen und Methoden verwendet, um Informationen über Autos in einem Auto-Leasing-Verwaltungssystem zu erstellen, abzurufen, zu aktualisieren und anzuzeigen.

## Beispielverwendung

```csharp
// Erstellen eines neuen Auto-Objekts
var auto = new CarModel
{
    Id = 1,
    Name = "Mein Auto",
    Marke = "Markenname",
    Modell = "Modellname",
    Jahr = 2023,
    Preis = 25000,00,
    AnzahlDerTüren = 4,
    AnzahlDerSitze = 5,
    AutoTyp = CarType.Limousine,
    AutoSpur = CarTrack.Standard
};

// Zugriff auf Autoeigenschaften
Console.WriteLine($"Auto-Name: {auto.Name}");
Console.WriteLine($"Auto-Marke: {auto.Marke}");
// ...und so weiter
