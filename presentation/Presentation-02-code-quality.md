# Agenda für DevTalk: SOLID-Prinzipien und Reine Funktionen/Methoden in C#


## Was versteht man unter Code-Qualität?

Code-Qualität unterscheidet sich wesentlich von einfachem Code. Als relativ junge Disziplin entwickelt sich das Software Engineering stetig weiter. Zunächst mag Code in kleinerem Umfang noch gut lesbar und einfach handhabbar sein. Aber jenseits einer gewissen Komplexität kann der Code sehr schwierig zu bewältigen sein. Dies beeinträchtigt das Gleichgewicht zwischen der effizienten Bereitstellung neuer, benötigter Funktionalitäten und der Handhabbarkeit des Codes. Deshalb gibt es eine Vielzahl von Tools und Techniken, die eingesetzt werden können, um hohe Code-Qualität zu erreichen.

## Warum ist Code-Qualität wichtig?

Code-Qualität ist von großer Bedeutung, da sie sich direkt auf die Effizienz, Wartbarkeit und Zuverlässigkeit eines Softwareprojekts auswirkt. Hochwertiger Code ist einfacher zu verstehen, zu warten und zu erweitern. Dies führt zu geringeren Entwicklungskosten, kürzeren Markteinführungszeiten und einer insgesamt verbesserten Benutzererfahrung.

## Zeitverlust durch schlechten Code

Eine Schätzung des Zeitverlusts für Entwickler aufgrund von schlecht gestaltetem Code kann stark variieren und hängt von vielen Faktoren ab, wie der Komplexität des Projekts, der Erfahrung der Entwickler, der Qualität der Dokumentation und der Effizienz der Entwicklungswerkzeuge. Trotzdem kann ich Ihnen eine grobe Schätzung geben:

### Minimale Schätzung (Best-Case-Szenario):
- **Wartung und Bugfixing:** 10-20% zusätzliche Zeit.
- **Code-Verständnis:** 5-10% zusätzliche Zeit.
- **Erweiterung/Änderung der Funktionalität:** 10-15% zusätzliche Zeit.
- **Code-Refactoring:** 5-10% zusätzliche Zeit.
- **Gesamt:** 30-55% zusätzlicher Zeitaufwand.

### Maximale Schätzung (Worst-Case-Szenario):
- **Wartung und Bugfixing:** 25-40% zusätzliche Zeit.
- **Code-Verständnis:** 15-25% zusätzliche Zeit.
- **Erweiterung/Änderung der Funktionalität:** 20-35% zusätzliche Zeit.
- **Code-Refactoring:** 10-20% zusätzliche Zeit.
- **Gesamt:** 70-120% zusätzlicher Zeitaufwand.

### Bedenken Sie:
- **Teamdynamik:** Ein eingespieltes Team kann trotz schlechten Codes effizienter arbeiten als ein weniger erfahrenes Team.
- **Technologische Hilfsmittel:** Moderne Entwicklungswerkzeuge und -praktiken können die Auswirkungen von schlechtem Code mildern.
- **Art des Projekts:** Bei komplexen, langfristigen Projekten sind die Auswirkungen schlechten Designs gravierender als bei kleineren, kurzfristigen Projekten.

### Fazit:
Diese Schätzungen sind sehr allgemein. Für eine genauere Einschätzung sollten Sie eine gründliche Code-Analyse durchführen und die spezifischen Umstände Ihres Projekts und Ihres Teams berücksichtigen.

