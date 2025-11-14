using Budget.Base;
using Budget.Internal.Entities;

namespace Budget.BankIntegrations.Lloyds
{
    public class LloydsParser: BaseParser<LloydsTransaction, LloydsMapper>
    {
        public override IEnumerable<TransactionRecord> Init()
        {
            SetMapper(new LloydsMapper());
            return Parse("test2.csv");
        }
    }
}
