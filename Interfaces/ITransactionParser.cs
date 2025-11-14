using Budget.Internal.Entities;

namespace Budget.Interfaces
{
    public interface ITransactionParser<T>
    {
        IEnumerable<TransactionRecord> Parse(T transactions);

        void SetStatementPath(string statementPath);

    }
}

