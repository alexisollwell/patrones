using System;
using AdapterClima.Adapters;
using AdapterClima.Interfaces;
using AdapterClima.Models;
using AdapterClima.Services;

namespace AdapterClima
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteClima cliente = new ClienteClima();

            Console.WriteLine("--- Sistema Antiguo");
            IClimaAntiguo sistemaAntiguo = new ClimaAntiguoMock();
            cliente.ProcesarClima(sistemaAntiguo, "Mexico");
            cliente.ProcesarClima(sistemaAntiguo, "Madrid");
            
            Console.WriteLine("--- Con Adapter");
            OpenMeteoService openMeteoService = new OpenMeteoService();
            IClimaAntiguo sistemaNuevoAdapter = new ClimaAdapter(openMeteoService);
            
            cliente.ProcesarClima(sistemaNuevoAdapter, "Mexico");
            cliente.ProcesarClima(sistemaNuevoAdapter, "Madrid");
        }
    }
}
