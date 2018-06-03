using System;

namespace _06.NumberInRange1To100
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Еnter a number in the range [1...100]:");
            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");

                Console.WriteLine("Еnter a number in the range [1...100]:");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + num);
        }
    }
}
