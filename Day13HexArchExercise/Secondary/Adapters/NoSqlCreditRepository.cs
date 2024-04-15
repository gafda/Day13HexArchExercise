using Day13HexArchExercise.Models;
using Day13HexArchExercise.Secondary.Interfaces;

namespace Day13HexArchExercise.Secondary.Adapters;

public class NoSqlCreditRepository : ICreditRepository
{
    private ICollection<Credit> _credits;

    public NoSqlCreditRepository()
    {
        _credits = Enumerable.Range(1, 9)
            .Select(i => new Credit(i, i, i * 1000))
            .ToList();
    }

    public bool AddCredit(int customerId, Credit credit)
    {
        var existsCredit = _credits
            .FirstOrDefault(c => c.CustomerId == customerId && c.Id == credit.Id);

        if (existsCredit is null)
        {
            _credits.Add(credit);

            return true;
        }

        return false;
    }

    public Credit GetCredit(int customerId, int creditId)
    {
        return _credits
            .FirstOrDefault(credit => credit.CustomerId == customerId && credit.Id == creditId) ?? Credit.Empty;
    }

    public ICollection<Credit> GetCredits(int customerId)
    {
        return _credits
            .Where(credit => credit.CustomerId == customerId)
            .ToArray();
    }
}
