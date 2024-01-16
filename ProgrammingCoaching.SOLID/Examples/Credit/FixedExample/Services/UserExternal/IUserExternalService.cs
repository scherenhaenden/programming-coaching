using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal
{
    public interface IUserExternalService
    {
        CreditRatingUserExternalModel? GetCreditRatingUserExternals(string nationalIdentificationId);
    }
}