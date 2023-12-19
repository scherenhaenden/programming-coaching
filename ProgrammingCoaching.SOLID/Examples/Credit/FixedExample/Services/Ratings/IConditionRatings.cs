using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings
{
    public interface IConditionRatings
    {
        CreditConditionsInternalModel GetConditionsForCreditType(CreditType creditType);
    
        bool IsRatingCoveredInCondition(CreditConditionsInternalModel creditConditionsInternalModel, double rating);
    
        bool IsRatingCoveredInCondition(double rating, CreditType creditType);
    }
}