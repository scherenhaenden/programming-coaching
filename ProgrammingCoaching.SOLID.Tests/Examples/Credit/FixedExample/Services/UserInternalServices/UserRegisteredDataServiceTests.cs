using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;
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
            var newUser = new RegisteredUserInternalModel
            {
                UserId = "user123",
                NationalIdentificationId = nationalIdentificationId,
                InternalCreditRating = 800,
                AccountNumber = "acc123",
                IsBlackListed = false
            };
            _dataCredit.RegisteredUsers.Add(newUser);

            // Act
            var result = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(newUser.UserId, result.UserId);
            // Add more specific assertions based on your requirements
        }

        [Test]
        public void RegisterUserAndGetRegisteredUser_ShouldRegisterUserAndReturnRegisteredUser()
        {
            
            // Get internalusers that are not registered
            var value = _dataCredit.ExternalUsers.Where(u =>
                    _dataCredit.RegisteredUsers.All(ru => ru.NationalIdentificationId != u.NationalIdentificationId))
                .Take(1)
                .ToList().First();
            
            // Arrange
            string nationalIdentificationId = value.NationalIdentificationId;

            // Act
            var result = _userRegisteredDataService.RegisterUserAndGetRegisteredUser(nationalIdentificationId);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result?.NationalIdentificationId, Is.EqualTo(nationalIdentificationId));
            Assert.IsNotNull(result?.AccountNumber);
            Assert.IsTrue(result?.InternalCreditRating >= 0);
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
            Assert.That(result.NationalIdentificationId, Is.EqualTo(nationalIdentificationId));
            Assert.IsTrue(string.IsNullOrEmpty(result.AccountNumber));
            Assert.IsTrue(result.InternalCreditRating >= 0);
            // Add more specific assertions based on your requirements
        }
    }
}