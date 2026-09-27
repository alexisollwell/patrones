using System.Net.Http;
using System.Text.Json;
using BridgePattern.Interfaces;
using BridgePattern.Models;

namespace BridgePattern.Implementations
{
    public class ProveedorAgify : IProveedorDatos
    {
        public InformacionPersona ObtenerDatos(string nombre)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetStringAsync($"https://api.agify.io/?name={nombre}").GetAwaiter().GetResult();
                var doc = JsonDocument.Parse(response);
                var age = doc.RootElement.TryGetProperty("age", out var ageProp) && ageProp.ValueKind != JsonValueKind.Null ? ageProp.GetInt32() : 0;

                return new InformacionPersona 
                { 
                    Nombre = nombre, 
                    EdadEstimada = age,
                    Origen = "API remota Agify"
                };
            }
        }
    }
}
