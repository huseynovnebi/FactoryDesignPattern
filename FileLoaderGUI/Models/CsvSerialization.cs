using System;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace FileLoaderGUI.Models
{
    public class CsvSerialization
    {
        [Index(0)]
        public string Date { get; set; }
        [Index(1)]
        public string Open { get; set; }
        [Index(2)]
        public string High { get; set; }
        [Index(3)]
        public string Low { get; set; }
        [Index(4)]
        public string Close { get; set; }
        [Index(5)]
        public string Volume { get; set; }
    }
}
