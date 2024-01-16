namespace ProgrammingCoaching.SOLID.Examples.Credit.Data.Models
{
    /// <summary>
    /// Represents external user credit rating information, including the national identification number (e.g., SSN), credit rating, and blacklisting status.
    /// </summary>
    public class CreditRatingUserExternalModel
    {
        /// <summary>
        /// Gets or sets the National Identification Number (e.g., SSN) of the user.
        /// </summary>
        public string NationalIdentificationId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user's credit rating on a scale of 1 to 1000.
        /// </summary>
        public double CreditRating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is blacklisted.
        /// </summary>
        public bool IsBlackListed { get; set; }
    }

}