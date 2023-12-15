namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

// Enum for given, pending of denied
public enum CreditStatus
{
    Given,
    Pending,
    Denied
}


public class CreditModels
{
    // Credit conditions
    CreditConditions CreditConditions { get; set; }
    // Credit Id
    string CreditId { get; set; }
    // Credite state
    CreditStatus CreditStatus { get; set; }
    // intern or external
    bool IsExternal { get; set; }
}