namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.SalesReports.FixedExample.Example1;

// !!! Wichtiger Hinweis !!!
// Dieses Beispiel dient ausschließlich Illustrationszwecken und ist nicht direkt ausführbar.
// Es zielt darauf ab, das Konzept des Open-Closed-Prinzips zu veranschaulichen.
// Bitte beachten Sie, dass die Implementierungsdetails in den Methoden nicht ausgeführt sind.

/*
 * Hier wird das Open-Closed-Prinzip angewendet.
 * Die Idee ist, dass die Methode GetReport() nicht mehr geändert werden muss,
 * wenn neue Berichtstypen hinzugefügt werden.
 * Stattdessen wird eine neue Klasse erstellt, die das Interface IReportService implementiert.
 * Die neue Klasse wird dann in der Methode GetReport() instanziiert und aufgerufen.
 * Die Methode GetReport() ist nun für Erweiterungen offen, aber für Änderungen geschlossen.
 */


public interface IReportService
{
    Stream? GetReport(dynamic salesData);
}

public class InStoreSalesReport : IReportService
{
    public Stream? GetReport(dynamic salesData)
    {
        // Process for In-Store Sales
        // Implementation details for In-Store sales go here
        return null;
    }
}

public class InStoreSalesReportTests
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new InStoreSalesReport();
        var report = reportExample1Bad.GetReport(null);
        //Assert.Null(report);
    }
}

public class OnlineSalesReport : IReportService
{
    public Stream? GetReport(dynamic salesData)
    {
        // Process for Online Sales
        // Implementation details for Online sales go here
        return null;
    }
}

public class OnlineSalesReportTests
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new OnlineSalesReport();
        var report = reportExample1Bad.GetReport(null);
        //Assert.Null(report);
    }
}

public class WholesaleSalesReport : IReportService
{
    public Stream? GetReport(dynamic salesData)
    {
        // Process for Wholesale Sales
        // Implementation details for Wholesale sales go here
        return null;
    }
}

public class WholesaleSalesReportTests
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new WholesaleSalesReport();
        var report = reportExample1Bad.GetReport(null);
        //Assert.Null(report);
    }
}

public class ReportExample1Fixed
{
    public Stream? GetReport(dynamic salesData, string typeOfReport)
    {
        if (typeOfReport == "In-Store")
            return new InStoreSalesReport().GetReport(salesData);
        else if (typeOfReport == "Online")
            return new OnlineSalesReport().GetReport(salesData);
        else if (typeOfReport == "Wholesale")
            return new WholesaleSalesReport().GetReport(salesData);
        // ... and so forth for each sale type
        return null;
    }
}