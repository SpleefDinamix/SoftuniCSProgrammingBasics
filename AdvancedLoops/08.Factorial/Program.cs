using System;

namespace _08.Factorial
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = num - 1; i > 0; i--)
            {
                num *= i;
            }

            Console.WriteLine(num);
        }
    }
}
