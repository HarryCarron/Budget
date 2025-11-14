using Budget.Internal.Entities;


namespace Budget.Interfaces
{
    public interface ITransactionMapper<T>
    {
        public TransactionRecord ToTransactionRecord(T transaction);
    }
}