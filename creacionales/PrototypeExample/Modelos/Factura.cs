using System;
using PrototypeExample.Interfaces;

namespace PrototypeExample.Modelos
{
    public class Factura : IPrototipoDocumento
    {
        public int NumeroFactura { get; set; }
        public string Cliente { get; set; }
        public double Monto { get; set; }

        public Factura(int numeroFactura, string cliente, double monto)
        {
            Console.WriteLine($"[Sistema] Creando factura original #{numeroFactura} desde la base de datos (Proceso lento)...");
            NumeroFactura = numeroFactura;
            Cliente = cliente;
            Monto = monto;
        }

        public IPrototipoDocumento Clonar()
        {
            Console.WriteLine($"[Sistema] Clonando factura #{NumeroFactura} (Proceso instantáneo)...");
            return (IPrototipoDocumento)this.MemberwiseClone();
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"> Factura #{NumeroFactura} | Cliente: {Cliente} | Monto: ${Monto}\n");
        }
    }
}
