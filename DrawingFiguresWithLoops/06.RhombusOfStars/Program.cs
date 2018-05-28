using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int stars = 0;

            while (size > stars)
            {
                stars++;
                DrawRhombus(stars,size);
            }

            
            while (0 < stars-1)
            {
                stars--;
                DrawRhombus(stars,size);
            }
        }

        public static void DrawRhombus(int stars, int size)
        {
            Console.Write(new String(' ',size-stars));
            for (int i = 1; i <= stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
