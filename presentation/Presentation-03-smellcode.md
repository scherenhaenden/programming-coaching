# Agenda für DevTalk: SOLID-Prinzipien und Reine Funktionen/Methoden in C#


## Wie erkennt man Smellcode?
- Rigidity (Steifheit): Schwierigkeiten bei der Integration, Anpassung oder Löschung von Funktionalitäten, weil eine lokale Änderung weitreichende Auswirkungen im Code hat. Dies kann auf eine starke Kopplung zwischen Komponenten hinweisen.

- Fragility (Sprödigkeit): Der Code ist anfällig für Fehler, und kleine Änderungen führen oft zu Fehlern an scheinbar unverbundenen Stellen.

- Immobility (Unbeweglichkeit): Schwierigkeiten, Teile des Codes in anderen Kontexten wiederzuverwenden, da er zu stark mit dem aktuellen System verwoben ist.

- Needless Complexity (Unnötige Komplexität): Der Code enthält mehr Funktionalität als notwendig, was oft durch das "Gold Plating" entsteht, bei dem Entwickler zusätzliche Features hinzufügen, die nicht gefordert sind.

- Needless Repetition (Unnötige Wiederholung): Kopieren und Einfügen von Code, anstatt abstrakte Konstruktionen oder Wiederverwendung zu nutzen, was zu Duplikation und Inkonsistenzen führt.

- Long Methods (Lange Methoden): Übermäßig lange Methoden, die zu viel Funktionalität enthalten und schwer zu verstehen, zu testen und zu warten sind.

- Large Class (Große Klasse): Klassen, die zu viele Verantwortlichkeiten haben, was das Single-Responsibility-Prinzip (SRP) verletzt.

- Divergent Change (Auseinanderstrebende Änderung): Wenn man für verschiedene Arten von Änderungen immer wieder dieselbe Klasse ändern muss.

- Shotgun Surgery (Schrotflinten-Chirurgie): Ähnlich wie bei Divergent Change, aber in diesem Fall führt eine einzige Änderung dazu, dass man viele verschiedene Klassen anpassen muss.

- Feature Envy (Funktionsneid): Eine Methode, die mehr Interesse an den Daten oder Methoden einer anderen Klasse zu haben scheint als an denen ihrer eigenen.

- Data Clumps (Datenklumpen): Wenn verschiedene Teile des Codes immer wieder dieselben Datengruppen als Parameter verwenden, was darauf hindeutet, dass diese zusammengehören und vielleicht in einer eigenen Klasse oder Struktur untergebracht werden sollten.

- Primitive Obsession (Primitive Fixierung): Übermäßige Verwendung primitiver Datentypen anstelle von kleinen Klassen für einfache Aufgaben (wie Währungen, Ranges, spezielle Strings für Telefonnummern usw.).

- Temporary Field (Temporäres Feld): Temporäre Felder, die nur unter bestimmten Bedingungen verwendet werden, was auf eine unvollständige Klasse oder eine falsche Verantwortlichkeitszuordnung hinweisen kann.

- Inconsistent Naming (Inkonsistente Namensgebung): Inkonsistente Namensgebung, die es schwer macht zu verstehen, was der Code tut.

- Speculative Generality (Vorauseilende Ver‚allgemeinerung): Code, der "für die Zukunft" geschrieben wurde, um Funktionen zu unterstützen, die nie implementiert wurden, was zu unnötiger Komplexität führt.


## Welche Werkzeuge haben wir, um Smellcode zu bekämpfen Bzw. Welche werden wir bentuzen?
Sehr vereinfach gesagt:

    - Code Reviews
    - Pair Programming
    - Clean Code
    - Refactoring
    - Unit Tests

Gerade Clean code ist ein sehr umfangreiches Thema, daher werden wir uns heute auf die SOLID-Prinzipien und Reine Funktionen/Methoden konzentrieren.



## Deterministische und Atomare Entwicklung

### Was ist Deterministische Entwicklung?
Deterministische Entwicklung bedeutet, dass die Ergebnisse der Softwarekonstruktion vorhersehbar und reproduzierbar sind. Bei jeder Ausführung unter den gleichen Bedingungen liefert der Code das gleiche Ergebnis, ohne Zufälligkeiten oder Unklarheiten.

