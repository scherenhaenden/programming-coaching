using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices
{
    public interface IUserRegisteredDataService
    {
        RegisteredUser? GetUserRegistered(string nationalIdentificationId);
    
        RegisteredUser? RegisterUserAndGetRegisteredUser(string nationalIdentificationId);
    
        RegisteredUser? RegisterUserWithoutBankAccountAndGetReisteredUser(string nationalIdentificationId);
    }
}