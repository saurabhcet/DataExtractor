using DataExtractor.Interface;
using System.Collections.Generic;

namespace DataExtractor
{
    public class TransformableWorkList : ITransformableWorkList
    {
        public TransformableWorkList(List<Model.Input.TradeScrip> inputList)
        {
            InputTrades = inputList;
            TransformedTrades = new List<Model.Output.TradeScrip>();
        }

        public List<Model.Input.TradeScrip> InputTrades { get; set; }
        public List<Model.Output.TradeScrip> TransformedTrades { get; set; }
    }
}
