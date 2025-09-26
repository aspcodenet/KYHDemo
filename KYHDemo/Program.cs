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

            var thingSpeak = new Thingspeak();
            thingSpeak.SendData(12, 4);

            Console.WriteLine("Hello, World!");
        }
    }
}
