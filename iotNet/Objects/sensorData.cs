using System;
using System.Data;

namespace ACN.Objects
{
    public class sensorData
    {
        private DateTime timeStamp;
        private double temperature, pressure, humdity, light;
        public double Temperature { get { return temperature; } }
        public double Pressure { get { return pressure; } }
        public double Humidity { get { return humdity; } }
        public double Light { get { return light; } }

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