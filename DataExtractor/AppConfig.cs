using System;
using System.IO;

namespace DataExtractor
{
    public class AppConfig
    {
       public AppConfig(string[] args)
       {
            Validation(args);
            FileInfo fileInfo = new(args[0]);
            InputFileName = args[0];
            OutputFileName = $"{fileInfo.Name.Split(".")[0]}_Output{fileInfo.Extension}";
       }       

        public string InputFileName { get; private set; }
        public string OutputFileName { get; private set; }

        private void Validation(string[] args)
        {
            if (args.Length == 0)
                throw new Exception("File Name parameter is missing");

            if (!File.Exists(args[0]))
                throw new Exception("File is missing in the given location");
        }
    }
}
