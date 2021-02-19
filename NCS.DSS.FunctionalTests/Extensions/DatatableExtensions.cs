using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace NCS.DSS.FunctionalTests.Extensions
{
    public static class DatatableExtensions
    {
        public static List<object> AsListOfObjects(this DataTable dataTable)
        {
            var lst = new List<object>();
            foreach (DataRow row in dataTable.Rows)
            {
                var sqlRowTable = new ExpandoObject() as IDictionary<string, object>;
                foreach (DataColumn column in dataTable.Columns)
                {
                    sqlRowTable.Add(column.ColumnName, row[column].ToString());
                }
                lst.Add(sqlRowTable);
            }
            return lst;
        }
    }
}
