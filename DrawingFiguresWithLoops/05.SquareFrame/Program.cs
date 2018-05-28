using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine()) - 2;

            FrameTopBottom(size);
            for (int i = 0; i < size; i++)
            {
                FrameMiddle(size);
            }
            FrameTopBottom(size);
        }

        public static void FrameMiddle(int size)
        {
            Console.Write("| ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("- ");
            }
            Console.Write("|");
            Console.WriteLine();
        }

        public static void FrameTopBottom(int size)
        {
            Console.Write("+ ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
