using System;

namespace _04.WorkHours
{
    class Program
    {
        static void Main()
        {
            int estimatedWorkHours = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            var totalWorkHours = numOfWorkers * workDays * 8;

            if (estimatedWorkHours < totalWorkHours)
            {
                var hoursLeft = totalWorkHours - estimatedWorkHours;
                Console.WriteLine(hoursLeft + " hours left");
            }
            else
            {
                var overTime = estimatedWorkHours - totalWorkHours;
                var penalties = overTime * workDays;

                Console.WriteLine(overTime + " overtime");
                Console.WriteLine("Penalties: " + penalties);
            }
        }
    }
}
