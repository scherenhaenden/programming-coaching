# AutoLeasingManagementFixed Klasse

Die Klasse `AutoLeasingManagementFixed` ist Teil eines Programms zur Verwaltung von Auto-Leasing und stellt eine refaktorierte und verbesserte Version des vorherigen "schlechten" Beispiels dar. Diese Klasse hält sich an das Prinzip der Einzelverantwortlichkeit (Single Responsibility Principle, SRP) der SOLID-Prinzipien, indem sie Verantwortlichkeiten in verschiedene Dienste aufteilt.

## Abhängigkeiten

Diese Klasse ist von den folgenden Diensten und Klassen abhängig:

- `UserManager`: Ein Dienst zur Verwaltung von Benutzerinformationen.
- `CarFilterService`: Ein Dienst zur Filterung von Autos basierend auf verschiedenen Kriterien.
- `DiscountService`: Ein Dienst zur Anwendung von Rabatten auf Autopreise.
- `CarFilterOptions`: Ein Objekt, das Filteroptionen für Autos darstellt.

## Konstruktor

Die Klasse verfügt über einen Konstruktor, der Instanzen der Dienste `UserManager`, `CarFilterService` und `DiscountService` initialisiert. Dieser Konstruktor richtet die für die Operationen der Klasse erforderlichen Abhängigkeiten ein.

## Methode: GetAvailableCarsOnRequest

Diese Methode ruft eine Liste verfügbarer Autos basierend auf den bereitgestellten Filteroptionen und der Möglichkeit der Anwendung eines Rabatts ab. Sie folgt den folgenden Schritten:

1. Sie verwendet den `CarFilterService`, um Autos basierend auf den bereitgestellten Filteroptionen zu filtern.
2. Wenn die Option `TryDiscount` aktiviert ist, überprüft sie die Existenz des Benutzers mithilfe des `UserManager`.
3. Wenn der Benutzer gefunden wird, wendet sie mit dem `DiscountService` einen Rabatt auf die Autopreise an und gibt die rabattierte Liste von Autos zurück. Andernfalls gibt sie die unveränderte Liste von Autos zurück.

## Methode: GetAvailableCarsOnRequestWithResponseModel

Diese Methode ist ähnlich wie die vorherige, gibt jedoch ein `ResponseModel`-Objekt zurück, das die Liste von Autos und eine Fehlermeldung (falls vorhanden) enthält. Dies ist eine strukturiertere Methode zur Behandlung von Antworten.

## CarFilterService

Die Klasse `CarFilterService` ist für die Filterung von Autos basierend auf den bereitgestellten `CarFilterOptions` verantwortlich. Sie übernimmt die Verantwortung für die Filterung von Autos aus der Hauptklasse.

## DiscountService

Die Klasse `DiscountService` ist für die Anwendung von Rabatten auf Autopreise verantwortlich. Sie enthält Methoden zur Anwendung von Rabatten und zur Rückgabe strukturierter `ResponseModel`-Objekte mit Fehlermeldungen, wenn erforderlich. Diese Klasse kapselt die Rabattlogik.

## UserManager

Die Klasse `UserManager` ist für die Verwaltung von Benutzerinformationen und das Abrufen von Benutzern anhand ihres Anmeldenamens verantwortlich. Sie isoliert benutzerbezogene Logik von der Hauptklasse und sorgt für eine bessere Trennung der Zuständigkeiten.

## Überlegungen

Durch die Aufteilung von Verantwortlichkeiten in separate Dienste hält sich die Klasse `AutoLeasingManagementFixed` an SRP und macht den Code wartbarer, testbarer und modularer. Diese Umstrukturierung verbessert die Codequalität und folgt bewährten Praktiken im Software-Design.



# CarFilterService Klasse

Die Klasse `CarFilterService` ist für die Filterung von Autos basierend auf den bereitgestellten `CarFilterOptions` verantwortlich. Sie kapselt die Logik zur Einschränkung der Liste von Autos basierend auf verschiedenen Kriterien.

## Eigenschaften

- `_cars`: Ein privates Feld, das eine Liste von `CarModel`-Objekten speichert, die Mock-Autodaten darstellen.

## Konstruktor

Die Klasse initialisiert `_cars`, indem sie auf Mock-Daten aus der Klasse `MockedModels` zugreift, um eine Datenquelle für Filteroperationen bereitzustellen.

## Methode: FilterCars

Die Methode `FilterCars` nimmt ein `CarFilterOptions`-Objekt als Parameter und filtert die Liste von Autos basierend auf den angegebenen Kriterien. Sie führt die folgenden Aktionen aus:

- Filtert Autos basierend auf der minimalen Anzahl von Türen (`MinNumberOfDoors`).
- Filtert Autos basierend auf der minimalen Anzahl von Sitzen (`MinNumberOfSeats`).
- Filtert Autos basierend auf dem minimalen Jahr (`Year`).
- Filtert Autos basierend auf dem maximalen Preis (`MaxPrice`).
- Filtert Autos basierend auf dem Autotyp (`CarType`).
- Filtert Autos basierend auf der Fahrzeugspur (`CarTrack`).

Die Methode gibt eine gefilterte Liste von Autos basierend auf den bereitgestellten Kriterien zurück.

# DiscountService Klasse

Die Klasse `DiscountService` ist für die Anwendung von Rabatten auf Autopreise verantwortlich. Sie kapselt die Rabattlogik und bietet Methoden zur
