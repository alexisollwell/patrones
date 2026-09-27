using System.Text.Json;
using AdapterPattern.Interfaces;
using AdapterPattern.Models;
using AdapterPattern.Services;

namespace AdapterPattern.Adapters
{
    public class UsuarioApiAdapter : IUsuarioSistema
    {
        private readonly ApiExterna _apiExterna;
        private readonly ApiUser? _usuarioCache;

        public UsuarioApiAdapter(ApiExterna apiExterna, int userId)
        {
            _apiExterna = apiExterna;
            var json = _apiExterna.GetUserJsonAsync(userId).GetAwaiter().GetResult();
            _usuarioCache = JsonSerializer.Deserialize<ApiUser>(json);
        }

        public string ObtenerNombreCompleto()
        {
            return _usuarioCache?.name ?? "Desconocido";
        }

        public string ObtenerCorreo()
        {
            return _usuarioCache?.email ?? "Sin correo";
        }
    }
}
