using ProgrammingCoaching.SOLID.Examples.Credit.Data.GenerationOfData;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

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
        public List<CreditConditionsInternalModel> CreditConditions { get; set; }= new List<CreditConditionsInternalModel>();
        public List<CreditRatingUserExternalModel> CreditRatingUsersExternals { get; set; }= new List<CreditRatingUserExternalModel>();
        public List<RegisteredUserInternalModel> RegisteredUsers { get; set; }= new List<RegisteredUserInternalModel>();
    }
}