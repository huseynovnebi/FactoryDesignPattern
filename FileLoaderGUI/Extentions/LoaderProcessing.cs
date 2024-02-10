using FileLoaderGUI.Loaders;
using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using static FileLoaderGUI.Extentions.FileType;

namespace FileLoaderGUI.Extentions
{
    public static class LoaderProcessing
    {
        public static async Task GetLoader(FileTypeEnum fileType,string content,DataGrid datagrid)
        {
            switch (fileType)
            {
                case FileTypeEnum.txt:
                    await TxtLoader.LoadContent(content, datagrid);
                    break;
                case FileTypeEnum.csv:
                    await CsvLoader.LoadContent(content,datagrid);
                    break;
                case FileTypeEnum.xml:
                     XmlLoader.LoadContent(content,datagrid);
                    break;
                default:
                    break;
            }
        }
    }
}
