using System;
using FactoryMethodExample.Interfaces;

namespace FactoryMethodExample.Fabricas
{
    public abstract class Logistica
    {
        public abstract ITransporte CrearTransporte();
        public void PlanificarEntrega()
        {
            ITransporte transporte = CrearTransporte();
            Console.WriteLine("Logística: Planificando la entrega...");
            transporte.Entregar();
        }
    }
}
