using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed
{
    public class BlacklistedService: IBlacklistedService
    {
        public bool GetBlackListStatus(ExtendedUserInformation extendedUserInformation)
        {
            return (extendedUserInformation?.RegisteredUser?.IsBlackListed ?? true) ||
                   (extendedUserInformation?.CreditRatingUserExternals?.IsBlackListed ?? true);
        }

    }
}