using System;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < readCycles; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < readCycles; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            int diff = Math.Abs(leftSum - rightSum);

            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
