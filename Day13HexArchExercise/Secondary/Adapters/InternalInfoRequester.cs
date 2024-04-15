using Day13HexArchExercise.Models;
using Day13HexArchExercise.Secondary.Interfaces;

namespace Day13HexArchExercise.Secondary.Adapters;

public class InternalInfoRequester : IInfoRequester
{
    private readonly ICollection<Customer> _customers;

    public InternalInfoRequester()
    {
        _customers = Enumerable.Range(1, 9)
            .Select(idx => new Customer(idx, idx % 2 == 0, [idx]))
            .ToArray();
    }

    public Customer GetCustomerById(int customerId)
    {
        return _customers
            .FirstOrDefault(customer => customer.Id == customerId) ?? Customer.Empty;
    }
}
