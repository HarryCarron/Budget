using Budget;

namespace Monzo
{
    public class MonzoMapper
    {
        public static TransactionRecord ToTransactionRecord(MonzoPayment payment)
        {
            string dateTimeStr = $"{payment.Date} {payment.Time}";
            DateTime dateTime = DateTime.Parse(dateTimeStr);
            return new TransactionRecord
            {
                TransactionDate = dateTime,
                Description = payment.Name!,
                Amount = decimal.Parse(payment.Amount!)
            };
        }
    }
}