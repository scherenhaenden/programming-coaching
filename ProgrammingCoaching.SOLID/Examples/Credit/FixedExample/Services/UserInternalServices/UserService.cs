using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserExternal;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

public class UserService: IUserService
{
    private readonly DataCredit _db;
    private readonly IUserExternalService _userExternalService;
    private readonly IUserRegisteredDataService _userRegisteredDataService;

    public UserService(DataCredit db, IUserExternalService userExternalService, IUserRegisteredDataService userRegisteredDataService)
    {
        _db = db;
        _userExternalService = userExternalService;
        _userRegisteredDataService = userRegisteredDataService;
    }
 

    public RegistredUser HandleDataInformationOfUser(string nationalIdentificationId, bool wantToRegister)
    {
        var registredUser = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);
        
        if(registredUser == null)
        {
            if (wantToRegister)
            {
                return _userRegisteredDataService.RegisterUserAndGetRegisteredUser(nationalIdentificationId)!;
            }
            return _userRegisteredDataService.RegisterUserWithoutBankAccountAndGetReisteredUser(nationalIdentificationId)!;
            
        }

        return registredUser;
    }

    public ExtendedUserInformation? GetAllUserInformation(string nationalIdentificationId)
    {
        var registredUser = _userRegisteredDataService.GetUserRegistered(nationalIdentificationId);
        var externalInformation = _userExternalService.GetCreditRatingUserExternals(nationalIdentificationId);
        var user = _db.Users.SingleOrDefault(u => u.NationalIdentificationID == nationalIdentificationId);
        
        var extendedUserInformation = new ExtendedUserInformation()
        {
            RegistredUser = registredUser,
            User = user,
            CreditRatingUserExternals = externalInformation
        };
        return extendedUserInformation;

    }
}