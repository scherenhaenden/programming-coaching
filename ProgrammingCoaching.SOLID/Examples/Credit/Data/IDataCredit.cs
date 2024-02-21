using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public interface IDataCredit
{
    public List<UserExternalModel> ExternalUsers { get; set; }
    public List<CreditConditionsInternalModel> CreditConditions { get; set; }
    public List<CreditRatingUserExternalModel> CreditRatingUsersExternals { get; set; }
    public List<RegisteredUserInternalModel> RegisteredUsers { get; set; }
    
   
}