
## Ziel

Das Ziel der Code-Beispiele besteht darin, einen Service oder eine Dienstleistung zu erstellen, die anhand der Höhe des beantragten Kredits, des Kreditverwendungszwecks und der Kundeninformationen feststellen kann, ob ein Kunde möglicherweise einen Kredit erhalten kann. Dies erfolgt durch die Überprüfung von Bonitätsbewertungen, das Prüfen auf Blacklisting und das Überprüfen von Bedingungen.

## Funktionen

### Kundenregistrierung überprüfen

- Überprüft, ob der Kunde bereits im System registriert ist.
- Entscheidet, ob der Kunde zusätzliche Informationen bereitstellen muss.

### Kundenregistrierung durchführen

- Führt die Registrierung des Kunden durch, wenn erforderlich.
- Bei Bedarf werden Kundendaten in die Datenbank eingefügt.

### Blacklisting überprüfen

- Ermittelt, ob der Kunde auf einer Blacklist steht, und verhindert die Kreditvergabe in diesem Fall.

### Bonitätsbewertungen sammeln

- Ermittelt sowohl die interne als auch die externe Bonitätsbewertung des Kunden, falls verfügbar.

### Bedingungen überprüfen

- Prüft, ob die Bedingungen für die Kreditvergabe erfüllt sind, einschließlich der Höhe des beantragten Kredits im Verhältnis zur Bonität des Kunden.

---
