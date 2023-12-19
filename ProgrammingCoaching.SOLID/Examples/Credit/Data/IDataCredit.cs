namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public interface IDataCredit
{
    public List<UserExternalModel> ExternalUsers { get; set; }
    public List<CreditConditions> CreditConditions { get; set; }
    public List<CreditRatingUserExternals> CreditRatingUsersExternals { get; set; }
    public List<RegisteredUser> RegisteredUsers { get; set; }
    
   
}