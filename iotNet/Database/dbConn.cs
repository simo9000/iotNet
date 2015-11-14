using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iotNet.Database
{
    public class dbConn : IDisposable
    {
        // members
        private string connString;
        private SqlConnection conn;
        
        // constructor
        public dbConn(){
            connString = ConfigurationManager.ConnectionStrings["ACN"].ConnectionString;
            string password = ConfigurationManager.AppSettings["dbPassword"];
            conn = new SqlConnection(connString);
            conn.Open();
        }
        
        // public functions
        public string[] getAreaList()
        {
            return null;
        }

        // private helper functions


        // Interface implementations

        public void Dispose()
        {
            conn.Close();
        }
    }
}