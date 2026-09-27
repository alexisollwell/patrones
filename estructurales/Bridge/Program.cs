using System;
using BridgePattern.Abstractions;
using BridgePattern.Implementations;
using BridgePattern.Interfaces;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            string nombreConsulta = "alexis";

            IProveedorDatos proveedorRemoto = new ProveedorAgify();
            IProveedorDatos proveedorLocal = new ProveedorLocal();

            VistaPersona vista1 = new VistaResumida(proveedorRemoto);
            vista1.Mostrar(nombreConsulta);
            
            Console.WriteLine();

            VistaPersona vista2 = new VistaDetallada(proveedorRemoto);
            vista2.Mostrar(nombreConsulta);

            Console.WriteLine("\nCambiando proveedor de datos al Local...\n");

            VistaPersona vista3 = new VistaDetallada(proveedorLocal);
            vista3.Mostrar(nombreConsulta);
        }
    }
}
