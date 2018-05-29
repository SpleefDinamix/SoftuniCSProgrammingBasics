using System;

namespace _09.House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int roofSize = (n + 1) / 2;
            int wallSize = n / 2 - 1;

            int stars = n % 2 == 0 ? 2 : 1 ;

            for (int i = 0; i < roofSize; i++)
            {
                var dashes = new String('-', (n - stars)/2);
                Console.WriteLine(dashes + new String('*',stars) + dashes);
                stars += 2;
            }

        }
    }
}
