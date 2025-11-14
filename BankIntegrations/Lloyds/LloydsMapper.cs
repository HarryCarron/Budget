using Budget.Interfaces;
using Budget.Internal.Entities;

namespace Budget.BankIntegrations.Lloyds
{
    public class LloydsMapper: ITransactionMapper<LloydsTransaction>
    {
        public TransactionRecord ToTransactionRecord(LloydsTransaction transaction)
        {
            DateTime dateTime = DateTime.Parse(transaction.TransactionDate);

            decimal.TryParse(transaction.DebitAmount, out decimal debit);
            decimal.TryParse(transaction.CreditAmount, out decimal credit);
            debit = -debit;

            decimal amount = credit != 0 ? credit : debit;
            return new TransactionRecord
            {
                TransactionDate = dateTime,
                Description = transaction.TransactionDescription,
                Amount = amount
            };
        }
    }
}