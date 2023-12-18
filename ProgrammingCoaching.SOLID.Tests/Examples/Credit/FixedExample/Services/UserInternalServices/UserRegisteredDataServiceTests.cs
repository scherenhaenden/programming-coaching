using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.UserInternalServices
{
    [TestFixture]
    public class UserRegisteredDataServiceTests
    {
        
        private readonly DataCredit _dataCredit = new DataCredit();
        private IUserExternalService _userExternalService;
        private UserRegisteredDataService _userRegisteredDataService;

        [SetUp]
        public void Setup()
        {
            // Initialize your dependencies here as needed
            _userExternalService = new UserExternalService(_dataCredit);
            _userRegisteredDataService = new UserRegisteredDataService(_dataCredit, _userExternalService);
        }

        [Test]
        public void GetUserRegisteredDoNoExit_ShouldReturnNull()
        {
            // Arrange
            string nationalIdentificationId = "12345";
           
            // Act
            var result = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);

            // Assert
            Assert.IsNull(result);
            //Assert.AreEqual(newUser.UserID, result.UserID);
            // Add more specific assertions based on your requirements
        }
        
        [Test]
        public void GetUserRegisteredDoNoExit_ShouldReturnNotNull()
        {
            // Arrange
            string nationalIdentificationId = "123456";
            var newUser = new RegistredUser
            {
                UserID = "user123",
                NationalIdentificationID = nationalIdentificationId,
                InternalCreditRating = 800,
                AccountNumber = "acc123",
                IsBlackListed = false
            };
            _dataCredit.RegistredUsers.Add(newUser);

            // Act
            var result = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(newUser.UserID, result.UserID);
            // Add more specific assertions based on your requirements
        }

        [Test]
        public void RegisterUserAndGetRegisteredUser_ShouldRegisterUserAndReturnRegisteredUser()
        {
            // Arrange
            string nationalIdentificationId = "56789";

            // Act
            var result = _userRegisteredDataService.RegisterUserAndGetRegisteredUser(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(nationalIdentificationId, result.NationalIdentificationID);
            Assert.IsNotNull(result.AccountNumber);
            Assert.IsTrue(result.InternalCreditRating >= 0);
            // Add more specific assertions based on your requirements
        }

        [Test]
        public void RegisterUserWithoutBankAccountAndGetReisteredUser_ShouldRegisterUserAndReturnRegisteredUser()
        {
            // Arrange
            string nationalIdentificationId = "98765";

            // Act
            var result = _userRegisteredDataService.RegisterUserWithoutBankAccountAndGetReisteredUser(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(nationalIdentificationId, result.NationalIdentificationID);
            Assert.IsNull(result.AccountNumber);
            Assert.IsTrue(result.InternalCreditRating >= 0);
            // Add more specific assertions based on your requirements
        }
    }
}