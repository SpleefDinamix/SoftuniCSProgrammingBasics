using System;

namespace _06.HappyCatParking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalPrice = 0d;

            for (int i = 1; i <= days; i++)
            {
                double dayPrice = 0d;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        dayPrice += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        dayPrice += 1.25;
                    }
                    else
                    {
                        dayPrice += 1d;
                    }
                }
                totalPrice += dayPrice;
                Console.WriteLine("Day: {0} - {1:F2} leva", i, dayPrice);
            }
            Console.WriteLine("Total: {0:F2} leva", totalPrice);
        }
    }
}
