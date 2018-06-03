using System;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter even number: ");
            int a;

            while (int.TryParse(Console.ReadLine(), out a) == false || a%2!=0)
            {
                    Console.WriteLine("The number is not even");
                    Console.Write("Enter even number: ");
            }

            Console.WriteLine($"Even number entered: {a}");
        }
    }
}
