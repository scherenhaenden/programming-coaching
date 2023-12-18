using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

public interface IUserService
{
    RegistredUser HandleDataInformationOfUser(string nationalIdentificationId, bool wantToRegister);
    
    ExtendedUserInformation? GetAllUserInformation(string nationalIdentificationId);
}