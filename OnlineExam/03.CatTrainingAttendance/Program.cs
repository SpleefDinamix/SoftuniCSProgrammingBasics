using System;

namespace _03.CatTrainingAttendance
{
    class Program
    {
        static void Main()
        {
            int lectureStartHour = int.Parse(Console.ReadLine());
            int catStartHour = int.Parse(Console.ReadLine());
            int catStartMinutes = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            var point = 0d;

            if (catStartHour == lectureStartHour - 1)
            {
                point = 1.5;
            }
            else if (catStartHour == lectureStartHour && catStartMinutes <= 30)
            {
                point = 1;
            }
            else
            {
                point = 0.5;
            }

            if (dayOfWeek == "Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Friday")
            {
                point += 0.6;
            }
            else if (dayOfWeek == "Sunday")
            {
                point += 2;
            }
            else
            {
                point += 0.8;
            }

            Console.WriteLine("{0:F2}",point);
        }
    }
}
