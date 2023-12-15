using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

public class CreditApplicationModel
{
    
    public string NationalIdentificationID { get; set; }
    public decimal Amount { get; set; }
    public CreditType CreditType { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public bool WantToRegister { get; set; }
}