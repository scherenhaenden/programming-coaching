using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed
{
    /// <summary>
    /// Interface for checking the blacklist status of a user.
    /// </summary>
    public interface IBlacklistedService
    {
        /// <summary>
        /// Checks if a user is blacklisted based on extended user information.
        /// </summary>
        /// <param name="extendedUserInformation">The extended user information to examine.</param>
        /// <returns>True if the user is blacklisted; otherwise, false.</returns>
        bool GetBlackListStatus(ExtendedUserInformation extendedUserInformation);
    }
}
