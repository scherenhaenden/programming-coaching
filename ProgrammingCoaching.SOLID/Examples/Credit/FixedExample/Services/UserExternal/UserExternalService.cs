using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal
{
    public class UserExternalService(IDataCredit db) : IUserExternalService
    {
        public CreditRatingUserExternalModel? GetCreditRatingUserExternals(string nationalIdentificationId)
        {
            return db?.CreditRatingUsersExternals?.FirstOrDefault(u => u.NationalIdentificationId == nationalIdentificationId);
        }
    }
}