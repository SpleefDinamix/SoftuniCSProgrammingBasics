using System;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 0; i < readCycles; i++)
            {
                if (i % 2 != 0)
                {
                    odd += int.Parse(Console.ReadLine());
                }
                else
                {
                    even += int.Parse(Console.ReadLine());
                }
            }

            int diff = Math.Abs(odd - even);

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + odd);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
