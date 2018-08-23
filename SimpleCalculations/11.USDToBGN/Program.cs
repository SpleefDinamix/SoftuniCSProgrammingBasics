using System;

namespace _11.USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = decimal.Parse(Console.ReadLine());
            var bgn = Math.Round(usd * 1.79549M, 2);

            Console.WriteLine(bgn + " BGN");
        }
    }
}
