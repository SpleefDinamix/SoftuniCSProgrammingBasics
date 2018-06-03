using System;

namespace _09.SumDigits
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine();
            int sum = 0;

            foreach (var num in nums)
            {
                sum += num - 48;
            }

            Console.WriteLine(sum);
        }
    }
}
