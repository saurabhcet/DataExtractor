using DataExtractor.Interface;
using System;
using System.Linq;

namespace DataExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {  
                //Parsing confguration
                var appConfig = new AppConfig(args);

                //Generic reader to parse raw CSV file - known format
                var records = new CSVReader(appConfig).Read(new Model.Input.TradeScrip());

                //Transforming data
                ITransformableWorkList workItem = new TransformableWorkList(records.ToList());
                var transformer = new ComplexTransformer();
                transformer.Transform(workItem);

                //Generic writer to bcp out records to a new CSV file - known format
                new CSVWriter(appConfig).Write(workItem.TransformedTrades);         

                Console.WriteLine("File processing completed succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine($"File processing not completed succesfully, Error:{e.Message}");
            }            
        }
    }  
}