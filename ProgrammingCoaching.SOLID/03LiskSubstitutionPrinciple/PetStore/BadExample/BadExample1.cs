namespace ProgrammingCoaching.SOLID._03LiskSubstitutionPrinciple.PetStore.BadExample;

public interface IAnimalBadExample1
{
    object GetColourOf();
    
    object GetWeightOf();
    
    object IsItDangerous();
    
    object FlySpeed();
}

public class LoroBadExample1: IAnimalBadExample1
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
}


public class EagleBadExample1: IAnimalBadExample1
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
}

public class PetStoreBadExample1
{
    public void Sell(IAnimalBadExample1 animal)
    {
        // ...
        // ... code
        // ... mehr code
        // ... noch mehr code
        // ... und noch mehr code
        // ... ultra noch mehr code und so weiter
        // ...
        
        // hier wird das Tier verkauft
        // ...
        // ... code
        // ... mehr code
        // ... noch mehr code
        // ... und noch mehr code
        // ... ultra noch mehr code und so weiter
        // ...
    }
}