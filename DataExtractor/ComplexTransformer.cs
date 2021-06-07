using DataExtractor.Interface;
using System.Collections.Generic;

namespace DataExtractor
{
    public class ComplexTransformer : TransformerBase
    {
        public override void Transform(ITransformableWorkList workItem)
        {
            var outputTrades = workItem.TransformedTrades;

            foreach (var trade in workItem.InputTrades)
            {
                outputTrades.Add(
                    new Model.Output.TradeScrip
                    {
                        ISIN = trade.ISIN,
                        Currency = trade.Currency,
                        Venue = trade.Venue,
                        ContractSize = base.ParsePriceMultiplier(trade.AlgoParams)
                    });
            }
        }

    }
};