using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.FixedExample;

namespace ProgrammingCoaching.SOLID.Tests.SinglesResponsabilityPattern.FixedExample;

using NUnit.Framework;

[TestFixture]
public class UserManagerTests {
    [Test]
    public void GetUser_UserExists_ReturnsUserModel() {
        // Arrange
        var userManager = new UserManager();
        var userLogin = "User1";

        // Act
        var result = userManager.GetUser(userLogin);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(userLogin, result!.Name);
    }

    [Test]
    public void GetUser_UserDoesNotExist_ReturnsNull() {
        // Arrange
        var userManager = new UserManager();
        var userLogin = "NonExistentUser";

        // Act
        var result = userManager.GetUser(userLogin);

        // Assert
        Assert.IsNull(result);
    }
}
