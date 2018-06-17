using System;
using System.Globalization;

namespace _04.CatFood
{
    class Program
    {
        static void Main()
        {
            int smallCats = 0;
            int largeCats = 0;
            int giantCats = 0;

            int n = int.Parse(Console.ReadLine());
            double totalFood = 0d;

            for (int i = 0; i < n; i++)
            {
                double foodEaten = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (foodEaten >= 100 && foodEaten < 200)
                {
                    smallCats++;
                }
                else if (foodEaten >= 200 && foodEaten < 300)
                {
                    largeCats++;
                }
                else
                {
                    giantCats++;
                }

                totalFood += foodEaten;
            }

            decimal price = ((decimal)totalFood) / 1000m * 12.45m;

            Console.WriteLine("Group 1: {0} cats.", smallCats);
            Console.WriteLine("Group 2: {0} cats.", largeCats);
            Console.WriteLine("Group 3: {0} cats.", giantCats);
            Console.WriteLine("Price for food per day: {0:F2} lv.", price);
        }
    }
}
