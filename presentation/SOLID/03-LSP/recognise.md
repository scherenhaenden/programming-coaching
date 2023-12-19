### Erkennen von LSP-Verstößen

#### Nicht-Technische Anzeichen (Verstehen des LSP-Verstoßes):

- **Unerwartetes Verhalten bei Vererbung**: Wenn abgeleitete Klassen sich anders verhalten als die Basisklasse und unerwartetes oder fehlerhaftes Verhalten zeigen, kann dies auf einen Verstoß gegen das LSP hinweisen.

- **Verletzung der erwarteten Verträge**: Wenn eine abgeleitete Klasse Methoden oder Eigenschaften überschreibt und dabei vordefinierte Verträge (z. B. Vorbedingungen oder Nachbedingungen) der Basisklasse verletzt, liegt möglicherweise ein LSP-Verstoß vor.

- **Zwangsweise Verwendung von Typüberprüfungen**: Wenn Code in der Anwendung erfordert, dass der konkrete Typ einer Instanz überprüft wird, um unerwartetes Verhalten zu vermeiden, könnte dies ein Zeichen für LSP-Verletzungen sein.

#### Technische Anzeichen (Erkennen des LSP-Verstoßes im Code):

- **Verletzung der Vertragserfüllung**: Wenn abgeleitete Klassen geerbte Verträge, wie Schnittstellen oder abstrakte Methoden, nicht ordnungsgemäß erfüllen und diese Verträge verletzen, besteht möglicherweise ein LSP-Verstoß.

- **Verstoß gegen das "ist-ein"-Prinzip**: Wenn eine abgeleitete Klasse behauptet, von einer Basisklasse zu erben, aber in Wirklichkeit nicht alle Verhaltensweisen der Basisklasse korrekt nachbildet, kann dies auf LSP-Verstöße hinweisen.

- **Unerwartete Ausnahmen oder Fehler**: Wenn abgeleitete Klassen zu unerwarteten Ausnahmen oder Fehlern führen, insbesondere wenn sie als Ersatz für die Basisklasse verwendet werden, könnte dies auf LSP-Verletzungen hindeuten.

- **Inkonsistente Schnittstellenimplementierung**: Wenn abgeleitete Klassen Schnittstellen implementieren, aber einige Methoden nicht sinnvoll unterstützen oder sinnvolle Implementierungen fehlen, kann dies auf LSP-Verstöße hinweisen.

- **Verletzung der Invarianz**: Wenn abgeleitete Klassen die Invarianz der Basisklasse nicht respektieren, indem sie Vorbedingungen oder Nachbedingungen der Basisklasse ändern oder aufheben, liegt möglicherweise ein LSP-Verstoß vor.
