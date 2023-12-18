using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.UserInternalServices;

[TestFixture]
public class UserServiceTests
{
    private DataCredit _dataCredit;
    private IUserExternalService _userExternalService;
    private IUserRegisteredDataService _userRegisteredDataService;

    [SetUp]
    public void Setup()
    {
        // Initialize your dependencies here as needed
        _dataCredit = new DataCredit();
        _userExternalService = new UserExternalService(_dataCredit);
        _userRegisteredDataService = new UserRegisteredDataService(_dataCredit, _userExternalService);
    }

    [Test]
    public void HandleDataInformationOfUser_WhenUserNotRegisteredAndWantToRegister_ShouldReturnRegisteredUser()
    {
        // Arrange
        string nationalIdentificationId = "12345";
        bool wantToRegister = true;
        var userService = new UserService(_dataCredit, _userExternalService, _userRegisteredDataService);

        // Act
        var result = userService.HandleDataInformationOfUser(nationalIdentificationId, wantToRegister);

        // Assert
        Assert.IsNotNull(result);
        // Add more specific assertions based on your requirements
    }

    [Test]
    public void GetAllUserInformation_ShouldReturnExtendedUserInformation()
    {
        // Arrange
        string nationalIdentificationId = "12345";
        var userService = new UserService(_dataCredit, _userExternalService, _userRegisteredDataService);

        // Act
        var result = userService.GetAllUserInformation(nationalIdentificationId);

        // Assert
        Assert.IsNotNull(result);
        // Add more specific assertions based on your requirements
    }
}
