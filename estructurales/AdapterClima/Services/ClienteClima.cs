using System;
using AdapterClima.Interfaces;

namespace AdapterClima
{
    public class ClienteClima
    {
        public void ProcesarClima(IClimaAntiguo proveedorClima, string ciudad)
        {
            try
            {
                double temperatura = proveedorClima.ObtenerTemperatura(ciudad);
                Console.WriteLine($"La temperatura en {ciudad} es de {temperatura}°C.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
    }
}
