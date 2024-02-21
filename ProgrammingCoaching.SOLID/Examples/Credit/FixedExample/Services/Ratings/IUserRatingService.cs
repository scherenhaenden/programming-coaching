using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings
{
    public interface IUserRatingService
    {
        double GetRating(double internalRating, double externalRating);
    
        double GetRating(ExtendedUserInformation extendedUserInformationg);
    }
}