namespace ProgrammingCoaching.SOLID._04InterfaceSegregationPrinciple.PrinterConnection.FixExample;

/// <summary>
/// An interface representing a generic printer that can print.
/// </summary>
public interface IPrinter
{
    void Print();
}

/// <summary>
/// An interface representing a scanner.
/// </summary>
public interface IScanner
{
    void Scan();
}

/// <summary>
/// An interface representing a fax machine.
/// </summary>
public interface IFax
{
    void Fax();
}

/// <summary>
/// A class representing a MultiFunctionPrinter implementing the specific interfaces.
/// </summary>
public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print()
    {
        Console.WriteLine("Printing a document.");
        // Implementation for printing goes here.
    }

    public void Scan()
    {
        Console.WriteLine("Scanning a document.");
        // Implementation for scanning goes here.
    }

    public void Fax()
    {
        Console.WriteLine("Faxing a document.");
        // Implementation for faxing goes here.
    }
}
