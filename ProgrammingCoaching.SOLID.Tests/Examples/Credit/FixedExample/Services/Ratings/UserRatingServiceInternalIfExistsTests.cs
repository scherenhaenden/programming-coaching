using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.Ratings
{
    public class UserRatingServiceInternalIfExistsTests
    {
        [Test]
        public void Test1_GetInternalWhenLower()
        {
        
            IUserRatingService userRatingService = new UserRatingInternalIfExistentService();
        
            var internalRating = 100;
            var externnalRating = 200;
        
            var result =userRatingService.GetRating(internalRating, externnalRating);
        
            Assert.AreEqual(internalRating, result);
        
        
            ExtendedUserInformation extendedUserInformation = new ExtendedUserInformation
            {
                RegistredUser = new RegistredUser()
                {
                    InternalCreditRating = 100
                },
                CreditRatingUserExternals = new CreditRatingUserExternals()
                {
                    CreditRating = 200
                }
            };
            var result2 =userRatingService.GetRating(extendedUserInformation);
        
            Assert.AreEqual(internalRating, result2);
        }
    
        [Test]
        public void Test2_GetInternalWhenHigher()
        {
        
            IUserRatingService userRatingService = new UserRatingInternalIfExistentService();
        
            var internalRating = 200;
            var externnalRating = 100;
        
            var result = userRatingService.GetRating(internalRating, externnalRating);
        
            Assert.AreEqual(internalRating, result);
        
            ExtendedUserInformation extendedUserInformation = new ExtendedUserInformation
            {
                RegistredUser = new RegistredUser()
                {
                    InternalCreditRating = 200
                },
                CreditRatingUserExternals = new CreditRatingUserExternals()
                {
                    CreditRating = 100
                }
            };
            var result2 =userRatingService.GetRating(extendedUserInformation);
        
            Assert.AreEqual(internalRating, result2);
        
        }

    }
}