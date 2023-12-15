using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

public interface IUserRegisteredDataService
{
    RegistredUser? GetUserRegistered(string nationalIdentificationId);
    
    RegistredUser? RegisterUserAndGetRegisteredUser(string nationalIdentificationId);
    
    RegistredUser? RegisterUserWithoutBankAccountAndGetReisteredUser(string nationalIdentificationId);
}