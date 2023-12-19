using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.BlackListed
{
    public class BlacklistedServiceTests
    {
        private IBlacklistedService _blacklistedService = new BlacklistedService();

        [Test]
        public void GetBlackListStatusShouldBe()
        {
        
            ExtendedUserInformation extendedUserInformation = new ExtendedUserInformation
            {
                RegisteredUser = new RegisteredUser
                {
                    IsBlackListed = true
                },
                CreditRatingUserExternals = new CreditRatingUserExternals
                {
                    IsBlackListed = true
                }
            };




            var result = _blacklistedService.GetBlackListStatus(extendedUserInformation);
        
            Assert.IsTrue(result);
            
            var extendedUserInformation1 = new ExtendedUserInformation
            {
                RegisteredUser = new RegisteredUser
                {
                    IsBlackListed = false
                },
                CreditRatingUserExternals = new CreditRatingUserExternals
                {
                    IsBlackListed = true
                }
            };
            var result1 = _blacklistedService.GetBlackListStatus(extendedUserInformation1);
        
            Assert.IsTrue(result1);
        
        
            var extendedUserInformation2 = new ExtendedUserInformation
            {
                RegisteredUser = new RegisteredUser
                {
                    IsBlackListed = true
                },
                CreditRatingUserExternals = new CreditRatingUserExternals
                {
                    IsBlackListed = false
                }
            };
            var result2 = _blacklistedService.GetBlackListStatus(extendedUserInformation2);
        
            Assert.IsTrue(result2);
        }
    
    
        [Test]
        public void GetBlackListStatusShouldNotBe()
        {
        
         
        
            var extendedUserInformation3 = new ExtendedUserInformation
            {
                RegisteredUser = new RegisteredUser
                {
                    IsBlackListed = false
                },
                CreditRatingUserExternals = new CreditRatingUserExternals
                {
                    IsBlackListed = false
                }
            };
            var result3 = _blacklistedService.GetBlackListStatus(extendedUserInformation3);
        
            Assert.IsFalse(result3);
        }
    }
}