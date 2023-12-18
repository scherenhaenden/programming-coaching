using ProgrammingCoaching.SOLID.Examples.Credit.BadExample;
using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Tests.Helpers;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.BadExample
{
    public class CreditManagementTakeBetterRatingTests
    {
    

    
    
        [Test]
        public void Test1_CreditShouldBeGiven()
        {
            DataCredit dataCredit = new DataCredit();
        
            CreditManagementTakeBetterRating creditManagementTakeBetterRating = new CreditManagementTakeBetterRating(dataCredit);
        
            // Get users that are NOT blacklisted
            // The users should be intern registered and have a high score
            // The users should have a very low external score to prove that the are getting the credit by the internal score first
        
            var registeredInternalBetterRating = dataCredit.Users
                .Where(user => 
                    dataCredit.CreditRatingUsersExternals.Any(external => 
                        external.NationalIdentificationID == user.NationalIdentificationID && 
                        !external.IsBlackListed && 
                        external.CreditRating < 100
                    ) &&
                    dataCredit.RegistredUsers.Any(internalUser => 
                        internalUser.NationalIdentificationID == user.NationalIdentificationID && 
                        internalUser.InternalCreditRating > 900 && 
                        !internalUser.IsBlackListed
                    )
                )
                .Take(5)
                .ToList();

            // Get users that are NOT blacklisted
            // The users should NOT be intern registered 
            // The users should have a very high external score 
       
            var registeredBetterExternalRating = dataCredit.Users
                .Where(x => dataCredit.CreditRatingUsersExternals.Any(y =>
                    y.NationalIdentificationID == x.NationalIdentificationID && y.IsBlackListed == false && y.CreditRating > 900))
                .Where(x => !dataCredit.RegistredUsers.Any(y => y.NationalIdentificationID == x.NationalIdentificationID
                                                                && y.IsBlackListed == false
                )).Take(5).ToList();

            foreach (var registedUser in registeredInternalBetterRating)
            {
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                var result1 = creditManagementTakeBetterRating.CanCreditBeGiven(registedUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
                Assert.IsTrue(result1);
            }
        
            foreach (var notregistredUser in registeredBetterExternalRating)
            {
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                var result1 = creditManagementTakeBetterRating.CanCreditBeGiven(notregistredUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
                Assert.IsTrue(result1);
            }
            //create addresses with bogus
        }
    
    
        [Test]
        public void Test1_CreditShouldNotBeGiven()
        {
            DataCredit dataCredit = new DataCredit();
        
            CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal = new CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal(dataCredit);
        
        
            //give my just any user
            var user = dataCredit.Users.FirstOrDefault();

            var registedUsersWithHighScoreOnly5 = dataCredit.Users
                .Where(x => !dataCredit.RegistredUsers.Any(y => y.NationalIdentificationID == x.NationalIdentificationID && y.InternalCreditRating < 9)).Take(5).ToList();
        
            // users that are in Users but not in RegistredUsers get external information
            var notRegistredWithHighScoreOnly5 = dataCredit.Users
                .Where(x => !dataCredit.RegistredUsers.Any(y => y.NationalIdentificationID == x.NationalIdentificationID))
                .Where(x => dataCredit.CreditRatingUsersExternals.Any(y =>
                    y.NationalIdentificationID == x.NationalIdentificationID && y.CreditRating < 9)).Take(5)
            
                .ToList();

            foreach (var registedUser in registedUsersWithHighScoreOnly5)
            {
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                var result1 = creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal.CanCreditBeGiven(registedUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
                Assert.IsFalse(result1);
            }
        
            foreach (var notregistredUser in notRegistredWithHighScoreOnly5)
            {
                CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
                var result1 = creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal.CanCreditBeGiven(notregistredUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
                Assert.IsFalse(result1);
            }
            //create addresses with bogus
        }
    }
}