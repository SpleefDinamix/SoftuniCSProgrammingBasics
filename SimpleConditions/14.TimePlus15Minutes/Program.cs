using System;

namespace _14.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hr = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var timeInMunutes = hr * 60 + min + 15;
            hr = timeInMunutes / 60;
            min = timeInMunutes % 60;

            if (hr == 24)
            {
                hr = 0;
            }

            if (min < 10)
            {
                Console.WriteLine(hr + ":0" + min);
            }
            else
            {
                Console.WriteLine(hr + ":" + min);
            }
        }
    }
}
