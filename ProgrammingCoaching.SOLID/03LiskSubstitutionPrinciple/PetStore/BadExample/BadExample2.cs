namespace ProgrammingCoaching.SOLID._03LiskSubstitutionPrinciple.PetStore.BadExample;



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