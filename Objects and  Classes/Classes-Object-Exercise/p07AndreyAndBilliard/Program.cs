using System;
using System.Collections.Generic;
using System.Linq;

namespace p07AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrder = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 0; i < numberOfOrder; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                Product product = products.FirstOrDefault(x => x.Name == name);

                if(product==null)
                {
                    Product newProduct = new Product(name, price);
                    products.Add(newProduct); 
                }
                else
                {
                    product.Price = price;
                }
            }

            string command = Console.ReadLine();
            List<Order> orders = new List<Order>();

            while (command != "end of clients")
            {
                string[] tokens = command.Split(new char[] { '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                string customerName = tokens[0];
                string productName = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (products.Any(x => x.Name == productName)==false)
                {
                    command = Console.ReadLine();
                    continue;
                }

                Order order = orders.FirstOrDefault(x => x.CustomerName == customerName);

                if (order == null)
                {
                    Order newOrder = new Order(customerName);
                    newOrder.OrderedProducts.Add(productName, quantity);
                    orders.Add(newOrder);
                }
                else
                {
                    if (order.OrderedProducts.ContainsKey(productName)==false)
                    {
                        order.OrderedProducts.Add(productName, quantity);
                    }
                    else
                    {
                        order.OrderedProducts[productName] += quantity;
                    }
                }
                command = Console.ReadLine();
            }

            double totalSum = 0;
            foreach (Order order in orders.OrderBy(x=>x.CustomerName))
            {
                Console.WriteLine(order.CustomerName);
                double sum = 0;
                foreach (var pair in order.OrderedProducts)
                {
                    Console.WriteLine($"-- {pair.Key} - {pair.Value}");
                    double price = products.First(x => x.Name == pair.Key).Price;
                    sum += pair.Value * price;
                }
                totalSum += sum;
                Console.WriteLine("Bill: {0:f2}", sum);
            }
            Console.WriteLine("Total bill: {0:f2}",totalSum);
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                this.Name = name;
                this.Price = price;
            }
        }

        class Order
        {
            public string CustomerName { get; set; }
            public Dictionary<string, int> OrderedProducts { get; set; }

            public Order(string customerName)
            {
                this.CustomerName = customerName;

                this.OrderedProducts = new Dictionary<string, int>();
            }
        }
    }
}
