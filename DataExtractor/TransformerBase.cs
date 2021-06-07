using DataExtractor.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DataExtractor
{
    public abstract class TransformerBase
    {
        const char COLON = ':';
        const char SEMI_COLON = ';';
        const char VERTICAL_BAR = '|';

        //Define complex attributes
        const string PRICE_MULTIPLIER = "PriceMultiplier";

        public abstract void Transform(ITransformableWorkList list);

        internal string ParsePriceMultiplier(string parameters)
        {
            var priceMultiplier = parameters.Split(SEMI_COLON).Where(x => x.Contains(PRICE_MULTIPLIER)).FirstOrDefault();
            var value = priceMultiplier?.TrimEnd(VERTICAL_BAR).Split(COLON);

            return value?[1];
        }
    }
}