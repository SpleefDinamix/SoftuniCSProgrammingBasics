using System;

namespace _08.Coins
{
    class Program
    {
        static void Main()
        {
            int coins = (int)(double.Parse(Console.ReadLine()) * 100);

            int hundreds = coins / 100;
            int tens = coins / 10 - hundreds * 10;
            int ones = coins - hundreds * 100 - tens * 10;

            int coinsCount = FindCoins(hundreds, 2, 1);
            coinsCount += FindCoins(tens, 5, 2, 1);
            coinsCount += FindCoins(ones, 5, 2, 1);

            Console.WriteLine(coinsCount);
        }

        public static int FindCoins(int hundreds, params int[] compared)
        {
            int coinsCount = 0;
            for (int i = 0; i < compared.Length; i++)
            {
                while (hundreds - compared[i] >= 0)
                {
                    hundreds -= compared[i];
                    coinsCount++;
                }
            }
            
            return coinsCount;
        }
    }
}
