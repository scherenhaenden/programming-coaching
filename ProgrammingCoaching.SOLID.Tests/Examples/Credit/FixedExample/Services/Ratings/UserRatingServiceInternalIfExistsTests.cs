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

            Assert.That(result, Is.EqualTo(internalRating));
        
        
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

            Assert.That(result2, Is.EqualTo(internalRating));
        }
    
        [Test]
        public void Test2_GetInternalWhenHigher()
        {
        
            IUserRatingService userRatingService = new UserRatingInternalIfExistentService();
        
            var internalRating = 200;
            var externnalRating = 100;
        
            var result = userRatingService.GetRating(internalRating, externnalRating);

            Assert.That(result, Is.EqualTo(internalRating));
        
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

            Assert.That(result2, Is.EqualTo(internalRating));
        
        }
        
        [Test]
        public void Test1_GetgetExternalWhenRatingInternalIsZero()
        {
        
            IUserRatingService userRatingService = new UserRatingInternalIfExistentService();
        
            var internalRating = 0;
            var externnalRating = 200;
        
            var result =userRatingService.GetRating(internalRating, externnalRating);

            Assert.That(result, Is.EqualTo(externnalRating));
        
        
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

            Assert.That(result2, Is.EqualTo(externnalRating));
        }

    }
}