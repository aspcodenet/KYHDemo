namespace KYHDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://api.thingspeak.com/update?api_key=5GA2OBFSGWT3TKF3&field1=12&field2=4
            // loopa forever
            //      generate random number för field1 och field2
            //       skicka till thingspeak
            //     vänta 15 sekunder
            //     

            // 1. Vi bör ha en klass som samlar ihop datan
            // temperature och humidity bör ligga i en klass som 
            // för er RPM, speed osv osv


            // 2. Skapa en service - "jaha ska vi rename:a Thingspeak -> ThingspeakService"

            // 3. Ha kvar Thingspeak klassen
            // 
            // - om vi byter ut Thingsspeak mot Azure IoT Hub

            while (true)
            {
                int temperature = new Random().Next(0, 40); // Random temperature between 0 and 40
                int humidity = new Random().Next(0, 100); // Random humidity between 0 and 100

                var sensorData = new SensorData(temperature, humidity);

                var sendDataService = new SendDataService(); // GENERISK SERVICE
                sendDataService.SendData(sensorData);//;
                System.Threading.Thread.Sleep(15000); // Wait for 15 seconds
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
