using ProgrammingCoaching.SOLID.Examples.Credit.Data;
using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval;

public interface ICreditService
{
    bool CanGetCreditByRatingCalculation(CreditApplicationModel creditApplicationModel, ExtendedUserInformation extendedUserInformation);
}