using Day13HexArchExercise.Models;

namespace Day13HexArchExercise.Secondary.Interfaces;

public interface IInfoRequester
{
    public Customer GetCustomerById(int customerId);
}
