using System;
using System.Linq;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            var nums = new int[readCycles];

            for (int i = 0; i < readCycles; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            if (nums.Max() == nums.Sum() - nums.Max())
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (nums.Sum() - nums.Max()));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(nums.Sum() - 2 * nums.Max()));
            }
        }
    }
}
