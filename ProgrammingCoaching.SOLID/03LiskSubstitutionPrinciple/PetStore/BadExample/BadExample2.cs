namespace ProgrammingCoaching.SOLID._03LiskSubstitutionPrinciple.PetStore.BadExample;


// !!! Wichtiger Hinweis !!!
// Dieses Beispiel dient ausschließlich Illustrationszwecken und ist nicht direkt ausführbar.
// Es zielt darauf ab, das Konzept des Open-Closed-Prinzips zu veranschaulichen.
// Bitte beachten Sie, dass die Implementierungsdetails in den Methoden nicht ausgeführt sind.
// Diese Klasse soll exemplarisch die Entwicklung und Erweiterungen über die Zeit darstellen.

/*
 * Schritt 2
 * In diesem ersten Beispiel beginnen wir mit einer Anforderung in einem PetStore.
 * Es wird ein Tier verkauft.
 * Hierzu implementieren wir eine interface, die die Methoden definiert, die wir benötigen.
 * Die methoden geben uns eigentschaften des Tieres zurück.
 *
 * Aber hier kommt ein neues Tier dazu, der Krokodil.
 * Dieses Tier kann nicht fliegen, aber es kann schwimmen.
 * Für die Implementierungen der Loro und Eagle müssen wir nun eine Exception werfen. (siehe unten)
 * Das stellt ein Problem dar, da wir nun die Methoden nicht mehr verwenden können aber die stehen zur Verfügung.
 * Ein klares Designproblem.
 */

public interface IAnimalBadExample2
{
    object GetColourOf();
    
    object GetWeightOf();
    
    object IsItDangerous();

    object FlySpeed();
    
    object SwimSpeed();
}

public class LoroBadExample2: IAnimalBadExample2
{
    public object GetColourOf()
    {
        return "Green";
    }

    public object GetWeightOf()
    {
        return 0.5;
    }

    public object IsItDangerous()
    {
        return false;
    }

    public object FlySpeed()
    {
        return 10;
    }

    public object SwimSpeed()
    {
        throw new Exception("Do NOT use this method on Loros");
    }
}


public class EagleBadExample2: IAnimalBadExample2
{
    public object GetColourOf()
    {
        return "Brown";
    }

    public object GetWeightOf()
    {
        return 1.5;
    }

    public object IsItDangerous()
    {
        return true;
    }

    public object FlySpeed()
    {
        return 100;
    }

    public object SwimSpeed()
    {
        throw new Exception("Do NOT use this method on Eagles");
    }
}


public class CrocodileBadExample2: IAnimalBadExample2
{
    public object GetColourOf()
    {
        return "Green";
    }

    public object GetWeightOf()
    {
        return 10.5;
    }

    public object IsItDangerous()
    {
        return true;
    }

    public object FlySpeed()
    {
        throw new Exception("Do NOT use this method on crocodiles");
    }

    public object SwimSpeed()
    {
        throw new NotImplementedException();
    }
}