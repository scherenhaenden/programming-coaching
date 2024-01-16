namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.SalesReports.BadExample;

// !!!!!!! Achtung !!!!!!!
// Dieses Beispiel ist nur ein Beispiel und nicht lauffähig
// Es soll nur die Idee des Open-Closed-Principle vermitteln
// Zu bedenken ist dass in der Methoden die Implementierungsdetails drinnen wären
// Bitte bedenken dass diese eigentlich in allen bsp diese Klasse in laufe Der Zeit darstellen soll

/*
* Schritt 2
* Im Laufe der Zeit erweitert sich die Anforderung.
* Nun wird zusätzlich ein Bericht für Online-Verkäufe benötigt.
* Gleichzeitig muss der Bericht für In-Store-Verkäufe weiterhin vorhanden sein und erstellt werden.
* Der Entwickler entscheidet sich, die Methode zu "erweitern", um diese neue Anforderung zu erfüllen.
*/

public class ReportExample2Bad
{
    public Stream? GetReport(dynamic salesData, string typeOfReport)
    {
        
        if (typeOfReport == "In-Store")
        {
            // dynamic inStoreSalesDataRespository ;
            // dynamic mystream = inStoreSalesDataRespository.GetInStoreSalesData();
            
            // hier verarbeitung der Daten und generierung des Reports
            // ...
            // ... code
            // ... mehr code
            // ... noch mehr code
            // ... und noch mehr code
            // ... ultra noch mehr code und so weiter
            // ...
            
            // Process for In-Store Sales
            // Implementation details for In-Store sales go here
        }
        else if (typeOfReport == "Online")
        {
            // hier verarbeitung der Daten und generierung des Reports
            // ...
            // ... code
            // ... mehr code
            // ... noch mehr code
            // ... und noch mehr code
            // ... ultra noch mehr code und so weiter
            // ...
            
            // Process for Online Sales
            // Implementation details for Online sales go here
        }
        // ... and so on for each sales type
        
        // Process and generate report for In-Store Sales
        // Implementation details go here
        
        return null;
    }
}


public class ReportExample2BadTest
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new ReportExample2Bad();
        var report = reportExample1Bad.GetReport(null, "somevalue");
        //Assert.Null(report);
        
        var report2 = reportExample1Bad.GetReport(null, "somevalue");
        //Assert.Null(report);
    }
}