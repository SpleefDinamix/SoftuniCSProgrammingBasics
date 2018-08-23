using System;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = int.Parse(Console.ReadLine());
            var person2 = int.Parse(Console.ReadLine());
            var person3 = int.Parse(Console.ReadLine());

            var timeInSeconds = person1 + person2 + person3;
            int minutes = timeInSeconds / 60;
            int remainingSeconds = timeInSeconds % 60;

            if (remainingSeconds < 10)
            {
                Console.WriteLine(minutes + ":0" + remainingSeconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + remainingSeconds);
            }
        }
    }
}
