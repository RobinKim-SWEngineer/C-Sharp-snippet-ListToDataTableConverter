using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToDataTableConverter.Worker
{
    static class Launcher
    {
        public static void PrintDataTable(DataTable dataTable)
        {
            PrintTitleRow(dataTable);

            PrintDataRows(dataTable);
        }

        private static void PrintTitleRow(DataTable dataTable)
        {
            Console.WriteLine("\n\n** Column names :\n");
            foreach (DataColumn column in dataTable.Columns)
            {
                Console.WriteLine($"   {column.ColumnName}");
            }
        }

        private static void PrintDataRows(DataTable dataTable)
        {
            Console.WriteLine("\n** Row values :\n");
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine($"   {row[column.ColumnName]}"); 
                }
                Console.WriteLine("\n   -----------\n");
            }
        }
    }
}
