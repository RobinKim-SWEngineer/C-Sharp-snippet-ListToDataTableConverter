using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ListToDataTableConverter
{
    static class FormatChanger
    {
        public static DataTable ConvertToDataTable<T>(List<T> listOfObjects)
        {
            DataTable dataTable = new DataTable();

            MakeTitleRow(dataTable, listOfObjects);

            MakeDataRows(dataTable, listOfObjects);

            return dataTable;
        }

        private static void MakeTitleRow<T>(DataTable dataTable, List<T> listOfObjects)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                dataTable.Columns.Add(property.Name);
            }
        }

        private static void MakeDataRows<T>(DataTable dataTable, List<T> listOfObjects)
        {
            foreach (object obj in listOfObjects)
            {
                DataRow row = dataTable.NewRow();
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    object propertyValue = obj.GetType().GetProperty(property.Name).GetValue(obj);
                    row[property.Name] = propertyValue;
                }
                dataTable.Rows.Add(row);
            }
        }
    }
}
