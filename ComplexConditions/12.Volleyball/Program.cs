using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double hs = (48 - h) * 3 / 4d;
            double ps = p * 2 / 3d;

            double result = h + hs + ps;

            double leap = 0d;
            if (yearType == "leap")
            {
                leap = result * 15 / 100;
                result += leap;
            }

            Console.WriteLine((int)result);
        }
    }
}
