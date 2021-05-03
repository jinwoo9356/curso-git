using System;
using System.Globalization;
using CompositionsExercice.Entities;
using CompositionsExercice.Entities.Enums;

namespace CompositionsExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Bithday date(DD/MM/YYYY):");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client Cliente = new Client(name, email, birthday);
            Order order = new Order(DateTime.Now, os, Cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order sumary: ");
            Console.WriteLine(order);



        }
    }
}
