using Budget.Banks.Monzo;
using Budget.Internal.Entities;
using Budget.Internal.Services;

MonzoParser parser = new();

parser.SetStatement("test.csv");
List<TransactionRecord> monzoTransactions = parser.Parse();

Console.WriteLine($"Found {monzoTransactions.Count} payments");

foreach (TransactionRecord payment in monzoTransactions)
{
    TransactionRecordService.ApplyCategory(payment);
    Console.WriteLine($"{payment.TransactionDate} {payment.Description} {payment.Amount} {payment.Category}");
}