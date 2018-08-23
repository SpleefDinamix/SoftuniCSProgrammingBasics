using System;
using System.Linq;


namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double bonusPoints = 0d;

            if (number % 2 == 0)
            {
                bonusPoints++;
            }

            if (number.ToString().Last() == '5')
            {
                bonusPoints += 2d;
            }

            if (number <= 100)
            {
                bonusPoints += 5d;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusPoints += number * 20d / 100d;
            }
            else if (number > 1000)
            {
                bonusPoints += number * 10d / 100d;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + number);
        }
    }
}
