using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.UserInternalServices;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval
{
    public class CreditApprovalService(
        IUserService userService,
        IBlacklistedService blacklistedService,
        IUserRatingService userRatingService,
        IConditionRatings conditionRatings)
        : ICreditApprovalService
    {
        private readonly ICreditService _creditService = new CreditService(blacklistedService, userRatingService, conditionRatings);

        public bool CanCreditBeGiven(CreditApplicationModel creditApplicationModel)
        {
            // 1. Check if user is registered if not register it and create a bank account for him
            // if he wants to register
            // if he does not want to register, register him without bank account
            var registered = userService.HandleDataInformationOfUser(creditApplicationModel.NationalIdentificationId, creditApplicationModel.WantToRegister);
            
            // Get user Information
            var userInformation = userService.GetAllUserInformation(registered.NationalIdentificationId);
        
            // 2. Check if user is eligible for credit
            return _creditService.CanGetCreditByRatingCalculation(creditApplicationModel, userInformation!);
       
        }
    
    }
}