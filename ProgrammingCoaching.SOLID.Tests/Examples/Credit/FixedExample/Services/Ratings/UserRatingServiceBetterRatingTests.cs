using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.Ratings
{
    public class UserRatingServiceBetterRatingTests
    {
        DataCredit _db = new DataCredit();
    
        [Test]
        public void Test1_GetBetterInternal()
        {
        
            IUserRatingService userRatingService = new UserRatingUserBetterRatingService();
        
            var internalRating = 200;
            var externnalRating = 100;
        
        
        
            var result =userRatingService.GetRating(internalRating, externnalRating);
        
            Assert.AreEqual(internalRating, result);

            ExtendedUserInformation extendedUserInformation = new ExtendedUserInformation
            {
                RegistredUser = new RegistredUser()
                {
                    InternalCreditRating = internalRating
                },
                CreditRatingUserExternals = new CreditRatingUserExternals()
                {
                    CreditRating = externnalRating
                }
            };
            var result2 =userRatingService.GetRating(extendedUserInformation);
        
            Assert.AreEqual(internalRating, result2);



        }
    
        [Test]
        public void Test1_GetBetterExternal()
        {
        
            IUserRatingService userRatingService = new UserRatingUserBetterRatingService();
        
            var internalRating = 300;
            var externnalRating = 400;
        
            var result = userRatingService.GetRating(internalRating, externnalRating);
        
            Assert.AreEqual(externnalRating, result);
        
        
            ExtendedUserInformation extendedUserInformation = new ExtendedUserInformation
            {
                RegistredUser = new RegistredUser()
                {
                    InternalCreditRating = internalRating
                },
                CreditRatingUserExternals = new CreditRatingUserExternals()
                {
                    CreditRating =externnalRating
                }
            };
            var result2 =userRatingService.GetRating(extendedUserInformation);
        
            Assert.AreEqual(externnalRating, result2);
        
        }

    }
}