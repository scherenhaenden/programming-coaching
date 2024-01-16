namespace ProgrammingCoaching.SOLID._03LiskSubstitutionPrinciple.PetStore.BadExample;


public interface IAnimalBadExample3
{
    object GetColourOf();
    
    object GetWeightOf();
    
    object IsItDangerous();

    object FlySpeed();
    
    object SwimSpeed();
    
    object BatteriesIncluded();
}

public class LoroBadExample3: IAnimalBadExample3
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

    public object BatteriesIncluded()
    {
        throw new Exception("Do NOT use this method on Loros");
    }
}


public class EagleBadExample3: IAnimalBadExample3
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

    public object BatteriesIncluded()
    {
        throw new Exception("Do NOT use this method on Eagles");
    }
}


public class CrocodileBadExample3: IAnimalBadExample3
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
        return 5;
    }

    public object BatteriesIncluded()
    {
        throw new Exception("Do NOT use this method on crocodiles");
    }
}

public class TeddyBadExample : IAnimalBadExample3
{
    public object GetColourOf()
    {
        return "Brown";
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
        throw new Exception("Do NOT use this method on teddies");
    }

    public object SwimSpeed()
    {
        throw new Exception("Do NOT use this method on teddies");
    }

    public object BatteriesIncluded()
    {
        return true;
    }
}

public class PetStoreBadExample3
{
    public void Sell(IAnimalBadExample3 animal)
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