namespace ProgrammingCoaching.SOLID.Examples.Credit.Data
{
    /// <summary>
    /// Represents a registered user with their personal and account information.
    /// </summary>
    public class RegisteredUser
    {
        /// <summary>
        /// Gets or sets the National Identification Number (e.g., SSN) of the user.
        /// </summary>
        public string NationalIdentificationId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the user's account.
        /// </summary>
        public string? AccountNumber { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the internal credit rating of the user on a scale of 1 to 1000.
        /// </summary>
        public double InternalCreditRating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is blacklisted.
        /// </summary>
        public bool IsBlackListed { get; set; }
    }

}


