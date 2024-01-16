using ProgrammingCoaching.SOLID.Examples.AutoLeasing.FixedExample;

namespace ProgrammingCoaching.SOLID.Tests.SinglesResponsabilityPattern.FixedExample
{
    using NUnit.Framework;

    [TestFixture]
    public class DiscountServiceTests {

        [Test]
        public void ApplyDiscount_ValidInput_ReturnsDiscountedPrice() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 1000;
        int discountPercentage = 20;

        // Act
        var discountedPrice = discountService.ApplyDiscount(currentPrice, discountPercentage);

        // Assert
        Assert.AreEqual(800, discountedPrice); // 20% discount on 1000 should be 800
    }

        [Test]
        public void ApplyDiscount_InvalidDiscountPercentage_ThrowsArgumentException() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 1000;
        int discountPercentage = -10;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => discountService.ApplyDiscount(currentPrice, discountPercentage));
    }

        [Test]
        public void ApplyDiscount_InvalidCurrentPrice_ThrowsArgumentException() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 0;
        int discountPercentage = 10;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => discountService.ApplyDiscount(currentPrice, discountPercentage));
    }

        [Test]
        public void ApplyDiscountWithResponseModel_ValidInput_ReturnsDiscountedPriceResponseModel() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 1000;
        int discountPercentage = 20;

        // Act
        var result = discountService.ApplyDiscountWithResponseModel(currentPrice, discountPercentage);

        // Assert
        Assert.IsTrue(result.Success);
        Assert.AreEqual(800, result.Data); // 20% discount on 1000 should be 800
    }

        [Test]
        public void ApplyDiscountWithResponseModel_InvalidDiscountPercentage_ReturnsErrorResponseModel() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 1000;
        int discountPercentage = -10;

        // Act
        var result = discountService.ApplyDiscountWithResponseModel(currentPrice, discountPercentage);

        // Assert
        Assert.IsFalse(result.Success);
        //Assert.AreEqual("Discount percentage cannot be negative.", result.ErrorMessage);
    }

        [Test]
        public void ApplyDiscountWithResponseModel_InvalidCurrentPrice_ReturnsErrorResponseModel() {
        // Arrange
        DiscountService discountService = new DiscountService();
        long currentPrice = 0;
        int discountPercentage = 10;

        // Act
        var result = discountService.ApplyDiscountWithResponseModel(currentPrice, discountPercentage);

        // Assert
        Assert.IsFalse(result.Success);
       // Assert.AreEqual("Current price must be greater than 0.", result.ErrorMessage);
    }
    }
}

