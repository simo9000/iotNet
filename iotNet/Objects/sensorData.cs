using System;
using System.Data;

namespace ACN.Objects
{
    public class sensorData
    {
        public DateTime timeStamp;
        public double temperature, pressure, humdity, light;

        public sensorData(DataRow row)
        {
            this.timeStamp = (DateTime)row["fdTimeStamp"];
            this.temperature = row.getValue("fdTemperature");
            this.pressure = row.getValue("fdPressure");
            this.humdity = row.getValue("fdHumidity");
            this.light = row.getValue("fdBrightness");
        }
    }
}