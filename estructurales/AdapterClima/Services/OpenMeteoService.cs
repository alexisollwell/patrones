using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdapterClima.Services
{
    public class OpenMeteoService
    {
        private readonly HttpClient _httpClient;

        public OpenMeteoService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetCurrentWeatherJsonAsync(double latitude, double longitude)
        {
            Console.WriteLine($"Realizando llamada HTTP para Lat: {latitude}, Lon: {longitude}...");
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";
            
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadAsStringAsync();
        }
    }
}
