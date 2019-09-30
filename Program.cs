using RestaurantInterfaces.Domain;
using System;
using System.Text;

namespace RestaurantInterfaces
{
    class Program
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant("Mc");
            bool shouldRun = true;
            while (shouldRun)
            { 

            Console.Clear();
            Console.WriteLine("Menu in De_restaurant:");

            Console.WriteLine("1. Add Order.\n2. List Order(s)\n3. Exit\n");

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
                      
                        shouldRun = false;
                        break;
               

                }
            }
        }
    }
}
