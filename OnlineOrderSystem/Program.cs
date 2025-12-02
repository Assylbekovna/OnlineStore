using System;
using System.Collections.Generic;
using OnlineOrderSystem.Models;
using OnlineOrderSystem.Services;

namespace OnlineOrderSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Online Store — Order Processing System\n");

    
            var catalog = new List<Product>
            {
                new Product(1, "Laptop", 450000),
                new Product(2, "Headphones", 15000),
                new Product(3, "Mouse", 6000)
            };

            Console.WriteLine("Available Products:");
            foreach (var p in catalog)
                Console.WriteLine($"{p.Id}. {p.Name} — {p.Price} ₸");

            
            var cart = new Cart();
            cart.Add(catalog[0]);
            cart.Add(catalog[2]);

            var order = new Order(cart)
            {
                CustomerName = "Aruzhan",
                Address = "Astana, Turan 12"
            };

           
            var processor = new OrderProcessor(
                new PaymentGateway(),
                new WarehouseService(),
                new ShippingService()
            );

            processor.Process(order);
        }
    }
}
