using System;
using System.Threading.Tasks;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var geoHandler = new GeolocationHandler();
            var weatherHandler = new WeatherHandler();

            geoHandler.SetNext(weatherHandler);
            //weatherHandler.SetNext(poblacion);

            var ipsToTest = new[]
            {
                "189.215.231.10", // México
                "8.8.8.8",        // USA
                "dfkmsgkndsfk"      // error
            };

            foreach (var ip in ipsToTest)
            {//mexico
                var requestData = new IpRequestData { IpAddress = ip };
                
                var result = await geoHandler.HandleAsync(requestData);

                Console.WriteLine($"\nCadena completa");
                Console.WriteLine($"{result.GetRequestInfo()}");
                Console.WriteLine(new string('-', 80));
            }
        }
    }
}
