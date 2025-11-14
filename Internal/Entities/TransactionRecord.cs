
using Budget.Internal.Enums;
namespace Budget.Internal.Entities
{
    public class TransactionRecord
    {
        public required DateTime TransactionDate;
        public required string Description;
        public required decimal Amount;
        public Categories Category { get; set; } = Categories.Uncategorised;
    }

}