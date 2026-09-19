using System;
using FactoryMethodExample.Interfaces;

namespace FactoryMethodExample.Modelos
{
    public class Barco : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entrega por mar en un contenedor usando un barco.");
        }
    }
}
