using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public interface IUserService
    {
        RegisteredUserInternalModel HandleDataInformationOfUser(string nationalIdentificationId, bool wantToRegister);
    
        ExtendedUserInformation? GetAllUserInformation(string nationalIdentificationId);
    }
}