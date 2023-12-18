namespace ProgrammingCoaching.SOLID.Examples.Credit.Data
{
    public class User
    {
        public string NationalIdentificationID { get; set; } = new Guid().ToString();// National identification number (e.g., SSN) 
    
        public string Name { get; set; } // User's full name
        public string Address { get; set; } // User's address
        public string ContactDetails { get; set; } // User's contact details (email, phone, etc.)
    
    
    
    }

    public class BlackListedExternalUser
    {
        public bool blackListed { get; set; }
        public string NationalIdentificationID { get; set; } // National identification number (e.g., SSN)
    }
}