using System;

namespace Strategy.Interfaces
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
