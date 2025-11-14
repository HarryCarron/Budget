using Budget.Internal.Entities;
using Budget.Base;


namespace Budget.BankIntegrations.Monzo
{
    public class MonzoParser : BaseParser<MonzoTransaction, MonzoMapper>
    {
        public override IEnumerable<TransactionRecord> Init()
        {
            SetMapper(new MonzoMapper());
            return Parse("test.csv");
        }
    } 
}