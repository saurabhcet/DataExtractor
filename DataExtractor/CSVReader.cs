using CsvHelper;
using DataExtractor.Interface;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DataExtractor
{
    public class CSVReader : ICSVReader
    {
        private readonly AppConfig appConfig;
        public CSVReader(AppConfig appConfig)
        {
            this.appConfig = appConfig;
        }       

        public IEnumerable<T> Read<T>(T obj)
        {
            using var reader = new StreamReader(appConfig.InputFileName);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.EnumerateRecords(obj);
            
            return records.ToList();
        }
    }
}
