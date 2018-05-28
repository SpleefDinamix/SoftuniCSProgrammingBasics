using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(new String(' ', size) + " | ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(new String(' ', size - (size - i)));
                Console.Write(new String('*',size-i));
                Console.Write(" | ");
                Console.WriteLine(new String('*', size - i));
            }
        }
    }
}
