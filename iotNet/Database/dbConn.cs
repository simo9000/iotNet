using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ACN.Database
{
    public class dbConn : IDisposable
    {
        // members
        private SqlConnection conn;
        
        // constructor
        public dbConn(){
            string connString = ConfigurationManager.ConnectionStrings["ACN"].ConnectionString;
            string password = ConfigurationManager.AppSettings["dbPassword"];
            connString = connString.Replace("{password}", password);
            conn = new SqlConnection(connString);
            conn.Open();
        }
        
        // public functions
        public string[] getAreaList()
        {
            string sqlString = "SELECT fdName as area FROM tblArea";
            DataTable results = query(sqlString);
            return results.Rows.Cast<DataRow>().Select(row => (string)row["area"]).ToArray();
        }

        public DataTable getSensorTable(string area)
        {
            string sqlString = "SELECT * FROM vwSensorRT WHERE areaName='{area}'";
            sqlString = sqlString.Replace("{area}", area);
            DataTable results = query(sqlString);
            return results;
        }

        // private helper functions
        private DataTable query(string sqlString)
        {
            DataTable returnVal = new DataTable();
            SqlCommand command = new SqlCommand(sqlString, conn);
            returnVal.Load(command.ExecuteReader());
            return returnVal;
        }

        // Interface implementations
        public void Dispose()
        {
            conn.Close();
        }
    }
}