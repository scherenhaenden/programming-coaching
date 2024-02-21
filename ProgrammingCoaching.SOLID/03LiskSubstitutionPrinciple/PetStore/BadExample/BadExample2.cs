namespace ProgrammingCoaching.SOLID._03LiskSubstitutionPrinciple.PetStore.BadExample;

// !!! Wichtiger Hinweis !!!
// Dieses Beispiel dient ausschließlich Illustrationszwecken und ist nicht direkt ausführbar.
// Es zielt darauf ab, das Konzept des Open-Closed-Prinzips zu veranschaulichen.
// Bitte beachten Sie, dass die Implementierungsdetails in den Methoden nicht ausgeführt sind.
// Diese Klasse soll exemplarisch die Entwicklung und Erweiterungen über die Zeit darstellen.

/*
* Schritt 1
* In diesem ersten Beispiel starten wir mit einer Anforderung im PetStore.
* Hierbei wird ein Vogel trainiert und je nachdem, ob es sich um ein echtes Tier handelt oder nicht,
* werden die Batterien ausgetauscht.
*/
public class BirdBadExample2
{
    /// <summary>
    /// Startet den Flug des Vogels.
    /// </summary>
    public void StartToFly()
    {
        // Implementierungsdetails hier einfügen
        Console.WriteLine("Vogel fliegt.");
    }
    
    /// <summary>
    /// Wechselt die Batterien des Vogels.
    /// </summary>
    public void ChangeBatteries()
    {
        // Implementierungsdetails hier einfügen
        Console.WriteLine("Batterien wurden gewechselt.");
    }
}

public class LoroBadExample2 : BirdBadExample2
{
    
    
    
    public new void ChangeBatteries()
    {
        // Implementierungsdetails hier einfügen
        // Console.WriteLine("Batterien wurden gewechselt.");
        throw new Exception("Papageien haben keine Batterien.");
    }
}

public class PenguinBadExample2 : BirdBadExample2
{
    public new void StartToFly()
    {
        // Implementierungsdetails hier einfügen
        // Console.WriteLine("Batterien wurden gewechselt.");
        throw new Exception("Pinguine können nicht fliegen.");
    }
    
    
    
    public new void ChangeBatteries()
    {
        // Implementierungsdetails hier einfügen
        // Console.WriteLine("Batterien wurden gewechselt.");
        throw new Exception("Papageien haben keine Batterien.");
    }
}

public class StuffedAnimalBadExample2 : BirdBadExample2
{
    public new void StartToFly()
    {
        // Implementierungsdetails hier einfügen
        // Console.WriteLine("Batterien wurden gewechselt.");
        throw new Exception("Stofftiere können nicht fliegen.");
    }
}

public class PetStoreBadExample2
{
    /// <summary>
    /// Trainiert einen Papagei, indem die Batterien gewechselt werden.
    /// </summary>
    public void TrainBird(LoroBadExample2 bird)
    {
        bird.ChangeBatteries();
    }
    
    /// <summary>
    /// Setzt Batterien in einen Vogel ein, damit er fliegt.
    /// </summary>
    public void PutBatteriesBird(PenguinBadExample2 bird)
    {
        bird.StartToFly();
    }
    
    /// <summary>
    /// Trainiert einen Vogel, indem die Batterien gewechselt werden.
    /// </summary>
    public void TrainBird(BirdBadExample2 birdBadExample2)
    {
        birdBadExample2.ChangeBatteries();
    }
    
    /// <summary>
    /// Setzt Batterien in einen Vogel ein, damit er fliegt.
    /// </summary>
    public void PutBatteriesBird(BirdBadExample2 birdBadExample2)
    {
        birdBadExample2.StartToFly();
    }
}
