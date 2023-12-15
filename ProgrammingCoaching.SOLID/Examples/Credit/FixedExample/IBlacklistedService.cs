using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample;

public interface IBlacklistedService
{
    bool CanGetCreditByRatingCalculation(CreditApplicationModel creditApplicationModel, ExtendedUserInformation extendedUserInformation);
}