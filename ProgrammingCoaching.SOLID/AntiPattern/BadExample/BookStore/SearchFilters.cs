namespace ProgrammingCoaching.SOLID.AntiPattern.BadExample.BookStore;



/*
    SearchFilters Class - Poor Design Example

    Functionalities and Characteristics:
    - Manages search criteria for the bookstore, including genre, author, and price range.
    - Contains private fields for genre, author, minPrice, and maxPrice to store search criteria.
    - Maintains unrelated private state members such as taxRate, isEmailSent, and inventoryUpdateCount, demonstrating a lack of focus and cohesion.
    - Provides a method ApplySearchCriteria to update search criteria, which has side effects of sending emails and updating inventory counts, leading to unexpected behavior and violating Single Responsibility Principle.
    - Includes a private SendEmail method for sending emails, unrelated to the core purpose of search filters, breaking encapsulation and mixing responsibilities.
    - Contains a private UpdateInventoryBasedOnSearch method, which is irrelevant to search filters and adds to the shared state complexity.
    - Implements a private CalculateTax method for tax calculations, demonstrating inappropriate placement of finance-related logic within the class.
    - Offers a DisplayInternalState method to expose the class's private state, violating the principle of encapsulation and demonstrating poor class design.
    - The class as a whole exemplifies a design with excessive responsibilities, lack of separation of concerns, and poor encapsulation, making it difficult to maintain and test.

    Note: This class is intentionally designed with poor software design principles as an illustrative example. In practice, such design should be avoided to ensure maintainable and scalable code.
*/

public class SearchFilters
{
    private string genre;
    private string author;
    private decimal minPrice;
    private decimal maxPrice;

    // Private shared state members
    private decimal taxRate; // Should not be part of SearchFilters
    private bool isEmailSent; // Unrelated to search filters
    private int inventoryUpdateCount; // Irrelevant to the class purpose

    public SearchFilters()
    {
        genre = string.Empty;
        author = string.Empty;
        minPrice = 0.0m;
        maxPrice = decimal.MaxValue;
        taxRate = 0.15m; // 15% tax rate
        isEmailSent = false;
        inventoryUpdateCount = 0;
    }

    // Public method with side effects that affect private state
    public void ApplySearchCriteria(string genre, string author, decimal minPrice, decimal maxPrice)
    {
        this.genre = genre;
        this.author = author;
        this.minPrice = minPrice;
        this.maxPrice = maxPrice;

        // Side effects - unrelated actions
        SendEmail("Search criteria updated");
        UpdateInventoryBasedOnSearch();
    }

    // Private method for sending email
    private void SendEmail(string content)
    {
        // Email sending logic (unrelated to search filters)
        isEmailSent = true;
        Console.WriteLine($"Email sent: {content}");
    }

    // Private method for updating inventory (irrelevant to search filters)
    private void UpdateInventoryBasedOnSearch()
    {
        // Inventory update logic based on search criteria
        inventoryUpdateCount++;
        Console.WriteLine($"Inventory updated based on search. Update count: {inventoryUpdateCount}");
    }

    // Private method for calculating tax (should be in a separate finance-related class)
    private decimal CalculateTax(decimal price)
    {
        return price * taxRate;
    }

    // Expose private state for demonstration (violates encapsulation)
    public void DisplayInternalState()
    {
        Console.WriteLine($"Genre: {genre}, Author: {author}, MinPrice: {minPrice}, MaxPrice: {maxPrice}");
        Console.WriteLine($"Tax Rate: {taxRate}, Is Email Sent: {isEmailSent}, Inventory Updates: {inventoryUpdateCount}");
    }
}