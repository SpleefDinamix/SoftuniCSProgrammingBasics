using System;

namespace _04.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var output = num1 > num2 ? num1 : num2;
            Console.WriteLine(output);
        }
    }
}
