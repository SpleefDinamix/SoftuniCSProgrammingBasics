using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine((int)Math.Pow(2, i));
            }
        }
    }
}
