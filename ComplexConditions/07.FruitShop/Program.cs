using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var days = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            var catalog = new Dictionary<string, double>()
            {
                {"banana",2.50},
                {"apple",1.20},
                {"orange",0.85},
                {"grapefruit",1.45},
                {"kiwi",2.70},
                {"pineapple",5.50},
                {"grapes",3.85}
            };
            var catalogWeekend = new Dictionary<string, double>(){
                {"banana",2.70},
                {"apple",1.25},
                {"orange",0.90},
                {"grapefruit",1.60},
                {"kiwi",3.00},
                {"pineapple",5.60},
                {"grapes",4.20}
            };

            if (!days.Contains(day) || !catalog.ContainsKey(product))
            {
                Console.WriteLine("error");
            }
            else if (day == "sunday" || day == "saturday")
            {
                Console.WriteLine("{0:f2}", catalogWeekend[product] * quantity);
            }
            else
            {
                Console.WriteLine("{0:f2}", catalog[product] * quantity);
            }
        }
    }
}
