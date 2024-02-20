# Richtlinien für die Verwendung von reinen Methoden in .NET

Dieses Dokument bietet eine Übersicht darüber, wann und wann nicht reine Methoden in .NET-Projekten verwendet werden sollen. Reine Methoden sind solche, die keine sichtbaren Nebeneffekte haben und bei gleichen Eingaben immer das gleiche Ergebnis liefern. Sie spielen eine wichtige Rolle in der Erstellung von vorhersagbaren, testbaren und wartbaren Anwendungen.

## Wann reine Methoden benutzt werden sollen

### 1. Berechenbarkeit und Vorhersagbarkeit

Reine Methoden verbessern die Vorhersagbarkeit des Codes, da das Ergebnis ausschließlich von den Eingabeparametern abhängt. Dies erleichtert das Verständnis, das Debugging und die Wartung des Codes.

### 2. Testbarkeit

Durch die Abwesenheit von externen Abhängigkeiten oder Zuständen sind reine Methoden einfacher zu testen. Tests können isoliert durchgeführt werden, ohne eine komplexe Testumgebung aufbauen zu müssen.

### 3. Parallelisierung und Nebenläufigkeit

Reine Methoden sind ideal für parallele Ausführungen und Anwendungen mit hoher Nebenläufigkeit, da sie keinen gemeinsamen Zustand verändern und somit thread-sicher sind.

### 4. Wiederverwendbarkeit und Modularität

Die Unabhängigkeit von externen Zuständen macht reine Methoden hochgradig wiederverwendbar und fördert eine modulare Codebasis.

### 5. Funktionale Programmierparadigmen

In Umgebungen, die funktionale Programmierkonzepte fördern oder verwenden, sind reine Methoden grundlegend und werden stark bevorzugt.

## Wann reine Methoden nicht benutzt werden sollen

### 1. Zugriff auf externe Ressourcen

Methoden, die externe Ressourcen wie Dateisysteme, Datenbanken oder Netzwerkdienste verwenden müssen, können nicht rein sein, da diese Aktionen externe Zustände verändern oder von ihnen abhängen.

### 2. Änderung des Objektzustands

Methoden, die den Zustand eines Objekts ändern, sind nicht als rein zu betrachten, da sie direkte Seiteneffekte innerhalb des Objekts verursachen.

### 3. Seiteneffekte sind erforderlich

In Fällen, wo Seiteneffekte (wie Logging) ein erwünschtes Verhalten sind, sind reine Methoden nicht geeignet.

### 4. Leistungsüberlegungen

In einigen Situationen kann die Verwendung reiner Methoden, insbesondere wenn sie eine unnötige Neuberechnung von bereits vorhandenen Daten erfordern, zu Leistungseinbußen führen.

## Schlussfolgerung

Reine Methoden bieten viele Vorteile in der Softwareentwicklung, sind jedoch nicht für alle Situationen geeignet. Die Entscheidung, ob reine Methoden verwendet werden sollen, hängt von den spezifischen Anforderungen des Projekts, den Leistungsüberlegungen und dem gewünschten Programmierparadigma ab. Ent
