using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.BlackListed;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval
{
    public class CreditService: ICreditService
    {
        private readonly IBlacklistedService _blacklistedService;
        private readonly IUserRatingService _userRatingService;
        private readonly IConditionRatings _conditionRatings;

        public CreditService(IBlacklistedService blacklistedService, IUserRatingService userRatingService, IConditionRatings conditionRatings)
        {
            _blacklistedService = blacklistedService;
            _userRatingService = userRatingService;
            _conditionRatings = conditionRatings;
        }
    
        public bool CanGetCreditByRatingCalculation(CreditApplicationModel creditApplicationModel, ExtendedUserInformation extendedUserInformation)
        {
        
            var isBlackListedAnywhere =_blacklistedService.GetBlackListStatus( extendedUserInformation);
        
            if(isBlackListedAnywhere)
            {
                return false;
            }
        
            var rating = _userRatingService.GetRating(extendedUserInformation);
        
            return _conditionRatings.IsRatingCoveredInCondition(rating, creditApplicationModel.CreditType);
        }
    }
}