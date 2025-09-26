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

            while (true)
            {
                var thingSpeak = new Thingspeak();
                int temperature = new Random().Next(0, 40); // Random temperature between 0 and 40
                int humidity = new Random().Next(0, 100); // Random humidity between 0 and 100
                thingSpeak.SendData(temperature, humidity);

                System.Threading.Thread.Sleep(15000); // Wait for 15 seconds
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
