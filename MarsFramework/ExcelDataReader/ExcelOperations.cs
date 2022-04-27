/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using System.Data;
using System;

namespace MarsFramework.ExcelDataReader
{
    public class ExcelOperations
    {
        //reads the data as excel and return the data as tables.
        public static DataTable ExcelToDataTable(FileStream stream, string sheetName)
        {
            //open file and returns as stream
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //createopenxmlreader via ExcelReaderFactory
            //createopenxmlreader reads the .xlsx files
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            // set the first row as column name
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            // excelReader.IsFirstRowAsColumnNames = true;
            //return as data set
            //DataSet result1= excelReader.AsDataSet();
            //get all the tables
            DataTableCollection table = result.Tables;
            //store it is data table.
            DataTable resultTable = table[sheetName];
            //return
            return resultTable;
        }
        public static void ReadDataTable(FileStream stream, string sheetName)
        {
            Console.WriteLine("Sheet:" + sheetName);
            DataTable table = ExcelToDataTable(stream, sheetName);
            //totalRowCount =table.Rows.Count;
            //Iterate through the rows and columns of the Table
            for (int row = 0; row < table.Rows.Count; row++)
            {
                Console.WriteLine("Row Number is " + (row + 1));
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Console.WriteLine("Column:" + table.Columns[col].ColumnName +
                      " |Value:" + table.Rows[row][col].ToString());
                }
            }
        }
    }
}*/
