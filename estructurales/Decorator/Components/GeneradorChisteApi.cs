using System.Net.Http;
using System.Text.Json;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;

namespace DecoratorPattern.Components
{
    public class GeneradorChisteApi : IGeneradorMensaje
    {
        public string ObtenerMensaje()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetStringAsync("https://official-joke-api.appspot.com/random_joke").GetAwaiter().GetResult();
                var joke = JsonSerializer.Deserialize<JokeResponse>(response);
                return $"{joke?.setup} - {joke?.punchline}";
            }
        }
    }
}
