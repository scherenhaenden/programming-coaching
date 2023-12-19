### Erkennen von OCP-Verstößen

#### Nicht-Technische Anzeichen (Verstehen des OCP-Verstoßes):

- **Häufige Änderungen an bestehendem Code**: Wenn Änderungen an einer Klasse oder Methode dazu führen, dass auch andere Teile des Codes häufig angepasst werden müssen, um die neuen Anforderungen zu erfüllen, könnte dies auf einen Verstoß gegen das OCP hinweisen.

- **Mangelnde Erweiterbarkeit**: Wenn das Hinzufügen neuer Funktionalität zu einer bestehenden Klasse erhebliche Änderungen an deren Implementierung erfordert und bestehende Codepfade beeinträchtigt, könnte dies ein Indikator für OCP-Verletzungen sein.

- **Hohe Komplexität**: Wenn eine Klasse oder Methode aufgrund ihrer Größe oder Komplexität schwer zu verstehen und zu erweitern ist, könnte dies auf einen OCP-Verstoß hindeuten.

#### Technische Anzeichen (Erkennen des OCP-Verstoßes im Code):

- **Vererbungsmuster mit ständigen Änderungen**: Wenn eine Klasse häufig als Basis für andere Klassen verwendet wird und diese abgeleiteten Klassen häufig geändert werden müssen, um neue Funktionen hinzuzufügen, kann dies auf einen OCP-Verstoß hinweisen.

- **Häufige Änderungen an Switch-Anweisungen**: Wenn in Ihrem Code häufig Switch- oder if-else-Anweisungen auftreten und diese ständig aktualisiert werden müssen, um neue Fälle zu behandeln, könnte dies auf eine Verletzung des OCP hinweisen.

- **Mangel an abstrakten Erweiterungspunkten**: Wenn Ihre Klassen und Methoden keine gut definierten und abstrakten Erweiterungspunkte bieten, um neue Funktionalität hinzuzufügen, fehlt es möglicherweise an OCP-Konformität.

- **Unnötige Abhängigkeiten zwischen Komponenten**: Wenn Änderungen an einer Komponente unerwartete Auswirkungen auf andere Komponenten haben und zu unerwünschten Seiteneffekten führen, könnte dies auf einen OCP-Verstoß hinweisen.

- **Fehlende Verwendung von Designmustern**: Das Fehlen von Entwurfsmustern wie Strategie oder Erweiterungsmechanismen wie Plugins kann darauf hinweisen, dass das OCP nicht ausreichend beachtet wurde.
