### Erkennen von SRP-Verstößen

#### Nicht-Technische Anzeichen (Verstehen des SRP-Verstoßes):

- **Mehrere "Und"-Aussagen**: Wenn Sie die Verantwortlichkeit einer Klasse oder Methode mit mehreren "und"-Aussagen beschreiben können, z. B. "Diese Klasse ist für das Speichern von Daten und das Senden von E-Mails verantwortlich", deutet dies auf eine Verletzung des SRP hin.

- **Verschiedene Benutzer oder Akteure**: Wenn eine Klasse oder Methode von verschiedenen Benutzern oder Akteuren verwendet wird, um unterschiedliche Aufgaben auszuführen, kann dies darauf hinweisen, dass sie zu viele Verantwortlichkeiten hat.

- **Schwierige Erklärbarkeit**: Wenn es schwierig ist, die Hauptaufgabe einer Klasse oder Methode in einem Satz zu beschreiben, könnte dies bedeuten, dass sie versucht, zu viele Dinge gleichzeitig zu tun.

#### Technische Anzeichen (Erkennen des SRP-Verstoßes im Code):

- **Lange und komplexe Methoden**: Wenn eine Methode zu lang ist und viele unterschiedliche Aufgaben in sich vereint, deutet dies darauf hin, dass das SRP verletzt sein könnte. Eine Methode sollte idealerweise nur eine klare, fokussierte Aufgabe haben.

- **Hohe Anzahl von Parametern**: Eine Methode, die viele Parameter benötigt, um verschiedene Aufgaben auszuführen, könnte gegen das SRP verstoßen. Dies kann die Lesbarkeit des Codes beeinträchtigen und die Verantwortlichkeiten der Methode verwirren.

- **Mehrere Verben oder Aktionen**: Wenn in einer Methode mehrere Verben oder Aktionen ausgeführt werden, z. B. Daten abgerufen, berechnet und gespeichert werden, ist dies ein Hinweis auf einen SRP-Verstoß.

- **Hohe Abstraktionsebene**: Wenn eine Methode auf einer sehr hohen Abstraktionsebene arbeitet und viele unterschiedliche Aufgaben innerhalb derselben Methode ausführt, kann dies ein Zeichen für eine unsaubere Trennung von Verantwortlichkeiten sein.

- **Wiederholter Code**: Wenn ähnliche Funktionalität in verschiedenen Teilen des Codes dupliziert wird, kann dies darauf hinweisen, dass die Verantwortlichkeiten nicht klar aufgeteilt sind und das SRP verletzt wird.
