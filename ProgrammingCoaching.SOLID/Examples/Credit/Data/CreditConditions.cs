namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class CreditConditions
{
    public CreditType CreditType { get; set; } // Type of credit (e.g., personal loan, mortgage, credit card, etc.)
    public decimal MinimumAmount { get; set; } // Minimum amount for the credit
    public decimal MaximumAmount { get; set; } // Maximum amount for the credit
    public Dictionary<decimal, double> AmountToCreditRating { get; set; } // Mapping of loan amount to minimum required credit rating
    public double InterestRate { get; set; } // Interest rate for the credit
    public int MaximumRepaymentPeriodMonths { get; set; } // Maximum repayment period in months

    public CreditConditions(
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


public enum CreditType
{
    AutoLoan,
    PersonalLoan,
    StudentLoan,
    CreditCard,
    BusinessLoan,
    HomeEquityLoan,
    PaydayLoan,
    DebtConsolidationLoan,
    Mortgage,
    CreditBuilderLoan,
    EquipmentFinancing,
    GreenLoan
}
