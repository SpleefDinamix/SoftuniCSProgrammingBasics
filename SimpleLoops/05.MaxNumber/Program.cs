using System;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCycles = int.Parse(Console.ReadLine());
            int biggerNum = int.MinValue;

            for (int i = 0; i < readCycles; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > biggerNum)
                {
                    biggerNum = num;
                }
            }
            Console.WriteLine(biggerNum);
        }
    }
}
