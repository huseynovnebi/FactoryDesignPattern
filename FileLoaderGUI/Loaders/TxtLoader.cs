using FileLoaderGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FileLoaderGUI.Loaders
{
    public static class TxtLoader
    {
        public static async Task LoadContent(string content,DataGrid datagrid)
        {
            List<TxtSerialization> TxtRowList = await ParseTxtContent(content);

            foreach (TxtSerialization TxtRow in TxtRowList)
            {
                datagrid.Items.Add(TxtRow);   
            }
        }

        public static Task<List<TxtSerialization>> ParseTxtContent(string txtContent)
        {
            List<TxtSerialization> TxtRowList = new List<TxtSerialization>();

            string[] lines = txtContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(';');

                if (values.Length >= 6) 
                {
                    TxtSerialization TxtRow = new TxtSerialization
                    {
                        Date = values[0],
                        Open = values[1],
                        High = values[2],
                        Low = values[3],
                        Close = values[4],
                        Volume = values[5]
                    };
                    TxtRowList.Add(TxtRow);
                }

            }

            return Task.FromResult(TxtRowList);
        }
    }
}
