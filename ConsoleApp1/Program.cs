﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero da convertire");
            int value =int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"il corrispettivo numero binario è {binary}");
            string esadecimale = Convert.ToString(value, 16);
            Console.WriteLine($"il corrispettivo numero esadecimale è {esadecimale}");
            string ottale = Convert.ToString(value, 8);
            Console.WriteLine($"il corrispettivo numero ottale è {ottale}");
            Console.ReadLine();

        }
    }
}
