namespace ProgrammingCoaching.SOLID._05DependencyInversionPrinciple.Taskmanager.BadExample;

public class TaskManagerBadExample3
{
    public void RunTask(TaskEngineTypeV3 taskEngineTypeV1)
    {
        taskEngineTypeV1.Run();
    }
    
}

public class TaskEngineTypeV3
{
    public void Run()
    {
        Console.WriteLine("TaskEngineTypev3 is running");
    }
}   