using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            var evenNums = new List<double>();
            var oddNums = new List<double>();

            for (int i = 1; i <= readCycles; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNums.Add(num);
                }
                else
                {
                    oddNums.Add(num);
                }
            }
            Console.WriteLine("OddSum=" + oddNums.Sum() + ',');
            Console.WriteLine("OddMin=" + (oddNums.Count == 0 ? "No" : oddNums.Min().ToString()) + ',');
            Console.WriteLine("OddMax=" + (oddNums.Count == 0 ? "No" : oddNums.Max().ToString()) + ',');
            Console.WriteLine("EvenSum=" + evenNums.Sum() + ',');
            Console.WriteLine("EvenMin=" + (evenNums.Count == 0 ? "No" : evenNums.Min().ToString()) + ',');
            Console.WriteLine("EvenMax=" + (evenNums.Count == 0 ? "No" : evenNums.Max().ToString()));
        }
    }
}
