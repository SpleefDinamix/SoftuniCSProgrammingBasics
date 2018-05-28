using System;

namespace _04.TriangleOfDollars
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
