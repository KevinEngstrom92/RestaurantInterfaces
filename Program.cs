﻿using System;

namespace RestaurantInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        System.Threading.Thread.Sleep(2000);

                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                      
                        shouldRun = false;
                        break;
               

                }
            }
        }
    }
}
