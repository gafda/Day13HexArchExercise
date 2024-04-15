using Day13HexArchExercise.Models;

namespace Day13HexArchExercise.Secondary.Interfaces;

public interface ICreditRepository
{
    public bool AddCredit(int customerId, Credit credit);
    public Credit GetCredit(int customerId, int creditInformationId);
    public ICollection<Credit> GetCredits(int customerId);
}
