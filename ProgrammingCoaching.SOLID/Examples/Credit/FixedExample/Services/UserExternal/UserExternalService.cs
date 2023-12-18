using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal
{
    public class UserExternalService(IDataCredit db) : IUserExternalService
    {
        public CreditRatingUserExternals? GetCreditRatingUserExternals(string nationalIdentificationId)
    {
        return db?.CreditRatingUsersExternals?.FirstOrDefault(u => u.NationalIdentificationID == nationalIdentificationId);
    }
    }
}