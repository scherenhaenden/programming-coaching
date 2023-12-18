namespace ProgrammingCoaching.SOLID.Examples.Credit.Data
{
    public interface IDataCredit
    {
        public List<User> Users { get; set; }
        public List<CreditConditions> CreditConditions { get; set; }
        public List<CreditRatingUserExternals> CreditRatingUsersExternals { get; set; }
        public List<RegistredUser> RegistredUsers { get; set; }
    
   
    }
    
    
    public class DataCredit: IDataCredit
    {
        public DataCredit()
        {
            
            ClassGenerateData.CreateAll();
            
            this.Users = ClassGenerateData.Users;
            this.CreditConditions = ClassGenerateData.CreditConditions;
            this.CreditRatingUsersExternals = ClassGenerateData.CreditRatingUserExternals;
            this.RegistredUsers = ClassGenerateData.RegistredUsers;
        }

        public List<User> Users { get; set; }= new List<User>();
        public List<CreditConditions> CreditConditions { get; set; }= new List<CreditConditions>();
        public List<CreditRatingUserExternals> CreditRatingUsersExternals { get; set; }= new List<CreditRatingUserExternals>();
        public List<RegistredUser> RegistredUsers { get; set; }= new List<RegistredUser>();
    }
}