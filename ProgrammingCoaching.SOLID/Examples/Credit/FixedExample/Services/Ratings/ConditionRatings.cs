using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings
{
    public class ConditionRatings: IConditionRatings
    {
        private readonly IDataCredit _db;

        public ConditionRatings(IDataCredit db)
        {
            _db = db;
        }
    
        // Since this is a enum, there is no way to test for null in real life.
        // In real life we would also use a database to get the data and not an enum.
        public CreditConditionsInternalModel GetConditionsForCreditType(CreditType creditType)
        {
            return _db.CreditConditions.First(x => x.CreditType == creditType);
        }

        public bool IsRatingCoveredInCondition(CreditConditionsInternalModel creditConditionsInternalModel, double rating)
        {
            var myConditions = creditConditionsInternalModel.AmountToCreditRating.ToList()
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
        
            return IsRatingCoveredInCondition(myConditions, rating);
        }
    }
}