
using System.Globalization;
using CsvHelper;
using Budget.Interfaces;
using Budget.Internal.Entities;
using CsvHelper.Configuration;

namespace Budget.Base
{
    public abstract class BaseParser<T, P> where P: class, ITransactionMapper<T>
    {
        private P? _mapper;

        public void SetMapper(P mapper)
        {
            _mapper = mapper;
        }

        public abstract IEnumerable<TransactionRecord> Init();

        public IEnumerable<TransactionRecord> Parse(string statementPath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };
            var items = _ExtractRecordsFromCsv(statementPath);
            return _Map(items);
        }

        private List<TransactionRecord> _Map(IEnumerable<T> items)
        {
            var output = new List<TransactionRecord>();

            foreach (var record in items)
            {
                output.Add(
                    _mapper!.ToTransactionRecord(record)
                );
            }

            return output;
        }

        private IEnumerable<T> _ExtractRecordsFromCsv(string statementPath)
        {
            var reader = new StreamReader(statementPath);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            return csv.GetRecords<T>();
        }


    }
}