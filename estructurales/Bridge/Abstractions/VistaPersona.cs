using BridgePattern.Interfaces;

namespace BridgePattern.Abstractions
{
    public abstract class VistaPersona
    {
        protected IProveedorDatos _proveedor;

        public VistaPersona(IProveedorDatos proveedor)
        {
            _proveedor = proveedor;
        }

        public abstract void Mostrar(string nombre);
    }
}
