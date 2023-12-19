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
    
        public RegisteredUser? GetUserRegistered(string nationalIdentificationId)
        {
            return _db.RegisteredUsers.SingleOrDefault(u => u.NationalIdentificationId == nationalIdentificationId);
        }

        public RegisteredUser? RegisterUserAndGetRegisteredUser(string nationalIdentificationId)
        {
            var creditRatingUserExternals = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
            
            if(creditRatingUserExternals == null)
            {
                return null;
            }
            
            _db.RegisteredUsers.Add(new RegisteredUser()
            {
                NationalIdentificationId = nationalIdentificationId,
                InternalCreditRating = creditRatingUserExternals?.CreditRating ?? 0,
                IsBlackListed = creditRatingUserExternals?.IsBlackListed ?? false
            });
            
            return GetUserRegistered(nationalIdentificationId);
        }
    
        public RegisteredUser? RegisterUserWithoutBankAccountAndGetReisteredUser(string nationalIdentificationId)
        {
            var creditRatingUserExternals = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
            
            _db.RegisteredUsers.Add(new RegisteredUser()
            {
                NationalIdentificationId = nationalIdentificationId,
                InternalCreditRating = creditRatingUserExternals?.CreditRating ?? 0,
                AccountNumber = String.Empty,
                IsBlackListed = creditRatingUserExternals?.IsBlackListed ?? false
            });
            
            return GetUserRegistered(nationalIdentificationId);
        }
    }
}