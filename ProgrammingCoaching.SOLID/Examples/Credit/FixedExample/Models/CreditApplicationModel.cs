using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models
{
    public class CreditApplicationModel
    {
        public string NationalIdentificationId { get; set; } = null!;
        public decimal Amount { get; set; }
        public CreditType CreditType { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public bool WantToRegister { get; set; }
    
        public CalculationTypeOfRating CalculationTypeOfRating { get; set; }
    
    }

    public enum CalculationTypeOfRating
    {
        Internal,
        External,
        BetterOfInternalOrExternal,
    }
}