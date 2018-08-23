using System;

namespace _05.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) / 2 * h;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
