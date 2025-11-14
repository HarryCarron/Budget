namespace Budget.BankIntegrations.Lloyds
{
    public class LloydsTransaction
    {
        public required string TransactionDate = "";

        public required string TransactionType = "";

        public required string AccountNumber = "";

        public required string SortCode = "";

        public required string TransactionDescription = "";

        public required string DebitAmount = "";

        public required string CreditAmount = "";

        public required string Balance = "";
    }
}