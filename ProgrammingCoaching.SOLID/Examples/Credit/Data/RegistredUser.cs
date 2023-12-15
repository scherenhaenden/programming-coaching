namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class RegistredUser
{
    public string NationalIdentificationID { get; set; } // National identification number (e.g., SSN)
    public string? AccountNumber { get; set; } // Unique identifier for the user's account
    public string UserID { get; set; } // Unique identifier for the user
    public double InternalCreditRating { get; set; } // User's credit rating 1-1000
    public bool IsBlackListed { get; set; }
}

public class ExtendedUserInformation
{
   public RegistredUser? RegistredUser { get; set; }
   public User? User { get; set; }
   public CreditRatingUserExternals? CreditRatingUserExternals { get; set; }
}


