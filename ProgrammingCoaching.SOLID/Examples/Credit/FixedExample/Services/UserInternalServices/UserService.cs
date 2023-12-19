using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public class UserService: IUserService
    {
        private readonly IDataCredit _db;
        private readonly IUserExternalService _userExternalService;
        private readonly IUserRegisteredDataService _userRegisteredDataService;

        public UserService(IDataCredit db, IUserExternalService userExternalService, IUserRegisteredDataService userRegisteredDataService)
        {
            _db = db;
            _userExternalService = userExternalService;
            _userRegisteredDataService = userRegisteredDataService;
        }
 

        public RegisteredUser HandleDataInformationOfUser(string nationalIdentificationId, bool wantToRegister)
        {
            var registeredUser = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);
        
            if(registeredUser == null)
            {
                if (wantToRegister)
                {
                    return _userRegisteredDataService.RegisterUserAndGetRegisteredUser(nationalIdentificationId)!;
                }
                return _userRegisteredDataService.RegisterUserWithoutBankAccountAndGetReisteredUser(nationalIdentificationId)!;
            }

            return registeredUser;
        }

        public ExtendedUserInformation? GetAllUserInformation(string nationalIdentificationId)
        {
            var registeredUser = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);
            var externalInformation = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
            var user = _db.ExternalUsers.SingleOrDefault(u => u.NationalIdentificationId == nationalIdentificationId);
        
            var extendedUserInformation = new ExtendedUserInformation()
            {
                RegisteredUser = registeredUser,
                User = user,
                CreditRatingUserExternals = externalInformation
            };
            return extendedUserInformation;

        }
    }
}