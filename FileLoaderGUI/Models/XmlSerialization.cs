using System;
using System.Text;
using System.Xml.Serialization;

namespace FileLoaderGUI.Models
{
    public class XmlSerialization
    {
        [XmlRoot("values")]
        public partial class Values
        {
            [XmlElement("value")]
            public Value[] value { get; set; }

        }

        public partial class Value
        {
            [XmlAttribute("date")]
            public string Date { get; set; }

            [XmlAttribute("open")]
            public double Open { get; set; }

            [XmlAttribute("high")]
            public double High { get; set; }

            [XmlAttribute("low")]
            public double Low { get; set; }

            [XmlAttribute("close")]
            public double Close { get; set; }

            [XmlAttribute("volume")]
            public int Volume { get; set; }
        }

    }
}
