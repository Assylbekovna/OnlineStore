using System;

namespace OnlineOrderSystem.Services
{
    public class ShippingService
    {
        public void ShipOrder(string address)
        {
            Console.WriteLine($"Order shipped to: {address}");
        }
    }
}
