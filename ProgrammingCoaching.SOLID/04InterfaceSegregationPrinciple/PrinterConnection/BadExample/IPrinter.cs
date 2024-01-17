namespace ProgrammingCoaching.SOLID._04InterfaceSegregationPrinciple.PrinterConnection.BadExample;

using System;

/// <summary>
/// Ein Interface, das einen generischen Drucker darstellt.
/// </summary>
public interface IPrinter
{
    /// <summary>
    /// Druckt ein Dokument.
    /// </summary>
    void Print();

    /// <summary>
    /// Scannt ein Dokument.
    /// </summary>
    void Scan();

    /// <summary>
    /// Faxt ein Dokument.
    /// </summary>
    void Fax();
}

/// <summary>
/// Eine Klasse, die einen Multifunktionsdrucker darstellt und das IPrinter-Interface implementiert.
/// </summary>
public class MultiFunctionPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Ein Dokument wird gedruckt.");
        // Implementierung für das Drucken erfolgt hier.
    }

    public void Scan()
    {
        Console.WriteLine("Ein Dokument wird gescannt.");
        // Implementierung für das Scannen erfolgt hier.
    }

    public void Fax()
    {
        Console.WriteLine("Ein Dokument wird gefaxt.");
        // Implementierung für das Faxen erfolgt hier.
    }
}
