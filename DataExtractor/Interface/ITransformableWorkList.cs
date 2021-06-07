using System.Collections.Generic;

namespace DataExtractor.Interface
{
    public interface ITransformableWorkList
    {
        List<Model.Input.TradeScrip> InputTrades { get; set; }

        List<Model.Output.TradeScrip> TransformedTrades { get; set; }
    }
}