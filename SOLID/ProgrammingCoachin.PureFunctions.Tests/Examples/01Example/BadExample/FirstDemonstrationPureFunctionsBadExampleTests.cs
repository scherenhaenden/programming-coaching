using ProgrammingCoachin.PureFunctions.Examples._01Example.BadExample;

namespace ProgrammingCoachin.PureFunctions.Tests.Examples._01Example.BadExample;

public class FirstDemonstrationPureFunctionsBadExampleTests
{
    // write test
    [Test]
    public void Test1()
    {
        
        
        FirstDemonstrationPureFunctionsBadExample firstDemonstrationPureFunctionsBadExample = new();
        
        firstDemonstrationPureFunctionsBadExample.Run();
        
        Assert.Pass();
    }
}