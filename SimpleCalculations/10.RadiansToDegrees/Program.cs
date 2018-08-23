using System;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rads = double.Parse(Console.ReadLine());
            var degrees = Math.Round(rads / Math.PI * 180);

            Console.WriteLine(degrees);
        }
    }
}
