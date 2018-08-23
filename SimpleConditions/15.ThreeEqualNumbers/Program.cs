using System;

namespace _15.ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            string areEqual = a == b ? a == c ? "yes" : "no" : "no";
            Console.WriteLine(areEqual);
        }
    }
}
