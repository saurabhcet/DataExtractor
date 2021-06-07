using System.Collections.Generic;

namespace DataExtractor.Interface
{
    public interface ICSVReader
    {
        IEnumerable<T> Read<T>(T obj);
    }
}
