using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class GeolocationHandler : BaseHandler
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public override async Task<IpRequestData> HandleAsync(IpRequestData request)
        {
            Console.WriteLine($"\nPrimer eslabon");
            Console.WriteLine($"Procesando IP: {request.IpAddress}...");
            try
            {
                string url = $"http://ip-api.com/json/{request.IpAddress}";
                var response = await _httpClient.GetStringAsync(url);
                using JsonDocument doc = JsonDocument.Parse(response);
                
                var root = doc.RootElement;
                if (root.GetProperty("status").GetString() == "success")
                {
                    request.Country = root.GetProperty("country").GetString();
                    request.City = root.GetProperty("city").GetString();
                    request.Latitude = root.GetProperty("lat").GetDouble();
                    request.Longitude = root.GetProperty("lon").GetDouble();
                    Console.WriteLine($"Éxito: Encontrado en {request.City}, {request.Country}.");
                }
                else
                {
                    Console.WriteLine("Error: No se pudo geolocalizar la IP.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
            }

            return await base.HandleAsync(request);
        }
    }
}
