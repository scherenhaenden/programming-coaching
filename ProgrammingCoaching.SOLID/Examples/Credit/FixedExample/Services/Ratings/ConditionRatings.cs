using ProgrammingCoaching.SOLID.Examples.Credit.Data;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;

public class ConditionRatings: IConditionRatings
{
    private readonly DataCredit _db;

    public ConditionRatings(DataCredit db)
    {
        _db = db;
    }
    
    public CreditConditions? GetConditionsForCreditType(CreditType creditType)
    {
        return _db.CreditConditions.FirstOrDefault(x => x.CreditType == creditType);
    }

    public bool IsRatingCoveredInCondition(CreditConditions creditConditions, double rating)
    {
        var myConditions = creditConditions.AmountToCreditRating.ToList()
            .Where(x => x.Value <= rating).ToList();
        
        if (!myConditions.Any())
        {
            return false;
        }
        var amountAsDecimal = (decimal)rating;
        var result = myConditions.ToList()
            .Where(a => a.Key > amountAsDecimal)
            .OrderBy(a => a.Key)
            .FirstOrDefault();
           
        return result.Value != 0;
    }

    public bool IsRatingCoveredInCondition(double rating, CreditType creditType)
    {
        var myConditions = GetConditionsForCreditType(creditType);
        
        if(myConditions == null)
        {
            return false;
        }
        
        return IsRatingCoveredInCondition(myConditions, rating);
    }
}