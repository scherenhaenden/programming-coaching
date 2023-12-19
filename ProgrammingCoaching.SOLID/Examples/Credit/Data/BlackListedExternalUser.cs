namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class BlackListedExternalUser
{
    public bool blackListed { get; set; }
    public string NationalIdentificationID { get; set; } // National identification number (e.g., SSN)
}