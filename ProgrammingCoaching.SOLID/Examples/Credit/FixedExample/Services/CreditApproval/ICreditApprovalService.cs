using ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Models;

namespace ProgrammingCoaching.SOLID.Examples.Credit.FixedExample.Services.CreditApproval
{
    public interface ICreditApprovalService
    {
        bool CanCreditBeGiven(CreditApplicationModel creditApplicationModel);
    }
}