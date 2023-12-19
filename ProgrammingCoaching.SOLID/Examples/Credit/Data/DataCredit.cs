namespace ProgrammingCoaching.SOLID.Examples.Credit.Data
{
    public class DataCredit: IDataCredit
    {
        public DataCredit()
        {
            
            ClassGenerateData.CreateAll();
            
            this.ExternalUsers = ClassGenerateData.Users;
            this.CreditConditions = ClassGenerateData.CreditConditions;
            this.CreditRatingUsersExternals = ClassGenerateData.CreditRatingUserExternals;
            this.RegisteredUsers = ClassGenerateData.RegistredUsers;
        }

        public List<UserExternalModel> ExternalUsers { get; set; }= new List<UserExternalModel>();
        public List<CreditConditions> CreditConditions { get; set; }= new List<CreditConditions>();
        public List<CreditRatingUserExternals> CreditRatingUsersExternals { get; set; }= new List<CreditRatingUserExternals>();
        public List<RegisteredUser> RegisteredUsers { get; set; }= new List<RegisteredUser>();
    }
}