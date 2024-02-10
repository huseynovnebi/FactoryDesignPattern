using CsvHelper;
using FileLoaderGUI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FileLoaderGUI.Loaders
{
    public static class CsvLoader
    {
        public static async Task LoadContent(string content,DataGrid datagrid)
        {
          
            List<CsvSerialization> CsvRowList = await ParseCsvContent(content);

            foreach (CsvSerialization CsvRow in CsvRowList)
            {
                datagrid.Items.Add(CsvRow);
            }
        }

        public static async Task<List<CsvSerialization>> ParseCsvContent(string csvContent)
        {
            List<CsvSerialization> CsvRowList = new List<CsvSerialization>();

            using (var reader = new StringReader(csvContent))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                CsvRowList = await csv.GetRecordsAsync<CsvSerialization>().ToListAsync();
            }

            return CsvRowList;
        }


       
    }
}
