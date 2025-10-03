using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHDemo
{
    internal class SensorData
    {
        // Constructor = SÄKERSTÄLLA VALID STATE
        public SensorData(int temperature, int humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
        }
        public int Temperature { get; set; }
        public int Humidity { get; set; }


    }
}
