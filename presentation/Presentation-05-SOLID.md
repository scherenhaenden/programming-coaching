# Agenda für DevTalk: SOLID-Prinzipien und Reine Funktionen/Methoden in C#

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





