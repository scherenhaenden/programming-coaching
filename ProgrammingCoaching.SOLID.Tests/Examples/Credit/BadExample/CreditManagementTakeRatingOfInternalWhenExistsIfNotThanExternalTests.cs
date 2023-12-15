using ProgrammingCoaching.SOLID.Examples.Credit.BadExample;
using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.BadExample;

public class CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternalTests
{
    public static class EnumHelper
    {
        private static Random random = new Random();

        public static T GetRandomEnumValue<T>() where T : Enum
        {
            T[] enumValues = (T[])Enum.GetValues(typeof(T));
            return enumValues[random.Next(enumValues.Length)];
        }
    }

    
    
    [Test]
    public void Test1_CreditShouldBeGiven()
    {
        DataCredit dataCredit = new DataCredit();
        
        CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal = new CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal(dataCredit);


        var registedUsersWithHighScoreOnly5 = dataCredit.Users
            .Where(x => dataCredit.CreditRatingUsersExternals.Any(y =>
                y.NationalIdentificationID == x.NationalIdentificationID && y.IsBlackListed == false))
            .Where(x => !dataCredit.RegistredUsers.Any(y => y.NationalIdentificationID == x.NationalIdentificationID && y.InternalCreditRating > 900
            && y.IsBlackListed == false
            )).Take(5).ToList();
        
        // users that are in Users but not in RegistredUsers get external information
        var notRegistredWithHighScoreOnly5 = dataCredit.Users
            .Where(x => !dataCredit.RegistredUsers.Any(y => y.NationalIdentificationID == x.NationalIdentificationID))
            .Where(x => dataCredit.CreditRatingUsersExternals.Any(y =>
                y.NationalIdentificationID == x.NationalIdentificationID && y.CreditRating > 900 && y.IsBlackListed == false)).Take(5)
            
            .ToList();

        foreach (var registedUser in registedUsersWithHighScoreOnly5)
        {
            CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
            var result1 = creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal.CanCreditBeGiven(registedUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
            Assert.IsTrue(result1);
        }
        
        foreach (var notregistredUser in notRegistredWithHighScoreOnly5)
        {
            CreditType randomEnumValue = EnumHelper.GetRandomEnumValue<CreditType>();
            
            var result1 = creditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal.CanCreditBeGiven(notregistredUser.NationalIdentificationID, 104, randomEnumValue, "John Doe", "123 Main St", "555-555-5555", true);
        
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