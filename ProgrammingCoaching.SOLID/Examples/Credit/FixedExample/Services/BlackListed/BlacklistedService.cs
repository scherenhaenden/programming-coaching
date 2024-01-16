using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;

/// <summary>
/// Service class for checking the blacklist status of a user.
/// </summary>
public class BlacklistedService: IBlacklistedService
{
    /// <summary>
    /// Checks if a user is blacklisted based on extended user information.
    /// </summary>
    /// <param name="extendedUserInformation">The extended user information to examine.</param>
    /// <returns>True if the user is blacklisted; otherwise, false.</returns>
    public bool GetBlackListStatus(ExtendedUserInformation extendedUserInformation)
    {
        return (extendedUserInformation?.RegisteredUser?.IsBlackListed ?? true) ||
               (extendedUserInformation?.CreditRatingUserExternals?.IsBlackListed ?? true);
    }

}





  
