using System.Collections.Generic;

namespace DustInTheWind.WindowsApi.Core
{
    public class DataSizeFormatOptions
    {
        public string Template { get; set; }

        public List<DataSizeUnit> Values { get; set; }
    }
}