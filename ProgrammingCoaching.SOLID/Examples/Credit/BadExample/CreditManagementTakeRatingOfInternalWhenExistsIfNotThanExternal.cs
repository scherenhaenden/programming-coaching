using Bogus;
using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.BadExample
{
    public class CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal
    {
        private readonly DataCredit _db;

        public CreditManagementTakeRatingOfInternalWhenExistsIfNotThanExternal(DataCredit db)
        {
            _db = db;
        }
    

        private UserExternalModel? Users;
    
        public bool CanCreditBeGiven(string userNationalId, double amount, CreditType typeOfCredit,  string name, string address, string contactDetails, bool? wantToRegister)
        {
            DataCredit db = _db;
            
            // verify user is registered in the system
            Users = db.ExternalUsers.FirstOrDefault(u => u.NationalIdentificationId == userNationalId);
            var registeredUser = db.RegisteredUsers.FirstOrDefault(u => u.NationalIdentificationId == Users.NationalIdentificationId);
            bool isCustomer = registeredUser != null;
        
            // Begin: handle registration
            if (registeredUser == null && wantToRegister == null)
            {
                throw new Exception("User is not registered in the system; Ask if he wants to be registered");
            }
        
            if (registeredUser == null  && ( name == null && address == null && contactDetails == null))
            {
                throw new Exception("User is not registered in the system; we need the information to register him");
            }
        
            if (registeredUser == null && wantToRegister == false)
            {
                db.RegisteredUsers.Add(new RegisteredUser()
                {
                    NationalIdentificationId = userNationalId,
                    InternalCreditRating = db.CreditRatingUsersExternals?.FirstOrDefault(u => u.NationalIdentificationId == userNationalId)?.CreditRating ?? 0,                    
                    IsBlackListed = false
                });
            }
        
            if (registeredUser == null && wantToRegister == true)
            {
                db.RegisteredUsers.Add(new RegisteredUser()
                {                    
                    NationalIdentificationId = userNationalId,
                    InternalCreditRating = db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationId == userNationalId).CreditRating,                    
                    IsBlackListed = false
                });
                isCustomer = true;
            }
            // End: handle registration

            // Begin: calculation ob eligibility for credit
            if (isCustomer)
            {
                // check if user is blacklisted
                var retingInternalUser = db.RegisteredUsers.FirstOrDefault(u => u.NationalIdentificationId == Users.NationalIdentificationId);
                if (retingInternalUser.IsBlackListed)
                {
                    return false;
                }

                // check if user is eligible for credit based on his credit credit type to conditions
                var conditionsForTypeOfCredit = db.CreditConditions.FirstOrDefault(x => x.CreditType == typeOfCredit);
                if (conditionsForTypeOfCredit == null)
                {
                    Console.WriteLine("No conditions found for this type of credit");
                    throw new Exception("No conditions found for this type of credit");
                }
            
         
                // check if user is eligible for credit based on the amount and his credit rating
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

                Console.WriteLine("Credit can be given");
                return true;
            }

            var externalInformationUser =
                db.CreditRatingUsersExternals.FirstOrDefault(u => u.NationalIdentificationId == userNationalId);
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
            Console.WriteLine("Credit can be given");
            return true;
            
            // End: calculation ob eligibility for credit
        }
    }
}
