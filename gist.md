# Milestone - Implementation of Primary Ports

## ICreditController.cs

> Credit listing and be able to check if customer have enough for a given amount.

```csharp
namespace Day13HexArchExercise.Primary.Interfaces;

public interface ICreditController
{
    public ICollection<Credit> GetCredits(int customerId);
    public bool CheckCredit(int customerId, decimal creditAmount);
}
```

## IPortabilityController.cs

> For portability credit requests from an individual or an external financial entity.

```csharp
namespace Day13HexArchExercise.Primary.Interfaces;

public interface IPortabilityController
{
    public void SendRequestedPortability(PortabilityInfo info);
}
```
