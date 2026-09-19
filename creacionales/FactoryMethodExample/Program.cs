using System;
using FactoryMethodExample.Fabricas;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App: Lanzando la logística terrestre.");
            Logistica logistica1 = new LogisticaTerrestre();
            logistica1.PlanificarEntrega();

            Console.WriteLine("\nApp: Lanzando la logística marítima.");
            Logistica logistica2 = new LogisticaMaritima();
            logistica2.PlanificarEntrega();
        }
    }
}
