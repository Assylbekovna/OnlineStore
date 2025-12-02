using System;
using OnlineOrderSystem.Models;

namespace OnlineOrderSystem.Services
{
    public class OrderProcessor
    {
        private readonly PaymentGateway _payment;
        private readonly WarehouseService _warehouse;
        private readonly ShippingService _shipping;

        public OrderProcessor(PaymentGateway payment, WarehouseService warehouse, ShippingService shipping)
        {
            _payment = payment;
            _warehouse = warehouse;
            _shipping = shipping;
        }

        public void Process(Order order)
        {
            if (order.Cart.IsEmpty)
            {
                Console.WriteLine("Cart is empty. Order canceled.");
                return;
            }

            Console.WriteLine("\n--- ORDER PROCESS STARTED ---");

          
            order.IsPaid = _payment.ProcessPayment(order.Cart.Total);

            if (!order.IsPaid)
            {
                Console.WriteLine("Order canceled due to payment failure.");
                return;
            }

            
            _warehouse.ProcessOrder();

            
            _shipping.ShipOrder(order.Address);

            Console.WriteLine("--- ORDER COMPLETED SUCCESSFULLY ---");
        }
    }
}
