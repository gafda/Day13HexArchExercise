using Day13HexArchExercise.Core;
using Day13HexArchExercise.Models;
using Day13HexArchExercise.Primary.Interfaces;

namespace Day13HexArchExercise.Primary.Adapters;

public class RestApiController : ICreditController
{
    private readonly CreditManager _creditManager;

    public RestApiController(CreditManager creditManager)
    {
        _creditManager = creditManager;
    }

    public bool CheckCredit(int customerId, decimal creditAmount)
    {
        return _creditManager.CheckCredit(customerId, creditAmount);
    }

    public ICollection<Credit> GetCredits(int customerId)
    {
        return _creditManager.GetCreditsByCustomerId(customerId);
    }
}
