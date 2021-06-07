using System.Collections.Generic;

namespace DataExtractor.Interface
{
    public interface ICSVWriter
    {
        void Write<T>(IEnumerable<T> records);
    }
}
