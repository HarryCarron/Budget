using Budget.Banks.Monzo;
using Budget.Entities;

MonzoParser parser = new();

parser.SetStatement("test.csv");
List<TransactionRecord> monzoTransactions = parser.Parse();

Console.WriteLine($"Found {monzoTransactions.Count} payments");

foreach (TransactionRecord payment in monzoTransactions)
{
    Console.WriteLine($"{payment.TransactionDate} {payment.Description} {payment.Amount}");
}