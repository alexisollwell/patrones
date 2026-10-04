using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class WeatherHandler : BaseHandler
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public override async Task<IpRequestData> HandleAsync(IpRequestData request)
        {
            Console.WriteLine($"\nSegundo eslabon");
            Console.WriteLine("Analizando si podemos obtener el clima...");

            if (!request.Latitude.HasValue || !request.Longitude.HasValue)
            {
                Console.WriteLine("No hay coordenadas disponibles, no se puede obtener el clima.");
                return await base.HandleAsync(request);
            }

            Console.WriteLine($"Obteniendo el clima para las coordenadas: {request.Latitude}, {request.Longitude}...");
            try
            {
                string url = $"https://api.open-meteo.com/v1/forecast?latitude={request.Latitude.Value}&longitude={request.Longitude.Value}&current_weather=true";
                var response = await _httpClient.GetStringAsync(url);
                using JsonDocument doc = JsonDocument.Parse(response);
                
                var root = doc.RootElement;
                if (root.TryGetProperty("current_weather", out JsonElement currentW))
                {
                    request.TemperatureC = currentW.GetProperty("temperature").GetDouble();
                    Console.WriteLine($"Éxito: Temperatura actual {request.TemperatureC}°C.");
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
