namespace Budget.Entities
{
    public class TransactionRecord
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0;
    }

}