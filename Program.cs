using Budget.BankIntegrations.Monzo;
using Budget.BankIntegrations.Lloyds;
using Budget.Internal.Entities;
using Budget.Internal.Services;

MonzoParser monzoParser = new();
LloydsParser lloydsParser = new();

IEnumerable<TransactionRecord> monzoTransactions = monzoParser.Init();
foreach (TransactionRecord payment in monzoTransactions)
{
    TransactionRecordService.ApplyCategory(payment);
    Console.WriteLine($"{payment.TransactionDate} {payment.Description} {payment.Amount} {payment.Category}");
}

// IEnumerable<TransactionRecord> lloydsTransactions = lloydsParser.Init();
// foreach (TransactionRecord payment in lloydsTransactions)
// {
//     TransactionRecordService.ApplyCategory(payment);
//     Console.WriteLine($"{payment.TransactionDate} {payment.Description} {payment.Amount} {payment.Category}");
// }