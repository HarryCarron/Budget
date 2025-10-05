using Monzo;

MonzoParser parser = new();

parser.SetStatement("test.csv");
List<MonzoPayment> monzoPayments = parser.Parse();

Console.WriteLine($"Found {monzoPayments.Count} payments");

foreach (MonzoPayment payment in monzoPayments)
{
    Console.WriteLine($"{payment.Date} {payment.Time} {payment.Name} {payment.Amount}");
}