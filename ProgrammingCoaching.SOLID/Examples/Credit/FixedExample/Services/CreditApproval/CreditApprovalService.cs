using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval;

public class CreditApprovalService: ICreditApprovalService
{
    private readonly IUserService _userService;
    private readonly ICreditService _creditService;

    public CreditApprovalService(IUserService userService)
    {
        _userService = userService;
    }
    
    public bool CanCreditBeGiven(CreditApplicationModel creditApplicationModel)
    {
        // 1. Check if user is registered if not register it and create a bank account for him
        // if he wants to register
        // if he does not want to register, register him without bank account
        var registered = _userService.HandleDataInformationOfUser(creditApplicationModel.NationalIdentificationID, creditApplicationModel.WantToRegister);

        // case not really taken into account
        if (registered == null)
        {
            return false;
        }
            
        
        var userInformation = _userService.GetAllUserInformation(registered?.NationalIdentificationID);
        
        // 2. Check if user is eligible for credit
        // 2.1 is blacklisted?
        
        

        // if yes, return true
       
        
        
        throw new NotImplementedException();
    }
    
    
}