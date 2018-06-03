using System;

namespace _03.PowersOfTwo
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine((int)Math.Pow(2,i));
            }
        }
    }
}
