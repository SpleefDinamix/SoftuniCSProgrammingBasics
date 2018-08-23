using System;

namespace _06.SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var face = new String('*', n);
            var filing = '*' + new String(' ', n - 2) + '*';

            Console.WriteLine(face);
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(filing);
            }
            Console.WriteLine(face);
        }
    }
}
