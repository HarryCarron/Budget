using Budget.Internal.Entities;
using Budget.Interfaces;

namespace Budget.BankIntegrations.Monzo
{
    public class MonzoMapper: ITransactionMapper<MonzoTransaction>
    {
        public TransactionRecord ToTransactionRecord(MonzoTransaction transaction)
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