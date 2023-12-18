using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings
{
    public class UserRatingInternalIfExistentService: IUserRatingService
    {
        public double GetRating(double internalRating, double externalRating)
        {
            if (internalRating > 0)
            {
                return internalRating;
            }
            return externalRating;
        }
 
        public double GetRating(ExtendedUserInformation extendedUserInformation)
        {
            return GetRating(extendedUserInformation?.RegistredUser.InternalCreditRating ?? 0, extendedUserInformation?.CreditRatingUserExternals.CreditRating ?? 0);
        }
    }
}