using System;
using Strategy.Context;
using Strategy.Strategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(25.50);
            cart.AddItem(15.00);
            cart.AddItem(100.00);

            Console.WriteLine("\n--- Intento de pago sin estrategia ---");
            cart.Checkout();

            Console.WriteLine("\n--- Pago con Tarjeta de Crédito ---");
            cart.SetPaymentStrategy(new CreditCardPayment("Alexis", "1234567890123456"));
            cart.Checkout();

            Console.WriteLine("\n--- Nueva Compra ---");
            cart.AddItem(45.99);

            Console.WriteLine("\n--- Pago con PayPal ---");
            cart.SetPaymentStrategy(new PayPalPayment("alexis@example.com"));
            cart.Checkout();

            Console.WriteLine("\n--- Nueva Compra ---");
            cart.AddItem(1500.00);

            Console.WriteLine("\n--- Pago con Criptomonedas ---");
            cart.SetPaymentStrategy(new CryptoPayment("0x123abc456def..."));
            cart.Checkout();
        }
    }
}
