using Day13HexArchExercise.Models;

namespace Day13HexArchExercise.Primary.Interfaces;

public interface IPortabilityController
{
    public void SendRequestedPortability(PortabilityInfo info);
}
