using System;
using System.Linq;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            int[] pairSum = new int[readCycles];
            int[] diffs = new int[readCycles];

            for (int i = 0; i < readCycles; i++)
            {
                pairSum[i] = int.Parse(Console.ReadLine());
                pairSum[i] += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < pairSum.Length - 1; i++)
            {
                diffs[i] = Math.Abs(pairSum[i] - pairSum[i + 1]);
            }

            if (diffs.Sum() == 0)
            {
                Console.WriteLine("Yes, value=" + pairSum[0]);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + diffs.Max());
            }
        }
    }
}
