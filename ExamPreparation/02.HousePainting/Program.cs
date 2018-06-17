using System;
using System.Globalization;

namespace _02.HousePainting
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var backWall = x * x;
            var frontWall = backWall - 2.4;
            var sideWall = x * y - 2.25;
            var roofTop = x * y;
            var roofFrontAndBackFace = x * h / 2;

            var wallArea = 2 * sideWall + backWall + frontWall;
            var roofArea = 2 * roofTop + 2 * roofFrontAndBackFace;

            Console.WriteLine("{0:F2}", wallArea / 3.4);
            Console.WriteLine("{0:F2}", roofArea / 4.3);
        }
    }
}
