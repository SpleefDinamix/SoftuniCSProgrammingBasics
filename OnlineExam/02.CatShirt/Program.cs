using System;

namespace _02.CatShirt
{
    class Program
    {
        static void Main()
        {
            double sleave = double.Parse(Console.ReadLine());
            double frontPart = double.Parse(Console.ReadLine());
            string material = Console.ReadLine();
            string includeTie = Console.ReadLine();

            double shritArea = 2 * sleave + 2 * frontPart;
            shritArea += shritArea * 10 / 100;
            shritArea /= 100;

            var price = 0d;
            if (material == "Linen")
            {
                price = shritArea * 15 + 10;
            }
            else if (material == "Cotton")
            {
                price = shritArea * 12 + 10;
            }
            else if (material == "Denim")
            {
                price = shritArea * 20 + 10;
            }
            else if (material == "Twill")
            {
                price = shritArea * 16 + 10;
            }
            else if (material == "Flannel")
            {
                price = shritArea * 11 + 10;
            }

            if (includeTie == "Yes")
            {
                price += price * 20 / 100;
            }

            Console.WriteLine("The price of the shirt is: {0:F2}lv.", price);
        }
    }
}
