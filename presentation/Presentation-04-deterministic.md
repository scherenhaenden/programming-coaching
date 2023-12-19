# Agenda für DevTalk: SOLID-Prinzipien und Reine Funktionen/Methoden in C#

# Reine Funktionen (Pure Functions)

Reine Funktionen sind ein Konzept aus der funktionalen Programmierung. Eine Funktion gilt als rein, wenn sie die folgenden zwei Hauptbedingungen erfüllt:

1. **Determinismus**: Die Funktion gibt bei gleichen Eingabewerten immer das gleiche Ergebnis zurück. Das bedeutet, dass das Ergebnis einer reinen Funktion nur von den Eingabewerten abhängt und keine externen Zustände verwendet werden.

2. **Keine Seiteneffekte**: Die Funktion verursacht keine Seiteneffekte in der Anwendung. Das bedeutet, dass sie keine Daten außerhalb ihres lokalen Umfangs verändert. Sie ändert keine globalen Variablen, führt keine I/O-Operationen durch und modifiziert ihre Eingabeargumente nicht.

## Vorteile von reinen Funktionen

- **Vorhersagbarkeit**: Da reine Funktionen keine externen Zustände verwenden und keine Seiteneffekte haben, sind sie einfacher zu verstehen und vorherzusagen.
- **Testbarkeit**: Reine Funktionen sind in der Regel leichter zu testen, weil man nur die Eingabe- und Ausgabewerte berücksichtigen muss.
- **Parallelisierbarkeit**: Reine Funktionen können parallel ausgeführt werden, da sie nicht von einem gemeinsamen Zustand abhängen.

## Beispiel

Eine reine Funktion zur Addition zweier Zahlen:

```javascript
function add(x, y) {
  return x + y;
}
```


# Warum reine Methoden in der OOP verwenden?

Reine Methoden in der Objektorientierten Programmierung (OOP) bieten zahlreiche Vorteile, die die Codequalität und -wartung verbessern. Im Gegensatz zu Methoden, die private Mitglieder oder geteilte Zustände (shared state) verwenden, bieten reine Methoden eine höhere Sicherheit und Zuverlässigkeit. Hier sind die Gründe, warum reine Methoden in der OOP vorteilhaft sind:

## Wartbarkeit

- **Verbesserte Wartbarkeit**: Reine Methoden in der OOP können die Wartbarkeit des Codes erhöhen. Bei reinen Methoden ist es einfacher, das Verhalten eines Objekts zu verstehen, da man sich auf die Logik der Methode konzentrieren kann, ohne sich um externe Seiteneffekte sorgen zu müssen.

## Vorhersagbarkeit

- **Mehr Vorhersagbarkeit**: Reine Methoden führen zu vorhersagbarerem Code. Wenn Sie eine reine Methode auf einem Objekt aufrufen, können Sie darauf vertrauen, dass sie den Zustand des Objekts nicht auf unerwartete Weise verändert.

## Testbarkeit

- **Leichtere Testbarkeit**: Reine Methoden sind einfacher isoliert zu testen. Sie können Unit-Tests für diese Methoden erstellen, ohne eine komplexe Einrichtung oder eine externe Manipulation des Objektzustands.

## Modularität

- **Förderung der Modularität**: Die Verwendung reiner Methoden fördert die Modularität in Ihrem OOP-Code. Jede Methode kapselt ein spezifisches Verhaltensstück ein, was es einfacher macht, das Verhalten eines Objekts zu erweitern oder zu ändern, ohne unabhängige Teile des Codes zu beeinflussen.

## Parallelismus und Nebenläufigkeit

- **Parallelismus und Nebenläufigkeit**: In der nebenläufigen oder parallelen Programmierung können reine Methoden sicher auf verschiedenen Threads oder Prozessen ausgeführt werden, da sie keinen geteilten veränderlichen Zustand haben.

## Code-Wiederverwendung

- **Hohe Wiederverwendbarkeit**: Reine Methoden sind hochgradig wiederverwendbar. Sie können die reinen Methoden eines Objekts in verschiedenen Teilen Ihrer Anwendung wiederverwenden, was die Produktivität erhöht und die Code-Duplizierung reduziert.

## Sicherheit gegenüber privaten Mitgliedern und geteiltem Zustand

- Im Vergleich zu Methoden, die private Mitglieder oder einen geteilten Zustand manipulieren, bieten reine Methoden eine höhere Sicherheit. Da sie keine externen Zustände ändern oder von ihnen abhängig sind, besteht ein geringeres Risiko für unerwartete Wechselwirkungen oder Zustandskorruptionen, die in komplexeren Systemen häufig auftreten können.


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
