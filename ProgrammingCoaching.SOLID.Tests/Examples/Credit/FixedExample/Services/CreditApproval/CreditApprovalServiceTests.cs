using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;
using ProgrammingCoaching.SOLID.Tests.Helpers;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.CreditApproval
{
    public class CreditApprovalServiceTests
    {
    
        IDataCredit _dataCredit = new DataCredit();
    
        [Test]
        public void CanGetCreditByRatingCalculationByInternal_True()
        {
        
            var registeredInternalBetterRating = _dataCredit.Users
                .Where(user => 
                    _dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        !external.IsBlackListed && 
                        external.CreditRating < 100
                    ) &&
                    _dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating > 900 && 
                        !internalUser.IsBlackListed
                    )
                )
                .Take(5)
                .ToList();

            foreach (var user in registeredInternalBetterRating)
            {
                CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
            
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                creditApplicationModel.CreditType = randomEnumValue;
                creditApplicationModel.NationalIdentificationID = user.NationalIdentificationID;
                creditApplicationModel.WantToRegister = true;
                creditApplicationModel.Address = user.Address;
                creditApplicationModel.Name = user.Name;
                creditApplicationModel.PhoneNumber = "555-555-5555";
                creditApplicationModel.Amount = 104;
                creditApplicationModel.CalculationTypeOfRating = CalculationTypeOfRating.Internal;
            
                // Arrange
                var creditApprovalService = CreateCreditApprovalService(creditApplicationModel.CalculationTypeOfRating);
                // Act
                var result = creditApprovalService.CanCreditBeGiven(creditApplicationModel);
            
                // Assert
                Assert.IsTrue(result);
            
            }
        
        }

        private ICreditApprovalService CreateCreditApprovalService(CalculationTypeOfRating calculationTypeOfRating)
        {
            IUserRatingService userRatingService = GetTypeOfRatingService(calculationTypeOfRating);
            
            IUserExternalService userExternalService = new UserExternalService(_dataCredit);
            
            IUserRegisteredDataService userRegisteredDataService = new UserRegisteredDataService(_dataCredit, userExternalService);
            
            IUserService userService = new UserService(_dataCredit, userExternalService, userRegisteredDataService);
            
            ICreditApprovalService creditApprovalService = new CreditApprovalService(userService, new BlacklistedService(), userRatingService, new ConditionRatings(_dataCredit));
            return creditApprovalService;
        }

        public IUserRatingService GetTypeOfRatingService(CalculationTypeOfRating calculationTypeOfRating)
        {
        
            if (calculationTypeOfRating == CalculationTypeOfRating.Internal)
            {
                return new UserRatingInternalIfExistentService();
            }
        
            return new UserRatingUserBetterRatingService();
        }
   
    
        [Test]
        public void CanGetCreditByRatingCalculationByInternal_False()
        {
            // Arrange
            var registeredInternalBetterRating = _dataCredit.Users
                .Where(user => 
                    _dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        !external.IsBlackListed && 
                        external.CreditRating > 900
                    ) &&
                    _dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating < 10 && 
                        !internalUser.IsBlackListed
                    )
                )
                .Take(5)
                .ToList();

            foreach (var user in registeredInternalBetterRating)
            {
                CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
            
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                creditApplicationModel.CreditType = randomEnumValue;
                creditApplicationModel.NationalIdentificationID = user.NationalIdentificationID;
                creditApplicationModel.WantToRegister = true;
                creditApplicationModel.Address = user.Address;
                creditApplicationModel.Name = user.Name;
                creditApplicationModel.PhoneNumber = "555-555-5555";
                creditApplicationModel.Amount = 100004;
                creditApplicationModel.CalculationTypeOfRating = CalculationTypeOfRating.Internal;
            
            
                //CalculationTypeOfRating calculationTypeOfRating = EnumHelper.GetRandomEnumValue<CalculationTypeOfRating>();
            
                //creditApplicationModel.CalculationTypeOfRating = calculationTypeOfRating;
            
                var creditApprovalService = CreateCreditApprovalService(creditApplicationModel.CalculationTypeOfRating);
                // Act
                var result = creditApprovalService.CanCreditBeGiven(creditApplicationModel);
            
                // Assert
                Assert.IsFalse(result);
            
            }
        
        }
        
        
        [Test]
        public void BlackListedUserBothSystems_False()
        {
            // Arrange
            var registeredInternalBetterRating = _dataCredit.Users
                .Where(user => 
                    _dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        external.IsBlackListed && 
                        external.CreditRating > 900
                    ) &&
                    _dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating < 10 && 
                        internalUser.IsBlackListed 
                    )
                )
                .Take(5)
                .ToList();

            foreach (var user in registeredInternalBetterRating)
            {
                CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
            
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                creditApplicationModel.CreditType = randomEnumValue;
                creditApplicationModel.NationalIdentificationID = user.NationalIdentificationID;
                creditApplicationModel.WantToRegister = true;
                creditApplicationModel.Address = user.Address;
                creditApplicationModel.Name = user.Name;
                creditApplicationModel.PhoneNumber = "555-555-5555";
                creditApplicationModel.Amount = 100004;
            
            
                CalculationTypeOfRating calculationTypeOfRating = EnumHelper.GetRandomEnumValue<CalculationTypeOfRating>();
            
                creditApplicationModel.CalculationTypeOfRating = calculationTypeOfRating;
            
                var creditApprovalService = CreateCreditApprovalService(creditApplicationModel.CalculationTypeOfRating);
                // Act
                var result = creditApprovalService.CanCreditBeGiven(creditApplicationModel);
            
                // Assert
                Assert.IsFalse(result);
            
            }
            
        }
        
        
         [Test]
        public void BlackListedUserExternalSystems_False()
        {
            // Arrange
            var registeredInternalBetterRating = _dataCredit.Users
                .Where(user => 
                    _dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        external.IsBlackListed == true && 
                        external.CreditRating > 900
                    ) &&
                    _dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating < 10 && 
                        !internalUser.IsBlackListed 
                    )
                )
                .Take(5)
                .ToList();

            foreach (var user in registeredInternalBetterRating)
            {
                CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
            
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                creditApplicationModel.CreditType = randomEnumValue;
                creditApplicationModel.NationalIdentificationID = user.NationalIdentificationID;
                creditApplicationModel.WantToRegister = true;
                creditApplicationModel.Address = user.Address;
                creditApplicationModel.Name = user.Name;
                creditApplicationModel.PhoneNumber = "555-555-5555";
                creditApplicationModel.Amount = 100004;
            
            
                CalculationTypeOfRating calculationTypeOfRating = EnumHelper.GetRandomEnumValue<CalculationTypeOfRating>();
            
                creditApplicationModel.CalculationTypeOfRating = calculationTypeOfRating;
            
                var creditApprovalService = CreateCreditApprovalService(creditApplicationModel.CalculationTypeOfRating);
                // Act
                var result = creditApprovalService.CanCreditBeGiven(creditApplicationModel);
            
                // Assert
                Assert.IsFalse(result);
            
            }
            
        }
        
         [Test]
        public void BlackListedUserInternalSystems_False()
        {
            // Arrange
            var registeredInternalBetterRating = _dataCredit.Users
                .Where(user => 
                    _dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        !external.IsBlackListed && 
                        external.CreditRating > 900
                    ) &&
                    _dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating < 10 && 
                        internalUser.IsBlackListed 
                    )
                )
                .Take(5)
                .ToList();

            foreach (var user in registeredInternalBetterRating)
            {
                CreditApplicationModel creditApplicationModel = new CreditApplicationModel();
            
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                creditApplicationModel.CreditType = randomEnumValue;
                creditApplicationModel.NationalIdentificationID = user.NationalIdentificationID;
                creditApplicationModel.WantToRegister = true;
                creditApplicationModel.Address = user.Address;
                creditApplicationModel.Name = user.Name;
                creditApplicationModel.PhoneNumber = "555-555-5555";
                creditApplicationModel.Amount = 100004;
            
            
                CalculationTypeOfRating calculationTypeOfRating = EnumHelper.GetRandomEnumValue<CalculationTypeOfRating>();
            
                creditApplicationModel.CalculationTypeOfRating = calculationTypeOfRating;
            
                var creditApprovalService = CreateCreditApprovalService(creditApplicationModel.CalculationTypeOfRating);
                // Act
                var result = creditApprovalService.CanCreditBeGiven(creditApplicationModel);
            
                // Assert
                Assert.IsFalse(result);
            
            }
            
        }
    }
}


