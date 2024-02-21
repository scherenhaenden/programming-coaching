namespace ProgrammingCoaching.SOLID.Examples.Credit.Data.Models
{
    /// <summary>
/// Represents the conditions for a credit offering, including credit type, amount limits, interest rate, and repayment terms.
/// </summary>
public class CreditConditionsInternalModel
{
    /// <summary>
    /// Gets or sets the type of credit (e.g., personal loan, mortgage, credit card, etc.).
    /// </summary>
    public CreditType CreditType { get; init; }

    /// <summary>
    /// Gets or sets the minimum amount for the credit.
    /// </summary>
    public decimal MinimumAmount { get; init; }

    /// <summary>
    /// Gets or sets the maximum amount for the credit.
    /// </summary>
    public decimal MaximumAmount { get; init; }

    /// <summary>
    /// Gets or sets the mapping of loan amount to minimum required credit rating.
    /// </summary>
    public Dictionary<decimal, double> AmountToCreditRating { get; init; }

    /// <summary>
    /// Gets or sets the interest rate for the credit.
    /// </summary>
    public double InterestRate { get; init; }

    /// <summary>
    /// Gets or sets the maximum repayment period in months.
    /// </summary>
    public int MaximumRepaymentPeriodMonths { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreditConditionsInternalModel"/> class with the specified parameters.
    /// </summary>
    /// <param name="creditType">The type of credit.</param>
    /// <param name="minimumAmount">The minimum amount for the credit.</param>
    /// <param name="maximumAmount">The maximum amount for the credit.</param>
    /// <param name="amountToCreditRating">The mapping of loan amount to minimum required credit rating.</param>
    /// <param name="interestRate">The interest rate for the credit.</param>
    /// <param name="maximumRepaymentPeriodMonths">The maximum repayment period in months.</param>
    public CreditConditionsInternalModel(
        CreditType creditType,
        decimal minimumAmount,
        decimal maximumAmount,
        Dictionary<decimal, double> amountToCreditRating,
        double interestRate,
        int maximumRepaymentPeriodMonths)
    {
        CreditType = creditType;
        MinimumAmount = minimumAmount;
        MaximumAmount = maximumAmount;
        AmountToCreditRating = amountToCreditRating;
        InterestRate = interestRate;
        MaximumRepaymentPeriodMonths = maximumRepaymentPeriodMonths;
    }
}
}
