using System;

namespace RestaurantInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu in De_restaurant:");

            Console.WriteLine("1.\n2.\n3.\n4.\n");

            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;

            }
        }
    }
}
