using Day13HexArchExercise.Models;

namespace Day13HexArchExercise.Primary.Interfaces;

public interface ICreditController
{
    public ICollection<Credit> GetCredits(int customerId);
    public bool CheckCredit(int customerId, decimal creditAmount);
}
