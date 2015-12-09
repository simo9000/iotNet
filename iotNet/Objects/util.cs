using System;
using System.Data;

namespace ACN.Objects
{
    public static class util
    {
        public static bool hasColumn(this DataRow row, string columnName)
        {
            return row.Table.Columns.Contains(columnName);
        }

        public static bool isNull(this DataRow row, string columnName)
        {
            return row[columnName] == DBNull.Value;
        }

        public static double getValue(this DataRow row, string columnName, double _default = -1)
        {
            return row.hasColumn(columnName) && !row.isNull(columnName) ? (float)row[columnName] : _default;
        }
    }
}