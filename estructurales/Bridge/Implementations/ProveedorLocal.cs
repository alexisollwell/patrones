using BridgePattern.Interfaces;
using BridgePattern.Models;

namespace BridgePattern.Implementations
{
    public class ProveedorLocal : IProveedorDatos
    {
        public InformacionPersona ObtenerDatos(string nombre)
        {
            return new InformacionPersona 
            { 
                Nombre = nombre, 
                EdadEstimada = 25, 
                Origen = "Base de Datos Local (Mock)"
            };
        }
    }
}
