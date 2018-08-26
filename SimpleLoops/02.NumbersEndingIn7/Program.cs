using System;

namespace _02.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i += 10)
            {
                Console.WriteLine(i + 7);
            }
        }
    }
}
