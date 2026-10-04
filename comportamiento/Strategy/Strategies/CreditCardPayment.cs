using System;
using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _name;
        private string _cardNumber;

        public CreditCardPayment(string name, string cardNumber)
        {
            _name = name;
            _cardNumber = cardNumber;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Pagando ${amount} usando la tarjeta terminada en {_cardNumber.Substring(_cardNumber.Length - 4)} a nombre de {_name}.");
        }
    }
}
