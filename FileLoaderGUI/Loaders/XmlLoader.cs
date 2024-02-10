using FileLoaderGUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;
using static FileLoaderGUI.Models.XmlSerialization;

namespace FileLoaderGUI.Loaders
{
    public static class XmlLoader
    {
        public static void LoadContent(string content,DataGrid dataGrid)
        {
            Values values;
            using (StringReader stringReader = new StringReader(content))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Values), new XmlRootAttribute("values"));
                values = (Values)serializer.Deserialize(stringReader);
            }
            foreach (Value value in values.value)
            {
                dataGrid.Items.Add(value);
            }
            
        }
    }
}
