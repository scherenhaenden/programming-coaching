using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

public interface IConditionRatings
{
    CreditConditions? GetConditionsForCreditType(CreditType creditType);
    
    bool IsRatingCoveredInCondition(CreditConditions creditConditions, double rating);
    
    bool IsRatingCoveredInCondition(double rating, CreditType creditType);
}