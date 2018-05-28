using System;

namespace _03.SquareOFStars
{
    class Program
    {
        static void Main()
        {
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < times; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
