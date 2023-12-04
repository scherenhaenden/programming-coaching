using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.Models;

namespace ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.FixedExample;

public class DiscountService {
    
    /// <summary>
    /// Applies discount to the current price.
    /// </summary>
    /// <param name="currentPrice">The current price, which cannot be 0 or less than that.</param>
    /// <param name="discountPercentage">The discount percentage, which cannot be negative.</param>
    /// <returns>The discounted price as a whole number (no fractional cents).</returns>
    public double ApplyDiscount(double currentPrice, double discountPercentage) {
        // Ensure discountPercentage is non-negative
        if (discountPercentage < 0) {
            throw new ArgumentException("Discount percentage cannot be negative.");
        }

        // Ensure currentPrice is greater than 0
        if (currentPrice <= 0) {
            throw new ArgumentException("Current price must be greater than 0.");
        }

        // Calculate the discounted price
        double discountedPrice = currentPrice - (currentPrice * discountPercentage / 100.0);
    
        return discountedPrice;
    }
    
    
    /// <summary>
    /// Applies discount to the current price.
    /// </summary>
    /// <param name="currentPrice">The current price, which cannot be 0 or less than that.</param>
    /// <param name="discountPercentage">The discount percentage, which cannot be negative.</param>
    /// <returns>The discounted price as a whole number (no fractional cents).</returns>
    public ResponseModel<double> ApplyDiscountWithResponseModel(double currentPrice, double discountPercentage) {
        // Ensure discountPercentage is non-negative
        if (discountPercentage < 0) {
            //throw new ArgumentException("Discount percentage cannot be negative.");
            return new ResponseModel<double>("Discount percentage cannot be negative.");
        }

        // Ensure currentPrice is greater than 0
        if (currentPrice <= 0) {
            //throw new ArgumentException("Current price must be greater than 0.");
            return new ResponseModel<double>("Current price must be greater than 0.");
        }

        // Calculate the discounted price
        double discountedPrice = currentPrice - (currentPrice * discountPercentage / 100);
    
        return new ResponseModel<double>(discountedPrice);
    }
}