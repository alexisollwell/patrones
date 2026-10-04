using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using AdapterClima.Interfaces;
using AdapterClima.Models;
using AdapterClima.Services;

namespace AdapterClima.Adapters
{
    public class ClimaAdapter : IClimaAntiguo
    {
        private readonly OpenMeteoService _openMeteoService;
        
        private readonly List<Cities> _ciudades;

        public ClimaAdapter(OpenMeteoService openMeteoService)
        {
            _openMeteoService = openMeteoService;
            
            _ciudades = new List<Cities>
            {
                new Cities { name = "Mexico", latitude = 19.42847, longitude = -99.12766 },
                new Cities { name = "Madrid", latitude = 40.4165, longitude = -3.70256 },
                new Cities { name = "Bogota", latitude = 4.6097, longitude = -74.0817 }
            };
        }

        public double ObtenerTemperatura(string ciudad)
        {
            Console.WriteLine($"Adaptando petición de la ciudad '{ciudad}' a coordenadas...");

            var ciudadInfo = _ciudades.FirstOrDefault(c => c.name.Equals(ciudad, StringComparison.OrdinalIgnoreCase));
            if (ciudadInfo == null)
            {
                throw new ArgumentException($"No se tienen coordenadas configuradas en el adaptador para la ciudad '{ciudad}'.");
            }

            var lat = ciudadInfo.latitude;
            var lon = ciudadInfo.longitude;

            string jsonResult = _openMeteoService.GetCurrentWeatherJsonAsync(lat, lon).GetAwaiter().GetResult();

            Console.WriteLine($"JSON recibido, extrayendo la temperatura...");
            
            using JsonDocument doc = JsonDocument.Parse(jsonResult);
            JsonElement root = doc.RootElement;
            JsonElement currentWeather = root.GetProperty("current_weather");
            double temperature = currentWeather.GetProperty("temperature").GetDouble();

            return temperature;
        }
    }
}
