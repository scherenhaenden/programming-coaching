# Single Responsibility Principle (SRP) - Prinzip der Einzelnen Verantwortlichkeit

Das Prinzip der Einzelnen Verantwortlichkeit besagt, dass jede Klasse oder Methode in unserem Code nur eine einzige klare Aufgabe haben sollte. Das bedeutet, dass sie nur für eine bestimmte Sache verantwortlich ist und nichts anderes tun sollte.

## Warum ist das wichtig?

- **Klarheit:** Wenn eine Klasse oder Methode nur eine Aufgabe hat, ist es einfacher zu verstehen, was sie tut.

- **Wartbarkeit:** Wenn sich etwas ändern muss, ist es einfacher, dies in einer Klasse oder Methode zu tun, die nur für diese Aufgabe verantwortlich ist.

- **Testbarkeit:** Es ist einfacher, einzelne Teile des Codes zu testen, wenn sie nur eine Aufgabe haben.

## Beispiele

### Auto-Klasse

Eine Klasse für Autos sollte sich nur um Aufgaben im Zusammenhang mit Autos kümmern. Sie sollte nicht für andere Dinge wie Benutzer oder Rabatte verantwortlich sein.

### Benutzer-Klasse

Eine Benutzerklasse sollte sich nur um Benutzer kümmern. Sie sollte keine Aufgaben wie Autodetails oder Rabatte behandeln.

### Rabatt-Berechnung

Eine Methode zur Berechnung von Rabatten sollte sich nur um die Rabattberechnung kümmern und keine anderen Aufgaben wie Benutzerverwaltung übernehmen.

## Vorteile des SRP

- Klarere und verständlichere Code-Struktur.
- Einfachere Fehlererkennung und Debugging.
- Bessere Wartbarkeit und Erweiterbarkeit.
- Leichtere Zusammenarbeit im Team.

Indem wir uns an das Prinzip der Einzelnen Verantwortlichkeit halten, schaffen wir Code, der sauberer, effizienter und leichter zu verwalten ist. Dies ist ein wichtiger Schritt auf dem Weg zu besserem Software-Design und besserer Zusammenarbeit im Team.
