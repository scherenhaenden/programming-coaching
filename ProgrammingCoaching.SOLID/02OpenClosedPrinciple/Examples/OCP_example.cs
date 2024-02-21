namespace ProgrammingCoaching.SOLID._02OpenClosedPrinciple.Examples;

public class OCP_example
{
    public void ProcessPayment(string paymentType, decimal amount)
    {
        switch (paymentType.ToLower())
        {
            case "paypal":
                // Logic to process PayPal payment
                Console.WriteLine("Processing PayPal payment...");
                break;
            case "creditcard":
                // Logic to process credit card payment
                Console.WriteLine("Processing credit card payment...");
                break;
            default:
                throw new ArgumentException("Invalid payment type");
        }
    }
    
    
    public void ProcessPaymentModified(string paymentType, decimal amount)
    {
        switch (paymentType.ToLower())
        {
            case "paypal": 
                // ... PayPal logic ...
                break;
            case "creditcard": 
                // ... Credit card logic ... 
                break;
            case "venmo":  // NEW - We had to modify the existing method 
                // Logic to process Venmo payment
                Console.WriteLine("Processing Venmo Payment...");
                break; 
            default:
                throw new ArgumentException("Invalid payment type");
        }
    }
}

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing PayPal payment of {0}", amount);
        // ... Actual PayPal integration logic ...
    }
}

public class CreditCardPayment : IPaymentMethod 
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing credit card payment of {0}", amount);
        // ... Actual credit card integration logic ...
    }
}

// Similarly, a VenmoPayment class implementing IPaymentMethod

public class PaymentProcessor
{
    private IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentMethod.ProcessPayment(amount);
    }
}