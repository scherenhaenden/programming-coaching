namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.SalesReports.BadExample;

// !!!!!!! Achtung !!!!!!!
// Dieses Beispiel ist nur ein Beispiel und nicht lauffähig
// Es soll nur die Idee des Open-Closed-Principle vermitteln
// Zu bedenken ist dass in der Methoden die Implementierungsdetails drinnen wären
// Bitte bedenken dass diese eigentlich in allen bsp diese Klasse in laufe Der Zeit darstellen soll

/*
 * step 1
 * In diesen ersten bsp fangen wir an mit der Anforderung von seite des Fachbereichs
 * Sie Möchten einen Report für die In-Store Sales
 * Wir haben hier eine Methode die einen Stream zurück gibt
 * Die Methode Verbinden mit dem Datenbank und/oder mit dem Filesystem und/oder mit dem WebService
 * um die Daten herauszuziehen und dann den Report zu generieren
 * Anschließend wird der Stream zurück gegeben und der Fachbereich kann damit machen was er will
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




