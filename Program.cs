using RestaurantInterfaces.Domain;
using System;
using System.Text;
using System.Threading;

namespace RestaurantInterfaces
{
    class Program
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant("Mc", new Jeff());
            bool shouldRun = true;
            while (shouldRun)
            { 

            Console.Clear();
            Console.WriteLine("Menu in De_restaurant:");

            Console.WriteLine("1. Add Order.\n2. List Pending Order(s)\n3. Process Order(s)\n\n\n4. Exit");

            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                        Console.WriteLine("Dish: ");
                       string dish = Console.ReadLine();
                        Console.WriteLine("Table: ");
                        string table = Console.ReadLine();

                        Order order = new Order(dish, table);

                        restaurant.RegisterOrder(order);

                        Console.Clear();
                        Console.WriteLine("Order Registered");
                        System.Threading.Thread.Sleep(2000);

                        break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("Table:\tDish:\t\t\tRegistered");
                        StringBuilder sb = new StringBuilder();
                        sb.Append('-', Console.WindowWidth);
                        Console.WriteLine(sb);

                        foreach (var orderone in restaurant.OrderQueue)
                        {
                            Console.WriteLine($"{orderone.Table}\t{orderone.Dish}\t\t\t{orderone.RegisteredAt}");
                        }

                        Console.WriteLine("<Press Any Key To Continue>");
                        Console.ReadKey(true);
                        break;
                case ConsoleKey.D3:
                        var orderListan = restaurant.ProcessOrders();

                        Console.WriteLine("All Orders Processed");
                        Thread.Sleep(2000);
                      
                        break;
                    case ConsoleKey.D4:
                        shouldRun = false;
                        break;

                }
            }
        }
    }
}
