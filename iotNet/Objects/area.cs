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

        // public properties
        public string Name
        {
            get { return name; }
        }

        public area(string name)
        {
            this.name = name;
            dbConn conn = new dbConn();
            DataTable rawData = conn.getSensorTable(name);
            conn.Dispose();
            
        }

        
    }
}