using Budget.Internal.Entities;
using Budget.Internal.Enums;

namespace Budget.Internal.Services
{
    public class TransactionRecordService
    {
        
        public static void ApplyCategory(TransactionRecord record)
        {
            var categoryRules = new Dictionary<string, Categories>(StringComparer.OrdinalIgnoreCase)
            {
                { "TESCO", Categories.Groceries },
                { "MCDONALD", Categories.EatingOut },
                { "UBER", Categories.Transportation },
                { "TFL", Categories.Transportation },
                { "EDF", Categories.Utilities },
                { "NETFLIX", Categories.Entertainment },
                { "SALARY", Categories.Income },
                { 
                    "Transport for London", Categories.Transportation
                }
            };

            foreach (var rule in categoryRules)
            {
                if (record.Description.Contains(rule.Key, StringComparison.OrdinalIgnoreCase))
                {
                    record.Category = rule.Value;
                }
            }
        }
    }
}

