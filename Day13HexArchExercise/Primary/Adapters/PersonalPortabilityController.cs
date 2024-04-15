using Day13HexArchExercise.Core;
using Day13HexArchExercise.Models;
using Day13HexArchExercise.Primary.Interfaces;

namespace Day13HexArchExercise.Primary.Adapters;

public class PersonalPortabilityController : IPortabilityController
{
    private readonly CreditManager _creditManager;

    public PersonalPortabilityController(CreditManager creditManager)
    {
        _creditManager = creditManager;
    }

    public void SendRequestedPortability(PortabilityInfo info)
    {
        _creditManager.AddPortabilityInfo(info);
    }
}
