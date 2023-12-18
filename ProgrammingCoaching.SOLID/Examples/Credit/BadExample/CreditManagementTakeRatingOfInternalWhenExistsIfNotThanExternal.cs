using Bogus;
using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.BadExample
{
    public class CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal
    {
        private readonly DataCredit _db;

        public CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal(DataCredit db)
        {
            _db = db;
        }
    

        private User Users;
    
        public bool CanCreditBeGiven(string userNationalId, double amount, CreditType typeOfCredit,  string name, string address, string contactDetails, bool? wantToRegister)
        {
            // verify user is registered in the system
            DataCredit db = _db;
        
        
            //db.ConnectToDatabase();
        
            Users = db.Users.FirstOrDefault(u => u.NationalIdentificationID == userNationalId);
            var registredUser = db.RegistredUsers.FirstOrDefault(u => u.NationalIdentificationID == Users.NationalIdentificationID);
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
                // register user
                // create a new user
                // add user to database
                // return
                Console.WriteLine("The User will be registered without account");
                db.RegistredUsers.Add(new RegistredUser()
                {
                    
                    NationalIdentificationID = userNationalId,
                    InternalCreditRating = db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationID == userNationalId).CreditRating,                    
                    IsBlackListed = false
                });
            
                //RegistredUsers = db.RegistredUsers.FirstOrDefault(u => u.NationalIdentificationID == userNationalId);
            
            
            
            }
        
            if (registredUser == null && wantToRegister == true)
            {
                // register user
                // create a new user
                // add user to database
                // return
                Console.WriteLine("The User will be registered without account");
                db.RegistredUsers.Add(new RegistredUser()
                {                    
                    NationalIdentificationID = userNationalId,
                    InternalCreditRating = db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationID == userNationalId).CreditRating,                    
                    IsBlackListed = false
                });
                isCustomer = true;
            
                //Users = db.Users.FirstOrDefault(u => u.NationalIdentificationID == userNationalId);
            
            }
            // find out if the user is on a blacklist
            // if yes, return

            if (isCustomer)
            {
                var retingInternalUser = db.RegistredUsers.FirstOrDefault(u => u.NationalIdentificationID == Users.NationalIdentificationID);
                if (retingInternalUser.IsBlackListed)
                {
                    Console.WriteLine("User is blacklisted");
                    //throw new Exception("User is blacklisted");
                    return false;
                }

                var conditionsForTypeOfCredit = db.CreditConditions.FirstOrDefault(x => x.CreditType == typeOfCredit);
                

                if (conditionsForTypeOfCredit == null)
                {
                    Console.WriteLine("No conditions found for this type of credit");
                    throw new Exception("No conditions found for this type of credit");
                }
            
         

                var myConditions = conditionsForTypeOfCredit.AmountToCreditRating.ToList()
                    .Where(x => x.Value <= retingInternalUser.InternalCreditRating).ToList();
            
                if (myConditions.Count() < 1)
                {
                    Console.WriteLine("No conditions found for this type of credit");
                    return false;
                }
            
                var amountAsDecimal = (decimal)amount;
                var result = myConditions.ToList()
                    .Where(a => a.Key >= amountAsDecimal)
                    .OrderByDescending(a => a.Key)
                    .FirstOrDefault();
           
                if (result.Value == null || result.Value == 0)
                {
                    Console.WriteLine("No conditions found for this type of credit");
                    return false;
                }
                else
                {
                    Console.WriteLine("Credit can be given");
                    return true;
                }
            }

            var externalInformationUser =
                db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationID == userNationalId);
            var blackListedExternal = externalInformationUser?.IsBlackListed;
            if (blackListedExternal is not null && blackListedExternal.Value)
            {
                Console.WriteLine("User is blacklisted");
                //throw new Exception("User is blacklisted");
                return false;
            }

            var conditionsForTypeOfCreditExternal = db.CreditConditions.FirstOrDefault(x => x.CreditType == typeOfCredit);

            if (conditionsForTypeOfCreditExternal == null)
            {
                Console.WriteLine("No conditions found for this type of credit");
                //throw new Exception("No conditions found for this type of credit");
                return false;
            }
            
            var myConditionsExternal = conditionsForTypeOfCreditExternal.AmountToCreditRating.ToList().Where(x=>x.Value<=externalInformationUser.CreditRating).OrderByDescending(x=>x.Key).Count();
            if (myConditionsExternal < 1)
            {
                Console.WriteLine("No conditions found for this type of credit");
                return false;
            }
            {
                Console.WriteLine("Credit can be given");
                return true;
            }
        }

    }
}
