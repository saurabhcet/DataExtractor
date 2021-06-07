using System.Linq;
using Xunit;

namespace DataExtractor.Tests
{
    public class CSVReaderTest
    {
        [Fact]
        public void CSVReaderIsReadingWhenValidCSVFile()
        {
            var appConfig = new AppConfig(AppSettingFixture.DefaultSettings);

            var reader = new CSVReader(appConfig);
            var output = reader.Read(new Model.Input.TradeScrip());

            Assert.True(output.Any());
        }
    }
}