using System;

namespace _09.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var days = new string[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            if (num > 0 && num <= days.Length)
            {
                Console.WriteLine(days[num - 1]);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
