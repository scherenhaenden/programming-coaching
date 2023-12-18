using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.UserExternal;

[TestFixture]
public class UserExternalServiceTests
{
    
    
    DataCredit _db = new DataCredit();
    UserExternalService _userExternalService;

    public UserExternalServiceTests()
    {
        _userExternalService = new UserExternalService(_db);
    }
    
    [Test]
    public void GetCreditRatingUserExternals_ReturnsCorrectData()
    {

        var identificationId = _db.CreditRatingUsersExternals.First(x=>x.IsBlackListed == false).NationalIdentificationID;
        
        var result = _userExternalService.GetCreditRatingUserExternals(identificationId);

        Assert.IsNotNull(result);
        Assert.AreEqual(identificationId, result.NationalIdentificationID);
        Assert.Greater(result.CreditRating, 0);
        Assert.IsFalse(result.IsBlackListed);
    }

    [Test]
    public void GetCreditRatingUserExternals_ReturnsNullForInvalidId()
    {
        var result = _userExternalService.GetCreditRatingUserExternals("invalid_id");

        Assert.IsNull(result);
    }
    
}