[
## Was ist Code-Qualität/Clean Code?
   
   ### Was ist Code-Qualität?

   Code-Qualität ist ein Indikator dafür, wie gut der Code verschiedene Standards und Anforderungen erfüllt. Hier sind Schlüsselaspekte, die bei der Bewertung der Code-Qualität berücksichtigt werden:

### Wie erreicht man Code-Qualität?

Um die Code-Qualität zu verbessern, können verschiedene bewährte Praktiken und Werkzeuge angewendet werden:

- **Code-Standards und Konventionen:** Die Einhaltung klarer Codierungsstandards und Namenskonventionen fördert die Lesbarkeit und Wartbarkeit des Codes.
- **Code-Reviews:** Regelmäßige Überprüfung des Codes durch andere Entwickler, um Fehler und Verbesserungspotenziale zu identifizieren.
- **Automatisierte Tests:** Erstellung von Unit-Tests und Integrationstests zur Sicherstellung der korrekten Funktionsweise des Codes und zur Vermeidung unerwünschter Nebenwirkungen bei Änderungen.
- **Statische Code-Analyse:** Einsatz von Tools zur statischen Code-Analyse, um potenzielle Probleme im Code frühzeitig zu erkennen.
- **Refaktorisierung:** Kontinuierliche Verbesserung des Codes durch Refaktorisierung zur Reduzierung von Duplikationen und Steigerung der Lesbarkeit.
- **Dokumentation:** Erstellung klarer und nützlicher Dokumentation, die Entwicklern hilft, den Code zu verstehen und zu nutzen.

### Was ist Clean Code?
Clean Code ist ein Begriff aus der Softwareentwicklung, der sich auf Code bezieht, der einfach zu lesen, zu verstehen und zu ändern ist. Er folgt guten Programmierpraktiken und Prinzipien, die eine hohe Qualität und eine effiziente Zusammenarbeit innerhalb von Entwicklungsteams gewährleisten.

### Wie schreiben wir Clean Code?
- **Klare Namensgebung:** Variablen, Funktionen und Klassen sollten so benannt werden, dass ihre Funktion offensichtlich ist.
- **Konsistente Formatierung:** Der Code sollte einheitlich formatiert sein, um die Lesbarkeit zu erhöhen.
- **Vermeidung von großen Klassen und Methoden:** Große Klassen und Methoden sollten in kleinere, verwaltbare Einheiten aufgeteilt werden.
- **Dokumentation:** Wichtige Designentscheidungen und komplexe Bereiche sollten dokumentiert werden.
- **Vermeidung von Duplikationen (DRY-Prinzip):** Jedes Stück Wissen im System sollte eine eindeutige, autoritative und explizite Darstellung haben.
- **Fokussierung auf Qualität:** Code-Reviews und Paarprogrammierung können dazu beitragen, die Codequalität zu sichern und zu verbessern.

### Kernprinzipien von Clean Code:
- **Performance**: Effizienter Code führt Aufgaben schnell und mit optimaler Nutzung von Ressourcen aus.
- **Zuverlässigkeit**: Zuverlässiger Code arbeitet unter den gegebenen Bedingungen konstant und vorhersehbar.
- **Portabilität**: Guter Code kann einfach von einer Umgebung in eine andere übertragen werden, ohne dass umfangreiche Änderungen nötig sind.
- **Skalierbarkeit**: Code sollte in der Lage sein, mit dem Wachstum und den sich ändernden Anforderungen eines Systems zu skalieren.
- **Sicherheit**: Der Code sollte sicher sein und Schutz gegen bekannte Sicherheitsrisiken wie SQL-Injection oder Cross-Site Scripting bieten.
- **Lesbarkeit**: Der Code sollte so geschrieben sein, dass andere Entwickler ihn leicht verstehen können, als wäre er gut geschriebene Prosa.
- **Einfachheit**: Der Code sollte so einfach wie möglich sein, ohne unnötige Komplexität.
- **Refaktorisierung**: Regelmäßige Verbesserung der Codebasis, um Redundanzen zu eliminieren und die Struktur zu optimieren.
- **Testbarkeit**: Der Code sollte so strukturiert sein, dass er leicht testbar ist.
- **Wartbarkeit**: Der Code sollte so organisiert sein, dass er leicht zu warten ist.
- **Verwendung von Best Practices**: Einhaltung bewährter Programmierstandards und -richtlinien.


### Vorteile von Clean Code:
- **Effizienz:** Reduzierung der Zeit, die benötigt wird, um neue Features zu implementieren oder bestehende zu ändern.
- **Zuverlässigkeit:** Geringere Fehlerquote und höhere Systemstabilität.
- **Skalierbarkeit:** Einfachere Erweiterung und Anpassung der Software an neue Anforderungen.
- **Teamzusammenarbeit:** Vereinfachte Zusammenarbeit und Onboarding neuer Teammitglieder.

Clean Code ist nicht nur eine Praxis, sondern auch eine Philosophie, die Entwickler dazu anhält, Stolz auf ihre Arbeit zu nehmen und Code zu schreiben, der nicht nur funktioniert, sondern auch gut gepflegt und erweitert werden kann.


Insgesamt ist Code-Qualität ein wesentlicher Aspekt der Softwareentwicklung, der zur Erstellung zuverlässiger und wartbarer Softwareprodukte beiträgt. Durch den Einsatz bewährter Praktiken und entsprechender Werkzeuge können Entwickler kontinuierlich zur Verbesserung der Code-Qualität beitragen.