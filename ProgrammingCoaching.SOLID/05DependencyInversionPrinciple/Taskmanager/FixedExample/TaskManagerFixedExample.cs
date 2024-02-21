namespace ProgrammingCoaching.SOLID._05DependencyInversionPrinciple.Taskmanager.FixedExample;

public class TaskManagerFixedExample
{
    public void RunTask(ITaskEngineType taskEngineType)
    {
        taskEngineType.Run();
    }
    
}

public interface ITaskEngineType
{
    void Run();
}


public class TaskEngineTypeV1: ITaskEngineType
{
    public void Run()
    {
        Console.WriteLine("TaskEngineType1 is running");
    }
}   

public class TaskEngineTypeV2: ITaskEngineType
{
    public void Run()
    {
        Console.WriteLine("TaskEngineType1 is running");
    }
} 

public class TaskEngineTypeV3: ITaskEngineType
{
    public void Run()
    {
        Console.WriteLine("TaskEngineType1 is running");
    }
} 