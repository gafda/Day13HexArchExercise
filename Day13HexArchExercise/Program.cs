using Day13HexArchExercise.Core;
using Day13HexArchExercise.Models;
using Day13HexArchExercise.Secondary.Adapters;
using Day13HexArchExercise.Secondary.Interfaces;

// External / NoSql
{
    ICreditRepository creditRepository = new NoSqlCreditRepository();
    IInfoRequester infoRequester = new ExternalInfoRequester();

    Execute(creditRepository, infoRequester, 1);
}

Console.WriteLine($"\n{new string('=', 80)}\n");

// Internal / Sql
{
    ICreditRepository creditRepository = new SqlCreditRepository();
    IInfoRequester infoRequester = new InternalInfoRequester();

    Execute(creditRepository, infoRequester, 2);
}

static void Execute(ICreditRepository creditRepository, IInfoRequester infoRequester, int customerId)
{
    const decimal CreditAmount = 5000;

    var manager = new CreditManager(creditRepository, infoRequester);

    ShowCredits(manager, customerId);

    var hasEnoughCredit = manager.CheckCredit(customerId, CreditAmount);
    if(hasEnoughCredit)
    {
        Console.WriteLine($"\nCustomer {customerId} has enought credit for {CreditAmount} more.");

        var portabilityInfo = new PortabilityInfo(customerId, []);
        portabilityInfo.Credits.Add(new Credit(10, customerId, customerId * 1000));
        manager.AddPortabilityInfo(portabilityInfo);
    }
    else
    {
        Console.WriteLine($"\nCustomer {customerId} does not have enough credit for {CreditAmount} more.");
    }

    ShowCredits(manager, customerId);
}

static void ShowCredits(CreditManager manager, int customerId)
{
    var customerCredits = manager.GetCreditsByCustomerId(customerId);
    Console.WriteLine($"List current credits of customer: {customerId}");
    foreach (var credit in customerCredits)
    {
        Console.WriteLine($"\tCredit id:{credit.Id} with {credit.Amount} $");
    }
}