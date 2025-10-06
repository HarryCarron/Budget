
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper;
using Budget.Entities;


namespace Budget.Banks.Monzo
{
    public class MonzoParser
    {
        private string StatementCsv { get; set; } = string.Empty;
        public void SetStatement(string statement)
        {
            StatementCsv = statement;
        }

        public List<TransactionRecord> Parse()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };

            var reader = new StreamReader(StatementCsv);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<MonzoTransaction>();

            var output = new List<TransactionRecord>();

            foreach (var record in records)
            {
                output.Add(
                    MonzoMapper.ToTransactionRecord(record)
                );
            }

            return output;
        }
    }
}