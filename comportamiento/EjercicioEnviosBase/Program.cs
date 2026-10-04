using System;
using EjercicioEnviosBase.Models;

namespace EjercicioEnviosBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order
            {
                WeightInKg = 3.5,
                DistanceInKm = 100
            };

            // Prueba 1
            myOrder.ShippingMethod = "Terrestre";
            Console.WriteLine($"Costo de envío Terrestre: ${myOrder.CalculateShippingCost()}");

            // Prueba 2
            myOrder.ShippingMethod = "Aereo";
            Console.WriteLine($"Costo de envío Aéreo: ${myOrder.CalculateShippingCost()}");

            // Prueba 3
            myOrder.ShippingMethod = "DronExpress";
            Console.WriteLine($"Costo de envío Dron Express: ${myOrder.CalculateShippingCost()}");
        }
    }
}
