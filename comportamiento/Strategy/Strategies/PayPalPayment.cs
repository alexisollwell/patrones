using System;
using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Pagando ${amount} usando la cuenta de PayPal asociada al correo {_email}.");
        }
    }
}
