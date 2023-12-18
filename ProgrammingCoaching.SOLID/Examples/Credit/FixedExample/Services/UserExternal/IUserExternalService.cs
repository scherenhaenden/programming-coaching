using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal
{
    public interface IUserExternalService
    {
        CreditRatingUserExternals? GetCreditRatingUserExternals(string nationalIdentificationId);
    }
}