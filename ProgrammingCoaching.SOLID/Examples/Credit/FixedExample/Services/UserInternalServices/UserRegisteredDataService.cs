using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public class UserRegisteredDataService: IUserRegisteredDataService
    {
        private readonly IDataCredit _db;
        private readonly IUserExternalService _userExternalService;

        public UserRegisteredDataService(IDataCredit db, IUserExternalService userExternalService)
        {
            _db = db;
            _userExternalService = userExternalService;
        }
    
        public RegistredUser? GetUserRegistered(string nationalIdentificationId)
        {
            return _db.RegistredUsers.SingleOrDefault(u => u.NationalIdentificationID == nationalIdentificationId);
        }

        public RegistredUser? RegisterUserAndGetRegisteredUser(string nationalIdentificationId)
        {
            var creditRatingUserExternals = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
            
            if(creditRatingUserExternals == null)
            {
                return null;
            }
            
            _db.RegistredUsers.Add(new RegistredUser()
            {
                UserID = Guid.NewGuid().ToString(),
                NationalIdentificationID = nationalIdentificationId,
                InternalCreditRating = creditRatingUserExternals?.CreditRating ?? 0,
                AccountNumber = Guid.NewGuid().ToString(),
                IsBlackListed = creditRatingUserExternals?.IsBlackListed ?? false
            });
            
            return GetUserRegistered(nationalIdentificationId);
        }
    
        public RegistredUser? RegisterUserWithoutBankAccountAndGetReisteredUser(string nationalIdentificationId)
        {
            // muss raus
            var creditRatingUserExternals = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
            
            _db.RegistredUsers.Add(new RegistredUser()
            {
                UserID = Guid.NewGuid().ToString(),
                NationalIdentificationID = nationalIdentificationId,
                InternalCreditRating = creditRatingUserExternals?.CreditRating ?? 0,
                //AccountNumber = Guid.NewGuid().ToString(),
                IsBlackListed = creditRatingUserExternals?.IsBlackListed ?? false
            });
            
            return GetUserRegistered(nationalIdentificationId);
        }
        }
}