using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.UserInternalServices
{
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
            
            // Get internalusers that are not registered
            var value = _dataCredit.Users.Where(u =>
                    _dataCredit.RegistredUsers.All(ru => ru.NationalIdentificationID != u.NationalIdentificationID))
                .Take(1)
                .ToList().First();
            
            // Arrange
            string nationalIdentificationId = value.NationalIdentificationID;
            bool wantToRegister = true;
            var userService = new UserService(_dataCredit, _userExternalService, _userRegisteredDataService);

            // Act
            var result = userService.HandleDataInformationOfUser(nationalIdentificationId, wantToRegister);

            // Assert
            Assert.IsNotNull(result);
            // Add more specific assertions based on your requirements
        }
        
        
        [Test]
        public void HandleDataInformationOfUser_WhenUserNotRegisteredAndNotFound_ShouldReturnNull()
        {
            // Arrange
            string nationalIdentificationId = "no_valid_id";
            bool wantToRegister = true;
            var userService = new UserService(_dataCredit, _userExternalService, _userRegisteredDataService);

            // Act
            var result = userService.HandleDataInformationOfUser(nationalIdentificationId, wantToRegister);

            // Assert
            Assert.IsNull(result);
            // Add more specific assertions based on your requirements
        }

        

        [Test]
        public void GetAllUserInformation_ShouldReturnExtendedUserInformation()
        {
            
            // Get internalusers that are not registered
            var value = _dataCredit.Users.Where(u =>
                    _dataCredit.RegistredUsers.All(ru => ru.NationalIdentificationID != u.NationalIdentificationID))
                .Take(1)
                .ToList().First();
            
            // Arrange
            string nationalIdentificationId = value.NationalIdentificationID;
            var userService = new UserService(_dataCredit, _userExternalService, _userRegisteredDataService);

            // Act
            var result = userService.GetAllUserInformation(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            // Add more specific assertions based on your requirements
        }
    }
}
