namespace ProgrammingCoaching.SOLID.Examples.Credit.Data.Models
{
    /// <summary>
    /// Represents a user's external model with personal information.
    /// </summary>
    public class UserExternalModel
    {
        /// <summary>
        /// Gets or sets the National Identification Number (e.g., SSN) of the user.
        /// </summary>
        public string NationalIdentificationId { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the user's full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user's address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the user's contact details, which may include email, phone number, etc.
        /// </summary>
        public string ContactDetails { get; set; }
    }

}