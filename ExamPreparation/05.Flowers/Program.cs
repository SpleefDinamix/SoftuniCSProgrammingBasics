using System;

namespace _05.Flowers
{
    class Program
    {
        static void Main()
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();;

            double finalPrice = 0d;

            if (season == "Spring" || season == "Summer")
            {
                finalPrice = chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.50;
            }
            else
            {
                finalPrice = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
            }

            if (isHoliday == "Y")
            {
                finalPrice += finalPrice * 15d / 100d;
            }

            if (season == "Spring" && tulips > 7)
            {
                finalPrice -= finalPrice * 5d / 100d;
            }

            if (season == "Winter" && roses >= 10)
            {
                finalPrice -= finalPrice * 10d / 100d;
            }

            var flowersSum = chrysanthemums + roses + tulips;

            if (flowersSum > 20)
            {
                finalPrice -= finalPrice * 20d / 100d;
            }

            Console.WriteLine("{0:F2}",finalPrice + 2.00);
        }
    }
}
