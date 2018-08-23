using System;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempCelsius = double.Parse(Console.ReadLine());
            var tempFahrentheit = tempCelsius * 1.8 + 32;

            Console.WriteLine(tempFahrentheit);
        }
    }
}
