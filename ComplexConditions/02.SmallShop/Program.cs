using System;
using System.Collections.Generic;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            var catalog = new Dictionary<string, Dictionary<string, double>>();
            catalog["sofia"] = new Dictionary<string, double>()
            {
                {"coffee",0.50},
                {"water", 0.80},
                {"beer", 1.20},
                {"sweets", 1.45},
                {"peanuts", 1.60}

            };
            catalog["plovdiv"] = new Dictionary<string, double>()
            {
                {"coffee",0.40},
                {"water", 0.70},
                {"beer", 1.15},
                {"sweets", 1.30},
                {"peanuts", 1.50}

            };
            catalog["varna"] = new Dictionary<string, double>()
            {
                {"coffee",0.45},
                {"water", 0.70},
                {"beer", 1.10},
                {"sweets", 1.35},
                {"peanuts", 1.55}

            };
            Console.WriteLine(catalog[town][product] * quantity);
        }
    }
}
