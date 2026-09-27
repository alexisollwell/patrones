using BridgePattern.Models;

namespace BridgePattern.Interfaces
{
    public interface IProveedorDatos
    {
        InformacionPersona ObtenerDatos(string nombre);
    }
}
