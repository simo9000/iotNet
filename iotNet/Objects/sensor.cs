using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ACN.Objects
{
    public class sensor
    {
        private int id;
        private string networkAddress;
        public string description;
        public sensorData currentConditions;

        public sensor(DataRow row)
        {
            // pull sensor description data from data row
            this.id = (int)row["ID"];
            this.networkAddress = row.hasColumn("fdNetworkAddress") ? (string)row["fdNetworkAddress"] : null;
            this.description = row.hasColumn("fdDescription") ? (string)row["fdDescription"] : null;

            // pull current condition data for sensor from row
            this.currentConditions = new sensorData(row);

            //TODO: populate tolerances from row
        }

        
    }
}