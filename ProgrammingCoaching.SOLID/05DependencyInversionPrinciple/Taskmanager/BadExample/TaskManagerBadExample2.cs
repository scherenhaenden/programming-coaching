namespace ProgrammingCoaching.SOLID._05DependencyInversionPrinciple.Taskmanager.BadExample;

public class TaskManagerBadExample2
{
    public void RunTask(TaskEngineTypeV2 taskEngineTypeV1)
    {
        taskEngineTypeV1.Run();
    }
    
}

public class TaskEngineTypeV2
{
    public void Run()
    {
        Console.WriteLine("TaskEngineTypeV2 is running");
    }
}   