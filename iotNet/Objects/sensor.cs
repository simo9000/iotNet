using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ACN.Objects
{
    public class sensor
    {
        // private memebers
        private int id;
        private string description;
        private sensorData currentConditions;


        // public properties
        public int ID { get { return id; } }
        public string Description { get { return description; } }
        public sensorData CurrentConditions { get { return currentConditions; } }

        public sensor(DataRow row)
        {
            // pull sensor description data from data row
            this.id = (int)row["ID"];
            this.description = row.hasColumn("fdDescription") ? (string)row["fdDescription"] : null;

            // pull current condition data for sensor from row
            this.currentConditions = new sensorData(row);
        }
    }
}