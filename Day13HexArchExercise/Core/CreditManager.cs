using Day13HexArchExercise.Models;
using Day13HexArchExercise.Secondary.Interfaces;

namespace Day13HexArchExercise.Core;

public class CreditManager
{
    private readonly ICreditRepository _creditRepository;
    private readonly IInfoRequester _infoRequester;

    public CreditManager(ICreditRepository creditRepository, IInfoRequester infoRequester)
    {
        _creditRepository = creditRepository;
        _infoRequester = infoRequester;
    }

    public bool CheckCredit(int customerId, decimal amount)
    {
        var customerInfo = _infoRequester.GetCustomerById(customerId);
        var totalCreditAmount = customerInfo.Credits
            .Select(creditId => _creditRepository.GetCredit(customerId, creditId))
            .Sum(credit => credit.Amount);

        return (totalCreditAmount + amount) < 5000 || customerInfo.IsVip;
    }

    public ICollection<Credit> GetCreditsByCustomerId(int customerId)
    {
        return _creditRepository.GetCredits(customerId);
    }

    public Credit GetCreditByCustomerId(int customerId, int creditInformationId)
    {
        return _creditRepository.GetCredit(customerId, creditInformationId);
    }

    internal void AddPortabilityInfo(PortabilityInfo info)
    {
        var customer = _infoRequester.GetCustomerById(info.CustomerId);

        if (customer.Id < 0)
        {
            return;
        }

        Console.WriteLine($"Customer: {customer.Id}");
        foreach (var credit in info.Credits)
        {
            var result = _creditRepository.AddCredit(info.CustomerId, credit);

            Console.WriteLine($"\t- Added credit {credit.Id} with {credit.Amount} $ from portability info? {(result ? "Yes" : "No")}");
        }
    }
}
