using ACN.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ACN.Objects
{
    public class area 
    {
        //private members
        private string name;
        private sensor[] sensors;

        // public properties
        public string Name
        {
            get { return name; }
        }

        public sensor[] Sensors
        {
            get { return sensors; }
        }

        public area(string name)
        {
            this.name = name;
            dbConn conn = new dbConn();
            DataTable rawData = conn.getSensorTable(name);
            conn.Dispose();

            List<sensor> holder = new List<sensor>();
            foreach (DataRow row in rawData.Rows)
                holder.Add(new sensor(row));
            this.sensors = holder.ToArray();                
            
        }

        
    }
}