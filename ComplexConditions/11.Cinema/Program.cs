using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectionType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double value = 0d;

            if (projectionType == "premiere")
            {
                value = rows * cols * 12.00;
            }
            else if (projectionType == "normal")
            {
                value = rows * cols * 7.50;
            }
            else if (projectionType == "discount")
            {
                value = rows * cols * 5.00;
            }

            Console.WriteLine("{0:f2}", value);
        }
    }
}
