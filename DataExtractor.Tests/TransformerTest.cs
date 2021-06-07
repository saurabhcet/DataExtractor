using Xunit;
using System.Linq;
using System.Collections.Generic;
using DataExtractor.Interface;

namespace DataExtractor.Tests
{
    public class TransformerTest
    {
        [Fact]
        public void TransformerExpectsOutListWhenInputListIsProvided()
        {
            var trade = new Model.Input.TradeScrip { ISIN = "12345", AlgoParams = "Dummy" };
            var trades = new List<Model.Input.TradeScrip> { trade };

            //Transforming complex attributes
            ITransformableWorkList workItem = new TransformableWorkList(trades);
            var transformer = new ComplexTransformer();
            transformer.Transform(workItem);

            Assert.Equal(workItem.InputTrades.Count, workItem.TransformedTrades.Count);
            Assert.True(workItem.TransformedTrades.Any());

            var result = workItem.TransformedTrades.Where(x=> x.ISIN == trade.ISIN).FirstOrDefault();
            Assert.Equal(result.ISIN, trade.ISIN);
        }
    }
}
