namespace ProgrammingCoaching.SOLID._04InterfaceSegregationPrinciple.PetStore.FixedExample;

public interface IAnimalFixedExample
{
    object GetColourOf();
    
    object GetWeightOf();
}

public interface IAnimalRealFixedExample: IAnimalFixedExample
{
    object IsItDangerous();
}


public interface IAnimalStuffed: IAnimalFixedExample
{
    object BatteriesIncluded();
}

public interface IAnimalBird: IAnimalRealFixedExample
{
    object FlySpeed();
}
public interface IAnimalAquatic: IAnimalRealFixedExample
{
    object SwimSpeed();
}


public interface IAnimalAmphibian: IAnimalBird, IAnimalAquatic
{
    
}


public class LoroBadExample3: IAnimalBird
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


public class EagleBadExample3: IAnimalBird
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


public class CrocodileBadExample3: IAnimalAquatic
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
   

    public object SwimSpeed()
    {
        return 5;
    }

    
}

public class TeddyBadExample : IAnimalStuffed
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
    

    public object BatteriesIncluded()
    {
        return true;
    }
}

public class DuckExample : IAnimalAmphibian
{
    public object GetColourOf()
    {
        return "Black and White";
    }

    public object GetWeightOf()
    {
        return 10.5;
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
        return 5;
    }
}