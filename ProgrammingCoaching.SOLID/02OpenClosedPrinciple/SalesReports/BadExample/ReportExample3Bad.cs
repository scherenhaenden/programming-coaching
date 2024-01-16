namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.SalesReports.BadExample;


// !!!!!!! Achtung !!!!!!!
// Dieses Beispiel ist nur ein Beispiel und nicht lauffähig
// Es soll nur die Idee des Open-Closed-Principle vermitteln
// Zu bedenken ist dass in der Methoden die Implementierungsdetails drinnen wären
// Bitte bedenken dass diese eigentlich in allen bsp diese Klasse in laufe Der Zeit darstellen soll

/*
* Schritt 3
* Im weiteren Verlauf kommen immer mehr Anforderungen hinzu,
* da das Geschäft der Firma floriert und eine Vielzahl unterschiedlicher Berichtstypen benötigt wird.
* Das Marketing-Team hat einen ständig wachsenden Bedarf an diversen Berichten.
*/

public class ReportExample3Bad
{
    public Stream? GetReport(dynamic salesData, string typeOfReport)
    {
        if (typeOfReport == "In-Store")
        {
            // Prozess für In-Store Sales
            // Implementierungsdetails für In-Store Sales
        }
        else if (typeOfReport == "Online")
        {
            // Prozess für Online Sales
            // Implementierungsdetails für Online Sales
        }
        else if (typeOfReport == "Wholesale")
        {
            // Prozess für Wholesale Sales
            // Implementierungsdetails für Wholesale Sales, einschließlich Mengen, wiederkehrende Kunden, und Langzeitverträge
        }
        else if (typeOfReport == "International")
        {
            // Prozess für International Sales
            // Implementierungsdetails für International Sales, einschließlich Währungsumrechnungen, internationaler Versand und regionsspezifische Steuern
        }
        else if (typeOfReport == "Seasonal")
        {
            // Prozess für Seasonal Sales
            // Implementierungsdetails für Seasonal Sales, einschließlich Analyse des Einflusses von Feiertagen, Wetter und saisonalen Marketingkampagnen
        }
        else if (typeOfReport == "B2B")
        {
            // Prozess für B2B Sales
            // Implementierungsdetails für B2B Sales, einschließlich Fokussierung auf Geschäftskunden, Auftragsgrößen und Vertragslaufzeiten
        }
        else if (typeOfReport == "B2C")
        {
            // Prozess für B2C Sales
            // Implementierungsdetails für B2C Sales, einschließlich Verbraucherverhalten, Marketingeffektivität und Kundenfeedback
        }
        else if (typeOfReport == "ReturnAndRefund")
        {
            // Prozess für Return and Refund
            // Implementierungsdetails für Return and Refund, einschließlich Verfolgung von Rücksendungen und Erstattungen, wichtig für das Verständnis von Produktproblemen und Kundenzufriedenheit
        }
        else if (typeOfReport == "Promotional")
        {
            // Prozess für Promotional Sales
            // Implementierungsdetails für Promotional Sales, einschließlich der Bewertung der Effektivität von Marketingkampagnen und Sonderangeboten
        }
        else if (typeOfReport == "LoyaltyProgram")
        {
            // Prozess für Loyalty Program Sales
            // Implementierungsdetails für Loyalty Program Sales, einschließlich Tracking von Kundenloyalität, Wiederkaufsraten und der Effektivität von Treueanreizen
        }
        // ... und so weiter für jeden Verkaufstyp

        return null;
    }
}

public class ReportExample3BadTest
{
    //[Fact]
    public void Test()
    {
        var reportExample1Bad = new ReportExample3Bad();
        
        List<string> reportTypen = new List<string>()
        {
            "In-Store",
            "Online",
            "Wholesale",
            "International",
            "Seasonal",
            "B2B",
            "B2C",
            "ReturnAndRefund",
            "Promotional",
            "LoyaltyProgram"
        };

        List<dynamic> data = new List<dynamic>();
        
        int i = 0;
        foreach (var reportTyp in reportTypen)
        {
            var report = reportExample1Bad.GetReport(data[i], reportTyp);
            i++;
            //Assert.Null(report);
        }
    }
}