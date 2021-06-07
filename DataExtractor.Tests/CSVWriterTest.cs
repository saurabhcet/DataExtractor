using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;
using DataExtractor.Interface;

namespace DataExtractor.Tests
{
    public class CSVWriterTest
    {
        [Fact]
        public void CSVWriterIsWritingWhenValidDataExists()
        {            
            var trades = new List<Model.Output.TradeScrip>();

            var mockWriter = new Mock<ICSVWriter>();
            mockWriter.Setup(x => x.Write(trades));            

            mockWriter.Verify(x => x.Write(It.Is<IEnumerable<Model.Output.TradeScrip>>(v => v.Equals(trades))), Times.AtMostOnce);
            mockWriter.VerifyNoOtherCalls();
        }
    }
}