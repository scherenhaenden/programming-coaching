namespace ProgrammingCoaching.SOLID._05DependencyInversionPrinciple.Taskmanager.BadExample;

public class TaskManagerBadExample1
{
    public void RunTask(TaskEngineTypeV1 taskEngineTypeV1)
    {
        taskEngineTypeV1.Run();
    }
    
}

public class TaskEngineTypeV1
{
    public void Run()
    {
        Console.WriteLine("TaskEngineType1 is running");
    }
}   