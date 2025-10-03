using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHDemo
{
    internal class SendDataService // GENERISK
    {

        // ett annat exempel på abstraktioner är
        // DbContext i EF Core
        // vi programmerar mot dbcontext (GENERISK)
        // dbcontext har olika providers
        // SELECT * from ,,    SELECT all from 
        // SqlServer, SqlLite, InMemory, PostgreSQL, MySQL, MariaDB osv osv

        // Meh ! Är inte den hör klassen helt meningslös!!!
        // Senddataservice är en ABSTRAKTION av att skicka till en molntjänst

        // Programmeera mot sk PROVIDER-modeller

        // DI - Dependency Injection

        public void SendData(SensorData sensorData)
        {
            var thingspeak = new Thingspeak();
            thingspeak.SendData(sensorData.Temperature, sensorData.Humidity);
        }
    }
}
