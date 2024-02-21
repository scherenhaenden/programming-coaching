# AutoLeasingManagementBad Klasse

Die Klasse `AutoLeasingManagementBad` ist Teil eines Programms zur Verwaltung von Auto-Leasing und zeigt ein Codebeispiel, das gegen das Prinzip der Einzelverantwortlichkeit (Single Responsibility Principle, SRP) der SOLID-Prinzipien verstößt. Dieser Code wird als "schlechtes" Beispiel betrachtet, da er mehrere Verantwortlichkeiten in einer einzigen Klasse kombiniert.

## Zweck

Der Hauptzweck dieser Klasse besteht darin, eine Liste verfügbarer Autos basierend auf verschiedenen Filterkriterien abzurufen, die als Methodenparameter bereitgestellt werden. Sie bietet auch einen Rabatt auf Autopreise unter bestimmten Bedingungen.

## Abhängigkeiten

Diese Klasse ist von den folgenden Namespaces und Klassen abhängig:

- `ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.DummyData`: Dieser Namespace wird verwendet, um Mock-Daten für Benutzer und Autos abzurufen.
- `ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.Models`: Dieser Namespace wird verwendet, um mit Datenmodellen wie `CarModel` und `UserModel` zu arbeiten.

## Methode: GetAvailableCarsOnRequest

Die Methode `GetAvailableCarsOnRequest` ruft eine Liste verfügbarer Autos basierend auf den folgenden Parametern ab:

- `userLogin`: Der Name des Benutzers, der die Autos anfordert.
- `carType`: Der Autotyp, nach dem gefiltert werden soll (optional).
- `carTrack`: Die Fahrzeugspur, nach der gefiltert werden soll (optional).
- `tryDiscount`: Ein boolescher Wert, der angibt, ob ein Rabatt auf die Autopreise angewendet werden soll (Standardwert ist `false`).
- `minNumberOfDoors`: Die minimale Anzahl von Türen für die Filterung (Standardwert ist `0`).
- `miNumberOfSeats`: Die minimale Anzahl von Sitzen für die Filterung (Standardwert ist `0`).
- `year`: Das minimale Jahr für die Filterung (Standardwert ist `0`).
- `maxPrice`: Der maximale Preis für die Filterung (Standardwert ist `0`).

### Code-Erklärung

1. Sie initialisiert `users` und `cars`, indem sie auf Mock-Daten zugreift.
2. Sie versucht, einen Benutzer mit dem bereitgestellten `userLogin` zu finden. Wenn der Benutzer nicht gefunden wird und `tryDiscount` `true` ist, wird eine Ausnahme ausgelöst.
3. Sie wendet verschiedene Filter basierend auf den bereitgestellten Parametern an, um die Liste der verfügbaren Autos einzuschränken.
4. Wenn `tryDiscount` `true` ist und ein Benutzer gefunden wird, wendet sie einen Rabatt auf die Autopreise an.
5. Schließlich gibt sie die gefilterte und optional rabattierte Liste von Autos zurück.

## Code-Probleme

Dieser Code verstößt gegen das Prinzip der Einzelverantwortlichkeit (Single Responsibility Principle, SRP), da er mehrere Verantwortlichkeiten in einer einzelnen Methode kombiniert:

- Datenzugriff (Abrufen von Benutzern und Autos).
- Filtern von Autos basierend auf verschiedenen Kriterien.
- Anwenden von Rabatten auf Autopreise.
- Behandeln von Ausnahmen.

Dies macht den Code weniger wartbar und schwerer testbar. Ein besseres Vorgehen wäre die Aufteilung dieser Verantwortlichkeiten in separate Klassen oder Methoden, um die SOLID-Prinzipien einzuhalten und die Codequalität zu verbessern.
