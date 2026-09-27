using System;
using BridgePattern.Interfaces;

namespace BridgePattern.Abstractions
{
    public class VistaResumida : VistaPersona
    {
        public VistaResumida(IProveedorDatos proveedor) : base(proveedor) { }

        public override void Mostrar(string nombre)
        {
            var datos = _proveedor.ObtenerDatos(nombre);
            Console.WriteLine($"[Vista Resumida] {datos.Nombre} - Edad: {datos.EdadEstimada}");
        }
    }
}
