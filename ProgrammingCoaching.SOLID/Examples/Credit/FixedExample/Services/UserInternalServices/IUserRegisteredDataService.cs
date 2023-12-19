using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public interface IUserRegisteredDataService
    {
        RegisteredUserInternalModel? GetUserRegistered(string nationalIdentificationId);
    
        RegisteredUserInternalModel? RegisterUserAndGetRegisteredUser(string nationalIdentificationId);
    
        RegisteredUserInternalModel? RegisterUserWithoutBankAccountAndGetReisteredUser(string nationalIdentificationId);
    }
}