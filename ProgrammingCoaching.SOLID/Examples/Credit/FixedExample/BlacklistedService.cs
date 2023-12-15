using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample;

public class BlacklistedService: IBlacklistedService
{
    public bool CanGetCreditByRatingCalculation(CreditApplicationModel creditApplicationModel, ExtendedUserInformation extendedUserInformation)
    {

        return ((extendedUserInformation?.RegistredUser?.IsBlackListed ?? false) ||
                (extendedUserInformation?.CreditRatingUserExternals?.IsBlackListed ?? false));
    }
}