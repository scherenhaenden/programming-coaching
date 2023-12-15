namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class DataCredit
{
    public DataCredit()
    {
        
        ClassGenerateData.CreateAll();
        
        this.Users = ClassGenerateData.Users;
        this.CreditConditions = ClassGenerateData.CreditConditions;
        this.CreditRatingUsersExternals = ClassGenerateData.CreditRatingUserExternals;
        this.RegistredUsers = ClassGenerateData.RegistredUsers;
    }
    
    public List<User> Users = new List<User>();
    public List<CreditConditions> CreditConditions = new List<CreditConditions>();
    public List<CreditRatingUserExternals> CreditRatingUsersExternals = new List<CreditRatingUserExternals>();
    public List<RegistredUser> RegistredUsers = new List<RegistredUser>();
    
   
}