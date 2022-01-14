using Pedidos.Entities;
using Pedidos.Entities.Enums;
using System;

namespace Pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:" );
            string clientName = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter order data: ");
            DateTime orderdata = DateTime.Now;
            
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(orderdata, status, client);
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());
                Product product = new Product(prodName, prodPrice);
                Console.Write("Quantity: ");
                int quanty = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quanty, prodPrice, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary:");
            Console.WriteLine(order);
        }
    }
}
