# Beispiel des Prinzips der Abhängigkeitsumkehr (DIP)

Dieses Dokument veranschaulicht die Anwendung des Prinzips der Abhängigkeitsumkehr (Dependency Inversion Principle, DIP) bei der Verwaltung von Aufgaben mit verschiedenen Versionen von `TaskEngineType`. DIP ist eines der fünf SOLID-Prinzipien der objektorientierten Gestaltung und Programmierung. Es betont die Entkopplung von Modulen auf hoher und niedriger Ebene durch Abstraktionen.

## Schlechte Beispiele

Ursprünglich waren verschiedene Versionen von `TaskManager` eng mit bestimmten Versionen von `TaskEngineType` gekoppelt. Dies führte zu Code-Duplizierung und erhöhte die Wartungskomplexität.

### TaskManagerSchlechtesBeispiel1

- **Zweck**: Verwaltet Aufgaben mit `TaskEngineTypeV1`.
- **Methode**: `RunTask(TaskEngineTypeV1 taskEngineTypeV1)`
  - Führt die Aufgabe aus, indem `taskEngineTypeV1.Run()` aufgerufen wird, was "TaskEngineType1 wird ausgeführt" ausgibt.

### TaskManagerSchlechtesBeispiel2

- **Zweck**: Verwaltet Aufgaben mit `TaskEngineTypeV2`.
- **Methode**: `RunTask(TaskEngineTypeV2 taskEngineTypeV2)`
  - Führt die Aufgabe aus, indem `taskEngineTypeV2.Run()` aufgerufen wird, was "TaskEngineTypeV2 wird ausgeführt" ausgibt.

### TaskManagerSchlechtesBeispiel3

- **Zweck**: Verwaltet Aufgaben mit `TaskEngineTypeV3`.
- **Methode**: `RunTask(TaskEngineTypeV3 taskEngineTypeV3)`
  - Führt die Aufgabe aus, indem `taskEngineTypeV3.Run()` aufgerufen wird, was "TaskEngineTypeV3 wird ausgeführt" ausgibt.

## Verbessertes Beispiel mit dem Prinzip der Abhängigkeitsumkehr

Das verbesserte Beispiel zeigt die Umsetzung des DIP. Es führt eine Schnittstelle `ITaskEngineType` ein und macht `TaskManagerFixedExample` von dieser Abstraktion abhängig anstelle von konkreten Implementierungen des Aufgabenmotors.

### ITaskEngineType (Schnittstelle)

- **Zweck**: Definiert einen Vertrag für Aufgabenmotoren mit einer Methode `Run`.

### TaskEngineTypeV1, TaskEngineTypeV2, TaskEngineTypeV3 (Implementierungen von ITaskEngineType)

- **Zweck**: Implementiert die Schnittstelle `ITaskEngineType`.
- **Methode**: `Run()`
  - Jede Klasse hat ihre eigene Version der Methode `Run`, die die jeweilige Version des Aufgabenmotors ausgibt.

### TaskManagerFixedExample

- **Zweck**: Verwaltet Aufgaben mit einer beliebigen Implementierung von `ITaskEngineType`.
- **Methode**: `RunTask(ITaskEngineType taskEngineType)`
  - Führt die Aufgabe aus, indem `taskEngineType.Run()` aufgerufen wird. Dieses Design ermöglicht es `TaskManagerFixedExample`, mit jeder Version von `TaskEngineType` zu arbeiten, ohne Änderungen am Code vorzunehmen.

## Fazit

Durch die Anwendung des Prinzips der Abhängigkeitsumkehr wird `TaskManagerFixedExample` unabhängig von den konkreten Versionen von `TaskEngineType` gemacht. Es ist von der Schnittstelle `ITaskEngineType` abhängig, was ein flexibleres und wartungsfreundlicheres Design fördert. Dieser Ansatz ermöglicht die einfache Hinzufügung neuer Aufgabenmotoren, ohne den Aufgabenmanager zu beeinträchtigen, und zeigt die Stärke der Abhängigkeitsumkehr in der Softwaregestaltung.
