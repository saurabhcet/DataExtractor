using CsvHelper;
using DataExtractor.Interface;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DataExtractor
{
    public class CSVWriter : ICSVWriter
    {
        private readonly AppConfig appConfig;
        public CSVWriter(AppConfig appConfig)
        {
            this.appConfig = appConfig;
        }

        public void Write<T>(IEnumerable<T> records)
        {
            using (var writer = new StreamWriter(appConfig.OutputFileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<T>();
                csv.NextRecord();
                foreach (var record in records)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
        }
    }
}