### Wie erreichen wir Deterministische Entwicklung?
- **Klare Spezifikationen:** Alle Anforderungen und Bedingungen müssen genau definiert sein.
- **Konsistente Umgebungen:** Entwicklung, Test und Produktion sollten so ähnlich wie möglich gehalten werden.
- **Versionierung von Abhängigkeiten:** Sichergestellt wird, dass alle Abhängigkeiten genau festgelegt und unverändert bleiben.
- **Automatisierte Tests:** Um sicherzustellen, dass Änderungen keine unerwarteten Nebeneffekte haben.
- **Code-Reviews:** Kollegen überprüfen den Code auf potenzielle Unklarheiten und Fehler.

### Was sind die Vorteile von Deterministischer Entwicklung?
- **Zuverlässigkeit:** Das System verhält sich konsistent und vertrauenswürdig.
- **Wartbarkeit:** Probleme können einfacher identifiziert und behoben werden, wenn das Verhalten des Systems vorhersehbar ist.
- **Sicherheit:** Es gibt weniger Raum für unvorhersehbare Sicherheitslücken.

### Was ist Atomare Entwicklung?
Atomare Entwicklung bezieht sich auf das Prinzip, Änderungen in kleinstmöglichen Einheiten vorzunehmen. Jede Änderung ist eigenständig und beeinflusst nicht das Gesamtsystem oder andere Teile des Codes.

### Wie erreichen wir Atomare Entwicklung?
- **Modulare Architektur:** Der Code sollte in kleine, unabhängige Module unterteilt werden.
- **Feature Flags/Toggles:** Ermöglichen es, bestimmte Funktionen unabhängig zu aktivieren oder zu deaktivieren.
- **Branching-Strategien:** Isolierte Entwicklungszweige für einzelne Features oder Änderungen.
- **Continuous Integration:** Frühe und regelmäßige Integration von Änderungen, um Isolation zu vermeiden.

### Was sind die Vorteile von Atomarer Entwicklung?
- **Einfachere Fehlerbehebung:** Da Änderungen klein sind, können Fehler leichter lokalisiert werden.
- **Flexibilität:** Features können unabhängig voneinander entwickelt, getestet und ausgerollt werden.
- **Bessere Kontrolle:** Änderungen können einzeln verwaltet und bei Bedarf rückgängig gemacht werden, ohne andere Bereiche zu beeinträchtigen.



## SOLID-Prinzipien

SOLID ist ein Akronym, das für fünf grundlegende Prinzipien der objektorientierten Programmierung und des Designs steht. Diese Prinzipien helfen Entwicklern dabei, Systeme zu entwerfen, die leicht zu warten und zu erweitern sind.

### S: Single Responsibility Principle (SRP)
- Jede Klasse sollte nur eine einzige Verantwortlichkeit haben.
- Eine Klasse sollte nur einen Grund haben, sich zu ändern.
- Dies führt zu einer höheren Kohäsion innerhalb der Klasse und zu einer geringeren Kopplung zwischen Klassen.

### O: Open/Closed Principle (OCP)
- Softwareentitäten (Klassen, Module, Funktionen usw.) sollten offen für Erweiterung, aber geschlossen für Modifikation sein.
- Dies bedeutet, dass das Verhalten einer Einheit erweitert werden kann, ohne den bestehenden Code zu ändern.

### L: Liskov Substitution Principle (LSP)
- Objekte einer Superklasse sollten in der Lage sein, durch Objekte von Subklassen ersetzt zu werden, ohne das korrekte Funktionieren des Systems zu beeinträchtigen.
- Dieses Prinzip sorgt für die korrekte Vererbungshierarchie, sodass die abgeleiteten Klassen tatsächlich als Erweiterungen ihrer Basisklassen fungieren.

### I: Interface Segregation Principle (ISP)
- Kein Client sollte gezwungen sein, abhängig von Methoden zu sein, die er nicht verwendet.
- Schnittstellen sollten spezifisch für die Clients sein, die sie verwenden, anstatt eine einzige generelle Zweck-Schnittstelle zu haben.

### D: Dependency Inversion Principle (DIP)
- Abhängigkeiten innerhalb des Systems sollten auf Abstraktionen und nicht auf konkreten Details beruhen.
- Hochrangige Module sollten nicht von niedrigrangigen Modulen abhängen, sondern beide sollten von Abstraktionen abhängen.

Diese Prinzipien sind eng miteinander verknüpft und tragen dazu bei, eine Codebasis zu schaffen, die widerstandsfähig gegenüber Veränderungen ist, einfacher zu verstehen und zu testen ist und eine langfristige Wartbarkeit fördert.





