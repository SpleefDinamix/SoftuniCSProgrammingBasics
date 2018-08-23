using System;

namespace _08.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = Math.Round(a * h / 2, 2);

            Console.WriteLine(area);
        }
    }
}
