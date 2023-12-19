### Erkennen von DIP-Verstößen

#### Nicht-Technische Anzeichen (Verstehen des DIP-Verstoßes):

- **Direkte Abhängigkeiten zu konkreten Klassen**: Wenn eine Komponente (hoher Grad) direkte Abhängigkeiten zu konkreten Klassen (niedriger Grad) hat, statt von abstrakten Schnittstellen oder Klassen abhängig zu sein, könnte dies auf einen Verstoß gegen das DIP hinweisen.

- **Schwierigkeiten bei der Wiederverwendung von Komponenten**: Wenn es schwer ist, eine Komponente in verschiedenen Kontexten wiederzuverwenden, weil sie starre Abhängigkeiten zu spezifischen Implementierungen hat, kann dies auf DIP-Verletzungen hinweisen.

- **Harte Kopplung an Details**: Wenn eine Komponente Details über die Implementierungsdetails anderer Komponenten kennt und darauf angewiesen ist, kann dies auf einen DIP-Verstoß hinweisen.

#### Technische Anzeichen (Erkennen des DIP-Verstoßes im Code):

- **Verwendung von "new" für Konstruktion**: Wenn eine Klasse die "new"-Anweisung verwendet, um Abhängigkeiten direkt zu instanziieren, statt sie über Injektion oder IoC-Container bereitzustellen, könnte dies auf DIP-Verstöße hinweisen.

- **Direkte Instanzierung von konkreten Klassen**: Wenn eine Klasse konkrete Klassen direkt instanziiert, anstatt abstrakte Schnittstellen oder Basisklassen zu verwenden, kann dies auf einen DIP-Verstoß hinweisen.

- **Harte Verdrahtung von Abhängigkeiten**: Wenn Abhängigkeiten zwischen Komponenten hart verdrahtet sind, anstatt durch Konstruktorinjektion oder Dependency Injection Frameworks gelöst zu werden, könnte dies auf DIP-Verletzungen hinweisen.

- **Fehlende Schnittstellen oder abstrakte Klassen**: Wenn Klassen und Komponenten keine Schnittstellen oder abstrakten Basisklassen verwenden, um Abhängigkeiten zu kapseln, kann dies auf DIP-Verstöße hinweisen.

- **Verstoß gegen das "Hochrangiges kontra Niedrigrangiges"-Prinzip**: Wenn hochrangige Module von niedrigrangigen Modulen abhängig sind, statt umgekehrt, kann dies auf einen DIP-Verstoß hinweisen.
