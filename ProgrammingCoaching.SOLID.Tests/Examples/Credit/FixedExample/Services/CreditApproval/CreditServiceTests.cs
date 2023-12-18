using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.CreditApproval;

[TestFixture]
public class CreditServiceTests
{
    DataCredit _db = new DataCredit();
    
    [Test]
    public void CanGetCreditByRatingCalculationByInternal()
    {
        // Arrange
       /* CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
        
        creditApplicationModel.CreditType = CreditType.Internal;
        
        
        
        IUserRatingService userRatingService = new UserRatingInternalIfExistentService();
        
        ICreditService creditService = new CreditService(new BlacklistedService(), userRatingService, new ConditionRatings(_db));
        
    

        // Act
        var result = creditService.CanGetCreditByRatingCalculation(creditApplicationModel, extendedUserInformation);*/

        // Assert
        //Assert.IsFalse(result);
    }
}