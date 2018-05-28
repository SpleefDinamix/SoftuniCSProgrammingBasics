using System;

namespace _02.RectanglesOFNxNStars
{
    class Program
    {
        static void Main()
        {
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(new String('*',times));
            }
        }
    }
}
