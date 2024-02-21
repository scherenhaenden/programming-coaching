# MockedModels Klasse

Die `MockedModels` Klasse ist Teil eines Programms im Zusammenhang mit der Verwaltung von Auto-Leasing und dient als Quelle für Mock-Daten von Benutzern und Autos. Sie ist dafür verantwortlich, Listen von `UserModel`- und `CarModel`-Objekten zu erstellen und mit Mock-Daten zu füllen, um die Simulation von Datenbanken oder externen Datenquellen zu ermöglichen.

## Eigenschaften

- `Users`: Eine Liste von `UserModel`-Objekten, die Mock-Benutzerdaten darstellen.
- `Cars`: Eine Liste von `CarModel`-Objekten, die Mock-Autodaten darstellen.

## Konstruktor

Die `MockedModels` Klasse verfügt über einen Konstruktor, der die `Users`- und `Cars`-Eigenschaften initialisiert, indem Mock-Daten zu diesen Listen hinzugefügt werden. Hier ist eine Aufschlüsselung der hinzugefügten Daten:

### Benutzer (Users)

- Es erstellt fünf Mock-Benutzerobjekte mit unterschiedlichen IDs, Namen und Passwörtern.

### Autos (Cars)

- Es erstellt sechs Mock-Autoobjekte mit unterschiedlichen IDs, Namen, Marken, Modellen, Baujahren, Preisen, Anzahl der Türen, Anzahl der Sitze, Autotypen und Fahrzeugspuren.

## Zweck

Die `MockedModels` Klasse wird zu Test- und Entwicklungszwecken verwendet, um das Vorhandensein von Benutzern und Autos zu simulieren, ohne auf eine tatsächliche Datenbank oder externe Datenquelle angewiesen zu sein. Sie ermöglicht Entwicklern, mit Beispieldaten zu arbeiten, wenn sie verschiedene Funktionen im Programm implementieren und testen.

## Verwendung

Diese Klasse wird in der Regel in Verbindung mit anderen Klassen und Methoden verwendet, die auf Benutzer- und Autodaten zugreifen müssen. Sie bietet eine bequeme Möglichkeit, auf Mock-Daten für Tests und Entwicklung zuzugreifen.

## Beispielverwendung

```csharp
// Erstellen einer Instanz von MockedModels, um auf Mock-Daten zuzugreifen
var mockedData = new MockedModels();

// Zugriff auf Mock-Benutzerdaten
var users = mockedData.Users;
var user1 = users.FirstOrDefault(u => u.Name == "User1");

// Zugriff auf Mock-Autodaten
var cars = mockedData.Cars;
var car1 = cars.FirstOrDefault(c => c.Name == "Car1");
