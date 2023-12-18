using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;

public interface IBlacklistedService
{
    bool GetBlackListStatus(ExtendedUserInformation extendedUserInformation);
}