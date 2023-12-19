using Bogus;
using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.BadExample
{
    public class CreditManagementTakeBetterRating
    {
        private readonly DataCredit _db;

        public CreditManagementTakeBetterRating(DataCredit db)
        {
            _db = db;
        }
    

        private UserExternalModel _usersExternalModel;
    
        public bool CanCreditBeGiven(string userNationalId, double amount, CreditType typeOfCredit,  string name, string address, string contactDetails, bool? wantToRegister)
        {
        // verify user is registered in the system
        DataCredit db = _db;
        
        
        //db.ConnectToDatabase();
        
        _usersExternalModel = db.ExternalUsers.FirstOrDefault(u => u.NationalIdentificationId == userNationalId);
        var registredUser = db.RegisteredUsers.FirstOrDefault(u => u.NationalIdentificationId == _usersExternalModel.NationalIdentificationId);
        bool isCustomer = registredUser != null;
        
        if (registredUser == null && wantToRegister == null)
        {
            // user is not registered in the system
            // ask if he wants to be registered
            // if yes, register him
            // if no, return
            
            Console.WriteLine("User is not registered in the system");
            throw new Exception("User is not registered in the system; Ask if he wants to be registered");
        }
        
        if (registredUser == null  && ( name == null && address == null && contactDetails == null))
        {
            // register user
            // create a new user
            // add user to database
            // return
            Console.WriteLine("User is not registered in the system; we need information about him");
            throw new Exception("User is not registered in the system; we need the information to register him");
        }
        
        
        
        if (registredUser == null && wantToRegister == false)
        {
            Console.WriteLine("The User will be registered without account");
            db.RegisteredUsers.Add(new RegisteredUser()
            {
                
                NationalIdentificationId = userNationalId,
                InternalCreditRating = db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationId == userNationalId)!.CreditRating,                
                IsBlackListed = false
            });
        }
        
        if (registredUser == null && wantToRegister == true)
        {
            // register user
            // create a new user
            // add user to database
            // return
            Console.WriteLine("The User will be registered without account");
            db.RegisteredUsers.Add(new RegisteredUser()
            {                
                NationalIdentificationId = userNationalId,
                InternalCreditRating = db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationId == userNationalId).CreditRating,                
                IsBlackListed = false
            });
            //Users = db.Users.FirstOrDefault(u => u.NationalIdentificationID == userNationalId);
            
        }
        // find out if the user is on a blacklist
        // if yes, return
        
        // check if the user is blacklisted somewhere
        var internalInformation =
            db.RegisteredUsers.FirstOrDefault(u => u.NationalIdentificationId == _usersExternalModel.NationalIdentificationId);
        var externalInformation =
            db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationId == _usersExternalModel.NationalIdentificationId);
        
        if(internalInformation.IsBlackListed || externalInformation.IsBlackListed)
        {
            Console.WriteLine("User is blacklisted");
            //throw new Exception("User is blacklisted");
            return false;
        }
        
        // get highest rating
        var highestRating = internalInformation.InternalCreditRating > externalInformation.CreditRating
            ? internalInformation.InternalCreditRating
            : externalInformation.CreditRating;
        
        // check if has rating for credit
        var conditionsForTypeOfCredit = db.CreditConditions.FirstOrDefault(x => x.CreditType == typeOfCredit);
        if (conditionsForTypeOfCredit == null)
        {
            Console.WriteLine("No conditions found for this type of credit");
            throw new Exception("No conditions found for this type of credit");
        }
        
        var myConditions = conditionsForTypeOfCredit.AmountToCreditRating.ToList()
            .Where(x => x.Value <= highestRating).ToList();
        
        if (myConditions.Count() < 1)
        {
            Console.WriteLine("No conditions found for this type of credit");
            return false;
        }
            
        var amountAsDecimal = (decimal)amount;
        var result = myConditions.ToList()
            .Where(a => a.Key > amountAsDecimal)
            .OrderBy(a => a.Key)
            .FirstOrDefault();
           
        if (result.Value == null || result.Value == 0)
        {
            Console.WriteLine("No conditions found for this type of credit");
            return false;
        }

        Console.WriteLine("Credit can be given");
        return true;
        }

    }
}
