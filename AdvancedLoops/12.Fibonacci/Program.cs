using System;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main()
        {
            int stopIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciFunc(1,1,stopIndex));
        }
        public static int FibonacciFunc(int prevNum, int nextNumber, int stopIndex , int cycleIndex = 0)
        {
            if (cycleIndex == stopIndex)
            {
                return prevNum;
            }
            else
            {
                return FibonacciFunc(nextNumber, prevNum + nextNumber, stopIndex , cycleIndex + 1);
            }
        }
    }
}
