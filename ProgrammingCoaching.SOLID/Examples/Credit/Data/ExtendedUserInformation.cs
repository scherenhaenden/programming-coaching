using ProgrammingCoaching.SOLID.Examples.Credit.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class ExtendedUserInformation
{
    public RegisteredUserInternalModel? RegisteredUser { get; set; }
    public UserExternalModel? User { get; set; }
    public CreditRatingUserExternalModel? CreditRatingUserExternals { get; set; }
}