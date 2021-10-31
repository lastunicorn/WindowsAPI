using System.Collections.Generic;

namespace DustInTheWind.WindowsApi
{
    public class DataSizeFormatOptions
    {
        public string Template { get; set; }

        public List<DataSizeUnit> Values { get; set; }
    }
}