using System;

namespace OnlineOrderSystem.Services
{
    public class PaymentGateway
    {
        private readonly Random _rnd = new();

        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment: {amount} ₸...");

            
            bool success = _rnd.Next(1, 100) <= 80;

            Console.WriteLine(success ? "Payment successful!" : "Payment failed!");
            return success;
        }
    }
}
