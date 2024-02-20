namespace ProgrammingCoaching.SOLID._01SinglesResponsabilityPattern.Examples;

public class SRP_Example
{
    public void ProcessOrder(string rawOrderDetails) 
    {
        
        /* !!! This method violates the Single Responsibility Principle (SRP) in multiple ways:

           * Responsibilities:
               * Order Parsing: Splits a raw string with hardcoded indexes, making it error-prone.
               * Payment Processing:  Interrupts for credit card input, a major security risk.
               * Inventory Management: Interacts with inventory (even if simulation), wrong place for this.
               * Email Generation: Constructs HTML email directly, poor separation.
               * Shipping Calculation: Crude shipping logic directly embedded.
               * Discount Application: Arbitrary coupon checks and Wednesday discounts out of place.
               * Console Output (Potentially): Mixing UI concerns with core order processing.

           * Problems caused by SRP violation:
               * Tight Coupling:  Changing one part likely breaks others.
               * Low Readability:  Mentally exhausting to follow the logic flow.
               * Difficult to Test:  Requires mocking many external dependencies for unit tests.
               * Security Issues:  Handles payment data in an unsafe way.

           !!! Refactoring is urgently needed. Each responsibility should be moved to its own class or module.
        */
        
        
        // 1. Oh no! Raw string parsing
        string[] orderParts = rawOrderDetails.Split(';'); 
        string customerName = orderParts[0].Substring(7); 
        decimal orderTotal = decimal.Parse(orderParts[3].Replace("$", ""));

        // 2.  Payment handling (Yikes!)
        Console.WriteLine("Enter credit card number:");
        string creditCardNumber = Console.ReadLine(); 
        // ... Unvalidated card processing goes here ...

        // 3.  Inventory Madness
        if (CheckInventory()) // Placeholder for chaotic inventory logic
        {
            // 4. HTML Email Generation
            string emailBody = "<h1>Thank you " + customerName + "!</h1>";
            emailBody += "<p>Your order total: $" + orderTotal + "</p>";
            SendEmail("customer@example.com", "Order Confirmation", emailBody);
        }
        else 
        {
            Console.WriteLine("Out of stock,  dreams shattered :(");
        }
        
        // ... (All the existing bad things here) ... 

        // 5. Let's calculate shipping!
        decimal shippingCost = 0;
        string countryCode = orderParts[4].Substring(0, 2); 
        if (countryCode == "US") {
            
            if (orderTotal < 50.0m) {
                shippingCost= 5.99m; 
            } else if (orderTotal < 100.0m) {
                shippingCost= 9.99m; 
            } else {
                shippingCost= 0.0m; // Free shipping on large orders
            }
            
        } else {
            decimal baseRate = 20.0m; 
    
            // Let's pretend certain countries get extra fees
            switch (countryCode)
            {
                case "CA": 
                    baseRate += 8.0m;
                    break;
                case "AU": 
                    baseRate += 15.0m; 
                    break;
                // ... more cases for other countries
                default:
                    break; // No additional fees
            }


            shippingCost = baseRate;
        }
        orderTotal += shippingCost;

        // 6.  Apply the latest marketing whims
        bool hasCoupon = rawOrderDetails.Contains("COUPON:");
        DateTime today = DateTime.Now;
        if (hasCoupon || today.DayOfWeek == DayOfWeek.Wednesday) {
            orderTotal *= 0.9m; // 10% off!
        }

        // ... More horror down here ...
        
        
    }
    
    // Omitted: Terrible implementations of CalculateDomesticShipping/InternationalShipping

    private bool CheckInventory()
    {
        // Simulating unreliable inventory
        Random random = new Random();
        return random.Next(10) > 3;  
    }

    private void SendEmail(string to, string subject, string body) 
    {
        //  Pseudo-email sending - bad practice!
        Console.WriteLine("Sending email...");
        Console.WriteLine("To: " + to);
        Console.WriteLine("Subject: " + subject);
        Console.WriteLine(body); 
    }

}