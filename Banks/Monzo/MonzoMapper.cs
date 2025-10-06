using Budget.Internal.Entities;

namespace Budget.Banks.Monzo
{
    public class MonzoMapper
    {
        public static TransactionRecord ToTransactionRecord(MonzoTransaction transaction)
        {
            string dateTimeStr = $"{transaction.Date} {transaction.Time}";
            DateTime dateTime = DateTime.Parse(dateTimeStr);
            return new TransactionRecord
            {
                TransactionDate = dateTime,
                Description = transaction.Name!,
                Amount = decimal.Parse(transaction.Amount!)
            };
        }
    }
}