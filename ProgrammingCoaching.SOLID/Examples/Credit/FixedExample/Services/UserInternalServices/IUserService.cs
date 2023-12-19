using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public interface IUserService
    {
        RegisteredUser HandleDataInformationOfUser(string nationalIdentificationId, bool wantToRegister);
    
        ExtendedUserInformation? GetAllUserInformation(string nationalIdentificationId);
    }
}