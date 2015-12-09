using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace ACN.Database
{
    public class dbConn_mysql : IDisposable
    {
        // members
        private MySqlConnection conn;
        
        // constructor
        public dbConn_mysql(){
            string connString = ConfigurationManager.ConnectionStrings["ACN_mysql"].ConnectionString;
            string password = ConfigurationManager.AppSettings["dbPassword_mysql"];
            connString = connString.Replace("{password}", password);
            conn = new MySqlConnection(connString);
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
            string sqlString = "SELECT tblSensor.PK_ID as ID, " + Environment.NewLine;
	        sqlString +=       "fdTimeStamp as fdTimeStamp, " + Environment.NewLine;
	        sqlString +=       "fdDescription as fdDescription, " + Environment.NewLine;
	        sqlString +=       "fdPressure as fdPressure, " + Environment.NewLine;
	        sqlString +=       "fdHumidity as fdHumidity, " + Environment.NewLine;
	        sqlString +=       "fdBrightness as fdBrightness, " + Environment.NewLine;
	        sqlString +=       "fdTemperature as fdTemperature, " + Environment.NewLine;
	        sqlString +=       "tblArea.fdName as areaName " + Environment.NewLine;
            sqlString +=       "FROM tblSensor " + Environment.NewLine;
	        sqlString +=       "   INNER JOIN tblArea " + Environment.NewLine;
		    sqlString +=       "       ON tblArea.PK_ID = tblSensor.FK_Area_ID " + Environment.NewLine;
	        sqlString +=       "   LEFT JOIN tblSensorData " + Environment.NewLine;
		    sqlString +=       "       ON tblSensor.PK_ID = tblSensorData.FK_Sensor_ID " + Environment.NewLine;
            sqlString +=       "WHERE tblSensorData.fdTimeStamp = (Select max(fdTimeStamp) from tblSensorData) " + Environment.NewLine;
            sqlString +=       "AND tblArea.fdName='{area}'";
            sqlString = sqlString.Replace("{area}", area);
            DataTable results = query(sqlString);
            return results;
        }

        // private helper functions
        private DataTable query(string sqlString)
        {
            DataTable returnVal = new DataTable();
            MySqlCommand command = new MySqlCommand(sqlString, conn);
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