namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.SalesReports.BadExample;

// !!! Wichtiger Hinweis !!!
// Dieses Beispiel dient ausschließlich Illustrationszwecken und ist nicht direkt ausführbar.
// Es zielt darauf ab, das Konzept des Open-Closed-Prinzips zu veranschaulichen.
// Bitte beachten Sie, dass die Implementierungsdetails in den Methoden nicht ausgeführt sind.
// Diese Klasse soll exemplarisch die Entwicklung und Erweiterungen über die Zeit darstellen.

/*
 * Schritt 1
 * In diesem ersten Beispiel beginnen wir mit einer Anforderung seitens des Fachbereichs.
 * Es wird ein Bericht für die In-Store-Verkäufe gewünscht.
 * Hierzu implementieren wir eine Methode, die einen Stream zurückgibt.
 * Die Methode stellt eine Verbindung zur Datenbank, zum Dateisystem oder zu einem WebService her,
 * um die erforderlichen Daten zu extrahieren und anschließend den Bericht zu generieren.
 * Der generierte Stream wird dann zurückgegeben, und der Fachbereich kann diesen nach Belieben verwenden.
 */
public class ReportExample1Bad
{
    public Stream? GetReport(dynamic salesData)
    {
        // Process and generate report for In-Store Sales
        // Implementation details go here
        
        return null;
    }
}


public class ReportExample1BadTest
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new ReportExample1Bad();
        var report = reportExample1Bad.GetReport(null);
        //Assert.Null(report);
    }
}




