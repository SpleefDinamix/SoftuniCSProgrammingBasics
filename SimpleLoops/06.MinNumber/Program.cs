using System;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            int smallerNum = int.MaxValue;

            for (int i = 0; i < readCycles; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < smallerNum)
                {
                    smallerNum = num;
                }
            }
            Console.WriteLine(smallerNum);
        }
    }
}
