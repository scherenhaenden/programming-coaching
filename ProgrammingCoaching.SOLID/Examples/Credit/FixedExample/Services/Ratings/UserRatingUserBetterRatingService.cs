using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings
{
    public class UserRatingUserBetterRatingService: IUserRatingService
    {
        public double GetRating(double internalRating, double externalRating)
        {
            // use the biggest value
            return Math.Max(internalRating, externalRating);
        }

        public double GetRating(ExtendedUserInformation extendedUserInformation)
        {
            return GetRating(extendedUserInformation?.CreditRatingUserExternals.CreditRating ?? 0, extendedUserInformation?.RegisteredUser.InternalCreditRating ?? 0);
        }
    }
}