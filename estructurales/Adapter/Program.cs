using System;
using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using AdapterPattern.Services;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            ApiExterna apiExterna = new ApiExterna();

            IUsuarioSistema usuario = new UsuarioApiAdapter(apiExterna, 5);
            Console.WriteLine($"Nombre: {usuario.ObtenerNombreCompleto()}");
            Console.WriteLine($"Correo: {usuario.ObtenerCorreo()}");            
        }
    }
}
