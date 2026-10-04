using System;
using Strategy.Interfaces;

namespace Strategy.Context
{
    public class ShoppingCart
    {
        private double _totalAmount;
        private IPaymentStrategy? _paymentStrategy;

        public ShoppingCart()
        {
            _totalAmount = 0.0;
        }

        public void AddItem(double price)
        {
            _totalAmount += price;
            Console.WriteLine($"Producto agregado. Total actual: ${_totalAmount}");
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout()
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Por favor, selecciona un método de pago antes de proceder.");
                return;
            }

            if (_totalAmount == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            _paymentStrategy.Pay(_totalAmount);
            _totalAmount = 0;
        }
    }
}
