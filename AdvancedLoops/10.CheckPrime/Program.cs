using System;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string result = "Prime";
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = "Not Prime";
                    break;
                }
            }

            if (num < 2)
            {
                result = "Not Prime";
            }

            Console.WriteLine(result);
        }
    }
}
