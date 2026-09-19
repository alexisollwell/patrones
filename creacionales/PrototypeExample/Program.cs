using System;
using PrototypeExample.Modelos;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura facturaOriginal = new Factura(1001, "Empresa ABC S.A.", 5000.50);            
            Console.WriteLine("--Factura Original");
            facturaOriginal.MostrarDetalles();


            Factura facturaClonada1 = (Factura)facturaOriginal.Clonar();            
            facturaClonada1.NumeroFactura = 1002;
            facturaClonada1.Cliente = "Industrias XYZ";

            Console.WriteLine("--Primera Factura Clonada (Modificada)");
            facturaClonada1.MostrarDetalles();

            Factura facturaClonada2 = (Factura)facturaOriginal.Clonar();
            facturaClonada2.NumeroFactura = 1003;
            facturaClonada2.Cliente = "Tech Solutions Ltda.";
            facturaClonada2.Monto = 12000.00;

            Console.WriteLine("--Segunda Factura Clonada (Modificada)");
            facturaClonada2.MostrarDetalles();
        }
    }
}
