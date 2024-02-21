namespace ProgrammingCoachin.PureFunctions.Examples._01Example.BadExample;

public class FirstDemonstrationPureFunctionsBadExample
{
    
    /*
     * Pure Function: Output only depends on the input, no side effects
     * They do not share state with other functions
     * They do not modify state outside of themselves
     * This is a demonstration of a pure method inside of OOP
     *
     * If we use impure functionalities (like global variables) or write methods that share state
     * the code is more difficult to make it verifyable and testable
     * we have to mock more around the code to make it work
     */
    
    
    // Global variable to demonstrate impure function behavior
    private int globalNumber = 10;

    public void Run()
    {
        Console.WriteLine("Demonstrating Pure Function:");
        Console.WriteLine("Result of PureFunction(5, 3): " + PureFunction(5, 3));
        Console.WriteLine("Result of PureFunction(5, 3): " + PureFunction(5, 3));
        
        Console.WriteLine("\nDemonstrating Impure Function:");
        Console.WriteLine("Result of ImpureFunction(5): " + ImpureFunction(5));
        Console.WriteLine("Result of ImpureFunction(5): " + ImpureFunction(5));
    }

    // Pure Function: Output only depends on the input, no side effects
    private int PureFunction(int x, int y)
    {
        return x + y;
    }

    // Impure Function: Output depends on external state (globalNumber) and it changes the state
    private int ImpureFunction(int x)
    {
        globalNumber += x; // Modifying global state
        return globalNumber;
    }
}

