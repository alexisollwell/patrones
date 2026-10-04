using System;

namespace EjercicioEnviosBase.Models
{
    public class Order
    {
        public double WeightInKg { get; set; }
        public double DistanceInKm { get; set; }
        public string ShippingMethod { get; set; } = "Terrestre";

        public double CalculateShippingCost()
        {
            double cost = 0;

            switch (ShippingMethod)
            {
                case "Terrestre":
                    // Tarifa base $50 + $5 por cada kg + $1 por cada km
                    cost = 50 + (WeightInKg * 5) + (DistanceInKm * 1);
                    break;
                
                case "Aereo":
                    // Tarifa base $150 + $20 por cada kg + $5 por cada km
                    cost = 150 + (WeightInKg * 20) + (DistanceInKm * 5);
                    break;
                
                case "DronExpress":
                    // Tarifa base $300 + cargo extra fijo por usar dron. 
                    // No importa la distancia, pero el peso máximo es bajo, así que cobramos extra si pesa más de 2kg.
                    cost = 300;
                    if (WeightInKg > 2)
                    {
                        cost += (WeightInKg - 2) * 50; 
                    }
                    break;

                default:
                    throw new InvalidOperationException("Método de envío no soportado.");
            }

            return cost;
        }
    }
}
