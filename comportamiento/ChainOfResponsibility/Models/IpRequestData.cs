using System;

namespace ChainOfResponsibility.Models
{
    public class IpRequestData
    {
        public string IpAddress { get; set; } = string.Empty;        
        public string? Country { get; set; }
        public string? City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? TemperatureC { get; set; }

        public string GetRequestInfo()
        {
            return $"IP: {IpAddress} | Ubicación: {NoValue(City)}, {NoValue(Country)} | Clima: {Temperature()}";
        }

        private string Temperature()
        {
            return TemperatureC.HasValue ? $"{TemperatureC:F2}°C" : "N/A";
        }

        private string NoValue(string value)
        {
            return !string.IsNullOrWhiteSpace(value) ? value : "N/A";
        }
    }
}
