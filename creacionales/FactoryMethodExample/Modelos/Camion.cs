using System;
using FactoryMethodExample.Interfaces;

namespace FactoryMethodExample.Modelos
{
    public class Camion : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entrega por tierra en una caja usando un camión.");
        }
    }
}
