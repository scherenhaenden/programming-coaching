using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.Ratings;
using ProgrammingCoaching.SOLID.Tests.Helpers;

namespace ProgrammingCoaching.SOLID.Tests.Examples.Credit.FixedExample.Services.Ratings
{
    using NUnit.Framework;

    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class ConditionRatingsTests
    {
        DataCredit _db = new DataCredit();
    

        public ConditionRatingsTests()
        {
            _conditionRatingsService = new ConditionRatings(_db);
        }

        private readonly ConditionRatings _conditionRatingsService;

        [Test]
        public void GetConditionsForCreditType_ReturnsCorrectConditions()
        {
            // Arrange
            CreditType creditType = EnumHelper.GetRandomEnumValue<CreditType>();

            // Act
            var result = _conditionRatingsService.GetConditionsForCreditType(creditType);

            // Assert
            Assert.IsNotNull(result);
            // Additional assertions based on expected behavior
        }

        [Test]
        public void IsRatingCoveredInCondition_WhenConditionsExist_ReturnsTrue()
        {
            // Arrange
            CreditType creditType = EnumHelper.GetRandomEnumValue<CreditType>();
            var creditConditions = _conditionRatingsService.GetConditionsForCreditType(creditType);
            var rating = 999;
        
            Assert.IsNotNull(creditConditions);

            // Act
            var result = _conditionRatingsService.IsRatingCoveredInCondition(creditConditions, rating);

            // Assert
            Assert.IsTrue(result);
        }
    
        [Test]
        public void IsRatingCoveredInCondition_WhenConditionsExist_ReturnsFalse()
        {
            // Arrange
            CreditType creditType = EnumHelper.GetRandomEnumValue<CreditType>();
            var creditConditions = _conditionRatingsService.GetConditionsForCreditType(creditType);
            var rating2 = 1;
        
            // Act
            var result2 = _conditionRatingsService.IsRatingCoveredInCondition(creditConditions, rating2);

            // Assert
            Assert.IsFalse(result2);
        }


        [Test]
        public void IsRatingCoveredInCondition_OverloadMethod_ReturnsTrue()
        {
            // Arrange
            var rating = 1000;
            var creditType =  EnumHelper.GetRandomEnumValue<CreditType>();

            // Act
            var result = _conditionRatingsService.IsRatingCoveredInCondition(rating, creditType);

            // Assert
            Assert.IsTrue(result);
        }
    
        [Test]
        public void IsRatingCoveredInCondition_OverloadMethod_ReturnsFalse()
        {
            // Arrange
            var rating = 1;
            var creditType =  EnumHelper.GetRandomEnumValue<CreditType>();

            // Act
            var result = _conditionRatingsService.IsRatingCoveredInCondition(rating, creditType);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
