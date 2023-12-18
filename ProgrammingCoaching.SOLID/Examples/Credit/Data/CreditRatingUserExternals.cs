namespace ProgrammingCoaching.SOLID.Examples.Credit.Data
{
    public class CreditRatingUserExternals
    {
        public string NationalIdentificationID { get; set; } // National identification number (e.g., SSN)
        public double CreditRating { get; set; } // User's credit rating 1-1000
        public bool IsBlackListed { get; set; }
    }
}