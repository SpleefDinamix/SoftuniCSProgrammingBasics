using System;
using System.Collections.Generic;

namespace _04.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var catalog = new Dictionary<string, List<string>>();
            catalog["fruit"] = new List<string>()
            {"banana", "apple", "kiwi", "cherry", "lemon", "grapes"};

            catalog["vegetable"] = new List<string>()
            {"tomato", "cucumber", "pepper", "carrot"};

            if (catalog["fruit"].Contains(product))
            {
                Console.WriteLine("fruit");
            }
            else if (catalog["vegetable"].Contains(product))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
