using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHDemo
{
    internal class Thingspeak
    {
        //public void SendData(int i, int i1)
        //{
        //    throw new NotImplementedException();
        //}
        public void SendData(int temperature, int humidity)
        {
            // https://api.thingspeak.com/update?api_key=5GA2OBFSGWT3TKF3&field1=12&field2=4
            
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.thingspeak.com");
            var response = httpClient.GetAsync($"/update?api_key=5GA2OBFSGWT3TKF3&field1={temperature}&field2={humidity}").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Data sent to ThingSpeak successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to send data to ThingSpeak. Status code: {response.StatusCode}");
            }
            throw new NotImplementedException();
        }
    }
}
