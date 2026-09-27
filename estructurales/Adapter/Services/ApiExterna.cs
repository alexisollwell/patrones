using System.Net.Http;
using System.Threading.Tasks;

namespace AdapterPattern.Services
{
    public class ApiExterna
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> GetUserJsonAsync(int userId)
        {
            var url = $"https://jsonplaceholder.typicode.com/users/{userId}";
            var response = await client.GetStringAsync(url);
            return response;
        }
    }
}
