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
        // private members
        private string name;
        private sensor[] sensors;
        private dbConn_mysql db;

        // public properties
        public string Name { get { return name; } }
        public sensor[] Sensors { get { return sensors; } }

        public area(string name)
        {
            this.name = name;
            db = new dbConn_mysql();
            DataTable rawData = db.getSensorTable(name);
            db.Dispose();

            List<sensor> holder = new List<sensor>();
            foreach (DataRow row in rawData.Rows)
                holder.Add(new sensor(row));
            this.sensors = holder.ToArray();
            holder = null;
        }

        
    }
}