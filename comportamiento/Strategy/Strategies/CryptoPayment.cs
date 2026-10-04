using System;
using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class CryptoPayment : IPaymentStrategy
    {
        private string _walletAddress;

        public CryptoPayment(string walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Procesando pago de ${amount} hacia la wallet {_walletAddress}.");
        }
    }
}
