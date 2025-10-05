
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper;

namespace Monzo
{
    public class MonzoParser
    {
        private string _statementCsv { get; set; } = String.Empty;
        public void SetStatement(string statement)
        {
            _statementCsv = statement;
        }

        public List<MonzoPayment> Parse()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };

            var reader = new StreamReader(_statementCsv);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<MonzoPayment>();

            return [.. records];
        }
    }
}