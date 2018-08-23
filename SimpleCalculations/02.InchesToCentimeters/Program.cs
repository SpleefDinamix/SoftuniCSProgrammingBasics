using System;

namespace _02.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(cm);
        }
    }
}
