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