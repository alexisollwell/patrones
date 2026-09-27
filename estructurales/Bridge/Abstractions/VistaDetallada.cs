using System;
using BridgePattern.Interfaces;

namespace BridgePattern.Abstractions
{
    public class VistaDetallada : VistaPersona
    {
        public VistaDetallada(IProveedorDatos proveedor) : base(proveedor) { }

        public override void Mostrar(string nombre)
        {
            var datos = _proveedor.ObtenerDatos(nombre);
            Console.WriteLine($"[Vista Detallada]");
            Console.WriteLine($"  - Nombre: {datos.Nombre}");
            Console.WriteLine($"  - Edad Estimada: {datos.EdadEstimada}");
            Console.WriteLine($"  - Obtenido desde: {datos.Origen}");
            Console.WriteLine($"  - Fecha consulta: {DateTime.Now}");
        }
    }
}
