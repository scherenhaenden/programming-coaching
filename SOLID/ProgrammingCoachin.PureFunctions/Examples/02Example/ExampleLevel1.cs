namespace ProgrammingCoachin.PureFunctions.Examples._02Example;

// Example 1: Pure methods because this implementations can be written as pure functions
public class ExampleLevel1
{
    public int AddNumbers(int x, int y)
    {
        // This is a PURE function because:
        // - Its output depends solely on the input arguments (x and y)
        // - It doesn't modify any variables outside of its own scope (no side effects)
        return x + y;
    }

    public DateTime GetCurrentTime()
    {
        // This is an IMPURE function because:
        // - Its output relies on an external factor (the system time)  
        // - It could return a different result each time it's called
        return DateTime.Now; 
    }
    
    public int GetTotalItems(List<int> itemList)
    {
        // Pure function:
        // - Output (item count) depends purely on the provided 'itemList'
        // - No modification of the input list or any external data
        return itemList.Count; 
    }
    
    
    public void Test() 
    {
        Console.WriteLine("Result of AddNumbers(5, 3): " + AddNumbers(5, 3));
        Console.WriteLine("Result of GetCurrentTime(): " + GetCurrentTime());
    }
}

// Example 2: Impure methods because they NEED to be written as impure functions
public class ExampleLevel2
{
    // IMPURE functions have always side effects but not all of them are called side effects
    // basically, if a function modifies the state of the system, or anything that is tight to a space in memory
    // somewhere, it is impure and it IS a side effect... but those are WANTED side effects
    public void PrintToConsole(string message)
    {
        // This is an IMPURE function because:
        // - It has a side effect (modifying the console output)
        // - Its output is not solely dependent on the input argument
        Console.WriteLine(message);
    }

    public void SaveToFile(string filePath, string content)
    {
        // This is an IMPURE function because:
        // - It has a side effect (modifying the file system)
        // - Its output is not solely dependent on the input arguments
        File.WriteAllText(filePath, content);
    }
    
    public void Test() 
    {
        PrintToConsole("Hello, World!");
        SaveToFile("output.txt", "Hello, World!");
    }
}
