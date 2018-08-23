using System;

namespace _07._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x2 - x1);
            var b = Math.Abs(y2 - y1);

            var perimeter = 2 * (a + b);
            var area = a * b;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
