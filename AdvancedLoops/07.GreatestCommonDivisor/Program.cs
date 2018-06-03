using System;

namespace _07.GreatestCommonDivisor
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(gcd(a, b));
        }

        static int gcd(int a, int b) {
            if (b == 0) {
                return a;
            }
            else {
                return gcd(b, a % b);
            }
        }
    }
}
