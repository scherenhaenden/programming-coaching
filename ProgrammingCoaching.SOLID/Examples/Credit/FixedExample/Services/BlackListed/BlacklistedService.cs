using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed
{
    public class BlacklistedService: IBlacklistedService
    {
        public bool GetBlackListStatus(ExtendedUserInformation extendedUserInformation)
        {

            return ((extendedUserInformation?.RegistredUser?.IsBlackListed ?? false) &&
                    (extendedUserInformation?.CreditRatingUserExternals?.IsBlackListed ?? false));
        }
    }
}